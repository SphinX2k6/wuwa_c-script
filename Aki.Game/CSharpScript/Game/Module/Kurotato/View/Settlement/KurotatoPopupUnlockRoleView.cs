using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005723 RID: 22307
	public class KurotatoPopupUnlockRoleView : UiViewBase
	{
		// Token: 0x06038B7D RID: 232317 RVA: 0x00D75749 File Offset: 0x00D73949
		[NullableContext(1)]
		public KurotatoPopupUnlockRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038B7E RID: 232318 RVA: 0x00D75760 File Offset: 0x00D73960
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickArrowLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickArrowRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038B7F RID: 232319 RVA: 0x00D758F4 File Offset: 0x00D73AF4
		protected override void OnStart()
		{
			IKurotatoPopupUnlockRoleOpenParam kurotatoPopupUnlockRoleOpenParam = (IKurotatoPopupUnlockRoleOpenParam)this.OpenParam;
			this.RoleIdList.Clear();
			if (kurotatoPopupUnlockRoleOpenParam.RoleIds != null)
			{
				this.RoleIdList.AddRange(kurotatoPopupUnlockRoleOpenParam.RoleIds);
			}
			this.RoleIndex = ((kurotatoPopupUnlockRoleOpenParam.Index >= 0 && kurotatoPopupUnlockRoleOpenParam.Index < this.RoleIdList.Count) ? kurotatoPopupUnlockRoleOpenParam.Index : 0);
			this.RoleId = ((this.RoleIdList.Count > 0) ? this.RoleIdList[this.RoleIndex] : 0);
			this.SkillInfoScrollList = new GenericScrollViewNew<SkillInfoItem, string>(base.GetScrollViewWithScrollbar(3), () => new SkillInfoItem(), null, false, null);
			this.RefreshArrowBtn();
			this.RefreshRoleInfo();
			this.RefreshSkillInfo();
		}

		// Token: 0x06038B80 RID: 232320 RVA: 0x00D759CC File Offset: 0x00D73BCC
		private void RefreshRoleInfo()
		{
			KurotatoPopupUnlockRoleView.<>c__DisplayClass9_0 CS$<>8__locals1 = new KurotatoPopupUnlockRoleView.<>c__DisplayClass9_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.RoleId == 0)
			{
				return;
			}
			KurotatoPopupUnlockRoleView.<>c__DisplayClass9_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.RoleRefreshToken + 1;
			this.RoleRefreshToken = num;
			CS$<>8__locals2.refreshToken = num;
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(this.RoleId).Value;
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(this.RoleId);
			RoleSkin value2 = SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value;
			CS$<>8__locals1.roleSpine = base.GetSpine(1);
			CS$<>8__locals1.roleItem = (CS$<>8__locals1.roleSpine.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			CS$<>8__locals1.param = value2.GetSpineParamArray();
			base.SetSpineAssetByPath(value2.FormationSpineAtlas, value2.FormationSpineSkeletonData, CS$<>8__locals1.roleSpine).ContinueWith(delegate()
			{
				if (CS$<>8__locals1.refreshToken != CS$<>8__locals1.<>4__this.RoleRefreshToken)
				{
					return;
				}
				CS$<>8__locals1.roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
				CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
				CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
				CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
			});
			base.GetText(2).ShowTextNew(value.Name);
		}

		// Token: 0x06038B81 RID: 232321 RVA: 0x00D75ACC File Offset: 0x00D73CCC
		private void RefreshSkillInfo()
		{
			if (this.RoleId == 0)
			{
				return;
			}
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(this.RoleId).Value;
			List<string> data = new List<string>
			{
				KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false)
			};
			this.SkillInfoScrollList.RefreshByData(data, null, false);
		}

		// Token: 0x06038B82 RID: 232322 RVA: 0x00D75B30 File Offset: 0x00D73D30
		private void RefreshArrowBtn()
		{
			bool uiactive = this.RoleIdList.Count > 1;
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			UUIButtonComponent button2 = base.GetButton(6);
			if (button2 == null)
			{
				return;
			}
			button2.RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x06038B83 RID: 232323 RVA: 0x00D75B8C File Offset: 0x00D73D8C
		private void SwitchRole(int offset)
		{
			if (this.RoleIdList.Count <= 1)
			{
				return;
			}
			this.RoleIndex = (this.RoleIndex + offset + this.RoleIdList.Count) % this.RoleIdList.Count;
			this.RoleId = this.RoleIdList[this.RoleIndex];
			this.RefreshRoleInfo();
			this.RefreshSkillInfo();
		}

		// Token: 0x06038B84 RID: 232324 RVA: 0x00D75BF1 File Offset: 0x00D73DF1
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038B85 RID: 232325 RVA: 0x00D75BFA File Offset: 0x00D73DFA
		private void OnClickArrowLeft()
		{
			this.SwitchRole(-1);
		}

		// Token: 0x06038B86 RID: 232326 RVA: 0x00D75C03 File Offset: 0x00D73E03
		private void OnClickArrowRight()
		{
			this.SwitchRole(1);
		}

		// Token: 0x0401DC31 RID: 121905
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SkillInfoItem, string> SkillInfoScrollList;

		// Token: 0x0401DC32 RID: 121906
		[Nullable(1)]
		private readonly List<int> RoleIdList = new List<int>();

		// Token: 0x0401DC33 RID: 121907
		private int RoleIndex;

		// Token: 0x0401DC34 RID: 121908
		private int RoleId;

		// Token: 0x0401DC35 RID: 121909
		private int RoleRefreshToken;

		// Token: 0x0200B8DD RID: 47325
		private class EComponents
		{
			// Token: 0x04037EBC RID: 229052
			public const int BtnClose = 0;

			// Token: 0x04037EBD RID: 229053
			public const int SpineRole = 1;

			// Token: 0x04037EBE RID: 229054
			public const int TextRoleName = 2;

			// Token: 0x04037EBF RID: 229055
			public const int ScrollView = 3;

			// Token: 0x04037EC0 RID: 229056
			public const int ScrollContent = 4;

			// Token: 0x04037EC1 RID: 229057
			public const int BtnArrowLeft = 5;

			// Token: 0x04037EC2 RID: 229058
			public const int BtnArrowRight = 6;
		}
	}
}
