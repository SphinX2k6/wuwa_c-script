using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B18 RID: 6936
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchRoleSkillDataComponent)]
public class FloroRanchRoleSkillDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600CDC7 RID: 52679 RVA: 0x002EDDB4 File Offset: 0x002EBFB4
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

	// Token: 0x0600CDC8 RID: 52680 RVA: 0x002EDE36 File Offset: 0x002EC036
	public bool CanUseSkill()
	{
		return this.CanUseCount > 0 && this.CurDayCanUseNum > 0;
	}

	// Token: 0x0600CDC9 RID: 52681 RVA: 0x002EDE4C File Offset: 0x002EC04C
	public override string Info()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
		defaultInterpolatedStringHandler.AppendLiteral("SkillId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SkillData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(", SkillName: ");
		defaultInterpolatedStringHandler.AppendFormatted(this.SkillData.GetRealName());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600CDCA RID: 52682 RVA: 0x002EDEA6 File Offset: 0x002EC0A6
	public override string DebugInfo()
	{
		return this.SkillData.GetRealName();
	}

	// Token: 0x04005E62 RID: 24162
	[Nullable(2)]
	public FloroRanchSkillData SkillData;

	// Token: 0x04005E63 RID: 24163
	public int CanUseCount;

	// Token: 0x04005E64 RID: 24164
	public int CurDayCanUseNum;
}
