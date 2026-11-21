using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02002436 RID: 9270
[NullableContext(1)]
[Nullable(0)]
public class CharacterOperationRecord
{
	// Token: 0x06017355 RID: 95061 RVA: 0x006D0690 File Offset: 0x006CE890
	public CharacterOperationRecord(string name, int entityId, int cfgId)
	{
		this.Name = name;
		this.EntityId = entityId;
		this.CfgId = cfgId;
	}

	// Token: 0x06017356 RID: 95062 RVA: 0x006D06D0 File Offset: 0x006CE8D0
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

	// Token: 0x0400C3B4 RID: 50100
	private static readonly string CHARACTER_RECORD_FMT = "{0},{1},{2},{3}\n";

	// Token: 0x0400C3B5 RID: 50101
	public readonly string Name;

	// Token: 0x0400C3B6 RID: 50102
	public readonly int EntityId;

	// Token: 0x0400C3B7 RID: 50103
	private readonly int CfgId;

	// Token: 0x0400C3B8 RID: 50104
	public readonly Dictionary<int, SkillOperationRecord> SkillOperationMap = new Dictionary<int, SkillOperationRecord>();

	// Token: 0x0400C3B9 RID: 50105
	public readonly Dictionary<ECharMoveState, SkillOperationRecord> MoveOperationMap = new Dictionary<ECharMoveState, SkillOperationRecord>();

	// Token: 0x0400C3BA RID: 50106
	public readonly Dictionary<int, SkillOperationRecord> TagOperationMap = new Dictionary<int, SkillOperationRecord>();
}
