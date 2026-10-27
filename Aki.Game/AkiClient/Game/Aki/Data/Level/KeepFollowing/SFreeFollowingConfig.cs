using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x02003F0F RID: 16143
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 69)]
	public class SFreeFollowingConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028F9E RID: 167838 RVA: 0x009B8C62 File Offset: 0x009B6E62
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFreeFollowingConfig._ScriptStructPtr != 0) ? SFreeFollowingConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig", ref SFreeFollowingConfig._ScriptStructPtr);
		}

		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x06028F9F RID: 167839 RVA: 0x009B8C86 File Offset: 0x009B6E86
		// (set) Token: 0x06028FA0 RID: 167840 RVA: 0x009B8C96 File Offset: 0x009B6E96
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x06028FA1 RID: 167841 RVA: 0x009B8CA7 File Offset: 0x009B6EA7
		// (set) Token: 0x06028FA2 RID: 167842 RVA: 0x009B8CB7 File Offset: 0x009B6EB7
		public unsafe bool FollowOnRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x06028FA3 RID: 167843 RVA: 0x009B8CC8 File Offset: 0x009B6EC8
		// (set) Token: 0x06028FA4 RID: 167844 RVA: 0x009B8CD8 File Offset: 0x009B6ED8
		public unsafe bool AutoChangeSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x06028FA5 RID: 167845 RVA: 0x009B8CE9 File Offset: 0x009B6EE9
		// (set) Token: 0x06028FA6 RID: 167846 RVA: 0x009B8CF9 File Offset: 0x009B6EF9
		public unsafe float StartFollowingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x06028FA7 RID: 167847 RVA: 0x009B8D0A File Offset: 0x009B6F0A
		// (set) Token: 0x06028FA8 RID: 167848 RVA: 0x009B8D1A File Offset: 0x009B6F1A
		public unsafe float WalkStartFollowingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x06028FA9 RID: 167849 RVA: 0x009B8D2B File Offset: 0x009B6F2B
		// (set) Token: 0x06028FAA RID: 167850 RVA: 0x009B8D3B File Offset: 0x009B6F3B
		public unsafe float FollowRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x06028FAB RID: 167851 RVA: 0x009B8D4C File Offset: 0x009B6F4C
		// (set) Token: 0x06028FAC RID: 167852 RVA: 0x009B8D5C File Offset: 0x009B6F5C
		public unsafe float WalkFollowRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x06028FAD RID: 167853 RVA: 0x009B8D6D File Offset: 0x009B6F6D
		// (set) Token: 0x06028FAE RID: 167854 RVA: 0x009B8D7D File Offset: 0x009B6F7D
		public unsafe float MaxForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x06028FAF RID: 167855 RVA: 0x009B8D8E File Offset: 0x009B6F8E
		// (set) Token: 0x06028FB0 RID: 167856 RVA: 0x009B8D9E File Offset: 0x009B6F9E
		public unsafe float FullForwardOffsetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x06028FB1 RID: 167857 RVA: 0x009B8DAF File Offset: 0x009B6FAF
		// (set) Token: 0x06028FB2 RID: 167858 RVA: 0x009B8DBF File Offset: 0x009B6FBF
		public unsafe float SideAngleTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x06028FB3 RID: 167859 RVA: 0x009B8DD0 File Offset: 0x009B6FD0
		// (set) Token: 0x06028FB4 RID: 167860 RVA: 0x009B8DE0 File Offset: 0x009B6FE0
		public unsafe float OffsetAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x06028FB5 RID: 167861 RVA: 0x009B8DF1 File Offset: 0x009B6FF1
		// (set) Token: 0x06028FB6 RID: 167862 RVA: 0x009B8E01 File Offset: 0x009B7001
		public unsafe float MovementIntentSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x06028FB7 RID: 167863 RVA: 0x009B8E12 File Offset: 0x009B7012
		// (set) Token: 0x06028FB8 RID: 167864 RVA: 0x009B8E22 File Offset: 0x009B7022
		public unsafe float StopConfirmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x06028FB9 RID: 167865 RVA: 0x009B8E33 File Offset: 0x009B7033
		// (set) Token: 0x06028FBA RID: 167866 RVA: 0x009B8E43 File Offset: 0x009B7043
		public unsafe float WalkBehindTargetPauseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170060CC RID: 24780
		// (get) Token: 0x06028FBB RID: 167867 RVA: 0x009B8E54 File Offset: 0x009B7054
		// (set) Token: 0x06028FBC RID: 167868 RVA: 0x009B8E64 File Offset: 0x009B7064
		public unsafe float RunReferenceDirectionSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x06028FBD RID: 167869 RVA: 0x009B8E75 File Offset: 0x009B7075
		// (set) Token: 0x06028FBE RID: 167870 RVA: 0x009B8E85 File Offset: 0x009B7085
		public unsafe float SprintReferenceDirectionSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x06028FBF RID: 167871 RVA: 0x009B8E96 File Offset: 0x009B7096
		// (set) Token: 0x06028FC0 RID: 167872 RVA: 0x009B8EA6 File Offset: 0x009B70A6
		public unsafe bool EnableLocalMovementHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x06028FC1 RID: 167873 RVA: 0x009B8EB7 File Offset: 0x009B70B7
		// (set) Token: 0x06028FC2 RID: 167874 RVA: 0x009B8EC7 File Offset: 0x009B70C7
		public unsafe float LocalMovementEnterRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x06028FC3 RID: 167875 RVA: 0x009B8ED8 File Offset: 0x009B70D8
		// (set) Token: 0x06028FC4 RID: 167876 RVA: 0x009B8EE8 File Offset: 0x009B70E8
		public unsafe float LocalMovementEnterConfirmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x06028FC5 RID: 167877 RVA: 0x009B8EF9 File Offset: 0x009B70F9
		// (set) Token: 0x06028FC6 RID: 167878 RVA: 0x009B8F09 File Offset: 0x009B7109
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028FC7 RID: 167879 RVA: 0x009B8F1A File Offset: 0x009B711A
		public SFreeFollowingConfig()
		{
		}

		// Token: 0x06028FC8 RID: 167880 RVA: 0x009B8F24 File Offset: 0x009B7124
		public SFreeFollowingConfig(bool Enable, bool FollowOnRight, bool AutoChangeSide, float StartFollowingRadius, float WalkStartFollowingRadius, float FollowRadius, float WalkFollowRadius, float MaxForwardOffset, float FullForwardOffsetSpeed, float SideAngleTolerance, float OffsetAngle, float MovementIntentSmoothingTime, float StopConfirmTime, float WalkBehindTargetPauseTime, float RunReferenceDirectionSmoothingTime, float SprintReferenceDirectionSmoothingTime, bool EnableLocalMovementHold, float LocalMovementEnterRate, float LocalMovementEnterConfirmTime, bool DebugDraw)
		{
			this.Enable = Enable;
			this.FollowOnRight = FollowOnRight;
			this.AutoChangeSide = AutoChangeSide;
			this.StartFollowingRadius = StartFollowingRadius;
			this.WalkStartFollowingRadius = WalkStartFollowingRadius;
			this.FollowRadius = FollowRadius;
			this.WalkFollowRadius = WalkFollowRadius;
			this.MaxForwardOffset = MaxForwardOffset;
			this.FullForwardOffsetSpeed = FullForwardOffsetSpeed;
			this.SideAngleTolerance = SideAngleTolerance;
			this.OffsetAngle = OffsetAngle;
			this.MovementIntentSmoothingTime = MovementIntentSmoothingTime;
			this.StopConfirmTime = StopConfirmTime;
			this.WalkBehindTargetPauseTime = WalkBehindTargetPauseTime;
			this.RunReferenceDirectionSmoothingTime = RunReferenceDirectionSmoothingTime;
			this.SprintReferenceDirectionSmoothingTime = SprintReferenceDirectionSmoothingTime;
			this.EnableLocalMovementHold = EnableLocalMovementHold;
			this.LocalMovementEnterRate = LocalMovementEnterRate;
			this.LocalMovementEnterConfirmTime = LocalMovementEnterConfirmTime;
			this.DebugDraw = DebugDraw;
		}

		// Token: 0x06028FC9 RID: 167881 RVA: 0x009B8FD4 File Offset: 0x009B71D4
		protected override IntPtr GetUStructPtr()
		{
			return SFreeFollowingConfig.StaticStruct();
		}

		// Token: 0x06028FCA RID: 167882 RVA: 0x009B8FE0 File Offset: 0x009B71E0
		[NullableContext(2)]
		public SFreeFollowingConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028FCB RID: 167883 RVA: 0x009B8FEA File Offset: 0x009B71EA
		public SFreeFollowingConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028FCC RID: 167884 RVA: 0x009B8FF5 File Offset: 0x009B71F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFreeFollowingConfig(Pointer, false, true);
		}

		// Token: 0x06028FCD RID: 167885 RVA: 0x009B8FFF File Offset: 0x009B71FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFreeFollowingConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014F62 RID: 85858
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig";

		// Token: 0x04014F63 RID: 85859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F64 RID: 85860
		internal static int __PropertyOffset_0;

		// Token: 0x04014F65 RID: 85861
		internal static int __PropertyOffset_1;

		// Token: 0x04014F66 RID: 85862
		internal static int __PropertyOffset_2;

		// Token: 0x04014F67 RID: 85863
		internal static int __PropertyOffset_3;

		// Token: 0x04014F68 RID: 85864
		internal static int __PropertyOffset_4;

		// Token: 0x04014F69 RID: 85865
		internal static int __PropertyOffset_5;

		// Token: 0x04014F6A RID: 85866
		internal static int __PropertyOffset_6;

		// Token: 0x04014F6B RID: 85867
		internal static int __PropertyOffset_7;

		// Token: 0x04014F6C RID: 85868
		internal static int __PropertyOffset_8;

		// Token: 0x04014F6D RID: 85869
		internal static int __PropertyOffset_9;

		// Token: 0x04014F6E RID: 85870
		internal static int __PropertyOffset_10;

		// Token: 0x04014F6F RID: 85871
		internal static int __PropertyOffset_11;

		// Token: 0x04014F70 RID: 85872
		internal static int __PropertyOffset_12;

		// Token: 0x04014F71 RID: 85873
		internal static int __PropertyOffset_13;

		// Token: 0x04014F72 RID: 85874
		internal static int __PropertyOffset_14;

		// Token: 0x04014F73 RID: 85875
		internal static int __PropertyOffset_15;

		// Token: 0x04014F74 RID: 85876
		internal static int __PropertyOffset_16;

		// Token: 0x04014F75 RID: 85877
		internal static int __PropertyOffset_17;

		// Token: 0x04014F76 RID: 85878
		internal static int __PropertyOffset_18;

		// Token: 0x04014F77 RID: 85879
		internal static int __PropertyOffset_19;
	}
}
