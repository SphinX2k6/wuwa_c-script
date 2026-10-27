using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F37 RID: 12087
[NullableContext(1)]
[Nullable(0)]
public class SetFormationAttributeRate : BuffEffect
{
	// Token: 0x06019BD1 RID: 105425 RVA: 0x006B4F8C File Offset: 0x006B318C
	public SetFormationAttributeRate(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BD2 RID: 105426 RVA: 0x006B4F9B File Offset: 0x006B319B
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019BD3 RID: 105427 RVA: 0x006B4FB0 File Offset: 0x006B31B0
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

	// Token: 0x06019BD4 RID: 105428 RVA: 0x006B5065 File Offset: 0x006B3265
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

	// Token: 0x06019BD5 RID: 105429 RVA: 0x006B50A1 File Offset: 0x006B32A1
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BD6 RID: 105430 RVA: 0x006B50A4 File Offset: 0x006B32A4
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

	// Token: 0x0400C20C RID: 49676
	protected EFormationAttributeId? AttributeId;

	// Token: 0x0400C20D RID: 49677
	protected float Rate;

	// Token: 0x0400C20E RID: 49678
	[Nullable(2)]
	protected string ModifierHandle;
}
