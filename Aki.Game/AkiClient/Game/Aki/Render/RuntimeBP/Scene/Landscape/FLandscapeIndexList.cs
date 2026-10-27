using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Landscape
{
	// Token: 0x02003B37 RID: 15159
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Landscape/FLandscapeIndexList.FLandscapeIndexList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLandscapeIndexList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021866 RID: 137318 RVA: 0x008EEA04 File Offset: 0x008ECC04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeIndexList._ScriptStructPtr != 0) ? FLandscapeIndexList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Landscape/FLandscapeIndexList.FLandscapeIndexList", ref FLandscapeIndexList._ScriptStructPtr);
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x06021867 RID: 137319 RVA: 0x008EEA28 File Offset: 0x008ECC28
		// (set) Token: 0x06021868 RID: 137320 RVA: 0x008EEA6B File Offset: 0x008ECC6B
		public TArray<int> Index
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Index) == null)
				{
					result = (this._Index = new TArray<int>(base.NativePtr + (IntPtr)FLandscapeIndexList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Index.CopyAssign(value);
			}
		}

		// Token: 0x06021869 RID: 137321 RVA: 0x008EEA79 File Offset: 0x008ECC79
		public FLandscapeIndexList()
		{
		}

		// Token: 0x0602186A RID: 137322 RVA: 0x008EEA81 File Offset: 0x008ECC81
		public FLandscapeIndexList(TArray<int> Index)
		{
			this.Index = Index;
		}

		// Token: 0x0602186B RID: 137323 RVA: 0x008EEA90 File Offset: 0x008ECC90
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeIndexList.StaticStruct();
		}

		// Token: 0x0602186C RID: 137324 RVA: 0x008EEA9C File Offset: 0x008ECC9C
		[NullableContext(2)]
		public FLandscapeIndexList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602186D RID: 137325 RVA: 0x008EEAA6 File Offset: 0x008ECCA6
		public FLandscapeIndexList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602186E RID: 137326 RVA: 0x008EEAB1 File Offset: 0x008ECCB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeIndexList(Pointer, false, true);
		}

		// Token: 0x0602186F RID: 137327 RVA: 0x008EEABB File Offset: 0x008ECCBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeIndexList(Pointer, MemoryOwner);
		}

		// Token: 0x04010566 RID: 66918
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Landscape/FLandscapeIndexList.FLandscapeIndexList";

		// Token: 0x04010567 RID: 66919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010568 RID: 66920
		internal static int __PropertyOffset_0;

		// Token: 0x04010569 RID: 66921
		[Nullable(2)]
		private TArray<int> _Index;
	}
}
