using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF5 RID: 15349
	public struct IBoxTriggerShape : IFlatbufferObject
	{
		// Token: 0x1700695F RID: 26975
		// (get) Token: 0x060151E3 RID: 86499 RVA: 0x0030F450 File Offset: 0x0030D650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060151E4 RID: 86500 RVA: 0x0030F45D File Offset: 0x0030D65D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x0030F464 File Offset: 0x0030D664
		public static IBoxTriggerShape GetRootAsIBoxTriggerShape(ByteBuffer _bb)
		{
			return IBoxTriggerShape.GetRootAsIBoxTriggerShape(_bb, default(IBoxTriggerShape));
		}

		// Token: 0x060151E6 RID: 86502 RVA: 0x0030F480 File Offset: 0x0030D680
		public static IBoxTriggerShape GetRootAsIBoxTriggerShape(ByteBuffer _bb, IBoxTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060151E7 RID: 86503 RVA: 0x0030F49D File Offset: 0x0030D69D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060151E8 RID: 86504 RVA: 0x0030F4AC File Offset: 0x0030D6AC
		public IBoxTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006960 RID: 26976
		// (get) Token: 0x060151E9 RID: 86505 RVA: 0x0030F4BC File Offset: 0x0030D6BC
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006961 RID: 26977
		// (get) Token: 0x060151EA RID: 86506 RVA: 0x0030F4F8 File Offset: 0x0030D6F8
		public IVectorInfo? Center
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

		// Token: 0x17006962 RID: 26978
		// (get) Token: 0x060151EB RID: 86507 RVA: 0x0030F558 File Offset: 0x0030D758
		public IVectorInfo? Size
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

		// Token: 0x17006963 RID: 26979
		// (get) Token: 0x060151EC RID: 86508 RVA: 0x0030F5B8 File Offset: 0x0030D7B8
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060151ED RID: 86509 RVA: 0x0030F616 File Offset: 0x0030D816
		public static Offset<IBoxTriggerShape> CreateIBoxTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxTriggerShape.AddRotator(builder, RotatorOffset);
			IBoxTriggerShape.AddSize(builder, SizeOffset);
			IBoxTriggerShape.AddCenter(builder, CenterOffset);
			IBoxTriggerShape.AddType(builder, Type);
			return IBoxTriggerShape.EndIBoxTriggerShape(builder);
		}

		// Token: 0x060151EE RID: 86510 RVA: 0x0030F642 File Offset: 0x0030D842
		public static void StartIBoxTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060151EF RID: 86511 RVA: 0x0030F64B File Offset: 0x0030D84B
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060151F0 RID: 86512 RVA: 0x0030F656 File Offset: 0x0030D856
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060151F1 RID: 86513 RVA: 0x0030F666 File Offset: 0x0030D866
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x060151F2 RID: 86514 RVA: 0x0030F676 File Offset: 0x0030D876
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x060151F3 RID: 86515 RVA: 0x0030F686 File Offset: 0x0030D886
		public static Offset<IBoxTriggerShape> EndIBoxTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTriggerShape>(builder.EndTable());
		}

		// Token: 0x060151F4 RID: 86516 RVA: 0x0030F694 File Offset: 0x0030D894
		public IBoxTriggerShapeT UnPack()
		{
			IBoxTriggerShapeT boxTriggerShapeT = new IBoxTriggerShapeT();
			this.UnPackTo(boxTriggerShapeT);
			return boxTriggerShapeT;
		}

		// Token: 0x060151F5 RID: 86517 RVA: 0x0030F6B0 File Offset: 0x0030D8B0
		public void UnPackTo(IBoxTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x060151F6 RID: 86518 RVA: 0x0030F758 File Offset: 0x0030D958
		public static Offset<IBoxTriggerShape> Pack(FlatBufferBuilder builder, IBoxTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IBoxTriggerShape.CreateIBoxTriggerShape(builder, _o.Type, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400B1C2 RID: 45506
		private Table __p;
	}
}
