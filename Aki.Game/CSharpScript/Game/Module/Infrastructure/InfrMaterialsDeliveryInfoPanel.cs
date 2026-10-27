using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005919 RID: 22809
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrMaterialsDeliveryInfoPanel : UiPanelBase
	{
		// Token: 0x06039EB1 RID: 237233 RVA: 0x00DC2AF0 File Offset: 0x00DC0CF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 42;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickEllipsisExpand));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(35, new Action(this.OnClickEllipsisFold));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(36, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039EB2 RID: 237234 RVA: 0x00DC3128 File Offset: 0x00DC1328
		private InfrRoadBuild GetRoadConfig()
		{
			return InfrastructureConfig.Instance.GetRoadConfigById(this.RoadId).Value;
		}

		// Token: 0x06039EB3 RID: 237235 RVA: 0x00DC3150 File Offset: 0x00DC1350
		private InfrLevel GetObservatoryConfig()
		{
			return InfrastructureConfig.Instance.GetLevelConfigById(InfrastructureModel.Instance.FireLevel).Value;
		}

		// Token: 0x06039EB4 RID: 237236 RVA: 0x00DC317C File Offset: 0x00DC137C
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<int, int>> GetRequirementList()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
				foreach (DicIntInt dicIntInt in this.GetRoadConfig().RequirementIter())
				{
					list.Add(new ValueTuple<int, int>(dicIntInt.Key, dicIntInt.Value));
				}
				list.Sort((ValueTuple<int, int> a, ValueTuple<int, int> b) => a.Item1 - b.Item1);
				return list;
			}
			List<ValueTuple<int, int>> list2 = new List<ValueTuple<int, int>>();
			foreach (DicIntInt dicIntInt2 in this.GetObservatoryConfig().RequirementIter())
			{
				list2.Add(new ValueTuple<int, int>(dicIntInt2.Key, dicIntInt2.Value));
			}
			list2.Sort((ValueTuple<int, int> a, ValueTuple<int, int> b) => a.Item1 - b.Item1);
			return list2;
		}

		// Token: 0x06039EB5 RID: 237237 RVA: 0x00DC32A0 File Offset: 0x00DC14A0
		private List<string> GetEffectDesList()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Observatory)
			{
				return new List<string>();
			}
			InfrRoadBuild roadConfig = this.GetRoadConfig();
			if (this.GetCurRoadData().Status == InfrStatusPb.InfrStatusProgress)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(roadConfig.EffectDes(0), null);
				return new List<string>
				{
					StringUtils.Format(localTextNew, new string[]
					{
						roadConfig.FireExpReward.ToString()
					})
				};
			}
			return new List<string>();
		}

		// Token: 0x06039EB6 RID: 237238 RVA: 0x00DC3310 File Offset: 0x00DC1510
		private string GetName()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().Name;
			}
			return this.GetObservatoryConfig().Name;
		}

		// Token: 0x06039EB7 RID: 237239 RVA: 0x00DC3344 File Offset: 0x00DC1544
		private string GetDescription()
		{
			if (this.DeliveryType != ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetObservatoryConfig().StageDescription;
			}
			if (this.GetCurRoadData().Status == InfrStatusPb.InfrStatusComplete)
			{
				return this.GetRoadConfig().BuildDoneDes;
			}
			return this.GetRoadConfig().Description;
		}

		// Token: 0x06039EB8 RID: 237240 RVA: 0x00DC3394 File Offset: 0x00DC1594
		private int GetLength()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().Length;
			}
			return 0;
		}

		// Token: 0x06039EB9 RID: 237241 RVA: 0x00DC33BC File Offset: 0x00DC15BC
		private string GetInfoPicturePath()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().InfoPicturePath;
			}
			return this.GetObservatoryConfig().InfoPicturePath;
		}

		// Token: 0x06039EBA RID: 237242 RVA: 0x00DC33EF File Offset: 0x00DC15EF
		private InfrastructureDefine.IInfrRoadData GetCurRoadData()
		{
			return InfrastructureModel.Instance.GetRoadDataByRoadId(this.RoadId);
		}

		// Token: 0x17008ADF RID: 35551
		// (get) Token: 0x06039EBB RID: 237243 RVA: 0x00DC3404 File Offset: 0x00DC1604
		private bool IsMaterialEnough
		{
			get
			{
				List<ValueTuple<int, int>> requirementList = this.GetRequirementList();
				InventoryModel instance = InventoryModel.Instance;
				foreach (ValueTuple<int, int> valueTuple in requirementList)
				{
					int item = valueTuple.Item1;
					int item2 = valueTuple.Item2;
					if (instance.GetItemCountByConfigId(item, 0) < item2)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x06039EBC RID: 237244 RVA: 0x00DC3478 File Offset: 0x00DC1678
		protected override UniTask OnBeforeStartAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EBD RID: 237245 RVA: 0x00DC34BC File Offset: 0x00DC16BC
		private UniTask CreateCaption()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateCaption>d__30 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateCaption>d__30>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06039EBE RID: 237246 RVA: 0x00DC34FF File Offset: 0x00DC16FF
		private void CreateConsumeList()
		{
			this.ConsumeList = new GenericLayout<InfrMaterialsDeliveryConsumeItem, TItem>(base.GetHorizontalLayout(17), () => new InfrMaterialsDeliveryConsumeItem(), null, false, true);
		}

		// Token: 0x06039EBF RID: 237247 RVA: 0x00DC3536 File Offset: 0x00DC1736
		private void CreateEffectList()
		{
			this.EffectList = new GenericLayout<InfrMaterialsDeliveryEffectItem, string>(base.GetVerticalLayout(20), () => new InfrMaterialsDeliveryEffectItem(), null, false, true);
		}

		// Token: 0x06039EC0 RID: 237248 RVA: 0x00DC3570 File Offset: 0x00DC1770
		private UniTask CreateButtonMarkAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonMarkAsync>d__33 <CreateButtonMarkAsync>d__;
			<CreateButtonMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonMarkAsync>d__.<>4__this = this;
			<CreateButtonMarkAsync>d__.<>1__state = -1;
			<CreateButtonMarkAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonMarkAsync>d__33>(ref <CreateButtonMarkAsync>d__);
			return <CreateButtonMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC1 RID: 237249 RVA: 0x00DC35B4 File Offset: 0x00DC17B4
		private UniTask CreateButtonLocateAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonLocateAsync>d__34 <CreateButtonLocateAsync>d__;
			<CreateButtonLocateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonLocateAsync>d__.<>4__this = this;
			<CreateButtonLocateAsync>d__.<>1__state = -1;
			<CreateButtonLocateAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonLocateAsync>d__34>(ref <CreateButtonLocateAsync>d__);
			return <CreateButtonLocateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC2 RID: 237250 RVA: 0x00DC35F8 File Offset: 0x00DC17F8
		private UniTask CreateButtonGotoMissionAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonGotoMissionAsync>d__35 <CreateButtonGotoMissionAsync>d__;
			<CreateButtonGotoMissionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonGotoMissionAsync>d__.<>4__this = this;
			<CreateButtonGotoMissionAsync>d__.<>1__state = -1;
			<CreateButtonGotoMissionAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonGotoMissionAsync>d__35>(ref <CreateButtonGotoMissionAsync>d__);
			return <CreateButtonGotoMissionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC3 RID: 237251 RVA: 0x00DC363C File Offset: 0x00DC183C
		private UniTask CreateButtonBuildStartAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonBuildStartAsync>d__36 <CreateButtonBuildStartAsync>d__;
			<CreateButtonBuildStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonBuildStartAsync>d__.<>4__this = this;
			<CreateButtonBuildStartAsync>d__.<>1__state = -1;
			<CreateButtonBuildStartAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonBuildStartAsync>d__36>(ref <CreateButtonBuildStartAsync>d__);
			return <CreateButtonBuildStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC4 RID: 237252 RVA: 0x00DC3680 File Offset: 0x00DC1880
		private UniTask CreateLockPanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateLockPanelAsync>d__37 <CreateLockPanelAsync>d__;
			<CreateLockPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLockPanelAsync>d__.<>4__this = this;
			<CreateLockPanelAsync>d__.<>1__state = -1;
			<CreateLockPanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateLockPanelAsync>d__37>(ref <CreateLockPanelAsync>d__);
			return <CreateLockPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC5 RID: 237253 RVA: 0x00DC36C4 File Offset: 0x00DC18C4
		private UniTask CreateDonePanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateDonePanelAsync>d__38 <CreateDonePanelAsync>d__;
			<CreateDonePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDonePanelAsync>d__.<>4__this = this;
			<CreateDonePanelAsync>d__.<>1__state = -1;
			<CreateDonePanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateDonePanelAsync>d__38>(ref <CreateDonePanelAsync>d__);
			return <CreateDonePanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC6 RID: 237254 RVA: 0x00DC3708 File Offset: 0x00DC1908
		private UniTask CreateWarnPanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateWarnPanelAsync>d__39 <CreateWarnPanelAsync>d__;
			<CreateWarnPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWarnPanelAsync>d__.<>4__this = this;
			<CreateWarnPanelAsync>d__.<>1__state = -1;
			<CreateWarnPanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateWarnPanelAsync>d__39>(ref <CreateWarnPanelAsync>d__);
			return <CreateWarnPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EC7 RID: 237255 RVA: 0x00DC374B File Offset: 0x00DC194B
		protected override void OnStart()
		{
			this.Refresh(this.OpenParam as InfrastructureDefine.IInfrMaterialsDeliveryOpenParam);
		}

		// Token: 0x06039EC8 RID: 237256 RVA: 0x00DC3760 File Offset: 0x00DC1960
		public void Refresh(InfrastructureDefine.IInfrMaterialsDeliveryOpenParam param)
		{
			this.InitData(param);
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road && this.RoadId == 0)
			{
				return;
			}
			this.RefreshCaption();
			this.RefreshTitle();
			this.RefreshEllipsis();
			this.RefreshBuildDifficulty();
			this.RefreshEffect();
			this.RefreshObtain();
			this.RefreshConsume();
			this.RefreshActivated();
			this.RefreshBuildDone();
		}

		// Token: 0x06039EC9 RID: 237257 RVA: 0x00DC37BC File Offset: 0x00DC19BC
		private void InitData(InfrastructureDefine.IInfrMaterialsDeliveryOpenParam param)
		{
			this.RoadId = ((param != null) ? param.RoadId : 0);
			this.DeliveryType = ((param != null) ? param.DeliveryType : ActionInfrastructureItemDeliveryType.Road);
			this.OpenSource = ((param != null) ? param.OpenSource : InfrastructureDefine.EMaterialDeliveryOpenSource.BigWorld);
			this.ShowEllipsis = true;
		}

		// Token: 0x06039ECA RID: 237258 RVA: 0x00DC37FC File Offset: 0x00DC19FC
		private void RefreshCaption()
		{
			if (this.OpenSource == InfrastructureDefine.EMaterialDeliveryOpenSource.RoadNetworkMap)
			{
				this.Caption.SetHelpCallBack(delegate
				{
					int helpIdActivity = InfrastructureConfig.Instance.GetHelpIdActivity();
					HelpController.Instance.OpenHelpById(helpIdActivity);
				});
				this.Caption.SetCloseCallBack(new Action(this.OnClickCaptionCloseBtn));
			}
			else
			{
				this.Caption.SetUiActive(false);
			}
			UUIButtonComponent button = base.GetButton(36);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06039ECB RID: 237259 RVA: 0x00DC3880 File Offset: 0x00DC1A80
		private void RefreshTitle()
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(this.GetName());
			}
			UUISprite sprite = base.GetSprite(40);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIText text2 = base.GetText(41);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			InfrastructureModel instance = InfrastructureModel.Instance;
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetLength());
					defaultInterpolatedStringHandler.AppendLiteral("m");
					text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				if (this.RoadId == instance.TracedRoadId)
				{
					UUISprite sprite2 = base.GetSprite(40);
					if (sprite2 != null)
					{
						sprite2.SetUIActive(true);
					}
					string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_InfrastructureMapMark1");
					this.SetSpriteByPath(resourcePath, base.GetSprite(40), false, null, null);
				}
				else if (this.RoadId == instance.RecommendRoadId)
				{
					UUISprite sprite3 = base.GetSprite(40);
					if (sprite3 != null)
					{
						sprite3.SetUIActive(true);
					}
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_InfrastructureMapMark2");
					this.SetSpriteByPath(resourcePath2, base.GetSprite(40), false, null, null);
				}
			}
			else
			{
				UUIText text4 = base.GetText(41);
				if (text4 != null)
				{
					text4.SetUIActive(false);
				}
				UUIText text5 = base.GetText(41);
				if (text5 != null)
				{
					text5.ShowTextNew(this.GetObservatoryConfig().Description);
				}
				UUIText text6 = base.GetText(1);
				if (text6 != null)
				{
					text6.SetUIActive(false);
				}
			}
			if (this.OpenSource == InfrastructureDefine.EMaterialDeliveryOpenSource.BigWorld && !string.IsNullOrEmpty(this.GetInfoPicturePath()))
			{
				base.SetTextureByPath(this.GetInfoPicturePath(), base.GetTexture(29), null, null);
				return;
			}
			UUITexture texture = base.GetTexture(29);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x06039ECC RID: 237260 RVA: 0x00DC3A50 File Offset: 0x00DC1C50
		private void RefreshEllipsis()
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.ShowTextNew(this.GetDescription());
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				text2.ShowTextNew(this.GetDescription());
			}
			UUIText text3 = base.GetText(8);
			if (text3 != null)
			{
				text3.ShowTextNew(this.GetDescription());
			}
			UUIText text4 = base.GetText(8);
			if (text4 != null)
			{
				text4.GetRealSize();
			}
			UUIText text5 = base.GetText(8);
			if (text5 != null && text5.GetRenderLineNum() > 3)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(this.ShowEllipsis);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(7);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(!this.ShowEllipsis);
				return;
			}
			else
			{
				UUIItem item4 = base.GetItem(2);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				UUIItem item5 = base.GetItem(5);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(7);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06039ECD RID: 237261 RVA: 0x00DC3B4E File Offset: 0x00DC1D4E
		private void RefreshBuildDifficulty()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				this.RefreshRoadDifficulty();
				return;
			}
			this.RefreshObservatoryDifficulty();
		}

		// Token: 0x06039ECE RID: 237262 RVA: 0x00DC3B68 File Offset: 0x00DC1D68
		private void RefreshRoadDifficulty()
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			InfrRoadBuild roadConfig = this.GetRoadConfig();
			InfrastructureDefine.IInfrRoadData curRoadData = this.GetCurRoadData();
			InfrStatusPb infrStatusPb = (curRoadData != null) ? curRoadData.Status : InfrStatusPb.InfrStatusLock;
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(infrStatusPb != InfrStatusPb.InfrStatusComplete);
			}
			UUIText text = base.GetText(15);
			if (text != null)
			{
				text.SetUIActive(infrStatusPb == InfrStatusPb.InfrStatusComplete);
			}
			UiResource? uiResource;
			string path = (UiResourceConfig.Instance.GetResourceConfig(InfrastructureDefine.difficultySpriteResourceId[roadConfig.Difficulty]) != null) ? uiResource.GetValueOrDefault().Path : null;
			this.SetSpriteByPath(path, base.GetSprite(12), true, null, null);
			UUISprite sprite = base.GetSprite(12);
			if (sprite != null)
			{
				sprite.SetUIActive(roadConfig.Difficulty >= 1);
			}
			UUISprite sprite2 = base.GetSprite(13);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUISprite sprite3 = base.GetSprite(14);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((curRoadData != null) ? curRoadData.CompleteTime : 0) * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
			UUIText text2 = base.GetText(15);
			if (text2 != null)
			{
				text2.SetText(TimeUtil.Instance.DateFormat3(localDateTime), true);
			}
			if (infrStatusPb == InfrStatusPb.InfrStatusComplete)
			{
				UUIText text3 = base.GetText(10);
				if (text3 == null)
				{
					return;
				}
				text3.ShowTextNew("Build_CompleteTime");
				return;
			}
			else
			{
				UUIText text4 = base.GetText(10);
				if (text4 == null)
				{
					return;
				}
				text4.ShowTextNew("Build_BuildingDiff");
				return;
			}
		}

		// Token: 0x06039ECF RID: 237263 RVA: 0x00DC3CEC File Offset: 0x00DC1EEC
		private void RefreshObservatoryDifficulty()
		{
			if (InfrastructureModel.Instance.FireLevel < InfrastructureConfig.Instance.GetMaxLevel())
			{
				UUIItem item = base.GetItem(9);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				UUIText text = base.GetText(10);
				if (text != null)
				{
					text.ShowTextNew("Build_CompleteTime");
				}
				DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(InfrastructureModel.Instance.FireLevelReachTime * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
				UUIItem item2 = base.GetItem(11);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIText text2 = base.GetText(15);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				UUIText text3 = base.GetText(15);
				if (text3 == null)
				{
					return;
				}
				text3.SetText(TimeUtil.Instance.DateFormat3(localDateTime), true);
				return;
			}
		}

		// Token: 0x06039ED0 RID: 237264 RVA: 0x00DC3DA8 File Offset: 0x00DC1FA8
		private void RefreshConsume()
		{
			List<TItem> list = (from x in this.GetRequirementList()
			orderby x.Item1
			select new TItem(new InventoryDefine.GetItemData(x.Item1, 0), x.Item2)).ToList<TItem>();
			GenericLayout<InfrMaterialsDeliveryConsumeItem, TItem> consumeList = this.ConsumeList;
			if (consumeList != null)
			{
				consumeList.RefreshByData(list, null, false);
			}
			if (list.Count == 0)
			{
				UUIItem item = base.GetItem(16);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				InfrastructureDefine.IInfrRoadData curRoadData = this.GetCurRoadData();
				InfrStatusPb infrStatusPb = (curRoadData != null) ? curRoadData.Status : InfrStatusPb.InfrStatusLock;
				UUIItem item2 = base.GetItem(16);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(infrStatusPb == InfrStatusPb.InfrStatusProgress);
				return;
			}
			else
			{
				UUIItem item3 = base.GetItem(16);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(InfrastructureModel.Instance.FireLevel < InfrastructureConfig.Instance.GetMaxLevel());
				return;
			}
		}

		// Token: 0x06039ED1 RID: 237265 RVA: 0x00DC3E94 File Offset: 0x00DC2094
		private void RefreshEffect()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Observatory)
			{
				UUIItem item = base.GetItem(18);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else if (this.GetCurRoadData().Status != InfrStatusPb.InfrStatusProgress)
			{
				UUIItem item2 = base.GetItem(18);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				List<string> effectDesList = this.GetEffectDesList();
				UUIItem item3 = base.GetItem(18);
				if (item3 != null)
				{
					item3.SetUIActive(effectDesList.Count > 0);
				}
				GenericLayout<InfrMaterialsDeliveryEffectItem, string> effectList = this.EffectList;
				if (effectList == null)
				{
					return;
				}
				effectList.RefreshByData(this.GetEffectDesList(), null, false);
				return;
			}
		}

		// Token: 0x06039ED2 RID: 237266 RVA: 0x00DC3F1C File Offset: 0x00DC211C
		private void RefreshObtain()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				UUIItem item = base.GetItem(21);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else if (InfrastructureModel.Instance.FireLevel >= InfrastructureConfig.Instance.GetMaxLevel())
			{
				UUIItem item2 = base.GetItem(21);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				UUIItem item3 = base.GetItem(21);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIText text = base.GetText(22);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew("Observatory_FunctionOpenDesc");
				return;
			}
		}

		// Token: 0x06039ED3 RID: 237267 RVA: 0x00DC3F9C File Offset: 0x00DC219C
		private void RefreshActivated()
		{
			this.RefreshTitle();
			UUIButtonComponent button = base.GetButton(33);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button2 = base.GetButton(34);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button3 = base.GetButton(26);
			if (button3 != null)
			{
				button3.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button4 = base.GetButton(24);
			if (button4 != null)
			{
				button4.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(31);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(30);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(32);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				InfrastructureDefine.IInfrRoadData curRoadData = this.GetCurRoadData();
				InfrStatusPb status = (curRoadData != null) ? curRoadData.Status : InfrStatusPb.InfrStatusLock;
				this.RefreshRoadActivated(status);
				return;
			}
			this.RefreshObservatoryActivated(InfrastructureModel.Instance.FireStatus);
		}

		// Token: 0x06039ED4 RID: 237268 RVA: 0x00DC40A4 File Offset: 0x00DC22A4
		private void RefreshRoadActivated(InfrStatusPb status)
		{
			if (status == InfrStatusPb.InfrStatusLock)
			{
				UUIItem item = base.GetItem(31);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				ConditionGroup? config = ConfigConditionGroupById.GetConfig(this.GetRoadConfig().ConditionId, true);
				this.LockPanel.Refresh(new InfrastructureDefine.InfrMaterialsDeliveryLockData
				{
					LockDescriptionTextId = config.Value.HintText
				});
				UUIButtonComponent button = base.GetButton(33);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetUIActive(true);
				return;
			}
			else if (status == InfrStatusPb.InfrStatusProgress)
			{
				if (this.OpenSource == InfrastructureDefine.EMaterialDeliveryOpenSource.RoadNetworkMap)
				{
					UUIButtonComponent button2 = base.GetButton(24);
					if (button2 != null)
					{
						button2.RootUIComp.Get().SetUIActive(!this.GetRoadConfig().DisableMark);
					}
					UUIButtonComponent button3 = base.GetButton(26);
					if (button3 != null)
					{
						button3.RootUIComp.Get().SetUIActive(true);
					}
				}
				else
				{
					UUIButtonComponent button4 = base.GetButton(34);
					if (button4 != null)
					{
						button4.RootUIComp.Get().SetUIActive(true);
					}
				}
				this.ButtonMark.SetLocalTextNew((InfrastructureModel.Instance.TracedRoadId == this.RoadId) ? "BuildRoadNet_RoadButton_2" : "BuildRoadNet_RoadButton_1", Array.Empty<object>());
				if (!this.IsMaterialEnough)
				{
					UUIItem item2 = base.GetItem(31);
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
					this.LockPanel.Refresh(new InfrastructureDefine.InfrMaterialsDeliveryLockData
					{
						LockDescriptionTextId = "BuildRoad_MaterialShortageTips"
					});
					this.ButtonBuildStart.SetEnableClick(false);
					return;
				}
				this.ButtonBuildStart.SetEnableClick(true);
				return;
			}
			else
			{
				UUIButtonComponent button5 = base.GetButton(26);
				if (button5 == null)
				{
					return;
				}
				button5.RootUIComp.Get().SetUIActive(true);
				return;
			}
		}

		// Token: 0x06039ED5 RID: 237269 RVA: 0x00DC4248 File Offset: 0x00DC2448
		private void RefreshObservatoryActivated(InfrStatusPb status)
		{
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			int maxLevel = instance.GetMaxLevel();
			if (InfrastructureModel.Instance.FireLevel >= maxLevel)
			{
				UUIButtonComponent button = base.GetButton(26);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetUIActive(true);
				return;
			}
			else if (status == InfrStatusPb.InfrStatusLock)
			{
				UUIItem item = base.GetItem(31);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				ConditionGroup? config = ConfigConditionGroupById.GetConfig(this.GetObservatoryConfig().ConditionId, true);
				this.LockPanel.Refresh(new InfrastructureDefine.InfrMaterialsDeliveryLockData
				{
					LockDescriptionTextId = config.Value.HintText
				});
				UUIButtonComponent button2 = base.GetButton(33);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(true);
				return;
			}
			else if (status == InfrStatusPb.InfrStatusProgress)
			{
				UUIButtonComponent button3 = base.GetButton(26);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(true);
				}
				InfrastructureModel instance2 = InfrastructureModel.Instance;
				bool flag = instance2.FireExp >= (long)instance.GetLevelConfigById(instance2.FireLevel + 1).Value.Exp;
				if (this.OpenSource == InfrastructureDefine.EMaterialDeliveryOpenSource.BigWorld)
				{
					UUIButtonComponent button4 = base.GetButton(34);
					if (button4 != null)
					{
						button4.RootUIComp.Get().SetUIActive(true);
					}
				}
				if (!this.IsMaterialEnough || !flag)
				{
					UUIItem item2 = base.GetItem(31);
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
					this.ButtonBuildStart.SetEnableClick(false);
					this.LockPanel.Refresh(new InfrastructureDefine.InfrMaterialsDeliveryLockData
					{
						LockDescriptionTextId = "BuildRoad_ObserMaterialShortageTips"
					});
					return;
				}
				this.ButtonBuildStart.SetEnableClick(true);
				return;
			}
			else
			{
				UUIButtonComponent button5 = base.GetButton(26);
				if (button5 == null)
				{
					return;
				}
				button5.RootUIComp.Get().SetUIActive(true);
				return;
			}
		}

		// Token: 0x06039ED6 RID: 237270 RVA: 0x00DC4404 File Offset: 0x00DC2604
		private void RefreshBuildDone()
		{
			if (this.DeliveryType != ActionInfrastructureItemDeliveryType.Road)
			{
				UUIItem item = base.GetItem(23);
				if (item != null)
				{
					item.SetUIActive(InfrastructureModel.Instance.FireLevel >= InfrastructureConfig.Instance.GetMaxLevel());
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(37), "BuildRoad_CompleteDes_1", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(this.GetName(), null) ?? ""));
				return;
			}
			UUIItem item2 = base.GetItem(23);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06039ED7 RID: 237271 RVA: 0x00DC448B File Offset: 0x00DC268B
		public void SetClickBtnBuildCb(Action cb)
		{
			this.OnClickBtnBuildCb = cb;
		}

		// Token: 0x06039ED8 RID: 237272 RVA: 0x00DC4494 File Offset: 0x00DC2694
		public void SetClickCaptionCloseBtnCb(Action cb)
		{
			this.OnClickCaptionCloseBtnCb = cb;
		}

		// Token: 0x06039ED9 RID: 237273 RVA: 0x00DC449D File Offset: 0x00DC269D
		private void OnClickButtonMark(int index)
		{
			this.OnClickButtonMarkAsync();
		}

		// Token: 0x06039EDA RID: 237274 RVA: 0x00DC44A8 File Offset: 0x00DC26A8
		private UniTask OnClickButtonMarkAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnClickButtonMarkAsync>d__59 <OnClickButtonMarkAsync>d__;
			<OnClickButtonMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickButtonMarkAsync>d__.<>4__this = this;
			<OnClickButtonMarkAsync>d__.<>1__state = -1;
			<OnClickButtonMarkAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnClickButtonMarkAsync>d__59>(ref <OnClickButtonMarkAsync>d__);
			return <OnClickButtonMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EDB RID: 237275 RVA: 0x00DC44EB File Offset: 0x00DC26EB
		private void OnClickButtonLocate(int index)
		{
			this.OnClickButtonLocateAsync();
		}

		// Token: 0x06039EDC RID: 237276 RVA: 0x00DC44F4 File Offset: 0x00DC26F4
		private UniTask OnClickButtonLocateAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnClickButtonLocateAsync>d__61 <OnClickButtonLocateAsync>d__;
			<OnClickButtonLocateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickButtonLocateAsync>d__.<>4__this = this;
			<OnClickButtonLocateAsync>d__.<>1__state = -1;
			<OnClickButtonLocateAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnClickButtonLocateAsync>d__61>(ref <OnClickButtonLocateAsync>d__);
			return <OnClickButtonLocateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EDD RID: 237277 RVA: 0x00DC4538 File Offset: 0x00DC2738
		private void OnClickButtonGotoMission(int index)
		{
			if (this.DeliveryType != ActionInfrastructureItemDeliveryType.Road)
			{
				return;
			}
			if (this.GetCurRoadData().Status == InfrStatusPb.InfrStatusLock)
			{
				int? intConfig = ConfigCommonParamById.GetIntConfig("InfrTeachStageEndQuestId");
				UiManager.Instance.OpenView(EUiViewName.QuestView, intConfig, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.GetRoadConfig().BuildQuest, null);
		}

		// Token: 0x06039EDE RID: 237278 RVA: 0x00DC45A1 File Offset: 0x00DC27A1
		private void OnClickButtonBuildStart(int _)
		{
			Action onClickBtnBuildCb = this.OnClickBtnBuildCb;
			if (onClickBtnBuildCb == null)
			{
				return;
			}
			onClickBtnBuildCb();
		}

		// Token: 0x06039EDF RID: 237279 RVA: 0x00DC45B3 File Offset: 0x00DC27B3
		private void OnClickClose()
		{
			Action onClickCaptionCloseBtnCb = this.OnClickCaptionCloseBtnCb;
			if (onClickCaptionCloseBtnCb == null)
			{
				return;
			}
			onClickCaptionCloseBtnCb();
		}

		// Token: 0x06039EE0 RID: 237280 RVA: 0x00DC45C5 File Offset: 0x00DC27C5
		private void OnClickEllipsisExpand()
		{
			this.ShowEllipsis = false;
			this.RefreshEllipsis();
		}

		// Token: 0x06039EE1 RID: 237281 RVA: 0x00DC45D4 File Offset: 0x00DC27D4
		private void OnClickEllipsisFold()
		{
			this.ShowEllipsis = true;
			this.RefreshEllipsis();
		}

		// Token: 0x06039EE2 RID: 237282 RVA: 0x00DC45E3 File Offset: 0x00DC27E3
		private void OnClickCaptionCloseBtn()
		{
			Action onClickCaptionCloseBtnCb = this.OnClickCaptionCloseBtnCb;
			if (onClickCaptionCloseBtnCb == null)
			{
				return;
			}
			onClickCaptionCloseBtnCb();
		}

		// Token: 0x06039EE3 RID: 237283 RVA: 0x00DC45F5 File Offset: 0x00DC27F5
		private void OnClickWarnPanel()
		{
		}

		// Token: 0x0401E339 RID: 123705
		private InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource;

		// Token: 0x0401E33A RID: 123706
		private int RoadId;

		// Token: 0x0401E33B RID: 123707
		private ActionInfrastructureItemDeliveryType DeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x0401E33C RID: 123708
		private GenericLayout<InfrMaterialsDeliveryConsumeItem, TItem> ConsumeList;

		// Token: 0x0401E33D RID: 123709
		private GenericLayout<InfrMaterialsDeliveryEffectItem, string> EffectList;

		// Token: 0x0401E33E RID: 123710
		private readonly ButtonItem ButtonMark = new ButtonItem(null);

		// Token: 0x0401E33F RID: 123711
		private readonly ButtonItem ButtonLocate = new ButtonItem(null);

		// Token: 0x0401E340 RID: 123712
		private readonly ButtonItem ButtonGotoMission = new ButtonItem(null);

		// Token: 0x0401E341 RID: 123713
		private readonly ButtonItem ButtonBuildStart = new ButtonItem(null);

		// Token: 0x0401E342 RID: 123714
		private readonly InfrMaterialsDeliveryLockItem LockPanel = new InfrMaterialsDeliveryLockItem();

		// Token: 0x0401E343 RID: 123715
		private readonly InfrMaterialsDeliveryLockItem WarnPanel = new InfrMaterialsDeliveryLockItem();

		// Token: 0x0401E344 RID: 123716
		private readonly InfrMaterialsDeliveryDoneItem DonePanel = new InfrMaterialsDeliveryDoneItem();

		// Token: 0x0401E345 RID: 123717
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401E346 RID: 123718
		private bool ShowEllipsis;

		// Token: 0x0401E347 RID: 123719
		private Action OnClickBtnBuildCb;

		// Token: 0x0401E348 RID: 123720
		private Action OnClickCaptionCloseBtnCb;

		// Token: 0x0200BB95 RID: 48021
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038A03 RID: 231939
			public const int TextName = 0;

			// Token: 0x04038A04 RID: 231940
			public const int TextDistance = 1;

			// Token: 0x04038A05 RID: 231941
			public const int PanelEllipsis = 2;

			// Token: 0x04038A06 RID: 231942
			public const int TextEllipsis = 3;

			// Token: 0x04038A07 RID: 231943
			public const int BtnEllipsisExpand = 4;

			// Token: 0x04038A08 RID: 231944
			public const int PanelEllipsis1 = 5;

			// Token: 0x04038A09 RID: 231945
			public const int TextEllipsis1 = 6;

			// Token: 0x04038A0A RID: 231946
			public const int PanelEllipsis2 = 7;

			// Token: 0x04038A0B RID: 231947
			public const int TextEllipsis2 = 8;

			// Token: 0x04038A0C RID: 231948
			public const int PanelBuildDifficulty = 9;

			// Token: 0x04038A0D RID: 231949
			public const int TextBuildDifficultyTitle = 10;

			// Token: 0x04038A0E RID: 231950
			public const int PanelBuildDifficultyStar = 11;

			// Token: 0x04038A0F RID: 231951
			public const int SpriteBuildDifficultyStar1 = 12;

			// Token: 0x04038A10 RID: 231952
			public const int SpriteBuildDifficultyStar2 = 13;

			// Token: 0x04038A11 RID: 231953
			public const int SpriteBuildDifficultyStar3 = 14;

			// Token: 0x04038A12 RID: 231954
			public const int TextBuildTime = 15;

			// Token: 0x04038A13 RID: 231955
			public const int PanelConsume = 16;

			// Token: 0x04038A14 RID: 231956
			public const int HorizontalConsume = 17;

			// Token: 0x04038A15 RID: 231957
			public const int PanelEffect = 18;

			// Token: 0x04038A16 RID: 231958
			public const int TextEffectTitle = 19;

			// Token: 0x04038A17 RID: 231959
			public const int VerticalEffect = 20;

			// Token: 0x04038A18 RID: 231960
			public const int PanelObtain = 21;

			// Token: 0x04038A19 RID: 231961
			public const int TextObtainInfo = 22;

			// Token: 0x04038A1A RID: 231962
			public const int PanelDone = 23;

			// Token: 0x04038A1B RID: 231963
			public const int BtnMark = 24;

			// Token: 0x04038A1C RID: 231964
			public const int TextBtnMark = 25;

			// Token: 0x04038A1D RID: 231965
			public const int BtnLocate = 26;

			// Token: 0x04038A1E RID: 231966
			public const int TextBtnLocate = 27;

			// Token: 0x04038A1F RID: 231967
			public const int PanelMapTexture = 28;

			// Token: 0x04038A20 RID: 231968
			public const int TextureMap = 29;

			// Token: 0x04038A21 RID: 231969
			public const int PanelActivatedWarn = 30;

			// Token: 0x04038A22 RID: 231970
			public const int PanelActivatedDisabled = 31;

			// Token: 0x04038A23 RID: 231971
			public const int PanelActivatedDone = 32;

			// Token: 0x04038A24 RID: 231972
			public const int BtnGotoMission = 33;

			// Token: 0x04038A25 RID: 231973
			public const int BtnBuildStart = 34;

			// Token: 0x04038A26 RID: 231974
			public const int BtnEllipsisFold = 35;

			// Token: 0x04038A27 RID: 231975
			public const int BtnClose = 36;

			// Token: 0x04038A28 RID: 231976
			public const int TextBuildDoneTips1 = 37;

			// Token: 0x04038A29 RID: 231977
			public const int TextBuildDoneTips2 = 38;

			// Token: 0x04038A2A RID: 231978
			public const int CaptionItem = 39;

			// Token: 0x04038A2B RID: 231979
			public const int SpriteRoad = 40;

			// Token: 0x04038A2C RID: 231980
			public const int TextObserveStage = 41;
		}
	}
}
