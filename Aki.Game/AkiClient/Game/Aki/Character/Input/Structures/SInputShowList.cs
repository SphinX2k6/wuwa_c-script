using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x0200425E RID: 16990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputShowList.SInputShowList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SInputShowList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C08C RID: 180364 RVA: 0x00A124FC File Offset: 0x00A106FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputShowList._ScriptStructPtr != 0) ? SInputShowList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputShowList.SInputShowList", ref SInputShowList._ScriptStructPtr);
		}

		// Token: 0x17006D65 RID: 28005
		// (get) Token: 0x0602C08D RID: 180365 RVA: 0x00A12520 File Offset: 0x00A10720
		// (set) Token: 0x0602C08E RID: 180366 RVA: 0x00A12563 File Offset: 0x00A10763
		public TArray<SInputShow> InputShowList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputShow> result;
				if ((result = this._InputShowList) == null)
				{
					result = (this._InputShowList = new TArray<SInputShow>(base.NativePtr + (IntPtr)SInputShowList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputShowList.CopyAssign(value);
			}
		}

		// Token: 0x0602C08F RID: 180367 RVA: 0x00A12571 File Offset: 0x00A10771
		public SInputShowList()
		{
		}

		// Token: 0x0602C090 RID: 180368 RVA: 0x00A12579 File Offset: 0x00A10779
		public SInputShowList(TArray<SInputShow> InputShowList)
		{
			this.InputShowList = InputShowList;
		}

		// Token: 0x0602C091 RID: 180369 RVA: 0x00A12588 File Offset: 0x00A10788
		protected override IntPtr GetUStructPtr()
		{
			return SInputShowList.StaticStruct();
		}

		// Token: 0x0602C092 RID: 180370 RVA: 0x00A12594 File Offset: 0x00A10794
		[NullableContext(2)]
		public SInputShowList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C093 RID: 180371 RVA: 0x00A1259E File Offset: 0x00A1079E
		public SInputShowList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C094 RID: 180372 RVA: 0x00A125A9 File Offset: 0x00A107A9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputShowList(Pointer, false, true);
		}

		// Token: 0x0602C095 RID: 180373 RVA: 0x00A125B3 File Offset: 0x00A107B3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputShowList(Pointer, MemoryOwner);
		}

		// Token: 0x0401700A RID: 94218
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputShowList.SInputShowList";

		// Token: 0x0401700B RID: 94219
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401700C RID: 94220
		internal static int __PropertyOffset_0;

		// Token: 0x0401700D RID: 94221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInputShow> _InputShowList;
	}
}
