using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200431D RID: 17181
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 25)]
	public class SHitWhirlpool : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C78C RID: 182156 RVA: 0x00A2086B File Offset: 0x00A1EA6B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitWhirlpool._ScriptStructPtr != 0) ? SHitWhirlpool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool", ref SHitWhirlpool._ScriptStructPtr);
		}

		// Token: 0x17006F6D RID: 28525
		// (get) Token: 0x0602C78D RID: 182157 RVA: 0x00A2088F File Offset: 0x00A1EA8F
		// (set) Token: 0x0602C78E RID: 182158 RVA: 0x00A208A3 File Offset: 0x00A1EAA3
		public unsafe FVector 滞空相对位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F6E RID: 28526
		// (get) Token: 0x0602C78F RID: 182159 RVA: 0x00A208B8 File Offset: 0x00A1EAB8
		// (set) Token: 0x0602C790 RID: 182160 RVA: 0x00A208C8 File Offset: 0x00A1EAC8
		public unsafe float 滞空时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F6F RID: 28527
		// (get) Token: 0x0602C791 RID: 182161 RVA: 0x00A208D9 File Offset: 0x00A1EAD9
		// (set) Token: 0x0602C792 RID: 182162 RVA: 0x00A208E9 File Offset: 0x00A1EAE9
		public unsafe float 到滞空点时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F70 RID: 28528
		// (get) Token: 0x0602C793 RID: 182163 RVA: 0x00A208FA File Offset: 0x00A1EAFA
		// (set) Token: 0x0602C794 RID: 182164 RVA: 0x00A2090A File Offset: 0x00A1EB0A
		public unsafe float 滞空高度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F71 RID: 28529
		// (get) Token: 0x0602C795 RID: 182165 RVA: 0x00A2091B File Offset: 0x00A1EB1B
		// (set) Token: 0x0602C796 RID: 182166 RVA: 0x00A2092F File Offset: 0x00A1EB2F
		public unsafe TEnumAsByte<EVelocityCurveType> 到滞空点曲线
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitWhirlpool.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602C797 RID: 182167 RVA: 0x00A20944 File Offset: 0x00A1EB44
		public SHitWhirlpool()
		{
		}

		// Token: 0x0602C798 RID: 182168 RVA: 0x00A2094C File Offset: 0x00A1EB4C
		public SHitWhirlpool(FVector 滞空相对位置, float 滞空时间, float 到滞空点时间, float 滞空高度限制, TEnumAsByte<EVelocityCurveType> 到滞空点曲线)
		{
			this.滞空相对位置 = 滞空相对位置;
			this.滞空时间 = 滞空时间;
			this.到滞空点时间 = 到滞空点时间;
			this.滞空高度限制 = 滞空高度限制;
			this.到滞空点曲线 = 到滞空点曲线;
		}

		// Token: 0x0602C799 RID: 182169 RVA: 0x00A20979 File Offset: 0x00A1EB79
		protected override IntPtr GetUStructPtr()
		{
			return SHitWhirlpool.StaticStruct();
		}

		// Token: 0x0602C79A RID: 182170 RVA: 0x00A20985 File Offset: 0x00A1EB85
		[NullableContext(2)]
		public SHitWhirlpool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C79B RID: 182171 RVA: 0x00A2098F File Offset: 0x00A1EB8F
		public SHitWhirlpool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C79C RID: 182172 RVA: 0x00A2099A File Offset: 0x00A1EB9A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitWhirlpool(Pointer, false, true);
		}

		// Token: 0x0602C79D RID: 182173 RVA: 0x00A209A4 File Offset: 0x00A1EBA4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitWhirlpool(Pointer, MemoryOwner);
		}

		// Token: 0x0401771A RID: 96026
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitWhirlpool.SHitWhirlpool";

		// Token: 0x0401771B RID: 96027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401771C RID: 96028
		internal static int __PropertyOffset_0;

		// Token: 0x0401771D RID: 96029
		internal static int __PropertyOffset_1;

		// Token: 0x0401771E RID: 96030
		internal static int __PropertyOffset_2;

		// Token: 0x0401771F RID: 96031
		internal static int __PropertyOffset_3;

		// Token: 0x04017720 RID: 96032
		internal static int __PropertyOffset_4;
	}
}
