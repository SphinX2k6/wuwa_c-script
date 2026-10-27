using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F38 RID: 12088
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeIncreaseRate : BuffEffect
{
	// Token: 0x06019BD7 RID: 105431 RVA: 0x006B50D7 File Offset: 0x006B32D7
	public ModifyFormationAttributeIncreaseRate(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BD8 RID: 105432 RVA: 0x006B50E6 File Offset: 0x006B32E6
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019BD9 RID: 105433 RVA: 0x006B50FC File Offset: 0x006B32FC
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

	// Token: 0x06019BDA RID: 105434 RVA: 0x006B51B1 File Offset: 0x006B33B1
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

	// Token: 0x06019BDB RID: 105435 RVA: 0x006B51ED File Offset: 0x006B33ED
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BDC RID: 105436 RVA: 0x006B51F0 File Offset: 0x006B33F0
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

	// Token: 0x0400C20F RID: 49679
	protected EFormationAttributeId? AttributeId;

	// Token: 0x0400C210 RID: 49680
	protected float Rate;

	// Token: 0x0400C211 RID: 49681
	[Nullable(2)]
	protected string ModifierHandle;
}
