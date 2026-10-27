using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005748 RID: 22344
	public class KurotatoRoleOverviewTabView : UiTabViewBase
	{
		// Token: 0x06038CCF RID: 232655 RVA: 0x00D7D28C File Offset: 0x00D7B48C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038CD0 RID: 232656 RVA: 0x00D7D39C File Offset: 0x00D7B59C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoRoleOverviewTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoRoleOverviewTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CD1 RID: 232657 RVA: 0x00D7D3E0 File Offset: 0x00D7B5E0
		private UniTask CreateAttributePanelAsync()
		{
			KurotatoRoleOverviewTabView.<CreateAttributePanelAsync>d__5 <CreateAttributePanelAsync>d__;
			<CreateAttributePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAttributePanelAsync>d__.<>4__this = this;
			<CreateAttributePanelAsync>d__.<>1__state = -1;
			<CreateAttributePanelAsync>d__.<>t__builder.Start<KurotatoRoleOverviewTabView.<CreateAttributePanelAsync>d__5>(ref <CreateAttributePanelAsync>d__);
			return <CreateAttributePanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CD2 RID: 232658 RVA: 0x00D7D424 File Offset: 0x00D7B624
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Switch");
			}
			KurotatoInstInfo kurotatoInstInfo = this.ExtraParams as KurotatoInstInfo;
			this.RefreshExp(kurotatoInstInfo);
			this.RefreshRoleInfo(kurotatoInstInfo);
			if (kurotatoInstInfo != null)
			{
				this.AttributePanel.SetSavePropertyMap(kurotatoInstInfo.PropertyMap.ToDictionary<int, int>());
				return;
			}
			this.AttributePanel.SetSavePropertyMap(null);
		}

		// Token: 0x06038CD3 RID: 232659 RVA: 0x00D7D488 File Offset: 0x00D7B688
		[NullableContext(2)]
		private void RefreshExp(KurotatoInstInfo saveInstInfo)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoModel instance2 = KurotatoModel.Instance;
			int characterId = (saveInstInfo != null) ? saveInstInfo.RoleId : instance2.GetRoleId();
			KurotatoCharacter value = instance.GetCharacterById(characterId).Value;
			int num = (saveInstInfo != null) ? saveInstInfo.RoleLevel : instance2.BattleData.GetRoleLevel();
			int num2 = (saveInstInfo != null) ? saveInstInfo.RoleExp : instance2.BattleData.GetRoleExp();
			KurotatoLevel value2 = instance.GetLevelConfig((saveInstInfo != null) ? saveInstInfo.LevelId : instance2.GetCurLevelId()).Value;
			int maxLevel = instance.GetMaxLevel(value2.ActivityId);
			UUISprite sprite = base.GetSprite(0);
			if (num <= 0)
			{
				sprite.SetFillAmount(0f);
			}
			else if (num >= maxLevel)
			{
				sprite.SetFillAmount(1f);
			}
			else
			{
				int expByLevel = instance.GetExpByLevel(num, value2.ActivityId);
				int expByLevel2 = instance.GetExpByLevel(num + 1, value2.ActivityId);
				sprite.SetFillAmount((float)(num2 - expByLevel) / (float)(expByLevel2 - expByLevel));
			}
			base.GetText(1).SetText(num.ToString(), true);
			List<string> data = new List<string>
			{
				KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false)
			};
			this.SkillInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06038CD4 RID: 232660 RVA: 0x00D7D5D8 File Offset: 0x00D7B7D8
		[NullableContext(2)]
		private void RefreshRoleInfo(KurotatoInstInfo saveInstInfo)
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int num = (saveInstInfo != null) ? saveInstInfo.RoleId : instance.GetRoleId();
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(num).Value;
			RoleDataBase roleDataByKurotatoRoleId = instance.GetRoleDataByKurotatoRoleId(num);
			RoleSkin value2 = SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value;
			USpineSkeletonAnimationComponent roleSpine = base.GetSpine(3);
			UUIItem roleItem = roleSpine.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			List<float> param = value2.SpineParamIter().ToList<float>();
			base.SetSpineAssetByPath(value2.FormationSpineAtlas, value2.FormationSpineSkeletonData, roleSpine).ContinueWith(delegate()
			{
				roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
				roleItem.SetAnchorOffsetX(param[0]);
				roleItem.SetAnchorOffsetY(param[1]);
				roleItem.SetUIItemScale(new FVector(param[2], param[2], param[2]));
			}).Forget();
			base.GetText(4).ShowTextNew(value.Name);
		}

		// Token: 0x0401DCA6 RID: 122022
		[Nullable(1)]
		private readonly KurotatoAttributePanel AttributePanel = new KurotatoAttributePanel();

		// Token: 0x0401DCA7 RID: 122023
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkillInfoItem, string> SkillInfoLayout;

		// Token: 0x0200B937 RID: 47415
		private enum EChildComp
		{
			// Token: 0x04038059 RID: 229465
			SpriteBar,
			// Token: 0x0403805A RID: 229466
			TextLevel,
			// Token: 0x0403805B RID: 229467
			AttributeViewItem,
			// Token: 0x0403805C RID: 229468
			SpineRole,
			// Token: 0x0403805D RID: 229469
			TextRoleName,
			// Token: 0x0403805E RID: 229470
			VerticalLayoutSkill,
			// Token: 0x0403805F RID: 229471
			PanelSkillInfo
		}
	}
}
