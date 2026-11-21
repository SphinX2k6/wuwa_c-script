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
	// Token: 0x02004028 RID: 16424
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotPortraitItem : UiPanelBase
	{
		// Token: 0x06029911 RID: 170257 RVA: 0x00BBCCDC File Offset: 0x00BBAEDC
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

		// Token: 0x06029912 RID: 170258 RVA: 0x00BBCF1C File Offset: 0x00BBB11C
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

		// Token: 0x06029913 RID: 170259 RVA: 0x00BBCF70 File Offset: 0x00BBB170
		public UniTask CloseAsync()
		{
			PlotPortraitItem.<CloseAsync>d__28 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<PlotPortraitItem.<CloseAsync>d__28>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029914 RID: 170260 RVA: 0x00BBCFB4 File Offset: 0x00BBB1B4
		public UniTask SwitchAsync(IHeadStyle param)
		{
			PlotPortraitItem.<SwitchAsync>d__29 <SwitchAsync>d__;
			<SwitchAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchAsync>d__.<>1__state = -1;
			<SwitchAsync>d__.<>t__builder.Start<PlotPortraitItem.<SwitchAsync>d__29>(ref <SwitchAsync>d__);
			return <SwitchAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029915 RID: 170261 RVA: 0x00BBCFF0 File Offset: 0x00BBB1F0
		protected override UniTask OnCreateAsync()
		{
			PlotPortraitItem.<OnCreateAsync>d__30 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotPortraitItem.<OnCreateAsync>d__30>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029916 RID: 170262 RVA: 0x00BBD033 File Offset: 0x00BBB233
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06029917 RID: 170263 RVA: 0x00BBD048 File Offset: 0x00BBB248
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

		// Token: 0x06029918 RID: 170264 RVA: 0x00BBD0C4 File Offset: 0x00BBB2C4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PlotPortraitItem.<OnShowAsyncImplementImplement>d__33 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PlotPortraitItem.<OnShowAsyncImplementImplement>d__33>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06029919 RID: 170265 RVA: 0x00BBD108 File Offset: 0x00BBB308
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PlotPortraitItem.<OnHideAsyncImplementImplement>d__34 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PlotPortraitItem.<OnHideAsyncImplementImplement>d__34>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602991A RID: 170266 RVA: 0x00BBD14B File Offset: 0x00BBB34B
		protected override void OnAfterHide()
		{
			PlotController.Instance.RemoveTick(this.TickId);
		}

		// Token: 0x0602991B RID: 170267 RVA: 0x00BBD15D File Offset: 0x00BBB35D
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

		// Token: 0x0602991C RID: 170268 RVA: 0x00BBD198 File Offset: 0x00BBB398
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

		// Token: 0x0602991D RID: 170269 RVA: 0x00BBD280 File Offset: 0x00BBB480
		private void ShowAudioCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(5).SetUIActive(true);
			base.GetText(0).ShowTextNew(string.IsNullOrEmpty(this.Name) ? "" : this.Name);
		}

		// Token: 0x0602991E RID: 170270 RVA: 0x00BBD2DB File Offset: 0x00BBB4DB
		private void ShowInterferenceCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(6).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x0602991F RID: 170271 RVA: 0x00BBD305 File Offset: 0x00BBB505
		private void ShowEmergencyCall()
		{
			base.GetItem(10).SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x06029920 RID: 170272 RVA: 0x00BBD330 File Offset: 0x00BBB530
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

		// Token: 0x06029921 RID: 170273 RVA: 0x00BBD3E0 File Offset: 0x00BBB5E0
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

		// Token: 0x06029922 RID: 170274 RVA: 0x00BBD458 File Offset: 0x00BBB658
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

		// Token: 0x06029923 RID: 170275 RVA: 0x00BBD4B0 File Offset: 0x00BBB6B0
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

		// Token: 0x06029924 RID: 170276 RVA: 0x00BBD63C File Offset: 0x00BBB83C
		private void RefreshAnchorOffset(float delta)
		{
			FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
			float alpha = MathUtils.Instance.Clamp(delta * 0.01f, 0f, 1f);
			float anchorOffsetX = MathUtils.Instance.Lerp(anchorOffset.X, this.TargetOffset.X, alpha);
			float anchorOffsetY = MathUtils.Instance.Lerp(anchorOffset.Y, this.TargetOffset.Y, alpha);
			this.RootItem.SetAnchorOffsetX(anchorOffsetX);
			this.RootItem.SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x06029925 RID: 170277 RVA: 0x00BBD6C3 File Offset: 0x00BBB8C3
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

		// Token: 0x06029926 RID: 170278 RVA: 0x00BBD6F0 File Offset: 0x00BBB8F0
		private void RefreshWaveMatParams()
		{
		}

		// Token: 0x06029927 RID: 170279 RVA: 0x00BBD6FD File Offset: 0x00BBB8FD
		private bool CanRefresh()
		{
			return this.IsShowingPlotPortraitItem && base.GetActive() && Global.BaseCharacter != null;
		}

		// Token: 0x04016AEF RID: 92911
		private const float VELOCITY_FOLLOW = 0.01f;

		// Token: 0x04016AF0 RID: 92912
		private const float ARM_LENGTH_MIN = 100f;

		// Token: 0x04016AF1 RID: 92913
		private const float ARM_LENGTH_MAX = 350f;

		// Token: 0x04016AF2 RID: 92914
		private const float HORI_DEC_RATIO = 4f;

		// Token: 0x04016AF3 RID: 92915
		private const float HORI_INC_RATIO = 0.3f;

		// Token: 0x04016AF4 RID: 92916
		private const float SCALE_RATIO = 0.002f;

		// Token: 0x04016AF5 RID: 92917
		private const float VO_RTPC_VALUE_MIN = -48f;

		// Token: 0x04016AF6 RID: 92918
		private const float VO_RTPC_VALUE_MAX = 0f;

		// Token: 0x04016AF7 RID: 92919
		private const string AUDIO_GROUP_NAME = "phone_call";

		// Token: 0x04016AF8 RID: 92920
		[Nullable(2)]
		private IHeadStyle OwnedSetHeadIcon;

		// Token: 0x04016AF9 RID: 92921
		private int TickId;

		// Token: 0x04016AFA RID: 92922
		private FVector2D TargetOffset;

		// Token: 0x04016AFB RID: 92923
		private FVector? TargetScale;

		// Token: 0x04016AFC RID: 92924
		private readonly float TargetRefreshInterval;

		// Token: 0x04016AFD RID: 92925
		private float CurTime;

		// Token: 0x04016AFE RID: 92926
		private FVector4 MatParam;

		// Token: 0x04016AFF RID: 92927
		private float VoRtpcValue;

		// Token: 0x04016B00 RID: 92928
		private bool IsShowingPlotPortraitItem;

		// Token: 0x04016B01 RID: 92929
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04016B02 RID: 92930
		private readonly PlayResult AudioPlayResult = new PlayResult();

		// Token: 0x04016B03 RID: 92931
		[Nullable(2)]
		private UTexture Texture;

		// Token: 0x04016B04 RID: 92932
		[Nullable(2)]
		private string Name;

		// Token: 0x04016B05 RID: 92933
		[Nullable(2)]
		private string Intro;

		// Token: 0x04016B06 RID: 92934
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

		// Token: 0x04016B07 RID: 92935
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

		// Token: 0x02009BEF RID: 39919
		[NullableContext(0)]
		private static class EPlotPortraitItem
		{
			// Token: 0x0403089E RID: 198814
			public const int Name = 0;

			// Token: 0x0403089F RID: 198815
			public const int HeadIcon = 1;

			// Token: 0x040308A0 RID: 198816
			public const int Frame = 2;

			// Token: 0x040308A1 RID: 198817
			public const int NormalCall = 3;

			// Token: 0x040308A2 RID: 198818
			public const int VideoCall = 4;

			// Token: 0x040308A3 RID: 198819
			public const int AudioCall = 5;

			// Token: 0x040308A4 RID: 198820
			public const int InterferenceCall = 6;

			// Token: 0x040308A5 RID: 198821
			public const int EmergencyCall = 7;

			// Token: 0x040308A6 RID: 198822
			public const int HeadIconNiagara = 8;

			// Token: 0x040308A7 RID: 198823
			public const int MonsterDisplayCall = 9;

			// Token: 0x040308A8 RID: 198824
			public const int CommonBg = 10;

			// Token: 0x040308A9 RID: 198825
			public const int MonsterDisplayTexture = 11;

			// Token: 0x040308AA RID: 198826
			public const int MonsterIconNiagara = 12;

			// Token: 0x040308AB RID: 198827
			public const int MonsterName = 13;

			// Token: 0x040308AC RID: 198828
			public const int MonsterIntroduce = 14;

			// Token: 0x040308AD RID: 198829
			public const int AudioCallLine = 15;
		}
	}
}
