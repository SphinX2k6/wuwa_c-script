using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035DA RID: 13786
	[NullableContext(1)]
	public interface IOpenAndCloseViewHotKey
	{
		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06023175 RID: 143733
		// (set) Token: 0x06023176 RID: 143734
		int ConfigId { get; set; }

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06023177 RID: 143735
		// (set) Token: 0x06023178 RID: 143736
		string ActionName { get; set; }

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x06023179 RID: 143737
		// (set) Token: 0x0602317A RID: 143738
		EOpenAndCloseViewInputControllerType InputControllerType { get; set; }

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x0602317B RID: 143739
		// (set) Token: 0x0602317C RID: 143740
		EUiViewName ViewName { get; set; }

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x0602317D RID: 143741
		// (set) Token: 0x0602317E RID: 143742
		string[] ViewParam { get; set; }

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x0602317F RID: 143743
		// (set) Token: 0x06023180 RID: 143744
		bool IsPressTrigger { get; set; }

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x06023181 RID: 143745
		// (set) Token: 0x06023182 RID: 143746
		int PressStartTime { get; set; }

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x06023183 RID: 143747
		// (set) Token: 0x06023184 RID: 143748
		int PressTriggerTime { get; set; }

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x06023185 RID: 143749
		// (set) Token: 0x06023186 RID: 143750
		bool IsReleaseTrigger { get; set; }

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x06023187 RID: 143751
		// (set) Token: 0x06023188 RID: 143752
		int ReleaseInvalidTime { get; set; }

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x06023189 RID: 143753
		// (set) Token: 0x0602318A RID: 143754
		bool IsPressClose { get; set; }

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x0602318B RID: 143755
		// (set) Token: 0x0602318C RID: 143756
		bool IsReleaseClose { get; set; }

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x0602318D RID: 143757
		// (set) Token: 0x0602318E RID: 143758
		Func<bool> IsAllowOpenViewByShortcutKey { get; set; }

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x0602318F RID: 143759
		// (set) Token: 0x06023190 RID: 143760
		Func<bool> IsAllowCloseViewByShortcutKey { get; set; }

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x06023191 RID: 143761
		// (set) Token: 0x06023192 RID: 143762
		Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey { get; set; }

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x06023193 RID: 143763
		// (set) Token: 0x06023194 RID: 143764
		[Nullable(2)]
		Action OpenViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x06023195 RID: 143765
		// (set) Token: 0x06023196 RID: 143766
		[Nullable(2)]
		Action CloseViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
