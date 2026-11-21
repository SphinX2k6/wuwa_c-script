using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200439B RID: 17307
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleScoreProgressPercentItem : GridProxyAbstract<MoraleProgressRewardData>
	{
		// Token: 0x0602BB7D RID: 179069 RVA: 0x00C452BC File Offset: 0x00C434BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x0602BB7E RID: 179070 RVA: 0x00C45318 File Offset: 0x00C43518
		public override void Refresh(MoraleProgressRewardData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUISprite sprite = base.GetSprite(1);
			float stageProgressPercent = MoraleModel.Instance.GetStageProgressPercent(data);
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(stageProgressPercent);
		}

		// Token: 0x0602BB7F RID: 179071 RVA: 0x00C45360 File Offset: 0x00C43560
		public void UpdatePercentHandle()
		{
			UUISprite sprite = base.GetSprite(1);
			UUISprite sprite2 = base.GetSprite(2);
			float num = (sprite != null) ? sprite.GetWidth() : 0f;
			float stageProgressPercent = MoraleModel.Instance.GetStageProgressPercent(this.ItemData);
			bool flag = this.ItemData.IsInCurrentStage && stageProgressPercent > 0f;
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag);
			}
			if (flag && sprite2 != null)
			{
				sprite2.SetAnchorOffsetX(num * stageProgressPercent);
			}
		}

		// Token: 0x0401790E RID: 96526
		private MoraleProgressRewardData ItemData;

		// Token: 0x0200A090 RID: 41104
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E35 RID: 204341
			public const int ItemSelf = 0;

			// Token: 0x04031E36 RID: 204342
			public const int SpritePercent = 1;

			// Token: 0x04031E37 RID: 204343
			public const int SpriteHandle = 2;
		}
	}
}
