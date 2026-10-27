using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E4A RID: 15946
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfoList.SPCGStaticMeshInfoList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SPCGStaticMeshInfoList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602814D RID: 164173 RVA: 0x009A371A File Offset: 0x009A191A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGStaticMeshInfoList._ScriptStructPtr != 0) ? SPCGStaticMeshInfoList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfoList.SPCGStaticMeshInfoList", ref SPCGStaticMeshInfoList._ScriptStructPtr);
		}

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x0602814E RID: 164174 RVA: 0x009A3740 File Offset: 0x009A1940
		// (set) Token: 0x0602814F RID: 164175 RVA: 0x009A3783 File Offset: 0x009A1983
		public TArray<SPCGStaticMeshInfo> StaticMeshList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPCGStaticMeshInfo> result;
				if ((result = this._StaticMeshList) == null)
				{
					result = (this._StaticMeshList = new TArray<SPCGStaticMeshInfo>(base.NativePtr + (IntPtr)SPCGStaticMeshInfoList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshList.CopyAssign(value);
			}
		}

		// Token: 0x06028150 RID: 164176 RVA: 0x009A3791 File Offset: 0x009A1991
		public SPCGStaticMeshInfoList()
		{
		}

		// Token: 0x06028151 RID: 164177 RVA: 0x009A3799 File Offset: 0x009A1999
		public SPCGStaticMeshInfoList(TArray<SPCGStaticMeshInfo> StaticMeshList)
		{
			this.StaticMeshList = StaticMeshList;
		}

		// Token: 0x06028152 RID: 164178 RVA: 0x009A37A8 File Offset: 0x009A19A8
		protected override IntPtr GetUStructPtr()
		{
			return SPCGStaticMeshInfoList.StaticStruct();
		}

		// Token: 0x06028153 RID: 164179 RVA: 0x009A37B4 File Offset: 0x009A19B4
		[NullableContext(2)]
		public SPCGStaticMeshInfoList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028154 RID: 164180 RVA: 0x009A37BE File Offset: 0x009A19BE
		public SPCGStaticMeshInfoList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028155 RID: 164181 RVA: 0x009A37C9 File Offset: 0x009A19C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGStaticMeshInfoList(Pointer, false, true);
		}

		// Token: 0x06028156 RID: 164182 RVA: 0x009A37D3 File Offset: 0x009A19D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGStaticMeshInfoList(Pointer, MemoryOwner);
		}

		// Token: 0x0401463C RID: 83516
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfoList.SPCGStaticMeshInfoList";

		// Token: 0x0401463D RID: 83517
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401463E RID: 83518
		internal static int __PropertyOffset_0;

		// Token: 0x0401463F RID: 83519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPCGStaticMeshInfo> _StaticMeshList;
	}
}
