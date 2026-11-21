using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FEC RID: 16364
	public struct IAbsoluteTipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17006ECA RID: 28362
		// (get) Token: 0x06016609 RID: 91657 RVA: 0x003346DE File Offset: 0x003328DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601660A RID: 91658 RVA: 0x003346EB File Offset: 0x003328EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601660B RID: 91659 RVA: 0x003346F4 File Offset: 0x003328F4
		public static IAbsoluteTipsActorTransformResult GetRootAsIAbsoluteTipsActorTransformResult(ByteBuffer _bb)
		{
			return IAbsoluteTipsActorTransformResult.GetRootAsIAbsoluteTipsActorTransformResult(_bb, default(IAbsoluteTipsActorTransformResult));
		}

		// Token: 0x0601660C RID: 91660 RVA: 0x00334710 File Offset: 0x00332910
		public static IAbsoluteTipsActorTransformResult GetRootAsIAbsoluteTipsActorTransformResult(ByteBuffer _bb, IAbsoluteTipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601660D RID: 91661 RVA: 0x0033472D File Offset: 0x0033292D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601660E RID: 91662 RVA: 0x0033473C File Offset: 0x0033293C
		public IAbsoluteTipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ECB RID: 28363
		// (get) Token: 0x0601660F RID: 91663 RVA: 0x0033474C File Offset: 0x0033294C
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006ECC RID: 28364
		// (get) Token: 0x06016610 RID: 91664 RVA: 0x0033478C File Offset: 0x0033298C
		public string Reason
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016611 RID: 91665 RVA: 0x003347C3 File Offset: 0x003329C3
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016612 RID: 91666 RVA: 0x003347D2 File Offset: 0x003329D2
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006ECD RID: 28365
		// (get) Token: 0x06016613 RID: 91667 RVA: 0x003347E0 File Offset: 0x003329E0
		public ETipsActorTransformType Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETipsActorTransformType.Absolute;
				}
				return (ETipsActorTransformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006ECE RID: 28366
		// (get) Token: 0x06016614 RID: 91668 RVA: 0x0033481C File Offset: 0x00332A1C
		public IShapeTransform? TransformWorld
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006ECF RID: 28367
		// (get) Token: 0x06016615 RID: 91669 RVA: 0x0033487C File Offset: 0x00332A7C
		public IHollowTipsActorComponent? HollowTipsActorComponent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHollowTipsActorComponent?(default(IHollowTipsActorComponent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016616 RID: 91670 RVA: 0x003348DA File Offset: 0x00332ADA
		public static Offset<IAbsoluteTipsActorTransformResult> CreateIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset), ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IShapeTransform> TransformWorldOffset = default(Offset<IShapeTransform>), Offset<IHollowTipsActorComponent> HollowTipsActorComponentOffset = default(Offset<IHollowTipsActorComponent>))
		{
			builder.StartTable(5);
			IAbsoluteTipsActorTransformResult.AddHollowTipsActorComponent(builder, HollowTipsActorComponentOffset);
			IAbsoluteTipsActorTransformResult.AddTransformWorld(builder, TransformWorldOffset);
			IAbsoluteTipsActorTransformResult.AddReason(builder, ReasonOffset);
			IAbsoluteTipsActorTransformResult.AddType(builder, Type);
			IAbsoluteTipsActorTransformResult.AddIsSuccess(builder, IsSuccess);
			return IAbsoluteTipsActorTransformResult.EndIAbsoluteTipsActorTransformResult(builder);
		}

		// Token: 0x06016617 RID: 91671 RVA: 0x0033490E File Offset: 0x00332B0E
		public static void StartIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016618 RID: 91672 RVA: 0x00334917 File Offset: 0x00332B17
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06016619 RID: 91673 RVA: 0x00334922 File Offset: 0x00332B22
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x0601661A RID: 91674 RVA: 0x00334932 File Offset: 0x00332B32
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601661B RID: 91675 RVA: 0x0033493D File Offset: 0x00332B3D
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x0601661C RID: 91676 RVA: 0x0033494D File Offset: 0x00332B4D
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x0601661D RID: 91677 RVA: 0x0033495D File Offset: 0x00332B5D
		public static Offset<IAbsoluteTipsActorTransformResult> EndIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<IAbsoluteTipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x0601661E RID: 91678 RVA: 0x0033496C File Offset: 0x00332B6C
		public IAbsoluteTipsActorTransformResultT UnPack()
		{
			IAbsoluteTipsActorTransformResultT absoluteTipsActorTransformResultT = new IAbsoluteTipsActorTransformResultT();
			this.UnPackTo(absoluteTipsActorTransformResultT);
			return absoluteTipsActorTransformResultT;
		}

		// Token: 0x0601661F RID: 91679 RVA: 0x00334988 File Offset: 0x00332B88
		public void UnPackTo(IAbsoluteTipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
		}

		// Token: 0x06016620 RID: 91680 RVA: 0x00334A18 File Offset: 0x00332C18
		public static Offset<IAbsoluteTipsActorTransformResult> Pack(FlatBufferBuilder builder, IAbsoluteTipsActorTransformResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsoluteTipsActorTransformResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			Offset<IShapeTransform> transformWorldOffset = (_o.TransformWorld == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformWorld);
			Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset = (_o.HollowTipsActorComponent == null) ? default(Offset<IHollowTipsActorComponent>) : IHollowTipsActorComponent.Pack(builder, _o.HollowTipsActorComponent);
			return IAbsoluteTipsActorTransformResult.CreateIAbsoluteTipsActorTransformResult(builder, _o.IsSuccess, reasonOffset, _o.Type, transformWorldOffset, hollowTipsActorComponentOffset);
		}

		// Token: 0x0400BB2B RID: 47915
		private Table __p;
	}
}
