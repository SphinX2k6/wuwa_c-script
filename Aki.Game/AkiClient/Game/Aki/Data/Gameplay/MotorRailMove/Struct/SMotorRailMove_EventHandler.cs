using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F42 RID: 16194
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SMotorRailMove_EventHandler : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029383 RID: 168835 RVA: 0x009BEBFE File Offset: 0x009BCDFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_EventHandler._ScriptStructPtr != 0) ? SMotorRailMove_EventHandler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler", ref SMotorRailMove_EventHandler._ScriptStructPtr);
		}

		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x06029384 RID: 168836 RVA: 0x009BEC24 File Offset: 0x009BCE24
		// (set) Token: 0x06029385 RID: 168837 RVA: 0x009BEC67 File Offset: 0x009BCE67
		public TMap<int, bool> ModifyCues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._ModifyCues) == null)
				{
					result = (this._ModifyCues = new TMap<int, bool>(base.NativePtr + (IntPtr)SMotorRailMove_EventHandler.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyCues.CopyAssign(value);
			}
		}

		// Token: 0x06029386 RID: 168838 RVA: 0x009BEC75 File Offset: 0x009BCE75
		public SMotorRailMove_EventHandler()
		{
		}

		// Token: 0x06029387 RID: 168839 RVA: 0x009BEC7D File Offset: 0x009BCE7D
		public SMotorRailMove_EventHandler(TMap<int, bool> ModifyCues)
		{
			this.ModifyCues = ModifyCues;
		}

		// Token: 0x06029388 RID: 168840 RVA: 0x009BEC8C File Offset: 0x009BCE8C
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMove_EventHandler.StaticStruct();
		}

		// Token: 0x06029389 RID: 168841 RVA: 0x009BEC98 File Offset: 0x009BCE98
		[NullableContext(2)]
		public SMotorRailMove_EventHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602938A RID: 168842 RVA: 0x009BECA2 File Offset: 0x009BCEA2
		public SMotorRailMove_EventHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602938B RID: 168843 RVA: 0x009BECAD File Offset: 0x009BCEAD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMove_EventHandler(Pointer, false, true);
		}

		// Token: 0x0602938C RID: 168844 RVA: 0x009BECB7 File Offset: 0x009BCEB7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMove_EventHandler(Pointer, MemoryOwner);
		}

		// Token: 0x040151BA RID: 86458
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_EventHandler.SMotorRailMove_EventHandler";

		// Token: 0x040151BB RID: 86459
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151BC RID: 86460
		internal static int __PropertyOffset_0;

		// Token: 0x040151BD RID: 86461
		[Nullable(2)]
		private TMap<int, bool> _ModifyCues;
	}
}
