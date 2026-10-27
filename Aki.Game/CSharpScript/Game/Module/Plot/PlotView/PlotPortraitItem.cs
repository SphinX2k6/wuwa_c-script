using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005058 RID: 20568
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotPortraitItem : UiPanelBase
	{
		// Token: 0x06034A1E RID: 215582 RVA: 0x00C6FA3C File Offset: 0x00C6DC3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034A1F RID: 215583 RVA: 0x00C6FC7C File Offset: 0x00C6DE7C
		public UniTask OpenAsync(UUIItem parentItem, IHeadStyle param)
		{
			PlotPortraitItem.<OpenAsync>d__27 <OpenAsync>d__;
			<OpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenAsync>d__.<>4__this = this;
			<OpenAsync>d__.parentItem = parentItem;
			<OpenAsync>d__.param = param;
			<OpenAsync>d__.<>1__state = -1;
			<OpenAsync>d__.<>t__builder.Start<PlotPortraitItem.<OpenAsync>d__27>(ref <OpenAsync>d__);
			return <OpenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A20 RID: 215584 RVA: 0x00C6FCD0 File Offset: 0x00C6DED0
		public UniTask CloseAsync()
		{
			PlotPortraitItem.<CloseAsync>d__28 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<PlotPortraitItem.<CloseAsync>d__28>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A21 RID: 215585 RVA: 0x00C6FD14 File Offset: 0x00C6DF14
		public UniTask SwitchAsync(IHeadStyle param)
		{
			PlotPortraitItem.<SwitchAsync>d__29 <SwitchAsync>d__;
			<SwitchAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchAsync>d__.<>1__state = -1;
			<SwitchAsync>d__.<>t__builder.Start<PlotPortraitItem.<SwitchAsync>d__29>(ref <SwitchAsync>d__);
			return <SwitchAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A22 RID: 215586 RVA: 0x00C6FD50 File Offset: 0x00C6DF50
		protected override UniTask OnCreateAsync()
		{
			PlotPortraitItem.<OnCreateAsync>d__30 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotPortraitItem.<OnCreateAsync>d__30>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A23 RID: 215587 RVA: 0x00C6FD93 File Offset: 0x00C6DF93
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06034A24 RID: 215588 RVA: 0x00C6FDA8 File Offset: 0x00C6DFA8
		protected override void OnBeforeShow()
		{
			this.HideAll();
			this.TickId = PlotController.Instance.AddTick(new Action<float>(this.OnTick));
			switch (this.OwnedSetHeadIcon.Type)
			{
			case EHeadStyle.Normal:
				this.ShowVideoCall();
				return;
			case EHeadStyle.VoiceOnly:
				this.ShowAudioCall();
				return;
			case EHeadStyle.WeakSignal:
				this.ShowInterferenceCall();
				return;
			case EHeadStyle.Warning:
				this.ShowEmergencyCall();
				return;
			case (EHeadStyle)4:
				break;
			case EHeadStyle.MonsterDisplay:
				this.ShowMonsterDispalyCall();
				break;
			default:
				return;
			}
		}

		// Token: 0x06034A25 RID: 215589 RVA: 0x00C6FE24 File Offset: 0x00C6E024
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PlotPortraitItem.<OnShowAsyncImplementImplement>d__33 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PlotPortraitItem.<OnShowAsyncImplementImplement>d__33>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034A26 RID: 215590 RVA: 0x00C6FE68 File Offset: 0x00C6E068
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PlotPortraitItem.<OnHideAsyncImplementImplement>d__34 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PlotPortraitItem.<OnHideAsyncImplementImplement>d__34>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034A27 RID: 215591 RVA: 0x00C6FEAB File Offset: 0x00C6E0AB
		protected override void OnAfterHide()
		{
			PlotController.Instance.RemoveTick(this.TickId);
		}

		// Token: 0x06034A28 RID: 215592 RVA: 0x00C6FEBD File Offset: 0x00C6E0BD
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.Texture = null;
			this.Name = null;
			this.Intro = null;
			this.CurTime = 0f;
			this.TickId = 0;
		}

		// Token: 0x06034A29 RID: 215593 RVA: 0x00C6FEF8 File Offset: 0x00C6E0F8
		private void ShowVideoCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
			base.GetText(0).ShowTextNew(string.IsNullOrEmpty(this.Name) ? "" : this.Name);
			UUITexture texture = base.GetTexture(1);
			UUINiagara uiNiagara = base.GetUiNiagara(8);
			texture.SetTexture(this.Texture);
			uiNiagara.SetNiagaraEmitterCustomTexture("head_portrait_01", "Mask", this.Texture);
			uiNiagara.SetNiagaraEmitterCustomTexture("head_portrait_02", "Mask", this.Texture);
			uiNiagara.SetNiagaraEmitterCustomTexture("head_portrait_03", "Mask", this.Texture);
			uiNiagara.SetNiagaraVarFloat("Size X", texture.Width);
			uiNiagara.SetNiagaraVarFloat("Size Y", texture.Height);
		}

		// Token: 0x06034A2A RID: 215594 RVA: 0x00C6FFE0 File Offset: 0x00C6E1E0
		private void ShowAudioCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(5).SetUIActive(true);
			base.GetText(0).ShowTextNew(string.IsNullOrEmpty(this.Name) ? "" : this.Name);
		}

		// Token: 0x06034A2B RID: 215595 RVA: 0x00C7003B File Offset: 0x00C6E23B
		private void ShowInterferenceCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(6).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x06034A2C RID: 215596 RVA: 0x00C70065 File Offset: 0x00C6E265
		private void ShowEmergencyCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x06034A2D RID: 215597 RVA: 0x00C70090 File Offset: 0x00C6E290
		private void ShowMonsterDispalyCall()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetTexture(11).SetTexture(this.Texture);
			UUINiagara uiNiagara = base.GetUiNiagara(12);
			uiNiagara.SetNiagaraEmitterCustomTexture("Frame001", "BaseTexture", this.Texture);
			uiNiagara.SetNiagaraEmitterCustomTexture("Frame001", "BackgroundTexture", this.Texture);
			base.GetText(13).ShowTextNew(string.IsNullOrEmpty(this.Name) ? "" : this.Name);
			base.GetText(14).ShowTextNew(string.IsNullOrEmpty(this.Intro) ? "" : this.Intro);
		}

		// Token: 0x06034A2E RID: 215598 RVA: 0x00C70140 File Offset: 0x00C6E340
		private void HideAll()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x06034A2F RID: 215599 RVA: 0x00C701B8 File Offset: 0x00C6E3B8
		public void OnTick(float delta)
		{
			if (!this.CanRefresh())
			{
				return;
			}
			this.CurTime += delta;
			if (this.CurTime < this.TargetRefreshInterval)
			{
				return;
			}
			this.CurTime = 0f;
			this.RefreshTargetParams();
			this.RefreshAnchorOffset(delta);
			this.RefreshScale();
			this.RefreshWaveMatParams();
		}

		// Token: 0x06034A30 RID: 215600 RVA: 0x00C70210 File Offset: 0x00C6E410
		private void RefreshTargetParams()
		{
			FVectorDouble fvectorDouble = Global.BaseCharacter.D_K2_GetActorLocation();
			FVector fvector = fvectorDouble;
			FVector2D fvector2D = new FVector2D();
			APlayerController characterController = Global.CharacterController;
			fvectorDouble = fvector;
			UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref fvector2D, true);
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			this.TargetOffset = canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
			this.TargetOffset.Y = UiLayer.Instance.UiRootItem.Height / 2f;
			Vector cameraLocation = CameraModel.Instance.MainModel.CameraLocation;
			if (cameraLocation == null)
			{
				return;
			}
			double num = Math.Pow(cameraLocation.X - (double)fvector.X, 2.0) + Math.Pow(cameraLocation.Y - (double)fvector.Y, 2.0) + Math.Pow(cameraLocation.Z - (double)fvector.Z, 2.0);
			num = (double)((float)Math.Sqrt(num));
			if (num < 100.0)
			{
				this.TargetOffset.X = this.TargetOffset.X - (100f - (float)num) * 4f;
				return;
			}
			if (num > 350.0)
			{
				this.TargetOffset.X = this.TargetOffset.X + ((float)num - 350f) * 0.3f;
				float inF = MathUtils.Instance.Clamp(1f - ((float)num - 350f) * 0.002f, 0.5f, 1f);
				this.TargetScale = new FVector?(new FVector(inF));
			}
		}

		// Token: 0x06034A31 RID: 215601 RVA: 0x00C7039C File Offset: 0x00C6E59C
		private void RefreshAnchorOffset(float delta)
		{
			FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
			float alpha = MathUtils.Instance.Clamp(delta * 0.01f, 0f, 1f);
			float anchorOffsetX = MathUtils.Instance.Lerp(anchorOffset.X, this.TargetOffset.X, alpha);
			float anchorOffsetY = MathUtils.Instance.Lerp(anchorOffset.Y, this.TargetOffset.Y, alpha);
			this.RootItem.SetAnchorOffsetX(anchorOffsetX);
			this.RootItem.SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x06034A32 RID: 215602 RVA: 0x00C70423 File Offset: 0x00C6E623
		private void RefreshScale()
		{
			if (this.TargetScale != null)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetUIItemScale(this.TargetScale.GetValueOrDefault());
			}
		}

		// Token: 0x06034A33 RID: 215603 RVA: 0x00C70450 File Offset: 0x00C6E650
		private void RefreshWaveMatParams()
		{
		}

		// Token: 0x06034A34 RID: 215604 RVA: 0x00C7045D File Offset: 0x00C6E65D
		private bool CanRefresh()
		{
			return this.IsShowingPlotPortraitItem && base.GetActive() && Global.BaseCharacter != null;
		}

		// Token: 0x0401C0C4 RID: 114884
		private const float VELOCITY_FOLLOW = 0.01f;

		// Token: 0x0401C0C5 RID: 114885
		private const float ARM_LENGTH_MIN = 100f;

		// Token: 0x0401C0C6 RID: 114886
		private const float ARM_LENGTH_MAX = 350f;

		// Token: 0x0401C0C7 RID: 114887
		private const float HORI_DEC_RATIO = 4f;

		// Token: 0x0401C0C8 RID: 114888
		private const float HORI_INC_RATIO = 0.3f;

		// Token: 0x0401C0C9 RID: 114889
		private const float SCALE_RATIO = 0.002f;

		// Token: 0x0401C0CA RID: 114890
		private const float VO_RTPC_VALUE_MIN = -48f;

		// Token: 0x0401C0CB RID: 114891
		private const float VO_RTPC_VALUE_MAX = 0f;

		// Token: 0x0401C0CC RID: 114892
		private const string AUDIO_GROUP_NAME = "phone_call";

		// Token: 0x0401C0CD RID: 114893
		[Nullable(2)]
		private IHeadStyle OwnedSetHeadIcon;

		// Token: 0x0401C0CE RID: 114894
		private int TickId;

		// Token: 0x0401C0CF RID: 114895
		private FVector2D TargetOffset;

		// Token: 0x0401C0D0 RID: 114896
		private FVector? TargetScale;

		// Token: 0x0401C0D1 RID: 114897
		private readonly float TargetRefreshInterval;

		// Token: 0x0401C0D2 RID: 114898
		private float CurTime;

		// Token: 0x0401C0D3 RID: 114899
		private FVector4 MatParam;

		// Token: 0x0401C0D4 RID: 114900
		private float VoRtpcValue;

		// Token: 0x0401C0D5 RID: 114901
		private bool IsShowingPlotPortraitItem;

		// Token: 0x0401C0D6 RID: 114902
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401C0D7 RID: 114903
		private readonly PlayResult AudioPlayResult = new PlayResult();

		// Token: 0x0401C0D8 RID: 114904
		[Nullable(2)]
		private UTexture Texture;

		// Token: 0x0401C0D9 RID: 114905
		[Nullable(2)]
		private string Name;

		// Token: 0x0401C0DA RID: 114906
		[Nullable(2)]
		private string Intro;

		// Token: 0x0401C0DB RID: 114907
		private readonly Dictionary<EHeadStyle, string> AudioSwitchMap = new Dictionary<EHeadStyle, string>
		{
			{
				EHeadStyle.Normal,
				"call_01"
			},
			{
				EHeadStyle.VoiceOnly,
				"call_02"
			},
			{
				EHeadStyle.WeakSignal,
				"call_03"
			},
			{
				EHeadStyle.Warning,
				"call_04"
			}
		};

		// Token: 0x0401C0DC RID: 114908
		private readonly Dictionary<EHeadStyle, string> SequenceMap = new Dictionary<EHeadStyle, string>
		{
			{
				EHeadStyle.Normal,
				"Start01"
			},
			{
				EHeadStyle.VoiceOnly,
				"Start01"
			},
			{
				EHeadStyle.WeakSignal,
				"Start02"
			},
			{
				EHeadStyle.Warning,
				"Start03"
			}
		};

		// Token: 0x0200B1B5 RID: 45493
		[NullableContext(0)]
		private static class EPlotPortraitItem
		{
			// Token: 0x04035E49 RID: 220745
			public const int Name = 0;

			// Token: 0x04035E4A RID: 220746
			public const int HeadIcon = 1;

			// Token: 0x04035E4B RID: 220747
			public const int Frame = 2;

			// Token: 0x04035E4C RID: 220748
			public const int NormalCall = 3;

			// Token: 0x04035E4D RID: 220749
			public const int VideoCall = 4;

			// Token: 0x04035E4E RID: 220750
			public const int AudioCall = 5;

			// Token: 0x04035E4F RID: 220751
			public const int InterferenceCall = 6;

			// Token: 0x04035E50 RID: 220752
			public const int EmergencyCall = 7;

			// Token: 0x04035E51 RID: 220753
			public const int HeadIconNiagara = 8;

			// Token: 0x04035E52 RID: 220754
			public const int MonsterDisplayCall = 9;

			// Token: 0x04035E53 RID: 220755
			public const int CommonBg = 10;

			// Token: 0x04035E54 RID: 220756
			public const int MonsterDisplayTexture = 11;

			// Token: 0x04035E55 RID: 220757
			public const int MonsterIconNiagara = 12;

			// Token: 0x04035E56 RID: 220758
			public const int MonsterName = 13;

			// Token: 0x04035E57 RID: 220759
			public const int MonsterIntroduce = 14;

			// Token: 0x04035E58 RID: 220760
			public const int AudioCallLine = 15;
		}
	}
}
