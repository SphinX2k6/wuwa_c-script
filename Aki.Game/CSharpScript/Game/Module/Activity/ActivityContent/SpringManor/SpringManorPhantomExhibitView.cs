using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200604F RID: 24655
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorPhantomExhibitView : UiViewBase
	{
		// Token: 0x0603E62E RID: 255534 RVA: 0x00F1132E File Offset: 0x00F0F52E
		public SpringManorPhantomExhibitView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E62F RID: 255535 RVA: 0x00F1136C File Offset: 0x00F0F56C
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

		// Token: 0x0603E630 RID: 255536 RVA: 0x00F11444 File Offset: 0x00F0F644
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorPhantomExhibitView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorPhantomExhibitView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E631 RID: 255537 RVA: 0x00F11487 File Offset: 0x00F0F687
		protected override void OnBeforeShow()
		{
			this.RefreshPhantomList();
		}

		// Token: 0x0603E632 RID: 255538 RVA: 0x00F1148F File Offset: 0x00F0F68F
		protected override void OnBeforeDestroy()
		{
			UiCameraAnimationManager.Instance.EnablePlayerActor();
			FilterSortEntrance<int> filterSortComponent = this.FilterSortComponent;
			if (filterSortComponent == null)
			{
				return;
			}
			filterSortComponent.ClearData(EFilterSortGroupId.MonsterHandBook);
		}

		// Token: 0x0603E633 RID: 255539 RVA: 0x00F114B0 File Offset: 0x00F0F6B0
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

		// Token: 0x0603E634 RID: 255540 RVA: 0x00F114FF File Offset: 0x00F0F6FF
		private SpringManorPhantomExhibitGrid CreatePhantomGrid()
		{
			return new SpringManorPhantomExhibitGrid
			{
				OnToggleClick = new Action<int, int>(this.OnPhantomGridSelected)
			};
		}

		// Token: 0x0603E635 RID: 255541 RVA: 0x00F11518 File Offset: 0x00F0F718
		private void InitFilterSortEntrance()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			this.FilterSortComponent = new FilterSortEntrance<int>(item, new TUpdateDataListFunction<int>(this.OnFilterSortRefresh));
		}

		// Token: 0x0603E636 RID: 255542 RVA: 0x00F1154C File Offset: 0x00F0F74C
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

		// Token: 0x0603E637 RID: 255543 RVA: 0x00F1161C File Offset: 0x00F0F81C
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

		// Token: 0x0603E638 RID: 255544 RVA: 0x00F11810 File Offset: 0x00F0FA10
		private void OnFilterSortRefresh(List<int> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.UpdatePhantomGridDataSource(list);
		}

		// Token: 0x0603E639 RID: 255545 RVA: 0x00F11826 File Offset: 0x00F0FA26
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

		// Token: 0x0603E63A RID: 255546 RVA: 0x00F11854 File Offset: 0x00F0FA54
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

		// Token: 0x0603E63B RID: 255547 RVA: 0x00F11948 File Offset: 0x00F0FB48
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

		// Token: 0x0603E63C RID: 255548 RVA: 0x00F119A5 File Offset: 0x00F0FBA5
		private void PreviewPhantomSelection(int phantomId)
		{
			if (this.EntityId == null)
			{
				return;
			}
			this.PreviewPhantomId = new int?(phantomId);
			this.RefreshSceneItemExhibit(this.EntityId.Value, phantomId);
		}

		// Token: 0x0603E63D RID: 255549 RVA: 0x00F119D4 File Offset: 0x00F0FBD4
		private UniTask InitCaptionAsync()
		{
			SpringManorPhantomExhibitView.<InitCaptionAsync>d__27 <InitCaptionAsync>d__;
			<InitCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionAsync>d__.<>4__this = this;
			<InitCaptionAsync>d__.<>1__state = -1;
			<InitCaptionAsync>d__.<>t__builder.Start<SpringManorPhantomExhibitView.<InitCaptionAsync>d__27>(ref <InitCaptionAsync>d__);
			return <InitCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E63E RID: 255550 RVA: 0x00F11A18 File Offset: 0x00F0FC18
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

		// Token: 0x0603E63F RID: 255551 RVA: 0x00F11A54 File Offset: 0x00F0FC54
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

		// Token: 0x0603E640 RID: 255552 RVA: 0x00F11AEC File Offset: 0x00F0FCEC
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

		// Token: 0x0603E641 RID: 255553 RVA: 0x00F11B34 File Offset: 0x00F0FD34
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

		// Token: 0x0603E642 RID: 255554 RVA: 0x00F11BAC File Offset: 0x00F0FDAC
		private void SaveIfChange()
		{
			int valueOrDefault = this.PlacedPhantomId.GetValueOrDefault();
			if (valueOrDefault != this.OriginItemId)
			{
				List<EntityItemBundleInfo> bundleInfos = this.BuildPhantomBundleInfos(new int?(valueOrDefault));
				SpringManorController.Instance.RequestExhibitionSave(bundleInfos);
			}
		}

		// Token: 0x0603E643 RID: 255555 RVA: 0x00F11BE8 File Offset: 0x00F0FDE8
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

		// Token: 0x0603E644 RID: 255556 RVA: 0x00F11C6C File Offset: 0x00F0FE6C
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

		// Token: 0x0603E645 RID: 255557 RVA: 0x00F11D24 File Offset: 0x00F0FF24
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

		// Token: 0x04020988 RID: 133512
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SpringManorPhantomExhibitGrid, SpringManorPhantomDisplayItem> PhantomScrollView;

		// Token: 0x04020989 RID: 133513
		private List<SpringManorPhantomDisplayItem> PhantomGridDataSource = new List<SpringManorPhantomDisplayItem>();

		// Token: 0x0402098A RID: 133514
		[Nullable(2)]
		private FilterSortEntrance<int> FilterSortComponent;

		// Token: 0x0402098B RID: 133515
		private int? CurrentSelectedPhantomId;

		// Token: 0x0402098C RID: 133516
		private int? PreviewPhantomId;

		// Token: 0x0402098D RID: 133517
		private int? PlacedPhantomId;

		// Token: 0x0402098E RID: 133518
		private int PhantomBodySize = 1;

		// Token: 0x0402098F RID: 133519
		private int? EntityId;

		// Token: 0x04020990 RID: 133520
		private int OriginItemId;

		// Token: 0x04020991 RID: 133521
		[Nullable(2)]
		private ButtonItem PlaceButtonItem;

		// Token: 0x04020992 RID: 133522
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

		// Token: 0x0200C2C6 RID: 49862
		[NullableContext(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x060506EE RID: 329454 RVA: 0x015A43EE File Offset: 0x015A25EE
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x0403AD35 RID: 240949
			[RequiredMember]
			public int TargetPhantomExhibitEntity;
		}
	}
}
