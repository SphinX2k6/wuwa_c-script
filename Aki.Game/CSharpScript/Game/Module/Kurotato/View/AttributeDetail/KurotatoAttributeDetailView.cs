using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttributeDetail
{
	// Token: 0x02004759 RID: 18265
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttributeDetailView : UiViewBase
	{
		// Token: 0x0602DD94 RID: 187796 RVA: 0x00CD519E File Offset: 0x00CD339E
		public KurotatoAttributeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DD95 RID: 187797 RVA: 0x00CD51A8 File Offset: 0x00CD33A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DD96 RID: 187798 RVA: 0x00CD5234 File Offset: 0x00CD3434
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
			this.CaptionItem.SetTitleLocalText("PrefabTextItem_1302715335_Text");
			this.CaptionItem.SetHelpCallBack(delegate
			{
				int helpIdAttrInfo = KurotatoConfig.Instance.GetHelpIdAttrInfo();
				HelpController.Instance.OpenHelpById(helpIdAttrInfo);
			});
			this.AttrLayout = new GenericLayout<KurotatoRoleAttributeItem, IKurotatoRoleSkillInfo>(base.GetVerticalLayout(1), new Func<KurotatoRoleAttributeItem>(this.InitAttrItem), null, false, true);
			this.RefreshAttrList();
			EventSystem.Instance.Emit<bool>(EEventName.AttributeComponentEvent, true);
			EventSystem.Instance.Add<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnAttrChanged));
			this.AttrListenDelegate = DelegateUtils.ToManualReleaseDelegate<FOnKSCAllAttrChange>(new Action<EKSC_AttrType, int, int>(this.OnKscAttrChanged));
			KurotatoModel.Instance.BattleData.AssignAllPlayerAttrListen(this.AttrListenDelegate);
		}

		// Token: 0x0602DD97 RID: 187799 RVA: 0x00CD5328 File Offset: 0x00CD3528
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<IDictionary<int, int>>(EEventName.KurotatoOnPropertyUpdate, new Action<IDictionary<int, int>>(this.OnAttrChanged));
			if (this.AttrListenDelegate != null)
			{
				KurotatoModel.Instance.BattleData.RemoveAllPlayerAttrListen(this.AttrListenDelegate);
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int, int>(this.OnKscAttrChanged));
				this.AttrListenDelegate = null;
			}
			this.CaptionItem.Destroy(null);
			if (this.AttrLayout != null)
			{
				this.AttrLayout = null;
			}
		}

		// Token: 0x0602DD98 RID: 187800 RVA: 0x00CD53A1 File Offset: 0x00CD35A1
		private void OnAttrChanged(IDictionary<int, int> propertyValues)
		{
			this.RefreshAttrList();
		}

		// Token: 0x0602DD99 RID: 187801 RVA: 0x00CD53A9 File Offset: 0x00CD35A9
		private void OnKscAttrChanged(EKSC_AttrType attrType, int oldValue, int newValue)
		{
			this.RefreshAttrList();
		}

		// Token: 0x0602DD9A RID: 187802 RVA: 0x00CD53B4 File Offset: 0x00CD35B4
		private void RefreshAttrList()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			IReadOnlyList<KurotatoProperty> allProperty = KurotatoConfig.Instance.GetAllProperty();
			List<KurotatoProperty> list = new List<KurotatoProperty>();
			for (int i = 0; i < allProperty.Count; i++)
			{
				if (allProperty[i].RoleType != 0)
				{
					list.Add(allProperty[i]);
				}
			}
			list.Sort(delegate(KurotatoProperty a, KurotatoProperty b)
			{
				if (a.RoleType != b.RoleType)
				{
					return a.RoleType - b.RoleType;
				}
				if (a.Priority == 0 && b.Priority == 0)
				{
					return a.Id - b.Id;
				}
				int num = a.Priority - b.Priority;
				if (num == 0)
				{
					return a.Id - b.Id;
				}
				return num;
			});
			List<IKurotatoRoleSkillInfo> list2 = new List<IKurotatoRoleSkillInfo>(list.Count);
			for (int j = 0; j < list.Count; j++)
			{
				KurotatoProperty kurotatoProperty = list[j];
				bool flag = instance.IsPropertyLocked(kurotatoProperty.Id);
				list2.Add(new KurotatoRoleSkillInfo
				{
					AttrId = kurotatoProperty.Id,
					Value = instance.GetPropertyValue(kurotatoProperty.Id),
					IsRecommend = false,
					BaseValue = new int?(kurotatoProperty.BasicValue),
					IsLocked = new bool?(flag),
					LockedValue = new int?(flag ? instance.GetPropertyLockedValue(kurotatoProperty.Id) : 0)
				});
			}
			this.AttrLayout.RefreshByData(list2, null, true);
		}

		// Token: 0x0602DD9B RID: 187803 RVA: 0x00CD54F1 File Offset: 0x00CD36F1
		private KurotatoRoleAttributeItem InitAttrItem()
		{
			return new KurotatoRoleAttributeItem();
		}

		// Token: 0x0602DD9C RID: 187804 RVA: 0x00CD54F8 File Offset: 0x00CD36F8
		private void OnBackButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040187F2 RID: 100338
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040187F3 RID: 100339
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoRoleAttributeItem, IKurotatoRoleSkillInfo> AttrLayout;

		// Token: 0x040187F4 RID: 100340
		[Nullable(2)]
		private FOnKSCAllAttrChange AttrListenDelegate;

		// Token: 0x0200A3BA RID: 41914
		[NullableContext(0)]
		private enum EAttributeView
		{
			// Token: 0x04032C06 RID: 207878
			ItemCaption,
			// Token: 0x04032C07 RID: 207879
			AttributeContent,
			// Token: 0x04032C08 RID: 207880
			ItemAttribute
		}
	}
}
