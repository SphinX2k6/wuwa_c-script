using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EEC RID: 20204
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceData
	{
		// Token: 0x06032C95 RID: 208021 RVA: 0x00E42ED3 File Offset: 0x00E410D3
		public ActivityEntrancePointData GetActivityEntrancePointData()
		{
			return this.ActivityEntrancePointData;
		}

		// Token: 0x06032C96 RID: 208022 RVA: 0x00E42EDB File Offset: 0x00E410DB
		public ActivityEntranceDescInfoData GetActivityEntranceDescInfoData()
		{
			return this.ActivityEntranceDescInfoData;
		}

		// Token: 0x06032C97 RID: 208023 RVA: 0x00E42EE3 File Offset: 0x00E410E3
		public ActivityEntranceSelectItemData GetActivityEntranceSelectItemData()
		{
			return this.ActivityEntranceSelectItemData;
		}

		// Token: 0x06032C98 RID: 208024 RVA: 0x00E42EEB File Offset: 0x00E410EB
		public ActivityEntranceCaptionItemData GetActivityEntranceCaptionItemData()
		{
			return this.ActivityEntranceCaptionItemData;
		}

		// Token: 0x06032C99 RID: 208025 RVA: 0x00E42EF3 File Offset: 0x00E410F3
		public ActivityEntranceDropDownData GetActivityEntranceDropDownData()
		{
			return this.ActivityEntranceDropDownData;
		}

		// Token: 0x06032C9A RID: 208026 RVA: 0x00E42EFB File Offset: 0x00E410FB
		public ActivityEntranceMonsterPreviewData GetActivityEntranceMonsterPreviewData()
		{
			return this.ActivityEntranceMonsterPreviewData;
		}

		// Token: 0x06032C9B RID: 208027 RVA: 0x00E42F03 File Offset: 0x00E41103
		public Action<int> GetClickConfirmCallBack()
		{
			return this.ClickConfirmCallBack;
		}

		// Token: 0x06032C9C RID: 208028 RVA: 0x00E42F0C File Offset: 0x00E4110C
		[NullableContext(1)]
		public static ActivityInstanceEntranceData Create(ActivityEntrancePointData activityEntrancePointData, ActivityEntranceDescInfoData activityEntranceDescInfoData, ActivityEntranceSelectItemData activityEntranceSelectItemData, ActivityEntranceCaptionItemData activityEntranceCaptionItemData, ActivityEntranceDropDownData activityEntranceDropDownData, ActivityEntranceMonsterPreviewData activityEntranceMonsterPreviewData, Action clickConfirmCallBack)
		{
			return new ActivityInstanceEntranceData
			{
				ActivityEntrancePointData = activityEntrancePointData,
				ActivityEntranceDescInfoData = activityEntranceDescInfoData,
				ActivityEntranceSelectItemData = activityEntranceSelectItemData,
				ActivityEntranceCaptionItemData = activityEntranceCaptionItemData,
				ActivityEntranceMonsterPreviewData = activityEntranceMonsterPreviewData,
				ActivityEntranceDropDownData = activityEntranceDropDownData,
				ClickConfirmCallBack = delegate(int _)
				{
					Action clickConfirmCallBack2 = clickConfirmCallBack;
					if (clickConfirmCallBack2 == null)
					{
						return;
					}
					clickConfirmCallBack2();
				}
			};
		}

		// Token: 0x0401AF65 RID: 110437
		private ActivityEntrancePointData ActivityEntrancePointData;

		// Token: 0x0401AF66 RID: 110438
		private ActivityEntranceDescInfoData ActivityEntranceDescInfoData;

		// Token: 0x0401AF67 RID: 110439
		private ActivityEntranceSelectItemData ActivityEntranceSelectItemData;

		// Token: 0x0401AF68 RID: 110440
		private ActivityEntranceCaptionItemData ActivityEntranceCaptionItemData;

		// Token: 0x0401AF69 RID: 110441
		private ActivityEntranceDropDownData ActivityEntranceDropDownData;

		// Token: 0x0401AF6A RID: 110442
		private ActivityEntranceMonsterPreviewData ActivityEntranceMonsterPreviewData;

		// Token: 0x0401AF6B RID: 110443
		private Action<int> ClickConfirmCallBack;
	}
}
