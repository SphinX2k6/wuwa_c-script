using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399E RID: 14750
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class UiCameraTargetType
	{
		// Token: 0x06025FEF RID: 155631 RVA: 0x00AAA6C7 File Offset: 0x00AA88C7
		protected UiCameraTargetType(EUiCameraAnimationTargetType targetType)
		{
			this.TargetType = targetType;
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x06025FF0 RID: 155632 RVA: 0x00AAA6D6 File Offset: 0x00AA88D6
		public EUiCameraAnimationTargetType TargetType { get; }

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x06025FF1 RID: 155633 RVA: 0x00AAA6DE File Offset: 0x00AA88DE
		// (set) Token: 0x06025FF2 RID: 155634 RVA: 0x00AAA6E6 File Offset: 0x00AA88E6
		public AActor Actor { get; private set; }

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x06025FF3 RID: 155635 RVA: 0x00AAA6EF File Offset: 0x00AA88EF
		// (set) Token: 0x06025FF4 RID: 155636 RVA: 0x00AAA6F7 File Offset: 0x00AA88F7
		public USkeletalMeshComponent SkeletalMesh { get; private set; }

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x06025FF5 RID: 155637 RVA: 0x00AAA700 File Offset: 0x00AA8900
		// (set) Token: 0x06025FF6 RID: 155638 RVA: 0x00AAA708 File Offset: 0x00AA8908
		public string BodyKey { get; private set; }

		// Token: 0x06025FF7 RID: 155639 RVA: 0x00AAA711 File Offset: 0x00AA8911
		[NullableContext(1)]
		public void Refresh(SUiCameraAnimationSettings settings)
		{
			this.Actor = this.GetTargetActor(settings);
			this.SkeletalMesh = this.GetTargetSkeletalMesh(settings);
			this.BodyKey = this.GetTargetBodyKey();
		}

		// Token: 0x06025FF8 RID: 155640 RVA: 0x00AAA739 File Offset: 0x00AA8939
		public string RefreshBodyKey()
		{
			this.BodyKey = this.GetTargetBodyKey();
			return this.BodyKey;
		}

		// Token: 0x06025FF9 RID: 155641
		[NullableContext(1)]
		[return: Nullable(2)]
		protected abstract AActor GetTargetActor(SUiCameraAnimationSettings settings);

		// Token: 0x06025FFA RID: 155642
		[NullableContext(1)]
		[return: Nullable(2)]
		protected abstract USkeletalMeshComponent GetTargetSkeletalMesh(SUiCameraAnimationSettings settings);

		// Token: 0x06025FFB RID: 155643
		protected abstract string GetTargetBodyKey();
	}
}
