using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D68 RID: 15720
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SMountainParameters.SMountainParameters")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class SMountainParameters : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026916 RID: 157974 RVA: 0x009788C2 File Offset: 0x00976AC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMountainParameters._ScriptStructPtr != 0) ? SMountainParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SMountainParameters.SMountainParameters", ref SMountainParameters._ScriptStructPtr);
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x06026917 RID: 157975 RVA: 0x009788E6 File Offset: 0x00976AE6
		// (set) Token: 0x06026918 RID: 157976 RVA: 0x009788F6 File Offset: 0x00976AF6
		public unsafe bool HasMountain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMountainParameters.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMountainParameters.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026919 RID: 157977 RVA: 0x00978907 File Offset: 0x00976B07
		public SMountainParameters()
		{
		}

		// Token: 0x0602691A RID: 157978 RVA: 0x0097890F File Offset: 0x00976B0F
		public SMountainParameters(bool HasMountain)
		{
			this.HasMountain = HasMountain;
		}

		// Token: 0x0602691B RID: 157979 RVA: 0x0097891E File Offset: 0x00976B1E
		protected override IntPtr GetUStructPtr()
		{
			return SMountainParameters.StaticStruct();
		}

		// Token: 0x0602691C RID: 157980 RVA: 0x0097892A File Offset: 0x00976B2A
		[NullableContext(2)]
		public SMountainParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602691D RID: 157981 RVA: 0x00978934 File Offset: 0x00976B34
		public SMountainParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602691E RID: 157982 RVA: 0x0097893F File Offset: 0x00976B3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMountainParameters(Pointer, false, true);
		}

		// Token: 0x0602691F RID: 157983 RVA: 0x00978949 File Offset: 0x00976B49
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMountainParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0401361E RID: 79390
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SMountainParameters.SMountainParameters";

		// Token: 0x0401361F RID: 79391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013620 RID: 79392
		internal static int __PropertyOffset_0;
	}
}
