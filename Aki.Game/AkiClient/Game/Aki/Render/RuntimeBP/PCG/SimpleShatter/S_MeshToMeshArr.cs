using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SimpleShatter
{
	// Token: 0x02003C00 RID: 15360
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_MeshToMeshArr.S_MeshToMeshArr")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class S_MeshToMeshArr : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F62 RID: 143202 RVA: 0x009170BE File Offset: 0x009152BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_MeshToMeshArr._ScriptStructPtr != 0) ? S_MeshToMeshArr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_MeshToMeshArr.S_MeshToMeshArr", ref S_MeshToMeshArr._ScriptStructPtr);
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x06022F63 RID: 143203 RVA: 0x009170E4 File Offset: 0x009152E4
		// (set) Token: 0x06022F64 RID: 143204 RVA: 0x00917127 File Offset: 0x00915327
		public TArray<UStaticMesh> MemberVar_0
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._MemberVar_0) == null)
				{
					result = (this._MemberVar_0 = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)S_MeshToMeshArr.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MemberVar_0.CopyAssign(value);
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x06022F65 RID: 143205 RVA: 0x00917135 File Offset: 0x00915335
		// (set) Token: 0x06022F66 RID: 143206 RVA: 0x00917145 File Offset: 0x00915345
		public unsafe bool 易碎物_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_MeshToMeshArr.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_MeshToMeshArr.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x06022F67 RID: 143207 RVA: 0x00917156 File Offset: 0x00915356
		// (set) Token: 0x06022F68 RID: 143208 RVA: 0x00917166 File Offset: 0x00915366
		public unsafe bool 消融_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_MeshToMeshArr.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_MeshToMeshArr.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x06022F69 RID: 143209 RVA: 0x00917177 File Offset: 0x00915377
		// (set) Token: 0x06022F6A RID: 143210 RVA: 0x0091718B File Offset: 0x0091538B
		[Nullable(2)]
		public unsafe UNiagaraSystem 粒子特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + S_MeshToMeshArr.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_MeshToMeshArr.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06022F6B RID: 143211 RVA: 0x009171A0 File Offset: 0x009153A0
		public S_MeshToMeshArr()
		{
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x009171A8 File Offset: 0x009153A8
		public S_MeshToMeshArr(TArray<UStaticMesh> MemberVar_0, bool 易碎物_, bool 消融_, UNiagaraSystem 粒子特效)
		{
			this.MemberVar_0 = MemberVar_0;
			this.易碎物_ = 易碎物_;
			this.消融_ = 消融_;
			this.粒子特效 = 粒子特效;
		}

		// Token: 0x06022F6D RID: 143213 RVA: 0x009171CD File Offset: 0x009153CD
		protected override IntPtr GetUStructPtr()
		{
			return S_MeshToMeshArr.StaticStruct();
		}

		// Token: 0x06022F6E RID: 143214 RVA: 0x009171D9 File Offset: 0x009153D9
		[NullableContext(2)]
		public S_MeshToMeshArr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022F6F RID: 143215 RVA: 0x009171E3 File Offset: 0x009153E3
		public S_MeshToMeshArr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022F70 RID: 143216 RVA: 0x009171EE File Offset: 0x009153EE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_MeshToMeshArr(Pointer, false, true);
		}

		// Token: 0x06022F71 RID: 143217 RVA: 0x009171F8 File Offset: 0x009153F8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_MeshToMeshArr(Pointer, MemoryOwner);
		}

		// Token: 0x04011369 RID: 70505
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_MeshToMeshArr.S_MeshToMeshArr";

		// Token: 0x0401136A RID: 70506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401136B RID: 70507
		internal static int __PropertyOffset_0;

		// Token: 0x0401136C RID: 70508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _MemberVar_0;

		// Token: 0x0401136D RID: 70509
		internal static int __PropertyOffset_1;

		// Token: 0x0401136E RID: 70510
		internal static int __PropertyOffset_2;

		// Token: 0x0401136F RID: 70511
		internal static int __PropertyOffset_3;
	}
}
