using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Utils
{
	// Token: 0x0200451A RID: 17690
	[NullableContext(1)]
	[Nullable(0)]
	public class ExpressionTreeModel : ModelBase
	{
		// Token: 0x0602D841 RID: 186433 RVA: 0x00A45D6C File Offset: 0x00A43F6C
		protected override bool OnInit()
		{
			this._builtinFunc["EntityTagContainer"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				Entity entity;
				if (args.Length < 1 || !args[0].TryGetEntity(out entity) || entity == null)
				{
					ExpressionTreeModel.AddContextError(context, "EntityTagContainer函数执行失败: entity为空");
					return default(TFormulaValue);
				}
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					return TFormulaValue.FromTagContainer(component.TagContainer);
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("获取实体TagContainer失败 实体ID");
				defaultInterpolatedStringHandler.AppendFormatted<int>(entity.Id);
				ExpressionTreeModel.AddContextError(context, defaultInterpolatedStringHandler.ToStringAndClear());
				return default(TFormulaValue);
			};
			this._builtinFunc["GetAttr"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				Entity entity;
				if (args.Length < 2 || !args[0].TryGetEntity(out entity) || entity == null)
				{
					ExpressionTreeModel.AddContextError(context, "GetAttr函数执行失败: entity为空或不是有效实体");
					return TFormulaValue.FromDouble(0.0);
				}
				int num;
				if (!args[1].TryGetInt(out num))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
					defaultInterpolatedStringHandler.AppendLiteral("GetAttr函数执行失败: attrId不合法 ");
					defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(args[1]);
					ExpressionTreeModel.AddContextError(context, defaultInterpolatedStringHandler.ToStringAndClear());
					return TFormulaValue.FromDouble(0.0);
				}
				EAttributeType eattributeType = (EAttributeType)num;
				if (eattributeType <= EAttributeType.None || num >= 143)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
					defaultInterpolatedStringHandler.AppendLiteral("GetAttr函数执行失败: attrId不合法 ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					ExpressionTreeModel.AddContextError(context, defaultInterpolatedStringHandler.ToStringAndClear());
					return TFormulaValue.FromDouble(0.0);
				}
				BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
				if (component == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
					defaultInterpolatedStringHandler.AppendLiteral("GetAttr函数执行失败: 获取实体属性组件失败 实体ID");
					defaultInterpolatedStringHandler.AppendFormatted<int>(entity.Id);
					ExpressionTreeModel.AddContextError(context, defaultInterpolatedStringHandler.ToStringAndClear());
					return TFormulaValue.FromDouble(0.0);
				}
				return TFormulaValue.FromDouble(Math.Floor((double)component.GetCurrentValue(eattributeType)));
			};
			this._builtinFunc["HasAnyTag"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				TagContainer tagContainer;
				TagContainer tagContainer2;
				if (args.Length < 2 || !args[0].TryGetTagContainer(out tagContainer) || !args[1].TryGetTagContainer(out tagContainer2) || tagContainer == null || tagContainer2 == null)
				{
					ExpressionTreeModel.AddContextError(context, "HasAnyTag函数执行失败: tagContainerA为空");
					return TFormulaValue.FromBool(false);
				}
				return TFormulaValue.FromBool(tagContainer.HasAnyTag(tagContainer2));
			};
			this._builtinFunc["HasAllTag"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				TagContainer tagContainer;
				TagContainer tagContainer2;
				if (args.Length < 2 || !args[0].TryGetTagContainer(out tagContainer) || !args[1].TryGetTagContainer(out tagContainer2) || tagContainer == null || tagContainer2 == null)
				{
					ExpressionTreeModel.AddContextError(context, "HasAllTag函数执行失败: tagContainerA为空");
					return TFormulaValue.FromBool(false);
				}
				return TFormulaValue.FromBool(tagContainer.HasAllTag(tagContainer2));
			};
			this._builtinFunc["ExecDamage"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				double num;
				if (args.Length < 1 || !args[0].TryGetDouble(out num))
				{
					ExpressionTreeModel.AddContextError(context, "ExecDamage函数执行失败: damageId为空");
					return TFormulaValue.FromBool(false);
				}
				long num2 = (long)num;
				BulletDamageContext bulletDamageContext = context as BulletDamageContext;
				if (bulletDamageContext != null)
				{
					bulletDamageContext.DamageParam.DamageDataId = num2;
					BulletDamageResult bulletDamageResult = bulletDamageContext.Victim.ExecuteBulletDamage(bulletDamageContext.BulletEntityId, bulletDamageContext.DamageParam, bulletDamageContext.ContextId);
					BulletDamageResult result = bulletDamageContext.Result;
					result.ToughResult += bulletDamageResult.ToughResult;
					result.IsAddEnergy = (result.IsAddEnergy || bulletDamageResult.IsAddEnergy);
					return TFormulaValue.FromBool(true);
				}
				BuffDamageContext buffDamageContext = context as BuffDamageContext;
				if (buffDamageContext != null)
				{
					buffDamageContext.DamageParam.DamageDataId = num2;
					buffDamageContext.Victim.ExecuteBuffDamage(buffDamageContext.DamageParam, buffDamageContext.Payload, buffDamageContext.ContextId);
					return TFormulaValue.FromBool(true);
				}
				BuffShareDamageContext buffShareDamageContext = context as BuffShareDamageContext;
				if (buffShareDamageContext != null)
				{
					buffShareDamageContext.DamageParam.DamageDataId = num2;
					buffShareDamageContext.Victim.ExecuteBuffShareDamage(buffShareDamageContext.DamageParam, buffShareDamageContext.Payload, buffShareDamageContext.ExtraRate, buffShareDamageContext.ContextId);
					return TFormulaValue.FromBool(true);
				}
				ReplaceDamageContext replaceDamageContext = context as ReplaceDamageContext;
				if (replaceDamageContext != null)
				{
					replaceDamageContext.DamageCb(num2);
					return TFormulaValue.FromBool(true);
				}
				return TFormulaValue.FromBool(false);
			};
			this._builtinFunc["NotHasAnyTag"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				TagContainer tagContainer;
				TagContainer tagContainer2;
				if (args.Length < 2 || !args[0].TryGetTagContainer(out tagContainer) || !args[1].TryGetTagContainer(out tagContainer2) || tagContainer == null || tagContainer2 == null)
				{
					ExpressionTreeModel.AddContextError(context, "NotHasAnyTag函数执行失败: tagContainerA为空");
					return TFormulaValue.FromBool(false);
				}
				return TFormulaValue.FromBool(tagContainer.NotHasAnyTag(tagContainer2));
			};
			this._builtinFunc["NotHasAllTag"] = delegate(IExpressionContext context, TFormulaValue[] args)
			{
				TagContainer tagContainer;
				TagContainer tagContainer2;
				if (args.Length < 2 || !args[0].TryGetTagContainer(out tagContainer) || !args[1].TryGetTagContainer(out tagContainer2) || tagContainer == null || tagContainer2 == null)
				{
					ExpressionTreeModel.AddContextError(context, "NotHasAllTag函数执行失败: tagContainerA为空");
					return TFormulaValue.FromBool(false);
				}
				return TFormulaValue.FromBool(tagContainer.NotHasAllTag(tagContainer2));
			};
			return base.OnInit();
		}

		// Token: 0x0602D842 RID: 186434 RVA: 0x00A45EC8 File Offset: 0x00A440C8
		protected override bool OnClear()
		{
			this._expressionCache.Clear();
			return base.OnClear();
		}

		// Token: 0x0602D843 RID: 186435 RVA: 0x00A45EDC File Offset: 0x00A440DC
		[NullableContext(2)]
		public ExpressionTree Get(long damageId)
		{
			ExpressionTree result;
			this._expressionCache.TryGetValue(damageId, out result);
			return result;
		}

		// Token: 0x0602D844 RID: 186436 RVA: 0x00A45EFC File Offset: 0x00A440FC
		public void Add(long damageId, ExpressionTree expression)
		{
			this._expressionCache[damageId] = expression;
			if (this._expressionCache.Count > 100)
			{
				using (Dictionary<long, ExpressionTree>.KeyCollection.Enumerator enumerator = this._expressionCache.Keys.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						this._expressionCache.Remove(enumerator.Current);
					}
				}
			}
		}

		// Token: 0x0602D845 RID: 186437 RVA: 0x00A45F74 File Offset: 0x00A44174
		public void Remove(long damageId)
		{
			this._expressionCache.Remove(damageId);
		}

		// Token: 0x0602D846 RID: 186438 RVA: 0x00A45F84 File Offset: 0x00A44184
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<IExpressionContext, TFormulaValue[], TFormulaValue> GetBuiltinFunc(string funcName)
		{
			Func<IExpressionContext, TFormulaValue[], TFormulaValue> result;
			if (this._builtinFunc.TryGetValue(funcName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0602D847 RID: 186439 RVA: 0x00A45FA4 File Offset: 0x00A441A4
		private static void AddContextError([Nullable(2)] IExpressionContext context, string error)
		{
			BaseContext baseContext = context as BaseContext;
			if (baseContext == null)
			{
				return;
			}
			BaseContext baseContext2 = baseContext;
			if (baseContext2.ErrorMsg == null)
			{
				baseContext2.ErrorMsg = new List<string>();
			}
			baseContext.ErrorMsg.Add(error);
		}

		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x0602D848 RID: 186440 RVA: 0x00A45FDD File Offset: 0x00A441DD
		public static ExpressionTreeModel Instance
		{
			get
			{
				return ExpressionTreeModel._Instance;
			}
		}

		// Token: 0x0602D849 RID: 186441 RVA: 0x00A45FE4 File Offset: 0x00A441E4
		public static ExpressionTreeModel GetOrCreateInstance()
		{
			if (ExpressionTreeModel._Instance == null)
			{
				ExpressionTreeModel.CreateInstance();
			}
			return ExpressionTreeModel._Instance;
		}

		// Token: 0x0602D84A RID: 186442 RVA: 0x00A45FF8 File Offset: 0x00A441F8
		public static bool CreateInstance()
		{
			if (ExpressionTreeModel._Instance != null)
			{
				return true;
			}
			ExpressionTreeModel._Instance = new ExpressionTreeModel();
			return true;
		}

		// Token: 0x0602D84B RID: 186443 RVA: 0x00A4600E File Offset: 0x00A4420E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D84C RID: 186444 RVA: 0x00A46010 File Offset: 0x00A44210
		public static void ResetStaticDefaultValue()
		{
			ExpressionTreeModel._Instance = null;
		}

		// Token: 0x0602D84D RID: 186445 RVA: 0x00A46018 File Offset: 0x00A44218
		static ExpressionTreeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExpressionTreeModel.CreateStaticDefaultValue), new Action(ExpressionTreeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401855F RID: 99679
		private const int DAMAGE_EXPRESSION_CACHE = 100;

		// Token: 0x04018560 RID: 99680
		private readonly Dictionary<long, ExpressionTree> _expressionCache = new Dictionary<long, ExpressionTree>();

		// Token: 0x04018561 RID: 99681
		private readonly Dictionary<string, Func<IExpressionContext, TFormulaValue[], TFormulaValue>> _builtinFunc = new Dictionary<string, Func<IExpressionContext, TFormulaValue[], TFormulaValue>>();

		// Token: 0x04018562 RID: 99682
		[Nullable(2)]
		private static ExpressionTreeModel _Instance;
	}
}
