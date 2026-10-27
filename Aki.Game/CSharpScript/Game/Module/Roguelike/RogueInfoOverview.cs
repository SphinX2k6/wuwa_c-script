using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DF8 RID: 19960
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueInfoOverview : UiPanelBase
	{
		// Token: 0x06033818 RID: 210968 RVA: 0x00C08EA0 File Offset: 0x00C070A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnMore));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033819 RID: 210969 RVA: 0x00C08FA9 File Offset: 0x00C071A9
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0603381A RID: 210970 RVA: 0x00C08FC4 File Offset: 0x00C071C4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueInfoOverview.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueInfoOverview.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603381B RID: 210971 RVA: 0x00C09007 File Offset: 0x00C07207
		protected override void OnStart()
		{
			PhantomSelectItem phantomItem = this.PhantomItem;
			if (phantomItem != null)
			{
				phantomItem.SetToggleRaycastTarget(false);
			}
			this.InitAttributeItemList();
			this.RefreshByViewModel();
		}

		// Token: 0x0603381C RID: 210972 RVA: 0x00C09028 File Offset: 0x00C07228
		private void OnBtnMore()
		{
			if (this.Vm == null)
			{
				return;
			}
			List<AttrListScrollData> attrList = this.Vm.GetAttrList();
			UiManager.Instance.OpenView(EUiViewName.RogueAttributeDetailView, attrList, null);
		}

		// Token: 0x0603381D RID: 210973 RVA: 0x00C0905C File Offset: 0x00C0725C
		private void InitAttributeItemList()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(3);
			List<UniTask> list = new List<UniTask>();
			int length = intArrayConfig.Count;
			int index;
			int index2;
			for (index = 0; index < length; index = index2)
			{
				UUIItem uuiitem;
				if (index == 0)
				{
					uuiitem = item2;
				}
				else
				{
					uuiitem = LguiUtil.Instance.CopyItem(item2, item);
				}
				int attributeId = intArrayConfig[index];
				AttributeItem attributeItem = new AttributeItem();
				UniTask item3 = attributeItem.CreateThenShowByActorAsync(uuiitem.GetOwner()).ContinueWith(delegate()
				{
					CSharpScript.Game.Module.Common.AttributeData data = new CSharpScript.Game.Module.Common.AttributeData
					{
						Id = attributeId,
						IsRatio = false,
						CurValue = 0f,
						BgActive = new bool?(length > 2 && index % 2 == 0)
					};
					attributeItem.Refresh(data, false, index);
				});
				this.AttributeItemList.Add(attributeItem);
				list.Add(item3);
				index2 = index + 1;
			}
			UniTask.WhenAll(list).ContinueWith(new Action(this.UpdateAttribute)).Forget();
		}

		// Token: 0x0603381E RID: 210974 RVA: 0x00C09184 File Offset: 0x00C07384
		protected void UpdateAttribute()
		{
			if (this.Vm == null)
			{
				return;
			}
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			for (int i = 0; i < this.AttributeItemList.Count; i++)
			{
				AttributeItem attributeItem = this.AttributeItemList[i];
				int attrId = intArrayConfig[i];
				float attributeValue = this.Vm.RogueInfo.GetAttributeValue(attrId);
				attributeItem.SetCurrentValue(attributeValue);
				attributeItem.SetActive(true);
			}
		}

		// Token: 0x0603381F RID: 210975 RVA: 0x00C091EE File Offset: 0x00C073EE
		[NullableContext(1)]
		public void SetViewModel(RogueInfoViewModel vm)
		{
			this.Vm = vm;
			this.RefreshByViewModel();
			this.UpdateAttribute();
		}

		// Token: 0x06033820 RID: 210976 RVA: 0x00C09203 File Offset: 0x00C07403
		public void RefreshPanel()
		{
			this.RefreshByViewModel();
		}

		// Token: 0x06033821 RID: 210977 RVA: 0x00C0920C File Offset: 0x00C0740C
		private void RefreshByViewModel()
		{
			if (this.Vm == null)
			{
				return;
			}
			RogueGainEntry phantomEntry = this.Vm.PhantomEntry;
			if (phantomEntry != null)
			{
				PhantomSelectItemContextData data = new PhantomSelectItemContextData
				{
					RogueGainEntry = phantomEntry,
					RoguelikeInfo = this.Vm.RogueInfo
				};
				PhantomSelectItem phantomItem = this.PhantomItem;
				if (phantomItem != null)
				{
					phantomItem.Update(data);
				}
				RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(phantomEntry.ConfigId);
				PhantomSelectItem phantomItem2 = this.PhantomItem;
				if (phantomItem2 != null)
				{
					phantomItem2.GetRootItem().SetUIActive(roguePhantomConfig != null);
				}
			}
			else
			{
				PhantomSelectItem phantomItem3 = this.PhantomItem;
				if (phantomItem3 != null)
				{
					phantomItem3.GetRootItem().SetUIActive(false);
				}
			}
			RogueGainEntry roleEntry = this.Vm.RoleEntry;
			RoleSelectItem roleItem = this.RoleItem;
			if (roleItem != null)
			{
				roleItem.Update(roleEntry);
			}
			RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(roleEntry.ConfigId);
			RoleSelectItem roleItem2 = this.RoleItem;
			if (roleItem2 == null)
			{
				return;
			}
			roleItem2.GetRootItem().SetUIActive(rogueCharacterConfig != null);
		}

		// Token: 0x0401B549 RID: 111945
		public PhantomSelectItem PhantomItem;

		// Token: 0x0401B54A RID: 111946
		public RoleSelectItem RoleItem;

		// Token: 0x0401B54B RID: 111947
		[Nullable(1)]
		public List<AttributeItem> AttributeItemList = new List<AttributeItem>();

		// Token: 0x0401B54C RID: 111948
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401B54D RID: 111949
		private RogueInfoViewModel Vm;

		// Token: 0x0200AF82 RID: 44930
		[NullableContext(0)]
		private class ERogueInfoOverviewDefine
		{
			// Token: 0x040354A6 RID: 218278
			public const int PhantomItem = 0;

			// Token: 0x040354A7 RID: 218279
			public const int RoleItem = 1;

			// Token: 0x040354A8 RID: 218280
			public const int AttrPanelItem = 2;

			// Token: 0x040354A9 RID: 218281
			public const int AttrItem = 3;

			// Token: 0x040354AA RID: 218282
			public const int BtnMore = 4;
		}
	}
}
