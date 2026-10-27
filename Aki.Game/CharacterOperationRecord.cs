using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02002EE3 RID: 12003
[NullableContext(1)]
[Nullable(0)]
public class CharacterOperationRecord
{
	// Token: 0x06019A52 RID: 105042 RVA: 0x006AA521 File Offset: 0x006A8721
	public CharacterOperationRecord(string name, int entityId, int cfgId)
	{
		this.Name = name;
		this.EntityId = entityId;
		this.CfgId = cfgId;
	}

	// Token: 0x06019A53 RID: 105043 RVA: 0x006AA560 File Offset: 0x006A8760
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (SkillOperationRecord skillOperationRecord in this.SkillOperationMap.Values)
		{
			stringBuilder.Append(StringUtils.Format(CharacterOperationRecord.CHARACTER_RECORD_FMT, new string[]
			{
				this.EntityId.ToString(),
				this.Name,
				this.CfgId.ToString(),
				skillOperationRecord.ToString()
			}));
		}
		foreach (SkillOperationRecord skillOperationRecord2 in this.MoveOperationMap.Values)
		{
			stringBuilder.Append(StringUtils.Format(CharacterOperationRecord.CHARACTER_RECORD_FMT, new string[]
			{
				this.EntityId.ToString(),
				this.Name,
				this.CfgId.ToString(),
				skillOperationRecord2.ToString()
			}));
		}
		foreach (SkillOperationRecord skillOperationRecord3 in this.TagOperationMap.Values)
		{
			stringBuilder.Append(StringUtils.Format(CharacterOperationRecord.CHARACTER_RECORD_FMT, new string[]
			{
				this.EntityId.ToString(),
				this.Name,
				this.CfgId.ToString(),
				skillOperationRecord3.ToString()
			}));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0400C019 RID: 49177
	private static readonly string CHARACTER_RECORD_FMT = "{0},{1},{2},{3}\n";

	// Token: 0x0400C01A RID: 49178
	public readonly string Name;

	// Token: 0x0400C01B RID: 49179
	public readonly int EntityId;

	// Token: 0x0400C01C RID: 49180
	private readonly int CfgId;

	// Token: 0x0400C01D RID: 49181
	public readonly Dictionary<int, SkillOperationRecord> SkillOperationMap = new Dictionary<int, SkillOperationRecord>();

	// Token: 0x0400C01E RID: 49182
	public readonly Dictionary<ECharMoveState, SkillOperationRecord> MoveOperationMap = new Dictionary<ECharMoveState, SkillOperationRecord>();

	// Token: 0x0400C01F RID: 49183
	public readonly Dictionary<int, SkillOperationRecord> TagOperationMap = new Dictionary<int, SkillOperationRecord>();
}
