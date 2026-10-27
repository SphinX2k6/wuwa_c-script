using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E82 RID: 16002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/SBeamYinlinEffect.SBeamYinlinEffect")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SBeamYinlinEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028663 RID: 165475 RVA: 0x009AB820 File Offset: 0x009A9A20
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBeamYinlinEffect._ScriptStructPtr != 0) ? SBeamYinlinEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Effect/BluePrint/BP_FX_Common/SBeamYinlinEffect.SBeamYinlinEffect", ref SBeamYinlinEffect._ScriptStructPtr);
		}

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x06028664 RID: 165476 RVA: 0x009AB844 File Offset: 0x009A9A44
		// (set) Token: 0x06028665 RID: 165477 RVA: 0x009AB854 File Offset: 0x009A9A54
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBeamYinlinEffect.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBeamYinlinEffect.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x06028666 RID: 165478 RVA: 0x009AB868 File Offset: 0x009A9A68
		// (set) Token: 0x06028667 RID: 165479 RVA: 0x009AB8AB File Offset: 0x009A9AAB
		public TArray<FVector> Poses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Poses) == null)
				{
					result = (this._Poses = new TArray<FVector>(base.NativePtr + (IntPtr)SBeamYinlinEffect.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Poses.CopyAssign(value);
			}
		}

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x06028668 RID: 165480 RVA: 0x009AB8BC File Offset: 0x009A9ABC
		// (set) Token: 0x06028669 RID: 165481 RVA: 0x009AB8FF File Offset: 0x009A9AFF
		public TArray<bool> ChangedPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._ChangedPoints) == null)
				{
					result = (this._ChangedPoints = new TArray<bool>(base.NativePtr + (IntPtr)SBeamYinlinEffect.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChangedPoints.CopyAssign(value);
			}
		}

		// Token: 0x0602866A RID: 165482 RVA: 0x009AB90D File Offset: 0x009A9B0D
		public SBeamYinlinEffect()
		{
		}

		// Token: 0x0602866B RID: 165483 RVA: 0x009AB915 File Offset: 0x009A9B15
		public SBeamYinlinEffect(float Time, TArray<FVector> Poses, TArray<bool> ChangedPoints)
		{
			this.Time = Time;
			this.Poses = Poses;
			this.ChangedPoints = ChangedPoints;
		}

		// Token: 0x0602866C RID: 165484 RVA: 0x009AB932 File Offset: 0x009A9B32
		protected override IntPtr GetUStructPtr()
		{
			return SBeamYinlinEffect.StaticStruct();
		}

		// Token: 0x0602866D RID: 165485 RVA: 0x009AB93E File Offset: 0x009A9B3E
		[NullableContext(2)]
		public SBeamYinlinEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602866E RID: 165486 RVA: 0x009AB948 File Offset: 0x009A9B48
		public SBeamYinlinEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602866F RID: 165487 RVA: 0x009AB953 File Offset: 0x009A9B53
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBeamYinlinEffect(Pointer, false, true);
		}

		// Token: 0x06028670 RID: 165488 RVA: 0x009AB95D File Offset: 0x009A9B5D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBeamYinlinEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0401497A RID: 84346
		public const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/SBeamYinlinEffect.SBeamYinlinEffect";

		// Token: 0x0401497B RID: 84347
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401497C RID: 84348
		internal static int __PropertyOffset_0;

		// Token: 0x0401497D RID: 84349
		internal static int __PropertyOffset_1;

		// Token: 0x0401497E RID: 84350
		[Nullable(2)]
		private TArray<FVector> _Poses;

		// Token: 0x0401497F RID: 84351
		internal static int __PropertyOffset_2;

		// Token: 0x04014980 RID: 84352
		[Nullable(2)]
		private TArray<bool> _ChangedPoints;
	}
}
