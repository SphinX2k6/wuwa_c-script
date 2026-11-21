using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031EE RID: 12782
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SMotorRailMove_EventHandler : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FCA7 RID: 130215 RVA: 0x00935CDE File Offset: 0x00933EDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_EventHandler._ScriptStructPtr != 0) ? SMotorRailMove_EventHandler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler", ref SMotorRailMove_EventHandler._ScriptStructPtr);
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0601FCA8 RID: 130216 RVA: 0x00935D04 File Offset: 0x00933F04
		// (set) Token: 0x0601FCA9 RID: 130217 RVA: 0x00935D47 File Offset: 0x00933F47
		public TMap<int, bool> ModifyCues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._ModifyCues) == null)
				{
					result = (this._ModifyCues = new TMap<int, bool>(base.NativePtr + (IntPtr)SMotorRailMove_EventHandler.__PropertyOffset_ModifyCues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyCues.CopyAssign(value);
			}
		}

		// Token: 0x0601FCAA RID: 130218 RVA: 0x00935D55 File Offset: 0x00933F55
		public SMotorRailMove_EventHandler()
		{
		}

		// Token: 0x0601FCAB RID: 130219 RVA: 0x00935D5D File Offset: 0x00933F5D
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMove_EventHandler.StaticStruct();
		}

		// Token: 0x0601FCAC RID: 130220 RVA: 0x00935D69 File Offset: 0x00933F69
		[NullableContext(2)]
		public SMotorRailMove_EventHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCAD RID: 130221 RVA: 0x00935D73 File Offset: 0x00933F73
		public SMotorRailMove_EventHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCAE RID: 130222 RVA: 0x00935D7E File Offset: 0x00933F7E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMove_EventHandler(Pointer, false, true);
		}

		// Token: 0x0601FCAF RID: 130223 RVA: 0x00935D88 File Offset: 0x00933F88
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMove_EventHandler(Pointer, MemoryOwner);
		}

		// Token: 0x040110F6 RID: 69878
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler";

		// Token: 0x040110F7 RID: 69879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110F8 RID: 69880
		internal static int __PropertyOffset_ModifyCues;

		// Token: 0x040110F9 RID: 69881
		[Nullable(2)]
		private TMap<int, bool> _ModifyCues;
	}
}
