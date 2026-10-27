using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004319 RID: 17177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SGEData.SGEData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SGEData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C712 RID: 182034 RVA: 0x00A1FD58 File Offset: 0x00A1DF58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGEData._ScriptStructPtr != 0) ? SGEData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SGEData.SGEData", ref SGEData._ScriptStructPtr);
		}

		// Token: 0x17006F40 RID: 28480
		// (get) Token: 0x0602C713 RID: 182035 RVA: 0x00A1FD7C File Offset: 0x00A1DF7C
		// (set) Token: 0x0602C714 RID: 182036 RVA: 0x00A1FD90 File Offset: 0x00A1DF90
		public unsafe FName GEName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F41 RID: 28481
		// (get) Token: 0x0602C715 RID: 182037 RVA: 0x00A1FDA8 File Offset: 0x00A1DFA8
		// (set) Token: 0x0602C716 RID: 182038 RVA: 0x00A1FDEB File Offset: 0x00A1DFEB
		public unsafe FText Comment
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Comment) == null)
				{
					result = (this._Comment = new FText(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SGEData.__PropertyOffset_1)), value.NativePtr, 1);
			}
		}

		// Token: 0x17006F42 RID: 28482
		// (get) Token: 0x0602C717 RID: 182039 RVA: 0x00A1FE06 File Offset: 0x00A1E006
		// (set) Token: 0x0602C718 RID: 182040 RVA: 0x00A1FE1A File Offset: 0x00A1E01A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> GE
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_2);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F43 RID: 28483
		// (get) Token: 0x0602C719 RID: 182041 RVA: 0x00A1FE30 File Offset: 0x00A1E030
		// (set) Token: 0x0602C71A RID: 182042 RVA: 0x00A1FE73 File Offset: 0x00A1E073
		public TArray<SFloatPayload> Payload
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatPayload> result;
				if ((result = this._Payload) == null)
				{
					result = (this._Payload = new TArray<SFloatPayload>(base.NativePtr + (IntPtr)SGEData.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Payload.CopyAssign(value);
			}
		}

		// Token: 0x0602C71B RID: 182043 RVA: 0x00A1FE81 File Offset: 0x00A1E081
		public SGEData()
		{
		}

		// Token: 0x0602C71C RID: 182044 RVA: 0x00A1FE89 File Offset: 0x00A1E089
		public SGEData(FName GEName, FText Comment, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> GE, TArray<SFloatPayload> Payload)
		{
			this.GEName = GEName;
			this.Comment = Comment;
			this.GE = GE;
			this.Payload = Payload;
		}

		// Token: 0x0602C71D RID: 182045 RVA: 0x00A1FEAE File Offset: 0x00A1E0AE
		protected override IntPtr GetUStructPtr()
		{
			return SGEData.StaticStruct();
		}

		// Token: 0x0602C71E RID: 182046 RVA: 0x00A1FEBA File Offset: 0x00A1E0BA
		[NullableContext(2)]
		public SGEData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C71F RID: 182047 RVA: 0x00A1FEC4 File Offset: 0x00A1E0C4
		public SGEData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C720 RID: 182048 RVA: 0x00A1FECF File Offset: 0x00A1E0CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGEData(Pointer, false, true);
		}

		// Token: 0x0602C721 RID: 182049 RVA: 0x00A1FED9 File Offset: 0x00A1E0D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGEData(Pointer, MemoryOwner);
		}

		// Token: 0x040176DE RID: 95966
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SGEData.SGEData";

		// Token: 0x040176DF RID: 95967
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176E0 RID: 95968
		internal static int __PropertyOffset_0;

		// Token: 0x040176E1 RID: 95969
		internal static int __PropertyOffset_1;

		// Token: 0x040176E2 RID: 95970
		[Nullable(2)]
		private FText _Comment;

		// Token: 0x040176E3 RID: 95971
		internal static int __PropertyOffset_2;

		// Token: 0x040176E4 RID: 95972
		internal static int __PropertyOffset_3;

		// Token: 0x040176E5 RID: 95973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatPayload> _Payload;
	}
}
