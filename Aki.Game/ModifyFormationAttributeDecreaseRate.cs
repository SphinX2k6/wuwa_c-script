using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F39 RID: 12089
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeDecreaseRate : BuffEffect
{
	// Token: 0x06019BDD RID: 105437 RVA: 0x006B5223 File Offset: 0x006B3423
	public ModifyFormationAttributeDecreaseRate(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BDE RID: 105438 RVA: 0x006B5232 File Offset: 0x006B3432
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019BDF RID: 105439 RVA: 0x006B5248 File Offset: 0x006B3448
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

	// Token: 0x06019BE0 RID: 105440 RVA: 0x006B52FD File Offset: 0x006B34FD
	public override void OnCreated()
	{
		if (this.AttributeId == null)
		{
			return;
		}
		if (this.CheckExecutable())
		{
			FormationAttributeController.Instance.AddSpeedModifier(this.ModifierHandle, this.AttributeId.Value, EModifierType.DecreaseModify, this.Rate, 100);
		}
	}

	// Token: 0x06019BE1 RID: 105441 RVA: 0x006B5339 File Offset: 0x006B3539
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BE2 RID: 105442 RVA: 0x006B533C File Offset: 0x006B353C
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

	// Token: 0x0400C212 RID: 49682
	protected EFormationAttributeId? AttributeId;

	// Token: 0x0400C213 RID: 49683
	protected float Rate;

	// Token: 0x0400C214 RID: 49684
	[Nullable(2)]
	protected string ModifierHandle;
}
