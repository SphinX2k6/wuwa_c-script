using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x020025A9 RID: 9641
[NullableContext(1)]
[Nullable(0)]
public class TCombatMessage
{
	// Token: 0x17002548 RID: 9544
	// (get) Token: 0x06017E6C RID: 97900 RVA: 0x0071E5B6 File Offset: 0x0071C7B6
	// (set) Token: 0x06017E6D RID: 97901 RVA: 0x0071E5BE File Offset: 0x0071C7BE
	public CombatCommon CombatCommon { get; set; }

	// Token: 0x17002549 RID: 9545
	// (get) Token: 0x06017E6E RID: 97902 RVA: 0x0071E5C7 File Offset: 0x0071C7C7
	// (set) Token: 0x06017E6F RID: 97903 RVA: 0x0071E5CF File Offset: 0x0071C7CF
	public ENotifyMessageId MessageId { get; set; }

	// Token: 0x1700254A RID: 9546
	// (get) Token: 0x06017E70 RID: 97904 RVA: 0x0071E5D8 File Offset: 0x0071C7D8
	// (set) Token: 0x06017E71 RID: 97905 RVA: 0x0071E5E0 File Offset: 0x0071C7E0
	public IMessage Message { get; set; }

	// Token: 0x1700254B RID: 9547
	// (get) Token: 0x06017E72 RID: 97906 RVA: 0x0071E5E9 File Offset: 0x0071C7E9
	// (set) Token: 0x06017E73 RID: 97907 RVA: 0x0071E5F1 File Offset: 0x0071C7F1
	public double ExecuteTime { get; set; }

	// Token: 0x06017E74 RID: 97908 RVA: 0x0071E5FA File Offset: 0x0071C7FA
	public TCombatMessage(CombatCommon combatCommon, ENotifyMessageId messageId, IMessage message, double executeTime)
	{
		this.CombatCommon = combatCommon;
		this.MessageId = messageId;
		this.Message = message;
		this.ExecuteTime = executeTime;
	}
}
