using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D23 RID: 15651
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/SKuroInteractionLimbsConfig.SKuroInteractionLimbsConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SKuroInteractionLimbsConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025981 RID: 153985 RVA: 0x0095E13E File Offset: 0x0095C33E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SKuroInteractionLimbsConfig._ScriptStructPtr != 0) ? SKuroInteractionLimbsConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Interaction/SKuroInteractionLimbsConfig.SKuroInteractionLimbsConfig", ref SKuroInteractionLimbsConfig._ScriptStructPtr);
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06025982 RID: 153986 RVA: 0x0095E162 File Offset: 0x0095C362
		// (set) Token: 0x06025983 RID: 153987 RVA: 0x0095E176 File Offset: 0x0095C376
		public unsafe FName 插槽名字
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06025984 RID: 153988 RVA: 0x0095E18B File Offset: 0x0095C38B
		// (set) Token: 0x06025985 RID: 153989 RVA: 0x0095E19F File Offset: 0x0095C39F
		public unsafe FVector 相对位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x06025986 RID: 153990 RVA: 0x0095E1B4 File Offset: 0x0095C3B4
		// (set) Token: 0x06025987 RID: 153991 RVA: 0x0095E1C4 File Offset: 0x0095C3C4
		public unsafe float 半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x06025988 RID: 153992 RVA: 0x0095E1D5 File Offset: 0x0095C3D5
		// (set) Token: 0x06025989 RID: 153993 RVA: 0x0095E1E5 File Offset: 0x0095C3E5
		public unsafe float 半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x0602598A RID: 153994 RVA: 0x0095E1F8 File Offset: 0x0095C3F8
		// (set) Token: 0x0602598B RID: 153995 RVA: 0x0095E23B File Offset: 0x0095C43B
		public FSoftObjectPath 交互配置
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._交互配置) == null)
				{
					result = (this._交互配置 = new FSoftObjectPath(base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SKuroInteractionLimbsConfig.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602598C RID: 153996 RVA: 0x0095E25C File Offset: 0x0095C45C
		public SKuroInteractionLimbsConfig()
		{
		}

		// Token: 0x0602598D RID: 153997 RVA: 0x0095E264 File Offset: 0x0095C464
		public SKuroInteractionLimbsConfig(FName 插槽名字, FVector 相对位置, float 半径, float 半高, FSoftObjectPath 交互配置)
		{
			this.插槽名字 = 插槽名字;
			this.相对位置 = 相对位置;
			this.半径 = 半径;
			this.半高 = 半高;
			this.交互配置 = 交互配置;
		}

		// Token: 0x0602598E RID: 153998 RVA: 0x0095E291 File Offset: 0x0095C491
		protected override IntPtr GetUStructPtr()
		{
			return SKuroInteractionLimbsConfig.StaticStruct();
		}

		// Token: 0x0602598F RID: 153999 RVA: 0x0095E29D File Offset: 0x0095C49D
		[NullableContext(2)]
		public SKuroInteractionLimbsConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025990 RID: 154000 RVA: 0x0095E2A7 File Offset: 0x0095C4A7
		public SKuroInteractionLimbsConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025991 RID: 154001 RVA: 0x0095E2B2 File Offset: 0x0095C4B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SKuroInteractionLimbsConfig(Pointer, false, true);
		}

		// Token: 0x06025992 RID: 154002 RVA: 0x0095E2BC File Offset: 0x0095C4BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SKuroInteractionLimbsConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04012C59 RID: 76889
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/SKuroInteractionLimbsConfig.SKuroInteractionLimbsConfig";

		// Token: 0x04012C5A RID: 76890
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012C5B RID: 76891
		internal static int __PropertyOffset_0;

		// Token: 0x04012C5C RID: 76892
		internal static int __PropertyOffset_1;

		// Token: 0x04012C5D RID: 76893
		internal static int __PropertyOffset_2;

		// Token: 0x04012C5E RID: 76894
		internal static int __PropertyOffset_3;

		// Token: 0x04012C5F RID: 76895
		internal static int __PropertyOffset_4;

		// Token: 0x04012C60 RID: 76896
		[Nullable(2)]
		private FSoftObjectPath _交互配置;
	}
}
