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
	// Token: 0x020049E6 RID: 18918
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpackItem : DangoBrawlItemViewBase
	{
		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x0602F656 RID: 194134 RVA: 0x00D37A4E File Offset: 0x00D35C4E
		[Nullable(2)]
		public DangoBrawlBackpackItemData MyItemData
		{
			[NullableContext(2)]
			get
			{
				return this.ItemData as DangoBrawlBackpackItemData;
			}
		}

		// Token: 0x0602F657 RID: 194135 RVA: 0x00D37A5C File Offset: 0x00D35C5C
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

		// Token: 0x0602F658 RID: 194136 RVA: 0x00D37B87 File Offset: 0x00D35D87
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

		// Token: 0x0602F659 RID: 194137 RVA: 0x00D37BBB File Offset: 0x00D35DBB
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnbindClickCallbacks();
		}

		// Token: 0x0602F65A RID: 194138 RVA: 0x00D37BC9 File Offset: 0x00D35DC9
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

		// Token: 0x0602F65B RID: 194139 RVA: 0x00D37C08 File Offset: 0x00D35E08
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

		// Token: 0x0602F65C RID: 194140 RVA: 0x00D37C3C File Offset: 0x00D35E3C
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

		// Token: 0x0602F65D RID: 194141 RVA: 0x00D37C9B File Offset: 0x00D35E9B
		private float MapProgress(float t)
		{
			return this.CDMaskMin + (this.CDMaskMax - this.CDMaskMin) * t;
		}

		// Token: 0x0602F65E RID: 194142 RVA: 0x00D37CB4 File Offset: 0x00D35EB4
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

		// Token: 0x0602F65F RID: 194143 RVA: 0x00D37D14 File Offset: 0x00D35F14
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

		// Token: 0x0602F660 RID: 194144 RVA: 0x00D37D6C File Offset: 0x00D35F6C
		public void OnWeaponStop(int stopMs)
		{
			if (stopMs <= 0)
			{
				return;
			}
			this.FreezeRemainMs += stopMs;
		}

		// Token: 0x0602F661 RID: 194145 RVA: 0x00D37D84 File Offset: 0x00D35F84
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

		// Token: 0x0602F662 RID: 194146 RVA: 0x00D37DDC File Offset: 0x00D35FDC
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

		// Token: 0x0602F663 RID: 194147 RVA: 0x00D37E34 File Offset: 0x00D36034
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

		// Token: 0x0602F664 RID: 194148 RVA: 0x00D37F3B File Offset: 0x00D3613B
		protected override void OnEndSequenceEvent(string sequenceName)
		{
			this.OnEffectShowSeqEnd(sequenceName);
		}

		// Token: 0x0602F665 RID: 194149 RVA: 0x00D37F44 File Offset: 0x00D36144
		private void OnEffectShowSeqEnd(string sequenceName)
		{
			if (this.EffectShowHoldSeqName == null || this.EffectShowHoldSeqName != sequenceName)
			{
				return;
			}
			this.EffectShowHoldSeqName = null;
			this.RefreshCDProgress(false);
		}

		// Token: 0x0602F666 RID: 194150 RVA: 0x00D37F6C File Offset: 0x00D3616C
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

		// Token: 0x0602F667 RID: 194151 RVA: 0x00D380EC File Offset: 0x00D362EC
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

		// Token: 0x0602F668 RID: 194152 RVA: 0x00D381D8 File Offset: 0x00D363D8
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

		// Token: 0x0602F669 RID: 194153 RVA: 0x00D38233 File Offset: 0x00D36433
		public void BindData(ActivityDangoBrawlData actData, DangoBrawlBackpackItemData itemData, int gridSize = 0)
		{
			base.BindData(actData, itemData, gridSize);
		}

		// Token: 0x0602F66A RID: 194154 RVA: 0x00D38240 File Offset: 0x00D36440
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

		// Token: 0x0602F66B RID: 194155 RVA: 0x00D382C0 File Offset: 0x00D364C0
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

		// Token: 0x0602F66C RID: 194156 RVA: 0x00D38388 File Offset: 0x00D36588
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

		// Token: 0x0602F66D RID: 194157 RVA: 0x00D383D8 File Offset: 0x00D365D8
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

		// Token: 0x0602F66E RID: 194158 RVA: 0x00D38420 File Offset: 0x00D36620
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

		// Token: 0x0602F66F RID: 194159 RVA: 0x00D3844F File Offset: 0x00D3664F
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

		// Token: 0x0602F670 RID: 194160 RVA: 0x00D3846C File Offset: 0x00D3666C
		private UniTask RefreshWeightAsync()
		{
			DangoBrawlBattleBackpackItem.<RefreshWeightAsync>d__48 <RefreshWeightAsync>d__;
			<RefreshWeightAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshWeightAsync>d__.<>4__this = this;
			<RefreshWeightAsync>d__.<>1__state = -1;
			<RefreshWeightAsync>d__.<>t__builder.Start<DangoBrawlBattleBackpackItem.<RefreshWeightAsync>d__48>(ref <RefreshWeightAsync>d__);
			return <RefreshWeightAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F671 RID: 194161 RVA: 0x00D384AF File Offset: 0x00D366AF
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

		// Token: 0x0602F672 RID: 194162 RVA: 0x00D384D6 File Offset: 0x00D366D6
		protected override float GetIconScale(DangoBrawlItem itemConfig)
		{
			return itemConfig.IconBattleScale;
		}

		// Token: 0x0602F673 RID: 194163 RVA: 0x00D384E0 File Offset: 0x00D366E0
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

		// Token: 0x0602F674 RID: 194164 RVA: 0x00D3851A File Offset: 0x00D3671A
		public UUIItem GetCenterItem()
		{
			return this.RootItem;
		}

		// Token: 0x040191E0 RID: 102880
		[Nullable(2)]
		private DangoBrawlViewCost WeightPanel;

		// Token: 0x040191E1 RID: 102881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlBattleBackpackItem> OnClickItem;

		// Token: 0x040191E2 RID: 102882
		private const int CD_TICK_INTERVAL = 50;

		// Token: 0x040191E3 RID: 102883
		[Nullable(2)]
		private TimerHandle CDTickHandle;

		// Token: 0x040191E4 RID: 102884
		private const float DangoBrwalCDStart = -0.2f;

		// Token: 0x040191E5 RID: 102885
		private const float DangoBrawlCDEnd = 1.2f;

		// Token: 0x040191E6 RID: 102886
		private const float MeshXBase = 15f;

		// Token: 0x040191E7 RID: 102887
		private const float MeshYBase = 1.5f;

		// Token: 0x040191E8 RID: 102888
		private const float LocationHBase = 50f;

		// Token: 0x040191E9 RID: 102889
		private const float LocationRBase = 80f;

		// Token: 0x040191EA RID: 102890
		private float CDMaskMin;

		// Token: 0x040191EB RID: 102891
		private float CDMaskMax;

		// Token: 0x040191EC RID: 102892
		private int CdStartMs;

		// Token: 0x040191ED RID: 102893
		private int CdReadyMs;

		// Token: 0x040191EE RID: 102894
		private int FreezeRemainMs;

		// Token: 0x040191EF RID: 102895
		[Nullable(2)]
		private string EffectShowHoldSeqName;

		// Token: 0x040191F0 RID: 102896
		private bool IsTriggerLimit;

		// Token: 0x040191F1 RID: 102897
		private static readonly FName RotateParamName = FNameUtil.GetDynamicFName("Rotate").Value;

		// Token: 0x040191F2 RID: 102898
		private static readonly FName ProgressParamName = FNameUtil.GetDynamicFName("Progress").Value;

		// Token: 0x0200A66E RID: 42606
		[NullableContext(0)]
		protected enum EComponents
		{
			// Token: 0x04033742 RID: 210754
			ItemWeight = 11,
			// Token: 0x04033743 RID: 210755
			PanelVfx = 16,
			// Token: 0x04033744 RID: 210756
			UniqueWeaponItem,
			// Token: 0x04033745 RID: 210757
			SprIconMask02,
			// Token: 0x04033746 RID: 210758
			Niagara,
			// Token: 0x04033747 RID: 210759
			FxNiagara,
			// Token: 0x04033748 RID: 210760
			FxNiagaraType1,
			// Token: 0x04033749 RID: 210761
			FxNiagaraType2,
			// Token: 0x0403374A RID: 210762
			SprIconMask03 = 24,
			// Token: 0x0403374B RID: 210763
			NiagaraQualityFx = 26
		}

		// Token: 0x0200A66F RID: 42607
		[NullableContext(0)]
		public struct DangoBrawlCdSnapshot
		{
			// Token: 0x0403374C RID: 210764
			public int StartMs;

			// Token: 0x0403374D RID: 210765
			public int ReadyMs;

			// Token: 0x0403374E RID: 210766
			public int FreezeRemainMs;

			// Token: 0x0403374F RID: 210767
			public bool IsTriggerLimit;
		}
	}
}
