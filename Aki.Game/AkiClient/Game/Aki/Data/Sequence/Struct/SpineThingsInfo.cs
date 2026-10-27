using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Sequence.Struct
{
	// Token: 0x02003E98 RID: 16024
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 17)]
	public class SpineThingsInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028833 RID: 165939 RVA: 0x009AE217 File Offset: 0x009AC417
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SpineThingsInfo._ScriptStructPtr != 0) ? SpineThingsInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo", ref SpineThingsInfo._ScriptStructPtr);
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x06028834 RID: 165940 RVA: 0x009AE23B File Offset: 0x009AC43B
		// (set) Token: 0x06028835 RID: 165941 RVA: 0x009AE24F File Offset: 0x009AC44F
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SpineThingsInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SpineThingsInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x06028836 RID: 165942 RVA: 0x009AE264 File Offset: 0x009AC464
		// (set) Token: 0x06028837 RID: 165943 RVA: 0x009AE274 File Offset: 0x009AC474
		public unsafe bool NeedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SpineThingsInfo.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SpineThingsInfo.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028838 RID: 165944 RVA: 0x009AE285 File Offset: 0x009AC485
		public SpineThingsInfo()
		{
		}

		// Token: 0x06028839 RID: 165945 RVA: 0x009AE28D File Offset: 0x009AC48D
		public SpineThingsInfo(string Name, bool NeedLoop)
		{
			this.Name = Name;
			this.NeedLoop = NeedLoop;
		}

		// Token: 0x0602883A RID: 165946 RVA: 0x009AE2A3 File Offset: 0x009AC4A3
		protected override IntPtr GetUStructPtr()
		{
			return SpineThingsInfo.StaticStruct();
		}

		// Token: 0x0602883B RID: 165947 RVA: 0x009AE2AF File Offset: 0x009AC4AF
		[NullableContext(2)]
		public SpineThingsInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602883C RID: 165948 RVA: 0x009AE2B9 File Offset: 0x009AC4B9
		public SpineThingsInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602883D RID: 165949 RVA: 0x009AE2C4 File Offset: 0x009AC4C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SpineThingsInfo(Pointer, false, true);
		}

		// Token: 0x0602883E RID: 165950 RVA: 0x009AE2CE File Offset: 0x009AC4CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SpineThingsInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AA3 RID: 84643
		public const string __ObjectPath = "/Game/Aki/Data/Sequence/Struct/SpineThingsInfo.SpineThingsInfo";

		// Token: 0x04014AA4 RID: 84644
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AA5 RID: 84645
		internal static int __PropertyOffset_0;

		// Token: 0x04014AA6 RID: 84646
		internal static int __PropertyOffset_1;
	}
}
