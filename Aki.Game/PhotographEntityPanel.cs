using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020025CD RID: 9677
[NullableContext(1)]
[Nullable(0)]
public class PhotographEntityPanel : UiPanelBase
{
	// Token: 0x06013A13 RID: 80403 RVA: 0x004E87F8 File Offset: 0x004E69F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06013A14 RID: 80404 RVA: 0x004E8894 File Offset: 0x004E6A94
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayoutNew<EntityInfoItem>(base.GetVerticalLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<EntityInfoItem>(this.CreateInfoItem), null);
		this.FatherIcon = base.GetItem(5);
		PhotographController.Instance.CloseBlackScreen().Forget();
	}

	// Token: 0x06013A15 RID: 80405 RVA: 0x004E88D4 File Offset: 0x004E6AD4
	protected override void OnBeforeDestroy()
	{
		if (this.InfoLayout != null)
		{
			this.InfoLayout.ClearChildren();
			this.InfoLayout = null;
		}
		this.NodeIconMap.Clear();
		this.MissionsInfoMap.Clear();
		this.InfoIconMap.Clear();
		this.FatherIcon = null;
	}

	// Token: 0x06013A16 RID: 80406 RVA: 0x004E8924 File Offset: 0x004E6B24
	public void Refresh(List<IInfoData> infoList)
	{
		this.MissionsInfoMap.Clear();
		int count = infoList.Count;
		for (int i = 0; i < count; i++)
		{
			this.MissionsInfoMap.Add(infoList[i].Text, i);
		}
		this.InfoLayout.RebuildLayoutByDataNew<IInfoData>(infoList, null);
	}

	// Token: 0x06013A17 RID: 80407 RVA: 0x004E897C File Offset: 0x004E6B7C
	public void SetInfoPanelVisible(bool bVisible)
	{
		base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06013A18 RID: 80408 RVA: 0x004E89A4 File Offset: 0x004E6BA4
	public void UpdateIcons(List<IPositionData> positionList, [Nullable(2)] EntityPhotoBehaviorNode node)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (IPositionData positionData in positionList)
		{
			hashSet.Add(positionData.Id);
		}
		foreach (IPositionData positionData2 in positionList)
		{
			if (!this.InfoIconMap.ContainsKey(positionData2.Id))
			{
				EntityIconItem entityIconItem = new EntityIconItem(LguiUtil.Instance.CopyItem(this.FatherIcon, base.GetItem(0)));
				entityIconItem.CreateByActorAsync(entityIconItem.GetItsItem().GetOwner(), null, false).Forget();
				if (entityIconItem == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Photo;
					ELogAuthor author = ELogAuthor.JYS;
					string message = "tempUiItem为空";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名称：", positionData2.Id);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					entityIconItem.SetUiActive(true);
					entityIconItem.InitSpr();
					this.InfoIconMap.Add(positionData2.Id, entityIconItem);
					if (this.NodeIconMap.ContainsKey(node))
					{
						List<EntityIconItem> list = this.NodeIconMap[node];
						if (list != null && !list.Contains(entityIconItem))
						{
							list.Add(entityIconItem);
							this.NodeIconMap[node] = list;
						}
					}
					else
					{
						List<EntityIconItem> list2 = new List<EntityIconItem>();
						list2.Add(entityIconItem);
						this.NodeIconMap.Add(node, list2);
					}
					this.Move(entityIconItem, new FVector2D?(positionData2.Vector), true, positionData2.IsOptional, positionData2.IsOptionalFinished, node);
				}
			}
			else
			{
				EntityIconItem entityIcon = this.InfoIconMap[positionData2.Id];
				this.Move(entityIcon, new FVector2D?(positionData2.Vector), positionData2.NotShow, positionData2.IsOptional, positionData2.IsOptionalFinished, node);
			}
		}
		List<EntityIconItem> list3;
		if (node != null && this.NodeIconMap.TryGetValue(node, out list3))
		{
			foreach (KeyValuePair<string, EntityIconItem> keyValuePair in this.InfoIconMap)
			{
				if (list3.Contains(keyValuePair.Value) && !hashSet.Contains(keyValuePair.Key))
				{
					this.Move(keyValuePair.Value, null, true, false, false, node);
				}
			}
		}
	}

	// Token: 0x06013A19 RID: 80409 RVA: 0x004E8C5C File Offset: 0x004E6E5C
	public void Move(EntityIconItem entityIcon, FVector2D? vector2D, bool bNotShow, bool bIsOptional, bool bIsOptionalFinished, EntityPhotoBehaviorNode node)
	{
		UUIItem itsItem = entityIcon.GetItsItem();
		itsItem.SetUIActive(true);
		if (vector2D != null)
		{
			itsItem.SetAnchorOffset(vector2D.Value);
		}
		if (bIsOptionalFinished || bNotShow)
		{
			entityIcon.UpdateNowIcon(ESprColor.None);
			return;
		}
		if (bIsOptional)
		{
			entityIcon.UpdateNowIcon(ESprColor.Green);
			return;
		}
		bool flag = false;
		if (node.RangeEntity != 0 && PhotographController.Instance.PhotoMissionFinishMap.TryGetValue(node.RangeEntity, out flag))
		{
			entityIcon.UpdateNowIcon(flag ? ESprColor.Green : ESprColor.Yellow);
			return;
		}
		entityIcon.UpdateNowIcon(ESprColor.Yellow);
	}

	// Token: 0x06013A1A RID: 80410 RVA: 0x004E8CE4 File Offset: 0x004E6EE4
	[return: Nullable(2)]
	public EntityInfoItem GetInfoItemByDesc(string id)
	{
		int index;
		if (this.MissionsInfoMap.TryGetValue(id, out index))
		{
			return this.InfoLayout.GetLayoutItemByIndex(index);
		}
		return null;
	}

	// Token: 0x06013A1B RID: 80411 RVA: 0x004E8D10 File Offset: 0x004E6F10
	private ILayoutItem<EntityInfoItem> CreateInfoItem(object data, UUIItem uiItem, int index)
	{
		EntityInfoItem entityInfoItem = new EntityInfoItem();
		entityInfoItem.SetRootActor(uiItem.GetOwner(), true);
		entityInfoItem.InitSpr();
		entityInfoItem.Refresh((IInfoData)data);
		return new LayoutItem<EntityInfoItem>
		{
			Key = index,
			Value = entityInfoItem
		};
	}

	// Token: 0x04009402 RID: 37890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<EntityInfoItem> InfoLayout;

	// Token: 0x04009403 RID: 37891
	[Nullable(2)]
	private UUIItem FatherIcon;

	// Token: 0x04009404 RID: 37892
	private readonly Dictionary<string, int> MissionsInfoMap = new Dictionary<string, int>();

	// Token: 0x04009405 RID: 37893
	private readonly Dictionary<EntityPhotoBehaviorNode, List<EntityIconItem>> NodeIconMap = new Dictionary<EntityPhotoBehaviorNode, List<EntityIconItem>>();

	// Token: 0x04009406 RID: 37894
	private readonly Dictionary<string, EntityIconItem> InfoIconMap = new Dictionary<string, EntityIconItem>();

	// Token: 0x02008BDC RID: 35804
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D66D RID: 185965
		Panel,
		// Token: 0x0402D66E RID: 185966
		PanelInfoLayout,
		// Token: 0x0402D66F RID: 185967
		ItemInfo,
		// Token: 0x0402D670 RID: 185968
		PanelArea,
		// Token: 0x0402D671 RID: 185969
		PanelAreaGreen,
		// Token: 0x0402D672 RID: 185970
		TargetIcon
	}
}
