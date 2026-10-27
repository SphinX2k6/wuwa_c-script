using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C6D RID: 15469
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Fog.PCG_LightPrefab_Fog")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class PCG_LightPrefab_Fog : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023DFB RID: 146939 RVA: 0x0092F71B File Offset: 0x0092D91B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Fog._ScriptStructPtr != 0) ? PCG_LightPrefab_Fog._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Fog.PCG_LightPrefab_Fog", ref PCG_LightPrefab_Fog._ScriptStructPtr);
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x06023DFC RID: 146940 RVA: 0x0092F740 File Offset: 0x0092D940
		// (set) Token: 0x06023DFD RID: 146941 RVA: 0x0092F783 File Offset: 0x0092D983
		public FKuroCurveLinearColor 雾效颜色
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._雾效颜色) == null)
				{
					result = (this._雾效颜色 = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Fog.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Fog.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023DFE RID: 146942 RVA: 0x0092F7A4 File Offset: 0x0092D9A4
		public PCG_LightPrefab_Fog()
		{
		}

		// Token: 0x06023DFF RID: 146943 RVA: 0x0092F7AC File Offset: 0x0092D9AC
		public PCG_LightPrefab_Fog(FKuroCurveLinearColor 雾效颜色)
		{
			this.雾效颜色 = 雾效颜色;
		}

		// Token: 0x06023E00 RID: 146944 RVA: 0x0092F7BB File Offset: 0x0092D9BB
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Fog.StaticStruct();
		}

		// Token: 0x06023E01 RID: 146945 RVA: 0x0092F7C7 File Offset: 0x0092D9C7
		[NullableContext(2)]
		public PCG_LightPrefab_Fog(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E02 RID: 146946 RVA: 0x0092F7D1 File Offset: 0x0092D9D1
		public PCG_LightPrefab_Fog(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E03 RID: 146947 RVA: 0x0092F7DC File Offset: 0x0092D9DC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Fog(Pointer, false, true);
		}

		// Token: 0x06023E04 RID: 146948 RVA: 0x0092F7E6 File Offset: 0x0092D9E6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Fog(Pointer, MemoryOwner);
		}

		// Token: 0x04011BE9 RID: 72681
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Fog.PCG_LightPrefab_Fog";

		// Token: 0x04011BEA RID: 72682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BEB RID: 72683
		internal static int __PropertyOffset_0;

		// Token: 0x04011BEC RID: 72684
		[Nullable(2)]
		private FKuroCurveLinearColor _雾效颜色;
	}
}
