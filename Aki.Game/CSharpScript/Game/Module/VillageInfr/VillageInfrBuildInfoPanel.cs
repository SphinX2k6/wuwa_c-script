using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004871 RID: 18545
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildInfoPanel : UiPanelBase
	{
		// Token: 0x06030889 RID: 198793 RVA: 0x00B45208 File Offset: 0x00B43408
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText))
			};
		}

		// Token: 0x0603088A RID: 198794 RVA: 0x00B4535C File Offset: 0x00B4355C
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x0603088B RID: 198795 RVA: 0x00B45384 File Offset: 0x00B43584
		private InfrV2Level GetVillageConfig()
		{
			return VillageInfrConfig.Instance.GetInfrLevel(this.SelectId).Value;
		}

		// Token: 0x0603088C RID: 198796 RVA: 0x00B453AC File Offset: 0x00B435AC
		private string GetDescription()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				return this.GetTreeConfig().Description;
			}
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				return this.GetVillageConfig().Description;
			}
			return "";
		}

		// Token: 0x0603088D RID: 198797 RVA: 0x00B453F0 File Offset: 0x00B435F0
		private string GetMapTexturePath()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				return this.GetTreeConfig().InfoPicturePath;
			}
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				return this.GetVillageConfig().InfoPicturePath;
			}
			return "";
		}

		// Token: 0x0603088E RID: 198798 RVA: 0x00B45432 File Offset: 0x00B43632
		private bool GetIsLock()
		{
			return this.SelectType == EVillageInfrSelectType.Tree && !VillageInfrModel.Instance.GetTreeIsUnlock(this.SelectId);
		}

		// Token: 0x0603088F RID: 198799 RVA: 0x00B45454 File Offset: 0x00B43654
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
		}

		// Token: 0x06030890 RID: 198800 RVA: 0x00B45485 File Offset: 0x00B43685
		private void CreateMissionList()
		{
			this.MissionList = new GenericLayout<VillageInfrMissionListItem, IVillageInfrBuildQuestParam>(base.GetVerticalLayout(5), () => new VillageInfrMissionListItem(), null, false, true);
		}

		// Token: 0x06030891 RID: 198801 RVA: 0x00B454BB File Offset: 0x00B436BB
		private void CreateDescList()
		{
			this.DescList = new GenericLayout<VillageInfrBuildInfoDescItem, string>(base.GetVerticalLayout(9), () => new VillageInfrBuildInfoDescItem(), null, false, true);
		}

		// Token: 0x06030892 RID: 198802 RVA: 0x00B454F2 File Offset: 0x00B436F2
		protected override void OnStart()
		{
			this.SetOpenParam();
			this.CreateMissionList();
			this.CreateDescList();
			this.Refresh(null);
		}

		// Token: 0x06030893 RID: 198803 RVA: 0x00B4550D File Offset: 0x00B4370D
		[NullableContext(2)]
		public void Refresh(IVillageInfrBuildInfoParam param = null)
		{
			if (param != null)
			{
				this.OpenParam = param;
				this.SetOpenParam();
			}
			this.RefreshEmpty();
			this.RefreshTitle();
			this.RefreshMap();
			this.RefreshDesc();
			this.RefreshMissionList();
		}

		// Token: 0x06030894 RID: 198804 RVA: 0x00B45540 File Offset: 0x00B43740
		private void RefreshEmpty()
		{
			base.GetItem(0).SetUIActive(this.GetIsLock());
			if (this.GetIsLock())
			{
				int lockJumpId = this.GetTreeConfig().LockJumpId;
				int questId = int.Parse(SkipInterfaceConfig.Instance.GetAccessPathConfig(lockJumpId).Value.Val1);
				string questName = QuestNewModel.Instance.GetQuestName(questId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "VillageInfr_Tree_LockingTips", new <>z__ReadOnlySingleElementList<object>(questName));
			}
		}

		// Token: 0x06030895 RID: 198805 RVA: 0x00B455C2 File Offset: 0x00B437C2
		private void RefreshTitle()
		{
			if (this.GetIsLock())
			{
				base.GetItem(3).SetUIActive(false);
				return;
			}
			base.GetItem(3).SetUIActive(true);
			base.GetText(4).ShowTextNew(this.GetDescription());
		}

		// Token: 0x06030896 RID: 198806 RVA: 0x00B455FC File Offset: 0x00B437FC
		private void RefreshMap()
		{
			if (this.GetIsLock())
			{
				base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(true);
			base.SetTextureByPath(this.GetMapTexturePath(), base.GetTexture(2), null, null);
		}

		// Token: 0x06030897 RID: 198807 RVA: 0x00B45664 File Offset: 0x00B43864
		private void RefreshMissionList()
		{
			if (this.GetIsLock() || this.SelectType == EVillageInfrSelectType.Village)
			{
				this.MissionList.SetActive(false);
				return;
			}
			this.MissionList.SetActive(true);
			List<IVillageInfrBuildQuestParam> list = new List<IVillageInfrBuildQuestParam>();
			foreach (int id in this.GetTreeConfig().QuestAccessPath())
			{
				list.Add(new VillageInfrBuildQuestParam
				{
					Id = id,
					SelectId = this.SelectId
				});
			}
			this.MissionList.RefreshByData(list, null, false);
		}

		// Token: 0x06030898 RID: 198808 RVA: 0x00B456F0 File Offset: 0x00B438F0
		private void RefreshDesc()
		{
			if (this.GetIsLock() || this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetItem(7).SetUIActive(false);
				base.GetItem(11).SetUIActive(false);
				return;
			}
			VillageInfrConfig instance = VillageInfrConfig.Instance;
			List<IVillageInfrTreeData> allTreeData = VillageInfrModel.Instance.GetAllTreeData();
			List<IVillageInfrTreeData> list = new List<IVillageInfrTreeData>();
			foreach (IVillageInfrTreeData villageInfrTreeData in allTreeData)
			{
				if (villageInfrTreeData.Status != InfrV2StatusPb.InfrV2StatusComplete)
				{
					list.Add(villageInfrTreeData);
				}
			}
			list.Sort((IVillageInfrTreeData a, IVillageInfrTreeData b) => a.Id - b.Id);
			if (list.Count > 0)
			{
				base.GetItem(7).SetUIActive(true);
				base.GetItem(11).SetUIActive(false);
				List<string> list2 = new List<string>();
				foreach (IVillageInfrTreeData villageInfrTreeData2 in list)
				{
					list2.Add(instance.GetInfrTreeBuild(villageInfrTreeData2.Id).Value.Name);
				}
				this.DescList.RefreshByData(list2, null, false);
				return;
			}
			base.GetItem(7).SetUIActive(false);
			base.GetItem(11).SetUIActive(true);
		}

		// Token: 0x0401A11E RID: 106782
		private int SelectId;

		// Token: 0x0401A11F RID: 106783
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A120 RID: 106784
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VillageInfrMissionListItem, IVillageInfrBuildQuestParam> MissionList;

		// Token: 0x0401A121 RID: 106785
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VillageInfrBuildInfoDescItem, string> DescList;
	}
}
