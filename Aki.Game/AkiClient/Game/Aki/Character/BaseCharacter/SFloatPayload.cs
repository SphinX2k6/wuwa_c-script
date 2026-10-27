using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004314 RID: 17172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFloatPayload.SFloatPayload")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SFloatPayload : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C6C7 RID: 181959 RVA: 0x00A1F799 File Offset: 0x00A1D999
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatPayload._ScriptStructPtr != 0) ? SFloatPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFloatPayload.SFloatPayload", ref SFloatPayload._ScriptStructPtr);
		}

		// Token: 0x17006F2E RID: 28462
		// (get) Token: 0x0602C6C8 RID: 181960 RVA: 0x00A1F7C0 File Offset: 0x00A1D9C0
		// (set) Token: 0x0602C6C9 RID: 181961 RVA: 0x00A1F803 File Offset: 0x00A1DA03
		public TArray<float> FloatArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FloatArray) == null)
				{
					result = (this._FloatArray = new TArray<float>(base.NativePtr + (IntPtr)SFloatPayload.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatArray.CopyAssign(value);
			}
		}

		// Token: 0x0602C6CA RID: 181962 RVA: 0x00A1F811 File Offset: 0x00A1DA11
		public SFloatPayload()
		{
		}

		// Token: 0x0602C6CB RID: 181963 RVA: 0x00A1F819 File Offset: 0x00A1DA19
		public SFloatPayload(TArray<float> FloatArray)
		{
			this.FloatArray = FloatArray;
		}

		// Token: 0x0602C6CC RID: 181964 RVA: 0x00A1F828 File Offset: 0x00A1DA28
		protected override IntPtr GetUStructPtr()
		{
			return SFloatPayload.StaticStruct();
		}

		// Token: 0x0602C6CD RID: 181965 RVA: 0x00A1F834 File Offset: 0x00A1DA34
		[NullableContext(2)]
		public SFloatPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C6CE RID: 181966 RVA: 0x00A1F83E File Offset: 0x00A1DA3E
		public SFloatPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C6CF RID: 181967 RVA: 0x00A1F849 File Offset: 0x00A1DA49
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatPayload(Pointer, false, true);
		}

		// Token: 0x0602C6D0 RID: 181968 RVA: 0x00A1F853 File Offset: 0x00A1DA53
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatPayload(Pointer, MemoryOwner);
		}

		// Token: 0x040176BE RID: 95934
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFloatPayload.SFloatPayload";

		// Token: 0x040176BF RID: 95935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176C0 RID: 95936
		internal static int __PropertyOffset_0;

		// Token: 0x040176C1 RID: 95937
		[Nullable(2)]
		private TArray<float> _FloatArray;
	}
}
