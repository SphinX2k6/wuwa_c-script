using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SimpleShatter
{
	// Token: 0x02003BFF RID: 15359
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_BakedShatter.S_BakedShatter")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class S_BakedShatter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F4E RID: 143182 RVA: 0x00916E34 File Offset: 0x00915034
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BakedShatter._ScriptStructPtr != 0) ? S_BakedShatter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_BakedShatter.S_BakedShatter", ref S_BakedShatter._ScriptStructPtr);
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x06022F4F RID: 143183 RVA: 0x00916E58 File Offset: 0x00915058
		// (set) Token: 0x06022F50 RID: 143184 RVA: 0x00916E9B File Offset: 0x0091509B
		public TArray<FTransform> SMComponentLocalTransformArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._SMComponentLocalTransformArr) == null)
				{
					result = (this._SMComponentLocalTransformArr = new TArray<FTransform>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SMComponentLocalTransformArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x06022F51 RID: 143185 RVA: 0x00916EAC File Offset: 0x009150AC
		// (set) Token: 0x06022F52 RID: 143186 RVA: 0x00916EEF File Offset: 0x009150EF
		public TArray<AStaticMeshActor> SMActorArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SMActorArr) == null)
				{
					result = (this._SMActorArr = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SMActorArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x06022F53 RID: 143187 RVA: 0x00916F00 File Offset: 0x00915100
		// (set) Token: 0x06022F54 RID: 143188 RVA: 0x00916F43 File Offset: 0x00915143
		public TArray<UStaticMesh> SMArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._SMArr) == null)
				{
					result = (this._SMArr = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SMArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x06022F55 RID: 143189 RVA: 0x00916F54 File Offset: 0x00915154
		// (set) Token: 0x06022F56 RID: 143190 RVA: 0x00916F97 File Offset: 0x00915197
		public TArray<FSimpleShatterNode> NodeArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSimpleShatterNode> result;
				if ((result = this._NodeArr) == null)
				{
					result = (this._NodeArr = new TArray<FSimpleShatterNode>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NodeArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x06022F57 RID: 143191 RVA: 0x00916FA8 File Offset: 0x009151A8
		// (set) Token: 0x06022F58 RID: 143192 RVA: 0x00916FEB File Offset: 0x009151EB
		public TArray<UStaticMeshComponent> SMComponentArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMComponentArr) == null)
				{
					result = (this._SMComponentArr = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SMComponentArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x06022F59 RID: 143193 RVA: 0x00916FFC File Offset: 0x009151FC
		// (set) Token: 0x06022F5A RID: 143194 RVA: 0x0091703F File Offset: 0x0091523F
		public TArray<int> BakedArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BakedArr) == null)
				{
					result = (this._BakedArr = new TArray<int>(base.NativePtr + (IntPtr)S_BakedShatter.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BakedArr.CopyAssign(value);
			}
		}

		// Token: 0x06022F5B RID: 143195 RVA: 0x0091704D File Offset: 0x0091524D
		public S_BakedShatter()
		{
		}

		// Token: 0x06022F5C RID: 143196 RVA: 0x00917055 File Offset: 0x00915255
		public S_BakedShatter(TArray<FTransform> SMComponentLocalTransformArr, TArray<AStaticMeshActor> SMActorArr, TArray<UStaticMesh> SMArr, TArray<FSimpleShatterNode> NodeArr, TArray<UStaticMeshComponent> SMComponentArr, TArray<int> BakedArr)
		{
			this.SMComponentLocalTransformArr = SMComponentLocalTransformArr;
			this.SMActorArr = SMActorArr;
			this.SMArr = SMArr;
			this.NodeArr = NodeArr;
			this.SMComponentArr = SMComponentArr;
			this.BakedArr = BakedArr;
		}

		// Token: 0x06022F5D RID: 143197 RVA: 0x0091708A File Offset: 0x0091528A
		protected override IntPtr GetUStructPtr()
		{
			return S_BakedShatter.StaticStruct();
		}

		// Token: 0x06022F5E RID: 143198 RVA: 0x00917096 File Offset: 0x00915296
		[NullableContext(2)]
		public S_BakedShatter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022F5F RID: 143199 RVA: 0x009170A0 File Offset: 0x009152A0
		public S_BakedShatter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022F60 RID: 143200 RVA: 0x009170AB File Offset: 0x009152AB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_BakedShatter(Pointer, false, true);
		}

		// Token: 0x06022F61 RID: 143201 RVA: 0x009170B5 File Offset: 0x009152B5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_BakedShatter(Pointer, MemoryOwner);
		}

		// Token: 0x0401135B RID: 70491
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/S_BakedShatter.S_BakedShatter";

		// Token: 0x0401135C RID: 70492
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401135D RID: 70493
		internal static int __PropertyOffset_0;

		// Token: 0x0401135E RID: 70494
		[Nullable(2)]
		private TArray<FTransform> _SMComponentLocalTransformArr;

		// Token: 0x0401135F RID: 70495
		internal static int __PropertyOffset_1;

		// Token: 0x04011360 RID: 70496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SMActorArr;

		// Token: 0x04011361 RID: 70497
		internal static int __PropertyOffset_2;

		// Token: 0x04011362 RID: 70498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _SMArr;

		// Token: 0x04011363 RID: 70499
		internal static int __PropertyOffset_3;

		// Token: 0x04011364 RID: 70500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSimpleShatterNode> _NodeArr;

		// Token: 0x04011365 RID: 70501
		internal static int __PropertyOffset_4;

		// Token: 0x04011366 RID: 70502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponentArr;

		// Token: 0x04011367 RID: 70503
		internal static int __PropertyOffset_5;

		// Token: 0x04011368 RID: 70504
		[Nullable(2)]
		private TArray<int> _BakedArr;
	}
}
