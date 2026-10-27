using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043D1 RID: 17361
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SRangeCurve.SRangeCurve")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SRangeCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CF81 RID: 184193 RVA: 0x00A2D6E6 File Offset: 0x00A2B8E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRangeCurve._ScriptStructPtr != 0) ? SRangeCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SRangeCurve.SRangeCurve", ref SRangeCurve._ScriptStructPtr);
		}

		// Token: 0x170071D7 RID: 29143
		// (get) Token: 0x0602CF82 RID: 184194 RVA: 0x00A2D70A File Offset: 0x00A2B90A
		// (set) Token: 0x0602CF83 RID: 184195 RVA: 0x00A2D71A File Offset: 0x00A2B91A
		public unsafe float From
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071D8 RID: 29144
		// (get) Token: 0x0602CF84 RID: 184196 RVA: 0x00A2D72B File Offset: 0x00A2B92B
		// (set) Token: 0x0602CF85 RID: 184197 RVA: 0x00A2D73B File Offset: 0x00A2B93B
		public unsafe float To
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071D9 RID: 29145
		// (get) Token: 0x0602CF86 RID: 184198 RVA: 0x00A2D74C File Offset: 0x00A2B94C
		// (set) Token: 0x0602CF87 RID: 184199 RVA: 0x00A2D78F File Offset: 0x00A2B98F
		public SBaseCurve BaseCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BaseCurve) == null)
				{
					result = (this._BaseCurve = new SBaseCurve(base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SRangeCurve.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CF88 RID: 184200 RVA: 0x00A2D7B0 File Offset: 0x00A2B9B0
		public SRangeCurve()
		{
		}

		// Token: 0x0602CF89 RID: 184201 RVA: 0x00A2D7B8 File Offset: 0x00A2B9B8
		public SRangeCurve(float From, float To, SBaseCurve BaseCurve)
		{
			this.From = From;
			this.To = To;
			this.BaseCurve = BaseCurve;
		}

		// Token: 0x0602CF8A RID: 184202 RVA: 0x00A2D7D5 File Offset: 0x00A2B9D5
		protected override IntPtr GetUStructPtr()
		{
			return SRangeCurve.StaticStruct();
		}

		// Token: 0x0602CF8B RID: 184203 RVA: 0x00A2D7E1 File Offset: 0x00A2B9E1
		[NullableContext(2)]
		public SRangeCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CF8C RID: 184204 RVA: 0x00A2D7EB File Offset: 0x00A2B9EB
		public SRangeCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CF8D RID: 184205 RVA: 0x00A2D7F6 File Offset: 0x00A2B9F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRangeCurve(Pointer, false, true);
		}

		// Token: 0x0602CF8E RID: 184206 RVA: 0x00A2D800 File Offset: 0x00A2BA00
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRangeCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04017DC9 RID: 97737
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SRangeCurve.SRangeCurve";

		// Token: 0x04017DCA RID: 97738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DCB RID: 97739
		internal static int __PropertyOffset_0;

		// Token: 0x04017DCC RID: 97740
		internal static int __PropertyOffset_1;

		// Token: 0x04017DCD RID: 97741
		internal static int __PropertyOffset_2;

		// Token: 0x04017DCE RID: 97742
		[Nullable(2)]
		private SBaseCurve _BaseCurve;
	}
}
