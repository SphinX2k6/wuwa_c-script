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

namespace CSharpScript.Game.Module.Kurotato.View.AttributeDetail
{
	// Token: 0x02005782 RID: 22402
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttributeDetailView : UiViewBase
	{
		// Token: 0x06038E84 RID: 233092 RVA: 0x00D864DE File Offset: 0x00D846DE
		public KurotatoAttributeDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038E85 RID: 233093 RVA: 0x00D864E8 File Offset: 0x00D846E8
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

		// Token: 0x06038E86 RID: 233094 RVA: 0x00D86574 File Offset: 0x00D84774
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

		// Token: 0x06038E87 RID: 233095 RVA: 0x00D86668 File Offset: 0x00D84868
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

		// Token: 0x06038E88 RID: 233096 RVA: 0x00D866E1 File Offset: 0x00D848E1
		private void OnAttrChanged(IDictionary<int, int> propertyValues)
		{
			this.RefreshAttrList();
		}

		// Token: 0x06038E89 RID: 233097 RVA: 0x00D866E9 File Offset: 0x00D848E9
		private void OnKscAttrChanged(EKSC_AttrType attrType, int oldValue, int newValue)
		{
			this.RefreshAttrList();
		}

		// Token: 0x06038E8A RID: 233098 RVA: 0x00D866F4 File Offset: 0x00D848F4
		private void RefreshAttrList()
		{
			KurotatoModel model = KurotatoModel.Instance;
			List<IKurotatoRoleSkillInfo> data = (from config in KurotatoConfig.Instance.GetAllProperty()
			where config.RoleType != 0
			select config).OrderBy((KurotatoProperty config) => config, Comparer<KurotatoProperty>.Create(delegate(KurotatoProperty a, KurotatoProperty b)
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
			})).Select(delegate(KurotatoProperty config)
			{
				bool flag = model.IsPropertyLocked(config.Id);
				return new KurotatoRoleSkillInfo
				{
					AttrId = config.Id,
					Value = model.GetPropertyValue(config.Id),
					IsRecommend = false,
					BaseValue = new int?(config.BasicValue),
					IsLocked = new bool?(flag),
					LockedValue = new int?(flag ? model.GetPropertyLockedValue(config.Id) : 0)
				};
			}).ToList<IKurotatoRoleSkillInfo>();
			this.AttrLayout.RefreshByData(data, null, true);
		}

		// Token: 0x06038E8B RID: 233099 RVA: 0x00D867AD File Offset: 0x00D849AD
		private KurotatoRoleAttributeItem InitAttrItem()
		{
			return new KurotatoRoleAttributeItem();
		}

		// Token: 0x06038E8C RID: 233100 RVA: 0x00D867B4 File Offset: 0x00D849B4
		private void OnBackButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DD5C RID: 122204
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DD5D RID: 122205
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoRoleAttributeItem, IKurotatoRoleSkillInfo> AttrLayout;

		// Token: 0x0401DD5E RID: 122206
		[Nullable(2)]
		private FOnKSCAllAttrChange AttrListenDelegate;

		// Token: 0x0200B9A2 RID: 47522
		[NullableContext(0)]
		private enum EAttributeView
		{
			// Token: 0x04038211 RID: 229905
			ItemCaption,
			// Token: 0x04038212 RID: 229906
			AttributeContent,
			// Token: 0x04038213 RID: 229907
			ItemAttribute
		}
	}
}
