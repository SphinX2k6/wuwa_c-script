using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B6E RID: 19310
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ITeleportContextParam : ITeleportContext
	{
		// Token: 0x17007BF0 RID: 31728
		// (get) Token: 0x0603200B RID: 204811 RVA: 0x00B9BF3C File Offset: 0x00B9A13C
		// (set) Token: 0x0603200C RID: 204812 RVA: 0x00B9BF44 File Offset: 0x00B9A144
		[Nullable(1)]
		[RequiredMember]
		public string ClientReason { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007BF1 RID: 31729
		// (get) Token: 0x0603200D RID: 204813 RVA: 0x00B9BF4D File Offset: 0x00B9A14D
		// (set) Token: 0x0603200E RID: 204814 RVA: 0x00B9BF55 File Offset: 0x00B9A155
		public FVectorDouble TargetPosition { get; set; }

		// Token: 0x17007BF2 RID: 31730
		// (get) Token: 0x0603200F RID: 204815 RVA: 0x00B9BF5E File Offset: 0x00B9A15E
		// (set) Token: 0x06032010 RID: 204816 RVA: 0x00B9BF66 File Offset: 0x00B9A166
		public ETeleportMode? TeleportMode { get; set; }

		// Token: 0x17007BF3 RID: 31731
		// (get) Token: 0x06032011 RID: 204817 RVA: 0x00B9BF6F File Offset: 0x00B9A16F
		// (set) Token: 0x06032012 RID: 204818 RVA: 0x00B9BF77 File Offset: 0x00B9A177
		public IRotator TargetRotation { get; set; }

		// Token: 0x17007BF4 RID: 31732
		// (get) Token: 0x06032013 RID: 204819 RVA: 0x00B9BF80 File Offset: 0x00B9A180
		// (set) Token: 0x06032014 RID: 204820 RVA: 0x00B9BF88 File Offset: 0x00B9A188
		public IVector TargetGravityDirect { get; set; }

		// Token: 0x17007BF5 RID: 31733
		// (get) Token: 0x06032015 RID: 204821 RVA: 0x00B9BF91 File Offset: 0x00B9A191
		// (set) Token: 0x06032016 RID: 204822 RVA: 0x00B9BF99 File Offset: 0x00B9A199
		public IVector TargetSpeed { get; set; }

		// Token: 0x17007BF6 RID: 31734
		// (get) Token: 0x06032017 RID: 204823 RVA: 0x00B9BFA2 File Offset: 0x00B9A1A2
		// (set) Token: 0x06032018 RID: 204824 RVA: 0x00B9BFAA File Offset: 0x00B9A1AA
		public TeleportReason? ServerReason { get; set; }

		// Token: 0x17007BF7 RID: 31735
		// (get) Token: 0x06032019 RID: 204825 RVA: 0x00B9BFB3 File Offset: 0x00B9A1B3
		// (set) Token: 0x0603201A RID: 204826 RVA: 0x00B9BFBB File Offset: 0x00B9A1BB
		public TransitionOptionPb Option { get; set; }

		// Token: 0x17007BF8 RID: 31736
		// (get) Token: 0x0603201B RID: 204827 RVA: 0x00B9BFC4 File Offset: 0x00B9A1C4
		// (set) Token: 0x0603201C RID: 204828 RVA: 0x00B9BFCC File Offset: 0x00B9A1CC
		public int? TransitionConfigId { get; set; }

		// Token: 0x17007BF9 RID: 31737
		// (get) Token: 0x0603201D RID: 204829 RVA: 0x00B9BFD5 File Offset: 0x00B9A1D5
		// (set) Token: 0x0603201E RID: 204830 RVA: 0x00B9BFDD File Offset: 0x00B9A1DD
		public bool? NeedRestoreCamera { get; set; }

		// Token: 0x17007BFA RID: 31738
		// (get) Token: 0x0603201F RID: 204831 RVA: 0x00B9BFE6 File Offset: 0x00B9A1E6
		// (set) Token: 0x06032020 RID: 204832 RVA: 0x00B9BFEE File Offset: 0x00B9A1EE
		public GameCtxPb GameCtx { get; set; }

		// Token: 0x17007BFB RID: 31739
		// (get) Token: 0x06032021 RID: 204833 RVA: 0x00B9BFF7 File Offset: 0x00B9A1F7
		// (set) Token: 0x06032022 RID: 204834 RVA: 0x00B9BFFF File Offset: 0x00B9A1FF
		public Entity ElevatorEntity { get; set; }

		// Token: 0x17007BFC RID: 31740
		// (get) Token: 0x06032023 RID: 204835 RVA: 0x00B9C008 File Offset: 0x00B9A208
		// (set) Token: 0x06032024 RID: 204836 RVA: 0x00B9C010 File Offset: 0x00B9A210
		public bool? DisableAutoFade { get; set; }

		// Token: 0x17007BFD RID: 31741
		// (get) Token: 0x06032025 RID: 204837 RVA: 0x00B9C019 File Offset: 0x00B9A219
		// (set) Token: 0x06032026 RID: 204838 RVA: 0x00B9C021 File Offset: 0x00B9A221
		public int? TeleportCfgId { get; set; }

		// Token: 0x17007BFE RID: 31742
		// (get) Token: 0x06032027 RID: 204839 RVA: 0x00B9C02A File Offset: 0x00B9A22A
		// (set) Token: 0x06032028 RID: 204840 RVA: 0x00B9C032 File Offset: 0x00B9A232
		public bool? NeedRequestToServer { get; set; }

		// Token: 0x17007BFF RID: 31743
		// (get) Token: 0x06032029 RID: 204841 RVA: 0x00B9C03B File Offset: 0x00B9A23B
		// (set) Token: 0x0603202A RID: 204842 RVA: 0x00B9C043 File Offset: 0x00B9A243
		public bool? NeedWaitStreaming { get; set; }

		// Token: 0x17007C00 RID: 31744
		// (get) Token: 0x0603202B RID: 204843 RVA: 0x00B9C04C File Offset: 0x00B9A24C
		// (set) Token: 0x0603202C RID: 204844 RVA: 0x00B9C054 File Offset: 0x00B9A254
		public bool? KeepCameraRelativeRotation { get; set; }

		// Token: 0x17007C01 RID: 31745
		// (get) Token: 0x0603202D RID: 204845 RVA: 0x00B9C05D File Offset: 0x00B9A25D
		// (set) Token: 0x0603202E RID: 204846 RVA: 0x00B9C065 File Offset: 0x00B9A265
		public bool? KeepSpeedRelativeRotation { get; set; }

		// Token: 0x17007C02 RID: 31746
		// (get) Token: 0x0603202F RID: 204847 RVA: 0x00B9C06E File Offset: 0x00B9A26E
		// (set) Token: 0x06032030 RID: 204848 RVA: 0x00B9C076 File Offset: 0x00B9A276
		public bool? UseCameraCutForMotionBlur { get; set; }

		// Token: 0x06032031 RID: 204849 RVA: 0x00B9C07F File Offset: 0x00B9A27F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ITeleportContextParam()
		{
		}
	}
}
