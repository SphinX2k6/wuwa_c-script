using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B8 RID: 21432
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleScoreProgressPercentItem : GridProxyAbstract<MoraleProgressRewardData>
	{
		// Token: 0x06036C37 RID: 224311 RVA: 0x00CF6214 File Offset: 0x00CF4414
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x06036C38 RID: 224312 RVA: 0x00CF6270 File Offset: 0x00CF4470
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

		// Token: 0x06036C39 RID: 224313 RVA: 0x00CF62B8 File Offset: 0x00CF44B8
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

		// Token: 0x0401CE76 RID: 118390
		private MoraleProgressRewardData ItemData;

		// Token: 0x0200B658 RID: 46680
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040373E0 RID: 226272
			public const int ItemSelf = 0;

			// Token: 0x040373E1 RID: 226273
			public const int SpritePercent = 1;

			// Token: 0x040373E2 RID: 226274
			public const int SpriteHandle = 2;
		}
	}
}
