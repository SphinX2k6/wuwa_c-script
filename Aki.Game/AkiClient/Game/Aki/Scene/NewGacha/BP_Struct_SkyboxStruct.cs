using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha
{
	// Token: 0x02003A45 RID: 14917
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP_Struct_SkyboxStruct.BP_Struct_SkyboxStruct")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class BP_Struct_SkyboxStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F723 RID: 128803 RVA: 0x008B898B File Offset: 0x008B6B8B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BP_Struct_SkyboxStruct._ScriptStructPtr != 0) ? BP_Struct_SkyboxStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/NewGacha/BP_Struct_SkyboxStruct.BP_Struct_SkyboxStruct", ref BP_Struct_SkyboxStruct._ScriptStructPtr);
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0601F724 RID: 128804 RVA: 0x008B89AF File Offset: 0x008B6BAF
		// (set) Token: 0x0601F725 RID: 128805 RVA: 0x008B89C3 File Offset: 0x008B6BC3
		public unsafe string WeatherDataAsset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0601F726 RID: 128806 RVA: 0x008B89D8 File Offset: 0x008B6BD8
		// (set) Token: 0x0601F727 RID: 128807 RVA: 0x008B89EC File Offset: 0x008B6BEC
		public unsafe string PPTODDataAsset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0601F728 RID: 128808 RVA: 0x008B8A01 File Offset: 0x008B6C01
		// (set) Token: 0x0601F729 RID: 128809 RVA: 0x008B8A11 File Offset: 0x008B6C11
		public unsafe int SkyboxSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0601F72A RID: 128810 RVA: 0x008B8A22 File Offset: 0x008B6C22
		// (set) Token: 0x0601F72B RID: 128811 RVA: 0x008B8A32 File Offset: 0x008B6C32
		public unsafe float FadeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0601F72C RID: 128812 RVA: 0x008B8A43 File Offset: 0x008B6C43
		// (set) Token: 0x0601F72D RID: 128813 RVA: 0x008B8A53 File Offset: 0x008B6C53
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0601F72E RID: 128814 RVA: 0x008B8A64 File Offset: 0x008B6C64
		// (set) Token: 0x0601F72F RID: 128815 RVA: 0x008B8A78 File Offset: 0x008B6C78
		public unsafe string TriggerMode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Struct_SkyboxStruct.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x0601F730 RID: 128816 RVA: 0x008B8A8D File Offset: 0x008B6C8D
		public BP_Struct_SkyboxStruct()
		{
		}

		// Token: 0x0601F731 RID: 128817 RVA: 0x008B8A95 File Offset: 0x008B6C95
		public BP_Struct_SkyboxStruct(string WeatherDataAsset, string PPTODDataAsset, int SkyboxSetting, float FadeTime, float Priority, string TriggerMode)
		{
			this.WeatherDataAsset = WeatherDataAsset;
			this.PPTODDataAsset = PPTODDataAsset;
			this.SkyboxSetting = SkyboxSetting;
			this.FadeTime = FadeTime;
			this.Priority = Priority;
			this.TriggerMode = TriggerMode;
		}

		// Token: 0x0601F732 RID: 128818 RVA: 0x008B8ACA File Offset: 0x008B6CCA
		protected override IntPtr GetUStructPtr()
		{
			return BP_Struct_SkyboxStruct.StaticStruct();
		}

		// Token: 0x0601F733 RID: 128819 RVA: 0x008B8AD6 File Offset: 0x008B6CD6
		[NullableContext(2)]
		public BP_Struct_SkyboxStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F734 RID: 128820 RVA: 0x008B8AE0 File Offset: 0x008B6CE0
		public BP_Struct_SkyboxStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F735 RID: 128821 RVA: 0x008B8AEB File Offset: 0x008B6CEB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BP_Struct_SkyboxStruct(Pointer, false, true);
		}

		// Token: 0x0601F736 RID: 128822 RVA: 0x008B8AF5 File Offset: 0x008B6CF5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BP_Struct_SkyboxStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400F1B1 RID: 61873
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP_Struct_SkyboxStruct.BP_Struct_SkyboxStruct";

		// Token: 0x0400F1B2 RID: 61874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F1B3 RID: 61875
		internal static int __PropertyOffset_0;

		// Token: 0x0400F1B4 RID: 61876
		internal static int __PropertyOffset_1;

		// Token: 0x0400F1B5 RID: 61877
		internal static int __PropertyOffset_2;

		// Token: 0x0400F1B6 RID: 61878
		internal static int __PropertyOffset_3;

		// Token: 0x0400F1B7 RID: 61879
		internal static int __PropertyOffset_4;

		// Token: 0x0400F1B8 RID: 61880
		internal static int __PropertyOffset_5;
	}
}
