using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FD7 RID: 4055
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchRoleSkillDataComponent)]
public class FloroRanchRoleSkillDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600A1D8 RID: 41432 RVA: 0x002F8E94 File Offset: 0x002F7094
	public override void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		if (entityData.SKillData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, base.GetType().Name + " RefreshEntityData failed, SkillData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SkillData = FloroRanchModel.Instance.GetFloroRanchSkillData(entityData.SKillData.SkillId);
		this.CanUseCount = entityData.SKillData.CurCanUseNum;
		this.CurDayCanUseNum = entityData.SKillData.CurDayCanUseNum;
	}

	// Token: 0x0600A1D9 RID: 41433 RVA: 0x002F8F16 File Offset: 0x002F7116
	public bool CanUseSkill()
	{
		return this.CanUseCount > 0 && this.CurDayCanUseNum > 0;
	}

	// Token: 0x0600A1DA RID: 41434 RVA: 0x002F8F2C File Offset: 0x002F712C
	public override string Info()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
		defaultInterpolatedStringHandler.AppendLiteral("SkillId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(", SkillName: ");
		defaultInterpolatedStringHandler.AppendFormatted(this.SkillData.GetRealName());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600A1DB RID: 41435 RVA: 0x002F8F86 File Offset: 0x002F7186
	public override string DebugInfo()
	{
		return this.SkillData.GetRealName();
	}

	// Token: 0x04005F31 RID: 24369
	[Nullable(2)]
	public FloroRanchSkillData SkillData;

	// Token: 0x04005F32 RID: 24370
	public int CanUseCount;

	// Token: 0x04005F33 RID: 24371
	public int CurDayCanUseNum;
}
