using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AED RID: 15085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/S_SE_ControllerCommon.S_SE_ControllerCommon")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 33)]
	public class S_SE_ControllerCommon : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020A9F RID: 133791 RVA: 0x008D95D7 File Offset: 0x008D77D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_SE_ControllerCommon._ScriptStructPtr != 0) ? S_SE_ControllerCommon._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/S_SE_ControllerCommon.S_SE_ControllerCommon", ref S_SE_ControllerCommon._ScriptStructPtr);
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x06020AA0 RID: 133792 RVA: 0x008D95FC File Offset: 0x008D77FC
		// (set) Token: 0x06020AA1 RID: 133793 RVA: 0x008D963F File Offset: 0x008D783F
		public TArray<SMaterialControllerFloatParameter> CustomFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._CustomFloats) == null)
				{
					result = (this._CustomFloats = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)S_SE_ControllerCommon.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloats.CopyAssign(value);
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x06020AA2 RID: 133794 RVA: 0x008D9650 File Offset: 0x008D7850
		// (set) Token: 0x06020AA3 RID: 133795 RVA: 0x008D9693 File Offset: 0x008D7893
		public TArray<SMaterialControllerColorParameter> CustomColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._CustomColors) == null)
				{
					result = (this._CustomColors = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)S_SE_ControllerCommon.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomColors.CopyAssign(value);
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x06020AA4 RID: 133796 RVA: 0x008D96A1 File Offset: 0x008D78A1
		// (set) Token: 0x06020AA5 RID: 133797 RVA: 0x008D96B1 File Offset: 0x008D78B1
		public unsafe bool bActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SE_ControllerCommon.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SE_ControllerCommon.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020AA6 RID: 133798 RVA: 0x008D96C2 File Offset: 0x008D78C2
		public S_SE_ControllerCommon()
		{
		}

		// Token: 0x06020AA7 RID: 133799 RVA: 0x008D96CA File Offset: 0x008D78CA
		public S_SE_ControllerCommon(TArray<SMaterialControllerFloatParameter> CustomFloats, TArray<SMaterialControllerColorParameter> CustomColors, bool bActive)
		{
			this.CustomFloats = CustomFloats;
			this.CustomColors = CustomColors;
			this.bActive = bActive;
		}

		// Token: 0x06020AA8 RID: 133800 RVA: 0x008D96E7 File Offset: 0x008D78E7
		protected override IntPtr GetUStructPtr()
		{
			return S_SE_ControllerCommon.StaticStruct();
		}

		// Token: 0x06020AA9 RID: 133801 RVA: 0x008D96F3 File Offset: 0x008D78F3
		[NullableContext(2)]
		public S_SE_ControllerCommon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020AAA RID: 133802 RVA: 0x008D96FD File Offset: 0x008D78FD
		public S_SE_ControllerCommon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020AAB RID: 133803 RVA: 0x008D9708 File Offset: 0x008D7908
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_SE_ControllerCommon(Pointer, false, true);
		}

		// Token: 0x06020AAC RID: 133804 RVA: 0x008D9712 File Offset: 0x008D7912
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_SE_ControllerCommon(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD9E RID: 64926
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/S_SE_ControllerCommon.S_SE_ControllerCommon";

		// Token: 0x0400FD9F RID: 64927
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDA0 RID: 64928
		internal static int __PropertyOffset_0;

		// Token: 0x0400FDA1 RID: 64929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _CustomFloats;

		// Token: 0x0400FDA2 RID: 64930
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDA3 RID: 64931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _CustomColors;

		// Token: 0x0400FDA4 RID: 64932
		internal static int __PropertyOffset_2;
	}
}
