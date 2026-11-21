using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001AB8 RID: 6840
[NullableContext(1)]
[Nullable(0)]
public class PhotographEntityPanel : UiPanelBase
{
	// Token: 0x06010EF3 RID: 69363 RVA: 0x004F73F8 File Offset: 0x004F55F8
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

	// Token: 0x06010EF4 RID: 69364 RVA: 0x004F7494 File Offset: 0x004F5694
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayoutNew<EntityInfoItem>(base.GetVerticalLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<EntityInfoItem>(this.CreateInfoItem), null);
		this.FatherIcon = base.GetItem(5);
		PhotographController.Instance.CloseBlackScreen().Forget();
	}

	// Token: 0x06010EF5 RID: 69365 RVA: 0x004F74D4 File Offset: 0x004F56D4
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

	// Token: 0x06010EF6 RID: 69366 RVA: 0x004F7524 File Offset: 0x004F5724
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

	// Token: 0x06010EF7 RID: 69367 RVA: 0x004F757C File Offset: 0x004F577C
	public void SetInfoPanelVisible(bool bVisible)
	{
		base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06010EF8 RID: 69368 RVA: 0x004F75A4 File Offset: 0x004F57A4
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

	// Token: 0x06010EF9 RID: 69369 RVA: 0x004F785C File Offset: 0x004F5A5C
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

	// Token: 0x06010EFA RID: 69370 RVA: 0x004F78E4 File Offset: 0x004F5AE4
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

	// Token: 0x06010EFB RID: 69371 RVA: 0x004F7910 File Offset: 0x004F5B10
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

	// Token: 0x04009558 RID: 38232
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<EntityInfoItem> InfoLayout;

	// Token: 0x04009559 RID: 38233
	[Nullable(2)]
	private UUIItem FatherIcon;

	// Token: 0x0400955A RID: 38234
	private readonly Dictionary<string, int> MissionsInfoMap = new Dictionary<string, int>();

	// Token: 0x0400955B RID: 38235
	private readonly Dictionary<EntityPhotoBehaviorNode, List<EntityIconItem>> NodeIconMap = new Dictionary<EntityPhotoBehaviorNode, List<EntityIconItem>>();

	// Token: 0x0400955C RID: 38236
	private readonly Dictionary<string, EntityIconItem> InfoIconMap = new Dictionary<string, EntityIconItem>();

	// Token: 0x02007D64 RID: 32100
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028982 RID: 166274
		Panel,
		// Token: 0x04028983 RID: 166275
		PanelInfoLayout,
		// Token: 0x04028984 RID: 166276
		ItemInfo,
		// Token: 0x04028985 RID: 166277
		PanelArea,
		// Token: 0x04028986 RID: 166278
		PanelAreaGreen,
		// Token: 0x04028987 RID: 166279
		TargetIcon
	}
}
