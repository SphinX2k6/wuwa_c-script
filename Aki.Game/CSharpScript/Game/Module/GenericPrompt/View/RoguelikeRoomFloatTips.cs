using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004986 RID: 18822
	public class RoguelikeRoomFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2B4 RID: 193204 RVA: 0x00D25A9D File Offset: 0x00D23C9D
		[NullableContext(1)]
		public RoguelikeRoomFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2B5 RID: 193205 RVA: 0x00D25AA6 File Offset: 0x00D23CA6
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0602F2B6 RID: 193206 RVA: 0x00D25ACC File Offset: 0x00D23CCC
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

		// Token: 0x0602F2B7 RID: 193207 RVA: 0x00D25BB8 File Offset: 0x00D23DB8
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

		// Token: 0x0200A626 RID: 42534
		private class ERoguelikeRoomFloatTipsDefine
		{
			// Token: 0x0403362D RID: 210477
			public const int Icon = 2;
		}
	}
}
