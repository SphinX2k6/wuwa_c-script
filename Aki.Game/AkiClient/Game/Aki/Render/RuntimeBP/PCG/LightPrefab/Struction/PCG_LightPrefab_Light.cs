using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C6E RID: 15470
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Light.PCG_LightPrefab_Light")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class PCG_LightPrefab_Light : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E05 RID: 146949 RVA: 0x0092F7EF File Offset: 0x0092D9EF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Light._ScriptStructPtr != 0) ? PCG_LightPrefab_Light._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Light.PCG_LightPrefab_Light", ref PCG_LightPrefab_Light._ScriptStructPtr);
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x06023E06 RID: 146950 RVA: 0x0092F814 File Offset: 0x0092DA14
		// (set) Token: 0x06023E07 RID: 146951 RVA: 0x0092F857 File Offset: 0x0092DA57
		public FKuroCurveFloat 灯光强度
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光强度) == null)
				{
					result = (this._灯光强度 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PCG_LightPrefab_Light.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Light.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x06023E08 RID: 146952 RVA: 0x0092F878 File Offset: 0x0092DA78
		// (set) Token: 0x06023E09 RID: 146953 RVA: 0x0092F8BB File Offset: 0x0092DABB
		public FKuroCurveLinearColor 灯光颜色
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._灯光颜色) == null)
				{
					result = (this._灯光颜色 = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Light.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Light.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023E0A RID: 146954 RVA: 0x0092F8DC File Offset: 0x0092DADC
		public PCG_LightPrefab_Light()
		{
		}

		// Token: 0x06023E0B RID: 146955 RVA: 0x0092F8E4 File Offset: 0x0092DAE4
		public PCG_LightPrefab_Light(FKuroCurveFloat 灯光强度, FKuroCurveLinearColor 灯光颜色)
		{
			this.灯光强度 = 灯光强度;
			this.灯光颜色 = 灯光颜色;
		}

		// Token: 0x06023E0C RID: 146956 RVA: 0x0092F8FA File Offset: 0x0092DAFA
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Light.StaticStruct();
		}

		// Token: 0x06023E0D RID: 146957 RVA: 0x0092F906 File Offset: 0x0092DB06
		[NullableContext(2)]
		public PCG_LightPrefab_Light(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E0E RID: 146958 RVA: 0x0092F910 File Offset: 0x0092DB10
		public PCG_LightPrefab_Light(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E0F RID: 146959 RVA: 0x0092F91B File Offset: 0x0092DB1B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Light(Pointer, false, true);
		}

		// Token: 0x06023E10 RID: 146960 RVA: 0x0092F925 File Offset: 0x0092DB25
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Light(Pointer, MemoryOwner);
		}

		// Token: 0x04011BED RID: 72685
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Light.PCG_LightPrefab_Light";

		// Token: 0x04011BEE RID: 72686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BEF RID: 72687
		internal static int __PropertyOffset_0;

		// Token: 0x04011BF0 RID: 72688
		[Nullable(2)]
		private FKuroCurveFloat _灯光强度;

		// Token: 0x04011BF1 RID: 72689
		internal static int __PropertyOffset_1;

		// Token: 0x04011BF2 RID: 72690
		[Nullable(2)]
		private FKuroCurveLinearColor _灯光颜色;
	}
}
