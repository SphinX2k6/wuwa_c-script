using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F05 RID: 24325
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceData
	{
		// Token: 0x0603DCFA RID: 253178 RVA: 0x00EF11CB File Offset: 0x00EEF3CB
		public ActivityEntrancePointData GetActivityEntrancePointData()
		{
			return this.ActivityEntrancePointData;
		}

		// Token: 0x0603DCFB RID: 253179 RVA: 0x00EF11D3 File Offset: 0x00EEF3D3
		public ActivityEntranceDescInfoData GetActivityEntranceDescInfoData()
		{
			return this.ActivityEntranceDescInfoData;
		}

		// Token: 0x0603DCFC RID: 253180 RVA: 0x00EF11DB File Offset: 0x00EEF3DB
		public ActivityEntranceSelectItemData GetActivityEntranceSelectItemData()
		{
			return this.ActivityEntranceSelectItemData;
		}

		// Token: 0x0603DCFD RID: 253181 RVA: 0x00EF11E3 File Offset: 0x00EEF3E3
		public ActivityEntranceCaptionItemData GetActivityEntranceCaptionItemData()
		{
			return this.ActivityEntranceCaptionItemData;
		}

		// Token: 0x0603DCFE RID: 253182 RVA: 0x00EF11EB File Offset: 0x00EEF3EB
		public ActivityEntranceDropDownData GetActivityEntranceDropDownData()
		{
			return this.ActivityEntranceDropDownData;
		}

		// Token: 0x0603DCFF RID: 253183 RVA: 0x00EF11F3 File Offset: 0x00EEF3F3
		public ActivityEntranceMonsterPreviewData GetActivityEntranceMonsterPreviewData()
		{
			return this.ActivityEntranceMonsterPreviewData;
		}

		// Token: 0x0603DD00 RID: 253184 RVA: 0x00EF11FB File Offset: 0x00EEF3FB
		public Action<int> GetClickConfirmCallBack()
		{
			return this.ClickConfirmCallBack;
		}

		// Token: 0x0603DD01 RID: 253185 RVA: 0x00EF1204 File Offset: 0x00EEF404
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

		// Token: 0x04020493 RID: 132243
		private ActivityEntrancePointData ActivityEntrancePointData;

		// Token: 0x04020494 RID: 132244
		private ActivityEntranceDescInfoData ActivityEntranceDescInfoData;

		// Token: 0x04020495 RID: 132245
		private ActivityEntranceSelectItemData ActivityEntranceSelectItemData;

		// Token: 0x04020496 RID: 132246
		private ActivityEntranceCaptionItemData ActivityEntranceCaptionItemData;

		// Token: 0x04020497 RID: 132247
		private ActivityEntranceDropDownData ActivityEntranceDropDownData;

		// Token: 0x04020498 RID: 132248
		private ActivityEntranceMonsterPreviewData ActivityEntranceMonsterPreviewData;

		// Token: 0x04020499 RID: 132249
		private Action<int> ClickConfirmCallBack;
	}
}
