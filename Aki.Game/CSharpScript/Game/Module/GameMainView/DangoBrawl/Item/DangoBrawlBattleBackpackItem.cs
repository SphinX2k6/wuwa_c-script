using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A0A RID: 23050
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpackItem : DangoBrawlItemViewBase
	{
		// Token: 0x17008BC5 RID: 35781
		// (get) Token: 0x0603A70D RID: 239373 RVA: 0x00DE74CE File Offset: 0x00DE56CE
		[Nullable(2)]
		public DangoBrawlBackpackItemData MyItemData
		{
			[NullableContext(2)]
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x0603A70E RID: 239374 RVA: 0x00DE74DC File Offset: 0x00DE56DC
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(16, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(17, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(19, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(20, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(21, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(22, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(18, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(24, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(26, typeof(UUINiagara)));
		}

		// Token: 0x0603A70F RID: 239375 RVA: 0x00DE7607 File Offset: 0x00DE5807
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.BindClickCallbacks();
		}

		// Token: 0x0603A710 RID: 239376 RVA: 0x00DE763B File Offset: 0x00DE583B
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnbindClickCallbacks();
		}

		// Token: 0x0603A711 RID: 239377 RVA: 0x00DE7649 File Offset: 0x00DE5849
		public void RegisterFightingTickCallback()
		{
			if (this.CDTickHandle != null)
			{
				return;
			}
			this.ResetCdReady();
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			this.CDTickHandle = ((battleManager != null) ? battleManager.RegisterFightingTickCallback(new TTimerAction(this.OnTickCD), 50f) : null);
		}

		// Token: 0x0603A712 RID: 239378 RVA: 0x00DE7688 File Offset: 0x00DE5888
		public void UnregisterFightingTickCallback()
		{
			if (this.CDTickHandle == null)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager != null)
			{
				battleManager.UnregisterFightingTickCallback(this.CDTickHandle);
			}
			this.CDTickHandle = null;
			this.ResetCdReady();
		}

		// Token: 0x0603A713 RID: 239379 RVA: 0x00DE76BC File Offset: 0x00DE58BC
		private void ResetCdReady()
		{
			this.CdStartMs = 0;
			this.CdReadyMs = 0;
			this.FreezeRemainMs = 0;
			this.EffectShowHoldSeqName = null;
			this.IsTriggerLimit = false;
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, 1.2f);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(20);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0603A714 RID: 239380 RVA: 0x00DE771B File Offset: 0x00DE591B
		private float MapProgress(float t)
		{
			return this.CDMaskMin + (this.CDMaskMax - this.CDMaskMin) * t;
		}

		// Token: 0x0603A715 RID: 239381 RVA: 0x00DE7734 File Offset: 0x00DE5934
		private void OnTickCD(float delta)
		{
			if (this.CdReadyMs <= 0)
			{
				return;
			}
			if (this.FreezeRemainMs > 0)
			{
				int num = Math.Min((int)delta, this.FreezeRemainMs);
				this.CdStartMs += num;
				this.CdReadyMs += num;
				this.FreezeRemainMs -= num;
				return;
			}
			this.RefreshCDProgress(false);
		}

		// Token: 0x0603A716 RID: 239382 RVA: 0x00DE7794 File Offset: 0x00DE5994
		public void RefreshOnCDChange(int nextReadyMs)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
			this.CdStartMs = (int)((dangoBrawlFightingClock != null) ? dangoBrawlFightingClock.FightingElapsed : 0f);
			this.CdReadyMs = nextReadyMs;
			this.FreezeRemainMs = 0;
			this.IsTriggerLimit = false;
			this.RefreshCDProgress(false);
		}

		// Token: 0x0603A717 RID: 239383 RVA: 0x00DE77EC File Offset: 0x00DE59EC
		public void OnWeaponStop(int stopMs)
		{
			if (stopMs <= 0)
			{
				return;
			}
			this.FreezeRemainMs += stopMs;
		}

		// Token: 0x0603A718 RID: 239384 RVA: 0x00DE7804 File Offset: 0x00DE5A04
		public bool TryGetCdSnapshot(out DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot snapshot)
		{
			snapshot = default(DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot);
			if (this.CdReadyMs <= 0 && !this.IsTriggerLimit)
			{
				return false;
			}
			snapshot.StartMs = this.CdStartMs;
			snapshot.ReadyMs = this.CdReadyMs;
			snapshot.FreezeRemainMs = this.FreezeRemainMs;
			snapshot.IsTriggerLimit = this.IsTriggerLimit;
			return true;
		}

		// Token: 0x0603A719 RID: 239385 RVA: 0x00DE785C File Offset: 0x00DE5A5C
		public void ApplyCdSnapshot(DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot snapshot)
		{
			if (snapshot.ReadyMs <= 0 && !snapshot.IsTriggerLimit)
			{
				return;
			}
			this.CdStartMs = snapshot.StartMs;
			this.CdReadyMs = snapshot.ReadyMs;
			this.FreezeRemainMs = snapshot.FreezeRemainMs;
			this.IsTriggerLimit = snapshot.IsTriggerLimit;
			this.RefreshCDProgress(true);
		}

		// Token: 0x0603A71A RID: 239386 RVA: 0x00DE78B4 File Offset: 0x00DE5AB4
		public void OnItemEffectShow(DangoBrawlItemUIEffectData data)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPrevSequence(false, true);
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			bool flag = dangoBrawlItemById.Value.UIAnimShowType == 2;
			this.IsTriggerLimit = (flag && data.IsTriggerLimit);
			string uianimSeqName = dangoBrawlItemById.Value.UIAnimSeqName;
			bool flag2 = false;
			if (!string.IsNullOrEmpty(uianimSeqName))
			{
				UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.PlayOrReplaySequenceByName(uianimSeqName, false, null);
				}
				flag2 = true;
			}
			if (flag2)
			{
				this.EffectShowHoldSeqName = uianimSeqName;
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, 1.2f);
				}
			}
			else if (flag)
			{
				float value = this.IsTriggerLimit ? -0.2f : 1.2f;
				UUITexture texture2 = base.GetTexture(2);
				if (texture2 != null)
				{
					texture2.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, value);
				}
			}
			this.ApplyNiagaraType0(dangoBrawlItemById.Value);
		}

		// Token: 0x0603A71B RID: 239387 RVA: 0x00DE79BB File Offset: 0x00DE5BBB
		protected override void OnEndSequenceEvent(string sequenceName)
		{
			this.OnEffectShowSeqEnd(sequenceName);
		}

		// Token: 0x0603A71C RID: 239388 RVA: 0x00DE79C4 File Offset: 0x00DE5BC4
		private void OnEffectShowSeqEnd(string sequenceName)
		{
			if (this.EffectShowHoldSeqName == null || this.EffectShowHoldSeqName != sequenceName)
			{
				return;
			}
			this.EffectShowHoldSeqName = null;
			this.RefreshCDProgress(false);
		}

		// Token: 0x0603A71D RID: 239389 RVA: 0x00DE79EC File Offset: 0x00DE5BEC
		private void ApplyNiagaraType0(DangoBrawlItem itemConfig)
		{
			UUINiagara fxNiagara = base.GetUiNiagara(20);
			if (fxNiagara == null)
			{
				return;
			}
			if (itemConfig.UINiagaraType != 0)
			{
				fxNiagara.SetUIActive(false);
				return;
			}
			bool applyMeshParams;
			int locationFlag;
			string text;
			FColor color;
			if (!string.IsNullOrEmpty(itemConfig.UINiagaraPath))
			{
				text = itemConfig.UINiagaraPath;
				color = FColor.FromHex("FFFFFFFF");
				applyMeshParams = false;
				locationFlag = 0;
			}
			else
			{
				DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfig.Quality);
				text = ((itemQualityConfigById != null) ? itemQualityConfigById.GetValueOrDefault().UINiagaraPath : null);
				string text2 = (itemQualityConfigById != null) ? itemQualityConfigById.GetValueOrDefault().UINiagaraColor : null;
				color = (string.IsNullOrEmpty(text2) ? FColor.FromHex("FFFFFFFF") : FColor.FromHex(text2));
				applyMeshParams = true;
				locationFlag = ((itemQualityConfigById != null) ? itemQualityConfigById.GetValueOrDefault().UINiagaraSize : 0);
			}
			if (string.IsNullOrEmpty(text))
			{
				fxNiagara.SetUIActive(false);
				return;
			}
			fxNiagara.SetUIActive(false);
			ValueTuple<int, int> boundSize = DangoBrawlUtil.GetBoundSize(DangoBrawlUtil.RotatePanelPosList(this.ItemData.MyConfigId, EDangoBrawlRotate.Direction0));
			int baseRow = boundSize.Item1;
			int baseCol = boundSize.Item2;
			base.SetNiagaraSystemByPath(text, fxNiagara, delegate(bool suc)
			{
				if (!suc || !fxNiagara.IsValid())
				{
					return;
				}
				if (applyMeshParams)
				{
					fxNiagara.SetNiagaraVarVector("Mesh_size", new FVector((float)baseCol * 15f, (float)baseRow * 1.5f, 0f));
					if (locationFlag != 0)
					{
						fxNiagara.SetNiagaraVarFloat("Location_R", (float)baseCol * 80f);
						fxNiagara.SetNiagaraVarFloat("Location_H", (float)baseRow * 50f);
					}
				}
				fxNiagara.SetUIActive(true);
				fxNiagara.ActivateSystem(true);
			});
			fxNiagara.SetColor(color);
		}

		// Token: 0x0603A71E RID: 239390 RVA: 0x00DE7B6C File Offset: 0x00DE5D6C
		private void RefreshCDProgress(bool force = false)
		{
			if (this.EffectShowHoldSeqName != null)
			{
				UUITexture texture = base.GetTexture(2);
				if (texture == null)
				{
					return;
				}
				texture.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, 1.2f);
				return;
			}
			else if (this.IsTriggerLimit)
			{
				UUITexture texture2 = base.GetTexture(2);
				if (texture2 == null)
				{
					return;
				}
				texture2.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, -0.2f);
				return;
			}
			else
			{
				if (this.FreezeRemainMs > 0 && !force)
				{
					return;
				}
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
				int num = (int)((dangoBrawlFightingClock != null) ? dangoBrawlFightingClock.FightingElapsed : 0f);
				int num2 = this.CdReadyMs - this.CdStartMs;
				float num3;
				if (num2 <= 0)
				{
					num3 = 0f;
				}
				else
				{
					int num4 = this.CdReadyMs - num;
					if (num4 <= 0)
					{
						num3 = 0f;
						this.CdReadyMs = 0;
					}
					else
					{
						num3 = (float)num4 / (float)num2;
					}
				}
				UUITexture texture3 = base.GetTexture(2);
				if (texture3 == null)
				{
					return;
				}
				texture3.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.ProgressParamName, this.MapProgress(1f - num3));
				return;
			}
		}

		// Token: 0x0603A71F RID: 239391 RVA: 0x00DE7C58 File Offset: 0x00DE5E58
		public void RefreshOnShow(DangoBrawlBackpackItemData itemData)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopPrevSequence(false, true);
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			if (activityDangoBrawlData == null)
			{
				return;
			}
			this.BindData(activityDangoBrawlData, itemData, 136);
			this.RefreshView();
		}

		// Token: 0x0603A720 RID: 239392 RVA: 0x00DE7CB3 File Offset: 0x00DE5EB3
		public void BindData(ActivityDangoBrawlData actData, DangoBrawlBackpackItemData itemData, int gridSize = 0)
		{
			base.BindData(actData, itemData, gridSize);
		}

		// Token: 0x0603A721 RID: 239393 RVA: 0x00DE7CC0 File Offset: 0x00DE5EC0
		public virtual void RefreshView()
		{
			DangoBrawlBackpackItemData myItemData = this.MyItemData;
			EDangoBrawlRotate edangoBrawlRotate = (myItemData != null) ? myItemData.MyRotation : EDangoBrawlRotate.Direction0;
			this.RefreshIcon();
			base.RefreshBoundSize(edangoBrawlRotate);
			this.RefreshRotation(edangoBrawlRotate);
			base.RefreshShadow(edangoBrawlRotate);
			this.RefreshPosition();
			this.RefreshWeightAsync().Forget();
			this.RefreshUniqueWeapon();
			this.RefreshCDMaskRange(edangoBrawlRotate);
			this.RefreshQualityFx(base.GetItem(21), base.GetItem(22), base.GetUiNiagara(26));
			this.ResetCdReady();
		}

		// Token: 0x0603A722 RID: 239394 RVA: 0x00DE7D40 File Offset: 0x00DE5F40
		private void RefreshCDMaskRange(EDangoBrawlRotate rotate)
		{
			this.CDMaskMin = 0f;
			this.CDMaskMax = 1f;
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			if (rotate < EDangoBrawlRotate.Direction0 || rotate >= (EDangoBrawlRotate)dangoBrawlItemById.Value.CDMaskRangeLength)
			{
				return;
			}
			IntArray? intArray = dangoBrawlItemById.Value.CDMaskRange((int)rotate);
			if (intArray == null || intArray.Value.ArrayIntLength != 2)
			{
				return;
			}
			this.CDMaskMin = (float)intArray.Value.ArrayInt(0) / 100f;
			this.CDMaskMax = (float)intArray.Value.ArrayInt(1) / 100f;
		}

		// Token: 0x0603A723 RID: 239395 RVA: 0x00DE7E08 File Offset: 0x00DE6008
		private void RefreshUniqueWeapon()
		{
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemData.MyConfigId);
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(dangoBrawlItemById != null && dangoBrawlItemById.GetValueOrDefault().IsSpeItem);
		}

		// Token: 0x0603A724 RID: 239396 RVA: 0x00DE7E58 File Offset: 0x00DE6058
		private void BindClickCallbacks()
		{
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable == null)
			{
				return;
			}
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		}

		// Token: 0x0603A725 RID: 239397 RVA: 0x00DE7EA0 File Offset: 0x00DE60A0
		private void UnbindClickCallbacks()
		{
			UUIDraggableComponent draggable = base.GetDraggable(1);
			if (draggable == null)
			{
				return;
			}
			draggable.OnPointerUpCallBack.Unbind();
			draggable.OnPointerCancelCallBack.Unbind();
		}

		// Token: 0x0603A726 RID: 239398 RVA: 0x00DE7ECF File Offset: 0x00DE60CF
		[NullableContext(2)]
		private void OnPointerUp(ULGUIPointerEventData data)
		{
			if (this.ItemData == null)
			{
				return;
			}
			Action<DangoBrawlBattleBackpackItem> onClickItem = this.OnClickItem;
			if (onClickItem == null)
			{
				return;
			}
			onClickItem(this);
		}

		// Token: 0x0603A727 RID: 239399 RVA: 0x00DE7EEC File Offset: 0x00DE60EC
		private UniTask RefreshWeightAsync()
		{
			DangoBrawlBattleBackpackItem.<RefreshWeightAsync>d__48 <RefreshWeightAsync>d__;
			<RefreshWeightAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshWeightAsync>d__.<>4__this = this;
			<RefreshWeightAsync>d__.<>1__state = -1;
			<RefreshWeightAsync>d__.<>t__builder.Start<DangoBrawlBattleBackpackItem.<RefreshWeightAsync>d__48>(ref <RefreshWeightAsync>d__);
			return <RefreshWeightAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A728 RID: 239400 RVA: 0x00DE7F2F File Offset: 0x00DE612F
		protected virtual void RefreshRotation(EDangoBrawlRotate val)
		{
			base.ApplyRotationToPnlRotate(val);
			UUITexture texture = base.GetTexture(2);
			if (texture == null)
			{
				return;
			}
			texture.SetCustomMaterialScalarParameter(DangoBrawlBattleBackpackItem.RotateParamName, (float)val * 0.25f);
		}

		// Token: 0x0603A729 RID: 239401 RVA: 0x00DE7F56 File Offset: 0x00DE6156
		protected override float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBattleScale;
		}

		// Token: 0x0603A72A RID: 239402 RVA: 0x00DE7F60 File Offset: 0x00DE6160
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			UUITexture texture = base.GetTexture(18);
			if (texture != null)
			{
				textures.Add(texture);
			}
			UUITexture texture2 = base.GetTexture(24);
			if (texture2 != null)
			{
				textures.Add(texture2);
			}
		}

		// Token: 0x0603A72B RID: 239403 RVA: 0x00DE7F9A File Offset: 0x00DE619A
		public UUIItem GetCenterItem()
		{
			return this.RootItem;
		}

		// Token: 0x0401E739 RID: 124729
		[Nullable(2)]
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x0401E73A RID: 124730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlBattleBackpackItem> OnClickItem;

		// Token: 0x0401E73B RID: 124731
		private const int CD_TICK_INTERVAL = 50;

		// Token: 0x0401E73C RID: 124732
		[Nullable(2)]
		private TimerHandle CDTickHandle;

		// Token: 0x0401E73D RID: 124733
		private const float DangoBrwalCDStart = -0.2f;

		// Token: 0x0401E73E RID: 124734
		private const float DangoBrawlCDEnd = 1.2f;

		// Token: 0x0401E73F RID: 124735
		private const float MeshXBase = 15f;

		// Token: 0x0401E740 RID: 124736
		private const float MeshYBase = 1.5f;

		// Token: 0x0401E741 RID: 124737
		private const float LocationHBase = 50f;

		// Token: 0x0401E742 RID: 124738
		private const float LocationRBase = 80f;

		// Token: 0x0401E743 RID: 124739
		private float CDMaskMin;

		// Token: 0x0401E744 RID: 124740
		private float CDMaskMax;

		// Token: 0x0401E745 RID: 124741
		private int CdStartMs;

		// Token: 0x0401E746 RID: 124742
		private int CdReadyMs;

		// Token: 0x0401E747 RID: 124743
		private int FreezeRemainMs;

		// Token: 0x0401E748 RID: 124744
		[Nullable(2)]
		private string EffectShowHoldSeqName;

		// Token: 0x0401E749 RID: 124745
		private bool IsTriggerLimit;

		// Token: 0x0401E74A RID: 124746
		private static readonly FName RotateParamName = FNameUtil.GetDynamicFName("Rotate").Value;

		// Token: 0x0401E74B RID: 124747
		private static readonly FName ProgressParamName = FNameUtil.GetDynamicFName("Progress").Value;

		// Token: 0x0200BC65 RID: 48229
		[NullableContext(0)]
		protected enum EComponents
		{
			// Token: 0x04038D76 RID: 232822
			ItemWeight = 11,
			// Token: 0x04038D77 RID: 232823
			PanelVfx = 16,
			// Token: 0x04038D78 RID: 232824
			UniqueWeaponItem,
			// Token: 0x04038D79 RID: 232825
			SprIconMask02,
			// Token: 0x04038D7A RID: 232826
			Niagara,
			// Token: 0x04038D7B RID: 232827
			FxNiagara,
			// Token: 0x04038D7C RID: 232828
			FxNiagaraType1,
			// Token: 0x04038D7D RID: 232829
			FxNiagaraType2,
			// Token: 0x04038D7E RID: 232830
			SprIconMask03 = 24,
			// Token: 0x04038D7F RID: 232831
			NiagaraQualityFx = 26
		}

		// Token: 0x0200BC66 RID: 48230
		[NullableContext(0)]
		public struct DangoBrawlCdSnapshot
		{
			// Token: 0x04038D80 RID: 232832
			public int StartMs;

			// Token: 0x04038D81 RID: 232833
			public int ReadyMs;

			// Token: 0x04038D82 RID: 232834
			public int FreezeRemainMs;

			// Token: 0x04038D83 RID: 232835
			public bool IsTriggerLimit;
		}
	}
}
