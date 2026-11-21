using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004019 RID: 16409
	public struct ICylinderTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F50 RID: 28496
		// (get) Token: 0x060167D9 RID: 92121 RVA: 0x00338390 File Offset: 0x00336590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167DA RID: 92122 RVA: 0x0033839D File Offset: 0x0033659D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167DB RID: 92123 RVA: 0x003383A4 File Offset: 0x003365A4
		public static ICylinderTipsActor GetRootAsICylinderTipsActor(ByteBuffer _bb)
		{
			return ICylinderTipsActor.GetRootAsICylinderTipsActor(_bb, default(ICylinderTipsActor));
		}

		// Token: 0x060167DC RID: 92124 RVA: 0x003383C0 File Offset: 0x003365C0
		public static ICylinderTipsActor GetRootAsICylinderTipsActor(ByteBuffer _bb, ICylinderTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167DD RID: 92125 RVA: 0x003383DD File Offset: 0x003365DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060167DE RID: 92126 RVA: 0x003383EC File Offset: 0x003365EC
		public ICylinderTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F51 RID: 28497
		// (get) Token: 0x060167DF RID: 92127 RVA: 0x003383FC File Offset: 0x003365FC
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

		// Token: 0x17006F52 RID: 28498
		// (get) Token: 0x060167E0 RID: 92128 RVA: 0x00338438 File Offset: 0x00336638
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

		// Token: 0x17006F53 RID: 28499
		// (get) Token: 0x060167E1 RID: 92129 RVA: 0x00338474 File Offset: 0x00336674
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

		// Token: 0x17006F54 RID: 28500
		// (get) Token: 0x060167E2 RID: 92130 RVA: 0x003384B4 File Offset: 0x003366B4
		public float Height
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

		// Token: 0x17006F55 RID: 28501
		// (get) Token: 0x060167E3 RID: 92131 RVA: 0x003384F8 File Offset: 0x003366F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060167E4 RID: 92132 RVA: 0x00338535 File Offset: 0x00336735
		public static Offset<ICylinderTipsActor> CreateICylinderTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICylinderTipsActor.AddHeight(builder, Height);
			ICylinderTipsActor.AddRadius(builder, Radius);
			ICylinderTipsActor.AddNullMask(builder, NullMask);
			ICylinderTipsActor.AddColorType(builder, ColorType);
			ICylinderTipsActor.AddType(builder, Type);
			return ICylinderTipsActor.EndICylinderTipsActor(builder);
		}

		// Token: 0x060167E5 RID: 92133 RVA: 0x00338569 File Offset: 0x00336769
		public static void StartICylinderTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060167E6 RID: 92134 RVA: 0x00338572 File Offset: 0x00336772
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167E7 RID: 92135 RVA: 0x0033857D File Offset: 0x0033677D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060167E8 RID: 92136 RVA: 0x00338588 File Offset: 0x00336788
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060167E9 RID: 92137 RVA: 0x0033859B File Offset: 0x0033679B
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x060167EA RID: 92138 RVA: 0x003385AE File Offset: 0x003367AE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060167EB RID: 92139 RVA: 0x003385B9 File Offset: 0x003367B9
		public static Offset<ICylinderTipsActor> EndICylinderTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderTipsActor>(builder.EndTable());
		}

		// Token: 0x060167EC RID: 92140 RVA: 0x003385C8 File Offset: 0x003367C8
		public ICylinderTipsActorT UnPack()
		{
			ICylinderTipsActorT cylinderTipsActorT = new ICylinderTipsActorT();
			this.UnPackTo(cylinderTipsActorT);
			return cylinderTipsActorT;
		}

		// Token: 0x060167ED RID: 92141 RVA: 0x003385E3 File Offset: 0x003367E3
		public void UnPackTo(ICylinderTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060167EE RID: 92142 RVA: 0x00338624 File Offset: 0x00336824
		public static Offset<ICylinderTipsActor> Pack(FlatBufferBuilder builder, ICylinderTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderTipsActor>);
			}
			return ICylinderTipsActor.CreateICylinderTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400BB75 RID: 47989
		private Table __p;
	}
}
