using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FCD RID: 20429
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorPhantomExhibitView : UiViewBase
	{
		// Token: 0x060332F2 RID: 209650 RVA: 0x00E580F2 File Offset: 0x00E562F2
		public SpringManorPhantomExhibitView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060332F3 RID: 209651 RVA: 0x00E58130 File Offset: 0x00E56330
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnRemove))
			};
		}

		// Token: 0x060332F4 RID: 209652 RVA: 0x00E58208 File Offset: 0x00E56408
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorPhantomExhibitView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorPhantomExhibitView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060332F5 RID: 209653 RVA: 0x00E5824B File Offset: 0x00E5644B
		protected override void OnBeforeShow()
		{
			this.RefreshPhantomList();
		}

		// Token: 0x060332F6 RID: 209654 RVA: 0x00E58253 File Offset: 0x00E56453
		protected override void OnBeforeDestroy()
		{
			UiCameraModel.Instance.EnablePlayerActor();
			FilterSortEntrance<int> filterSortComponent = this.FilterSortComponent;
			if (filterSortComponent == null)
			{
				return;
			}
			filterSortComponent.ClearData(EFilterSortGroupId.MonsterHandBook);
		}

		// Token: 0x060332F7 RID: 209655 RVA: 0x00E58274 File Offset: 0x00E56474
		private void InitPhantomScrollView()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
			UUIItem item = base.GetItem(3);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (loopScrollViewComponent == null || auibaseActor == null)
			{
				return;
			}
			this.PhantomScrollView = new LoopScrollView<SpringManorPhantomExhibitGrid, SpringManorPhantomDisplayItem>(loopScrollViewComponent, auibaseActor, new Func<SpringManorPhantomExhibitGrid>(this.CreatePhantomGrid), false);
		}

		// Token: 0x060332F8 RID: 209656 RVA: 0x00E582C3 File Offset: 0x00E564C3
		private SpringManorPhantomExhibitGrid CreatePhantomGrid()
		{
			return new SpringManorPhantomExhibitGrid
			{
				OnToggleClick = new Action<int, int>(this.OnPhantomGridSelected)
			};
		}

		// Token: 0x060332F9 RID: 209657 RVA: 0x00E582DC File Offset: 0x00E564DC
		private void InitFilterSortEntrance()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			this.FilterSortComponent = new FilterSortEntrance<int>(item, new TUpdateDataListFunction<int>(this.OnFilterSortRefresh));
		}

		// Token: 0x060332FA RID: 209658 RVA: 0x00E58310 File Offset: 0x00E56510
		private void RefreshPhantomList()
		{
			IEnumerable<ExhibitPhantom> phantomExtraConfigByBodySize = SpringManorConfig.Instance.GetPhantomExtraConfigByBodySize(this.PhantomBodySize);
			List<int> list = new List<int>();
			foreach (ExhibitPhantom exhibitPhantom in phantomExtraConfigByBodySize)
			{
				if (CalabashModel.Instance.CheckCalabashMonsterUnlocked(exhibitPhantom.Id))
				{
					HandBookConfig instance = HandBookConfig.Instance;
					MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigByMonsterId(exhibitPhantom.Id) : null;
					if (monsterHandBook != null)
					{
						list.Add(monsterHandBook.Value.Id);
					}
				}
			}
			if (this.FilterSortComponent != null)
			{
				this.FilterSortComponent.UpdateData(EFilterSortGroupId.SpringManorPhantomExhibit, list, Array.Empty<object>());
				return;
			}
			this.UpdatePhantomGridDataSource(list);
		}

		// Token: 0x060332FB RID: 209659 RVA: 0x00E583E0 File Offset: 0x00E565E0
		private void UpdatePhantomGridDataSource(List<int> handbookIdList)
		{
			bool flag = handbookIdList.Count > 0;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			SpringManorPhantomDisplayItem springManorPhantomDisplayItem = null;
			List<SpringManorPhantomDisplayItem> list = new List<SpringManorPhantomDisplayItem>();
			foreach (int id in handbookIdList)
			{
				HandBookConfig instance = HandBookConfig.Instance;
				MonsterHandBook? monsterHandBook = (instance != null) ? instance.GetMonsterHandBookConfigById(id) : null;
				if (monsterHandBook != null)
				{
					IReadOnlyList<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterHandBook.Value.MonsterId);
					if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count != 0)
					{
						Aki.Config.PhantomItem phantomItem = phantomItemByMonsterId[0];
						int? placedPhantomId = this.PlacedPhantomId;
						int itemId = phantomItem.ItemId;
						bool flag2 = placedPhantomId.GetValueOrDefault() == itemId & placedPhantomId != null;
						SpringManorPhantomDisplayItem springManorPhantomDisplayItem2 = new SpringManorPhantomDisplayItem
						{
							PhantomId = phantomItem.ItemId,
							IsSelected = flag2
						};
						if (flag2)
						{
							springManorPhantomDisplayItem = springManorPhantomDisplayItem2;
						}
						else
						{
							list.Add(springManorPhantomDisplayItem2);
						}
					}
				}
			}
			if (springManorPhantomDisplayItem != null)
			{
				this.PhantomGridDataSource = new List<SpringManorPhantomDisplayItem>
				{
					springManorPhantomDisplayItem
				};
				this.PhantomGridDataSource.AddRange(list);
			}
			else
			{
				this.PhantomGridDataSource = list;
			}
			this.PhantomScrollView.RefreshByData(this.PhantomGridDataSource, false, null, true);
			if (flag && this.PhantomGridDataSource.Count > 0)
			{
				int num = 0;
				this.PhantomScrollView.ScrollToGridIndex(num, false);
				this.PhantomScrollView.SelectGridProxy(num, false);
				SpringManorPhantomDisplayItem springManorPhantomDisplayItem3 = this.PhantomGridDataSource[num];
				this.CurrentSelectedPhantomId = ((springManorPhantomDisplayItem3 != null) ? new int?(springManorPhantomDisplayItem3.PhantomId) : null);
				this.PreviewPhantomSelection(this.CurrentSelectedPhantomId.Value);
			}
			else
			{
				this.PhantomScrollView.DeselectCurrentGridProxy(false);
				this.CurrentSelectedPhantomId = null;
			}
			this.RefreshOperationButtonState();
		}

		// Token: 0x060332FC RID: 209660 RVA: 0x00E585D4 File Offset: 0x00E567D4
		private void OnFilterSortRefresh(List<int> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.UpdatePhantomGridDataSource(list);
		}

		// Token: 0x060332FD RID: 209661 RVA: 0x00E585EA File Offset: 0x00E567EA
		private void OnPhantomGridSelected(int phantomId, int gridIndex)
		{
			this.CurrentSelectedPhantomId = new int?(phantomId);
			this.PreviewPhantomSelection(phantomId);
			this.RefreshOperationButtonState();
			LoopScrollView<SpringManorPhantomExhibitGrid, SpringManorPhantomDisplayItem> phantomScrollView = this.PhantomScrollView;
			if (phantomScrollView == null)
			{
				return;
			}
			phantomScrollView.SelectGridProxy(gridIndex, false);
		}

		// Token: 0x060332FE RID: 209662 RVA: 0x00E58618 File Offset: 0x00E56818
		private void RefreshOperationButtonState()
		{
			bool flag = this.CurrentSelectedPhantomId != null;
			bool flag2;
			if (flag && this.PlacedPhantomId != null)
			{
				int? placedPhantomId = this.PlacedPhantomId;
				int? currentSelectedPhantomId = this.CurrentSelectedPhantomId;
				flag2 = (placedPhantomId.GetValueOrDefault() == currentSelectedPhantomId.GetValueOrDefault() & placedPhantomId != null == (currentSelectedPhantomId != null));
			}
			else
			{
				flag2 = false;
			}
			bool flag3 = flag2;
			ButtonItem placeButtonItem = this.PlaceButtonItem;
			if (placeButtonItem != null)
			{
				placeButtonItem.SetUiActive(flag && !flag3);
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && flag3);
				}
			}
			bool flag4 = !flag3 && this.PlacedPhantomId != 0;
			if (this.PlaceButtonItem != null)
			{
				if (flag4)
				{
					this.PlaceButtonItem.SetShowText("Text_PhantomExhibitionReplace_Text");
					return;
				}
				this.PlaceButtonItem.SetShowText("Text_PhantomExhibitionEquip_Text");
			}
		}

		// Token: 0x060332FF RID: 209663 RVA: 0x00E5870C File Offset: 0x00E5690C
		private void UpdatePhantomSelectionState(int phantomId, bool isSelected)
		{
			int i = 0;
			while (i < this.PhantomGridDataSource.Count)
			{
				SpringManorPhantomDisplayItem springManorPhantomDisplayItem = this.PhantomGridDataSource[i];
				if (springManorPhantomDisplayItem != null && springManorPhantomDisplayItem.PhantomId == phantomId)
				{
					springManorPhantomDisplayItem.IsSelected = isSelected;
					LoopScrollView<SpringManorPhantomExhibitGrid, SpringManorPhantomDisplayItem> phantomScrollView = this.PhantomScrollView;
					if (phantomScrollView == null)
					{
						return;
					}
					phantomScrollView.RefreshGridProxy(i);
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06033300 RID: 209664 RVA: 0x00E58769 File Offset: 0x00E56969
		private void PreviewPhantomSelection(int phantomId)
		{
			if (this.EntityId == null)
			{
				return;
			}
			this.PreviewPhantomId = new int?(phantomId);
			this.RefreshSceneItemExhibit(this.EntityId.Value, phantomId);
		}

		// Token: 0x06033301 RID: 209665 RVA: 0x00E58798 File Offset: 0x00E56998
		private UniTask InitCaptionAsync()
		{
			SpringManorPhantomExhibitView.<InitCaptionAsync>d__27 <InitCaptionAsync>d__;
			<InitCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionAsync>d__.<>4__this = this;
			<InitCaptionAsync>d__.<>1__state = -1;
			<InitCaptionAsync>d__.<>t__builder.Start<SpringManorPhantomExhibitView.<InitCaptionAsync>d__27>(ref <InitCaptionAsync>d__);
			return <InitCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033302 RID: 209666 RVA: 0x00E587DC File Offset: 0x00E569DC
		private bool RefreshSceneItemExhibit(int entityId, int itemId)
		{
			SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(entityId);
			if (exhibitComponent == null)
			{
				return false;
			}
			if (itemId == 0)
			{
				SceneItemExhibitComponent exhibitComponent2 = this.GetExhibitComponent(entityId);
				if (exhibitComponent2 != null)
				{
					exhibitComponent2.HideSkeletalMeshComponent();
				}
			}
			else
			{
				exhibitComponent.RefreshSkeletalMeshComponent(itemId, false);
			}
			return true;
		}

		// Token: 0x06033303 RID: 209667 RVA: 0x00E58818 File Offset: 0x00E56A18
		private List<EntityItemBundleInfo> BuildPhantomBundleInfos(int? phantomId = null)
		{
			int? num = phantomId;
			int? num2 = (num != null) ? num : this.PlacedPhantomId;
			if (this.EntityId == null || num2 == null)
			{
				return new List<EntityItemBundleInfo>();
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId.Value);
			if (entityById == null)
			{
				return new List<EntityItemBundleInfo>();
			}
			int value = num2.Value;
			EntityItemBundleInfo entityItemBundleInfo = EntityItemBundleInfo.Create();
			entityItemBundleInfo.EntityId = MathUtils.Instance.NumberToLong(entityById.CreatureDataId);
			entityItemBundleInfo.ItemId = value;
			return new List<EntityItemBundleInfo>
			{
				entityItemBundleInfo
			};
		}

		// Token: 0x06033304 RID: 209668 RVA: 0x00E588B0 File Offset: 0x00E56AB0
		private EPhantomExhibitSizeType? GetSize()
		{
			SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(this.EntityId.Value);
			IPhantomExhibitConfig phantomExhibitConfig = ((exhibitComponent != null) ? exhibitComponent.GetExhibitConfig() : null) as IPhantomExhibitConfig;
			if (phantomExhibitConfig == null)
			{
				return null;
			}
			return new EPhantomExhibitSizeType?(phantomExhibitConfig.PhantomSize);
		}

		// Token: 0x06033305 RID: 209669 RVA: 0x00E588F8 File Offset: 0x00E56AF8
		[NullableContext(2)]
		private SceneItemExhibitComponent GetExhibitComponent(int entityId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null)
			{
				return null;
			}
			SceneItemExhibitComponent component = entityById.Entity.GetComponent<SceneItemExhibitComponent>();
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 1);
				defaultInterpolatedStringHandler.AppendLiteral("刷新场景物品展示模型失败，PbDataId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
				defaultInterpolatedStringHandler.AppendLiteral("，Entity没有ActorComponent");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return component;
		}

		// Token: 0x06033306 RID: 209670 RVA: 0x00E58970 File Offset: 0x00E56B70
		private void SaveIfChange()
		{
			int valueOrDefault = this.PlacedPhantomId.GetValueOrDefault();
			if (valueOrDefault != this.OriginItemId)
			{
				List<EntityItemBundleInfo> bundleInfos = this.BuildPhantomBundleInfos(new int?(valueOrDefault));
				SpringManorController.Instance.RequestExhibitionSave(bundleInfos);
			}
		}

		// Token: 0x06033307 RID: 209671 RVA: 0x00E589AC File Offset: 0x00E56BAC
		private void OnClickCloseBtn()
		{
			int valueOrDefault = this.PreviewPhantomId.GetValueOrDefault();
			int valueOrDefault2 = this.PlacedPhantomId.GetValueOrDefault();
			if (valueOrDefault == valueOrDefault2)
			{
				this.SaveIfChange();
				base.CloseMe(null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SpringManorPhantomExhibitConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				this.PreviewPhantomId = this.PlacedPhantomId;
				if (this.EntityId != null)
				{
					this.RefreshSceneItemExhibit(this.EntityId.Value, this.PlacedPhantomId.GetValueOrDefault());
				}
				this.SaveIfChange();
				base.CloseMe(null);
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.PlacedPhantomId = this.PreviewPhantomId;
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomDisplayUpdated_Tips", Array.Empty<object>());
				this.SaveIfChange();
				base.CloseMe(null);
			});
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06033308 RID: 209672 RVA: 0x00E58A30 File Offset: 0x00E56C30
		private void OnClickBtnPlace(int _)
		{
			if (this.CurrentSelectedPhantomId == null)
			{
				return;
			}
			int? placedPhantomId = this.PlacedPhantomId;
			int? currentSelectedPhantomId = this.CurrentSelectedPhantomId;
			if (placedPhantomId.GetValueOrDefault() == currentSelectedPhantomId.GetValueOrDefault() & placedPhantomId != null == (currentSelectedPhantomId != null))
			{
				return;
			}
			if (this.PlacedPhantomId != null)
			{
				this.UpdatePhantomSelectionState(this.PlacedPhantomId.Value, false);
			}
			this.PlacedPhantomId = this.CurrentSelectedPhantomId;
			this.UpdatePhantomSelectionState(this.CurrentSelectedPhantomId.Value, true);
			this.PreviewPhantomSelection(this.PlacedPhantomId.Value);
			this.RefreshOperationButtonState();
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomDisplayUpdated_Tips", Array.Empty<object>());
		}

		// Token: 0x06033309 RID: 209673 RVA: 0x00E58AE8 File Offset: 0x00E56CE8
		private void OnClickBtnRemove()
		{
			if (this.CurrentSelectedPhantomId == null)
			{
				return;
			}
			int? placedPhantomId = this.PlacedPhantomId;
			int? currentSelectedPhantomId = this.CurrentSelectedPhantomId;
			if (!(placedPhantomId.GetValueOrDefault() == currentSelectedPhantomId.GetValueOrDefault() & placedPhantomId != null == (currentSelectedPhantomId != null)))
			{
				return;
			}
			this.PlacedPhantomId = null;
			this.PreviewPhantomId = null;
			this.UpdatePhantomSelectionState(this.CurrentSelectedPhantomId.Value, false);
			SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(this.EntityId.Value);
			if (exhibitComponent != null)
			{
				exhibitComponent.HideSkeletalMeshComponent();
			}
			this.RefreshOperationButtonState();
		}

		// Token: 0x0401B2B5 RID: 111285
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SpringManorPhantomExhibitGrid, SpringManorPhantomDisplayItem> PhantomScrollView;

		// Token: 0x0401B2B6 RID: 111286
		private List<SpringManorPhantomDisplayItem> PhantomGridDataSource = new List<SpringManorPhantomDisplayItem>();

		// Token: 0x0401B2B7 RID: 111287
		[Nullable(2)]
		private FilterSortEntrance<int> FilterSortComponent;

		// Token: 0x0401B2B8 RID: 111288
		private int? CurrentSelectedPhantomId;

		// Token: 0x0401B2B9 RID: 111289
		private int? PreviewPhantomId;

		// Token: 0x0401B2BA RID: 111290
		private int? PlacedPhantomId;

		// Token: 0x0401B2BB RID: 111291
		private int PhantomBodySize = 1;

		// Token: 0x0401B2BC RID: 111292
		private int? EntityId;

		// Token: 0x0401B2BD RID: 111293
		private int OriginItemId;

		// Token: 0x0401B2BE RID: 111294
		[Nullable(2)]
		private ButtonItem PlaceButtonItem;

		// Token: 0x0401B2BF RID: 111295
		private readonly Dictionary<EPhantomExhibitSizeType, int> phantomExhibitBodySizeRecord = new Dictionary<EPhantomExhibitSizeType, int>
		{
			{
				EPhantomExhibitSizeType.Small,
				1
			},
			{
				EPhantomExhibitSizeType.Big,
				2
			},
			{
				EPhantomExhibitSizeType.Huge,
				3
			}
		};

		// Token: 0x0200ACB1 RID: 44209
		[NullableContext(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x06046BE0 RID: 289760 RVA: 0x0155C182 File Offset: 0x0155A382
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x0403569D RID: 218781
			[RequiredMember]
			public int TargetPhantomExhibitEntity;
		}
	}
}
