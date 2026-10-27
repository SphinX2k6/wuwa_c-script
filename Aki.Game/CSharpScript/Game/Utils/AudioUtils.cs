using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004547 RID: 17735
	[NullableContext(1)]
	[Nullable(0)]
	public class AudioUtils : Singleton
	{
		// Token: 0x0602DD65 RID: 187749 RVA: 0x00A89848 File Offset: 0x00A87A48
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

		// Token: 0x0602DD66 RID: 187750 RVA: 0x00A89894 File Offset: 0x00A87A94
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

		// Token: 0x1700754F RID: 30031
		// (get) Token: 0x0602DD67 RID: 187751 RVA: 0x00A89A0E File Offset: 0x00A87C0E
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

		// Token: 0x0602DD68 RID: 187752 RVA: 0x00A89A31 File Offset: 0x00A87C31
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DD69 RID: 187753 RVA: 0x00A89A33 File Offset: 0x00A87C33
		public static void ResetStaticDefaultValue()
		{
			AudioUtils instance = AudioUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			AudioUtils._instance = null;
		}

		// Token: 0x0602DD6A RID: 187754 RVA: 0x00A89A4C File Offset: 0x00A87C4C
		static AudioUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioUtils.CreateStaticDefaultValue), new Action(AudioUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0401878A RID: 100234
		private const string AUDIO_TAG_PREFIX = "Audio_";

		// Token: 0x0401878B RID: 100235
		[Nullable(2)]
		private static AudioUtils _instance;
	}
}
