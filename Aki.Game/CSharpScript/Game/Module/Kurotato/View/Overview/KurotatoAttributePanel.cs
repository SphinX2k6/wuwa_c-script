using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200471A RID: 18202
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttributePanel : UiPanelBase
	{
		// Token: 0x0602DBAE RID: 187310 RVA: 0x00CCA188 File Offset: 0x00CC8388
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickMore));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DBAF RID: 187311 RVA: 0x00CCA294 File Offset: 0x00CC8494
		protected override void OnStart()
		{
			this.CreateAttrList();
			this.RefreshAttrList();
			this.RefreshToggle();
			EventSystem.Instance.Add<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPlayerAttrChanged));
			this.AttrListenDelegate = DelegateUtils.ToManualReleaseDelegate<FOnKSCAllAttrChange>(new Action<EKSC_AttrType, int, int>(this.OnKscAttrChanged));
			KurotatoModel.Instance.BattleData.AssignAllPlayerAttrListen(this.AttrListenDelegate);
		}

		// Token: 0x0602DBB0 RID: 187312 RVA: 0x00CCA2FC File Offset: 0x00CC84FC
		public void HideAllChangeFx()
		{
			if (this.LoopScrollView == null)
			{
				return;
			}
			int displayGridStartIndex = this.LoopScrollView.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.LoopScrollView.GetDisplayGridEndIndex();
			for (int i = Math.Max(0, displayGridStartIndex); i <= displayGridEndIndex; i++)
			{
				AttributeItem attributeItem = this.LoopScrollView.UnsafeGetGridProxy(i, false);
				if (attributeItem != null)
				{
					attributeItem.HideChangeFx();
				}
			}
		}

		// Token: 0x0602DBB1 RID: 187313 RVA: 0x00CCA354 File Offset: 0x00CC8554
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPlayerAttrChanged));
			if (this.AttrListenDelegate != null)
			{
				KurotatoModel.Instance.BattleData.RemoveAllPlayerAttrListen(this.AttrListenDelegate);
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int, int>(this.OnKscAttrChanged));
				this.AttrListenDelegate = null;
			}
		}

		// Token: 0x0602DBB2 RID: 187314 RVA: 0x00CCA3B2 File Offset: 0x00CC85B2
		private void OnPlayerAttrChanged(IDictionary<int, int> propertyValues)
		{
			this.RefreshAttributeList();
		}

		// Token: 0x0602DBB3 RID: 187315 RVA: 0x00CCA3BA File Offset: 0x00CC85BA
		private void OnKscAttrChanged(EKSC_AttrType attrType, int oldValue, int newValue)
		{
			this.RefreshAttributeList();
		}

		// Token: 0x0602DBB4 RID: 187316 RVA: 0x00CCA3C2 File Offset: 0x00CC85C2
		[NullableContext(2)]
		public void SetSavePropertyMap(Dictionary<int, int> propertyMap)
		{
			this.SavePropertyMap = propertyMap;
			if (this.LoopScrollView != null)
			{
				this.RefreshAttrList();
			}
		}

		// Token: 0x0602DBB5 RID: 187317 RVA: 0x00CCA3DC File Offset: 0x00CC85DC
		public void ShowPreview(IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			this.PreviewMap.Clear();
			foreach (IKurotatoAttrPreviewDelta kurotatoAttrPreviewDelta in deltas)
			{
				this.PreviewMap[kurotatoAttrPreviewDelta.PropertyId] = kurotatoAttrPreviewDelta;
			}
			if (this.LoopScrollView != null)
			{
				this.RefreshAttrList();
			}
		}

		// Token: 0x0602DBB6 RID: 187318 RVA: 0x00CCA448 File Offset: 0x00CC8648
		public void ClearPreview()
		{
			this.PreviewMap.Clear();
			if (this.LoopScrollView != null)
			{
				this.RefreshAttrList();
			}
		}

		// Token: 0x0602DBB7 RID: 187319 RVA: 0x00CCA464 File Offset: 0x00CC8664
		public void RefreshAttributeList()
		{
			if (this.LoopScrollView == null)
			{
				return;
			}
			List<IAttributeListItem> list = this.BuildAttrList();
			int displayGridStartIndex = this.LoopScrollView.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.LoopScrollView.GetDisplayGridEndIndex();
			int num = Math.Max(0, displayGridStartIndex);
			while (num <= displayGridEndIndex && num < list.Count)
			{
				IAttributeListItem attributeListItem = this.LoopScrollView.TryGetCachedData(num);
				if (attributeListItem != null && attributeListItem.AttrId == list[num].AttrId && attributeListItem.Value != list[num].Value)
				{
					list[num].JustChanged = new bool?(true);
				}
				num++;
			}
			this.LoopScrollView.RefreshByData(list, false, null, false);
		}

		// Token: 0x0602DBB8 RID: 187320 RVA: 0x00CCA511 File Offset: 0x00CC8711
		protected bool OnCheckBattleChildViewPanelShowCondition()
		{
			return false;
		}

		// Token: 0x0602DBB9 RID: 187321 RVA: 0x00CCA514 File Offset: 0x00CC8714
		private void CreateAttrList()
		{
			this.LoopScrollView = new LoopScrollView<AttributeItem, IAttributeListItem>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, () => new AttributeItem(), false);
		}

		// Token: 0x0602DBBA RID: 187322 RVA: 0x00CCA564 File Offset: 0x00CC8764
		private void RefreshToggle()
		{
			base.GetExtendToggle(0).SetToggleState((this.SelectedType != EKurotatoPropertyType.Main) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602DBBB RID: 187323 RVA: 0x00CCA583 File Offset: 0x00CC8783
		private void RefreshAttrList()
		{
			this.LoopScrollView.RefreshByData(this.BuildAttrList(), false, null, false);
		}

		// Token: 0x0602DBBC RID: 187324 RVA: 0x00CCA59C File Offset: 0x00CC879C
		private List<IAttributeListItem> BuildAttrList()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			bool flag = this.SavePropertyMap != null;
			List<KurotatoProperty> list = new List<KurotatoProperty>();
			foreach (KurotatoProperty item in KurotatoConfig.Instance.GetAllProperty())
			{
				if (item.RoleType == (int)this.SelectedType)
				{
					list.Add(item);
				}
			}
			NoLinq.SortStable<KurotatoProperty>(list, (KurotatoProperty left, KurotatoProperty right) => left.Priority.CompareTo(right.Priority));
			List<IAttributeListItem> list2 = new List<IAttributeListItem>(list.Count);
			foreach (KurotatoProperty kurotatoProperty in list)
			{
				bool flag2 = !flag && instance.IsPropertyLocked(kurotatoProperty.Id);
				List<IAttributeListItem> list3 = list2;
				AttributeListItem attributeListItem = new AttributeListItem();
				attributeListItem.AttrId = kurotatoProperty.Id;
				Dictionary<int, int> savePropertyMap = this.SavePropertyMap;
				attributeListItem.Value = ((savePropertyMap != null) ? savePropertyMap.GetValueOrDefault(kurotatoProperty.Id, 0) : instance.GetPropertyValue(kurotatoProperty.Id));
				attributeListItem.IsRecommend = false;
				attributeListItem.BaseValue = new int?(kurotatoProperty.BasicValue);
				attributeListItem.IsLocked = new bool?(flag2);
				attributeListItem.LockedValue = new int?(flag2 ? instance.GetPropertyLockedValue(kurotatoProperty.Id) : 0);
				attributeListItem.Preview = this.PreviewMap.GetValueOrDefault(kurotatoProperty.Id);
				list3.Add(attributeListItem);
			}
			return list2;
		}

		// Token: 0x0602DBBD RID: 187325 RVA: 0x00CCA740 File Offset: 0x00CC8940
		private void OnClickToggle(EToggleState state)
		{
			this.SelectedType = ((state == EToggleState.ETT_Checked) ? EKurotatoPropertyType.Sub : EKurotatoPropertyType.Main);
			this.RefreshAttrList();
		}

		// Token: 0x0602DBBE RID: 187326 RVA: 0x00CCA756 File Offset: 0x00CC8956
		private void OnClickMore()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoAttributeDetailView, null, null);
		}

		// Token: 0x0401872A RID: 100138
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<AttributeItem, IAttributeListItem> LoopScrollView;

		// Token: 0x0401872B RID: 100139
		private EKurotatoPropertyType SelectedType = EKurotatoPropertyType.Main;

		// Token: 0x0401872C RID: 100140
		[Nullable(2)]
		private Dictionary<int, int> SavePropertyMap;

		// Token: 0x0401872D RID: 100141
		private readonly Dictionary<int, IKurotatoAttrPreviewDelta> PreviewMap = new Dictionary<int, IKurotatoAttrPreviewDelta>();

		// Token: 0x0401872E RID: 100142
		[Nullable(2)]
		private FOnKSCAllAttrChange AttrListenDelegate;

		// Token: 0x0200A34B RID: 41803
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x04032A1C RID: 207388
			ToggleTab,
			// Token: 0x04032A1D RID: 207389
			LoopScroll,
			// Token: 0x04032A1E RID: 207390
			AttributeItem,
			// Token: 0x04032A1F RID: 207391
			ButtonMore
		}
	}
}
