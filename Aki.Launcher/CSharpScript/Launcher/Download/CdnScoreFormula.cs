using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F4 RID: 500
	[NullableContext(1)]
	[Nullable(0)]
	public static class CdnScoreFormula
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x0004E768 File Offset: 0x0004C968
		public static CdnScoreSelectionResult Select([Nullable(2)] ICdnScoreCfg cfg)
		{
			if (cfg == null || cfg.Candidates == null)
			{
				return new CdnScoreSelectionResult
				{
					Reason = "no_config"
				};
			}
			if (cfg.Candidates.Count == 0)
			{
				return new CdnScoreSelectionResult
				{
					Reason = "empty_candidates"
				};
			}
			if (string.IsNullOrEmpty(cfg.UsedCandidate))
			{
				return new CdnScoreSelectionResult
				{
					Reason = "no_config"
				};
			}
			ICdnScoreFormula cdnScoreFormula = null;
			for (int i = 0; i < cfg.Candidates.Count; i++)
			{
				ICdnScoreFormula cdnScoreFormula2 = cfg.Candidates[i];
				if (cdnScoreFormula2 != null && cdnScoreFormula2.Name == cfg.UsedCandidate)
				{
					cdnScoreFormula = cdnScoreFormula2;
					break;
				}
			}
			if (cdnScoreFormula == null)
			{
				return new CdnScoreSelectionResult
				{
					Reason = "used_not_found:" + cfg.UsedCandidate
				};
			}
			string text = CdnScoreFormula.Validate(cdnScoreFormula);
			if (!(text == "ok"))
			{
				return new CdnScoreSelectionResult
				{
					Reason = text
				};
			}
			return new CdnScoreSelectionResult
			{
				Formula = cdnScoreFormula,
				Reason = "ok"
			};
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0004E864 File Offset: 0x0004CA64
		public static string Validate(ICdnScoreFormula formula)
		{
			if (string.IsNullOrEmpty(formula.Name) || string.IsNullOrEmpty(formula.Output))
			{
				return "bad_shape";
			}
			if (formula.Order != "asc" && formula.Order != "desc")
			{
				return "bad_order";
			}
			if (formula.Steps == null)
			{
				return "bad_steps";
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (ICdnScoreStep cdnScoreStep in formula.Steps)
			{
				if (cdnScoreStep == null)
				{
					return "bad_step";
				}
				if (string.IsNullOrEmpty(cdnScoreStep.Let) || !hashSet.Add(cdnScoreStep.Let))
				{
					return "bad_let:" + cdnScoreStep.Let;
				}
				if (!CdnScoreFormula.IsSupportedOp(cdnScoreStep.Op))
				{
					return "bad_op:" + cdnScoreStep.Op;
				}
				if (cdnScoreStep.Op != "neg" && cdnScoreStep.B == null)
				{
					return "missing_b:" + cdnScoreStep.Let;
				}
			}
			return "ok";
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0004E9AC File Offset: 0x0004CBAC
		public static CdnScoreEvalResult Evaluate(ICdnScoreFormula formula, IReadOnlyDictionary<string, double> vars)
		{
			Dictionary<string, double> dictionary = new Dictionary<string, double>();
			foreach (ICdnScoreStep cdnScoreStep in formula.Steps)
			{
				if (vars.ContainsKey(cdnScoreStep.Let))
				{
					return CdnScoreFormula.Error("duplicate_let:" + cdnScoreStep.Let);
				}
				CdnScoreEvalResult cdnScoreEvalResult = CdnScoreFormula.ResolveOperand(cdnScoreStep.A, dictionary, vars);
				if (cdnScoreEvalResult.Error != null)
				{
					return cdnScoreEvalResult;
				}
				CdnScoreEvalResult cdnScoreEvalResult2;
				if (cdnScoreStep.B == null)
				{
					(cdnScoreEvalResult2 = new CdnScoreEvalResult()).Value = new double?(0.0);
				}
				else
				{
					cdnScoreEvalResult2 = CdnScoreFormula.ResolveOperand(cdnScoreStep.B.Value, dictionary, vars);
				}
				CdnScoreEvalResult cdnScoreEvalResult3 = cdnScoreEvalResult2;
				if (cdnScoreEvalResult3.Error != null)
				{
					return cdnScoreEvalResult3;
				}
				CdnScoreEvalResult cdnScoreEvalResult4 = CdnScoreFormula.ApplyOp(cdnScoreStep.Op, cdnScoreEvalResult.Value.Value, cdnScoreEvalResult3.Value.Value);
				if (cdnScoreEvalResult4.Error != null)
				{
					return cdnScoreEvalResult4;
				}
				if (!double.IsFinite(cdnScoreEvalResult4.Value.Value))
				{
					return CdnScoreFormula.Error("non_finite");
				}
				dictionary[cdnScoreStep.Let] = cdnScoreEvalResult4.Value.Value;
			}
			double num;
			if (!dictionary.TryGetValue(formula.Output, out num) && !vars.TryGetValue(formula.Output, out num))
			{
				return CdnScoreFormula.Error("missing_output:" + formula.Output);
			}
			if (!double.IsFinite(num))
			{
				return CdnScoreFormula.Error("non_finite");
			}
			return new CdnScoreEvalResult
			{
				Value = new double?(num)
			};
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0004EB7C File Offset: 0x0004CD7C
		private static CdnScoreEvalResult ResolveOperand(JsonElement operand, IReadOnlyDictionary<string, double> env, IReadOnlyDictionary<string, double> vars)
		{
			double value;
			if (operand.ValueKind == JsonValueKind.Number && operand.TryGetDouble(out value))
			{
				return new CdnScoreEvalResult
				{
					Value = new double?(value)
				};
			}
			if (operand.ValueKind != JsonValueKind.String)
			{
				return CdnScoreFormula.Error("bad_operand");
			}
			string text = operand.GetString() ?? string.Empty;
			double value2;
			if (env.TryGetValue(text, out value2))
			{
				return new CdnScoreEvalResult
				{
					Value = new double?(value2)
				};
			}
			double value3;
			if (vars.TryGetValue(text, out value3))
			{
				return new CdnScoreEvalResult
				{
					Value = new double?(value3)
				};
			}
			return CdnScoreFormula.Error("missing_operand:" + text);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0004EC20 File Offset: 0x0004CE20
		private static CdnScoreEvalResult ApplyOp(string op, double a, double b)
		{
			if (op == "div" && b == 0.0)
			{
				return CdnScoreFormula.Error("divide_by_zero");
			}
			double num;
			if (op != null)
			{
				int length = op.Length;
				if (length != 2)
				{
					if (length == 3)
					{
						char c = op[2];
						if (c <= 'l')
						{
							switch (c)
							{
							case 'b':
								if (op == "sub")
								{
									num = a - b;
									goto IL_1D0;
								}
								break;
							case 'c':
							case 'f':
								break;
							case 'd':
								if (op == "add")
								{
									num = a + b;
									goto IL_1D0;
								}
								break;
							case 'e':
								if (op == "gte")
								{
									num = (a >= b);
									goto IL_1D0;
								}
								if (op == "lte")
								{
									num = (a <= b);
									goto IL_1D0;
								}
								break;
							case 'g':
								if (op == "neg")
								{
									num = -a;
									goto IL_1D0;
								}
								break;
							default:
								if (c == 'l')
								{
									if (op == "mul")
									{
										num = a * b;
										goto IL_1D0;
									}
								}
								break;
							}
						}
						else if (c != 'n')
						{
							if (c != 'v')
							{
								if (c == 'x')
								{
									if (op == "max")
									{
										num = Math.Max(a, b);
										goto IL_1D0;
									}
								}
							}
							else if (op == "div")
							{
								num = a / b;
								goto IL_1D0;
							}
						}
						else if (op == "min")
						{
							num = Math.Min(a, b);
							goto IL_1D0;
						}
					}
				}
				else
				{
					char c = op[0];
					if (c != 'g')
					{
						if (c == 'l')
						{
							if (op == "lt")
							{
								num = (a < b);
								goto IL_1D0;
							}
						}
					}
					else if (op == "gt")
					{
						num = (a > b);
						goto IL_1D0;
					}
				}
			}
			num = double.NaN;
			IL_1D0:
			double value = num;
			return new CdnScoreEvalResult
			{
				Value = new double?(value)
			};
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0004EE10 File Offset: 0x0004D010
		private static CdnScoreEvalResult Error(string error)
		{
			return new CdnScoreEvalResult
			{
				Error = error
			};
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0004EE20 File Offset: 0x0004D020
		private static bool IsSupportedOp(string op)
		{
			if (op != null)
			{
				int length = op.Length;
				if (length != 2)
				{
					if (length != 3)
					{
						goto IL_138;
					}
					char c = op[2];
					if (c <= 'l')
					{
						switch (c)
						{
						case 'b':
							if (!(op == "sub"))
							{
								goto IL_138;
							}
							break;
						case 'c':
						case 'f':
							goto IL_138;
						case 'd':
							if (!(op == "add"))
							{
								goto IL_138;
							}
							break;
						case 'e':
							if (!(op == "gte") && !(op == "lte"))
							{
								goto IL_138;
							}
							break;
						case 'g':
							if (!(op == "neg"))
							{
								goto IL_138;
							}
							break;
						default:
							if (c != 'l')
							{
								goto IL_138;
							}
							if (!(op == "mul"))
							{
								goto IL_138;
							}
							break;
						}
					}
					else if (c != 'n')
					{
						if (c != 'v')
						{
							if (c != 'x')
							{
								goto IL_138;
							}
							if (!(op == "max"))
							{
								goto IL_138;
							}
						}
						else if (!(op == "div"))
						{
							goto IL_138;
						}
					}
					else if (!(op == "min"))
					{
						goto IL_138;
					}
				}
				else
				{
					char c = op[0];
					if (c != 'g')
					{
						if (c != 'l')
						{
							goto IL_138;
						}
						if (!(op == "lt"))
						{
							goto IL_138;
						}
					}
					else if (!(op == "gt"))
					{
						goto IL_138;
					}
				}
				return true;
			}
			IL_138:
			return false;
		}

		// Token: 0x04000805 RID: 2053
		public const string Ok = "ok";

		// Token: 0x04000806 RID: 2054
		public const string ClientBuiltinFormulaName = "client_builtin";
	}
}
