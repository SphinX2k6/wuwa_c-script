using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F9B RID: 12187
[NullableContext(1)]
[Nullable(0)]
public class StartBattleQte : PeriodExecution
{
	// Token: 0x06019DCC RID: 105932 RVA: 0x006C1B8F File Offset: 0x006BFD8F
	public StartBattleQte(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DCD RID: 105933 RVA: 0x006C1B98 File Offset: 0x006BFD98
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.BattleQteId = new int?(int.Parse(extraEffectParameters_[0]));
		}
	}

	// Token: 0x06019DCE RID: 105934 RVA: 0x006C1BC8 File Offset: 0x006BFDC8
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

	// Token: 0x06019DCF RID: 105935 RVA: 0x006C1C90 File Offset: 0x006BFE90
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 触发战斗QTE");
		defaultInterpolatedStringHandler.AppendFormatted<int?>(this.BattleQteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C372 RID: 50034
	protected int? BattleQteId;
}
