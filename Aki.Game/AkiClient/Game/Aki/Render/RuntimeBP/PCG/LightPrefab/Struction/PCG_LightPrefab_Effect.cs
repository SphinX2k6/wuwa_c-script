using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C6C RID: 15468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Effect.PCG_LightPrefab_Effect")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class PCG_LightPrefab_Effect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023DF1 RID: 146929 RVA: 0x0092F647 File Offset: 0x0092D847
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Effect._ScriptStructPtr != 0) ? PCG_LightPrefab_Effect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Effect.PCG_LightPrefab_Effect", ref PCG_LightPrefab_Effect._ScriptStructPtr);
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x06023DF2 RID: 146930 RVA: 0x0092F66C File Offset: 0x0092D86C
		// (set) Token: 0x06023DF3 RID: 146931 RVA: 0x0092F6AF File Offset: 0x0092D8AF
		public FKuroCurveLinearColor 特效颜色
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._特效颜色) == null)
				{
					result = (this._特效颜色 = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Effect.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Effect.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023DF4 RID: 146932 RVA: 0x0092F6D0 File Offset: 0x0092D8D0
		public PCG_LightPrefab_Effect()
		{
		}

		// Token: 0x06023DF5 RID: 146933 RVA: 0x0092F6D8 File Offset: 0x0092D8D8
		public PCG_LightPrefab_Effect(FKuroCurveLinearColor 特效颜色)
		{
			this.特效颜色 = 特效颜色;
		}

		// Token: 0x06023DF6 RID: 146934 RVA: 0x0092F6E7 File Offset: 0x0092D8E7
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Effect.StaticStruct();
		}

		// Token: 0x06023DF7 RID: 146935 RVA: 0x0092F6F3 File Offset: 0x0092D8F3
		[NullableContext(2)]
		public PCG_LightPrefab_Effect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023DF8 RID: 146936 RVA: 0x0092F6FD File Offset: 0x0092D8FD
		public PCG_LightPrefab_Effect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023DF9 RID: 146937 RVA: 0x0092F708 File Offset: 0x0092D908
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Effect(Pointer, false, true);
		}

		// Token: 0x06023DFA RID: 146938 RVA: 0x0092F712 File Offset: 0x0092D912
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Effect(Pointer, MemoryOwner);
		}

		// Token: 0x04011BE5 RID: 72677
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Effect.PCG_LightPrefab_Effect";

		// Token: 0x04011BE6 RID: 72678
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BE7 RID: 72679
		internal static int __PropertyOffset_0;

		// Token: 0x04011BE8 RID: 72680
		[Nullable(2)]
		private FKuroCurveLinearColor _特效颜色;
	}
}
