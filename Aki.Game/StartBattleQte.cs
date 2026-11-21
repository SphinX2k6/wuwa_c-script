using System;
using System.Runtime.CompilerServices;

// Token: 0x020024EF RID: 9455
[NullableContext(1)]
[Nullable(0)]
public class StartBattleQte : PeriodExecution
{
	// Token: 0x060176DE RID: 95966 RVA: 0x006E8457 File Offset: 0x006E6657
	public StartBattleQte(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176DF RID: 95967 RVA: 0x006E8460 File Offset: 0x006E6660
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.BattleQteId = new int?(int.Parse(extraEffectParameters_[0]));
		}
	}

	// Token: 0x060176E0 RID: 95968 RVA: 0x006E8490 File Offset: 0x006E6690
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		if (this.BattleQteId == null)
		{
			return null;
		}
		IActiveBuff buff = this.Buff;
		Entity entity = (buff != null) ? buff.GetOwner() : null;
		bool flag;
		if (entity == null)
		{
			flag = true;
		}
		else
		{
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			flag = !((component != null) ? new bool?(component.IsAutonomousProxy) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return null;
		}
		CharacterModel instance = CharacterModel.Instance;
		IActiveBuff buff2 = this.Buff;
		EntityHandle handleByEntity = instance.GetHandleByEntity((buff2 != null) ? buff2.GetInstigator() : null);
		IActiveBuff buff3 = this.Buff;
		long? num = (buff3 != null) ? buff3.MessageId : null;
		if (handleByEntity != null && num != null)
		{
			BattleQteController.Instance.StartBattleQte(this.BattleQteId.Value, num.Value, handleByEntity, EBattleQteSource.Buff);
		}
		return null;
	}

	// Token: 0x060176E1 RID: 95969 RVA: 0x006E8558 File Offset: 0x006E6758
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 触发战斗QTE");
		defaultInterpolatedStringHandler.AppendFormatted<int?>(this.BattleQteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C71B RID: 50971
	protected int? BattleQteId;
}
