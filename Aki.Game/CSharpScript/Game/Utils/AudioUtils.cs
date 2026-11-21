using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200346F RID: 13423
	[NullableContext(1)]
	[Nullable(0)]
	public class AudioUtils : Singleton
	{
		// Token: 0x06022447 RID: 140359 RVA: 0x009B4F7C File Offset: 0x009B317C
		public void HandleAudioBoxUpdate(AudioBox box, EAudioUpdateType type)
		{
			AudioBox audioBox = AudioModel.Instance.UpdateAudioBoxQueue(box, type);
			if (audioBox == null)
			{
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(audioBox.PbDataId);
			if (entityByPbDataId == null)
			{
				return;
			}
			SceneItemStateAudioComponent component = entityByPbDataId.Entity.GetComponent<SceneItemStateAudioComponent>();
			if (component == null)
			{
				return;
			}
			component.PostAudioBoxEvent();
		}

		// Token: 0x06022448 RID: 140360 RVA: 0x009B4FC8 File Offset: 0x009B31C8
		public FoliageAudioInfo QueryFoliageAudioPhysicalMaterial(FVectorDouble location, [Nullable(2)] Entity entity = null)
		{
			FoliageAudioInfo foliageAudioInfo = new FoliageAudioInfo();
			UKuroAudioMaterialSubsystem ukuroAudioMaterialSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroAudioMaterialSubsystem.StaticClass()) as UKuroAudioMaterialSubsystem;
			FName none = FNameUtil.NONE;
			UPhysicalMaterial physicalMaterial = null;
			UStaticMeshComponent ustaticMeshComponent = null;
			foliageAudioInfo.IsHitFoliage = ukuroAudioMaterialSubsystem.QueryInsideAnyFoliageInstance(location, ref none, ref physicalMaterial, ref ustaticMeshComponent);
			UStaticMeshComponent ustaticMeshComponent2 = ustaticMeshComponent;
			if (ustaticMeshComponent2 != null && ustaticMeshComponent2.IsValid())
			{
				if (!ustaticMeshComponent2.bHiddenInGame)
				{
					AActor owner = ustaticMeshComponent2.GetOwner();
					if (owner == null || !owner.bHidden)
					{
						goto IL_76;
					}
				}
				foliageAudioInfo.IsHitFoliage = false;
				return foliageAudioInfo;
			}
			IL_76:
			foliageAudioInfo.FoliageName = none;
			foliageAudioInfo.PhysicalMaterial = physicalMaterial;
			string text = none.ToString();
			if (text.Contains("_Shr_") || text.Contains("_Veg_"))
			{
				foliageAudioInfo.IsAudioShrub = true;
			}
			if (ustaticMeshComponent2 != null && ustaticMeshComponent2.IsValid())
			{
				UStaticMesh staticMesh = ustaticMeshComponent2.StaticMesh;
				if (staticMesh != null && staticMesh.IsValid())
				{
					for (int i = 0; i < ustaticMeshComponent2.StaticMesh.Tags.Num(); i++)
					{
						string text2 = ustaticMeshComponent2.StaticMesh.Tags.Get(i).ToString();
						if (text2.StartsWith("Audio_"))
						{
							foliageAudioInfo.AudioShrubTag = new FName(text2.Substring("Audio_".Length));
						}
					}
				}
			}
			if (entity != null)
			{
				RoleAudioComponent component = entity.GetComponent<RoleAudioComponent>();
				if (component != null)
				{
					component.UpdateIsInAudioShrubEvent(foliageAudioInfo.IsAudioShrub, foliageAudioInfo.AudioShrubTag);
				}
			}
			return foliageAudioInfo;
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x06022449 RID: 140361 RVA: 0x009B5142 File Offset: 0x009B3342
		public static AudioUtils Instance
		{
			get
			{
				if (AudioUtils._instance == null)
				{
					AudioUtils._instance = new AudioUtils();
					AudioUtils._instance.OnInit();
				}
				return AudioUtils._instance;
			}
		}

		// Token: 0x0602244A RID: 140362 RVA: 0x009B5165 File Offset: 0x009B3365
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602244B RID: 140363 RVA: 0x009B5167 File Offset: 0x009B3367
		public static void ResetStaticDefaultValue()
		{
			AudioUtils instance = AudioUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			AudioUtils._instance = null;
		}

		// Token: 0x0602244C RID: 140364 RVA: 0x009B5180 File Offset: 0x009B3380
		static AudioUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioUtils.CreateStaticDefaultValue), new Action(AudioUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04012DC4 RID: 77252
		private const string AUDIO_TAG_PREFIX = "Audio_";

		// Token: 0x04012DC5 RID: 77253
		[Nullable(2)]
		private static AudioUtils _instance;
	}
}
