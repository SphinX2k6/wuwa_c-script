using System;
using System.Runtime.CompilerServices;

// Token: 0x020024F7 RID: 9463
[NullableContext(1)]
[Nullable(0)]
public class ModifyTeamMemberBuff : PeriodExecution
{
	// Token: 0x060176F2 RID: 95986 RVA: 0x006E8D9F File Offset: 0x006E6F9F
	public ModifyTeamMemberBuff(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176F3 RID: 95987 RVA: 0x006E8DBC File Offset: 0x006E6FBC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.MemberType = ETeamMemberType.Self;
			this.AddBuff = true;
			this.BuffIds = Array.Empty<long>();
			return;
		}
		this.MemberType = (ETeamMemberType)((extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0]) : 0);
		this.AddBuff = (extraEffectParameters_.Length <= 1 || int.Parse(extraEffectParameters_[1]) == 0);
		if (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			string[] array = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
			this.BuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.BuffIds[i] = long.Parse(array[i]);
			}
			return;
		}
		this.BuffIds = Array.Empty<long>();
	}

	// Token: 0x060176F4 RID: 95988 RVA: 0x006E8E70 File Offset: 0x006E7070
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		ETeamMemberType memberType = this.MemberType;
		if (memberType != ETeamMemberType.Self)
		{
			if (memberType - ETeamMemberType.LocalFormation <= 1)
			{
				bool onlyMyRole = this.MemberType == ETeamMemberType.LocalFormation;
				foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(onlyMyRole))
				{
					this.DoExecute((entityHandle != null) ? entityHandle.Entity : null);
				}
			}
		}
		else
		{
			this.DoExecute(base.OwnerEntity);
		}
		return null;
	}

	// Token: 0x060176F5 RID: 95989 RVA: 0x006E8F00 File Offset: 0x006E7100
	[NullableContext(2)]
	private void DoExecute(Entity entity)
	{
		if (entity == null)
		{
			return;
		}
		BaseBuffComponent component = entity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return;
		}
		if (this.AddBuff)
		{
			for (int i = 0; i < this.BuffIds.Length; i++)
			{
				BaseBuffComponent baseBuffComponent = component;
				long buffId = this.BuffIds[i];
				IActiveBuff buff = this.Buff;
				int? stackCount = null;
				bool isIterable = true;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Buff");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral("的额外效果ModifyTeamMemberBuff导致的添加");
				baseBuffComponent.AddIterativeBuff(buffId, buff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
			}
			return;
		}
		for (int j = 0; j < this.BuffIds.Length; j++)
		{
			BaseBuffComponent baseBuffComponent2 = component;
			long buffId2 = this.BuffIds[j];
			int stackCount2 = -1;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Buff");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral("的额外效果ModifyTeamMemberBuff");
			baseBuffComponent2.RemoveBuff(buffId2, stackCount2, defaultInterpolatedStringHandler.ToStringAndClear(), null, null, null);
		}
	}

	// Token: 0x060176F6 RID: 95990 RVA: 0x006E9014 File Offset: 0x006E7214
	public override string GetDebugEffectString()
	{
		string value = "自己";
		if (this.MemberType == ETeamMemberType.LocalFormation)
		{
			value = "小队";
		}
		else if (this.MemberType == ETeamMemberType.AllFormation)
		{
			value = "队伍";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 4);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted(this.AddBuff ? "添加" : "移除");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("的buff");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<long>(",", this.BuffIds));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C72E RID: 50990
	private ETeamMemberType MemberType;

	// Token: 0x0400C72F RID: 50991
	private bool AddBuff = true;

	// Token: 0x0400C730 RID: 50992
	private long[] BuffIds = Array.Empty<long>();
}
