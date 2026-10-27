using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.World.Model;
using CSharpScript.Utils;

// Token: 0x020034CD RID: 13517
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ExpressionTreeController : ControllerBase
{
	// Token: 0x0601D70D RID: 120589 RVA: 0x008377A0 File Offset: 0x008359A0
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

	// Token: 0x0601D70E RID: 120590 RVA: 0x0083781C File Offset: 0x00835A1C
	public void DoDamageExpression(IExpressionContext context, Damage damageData, Entity attacker)
	{
		ExpressionTree damageExpression = this.GetDamageExpression(damageData);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = attacker;
		damageExpression.Evaluate(context, dictionary);
	}

	// Token: 0x0601D70F RID: 120591 RVA: 0x00837844 File Offset: 0x00835A44
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

	// Token: 0x0601D710 RID: 120592 RVA: 0x008378C4 File Offset: 0x00835AC4
	public bool ShouldPreResolveDamageIdByExecutionTiming(long damageId)
	{
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		return damageConfigById != null && damageConfigById.GetValueOrDefault().ExecutionTiming == 1 && !string.IsNullOrEmpty((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Condition : null);
	}

	// Token: 0x0601D711 RID: 120593 RVA: 0x00837924 File Offset: 0x00835B24
	public bool CheckReplaceDamageWhenHit(long damageId)
	{
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		return (damageConfigById == null || damageConfigById.GetValueOrDefault().ExecutionTiming != 0) && !string.IsNullOrEmpty((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Condition : null);
	}

	// Token: 0x170028D9 RID: 10457
	// (get) Token: 0x0601D712 RID: 120594 RVA: 0x00837982 File Offset: 0x00835B82
	public static ExpressionTreeController Instance
	{
		get
		{
			return ExpressionTreeController._Instance;
		}
	}

	// Token: 0x0601D713 RID: 120595 RVA: 0x00837989 File Offset: 0x00835B89
	public static ExpressionTreeController GetOrCreateInstance()
	{
		if (ExpressionTreeController._Instance == null)
		{
			ExpressionTreeController.CreateInstance();
		}
		return ExpressionTreeController._Instance;
	}

	// Token: 0x0601D714 RID: 120596 RVA: 0x0083799D File Offset: 0x00835B9D
	public static bool CreateInstance()
	{
		if (ExpressionTreeController._Instance != null)
		{
			return true;
		}
		ExpressionTreeController._Instance = new ExpressionTreeController();
		return true;
	}

	// Token: 0x0601D715 RID: 120597 RVA: 0x008379B3 File Offset: 0x00835BB3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D716 RID: 120598 RVA: 0x008379B5 File Offset: 0x00835BB5
	public static void ResetStaticDefaultValue()
	{
		ExpressionTreeController._Instance = null;
	}

	// Token: 0x0601D717 RID: 120599 RVA: 0x008379BD File Offset: 0x00835BBD
	static ExpressionTreeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExpressionTreeController.CreateStaticDefaultValue), new Action(ExpressionTreeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E7F1 RID: 59377
	private readonly Stat GetExpressionStat = Stat.Create("GetDamageExpression", "", "");

	// Token: 0x0400E7F2 RID: 59378
	private readonly Stat DoExpressionStat = Stat.Create("DoDamageExpression", "", "");

	// Token: 0x0400E7F3 RID: 59379
	[Nullable(2)]
	private static ExpressionTreeController _Instance;
}
