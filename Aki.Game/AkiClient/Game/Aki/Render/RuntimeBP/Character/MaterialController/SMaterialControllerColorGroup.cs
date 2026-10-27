using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E18 RID: 15896
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1632)]
	public class SMaterialControllerColorGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027D87 RID: 163207 RVA: 0x0099CC94 File Offset: 0x0099AE94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerColorGroup._ScriptStructPtr != 0) ? SMaterialControllerColorGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup", ref SMaterialControllerColorGroup._ScriptStructPtr);
		}

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x06027D88 RID: 163208 RVA: 0x0099CCB8 File Offset: 0x0099AEB8
		// (set) Token: 0x06027D89 RID: 163209 RVA: 0x0099CCFB File Offset: 0x0099AEFB
		public FKuroCurveLinearColor Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x06027D8A RID: 163210 RVA: 0x0099CD1C File Offset: 0x0099AF1C
		// (set) Token: 0x06027D8B RID: 163211 RVA: 0x0099CD5F File Offset: 0x0099AF5F
		public FKuroCurveLinearColor Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x06027D8C RID: 163212 RVA: 0x0099CD80 File Offset: 0x0099AF80
		// (set) Token: 0x06027D8D RID: 163213 RVA: 0x0099CDC3 File Offset: 0x0099AFC3
		public FKuroCurveLinearColor End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027D8E RID: 163214 RVA: 0x0099CDE4 File Offset: 0x0099AFE4
		public SMaterialControllerColorGroup()
		{
		}

		// Token: 0x06027D8F RID: 163215 RVA: 0x0099CDEC File Offset: 0x0099AFEC
		public SMaterialControllerColorGroup(FKuroCurveLinearColor Start, FKuroCurveLinearColor Loop, FKuroCurveLinearColor End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x06027D90 RID: 163216 RVA: 0x0099CE09 File Offset: 0x0099B009
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerColorGroup.StaticStruct();
		}

		// Token: 0x06027D91 RID: 163217 RVA: 0x0099CE15 File Offset: 0x0099B015
		[NullableContext(2)]
		public SMaterialControllerColorGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027D92 RID: 163218 RVA: 0x0099CE1F File Offset: 0x0099B01F
		public SMaterialControllerColorGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027D93 RID: 163219 RVA: 0x0099CE2A File Offset: 0x0099B02A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerColorGroup(Pointer, false, true);
		}

		// Token: 0x06027D94 RID: 163220 RVA: 0x0099CE34 File Offset: 0x0099B034
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerColorGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04014332 RID: 82738
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup";

		// Token: 0x04014333 RID: 82739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014334 RID: 82740
		internal static int __PropertyOffset_0;

		// Token: 0x04014335 RID: 82741
		[Nullable(2)]
		private FKuroCurveLinearColor _Start;

		// Token: 0x04014336 RID: 82742
		internal static int __PropertyOffset_1;

		// Token: 0x04014337 RID: 82743
		[Nullable(2)]
		private FKuroCurveLinearColor _Loop;

		// Token: 0x04014338 RID: 82744
		internal static int __PropertyOffset_2;

		// Token: 0x04014339 RID: 82745
		[Nullable(2)]
		private FKuroCurveLinearColor _End;
	}
}
