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
	// Token: 0x020037E8 RID: 14312
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildInfoPanel : UiPanelBase
	{
		// Token: 0x060253B5 RID: 152501 RVA: 0x00A7FFA4 File Offset: 0x00A7E1A4
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

		// Token: 0x060253B6 RID: 152502 RVA: 0x00A800F8 File Offset: 0x00A7E2F8
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x060253B7 RID: 152503 RVA: 0x00A80120 File Offset: 0x00A7E320
		private InfrV2Level GetVillageConfig()
		{
			return VillageInfrConfig.Instance.GetInfrLevel(this.SelectId).Value;
		}

		// Token: 0x060253B8 RID: 152504 RVA: 0x00A80148 File Offset: 0x00A7E348
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

		// Token: 0x060253B9 RID: 152505 RVA: 0x00A8018C File Offset: 0x00A7E38C
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

		// Token: 0x060253BA RID: 152506 RVA: 0x00A801CE File Offset: 0x00A7E3CE
		private bool GetIsLock()
		{
			return this.SelectType == EVillageInfrSelectType.Tree && !VillageInfrModel.Instance.GetTreeIsUnlock(this.SelectId);
		}

		// Token: 0x060253BB RID: 152507 RVA: 0x00A801F0 File Offset: 0x00A7E3F0
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
		}

		// Token: 0x060253BC RID: 152508 RVA: 0x00A80221 File Offset: 0x00A7E421
		private void CreateMissionList()
		{
			this.MissionList = new GenericLayout<VillageInfrMissionListItem, IVillageInfrBuildQuestParam>(base.GetVerticalLayout(5), () => new VillageInfrMissionListItem(), null, false, true);
		}

		// Token: 0x060253BD RID: 152509 RVA: 0x00A80257 File Offset: 0x00A7E457
		private void CreateDescList()
		{
			this.DescList = new GenericLayout<VillageInfrBuildInfoDescItem, string>(base.GetVerticalLayout(9), () => new VillageInfrBuildInfoDescItem(), null, false, true);
		}

		// Token: 0x060253BE RID: 152510 RVA: 0x00A8028E File Offset: 0x00A7E48E
		protected override void OnStart()
		{
			this.SetOpenParam();
			this.CreateMissionList();
			this.CreateDescList();
			this.Refresh(null);
		}

		// Token: 0x060253BF RID: 152511 RVA: 0x00A802A9 File Offset: 0x00A7E4A9
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

		// Token: 0x060253C0 RID: 152512 RVA: 0x00A802DC File Offset: 0x00A7E4DC
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

		// Token: 0x060253C1 RID: 152513 RVA: 0x00A8035E File Offset: 0x00A7E55E
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

		// Token: 0x060253C2 RID: 152514 RVA: 0x00A80398 File Offset: 0x00A7E598
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

		// Token: 0x060253C3 RID: 152515 RVA: 0x00A80400 File Offset: 0x00A7E600
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

		// Token: 0x060253C4 RID: 152516 RVA: 0x00A8048C File Offset: 0x00A7E68C
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

		// Token: 0x04014991 RID: 84369
		private int SelectId;

		// Token: 0x04014992 RID: 84370
		private EVillageInfrSelectType SelectType;

		// Token: 0x04014993 RID: 84371
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VillageInfrMissionListItem, IVillageInfrBuildQuestParam> MissionList;

		// Token: 0x04014994 RID: 84372
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VillageInfrBuildInfoDescItem, string> DescList;
	}
}
