using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E17 RID: 19991
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRoleAffixDetailView : UiViewBase
	{
		// Token: 0x0603391A RID: 211226 RVA: 0x00C0E507 File Offset: 0x00C0C707
		public RoguelikeRoleAffixDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603391B RID: 211227 RVA: 0x00C0E510 File Offset: 0x00C0C710
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603391C RID: 211228 RVA: 0x00C0E5FD File Offset: 0x00C0C7FD
		private void OnSelectAffix(int index)
		{
			GenericLayout<RoguelikeRoleAffixDetailToggle, int> affixLayout = this.AffixLayout;
			if (affixLayout != null)
			{
				affixLayout.SelectGridProxy(index, false);
			}
			this.RefreshDetail();
		}

		// Token: 0x0603391D RID: 211229 RVA: 0x00C0E618 File Offset: 0x00C0C818
		private RoguelikeRoleAffixDetailToggle CreateItem()
		{
			return new RoguelikeRoleAffixDetailToggle
			{
				OnSelectCallback = new Action<int>(this.OnSelectAffix)
			};
		}

		// Token: 0x0603391E RID: 211230 RVA: 0x00C0E634 File Offset: 0x00C0C834
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeRoleAffixDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeRoleAffixDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603391F RID: 211231 RVA: 0x00C0E678 File Offset: 0x00C0C878
		public void RefreshDetail()
		{
			int selectedGridIndex = this.AffixLayout.GetSelectedGridIndex();
			if (selectedGridIndex < 0)
			{
				return;
			}
			int id = this.ViewParam.AffixIds[selectedGridIndex];
			RogueCharacterBuff? rogueCharacterBuffConfig = RoguelikeConfig.Instance.GetRogueCharacterBuffConfig(id);
			if (rogueCharacterBuffConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueCharacterBuffConfig.Value.AffixTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueCharacterBuffConfig.Value.AffixDesc, rogueCharacterBuffConfig.Value.AffixDescParam());
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("RogueCharacterBuff_Type", null);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string id2 in rogueCharacterBuffConfig.Value.AffixTypeListIter())
			{
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(id2, null);
				stringBuilder.Append(StringUtils.Format(localTextNew, new string[]
				{
					localTextNew2
				}));
			}
			if (rogueCharacterBuffConfig.Value.AffixTypeListLength > 0)
			{
				base.GetText(6).ShowTextNew(stringBuilder.ToString());
				base.GetText(6).SetUIActive(true);
			}
			else
			{
				base.GetText(6).SetUIActive(false);
			}
			this.SetSpriteByPath(rogueCharacterBuffConfig.Value.AffixIcon, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0401B5A0 RID: 112032
		private IRoguelikeRoleAffixDetailViewParam ViewParam;

		// Token: 0x0401B5A1 RID: 112033
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B5A2 RID: 112034
		private GenericLayout<RoguelikeRoleAffixDetailToggle, int> AffixLayout;

		// Token: 0x0200AFB4 RID: 44980
		[NullableContext(0)]
		private class ERoguelikeRoleAffixDetailViewDefine
		{
			// Token: 0x0403556C RID: 218476
			public const int CaptionItem = 0;

			// Token: 0x0403556D RID: 218477
			public const int SpriteIcon = 1;

			// Token: 0x0403556E RID: 218478
			public const int TxtName = 2;

			// Token: 0x0403556F RID: 218479
			public const int TxtDesc = 3;

			// Token: 0x04035570 RID: 218480
			public const int AffixLayout = 4;

			// Token: 0x04035571 RID: 218481
			public const int ItemText = 5;

			// Token: 0x04035572 RID: 218482
			public const int TxtClassify = 6;
		}
	}
}
