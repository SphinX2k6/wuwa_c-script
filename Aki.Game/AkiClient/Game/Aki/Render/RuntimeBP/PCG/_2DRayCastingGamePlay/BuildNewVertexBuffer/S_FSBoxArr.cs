using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG._2DRayCastingGamePlay.BuildNewVertexBuffer
{
	// Token: 0x02003CE9 RID: 15593
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/S_FSBoxArr.S_FSBoxArr")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class S_FSBoxArr : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025205 RID: 152069 RVA: 0x00951CD4 File Offset: 0x0094FED4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_FSBoxArr._ScriptStructPtr != 0) ? S_FSBoxArr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/S_FSBoxArr.S_FSBoxArr", ref S_FSBoxArr._ScriptStructPtr);
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x06025206 RID: 152070 RVA: 0x00951CF8 File Offset: 0x0094FEF8
		// (set) Token: 0x06025207 RID: 152071 RVA: 0x00951D3B File Offset: 0x0094FF3B
		public TArray<FVector> Origin
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Origin) == null)
				{
					result = (this._Origin = new TArray<FVector>(base.NativePtr + (IntPtr)S_FSBoxArr.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Origin.CopyAssign(value);
			}
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x06025208 RID: 152072 RVA: 0x00951D4C File Offset: 0x0094FF4C
		// (set) Token: 0x06025209 RID: 152073 RVA: 0x00951D8F File Offset: 0x0094FF8F
		public TArray<FVector> BoxExtent
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._BoxExtent) == null)
				{
					result = (this._BoxExtent = new TArray<FVector>(base.NativePtr + (IntPtr)S_FSBoxArr.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoxExtent.CopyAssign(value);
			}
		}

		// Token: 0x0602520A RID: 152074 RVA: 0x00951D9D File Offset: 0x0094FF9D
		public S_FSBoxArr()
		{
		}

		// Token: 0x0602520B RID: 152075 RVA: 0x00951DA5 File Offset: 0x0094FFA5
		public S_FSBoxArr(TArray<FVector> Origin, TArray<FVector> BoxExtent)
		{
			this.Origin = Origin;
			this.BoxExtent = BoxExtent;
		}

		// Token: 0x0602520C RID: 152076 RVA: 0x00951DBB File Offset: 0x0094FFBB
		protected override IntPtr GetUStructPtr()
		{
			return S_FSBoxArr.StaticStruct();
		}

		// Token: 0x0602520D RID: 152077 RVA: 0x00951DC7 File Offset: 0x0094FFC7
		[NullableContext(2)]
		public S_FSBoxArr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602520E RID: 152078 RVA: 0x00951DD1 File Offset: 0x0094FFD1
		public S_FSBoxArr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602520F RID: 152079 RVA: 0x00951DDC File Offset: 0x0094FFDC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_FSBoxArr(Pointer, false, true);
		}

		// Token: 0x06025210 RID: 152080 RVA: 0x00951DE6 File Offset: 0x0094FFE6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_FSBoxArr(Pointer, MemoryOwner);
		}

		// Token: 0x040127C2 RID: 75714
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/S_FSBoxArr.S_FSBoxArr";

		// Token: 0x040127C3 RID: 75715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127C4 RID: 75716
		internal static int __PropertyOffset_0;

		// Token: 0x040127C5 RID: 75717
		[Nullable(2)]
		private TArray<FVector> _Origin;

		// Token: 0x040127C6 RID: 75718
		internal static int __PropertyOffset_1;

		// Token: 0x040127C7 RID: 75719
		[Nullable(2)]
		private TArray<FVector> _BoxExtent;
	}
}
