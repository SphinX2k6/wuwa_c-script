using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1A RID: 15898
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class SMaterialControllerFloatGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DA1 RID: 163233 RVA: 0x0099CF42 File Offset: 0x0099B142
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerFloatGroup._ScriptStructPtr != 0) ? SMaterialControllerFloatGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup", ref SMaterialControllerFloatGroup._ScriptStructPtr);
		}

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x06027DA2 RID: 163234 RVA: 0x0099CF68 File Offset: 0x0099B168
		// (set) Token: 0x06027DA3 RID: 163235 RVA: 0x0099CFAB File Offset: 0x0099B1AB
		public FKuroCurveFloat Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x06027DA4 RID: 163236 RVA: 0x0099CFCC File Offset: 0x0099B1CC
		// (set) Token: 0x06027DA5 RID: 163237 RVA: 0x0099D00F File Offset: 0x0099B20F
		public FKuroCurveFloat Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x06027DA6 RID: 163238 RVA: 0x0099D030 File Offset: 0x0099B230
		// (set) Token: 0x06027DA7 RID: 163239 RVA: 0x0099D073 File Offset: 0x0099B273
		public FKuroCurveFloat End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027DA8 RID: 163240 RVA: 0x0099D094 File Offset: 0x0099B294
		public SMaterialControllerFloatGroup()
		{
		}

		// Token: 0x06027DA9 RID: 163241 RVA: 0x0099D09C File Offset: 0x0099B29C
		public SMaterialControllerFloatGroup(FKuroCurveFloat Start, FKuroCurveFloat Loop, FKuroCurveFloat End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x06027DAA RID: 163242 RVA: 0x0099D0B9 File Offset: 0x0099B2B9
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerFloatGroup.StaticStruct();
		}

		// Token: 0x06027DAB RID: 163243 RVA: 0x0099D0C5 File Offset: 0x0099B2C5
		[NullableContext(2)]
		public SMaterialControllerFloatGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027DAC RID: 163244 RVA: 0x0099D0CF File Offset: 0x0099B2CF
		public SMaterialControllerFloatGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027DAD RID: 163245 RVA: 0x0099D0DA File Offset: 0x0099B2DA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerFloatGroup(Pointer, false, true);
		}

		// Token: 0x06027DAE RID: 163246 RVA: 0x0099D0E4 File Offset: 0x0099B2E4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerFloatGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0401433F RID: 82751
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup";

		// Token: 0x04014340 RID: 82752
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014341 RID: 82753
		internal static int __PropertyOffset_0;

		// Token: 0x04014342 RID: 82754
		[Nullable(2)]
		private FKuroCurveFloat _Start;

		// Token: 0x04014343 RID: 82755
		internal static int __PropertyOffset_1;

		// Token: 0x04014344 RID: 82756
		[Nullable(2)]
		private FKuroCurveFloat _Loop;

		// Token: 0x04014345 RID: 82757
		internal static int __PropertyOffset_2;

		// Token: 0x04014346 RID: 82758
		[Nullable(2)]
		private FKuroCurveFloat _End;
	}
}
