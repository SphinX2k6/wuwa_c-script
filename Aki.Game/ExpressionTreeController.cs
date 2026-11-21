using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;
using CSharpScript.Utils;

// Token: 0x02002A41 RID: 10817
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ExpressionTreeController : ControllerBase
{
	// Token: 0x0601B40C RID: 111628 RVA: 0x0085EC48 File Offset: 0x0085CE48
	public ExpressionTree GetDamageExpression(Damage damageData)
	{
		ExpressionTree expressionTree = ExpressionTreeModel.Instance.Get(damageData.Id);
		if (expressionTree != null)
		{
			return expressionTree;
		}
		ExpressionTree expressionTree2 = new ExpressionTree();
		ExpressionTree expressionTree3 = expressionTree2;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler.AppendLiteral("结算");
		defaultInterpolatedStringHandler.AppendFormatted<long>(damageData.Id);
		expressionTree3.Parse(defaultInterpolatedStringHandler.ToStringAndClear(), damageData.Condition, damageData.ConstVariables());
		ExpressionTreeModel.Instance.Add(damageData.Id, expressionTree2);
		return expressionTree2;
	}

	// Token: 0x0601B40D RID: 111629 RVA: 0x0085ECC4 File Offset: 0x0085CEC4
	public void DoDamageExpression(IExpressionContext context, Damage damageData, Entity attacker)
	{
		ExpressionTree damageExpression = this.GetDamageExpression(damageData);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = attacker;
		damageExpression.Evaluate(context, dictionary);
	}

	// Token: 0x0601B40E RID: 111630 RVA: 0x0085ECEC File Offset: 0x0085CEEC
	public long GetEffectDamageId(long damageId, Entity attacker)
	{
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		if (!string.IsNullOrEmpty((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Condition : null))
		{
			long replaceDamageId = 0L;
			this.DoDamageExpression(new ReplaceDamageContext
			{
				ContextType = EContextType.ReplaceDamage,
				DamageCb = delegate(long id)
				{
					replaceDamageId = id;
				}
			}, damageConfigById.Value, attacker);
			return replaceDamageId;
		}
		return damageId;
	}

	// Token: 0x0601B40F RID: 111631 RVA: 0x0085ED6C File Offset: 0x0085CF6C
	public bool ShouldPreResolveDamageIdByExecutionTiming(long damageId)
	{
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		return damageConfigById != null && damageConfigById.GetValueOrDefault().ExecutionTiming == 1 && !string.IsNullOrEmpty((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Condition : null);
	}

	// Token: 0x0601B410 RID: 111632 RVA: 0x0085EDCC File Offset: 0x0085CFCC
	public bool CheckReplaceDamageWhenHit(long damageId)
	{
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		return (damageConfigById == null || damageConfigById.GetValueOrDefault().ExecutionTiming != 0) && !string.IsNullOrEmpty((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Condition : null);
	}

	// Token: 0x17002C71 RID: 11377
	// (get) Token: 0x0601B411 RID: 111633 RVA: 0x0085EE2A File Offset: 0x0085D02A
	public static ExpressionTreeController Instance
	{
		get
		{
			return ExpressionTreeController._Instance;
		}
	}

	// Token: 0x0601B412 RID: 111634 RVA: 0x0085EE31 File Offset: 0x0085D031
	public static ExpressionTreeController GetOrCreateInstance()
	{
		if (ExpressionTreeController._Instance == null)
		{
			ExpressionTreeController.CreateInstance();
		}
		return ExpressionTreeController._Instance;
	}

	// Token: 0x0601B413 RID: 111635 RVA: 0x0085EE45 File Offset: 0x0085D045
	public static bool CreateInstance()
	{
		if (ExpressionTreeController._Instance != null)
		{
			return true;
		}
		ExpressionTreeController._Instance = new ExpressionTreeController();
		return true;
	}

	// Token: 0x0601B414 RID: 111636 RVA: 0x0085EE5B File Offset: 0x0085D05B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B415 RID: 111637 RVA: 0x0085EE5D File Offset: 0x0085D05D
	public static void ResetStaticDefaultValue()
	{
		ExpressionTreeController._Instance = null;
	}

	// Token: 0x0601B416 RID: 111638 RVA: 0x0085EE65 File Offset: 0x0085D065
	static ExpressionTreeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExpressionTreeController.CreateStaticDefaultValue), new Action(ExpressionTreeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECA5 RID: 60581
	private readonly Stat GetExpressionStat = Stat.Create("GetDamageExpression", "", "");

	// Token: 0x0400ECA6 RID: 60582
	private readonly Stat DoExpressionStat = Stat.Create("DoDamageExpression", "", "");

	// Token: 0x0400ECA7 RID: 60583
	[Nullable(2)]
	private static ExpressionTreeController _Instance;
}
