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
	// Token: 0x02003DE0 RID: 15840
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeRoleAffixDetailView : UiViewBase
	{
		// Token: 0x06028785 RID: 165765 RVA: 0x00B57A13 File Offset: 0x00B55C13
		public RoguelikeRoleAffixDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028786 RID: 165766 RVA: 0x00B57A1C File Offset: 0x00B55C1C
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

		// Token: 0x06028787 RID: 165767 RVA: 0x00B57B09 File Offset: 0x00B55D09
		private void OnSelectAffix(int index)
		{
			GenericLayout<RoguelikeRoleAffixDetailToggle, int> affixLayout = this.AffixLayout;
			if (affixLayout != null)
			{
				affixLayout.SelectGridProxy(index, false);
			}
			this.RefreshDetail();
		}

		// Token: 0x06028788 RID: 165768 RVA: 0x00B57B24 File Offset: 0x00B55D24
		private RoguelikeRoleAffixDetailToggle CreateItem()
		{
			return new RoguelikeRoleAffixDetailToggle
			{
				OnSelectCallback = new Action<int>(this.OnSelectAffix)
			};
		}

		// Token: 0x06028789 RID: 165769 RVA: 0x00B57B40 File Offset: 0x00B55D40
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeRoleAffixDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeRoleAffixDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602878A RID: 165770 RVA: 0x00B57B84 File Offset: 0x00B55D84
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

		// Token: 0x04015F73 RID: 89971
		private IRoguelikeRoleAffixDetailViewParam ViewParam;

		// Token: 0x04015F74 RID: 89972
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015F75 RID: 89973
		private GenericLayout<RoguelikeRoleAffixDetailToggle, int> AffixLayout;

		// Token: 0x020099E9 RID: 39401
		[NullableContext(0)]
		private class ERoguelikeRoleAffixDetailViewDefine
		{
			// Token: 0x0402FF9F RID: 196511
			public const int CaptionItem = 0;

			// Token: 0x0402FFA0 RID: 196512
			public const int SpriteIcon = 1;

			// Token: 0x0402FFA1 RID: 196513
			public const int TxtName = 2;

			// Token: 0x0402FFA2 RID: 196514
			public const int TxtDesc = 3;

			// Token: 0x0402FFA3 RID: 196515
			public const int AffixLayout = 4;

			// Token: 0x0402FFA4 RID: 196516
			public const int ItemText = 5;

			// Token: 0x0402FFA5 RID: 196517
			public const int TxtClassify = 6;
		}
	}
}
