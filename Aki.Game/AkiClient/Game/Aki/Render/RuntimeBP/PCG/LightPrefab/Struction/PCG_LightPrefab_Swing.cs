using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C71 RID: 15473
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Swing.PCG_LightPrefab_Swing")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class PCG_LightPrefab_Swing : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E39 RID: 147001 RVA: 0x0092FE03 File Offset: 0x0092E003
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Swing._ScriptStructPtr != 0) ? PCG_LightPrefab_Swing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Swing.PCG_LightPrefab_Swing", ref PCG_LightPrefab_Swing._ScriptStructPtr);
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x06023E3A RID: 147002 RVA: 0x0092FE27 File Offset: 0x0092E027
		// (set) Token: 0x06023E3B RID: 147003 RVA: 0x0092FE37 File Offset: 0x0092E037
		public unsafe bool 开启摆动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x06023E3C RID: 147004 RVA: 0x0092FE48 File Offset: 0x0092E048
		// (set) Token: 0x06023E3D RID: 147005 RVA: 0x0092FE5C File Offset: 0x0092E05C
		public unsafe FVector 摆动方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x06023E3E RID: 147006 RVA: 0x0092FE71 File Offset: 0x0092E071
		// (set) Token: 0x06023E3F RID: 147007 RVA: 0x0092FE81 File Offset: 0x0092E081
		public unsafe float 摆动幅度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x06023E40 RID: 147008 RVA: 0x0092FE92 File Offset: 0x0092E092
		// (set) Token: 0x06023E41 RID: 147009 RVA: 0x0092FEA2 File Offset: 0x0092E0A2
		public unsafe float 摆动频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Swing.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06023E42 RID: 147010 RVA: 0x0092FEB3 File Offset: 0x0092E0B3
		public PCG_LightPrefab_Swing()
		{
		}

		// Token: 0x06023E43 RID: 147011 RVA: 0x0092FEBB File Offset: 0x0092E0BB
		public PCG_LightPrefab_Swing(bool 开启摆动, FVector 摆动方向, float 摆动幅度, float 摆动频率)
		{
			this.开启摆动 = 开启摆动;
			this.摆动方向 = 摆动方向;
			this.摆动幅度 = 摆动幅度;
			this.摆动频率 = 摆动频率;
		}

		// Token: 0x06023E44 RID: 147012 RVA: 0x0092FEE0 File Offset: 0x0092E0E0
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Swing.StaticStruct();
		}

		// Token: 0x06023E45 RID: 147013 RVA: 0x0092FEEC File Offset: 0x0092E0EC
		[NullableContext(2)]
		public PCG_LightPrefab_Swing(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E46 RID: 147014 RVA: 0x0092FEF6 File Offset: 0x0092E0F6
		public PCG_LightPrefab_Swing(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E47 RID: 147015 RVA: 0x0092FF01 File Offset: 0x0092E101
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Swing(Pointer, false, true);
		}

		// Token: 0x06023E48 RID: 147016 RVA: 0x0092FF0B File Offset: 0x0092E10B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Swing(Pointer, MemoryOwner);
		}

		// Token: 0x04011C0E RID: 72718
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Swing.PCG_LightPrefab_Swing";

		// Token: 0x04011C0F RID: 72719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C10 RID: 72720
		internal static int __PropertyOffset_0;

		// Token: 0x04011C11 RID: 72721
		internal static int __PropertyOffset_1;

		// Token: 0x04011C12 RID: 72722
		internal static int __PropertyOffset_2;

		// Token: 0x04011C13 RID: 72723
		internal static int __PropertyOffset_3;
	}
}
