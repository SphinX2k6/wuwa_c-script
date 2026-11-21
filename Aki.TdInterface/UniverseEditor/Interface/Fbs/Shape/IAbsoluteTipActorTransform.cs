using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FE9 RID: 16361
	public struct IAbsoluteTipActorTransform : IFlatbufferObject
	{
		// Token: 0x17006EC3 RID: 28355
		// (get) Token: 0x060165EF RID: 91631 RVA: 0x0033434C File Offset: 0x0033254C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165F0 RID: 91632 RVA: 0x00334359 File Offset: 0x00332559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165F1 RID: 91633 RVA: 0x00334360 File Offset: 0x00332560
		public static IAbsoluteTipActorTransform GetRootAsIAbsoluteTipActorTransform(ByteBuffer _bb)
		{
			return IAbsoluteTipActorTransform.GetRootAsIAbsoluteTipActorTransform(_bb, default(IAbsoluteTipActorTransform));
		}

		// Token: 0x060165F2 RID: 91634 RVA: 0x0033437C File Offset: 0x0033257C
		public static IAbsoluteTipActorTransform GetRootAsIAbsoluteTipActorTransform(ByteBuffer _bb, IAbsoluteTipActorTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165F3 RID: 91635 RVA: 0x00334399 File Offset: 0x00332599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165F4 RID: 91636 RVA: 0x003343A8 File Offset: 0x003325A8
		public IAbsoluteTipActorTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EC4 RID: 28356
		// (get) Token: 0x060165F5 RID: 91637 RVA: 0x003343B8 File Offset: 0x003325B8
		public ETipsActorTransformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorTransformType.Absolute;
				}
				return (ETipsActorTransformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006EC5 RID: 28357
		// (get) Token: 0x060165F6 RID: 91638 RVA: 0x003343F4 File Offset: 0x003325F4
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006EC6 RID: 28358
		// (get) Token: 0x060165F7 RID: 91639 RVA: 0x00334454 File Offset: 0x00332654
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060165F8 RID: 91640 RVA: 0x003344B1 File Offset: 0x003326B1
		public static Offset<IAbsoluteTipActorTransform> CreateIAbsoluteTipActorTransform(FlatBufferBuilder builder, ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IAbsoluteTipActorTransform.AddRot(builder, RotOffset);
			IAbsoluteTipActorTransform.AddPos(builder, PosOffset);
			IAbsoluteTipActorTransform.AddType(builder, Type);
			return IAbsoluteTipActorTransform.EndIAbsoluteTipActorTransform(builder);
		}

		// Token: 0x060165F9 RID: 91641 RVA: 0x003344D5 File Offset: 0x003326D5
		public static void StartIAbsoluteTipActorTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060165FA RID: 91642 RVA: 0x003344DE File Offset: 0x003326DE
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060165FB RID: 91643 RVA: 0x003344E9 File Offset: 0x003326E9
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060165FC RID: 91644 RVA: 0x003344F9 File Offset: 0x003326F9
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x060165FD RID: 91645 RVA: 0x00334509 File Offset: 0x00332709
		public static Offset<IAbsoluteTipActorTransform> EndIAbsoluteTipActorTransform(FlatBufferBuilder builder)
		{
			return new Offset<IAbsoluteTipActorTransform>(builder.EndTable());
		}

		// Token: 0x060165FE RID: 91646 RVA: 0x00334518 File Offset: 0x00332718
		public IAbsoluteTipActorTransformT UnPack()
		{
			IAbsoluteTipActorTransformT absoluteTipActorTransformT = new IAbsoluteTipActorTransformT();
			this.UnPackTo(absoluteTipActorTransformT);
			return absoluteTipActorTransformT;
		}

		// Token: 0x060165FF RID: 91647 RVA: 0x00334534 File Offset: 0x00332734
		public void UnPackTo(IAbsoluteTipActorTransformT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06016600 RID: 91648 RVA: 0x003345AC File Offset: 0x003327AC
		public static Offset<IAbsoluteTipActorTransform> Pack(FlatBufferBuilder builder, IAbsoluteTipActorTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsoluteTipActorTransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IAbsoluteTipActorTransform.CreateIAbsoluteTipActorTransform(builder, _o.Type, posOffset, rotOffset);
		}

		// Token: 0x0400BB27 RID: 47911
		private Table __p;
	}
}
