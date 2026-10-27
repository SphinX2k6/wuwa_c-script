using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Scene3DUI.Struct
{
	// Token: 0x02003E9A RID: 16026
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Scene3DUI/Struct/SSceneUITagConfig.SSceneUITagConfig")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSceneUITagConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602884D RID: 165965 RVA: 0x009AE3CF File Offset: 0x009AC5CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneUITagConfig._ScriptStructPtr != 0) ? SSceneUITagConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Scene3DUI/Struct/SSceneUITagConfig.SSceneUITagConfig", ref SSceneUITagConfig._ScriptStructPtr);
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x0602884E RID: 165966 RVA: 0x009AE3F3 File Offset: 0x009AC5F3
		// (set) Token: 0x0602884F RID: 165967 RVA: 0x009AE407 File Offset: 0x009AC607
		public unsafe string DecorativeID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneUITagConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneUITagConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x06028850 RID: 165968 RVA: 0x009AE41C File Offset: 0x009AC61C
		public SSceneUITagConfig()
		{
		}

		// Token: 0x06028851 RID: 165969 RVA: 0x009AE424 File Offset: 0x009AC624
		public SSceneUITagConfig(string DecorativeID)
		{
			this.DecorativeID = DecorativeID;
		}

		// Token: 0x06028852 RID: 165970 RVA: 0x009AE433 File Offset: 0x009AC633
		protected override IntPtr GetUStructPtr()
		{
			return SSceneUITagConfig.StaticStruct();
		}

		// Token: 0x06028853 RID: 165971 RVA: 0x009AE43F File Offset: 0x009AC63F
		[NullableContext(2)]
		public SSceneUITagConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028854 RID: 165972 RVA: 0x009AE449 File Offset: 0x009AC649
		public SSceneUITagConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028855 RID: 165973 RVA: 0x009AE454 File Offset: 0x009AC654
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneUITagConfig(Pointer, false, true);
		}

		// Token: 0x06028856 RID: 165974 RVA: 0x009AE45E File Offset: 0x009AC65E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneUITagConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014AAC RID: 84652
		public const string __ObjectPath = "/Game/Aki/Data/Scene3DUI/Struct/SSceneUITagConfig.SSceneUITagConfig";

		// Token: 0x04014AAD RID: 84653
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AAE RID: 84654
		internal static int __PropertyOffset_0;
	}
}
