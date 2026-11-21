using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Module.Infrastructure;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039A3 RID: 14755
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraTargetTypeUiInfrastructure : UiCameraTargetType
	{
		// Token: 0x0602600E RID: 155662 RVA: 0x00AAAA65 File Offset: 0x00AA8C65
		public UiCameraTargetTypeUiInfrastructure() : base(EUiCameraAnimationTargetType.UiInfrastructure)
		{
		}

		// Token: 0x0602600F RID: 155663 RVA: 0x00AAAA6F File Offset: 0x00AA8C6F
		[return: Nullable(2)]
		protected override AActor GetTargetActor(SUiCameraAnimationSettings settings)
		{
			return null;
		}

		// Token: 0x06026010 RID: 155664 RVA: 0x00AAAA72 File Offset: 0x00AA8C72
		[return: Nullable(2)]
		protected override USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings)
		{
			return null;
		}

		// Token: 0x06026011 RID: 155665 RVA: 0x00AAAA78 File Offset: 0x00AA8C78
		[NullableContext(2)]
		protected override string GetTargetBodyKey()
		{
			if (InfrastructureConfig.Instance.GetRoadConfigById(InfrastructureModel.Instance.InteractingRoadId) == null)
			{
				return null;
			}
			InfrRoadBuild? infrRoadBuild;
			return infrRoadBuild.GetValueOrDefault().BodyCameraSettingsName;
		}
	}
}
