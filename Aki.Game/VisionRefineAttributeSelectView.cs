using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C21 RID: 3105
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineAttributeSelectView : UiViewBase
{
	// Token: 0x06008182 RID: 33154 RVA: 0x0027B827 File Offset: 0x00279A27
	public VisionRefineAttributeSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008183 RID: 33155 RVA: 0x0027B844 File Offset: 0x00279A44
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirm))
		};
	}

	// Token: 0x06008184 RID: 33156 RVA: 0x0027B930 File Offset: 0x00279B30
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributeSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributeSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008185 RID: 33157 RVA: 0x0027B974 File Offset: 0x00279B74
	protected override void OnStart()
	{
		IRefineAttrSelectViewOpenParam refineAttrSelectViewOpenParam = this.OpenParam as IRefineAttrSelectViewOpenParam;
		this.IncId = refineAttrSelectViewOpenParam.IncId;
		this.CallbackConfirm = refineAttrSelectViewOpenParam.Callback;
		this.GetSelectedPropItemIdList = refineAttrSelectViewOpenParam.GetSelectedPropItemIdList;
		this.Selection = refineAttrSelectViewOpenParam.SelectAttribute;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(this.IncId);
		AttrListScrollData attrListScrollData = phantomDataBase.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false)[0];
		int[] visionRefineRecommendAttributes = CalabashModel.Instance.GetVisionRefineRecommendAttributes(phantomDataBase.GetCost(), phantomDataBase.GetFetterGroupId());
		int[] phantomMainPropItemRefineAvailableIdList = PhantomBattleModel.Instance.GetPhantomMainPropItemRefineAvailableIdList(phantomDataBase.GetConfigId(false));
		List<IRefineAttrItemData> list = new List<IRefineAttrItemData>();
		int? chosenIndex = null;
		for (int i = 0; i < phantomMainPropItemRefineAvailableIdList.Length; i++)
		{
			int num = phantomMainPropItemRefineAvailableIdList[i];
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(num);
			RefineAttrItemData item = new RefineAttrItemData
			{
				PropItemId = num,
				PropIndexId = phantomMainPropertyItemId.PropId,
				IsRecommend = (refineAttrSelectViewOpenParam.DataConfirmed && Array.IndexOf<int>(visionRefineRecommendAttributes, phantomMainPropertyItemId.PropId) >= 0),
				IsDisable = (refineAttrSelectViewOpenParam.DataConfirmed && attrListScrollData.Id == phantomMainPropertyItemId.PropId)
			};
			list.Add(item);
			if (refineAttrSelectViewOpenParam.SelectAttribute != null && refineAttrSelectViewOpenParam.SelectAttribute.PropItemId == num)
			{
				chosenIndex = new int?(i);
			}
		}
		this.Attributes = list.ToArray();
		this.AttributeLayout.RefreshByData(this.Attributes, chosenIndex);
		this.RefreshTips();
	}

	// Token: 0x06008186 RID: 33158 RVA: 0x0027BAF3 File Offset: 0x00279CF3
	protected override void OnBeforeShow()
	{
		this.RefreshConfirm();
	}

	// Token: 0x06008187 RID: 33159 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private void RefreshConfirm()
	{
		if (this.Selection == null)
		{
			base.GetButton(1).SetSelfInteractive(false);
			return;
		}
		base.GetButton(1).SetSelfInteractive(true);
	}

	// Token: 0x06008188 RID: 33160 RVA: 0x0027BB20 File Offset: 0x00279D20
	private void RefreshTips()
	{
		if (this.GetSelectedPropItemIdList != null)
		{
			int[] array = this.GetSelectedPropItemIdList();
			IRefineAttrItemData selection = this.Selection;
			int? num = (selection != null) ? new int?(selection.PropItemId) : null;
			if (num != null && array.Length != 0)
			{
				int num2 = 0;
				foreach (int num3 in array)
				{
					int? num4 = num;
					if (num3 == num4.GetValueOrDefault() & num4 != null)
					{
						num2++;
					}
				}
				if (num2 > 0)
				{
					UUIItem item = base.GetItem(5);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Text_VisionRefine_CanRefineWithNumber_Text", new <>z__ReadOnlySingleElementList<object>(num2.ToString()));
					return;
				}
			}
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06008189 RID: 33161 RVA: 0x0027BBF3 File Offset: 0x00279DF3
	private void OnClickConfirm()
	{
		if (this.CallbackConfirm != null)
		{
			this.CallbackConfirm(this.Selection);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600818A RID: 33162 RVA: 0x0027BC15 File Offset: 0x00279E15
	private void OnClickAttribute(IRefineAttrItemData data)
	{
		this.Selection = data;
		this.RefreshConfirm();
		this.RefreshTips();
	}

	// Token: 0x04004F92 RID: 20370
	private int IncId = -1;

	// Token: 0x04004F93 RID: 20371
	[Nullable(2)]
	private IRefineAttrItemData Selection;

	// Token: 0x04004F94 RID: 20372
	private IRefineAttrItemData[] Attributes = new IRefineAttrItemData[0];

	// Token: 0x04004F95 RID: 20373
	[Nullable(2)]
	private AttributeSelectPanel AttributeLayout;

	// Token: 0x04004F96 RID: 20374
	[Nullable(2)]
	private Action<IRefineAttrItemData> CallbackConfirm;

	// Token: 0x04004F97 RID: 20375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<int[]> GetSelectedPropItemIdList;

	// Token: 0x02006EE1 RID: 28385
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243F0 RID: 148464
		ClearButton,
		// Token: 0x040243F1 RID: 148465
		ConfirmButton,
		// Token: 0x040243F2 RID: 148466
		BaseLayout,
		// Token: 0x040243F3 RID: 148467
		AttributeLayout,
		// Token: 0x040243F4 RID: 148468
		TitleText,
		// Token: 0x040243F5 RID: 148469
		DownLeftRoot,
		// Token: 0x040243F6 RID: 148470
		TipsText,
		// Token: 0x040243F7 RID: 148471
		IconItem
	}
}
