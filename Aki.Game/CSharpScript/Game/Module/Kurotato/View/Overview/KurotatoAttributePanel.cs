using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005743 RID: 22339
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttributePanel : UiPanelBase
	{
		// Token: 0x06038C9E RID: 232606 RVA: 0x00D7BAD8 File Offset: 0x00D79CD8
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

		// Token: 0x06038C9F RID: 232607 RVA: 0x00D7BBE4 File Offset: 0x00D79DE4
		protected override void OnStart()
		{
			this.CreateAttrList();
			this.RefreshAttrList();
			this.RefreshToggle();
			EventSystem.Instance.Add<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnPlayerAttrChanged));
			this.AttrListenDelegate = DelegateUtils.ToManualReleaseDelegate<FOnKSCAllAttrChange>(new Action<EKSC_AttrType, int, int>(this.OnKscAttrChanged));
			KurotatoModel.Instance.BattleData.AssignAllPlayerAttrListen(this.AttrListenDelegate);
		}

		// Token: 0x06038CA0 RID: 232608 RVA: 0x00D7BC4C File Offset: 0x00D79E4C
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

		// Token: 0x06038CA1 RID: 232609 RVA: 0x00D7BCA4 File Offset: 0x00D79EA4
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

		// Token: 0x06038CA2 RID: 232610 RVA: 0x00D7BD02 File Offset: 0x00D79F02
		private void OnPlayerAttrChanged(IDictionary<int, int> propertyValues)
		{
			this.RefreshAttributeList();
		}

		// Token: 0x06038CA3 RID: 232611 RVA: 0x00D7BD0A File Offset: 0x00D79F0A
		private void OnKscAttrChanged(EKSC_AttrType attrType, int oldValue, int newValue)
		{
			this.RefreshAttributeList();
		}

		// Token: 0x06038CA4 RID: 232612 RVA: 0x00D7BD12 File Offset: 0x00D79F12
		[NullableContext(2)]
		public void SetSavePropertyMap(Dictionary<int, int> propertyMap)
		{
			this.SavePropertyMap = propertyMap;
			if (this.LoopScrollView != null)
			{
				this.RefreshAttrList();
			}
		}

		// Token: 0x06038CA5 RID: 232613 RVA: 0x00D7BD2C File Offset: 0x00D79F2C
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

		// Token: 0x06038CA6 RID: 232614 RVA: 0x00D7BD98 File Offset: 0x00D79F98
		public void ClearPreview()
		{
			this.PreviewMap.Clear();
			if (this.LoopScrollView != null)
			{
				this.RefreshAttrList();
			}
		}

		// Token: 0x06038CA7 RID: 232615 RVA: 0x00D7BDB4 File Offset: 0x00D79FB4
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

		// Token: 0x06038CA8 RID: 232616 RVA: 0x00D7BE61 File Offset: 0x00D7A061
		protected bool OnCheckBattleChildViewPanelShowCondition()
		{
			return false;
		}

		// Token: 0x06038CA9 RID: 232617 RVA: 0x00D7BE64 File Offset: 0x00D7A064
		private void CreateAttrList()
		{
			this.LoopScrollView = new LoopScrollView<AttributeItem, IAttributeListItem>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, () => new AttributeItem(), false);
		}

		// Token: 0x06038CAA RID: 232618 RVA: 0x00D7BEB4 File Offset: 0x00D7A0B4
		private void RefreshToggle()
		{
			base.GetExtendToggle(0).SetToggleState((this.SelectedType != EKurotatoPropertyType.Main) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038CAB RID: 232619 RVA: 0x00D7BED3 File Offset: 0x00D7A0D3
		private void RefreshAttrList()
		{
			this.LoopScrollView.RefreshByData(this.BuildAttrList(), false, null, false);
		}

		// Token: 0x06038CAC RID: 232620 RVA: 0x00D7BEEC File Offset: 0x00D7A0EC
		private List<IAttributeListItem> BuildAttrList()
		{
			KurotatoModel model = KurotatoModel.Instance;
			bool isSaveMode = this.SavePropertyMap != null;
			return (from config in KurotatoConfig.Instance.GetAllProperty()
			where config.RoleType == (int)this.SelectedType
			orderby config.Priority
			select config).Select(delegate(KurotatoProperty config)
			{
				bool flag = !isSaveMode && model.IsPropertyLocked(config.Id);
				AttributeListItem attributeListItem = new AttributeListItem();
				attributeListItem.AttrId = config.Id;
				Dictionary<int, int> savePropertyMap = this.SavePropertyMap;
				attributeListItem.Value = ((savePropertyMap != null) ? savePropertyMap.GetValueOrDefault(config.Id, 0) : model.GetPropertyValue(config.Id));
				attributeListItem.IsRecommend = false;
				attributeListItem.BaseValue = new int?(config.BasicValue);
				attributeListItem.IsLocked = new bool?(flag);
				attributeListItem.LockedValue = new int?(flag ? model.GetPropertyLockedValue(config.Id) : 0);
				attributeListItem.Preview = this.PreviewMap.GetValueOrDefault(config.Id);
				return attributeListItem;
			}).ToList<IAttributeListItem>();
		}

		// Token: 0x06038CAD RID: 232621 RVA: 0x00D7BF75 File Offset: 0x00D7A175
		private void OnClickToggle(EToggleState state)
		{
			this.SelectedType = ((state == EToggleState.ETT_Checked) ? EKurotatoPropertyType.Sub : EKurotatoPropertyType.Main);
			this.RefreshAttrList();
		}

		// Token: 0x06038CAE RID: 232622 RVA: 0x00D7BF8B File Offset: 0x00D7A18B
		private void OnClickMore()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoAttributeDetailView, null, null);
		}

		// Token: 0x0401DC94 RID: 122004
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<AttributeItem, IAttributeListItem> LoopScrollView;

		// Token: 0x0401DC95 RID: 122005
		private EKurotatoPropertyType SelectedType = EKurotatoPropertyType.Main;

		// Token: 0x0401DC96 RID: 122006
		[Nullable(2)]
		private Dictionary<int, int> SavePropertyMap;

		// Token: 0x0401DC97 RID: 122007
		private readonly Dictionary<int, IKurotatoAttrPreviewDelta> PreviewMap = new Dictionary<int, IKurotatoAttrPreviewDelta>();

		// Token: 0x0401DC98 RID: 122008
		[Nullable(2)]
		private FOnKSCAllAttrChange AttrListenDelegate;

		// Token: 0x0200B92A RID: 47402
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x0403800C RID: 229388
			ToggleTab,
			// Token: 0x0403800D RID: 229389
			LoopScroll,
			// Token: 0x0403800E RID: 229390
			AttributeItem,
			// Token: 0x0403800F RID: 229391
			ButtonMore
		}
	}
}
