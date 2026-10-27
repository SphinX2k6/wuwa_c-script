using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02003053 RID: 12371
[NullableContext(1)]
[Nullable(0)]
public class TCombatMessage
{
	// Token: 0x17002430 RID: 9264
	// (get) Token: 0x0601A4D4 RID: 107732 RVA: 0x006F7536 File Offset: 0x006F5736
	// (set) Token: 0x0601A4D5 RID: 107733 RVA: 0x006F753E File Offset: 0x006F573E
	public CombatCommon CombatCommon { get; set; }

	// Token: 0x17002431 RID: 9265
	// (get) Token: 0x0601A4D6 RID: 107734 RVA: 0x006F7547 File Offset: 0x006F5747
	// (set) Token: 0x0601A4D7 RID: 107735 RVA: 0x006F754F File Offset: 0x006F574F
	public ENotifyMessageId MessageId { get; set; }

	// Token: 0x17002432 RID: 9266
	// (get) Token: 0x0601A4D8 RID: 107736 RVA: 0x006F7558 File Offset: 0x006F5758
	// (set) Token: 0x0601A4D9 RID: 107737 RVA: 0x006F7560 File Offset: 0x006F5760
	public IMessage Message { get; set; }

	// Token: 0x17002433 RID: 9267
	// (get) Token: 0x0601A4DA RID: 107738 RVA: 0x006F7569 File Offset: 0x006F5769
	// (set) Token: 0x0601A4DB RID: 107739 RVA: 0x006F7571 File Offset: 0x006F5771
	public double ExecuteTime { get; set; }

	// Token: 0x0601A4DC RID: 107740 RVA: 0x006F757A File Offset: 0x006F577A
	public TCombatMessage(CombatCommon combatCommon, ENotifyMessageId messageId, IMessage message, double executeTime)
	{
		this.CombatCommon = combatCommon;
		this.MessageId = messageId;
		this.Message = message;
		this.ExecuteTime = executeTime;
	}
}
