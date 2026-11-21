using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035DB RID: 13787
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenAndCloseViewHotKey : IOpenAndCloseViewHotKey
	{
		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x06023197 RID: 143767 RVA: 0x009FA7E9 File Offset: 0x009F89E9
		// (set) Token: 0x06023198 RID: 143768 RVA: 0x009FA7F1 File Offset: 0x009F89F1
		public int ConfigId { get; set; }

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x06023199 RID: 143769 RVA: 0x009FA7FA File Offset: 0x009F89FA
		// (set) Token: 0x0602319A RID: 143770 RVA: 0x009FA802 File Offset: 0x009F8A02
		public string ActionName { get; set; }

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x0602319B RID: 143771 RVA: 0x009FA80B File Offset: 0x009F8A0B
		// (set) Token: 0x0602319C RID: 143772 RVA: 0x009FA813 File Offset: 0x009F8A13
		public EOpenAndCloseViewInputControllerType InputControllerType { get; set; }

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x0602319D RID: 143773 RVA: 0x009FA81C File Offset: 0x009F8A1C
		// (set) Token: 0x0602319E RID: 143774 RVA: 0x009FA824 File Offset: 0x009F8A24
		public EUiViewName ViewName { get; set; }

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x0602319F RID: 143775 RVA: 0x009FA82D File Offset: 0x009F8A2D
		// (set) Token: 0x060231A0 RID: 143776 RVA: 0x009FA835 File Offset: 0x009F8A35
		public string[] ViewParam { get; set; }

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x060231A1 RID: 143777 RVA: 0x009FA83E File Offset: 0x009F8A3E
		// (set) Token: 0x060231A2 RID: 143778 RVA: 0x009FA846 File Offset: 0x009F8A46
		public bool IsPressTrigger { get; set; }

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x060231A3 RID: 143779 RVA: 0x009FA84F File Offset: 0x009F8A4F
		// (set) Token: 0x060231A4 RID: 143780 RVA: 0x009FA857 File Offset: 0x009F8A57
		public int PressStartTime { get; set; }

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x060231A5 RID: 143781 RVA: 0x009FA860 File Offset: 0x009F8A60
		// (set) Token: 0x060231A6 RID: 143782 RVA: 0x009FA868 File Offset: 0x009F8A68
		public int PressTriggerTime { get; set; }

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x060231A7 RID: 143783 RVA: 0x009FA871 File Offset: 0x009F8A71
		// (set) Token: 0x060231A8 RID: 143784 RVA: 0x009FA879 File Offset: 0x009F8A79
		public bool IsReleaseTrigger { get; set; }

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x060231A9 RID: 143785 RVA: 0x009FA882 File Offset: 0x009F8A82
		// (set) Token: 0x060231AA RID: 143786 RVA: 0x009FA88A File Offset: 0x009F8A8A
		public int ReleaseInvalidTime { get; set; }

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x060231AB RID: 143787 RVA: 0x009FA893 File Offset: 0x009F8A93
		// (set) Token: 0x060231AC RID: 143788 RVA: 0x009FA89B File Offset: 0x009F8A9B
		public bool IsPressClose { get; set; }

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x060231AD RID: 143789 RVA: 0x009FA8A4 File Offset: 0x009F8AA4
		// (set) Token: 0x060231AE RID: 143790 RVA: 0x009FA8AC File Offset: 0x009F8AAC
		public bool IsReleaseClose { get; set; }

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x060231AF RID: 143791 RVA: 0x009FA8B5 File Offset: 0x009F8AB5
		// (set) Token: 0x060231B0 RID: 143792 RVA: 0x009FA8BD File Offset: 0x009F8ABD
		public Func<bool> IsAllowOpenViewByShortcutKey { get; set; }

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x060231B1 RID: 143793 RVA: 0x009FA8C6 File Offset: 0x009F8AC6
		// (set) Token: 0x060231B2 RID: 143794 RVA: 0x009FA8CE File Offset: 0x009F8ACE
		public Func<bool> IsAllowCloseViewByShortcutKey { get; set; }

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x060231B3 RID: 143795 RVA: 0x009FA8D7 File Offset: 0x009F8AD7
		// (set) Token: 0x060231B4 RID: 143796 RVA: 0x009FA8DF File Offset: 0x009F8ADF
		public Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey { get; set; }

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x060231B5 RID: 143797 RVA: 0x009FA8E8 File Offset: 0x009F8AE8
		// (set) Token: 0x060231B6 RID: 143798 RVA: 0x009FA8F0 File Offset: 0x009F8AF0
		[Nullable(2)]
		public Action OpenViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x060231B7 RID: 143799 RVA: 0x009FA8F9 File Offset: 0x009F8AF9
		// (set) Token: 0x060231B8 RID: 143800 RVA: 0x009FA901 File Offset: 0x009F8B01
		[Nullable(2)]
		public Action CloseViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
