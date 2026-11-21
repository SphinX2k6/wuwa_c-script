using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B18 RID: 15128
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ITeleportContextParam : ITeleportContext
	{
		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x06026DA0 RID: 159136 RVA: 0x00AE0290 File Offset: 0x00ADE490
		// (set) Token: 0x06026DA1 RID: 159137 RVA: 0x00AE0298 File Offset: 0x00ADE498
		[Nullable(1)]
		[RequiredMember]
		public string ClientReason { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06026DA2 RID: 159138 RVA: 0x00AE02A1 File Offset: 0x00ADE4A1
		// (set) Token: 0x06026DA3 RID: 159139 RVA: 0x00AE02A9 File Offset: 0x00ADE4A9
		public FVectorDouble TargetPosition { get; set; }

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x06026DA4 RID: 159140 RVA: 0x00AE02B2 File Offset: 0x00ADE4B2
		// (set) Token: 0x06026DA5 RID: 159141 RVA: 0x00AE02BA File Offset: 0x00ADE4BA
		public ETeleportMode? TeleportMode { get; set; }

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x06026DA6 RID: 159142 RVA: 0x00AE02C3 File Offset: 0x00ADE4C3
		// (set) Token: 0x06026DA7 RID: 159143 RVA: 0x00AE02CB File Offset: 0x00ADE4CB
		public IRotator TargetRotation { get; set; }

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x06026DA8 RID: 159144 RVA: 0x00AE02D4 File Offset: 0x00ADE4D4
		// (set) Token: 0x06026DA9 RID: 159145 RVA: 0x00AE02DC File Offset: 0x00ADE4DC
		public IVector TargetGravityDirect { get; set; }

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x06026DAA RID: 159146 RVA: 0x00AE02E5 File Offset: 0x00ADE4E5
		// (set) Token: 0x06026DAB RID: 159147 RVA: 0x00AE02ED File Offset: 0x00ADE4ED
		public IVector TargetSpeed { get; set; }

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x06026DAC RID: 159148 RVA: 0x00AE02F6 File Offset: 0x00ADE4F6
		// (set) Token: 0x06026DAD RID: 159149 RVA: 0x00AE02FE File Offset: 0x00ADE4FE
		public TeleportReason? ServerReason { get; set; }

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x06026DAE RID: 159150 RVA: 0x00AE0307 File Offset: 0x00ADE507
		// (set) Token: 0x06026DAF RID: 159151 RVA: 0x00AE030F File Offset: 0x00ADE50F
		public TransitionOptionPb Option { get; set; }

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x06026DB0 RID: 159152 RVA: 0x00AE0318 File Offset: 0x00ADE518
		// (set) Token: 0x06026DB1 RID: 159153 RVA: 0x00AE0320 File Offset: 0x00ADE520
		public int? TransitionConfigId { get; set; }

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x06026DB2 RID: 159154 RVA: 0x00AE0329 File Offset: 0x00ADE529
		// (set) Token: 0x06026DB3 RID: 159155 RVA: 0x00AE0331 File Offset: 0x00ADE531
		public bool? NeedRestoreCamera { get; set; }

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x06026DB4 RID: 159156 RVA: 0x00AE033A File Offset: 0x00ADE53A
		// (set) Token: 0x06026DB5 RID: 159157 RVA: 0x00AE0342 File Offset: 0x00ADE542
		public GameCtxPb GameCtx { get; set; }

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x06026DB6 RID: 159158 RVA: 0x00AE034B File Offset: 0x00ADE54B
		// (set) Token: 0x06026DB7 RID: 159159 RVA: 0x00AE0353 File Offset: 0x00ADE553
		public Entity ElevatorEntity { get; set; }

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x06026DB8 RID: 159160 RVA: 0x00AE035C File Offset: 0x00ADE55C
		// (set) Token: 0x06026DB9 RID: 159161 RVA: 0x00AE0364 File Offset: 0x00ADE564
		public bool? DisableAutoFade { get; set; }

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x06026DBA RID: 159162 RVA: 0x00AE036D File Offset: 0x00ADE56D
		// (set) Token: 0x06026DBB RID: 159163 RVA: 0x00AE0375 File Offset: 0x00ADE575
		public int? TeleportCfgId { get; set; }

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x06026DBC RID: 159164 RVA: 0x00AE037E File Offset: 0x00ADE57E
		// (set) Token: 0x06026DBD RID: 159165 RVA: 0x00AE0386 File Offset: 0x00ADE586
		public bool? NeedRequestToServer { get; set; }

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x06026DBE RID: 159166 RVA: 0x00AE038F File Offset: 0x00ADE58F
		// (set) Token: 0x06026DBF RID: 159167 RVA: 0x00AE0397 File Offset: 0x00ADE597
		public bool? NeedWaitStreaming { get; set; }

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x06026DC0 RID: 159168 RVA: 0x00AE03A0 File Offset: 0x00ADE5A0
		// (set) Token: 0x06026DC1 RID: 159169 RVA: 0x00AE03A8 File Offset: 0x00ADE5A8
		public bool? KeepCameraRelativeRotation { get; set; }

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x06026DC2 RID: 159170 RVA: 0x00AE03B1 File Offset: 0x00ADE5B1
		// (set) Token: 0x06026DC3 RID: 159171 RVA: 0x00AE03B9 File Offset: 0x00ADE5B9
		public bool? KeepSpeedRelativeRotation { get; set; }

		// Token: 0x06026DC4 RID: 159172 RVA: 0x00AE03C2 File Offset: 0x00ADE5C2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ITeleportContextParam()
		{
		}
	}
}
