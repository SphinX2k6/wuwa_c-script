using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.World.Define;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006461 RID: 25697
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceCamera : Entity
	{
		// Token: 0x0603E6C3 RID: 255683 RVA: 0x01226F8E File Offset: 0x0122518E
		public SequenceCamera(int id, int index) : base(id, index)
		{
		}

		// Token: 0x0603E6C4 RID: 255684 RVA: 0x01226FA3 File Offset: 0x012251A3
		[NullableContext(1)]
		protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
		{
			return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTick2Config);
		}

		// Token: 0x170076CF RID: 30415
		// (get) Token: 0x0603E6C5 RID: 255685 RVA: 0x01226FB4 File Offset: 0x012251B4
		// (set) Token: 0x0603E6C6 RID: 255686 RVA: 0x01226FBC File Offset: 0x012251BC
		public SequenceCameraDisplayComponent DisplayComponent { get; private set; }

		// Token: 0x170076D0 RID: 30416
		// (get) Token: 0x0603E6C7 RID: 255687 RVA: 0x01226FC5 File Offset: 0x012251C5
		// (set) Token: 0x0603E6C8 RID: 255688 RVA: 0x01226FCD File Offset: 0x012251CD
		public SequenceCameraPlayerComponent PlayerComponent { get; private set; }

		// Token: 0x0603E6C9 RID: 255689 RVA: 0x01226FD6 File Offset: 0x012251D6
		public void SetPlayCameraSequenceEnabled(bool enabled)
		{
			SequenceCameraPlayerComponent playerComponent = this.PlayerComponent;
			if (playerComponent == null)
			{
				return;
			}
			playerComponent.SetPlayCameraSequenceEnabled(enabled);
		}

		// Token: 0x0603E6CA RID: 255690 RVA: 0x01226FE9 File Offset: 0x012251E9
		public void SetSeparateSequencePlayerLogicEnabled(bool enabled)
		{
			SequenceCameraPlayerComponent playerComponent = this.PlayerComponent;
			if (playerComponent == null)
			{
				return;
			}
			playerComponent.SetSeparateSequencePlayerLogicEnabled(enabled);
		}

		// Token: 0x0603E6CB RID: 255691 RVA: 0x01226FFC File Offset: 0x012251FC
		[NullableContext(1)]
		public unsafe void RegisterLevelSequenceActor(ALevelSequenceActor levelSequenceActor)
		{
			if (levelSequenceActor == null || !levelSequenceActor.IsValid())
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.ZJL, "拒绝注册无效的主屏LevelSequenceActor", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.LevelSequenceActorInternal == levelSequenceActor)
			{
				return;
			}
			AKuroSplitScreenPreviewController.RequestRuntimeTakeover("主屏LevelSequenceActor注册接管");
			if (this.LevelSequenceActorInternal != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "主屏SequenceCamera注册被新的LevelSequenceActor覆盖";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("oldActor", SequenceCamera.GetActorName(this.LevelSequenceActorInternal));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newActor", SequenceCamera.GetActorName(levelSequenceActor));
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ReleaseSeparateCameraSession(this.LevelSequenceActorInternal);
			}
			this.LevelSequenceActorInternal = levelSequenceActor;
		}

		// Token: 0x0603E6CC RID: 255692 RVA: 0x012270C2 File Offset: 0x012252C2
		[NullableContext(1)]
		public void UnregisterLevelSequenceActor(ALevelSequenceActor levelSequenceActor)
		{
			if (this.LevelSequenceActorInternal != levelSequenceActor)
			{
				return;
			}
			this.ReleaseSeparateCameraSession(levelSequenceActor);
			this.LevelSequenceActorInternal = null;
		}

		// Token: 0x0603E6CD RID: 255693 RVA: 0x012270DC File Offset: 0x012252DC
		public ALevelSequenceActor GetLevelSequenceActor()
		{
			ALevelSequenceActor levelSequenceActorInternal = this.LevelSequenceActorInternal;
			if (levelSequenceActorInternal == null || !levelSequenceActorInternal.IsValid())
			{
				return null;
			}
			return this.LevelSequenceActorInternal;
		}

		// Token: 0x0603E6CE RID: 255694 RVA: 0x012270FC File Offset: 0x012252FC
		public bool HasSeparateCameraTagBinding(FName sequenceCameraTag)
		{
			using (Dictionary<string, SequenceSeparateCameraBinding>.ValueCollection.Enumerator enumerator = this.SeparateCameraBindings.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.SequenceCameraTag == sequenceCameraTag)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603E6CF RID: 255695 RVA: 0x01227160 File Offset: 0x01225360
		[NullableContext(1)]
		public void RegisterSeparateCameraBinding(string cameraName, FName sequenceCameraTag, BP_CineCamera_C cineCamera, CameraModelInstance cameraModel)
		{
			this.SeparateCameraBindings[cameraName] = new SequenceSeparateCameraBinding(sequenceCameraTag, cineCamera, cameraModel);
		}

		// Token: 0x0603E6D0 RID: 255696 RVA: 0x01227178 File Offset: 0x01225378
		[NullableContext(1)]
		public void RemoveSeparateCameraBinding(string cameraName)
		{
			SequenceSeparateCameraBinding sequenceSeparateCameraBinding;
			this.SeparateCameraBindings.TryGetValue(cameraName, out sequenceSeparateCameraBinding);
			ALevelSequenceActor levelSequenceActorInternal = this.LevelSequenceActorInternal;
			this.SeparateCameraBindings.Remove(cameraName);
			if (sequenceSeparateCameraBinding != null && levelSequenceActorInternal != null && levelSequenceActorInternal.IsValid())
			{
				BP_CineCamera_C cineCamera = sequenceSeparateCameraBinding.CineCamera;
				if (cineCamera != null && cineCamera.IsValid())
				{
					levelSequenceActorInternal.RemoveBindingByTag(sequenceSeparateCameraBinding.SequenceCameraTag, sequenceSeparateCameraBinding.CineCamera, true);
				}
			}
		}

		// Token: 0x0603E6D1 RID: 255697 RVA: 0x012271DD File Offset: 0x012253DD
		public void MarkMainCameraLayoutOverridden()
		{
			this.IsMainCameraLayoutOverridden = true;
		}

		// Token: 0x0603E6D2 RID: 255698 RVA: 0x012271E6 File Offset: 0x012253E6
		public void ClearMainCameraLayoutOverride()
		{
			this.IsMainCameraLayoutOverridden = false;
		}

		// Token: 0x0603E6D3 RID: 255699 RVA: 0x012271EF File Offset: 0x012253EF
		[NullableContext(1)]
		private static string GetActorName(ALevelSequenceActor levelSequenceActor)
		{
			if (!levelSequenceActor.IsValid())
			{
				return "InvalidActor";
			}
			return levelSequenceActor.GetName();
		}

		// Token: 0x0603E6D4 RID: 255700 RVA: 0x01227208 File Offset: 0x01225408
		private void ReleaseSeparateCameraSession(ALevelSequenceActor levelSequenceActor)
		{
			Dictionary<string, SequenceSeparateCameraBinding> dictionary = new Dictionary<string, SequenceSeparateCameraBinding>(this.SeparateCameraBindings);
			bool isMainCameraLayoutOverridden = this.IsMainCameraLayoutOverridden;
			this.SeparateCameraBindings.Clear();
			this.IsMainCameraLayoutOverridden = false;
			foreach (KeyValuePair<string, SequenceSeparateCameraBinding> keyValuePair in dictionary)
			{
				string text;
				SequenceSeparateCameraBinding sequenceSeparateCameraBinding;
				keyValuePair.Deconstruct(out text, out sequenceSeparateCameraBinding);
				string cameraName = text;
				SequenceSeparateCameraBinding sequenceSeparateCameraBinding2 = sequenceSeparateCameraBinding;
				if (levelSequenceActor != null && levelSequenceActor.IsValid() && sequenceSeparateCameraBinding2.CineCamera.IsValid())
				{
					levelSequenceActor.RemoveBindingByTag(sequenceSeparateCameraBinding2.SequenceCameraTag, sequenceSeparateCameraBinding2.CineCamera, true);
				}
				sequenceSeparateCameraBinding2.CameraModel.ReleaseOwnedSequenceSeparateCamera(cameraName);
			}
			if (isMainCameraLayoutOverridden)
			{
				CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
				if (cameraModelInstanceInternal == null)
				{
					return;
				}
				cameraModelInstanceInternal.ResetMainCameraLayout();
			}
		}

		// Token: 0x0603E6D5 RID: 255701 RVA: 0x012272D0 File Offset: 0x012254D0
		protected override bool OnCreate(IEntityArgs args = null)
		{
			CameraModelInstance cameraModelInstance = (args != null) ? args.GetP1<CameraModelInstance>() : null;
			if (cameraModelInstance == null)
			{
				Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "Invalid CameraModelInstance on Create SequenceCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.CameraModelInstanceInternal = cameraModelInstance;
			if (!base.AddComponent<SequenceCameraDisplayComponent>(null, args))
			{
				return false;
			}
			if (!base.AddComponent<SequenceCameraPlayerComponent>(null, args))
			{
				return false;
			}
			base.RegisterToGameBudgetController(null);
			return true;
		}

		// Token: 0x0603E6D6 RID: 255702 RVA: 0x01227350 File Offset: 0x01225550
		protected override bool OnStart()
		{
			this.DisplayComponent = base.GetComponent<SequenceCameraDisplayComponent>();
			this.PlayerComponent = base.GetComponent<SequenceCameraPlayerComponent>();
			return true;
		}

		// Token: 0x0603E6D7 RID: 255703 RVA: 0x0122736B File Offset: 0x0122556B
		protected override bool OnClear()
		{
			this.ReleaseSeparateCameraSession(this.LevelSequenceActorInternal);
			this.LevelSequenceActorInternal = null;
			this.CameraModelInstanceInternal = null;
			this.DisplayComponent = null;
			this.PlayerComponent = null;
			return true;
		}

		// Token: 0x0402144C RID: 136268
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x0402144D RID: 136269
		private ALevelSequenceActor LevelSequenceActorInternal;

		// Token: 0x0402144E RID: 136270
		[Nullable(1)]
		private readonly Dictionary<string, SequenceSeparateCameraBinding> SeparateCameraBindings = new Dictionary<string, SequenceSeparateCameraBinding>();

		// Token: 0x0402144F RID: 136271
		private bool IsMainCameraLayoutOverridden;
	}
}
