using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248B RID: 9355
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeIncreaseRate : BuffEffect
{
	// Token: 0x060174E2 RID: 95458 RVA: 0x006DB3FF File Offset: 0x006D95FF
	public ModifyFormationAttributeIncreaseRate(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174E3 RID: 95459 RVA: 0x006DB40E File Offset: 0x006D960E
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060174E4 RID: 95460 RVA: 0x006DB424 File Offset: 0x006D9624
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0 || string.IsNullOrEmpty(extraEffectParameters_[0]))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "SetFormationAttributeRate参数错误，没有合法的队伍属性id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AttributeId = new EFormationAttributeId?((EFormationAttributeId)int.Parse(extraEffectParameters_[0]));
		this.Rate = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
		this.ModifierHandle = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060174E5 RID: 95461 RVA: 0x006DB4D9 File Offset: 0x006D96D9
	public override void OnCreated()
	{
		if (this.AttributeId == null)
		{
			return;
		}
		if (this.CheckExecutable())
		{
			FormationAttributeController.Instance.AddSpeedModifier(this.ModifierHandle, this.AttributeId.Value, EModifierType.IncreaseModify, this.Rate, 100);
		}
	}

	// Token: 0x060174E6 RID: 95462 RVA: 0x006DB515 File Offset: 0x006D9715
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060174E7 RID: 95463 RVA: 0x006DB518 File Offset: 0x006D9718
	public override void OnRemoved(bool bPremature)
	{
		if (this.AttributeId == null)
		{
			return;
		}
		if (this.CheckExecutable())
		{
			FormationAttributeController.Instance.RemoveSpeedModifier(this.ModifierHandle, this.AttributeId.Value);
		}
	}

	// Token: 0x0400C5B1 RID: 50609
	protected EFormationAttributeId? AttributeId;

	// Token: 0x0400C5B2 RID: 50610
	protected float Rate;

	// Token: 0x0400C5B3 RID: 50611
	[Nullable(2)]
	protected string ModifierHandle;
}
