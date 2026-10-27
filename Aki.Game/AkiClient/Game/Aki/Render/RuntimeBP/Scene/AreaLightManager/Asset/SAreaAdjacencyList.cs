using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.AreaLightManager.Asset
{
	// Token: 0x02003BA8 RID: 15272
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/Asset/SAreaAdjacencyList.SAreaAdjacencyList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SAreaAdjacencyList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022084 RID: 139396 RVA: 0x008FD5DF File Offset: 0x008FB7DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAreaAdjacencyList._ScriptStructPtr != 0) ? SAreaAdjacencyList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/Asset/SAreaAdjacencyList.SAreaAdjacencyList", ref SAreaAdjacencyList._ScriptStructPtr);
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x06022085 RID: 139397 RVA: 0x008FD604 File Offset: 0x008FB804
		// (set) Token: 0x06022086 RID: 139398 RVA: 0x008FD647 File Offset: 0x008FB847
		public TArray<int> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<int>(base.NativePtr + (IntPtr)SAreaAdjacencyList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x06022087 RID: 139399 RVA: 0x008FD655 File Offset: 0x008FB855
		public SAreaAdjacencyList()
		{
		}

		// Token: 0x06022088 RID: 139400 RVA: 0x008FD65D File Offset: 0x008FB85D
		public SAreaAdjacencyList(TArray<int> Value)
		{
			this.Value = Value;
		}

		// Token: 0x06022089 RID: 139401 RVA: 0x008FD66C File Offset: 0x008FB86C
		protected override IntPtr GetUStructPtr()
		{
			return SAreaAdjacencyList.StaticStruct();
		}

		// Token: 0x0602208A RID: 139402 RVA: 0x008FD678 File Offset: 0x008FB878
		[NullableContext(2)]
		public SAreaAdjacencyList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602208B RID: 139403 RVA: 0x008FD682 File Offset: 0x008FB882
		public SAreaAdjacencyList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602208C RID: 139404 RVA: 0x008FD68D File Offset: 0x008FB88D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAreaAdjacencyList(Pointer, false, true);
		}

		// Token: 0x0602208D RID: 139405 RVA: 0x008FD697 File Offset: 0x008FB897
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAreaAdjacencyList(Pointer, MemoryOwner);
		}

		// Token: 0x04010A7B RID: 68219
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/AreaLightManager/Asset/SAreaAdjacencyList.SAreaAdjacencyList";

		// Token: 0x04010A7C RID: 68220
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A7D RID: 68221
		internal static int __PropertyOffset_0;

		// Token: 0x04010A7E RID: 68222
		[Nullable(2)]
		private TArray<int> _Value;
	}
}
