using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x0200322C RID: 12844
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SCharacterLocationsAndRadius : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602010C RID: 131340 RVA: 0x0093C638 File Offset: 0x0093A838
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterLocationsAndRadius._ScriptStructPtr != 0) ? SCharacterLocationsAndRadius._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius", ref SCharacterLocationsAndRadius._ScriptStructPtr);
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0602010D RID: 131341 RVA: 0x0093C65C File Offset: 0x0093A85C
		// (set) Token: 0x0602010E RID: 131342 RVA: 0x0093C69F File Offset: 0x0093A89F
		public TArray<FVectorDouble> Locations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._Locations) == null)
				{
					result = (this._Locations = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_Locations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Locations.CopyAssign(value);
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0602010F RID: 131343 RVA: 0x0093C6B0 File Offset: 0x0093A8B0
		// (set) Token: 0x06020110 RID: 131344 RVA: 0x0093C6F3 File Offset: 0x0093A8F3
		public TArray<float> Radius
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Radius) == null)
				{
					result = (this._Radius = new TArray<float>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_Radius, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Radius.CopyAssign(value);
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x06020111 RID: 131345 RVA: 0x0093C704 File Offset: 0x0093A904
		// (set) Token: 0x06020112 RID: 131346 RVA: 0x0093C747 File Offset: 0x0093A947
		public TArray<float> HalfHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._HalfHeight) == null)
				{
					result = (this._HalfHeight = new TArray<float>(base.NativePtr + (IntPtr)SCharacterLocationsAndRadius.__PropertyOffset_HalfHeight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HalfHeight.CopyAssign(value);
			}
		}

		// Token: 0x06020113 RID: 131347 RVA: 0x0093C755 File Offset: 0x0093A955
		public SCharacterLocationsAndRadius()
		{
		}

		// Token: 0x06020114 RID: 131348 RVA: 0x0093C75D File Offset: 0x0093A95D
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterLocationsAndRadius.StaticStruct();
		}

		// Token: 0x06020115 RID: 131349 RVA: 0x0093C769 File Offset: 0x0093A969
		[NullableContext(2)]
		public SCharacterLocationsAndRadius(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020116 RID: 131350 RVA: 0x0093C773 File Offset: 0x0093A973
		public SCharacterLocationsAndRadius(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020117 RID: 131351 RVA: 0x0093C77E File Offset: 0x0093A97E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterLocationsAndRadius(Pointer, false, true);
		}

		// Token: 0x06020118 RID: 131352 RVA: 0x0093C788 File Offset: 0x0093A988
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterLocationsAndRadius(Pointer, MemoryOwner);
		}

		// Token: 0x040113D7 RID: 70615
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SCharacterLocationsAndRadius.SCharacterLocationsAndRadius";

		// Token: 0x040113D8 RID: 70616
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040113D9 RID: 70617
		internal static int __PropertyOffset_Locations;

		// Token: 0x040113DA RID: 70618
		[Nullable(2)]
		private TArray<FVectorDouble> _Locations;

		// Token: 0x040113DB RID: 70619
		internal static int __PropertyOffset_Radius;

		// Token: 0x040113DC RID: 70620
		[Nullable(2)]
		private TArray<float> _Radius;

		// Token: 0x040113DD RID: 70621
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x040113DE RID: 70622
		[Nullable(2)]
		private TArray<float> _HalfHeight;
	}
}
