using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C6B RID: 15467
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Decal.PCG_LightPrefab_Decal")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class PCG_LightPrefab_Decal : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023DE7 RID: 146919 RVA: 0x0092F574 File Offset: 0x0092D774
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Decal._ScriptStructPtr != 0) ? PCG_LightPrefab_Decal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Decal.PCG_LightPrefab_Decal", ref PCG_LightPrefab_Decal._ScriptStructPtr);
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x06023DE8 RID: 146920 RVA: 0x0092F598 File Offset: 0x0092D798
		// (set) Token: 0x06023DE9 RID: 146921 RVA: 0x0092F5DB File Offset: 0x0092D7DB
		public FKuroCurveLinearColor 贴花颜色
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._贴花颜色) == null)
				{
					result = (this._贴花颜色 = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Decal.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Decal.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023DEA RID: 146922 RVA: 0x0092F5FC File Offset: 0x0092D7FC
		public PCG_LightPrefab_Decal()
		{
		}

		// Token: 0x06023DEB RID: 146923 RVA: 0x0092F604 File Offset: 0x0092D804
		public PCG_LightPrefab_Decal(FKuroCurveLinearColor 贴花颜色)
		{
			this.贴花颜色 = 贴花颜色;
		}

		// Token: 0x06023DEC RID: 146924 RVA: 0x0092F613 File Offset: 0x0092D813
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Decal.StaticStruct();
		}

		// Token: 0x06023DED RID: 146925 RVA: 0x0092F61F File Offset: 0x0092D81F
		[NullableContext(2)]
		public PCG_LightPrefab_Decal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023DEE RID: 146926 RVA: 0x0092F629 File Offset: 0x0092D829
		public PCG_LightPrefab_Decal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023DEF RID: 146927 RVA: 0x0092F634 File Offset: 0x0092D834
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Decal(Pointer, false, true);
		}

		// Token: 0x06023DF0 RID: 146928 RVA: 0x0092F63E File Offset: 0x0092D83E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Decal(Pointer, MemoryOwner);
		}

		// Token: 0x04011BE1 RID: 72673
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Decal.PCG_LightPrefab_Decal";

		// Token: 0x04011BE2 RID: 72674
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BE3 RID: 72675
		internal static int __PropertyOffset_0;

		// Token: 0x04011BE4 RID: 72676
		[Nullable(2)]
		private FKuroCurveLinearColor _贴花颜色;
	}
}
