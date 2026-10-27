using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059AD RID: 22957
	public class RoguelikeRoomFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A38E RID: 238478 RVA: 0x00DD660D File Offset: 0x00DD480D
		[NullableContext(1)]
		public RoguelikeRoomFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A38F RID: 238479 RVA: 0x00DD6616 File Offset: 0x00DD4816
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603A390 RID: 238480 RVA: 0x00DD663C File Offset: 0x00DD483C
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				LguiUtil.Instance.SetLocalTextNew(base.MainText, "RoguelikeRoomFloatTips_Normal", new <>z__ReadOnlyArray<object>(new object[]
				{
					WeeklyRogueModel.Instance.CurrentLayer,
					WeeklyRogueModel.Instance.MaxLayer
				}));
				LguiUtil.Instance.SetLocalTextNew(base.ExtraText, "RoguelikeRoomFloatTips_NormalDesc", Array.Empty<object>());
				return;
			}
			RoguelikeRoomType? curRoomType = RoguelikeModel.Instance.CurRoomType;
			RoguelikeRoomType roguelikeRoomType = RoguelikeRoomType.Normal;
			bool flag = curRoomType.GetValueOrDefault() == roguelikeRoomType & curRoomType != null;
			base.MainText.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.MainText, "RoguelikeRoomFloatTips_Normal", new <>z__ReadOnlyArray<object>(new object[]
				{
					RoguelikeModel.Instance.CurRoomCount,
					RoguelikeModel.Instance.TotalRoomCount
				}));
			}
		}

		// Token: 0x0603A391 RID: 238481 RVA: 0x00DD6728 File Offset: 0x00DD4928
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			base.GetSprite(2).SetUIActive(false);
			RoguelikeRoomType? curRoomType = RoguelikeModel.Instance.CurRoomType;
			if (curRoomType != null)
			{
				switch (curRoomType.GetValueOrDefault())
				{
				case RoguelikeRoomType.Normal:
					LguiUtil.Instance.SetLocalTextNew(base.ExtraText, "RoguelikeRoomFloatTips_NormalDesc", Array.Empty<object>());
					return;
				case RoguelikeRoomType.Special:
					LguiUtil.Instance.SetLocalTextNew(base.ExtraText, "RoguelikeRoomFloatTips_SpecialDesc", Array.Empty<object>());
					break;
				case RoguelikeRoomType.Boss:
					LguiUtil.Instance.SetLocalTextNew(base.ExtraText, "RoguelikeRoomFloatTips_NoHeadDesc", Array.Empty<object>());
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0200BC1B RID: 48155
		private class ERoguelikeRoomFloatTipsDefine
		{
			// Token: 0x04038C5E RID: 232542
			public const int Icon = 2;
		}
	}
}
