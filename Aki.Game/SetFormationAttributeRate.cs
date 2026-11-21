using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248A RID: 9354
[NullableContext(1)]
[Nullable(0)]
public class SetFormationAttributeRate : BuffEffect
{
	// Token: 0x060174DC RID: 95452 RVA: 0x006DB2B4 File Offset: 0x006D94B4
	public SetFormationAttributeRate(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174DD RID: 95453 RVA: 0x006DB2C3 File Offset: 0x006D94C3
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060174DE RID: 95454 RVA: 0x006DB2D8 File Offset: 0x006D94D8
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

	// Token: 0x060174DF RID: 95455 RVA: 0x006DB38D File Offset: 0x006D958D
	public override void OnCreated()
	{
		if (this.AttributeId == null)
		{
			return;
		}
		if (this.CheckExecutable())
		{
			FormationAttributeController.Instance.AddSpeedModifier(this.ModifierHandle, this.AttributeId.Value, EModifierType.Override, this.Rate, 100);
		}
	}

	// Token: 0x060174E0 RID: 95456 RVA: 0x006DB3C9 File Offset: 0x006D95C9
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060174E1 RID: 95457 RVA: 0x006DB3CC File Offset: 0x006D95CC
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

	// Token: 0x0400C5AE RID: 50606
	protected EFormationAttributeId? AttributeId;

	// Token: 0x0400C5AF RID: 50607
	protected float Rate;

	// Token: 0x0400C5B0 RID: 50608
	[Nullable(2)]
	protected string ModifierHandle;
}
