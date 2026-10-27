using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F1 RID: 17137
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class SBatchBulletPositionSpline : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C40A RID: 181258 RVA: 0x00A1B6CF File Offset: 0x00A198CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionSpline._ScriptStructPtr != 0) ? SBatchBulletPositionSpline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline", ref SBatchBulletPositionSpline._ScriptStructPtr);
		}

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x0602C40B RID: 181259 RVA: 0x00A1B6F3 File Offset: 0x00A198F3
		// (set) Token: 0x0602C40C RID: 181260 RVA: 0x00A1B712 File Offset: 0x00A19912
		public TSoftClassPtr<BP_BasePathLineBullet_C> SplineClass
		{
			get
			{
				return new TSoftClassPtr<BP_BasePathLineBullet_C>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x0602C40D RID: 181261 RVA: 0x00A1B737 File Offset: 0x00A19937
		// (set) Token: 0x0602C40E RID: 181262 RVA: 0x00A1B74B File Offset: 0x00A1994B
		public unsafe string StartKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x0602C40F RID: 181263 RVA: 0x00A1B760 File Offset: 0x00A19960
		// (set) Token: 0x0602C410 RID: 181264 RVA: 0x00A1B774 File Offset: 0x00A19974
		public unsafe string EndKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x0602C411 RID: 181265 RVA: 0x00A1B789 File Offset: 0x00A19989
		// (set) Token: 0x0602C412 RID: 181266 RVA: 0x00A1B79D File Offset: 0x00A1999D
		public unsafe string RotatorKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x0602C413 RID: 181267 RVA: 0x00A1B7B2 File Offset: 0x00A199B2
		// (set) Token: 0x0602C414 RID: 181268 RVA: 0x00A1B7C6 File Offset: 0x00A199C6
		public unsafe string DurationKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17006E5E RID: 28254
		// (get) Token: 0x0602C415 RID: 181269 RVA: 0x00A1B7DB File Offset: 0x00A199DB
		// (set) Token: 0x0602C416 RID: 181270 RVA: 0x00A1B7EB File Offset: 0x00A199EB
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006E5F RID: 28255
		// (get) Token: 0x0602C417 RID: 181271 RVA: 0x00A1B7FC File Offset: 0x00A199FC
		// (set) Token: 0x0602C418 RID: 181272 RVA: 0x00A1B80C File Offset: 0x00A19A0C
		public unsafe bool DestroyAllOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E60 RID: 28256
		// (get) Token: 0x0602C419 RID: 181273 RVA: 0x00A1B81D File Offset: 0x00A19A1D
		// (set) Token: 0x0602C41A RID: 181274 RVA: 0x00A1B82D File Offset: 0x00A19A2D
		public unsafe bool DestroySummonBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E61 RID: 28257
		// (get) Token: 0x0602C41B RID: 181275 RVA: 0x00A1B83E File Offset: 0x00A19A3E
		// (set) Token: 0x0602C41C RID: 181276 RVA: 0x00A1B852 File Offset: 0x00A19A52
		public unsafe string BulletIdOfEnd
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x17006E62 RID: 28258
		// (get) Token: 0x0602C41D RID: 181277 RVA: 0x00A1B867 File Offset: 0x00A19A67
		// (set) Token: 0x0602C41E RID: 181278 RVA: 0x00A1B886 File Offset: 0x00A19A86
		public TSoftObjectPtr<UEffectModelBase> EffectOfEnd
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_9, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E63 RID: 28259
		// (get) Token: 0x0602C41F RID: 181279 RVA: 0x00A1B8AB File Offset: 0x00A19AAB
		// (set) Token: 0x0602C420 RID: 181280 RVA: 0x00A1B8BF File Offset: 0x00A19ABF
		public unsafe string BulletIdOnBreak
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionSpline.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x17006E64 RID: 28260
		// (get) Token: 0x0602C421 RID: 181281 RVA: 0x00A1B8D4 File Offset: 0x00A19AD4
		// (set) Token: 0x0602C422 RID: 181282 RVA: 0x00A1B8F3 File Offset: 0x00A19AF3
		public TSoftObjectPtr<UEffectModelBase> EffectOnBreak
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBatchBulletPositionSpline.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602C423 RID: 181283 RVA: 0x00A1B918 File Offset: 0x00A19B18
		public SBatchBulletPositionSpline()
		{
		}

		// Token: 0x0602C424 RID: 181284 RVA: 0x00A1B920 File Offset: 0x00A19B20
		public SBatchBulletPositionSpline(TSoftClassPtr<BP_BasePathLineBullet_C> SplineClass, string StartKey, string EndKey, string RotatorKey, string DurationKey, float Delay, bool DestroyAllOnEnd, bool DestroySummonBullet, string BulletIdOfEnd, TSoftObjectPtr<UEffectModelBase> EffectOfEnd, string BulletIdOnBreak, TSoftObjectPtr<UEffectModelBase> EffectOnBreak)
		{
			this.SplineClass = SplineClass;
			this.StartKey = StartKey;
			this.EndKey = EndKey;
			this.RotatorKey = RotatorKey;
			this.DurationKey = DurationKey;
			this.Delay = Delay;
			this.DestroyAllOnEnd = DestroyAllOnEnd;
			this.DestroySummonBullet = DestroySummonBullet;
			this.BulletIdOfEnd = BulletIdOfEnd;
			this.EffectOfEnd = EffectOfEnd;
			this.BulletIdOnBreak = BulletIdOnBreak;
			this.EffectOnBreak = EffectOnBreak;
		}

		// Token: 0x0602C425 RID: 181285 RVA: 0x00A1B990 File Offset: 0x00A19B90
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionSpline.StaticStruct();
		}

		// Token: 0x0602C426 RID: 181286 RVA: 0x00A1B99C File Offset: 0x00A19B9C
		[NullableContext(2)]
		public SBatchBulletPositionSpline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C427 RID: 181287 RVA: 0x00A1B9A6 File Offset: 0x00A19BA6
		public SBatchBulletPositionSpline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C428 RID: 181288 RVA: 0x00A1B9B1 File Offset: 0x00A19BB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionSpline(Pointer, false, true);
		}

		// Token: 0x0602C429 RID: 181289 RVA: 0x00A1B9BB File Offset: 0x00A19BBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionSpline(Pointer, MemoryOwner);
		}

		// Token: 0x04017567 RID: 95591
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionSpline.SBatchBulletPositionSpline";

		// Token: 0x04017568 RID: 95592
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017569 RID: 95593
		internal static int __PropertyOffset_0;

		// Token: 0x0401756A RID: 95594
		internal static int __PropertyOffset_1;

		// Token: 0x0401756B RID: 95595
		internal static int __PropertyOffset_2;

		// Token: 0x0401756C RID: 95596
		internal static int __PropertyOffset_3;

		// Token: 0x0401756D RID: 95597
		internal static int __PropertyOffset_4;

		// Token: 0x0401756E RID: 95598
		internal static int __PropertyOffset_5;

		// Token: 0x0401756F RID: 95599
		internal static int __PropertyOffset_6;

		// Token: 0x04017570 RID: 95600
		internal static int __PropertyOffset_7;

		// Token: 0x04017571 RID: 95601
		internal static int __PropertyOffset_8;

		// Token: 0x04017572 RID: 95602
		internal static int __PropertyOffset_9;

		// Token: 0x04017573 RID: 95603
		internal static int __PropertyOffset_10;

		// Token: 0x04017574 RID: 95604
		internal static int __PropertyOffset_11;
	}
}
