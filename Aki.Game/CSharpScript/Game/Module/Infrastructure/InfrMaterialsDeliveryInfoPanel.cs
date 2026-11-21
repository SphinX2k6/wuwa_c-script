using System;
using System.Collections.Generic;
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
	// Token: 0x020048F2 RID: 18674
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrMaterialsDeliveryInfoPanel : UiPanelBase
	{
		// Token: 0x0602EDD4 RID: 191956 RVA: 0x00D11DF0 File Offset: 0x00D0FFF0
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

		// Token: 0x0602EDD5 RID: 191957 RVA: 0x00D12428 File Offset: 0x00D10628
		private InfrRoadBuild GetRoadConfig()
		{
			return InfrastructureConfig.Instance.GetRoadConfigById(this.RoadId).Value;
		}

		// Token: 0x0602EDD6 RID: 191958 RVA: 0x00D12450 File Offset: 0x00D10650
		private InfrLevel GetObservatoryConfig()
		{
			return InfrastructureConfig.Instance.GetLevelConfigById(InfrastructureModel.Instance.FireLevel).Value;
		}

		// Token: 0x0602EDD7 RID: 191959 RVA: 0x00D1247C File Offset: 0x00D1067C
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

		// Token: 0x0602EDD8 RID: 191960 RVA: 0x00D125A0 File Offset: 0x00D107A0
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

		// Token: 0x0602EDD9 RID: 191961 RVA: 0x00D12610 File Offset: 0x00D10810
		private string GetName()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().Name;
			}
			return this.GetObservatoryConfig().Name;
		}

		// Token: 0x0602EDDA RID: 191962 RVA: 0x00D12644 File Offset: 0x00D10844
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

		// Token: 0x0602EDDB RID: 191963 RVA: 0x00D12694 File Offset: 0x00D10894
		private int GetLength()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().Length;
			}
			return 0;
		}

		// Token: 0x0602EDDC RID: 191964 RVA: 0x00D126BC File Offset: 0x00D108BC
		private string GetInfoPicturePath()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				return this.GetRoadConfig().InfoPicturePath;
			}
			return this.GetObservatoryConfig().InfoPicturePath;
		}

		// Token: 0x0602EDDD RID: 191965 RVA: 0x00D126EF File Offset: 0x00D108EF
		private InfrastructureDefine.IInfrRoadData GetCurRoadData()
		{
			return InfrastructureModel.Instance.GetRoadDataByRoadId(this.RoadId);
		}

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x0602EDDE RID: 191966 RVA: 0x00D12704 File Offset: 0x00D10904
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

		// Token: 0x0602EDDF RID: 191967 RVA: 0x00D12778 File Offset: 0x00D10978
		protected override UniTask OnBeforeStartAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE0 RID: 191968 RVA: 0x00D127BC File Offset: 0x00D109BC
		private UniTask CreateCaption()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateCaption>d__30 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateCaption>d__30>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE1 RID: 191969 RVA: 0x00D127FF File Offset: 0x00D109FF
		private void CreateConsumeList()
		{
			this.ConsumeList = new GenericLayout<InfrMaterialsDeliveryConsumeItem, TItem>(base.GetHorizontalLayout(17), () => new InfrMaterialsDeliveryConsumeItem(), null, false, true);
		}

		// Token: 0x0602EDE2 RID: 191970 RVA: 0x00D12836 File Offset: 0x00D10A36
		private void CreateEffectList()
		{
			this.EffectList = new GenericLayout<InfrMaterialsDeliveryEffectItem, string>(base.GetVerticalLayout(20), () => new InfrMaterialsDeliveryEffectItem(), null, false, true);
		}

		// Token: 0x0602EDE3 RID: 191971 RVA: 0x00D12870 File Offset: 0x00D10A70
		private UniTask CreateButtonMarkAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonMarkAsync>d__33 <CreateButtonMarkAsync>d__;
			<CreateButtonMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonMarkAsync>d__.<>4__this = this;
			<CreateButtonMarkAsync>d__.<>1__state = -1;
			<CreateButtonMarkAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonMarkAsync>d__33>(ref <CreateButtonMarkAsync>d__);
			return <CreateButtonMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE4 RID: 191972 RVA: 0x00D128B4 File Offset: 0x00D10AB4
		private UniTask CreateButtonLocateAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonLocateAsync>d__34 <CreateButtonLocateAsync>d__;
			<CreateButtonLocateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonLocateAsync>d__.<>4__this = this;
			<CreateButtonLocateAsync>d__.<>1__state = -1;
			<CreateButtonLocateAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonLocateAsync>d__34>(ref <CreateButtonLocateAsync>d__);
			return <CreateButtonLocateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE5 RID: 191973 RVA: 0x00D128F8 File Offset: 0x00D10AF8
		private UniTask CreateButtonGotoMissionAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonGotoMissionAsync>d__35 <CreateButtonGotoMissionAsync>d__;
			<CreateButtonGotoMissionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonGotoMissionAsync>d__.<>4__this = this;
			<CreateButtonGotoMissionAsync>d__.<>1__state = -1;
			<CreateButtonGotoMissionAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonGotoMissionAsync>d__35>(ref <CreateButtonGotoMissionAsync>d__);
			return <CreateButtonGotoMissionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE6 RID: 191974 RVA: 0x00D1293C File Offset: 0x00D10B3C
		private UniTask CreateButtonBuildStartAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateButtonBuildStartAsync>d__36 <CreateButtonBuildStartAsync>d__;
			<CreateButtonBuildStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonBuildStartAsync>d__.<>4__this = this;
			<CreateButtonBuildStartAsync>d__.<>1__state = -1;
			<CreateButtonBuildStartAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateButtonBuildStartAsync>d__36>(ref <CreateButtonBuildStartAsync>d__);
			return <CreateButtonBuildStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE7 RID: 191975 RVA: 0x00D12980 File Offset: 0x00D10B80
		private UniTask CreateLockPanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateLockPanelAsync>d__37 <CreateLockPanelAsync>d__;
			<CreateLockPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLockPanelAsync>d__.<>4__this = this;
			<CreateLockPanelAsync>d__.<>1__state = -1;
			<CreateLockPanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateLockPanelAsync>d__37>(ref <CreateLockPanelAsync>d__);
			return <CreateLockPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE8 RID: 191976 RVA: 0x00D129C4 File Offset: 0x00D10BC4
		private UniTask CreateDonePanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateDonePanelAsync>d__38 <CreateDonePanelAsync>d__;
			<CreateDonePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDonePanelAsync>d__.<>4__this = this;
			<CreateDonePanelAsync>d__.<>1__state = -1;
			<CreateDonePanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateDonePanelAsync>d__38>(ref <CreateDonePanelAsync>d__);
			return <CreateDonePanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDE9 RID: 191977 RVA: 0x00D12A08 File Offset: 0x00D10C08
		private UniTask CreateWarnPanelAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<CreateWarnPanelAsync>d__39 <CreateWarnPanelAsync>d__;
			<CreateWarnPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWarnPanelAsync>d__.<>4__this = this;
			<CreateWarnPanelAsync>d__.<>1__state = -1;
			<CreateWarnPanelAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<CreateWarnPanelAsync>d__39>(ref <CreateWarnPanelAsync>d__);
			return <CreateWarnPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDEA RID: 191978 RVA: 0x00D12A4B File Offset: 0x00D10C4B
		protected override void OnStart()
		{
			this.Refresh(this.OpenParam as InfrastructureDefine.IInfrMaterialsDeliveryOpenParam);
		}

		// Token: 0x0602EDEB RID: 191979 RVA: 0x00D12A60 File Offset: 0x00D10C60
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

		// Token: 0x0602EDEC RID: 191980 RVA: 0x00D12ABC File Offset: 0x00D10CBC
		private void InitData(InfrastructureDefine.IInfrMaterialsDeliveryOpenParam param)
		{
			this.RoadId = ((param != null) ? param.RoadId : 0);
			this.DeliveryType = ((param != null) ? param.DeliveryType : ActionInfrastructureItemDeliveryType.Road);
			this.OpenSource = ((param != null) ? param.OpenSource : InfrastructureDefine.EMaterialDeliveryOpenSource.BigWorld);
			this.ShowEllipsis = true;
		}

		// Token: 0x0602EDED RID: 191981 RVA: 0x00D12AFC File Offset: 0x00D10CFC
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

		// Token: 0x0602EDEE RID: 191982 RVA: 0x00D12B80 File Offset: 0x00D10D80
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

		// Token: 0x0602EDEF RID: 191983 RVA: 0x00D12D50 File Offset: 0x00D10F50
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

		// Token: 0x0602EDF0 RID: 191984 RVA: 0x00D12E4E File Offset: 0x00D1104E
		private void RefreshBuildDifficulty()
		{
			if (this.DeliveryType == ActionInfrastructureItemDeliveryType.Road)
			{
				this.RefreshRoadDifficulty();
				return;
			}
			this.RefreshObservatoryDifficulty();
		}

		// Token: 0x0602EDF1 RID: 191985 RVA: 0x00D12E68 File Offset: 0x00D11068
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

		// Token: 0x0602EDF2 RID: 191986 RVA: 0x00D12FEC File Offset: 0x00D111EC
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

		// Token: 0x0602EDF3 RID: 191987 RVA: 0x00D130A8 File Offset: 0x00D112A8
		private void RefreshConsume()
		{
			List<TItem> list = new List<TItem>();
			List<ValueTuple<int, int>> requirementList = this.GetRequirementList();
			for (int i = 0; i < requirementList.Count; i++)
			{
				ValueTuple<int, int> valueTuple = requirementList[i];
				list.Add(new TItem(new InventoryDefine.GetItemData(valueTuple.Item1, 0), valueTuple.Item2));
			}
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

		// Token: 0x0602EDF4 RID: 191988 RVA: 0x00D13188 File Offset: 0x00D11388
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

		// Token: 0x0602EDF5 RID: 191989 RVA: 0x00D13210 File Offset: 0x00D11410
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

		// Token: 0x0602EDF6 RID: 191990 RVA: 0x00D13290 File Offset: 0x00D11490
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

		// Token: 0x0602EDF7 RID: 191991 RVA: 0x00D13398 File Offset: 0x00D11598
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

		// Token: 0x0602EDF8 RID: 191992 RVA: 0x00D1353C File Offset: 0x00D1173C
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

		// Token: 0x0602EDF9 RID: 191993 RVA: 0x00D136F8 File Offset: 0x00D118F8
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

		// Token: 0x0602EDFA RID: 191994 RVA: 0x00D1377F File Offset: 0x00D1197F
		public void SetClickBtnBuildCb(Action cb)
		{
			this.OnClickBtnBuildCb = cb;
		}

		// Token: 0x0602EDFB RID: 191995 RVA: 0x00D13788 File Offset: 0x00D11988
		public void SetClickCaptionCloseBtnCb(Action cb)
		{
			this.OnClickCaptionCloseBtnCb = cb;
		}

		// Token: 0x0602EDFC RID: 191996 RVA: 0x00D13791 File Offset: 0x00D11991
		private void OnClickButtonMark(int index)
		{
			this.OnClickButtonMarkAsync();
		}

		// Token: 0x0602EDFD RID: 191997 RVA: 0x00D1379C File Offset: 0x00D1199C
		private UniTask OnClickButtonMarkAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnClickButtonMarkAsync>d__59 <OnClickButtonMarkAsync>d__;
			<OnClickButtonMarkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickButtonMarkAsync>d__.<>4__this = this;
			<OnClickButtonMarkAsync>d__.<>1__state = -1;
			<OnClickButtonMarkAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnClickButtonMarkAsync>d__59>(ref <OnClickButtonMarkAsync>d__);
			return <OnClickButtonMarkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EDFE RID: 191998 RVA: 0x00D137DF File Offset: 0x00D119DF
		private void OnClickButtonLocate(int index)
		{
			this.OnClickButtonLocateAsync();
		}

		// Token: 0x0602EDFF RID: 191999 RVA: 0x00D137E8 File Offset: 0x00D119E8
		private UniTask OnClickButtonLocateAsync()
		{
			InfrMaterialsDeliveryInfoPanel.<OnClickButtonLocateAsync>d__61 <OnClickButtonLocateAsync>d__;
			<OnClickButtonLocateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickButtonLocateAsync>d__.<>4__this = this;
			<OnClickButtonLocateAsync>d__.<>1__state = -1;
			<OnClickButtonLocateAsync>d__.<>t__builder.Start<InfrMaterialsDeliveryInfoPanel.<OnClickButtonLocateAsync>d__61>(ref <OnClickButtonLocateAsync>d__);
			return <OnClickButtonLocateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE00 RID: 192000 RVA: 0x00D1382C File Offset: 0x00D11A2C
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

		// Token: 0x0602EE01 RID: 192001 RVA: 0x00D13895 File Offset: 0x00D11A95
		private void OnClickButtonBuildStart(int _)
		{
			Action onClickBtnBuildCb = this.OnClickBtnBuildCb;
			if (onClickBtnBuildCb == null)
			{
				return;
			}
			onClickBtnBuildCb();
		}

		// Token: 0x0602EE02 RID: 192002 RVA: 0x00D138A7 File Offset: 0x00D11AA7
		private void OnClickClose()
		{
			Action onClickCaptionCloseBtnCb = this.OnClickCaptionCloseBtnCb;
			if (onClickCaptionCloseBtnCb == null)
			{
				return;
			}
			onClickCaptionCloseBtnCb();
		}

		// Token: 0x0602EE03 RID: 192003 RVA: 0x00D138B9 File Offset: 0x00D11AB9
		private void OnClickEllipsisExpand()
		{
			this.ShowEllipsis = false;
			this.RefreshEllipsis();
		}

		// Token: 0x0602EE04 RID: 192004 RVA: 0x00D138C8 File Offset: 0x00D11AC8
		private void OnClickEllipsisFold()
		{
			this.ShowEllipsis = true;
			this.RefreshEllipsis();
		}

		// Token: 0x0602EE05 RID: 192005 RVA: 0x00D138D7 File Offset: 0x00D11AD7
		private void OnClickCaptionCloseBtn()
		{
			Action onClickCaptionCloseBtnCb = this.OnClickCaptionCloseBtnCb;
			if (onClickCaptionCloseBtnCb == null)
			{
				return;
			}
			onClickCaptionCloseBtnCb();
		}

		// Token: 0x0602EE06 RID: 192006 RVA: 0x00D138E9 File Offset: 0x00D11AE9
		private void OnClickWarnPanel()
		{
		}

		// Token: 0x04018DD6 RID: 101846
		private InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource;

		// Token: 0x04018DD7 RID: 101847
		private int RoadId;

		// Token: 0x04018DD8 RID: 101848
		private ActionInfrastructureItemDeliveryType DeliveryType = ActionInfrastructureItemDeliveryType.Road;

		// Token: 0x04018DD9 RID: 101849
		private GenericLayout<InfrMaterialsDeliveryConsumeItem, TItem> ConsumeList;

		// Token: 0x04018DDA RID: 101850
		private GenericLayout<InfrMaterialsDeliveryEffectItem, string> EffectList;

		// Token: 0x04018DDB RID: 101851
		private readonly ButtonItem ButtonMark = new ButtonItem(null);

		// Token: 0x04018DDC RID: 101852
		private readonly ButtonItem ButtonLocate = new ButtonItem(null);

		// Token: 0x04018DDD RID: 101853
		private readonly ButtonItem ButtonGotoMission = new ButtonItem(null);

		// Token: 0x04018DDE RID: 101854
		private readonly ButtonItem ButtonBuildStart = new ButtonItem(null);

		// Token: 0x04018DDF RID: 101855
		private readonly InfrMaterialsDeliveryLockItem LockPanel = new InfrMaterialsDeliveryLockItem();

		// Token: 0x04018DE0 RID: 101856
		private readonly InfrMaterialsDeliveryLockItem WarnPanel = new InfrMaterialsDeliveryLockItem();

		// Token: 0x04018DE1 RID: 101857
		private readonly InfrMaterialsDeliveryDoneItem DonePanel = new InfrMaterialsDeliveryDoneItem();

		// Token: 0x04018DE2 RID: 101858
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x04018DE3 RID: 101859
		private bool ShowEllipsis;

		// Token: 0x04018DE4 RID: 101860
		private Action OnClickBtnBuildCb;

		// Token: 0x04018DE5 RID: 101861
		private Action OnClickCaptionCloseBtnCb;

		// Token: 0x0200A5A5 RID: 42405
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040333EB RID: 209899
			public const int TextName = 0;

			// Token: 0x040333EC RID: 209900
			public const int TextDistance = 1;

			// Token: 0x040333ED RID: 209901
			public const int PanelEllipsis = 2;

			// Token: 0x040333EE RID: 209902
			public const int TextEllipsis = 3;

			// Token: 0x040333EF RID: 209903
			public const int BtnEllipsisExpand = 4;

			// Token: 0x040333F0 RID: 209904
			public const int PanelEllipsis1 = 5;

			// Token: 0x040333F1 RID: 209905
			public const int TextEllipsis1 = 6;

			// Token: 0x040333F2 RID: 209906
			public const int PanelEllipsis2 = 7;

			// Token: 0x040333F3 RID: 209907
			public const int TextEllipsis2 = 8;

			// Token: 0x040333F4 RID: 209908
			public const int PanelBuildDifficulty = 9;

			// Token: 0x040333F5 RID: 209909
			public const int TextBuildDifficultyTitle = 10;

			// Token: 0x040333F6 RID: 209910
			public const int PanelBuildDifficultyStar = 11;

			// Token: 0x040333F7 RID: 209911
			public const int SpriteBuildDifficultyStar1 = 12;

			// Token: 0x040333F8 RID: 209912
			public const int SpriteBuildDifficultyStar2 = 13;

			// Token: 0x040333F9 RID: 209913
			public const int SpriteBuildDifficultyStar3 = 14;

			// Token: 0x040333FA RID: 209914
			public const int TextBuildTime = 15;

			// Token: 0x040333FB RID: 209915
			public const int PanelConsume = 16;

			// Token: 0x040333FC RID: 209916
			public const int HorizontalConsume = 17;

			// Token: 0x040333FD RID: 209917
			public const int PanelEffect = 18;

			// Token: 0x040333FE RID: 209918
			public const int TextEffectTitle = 19;

			// Token: 0x040333FF RID: 209919
			public const int VerticalEffect = 20;

			// Token: 0x04033400 RID: 209920
			public const int PanelObtain = 21;

			// Token: 0x04033401 RID: 209921
			public const int TextObtainInfo = 22;

			// Token: 0x04033402 RID: 209922
			public const int PanelDone = 23;

			// Token: 0x04033403 RID: 209923
			public const int BtnMark = 24;

			// Token: 0x04033404 RID: 209924
			public const int TextBtnMark = 25;

			// Token: 0x04033405 RID: 209925
			public const int BtnLocate = 26;

			// Token: 0x04033406 RID: 209926
			public const int TextBtnLocate = 27;

			// Token: 0x04033407 RID: 209927
			public const int PanelMapTexture = 28;

			// Token: 0x04033408 RID: 209928
			public const int TextureMap = 29;

			// Token: 0x04033409 RID: 209929
			public const int PanelActivatedWarn = 30;

			// Token: 0x0403340A RID: 209930
			public const int PanelActivatedDisabled = 31;

			// Token: 0x0403340B RID: 209931
			public const int PanelActivatedDone = 32;

			// Token: 0x0403340C RID: 209932
			public const int BtnGotoMission = 33;

			// Token: 0x0403340D RID: 209933
			public const int BtnBuildStart = 34;

			// Token: 0x0403340E RID: 209934
			public const int BtnEllipsisFold = 35;

			// Token: 0x0403340F RID: 209935
			public const int BtnClose = 36;

			// Token: 0x04033410 RID: 209936
			public const int TextBuildDoneTips1 = 37;

			// Token: 0x04033411 RID: 209937
			public const int TextBuildDoneTips2 = 38;

			// Token: 0x04033412 RID: 209938
			public const int CaptionItem = 39;

			// Token: 0x04033413 RID: 209939
			public const int SpriteRoad = 40;

			// Token: 0x04033414 RID: 209940
			public const int TextObserveStage = 41;
		}
	}
}
