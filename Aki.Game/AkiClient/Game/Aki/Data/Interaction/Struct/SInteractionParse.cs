using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x02003F1D RID: 16157
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionParse.SInteractionParse")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SInteractionParse : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029088 RID: 168072 RVA: 0x009BA258 File Offset: 0x009B8458
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionParse._ScriptStructPtr != 0) ? SInteractionParse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionParse.SInteractionParse", ref SInteractionParse._ScriptStructPtr);
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x06029089 RID: 168073 RVA: 0x009BA27C File Offset: 0x009B847C
		// (set) Token: 0x0602908A RID: 168074 RVA: 0x009BA28C File Offset: 0x009B848C
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionParse.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionParse.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x0602908B RID: 168075 RVA: 0x009BA29D File Offset: 0x009B849D
		// (set) Token: 0x0602908C RID: 168076 RVA: 0x009BA2B1 File Offset: 0x009B84B1
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionParse.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionParse.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x0602908D RID: 168077 RVA: 0x009BA2C6 File Offset: 0x009B84C6
		public SInteractionParse()
		{
		}

		// Token: 0x0602908E RID: 168078 RVA: 0x009BA2CE File Offset: 0x009B84CE
		public SInteractionParse(int Value, string Desc)
		{
			this.Value = Value;
			this.Desc = Desc;
		}

		// Token: 0x0602908F RID: 168079 RVA: 0x009BA2E4 File Offset: 0x009B84E4
		protected override IntPtr GetUStructPtr()
		{
			return SInteractionParse.StaticStruct();
		}

		// Token: 0x06029090 RID: 168080 RVA: 0x009BA2F0 File Offset: 0x009B84F0
		[NullableContext(2)]
		public SInteractionParse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029091 RID: 168081 RVA: 0x009BA2FA File Offset: 0x009B84FA
		public SInteractionParse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029092 RID: 168082 RVA: 0x009BA305 File Offset: 0x009B8505
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractionParse(Pointer, false, true);
		}

		// Token: 0x06029093 RID: 168083 RVA: 0x009BA30F File Offset: 0x009B850F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractionParse(Pointer, MemoryOwner);
		}

		// Token: 0x04014FF5 RID: 86005
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionParse.SInteractionParse";

		// Token: 0x04014FF6 RID: 86006
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014FF7 RID: 86007
		internal static int __PropertyOffset_0;

		// Token: 0x04014FF8 RID: 86008
		internal static int __PropertyOffset_1;
	}
}
