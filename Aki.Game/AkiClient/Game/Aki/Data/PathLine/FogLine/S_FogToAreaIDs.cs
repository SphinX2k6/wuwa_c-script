using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PathLine.FogLine
{
	// Token: 0x02003EEA RID: 16106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 18)]
	public class S_FogToAreaIDs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028C83 RID: 167043 RVA: 0x009B47E6 File Offset: 0x009B29E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_FogToAreaIDs._ScriptStructPtr != 0) ? S_FogToAreaIDs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs", ref S_FogToAreaIDs._ScriptStructPtr);
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x06028C84 RID: 167044 RVA: 0x009B480C File Offset: 0x009B2A0C
		// (set) Token: 0x06028C85 RID: 167045 RVA: 0x009B484F File Offset: 0x009B2A4F
		public TArray<int> AreaFogIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._AreaFogIDs) == null)
				{
					result = (this._AreaFogIDs = new TArray<int>(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AreaFogIDs.CopyAssign(value);
			}
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x06028C86 RID: 167046 RVA: 0x009B485D File Offset: 0x009B2A5D
		// (set) Token: 0x06028C87 RID: 167047 RVA: 0x009B486D File Offset: 0x009B2A6D
		public unsafe bool IsFogP1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x06028C88 RID: 167048 RVA: 0x009B487E File Offset: 0x009B2A7E
		// (set) Token: 0x06028C89 RID: 167049 RVA: 0x009B488E File Offset: 0x009B2A8E
		public unsafe bool IsFogP2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028C8A RID: 167050 RVA: 0x009B489F File Offset: 0x009B2A9F
		public S_FogToAreaIDs()
		{
		}

		// Token: 0x06028C8B RID: 167051 RVA: 0x009B48A7 File Offset: 0x009B2AA7
		public S_FogToAreaIDs(TArray<int> AreaFogIDs, bool IsFogP1, bool IsFogP2)
		{
			this.AreaFogIDs = AreaFogIDs;
			this.IsFogP1 = IsFogP1;
			this.IsFogP2 = IsFogP2;
		}

		// Token: 0x06028C8C RID: 167052 RVA: 0x009B48C4 File Offset: 0x009B2AC4
		protected override IntPtr GetUStructPtr()
		{
			return S_FogToAreaIDs.StaticStruct();
		}

		// Token: 0x06028C8D RID: 167053 RVA: 0x009B48D0 File Offset: 0x009B2AD0
		[NullableContext(2)]
		public S_FogToAreaIDs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028C8E RID: 167054 RVA: 0x009B48DA File Offset: 0x009B2ADA
		public S_FogToAreaIDs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028C8F RID: 167055 RVA: 0x009B48E5 File Offset: 0x009B2AE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_FogToAreaIDs(Pointer, false, true);
		}

		// Token: 0x06028C90 RID: 167056 RVA: 0x009B48EF File Offset: 0x009B2AEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_FogToAreaIDs(Pointer, MemoryOwner);
		}

		// Token: 0x04014D8B RID: 85387
		public const string __ObjectPath = "/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs";

		// Token: 0x04014D8C RID: 85388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D8D RID: 85389
		internal static int __PropertyOffset_0;

		// Token: 0x04014D8E RID: 85390
		[Nullable(2)]
		private TArray<int> _AreaFogIDs;

		// Token: 0x04014D8F RID: 85391
		internal static int __PropertyOffset_1;

		// Token: 0x04014D90 RID: 85392
		internal static int __PropertyOffset_2;
	}
}
