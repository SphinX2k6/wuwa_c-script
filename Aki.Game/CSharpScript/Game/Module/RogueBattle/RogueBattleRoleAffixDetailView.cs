using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EC1 RID: 16065
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleAffixDetailView : UiViewBase
	{
		// Token: 0x06028C1C RID: 166940 RVA: 0x00B6F066 File Offset: 0x00B6D266
		public RogueBattleRoleAffixDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C1D RID: 166941 RVA: 0x00B6F070 File Offset: 0x00B6D270
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnRolePreview))
			};
		}

		// Token: 0x06028C1E RID: 166942 RVA: 0x00B6F130 File Offset: 0x00B6D330
		private unsafe void OnClickBtnRolePreview()
		{
			int roleId = ((IRogueBattleRoleAffixDetailOpenParam)this.OpenParam).RoleId;
			if (roleId > 100000)
			{
				RoleController instance = RoleController.Instance;
				ERoleAgentType agentType = ERoleAgentType.Preview;
				int selectRoleId = 0;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int num2 = 0;
				*span[num2] = roleId;
				instance.OpenRoleMainView(agentType, selectRoleId, list, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
				return;
			}
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(roleId);
			if (rogueResBondRole != null)
			{
				RoleController instance2 = RoleController.Instance;
				ERoleAgentType agentType2 = ERoleAgentType.Preview;
				int selectRoleId2 = 0;
				int num2 = 1;
				List<int> list2 = new List<int>(num2);
				CollectionsMarshal.SetCount<int>(list2, num2);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
				int num = 0;
				*span[num] = rogueResBondRole.Value.TrialRoleId;
				instance2.OpenRoleMainView(agentType2, selectRoleId2, list2, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
			}
		}

		// Token: 0x06028C1F RID: 166943 RVA: 0x00B6F1EE File Offset: 0x00B6D3EE
		private void OnSelectAffix(int index)
		{
			GenericLayout<RogueBattleRoleAffixDetailToggle, int> affixLayout = this.AffixLayout;
			if (affixLayout != null)
			{
				affixLayout.SelectGridProxy(index, false);
			}
			this.RefreshDetail();
		}

		// Token: 0x06028C20 RID: 166944 RVA: 0x00B6F209 File Offset: 0x00B6D409
		private RogueBattleRoleAffixDetailToggle CreateItem()
		{
			return new RogueBattleRoleAffixDetailToggle
			{
				OnSelectCallback = new Action<int>(this.OnSelectAffix)
			};
		}

		// Token: 0x06028C21 RID: 166945 RVA: 0x00B6F224 File Offset: 0x00B6D424
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRoleAffixDetailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRoleAffixDetailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C22 RID: 166946 RVA: 0x00B6F268 File Offset: 0x00B6D468
		public void RefreshDetail()
		{
			int selectedGridIndex = this.AffixLayout.GetSelectedGridIndex();
			if (selectedGridIndex < 0)
			{
				return;
			}
			int id = ((IRogueBattleRoleAffixDetailOpenParam)this.OpenParam).AffixIds[selectedGridIndex];
			RogueResCharacterBuff? rogueResCharacterBuff = RogueBattleConfig.Instance.GetRogueResCharacterBuff(id);
			if (rogueResCharacterBuff == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueResCharacterBuff.Value.AffixTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueResCharacterBuff.Value.AffixDesc, rogueResCharacterBuff.Value.AffixDescParam());
			this.SetSpriteByPath(rogueResCharacterBuff.Value.AffixIcon, base.GetSprite(1), false, null, null);
		}

		// Token: 0x040162B2 RID: 90802
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040162B3 RID: 90803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleRoleAffixDetailToggle, int> AffixLayout;
	}
}
