using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004049 RID: 16457
	public struct ISectorTipsActor : IFlatbufferObject
	{
		// Token: 0x17006FDF RID: 28639
		// (get) Token: 0x060169BB RID: 92603 RVA: 0x0033BCB5 File Offset: 0x00339EB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169BC RID: 92604 RVA: 0x0033BCC2 File Offset: 0x00339EC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169BD RID: 92605 RVA: 0x0033BCCC File Offset: 0x00339ECC
		public static ISectorTipsActor GetRootAsISectorTipsActor(ByteBuffer _bb)
		{
			return ISectorTipsActor.GetRootAsISectorTipsActor(_bb, default(ISectorTipsActor));
		}

		// Token: 0x060169BE RID: 92606 RVA: 0x0033BCE8 File Offset: 0x00339EE8
		public static ISectorTipsActor GetRootAsISectorTipsActor(ByteBuffer _bb, ISectorTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169BF RID: 92607 RVA: 0x0033BD05 File Offset: 0x00339F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060169C0 RID: 92608 RVA: 0x0033BD14 File Offset: 0x00339F14
		public ISectorTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FE0 RID: 28640
		// (get) Token: 0x060169C1 RID: 92609 RVA: 0x0033BD24 File Offset: 0x00339F24
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE1 RID: 28641
		// (get) Token: 0x060169C2 RID: 92610 RVA: 0x0033BD60 File Offset: 0x00339F60
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE2 RID: 28642
		// (get) Token: 0x060169C3 RID: 92611 RVA: 0x0033BD9C File Offset: 0x00339F9C
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE3 RID: 28643
		// (get) Token: 0x060169C4 RID: 92612 RVA: 0x0033BDDC File Offset: 0x00339FDC
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE4 RID: 28644
		// (get) Token: 0x060169C5 RID: 92613 RVA: 0x0033BE20 File Offset: 0x0033A020
		public float Offset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE5 RID: 28645
		// (get) Token: 0x060169C6 RID: 92614 RVA: 0x0033BE64 File Offset: 0x0033A064
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060169C7 RID: 92615 RVA: 0x0033BEA1 File Offset: 0x0033A0A1
		public static Offset<ISectorTipsActor> CreateISectorTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Angle = 0f, float Offset = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISectorTipsActor.AddOffset(builder, Offset);
			ISectorTipsActor.AddAngle(builder, Angle);
			ISectorTipsActor.AddRadius(builder, Radius);
			ISectorTipsActor.AddNullMask(builder, NullMask);
			ISectorTipsActor.AddColorType(builder, ColorType);
			ISectorTipsActor.AddType(builder, Type);
			return ISectorTipsActor.EndISectorTipsActor(builder);
		}

		// Token: 0x060169C8 RID: 92616 RVA: 0x0033BEDD File Offset: 0x0033A0DD
		public static void StartISectorTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060169C9 RID: 92617 RVA: 0x0033BEE6 File Offset: 0x0033A0E6
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060169CA RID: 92618 RVA: 0x0033BEF1 File Offset: 0x0033A0F1
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060169CB RID: 92619 RVA: 0x0033BEFC File Offset: 0x0033A0FC
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060169CC RID: 92620 RVA: 0x0033BF0F File Offset: 0x0033A10F
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x0033BF22 File Offset: 0x0033A122
		public static void AddOffset(FlatBufferBuilder builder, float offset)
		{
			builder.AddFloat(4, offset, 0.0);
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x0033BF35 File Offset: 0x0033A135
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060169CF RID: 92623 RVA: 0x0033BF40 File Offset: 0x0033A140
		public static Offset<ISectorTipsActor> EndISectorTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISectorTipsActor>(builder.EndTable());
		}

		// Token: 0x060169D0 RID: 92624 RVA: 0x0033BF50 File Offset: 0x0033A150
		public ISectorTipsActorT UnPack()
		{
			ISectorTipsActorT sectorTipsActorT = new ISectorTipsActorT();
			this.UnPackTo(sectorTipsActorT);
			return sectorTipsActorT;
		}

		// Token: 0x060169D1 RID: 92625 RVA: 0x0033BF6C File Offset: 0x0033A16C
		public void UnPackTo(ISectorTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Angle = this.Angle;
			_o.Offset = this.Offset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060169D2 RID: 92626 RVA: 0x0033BFC4 File Offset: 0x0033A1C4
		public static Offset<ISectorTipsActor> Pack(FlatBufferBuilder builder, ISectorTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISectorTipsActor>);
			}
			return ISectorTipsActor.CreateISectorTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Angle, _o.Offset, _o.NullMask);
		}

		// Token: 0x0400BBCB RID: 48075
		private Table __p;
	}
}
