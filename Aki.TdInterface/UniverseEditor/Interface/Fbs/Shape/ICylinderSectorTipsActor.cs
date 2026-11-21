using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004016 RID: 16406
	public struct ICylinderSectorTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F43 RID: 28483
		// (get) Token: 0x060167B3 RID: 92083 RVA: 0x00337F1F File Offset: 0x0033611F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167B4 RID: 92084 RVA: 0x00337F2C File Offset: 0x0033612C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167B5 RID: 92085 RVA: 0x00337F34 File Offset: 0x00336134
		public static ICylinderSectorTipsActor GetRootAsICylinderSectorTipsActor(ByteBuffer _bb)
		{
			return ICylinderSectorTipsActor.GetRootAsICylinderSectorTipsActor(_bb, default(ICylinderSectorTipsActor));
		}

		// Token: 0x060167B6 RID: 92086 RVA: 0x00337F50 File Offset: 0x00336150
		public static ICylinderSectorTipsActor GetRootAsICylinderSectorTipsActor(ByteBuffer _bb, ICylinderSectorTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167B7 RID: 92087 RVA: 0x00337F6D File Offset: 0x0033616D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060167B8 RID: 92088 RVA: 0x00337F7C File Offset: 0x0033617C
		public ICylinderSectorTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F44 RID: 28484
		// (get) Token: 0x060167B9 RID: 92089 RVA: 0x00337F8C File Offset: 0x0033618C
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

		// Token: 0x17006F45 RID: 28485
		// (get) Token: 0x060167BA RID: 92090 RVA: 0x00337FC8 File Offset: 0x003361C8
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

		// Token: 0x17006F46 RID: 28486
		// (get) Token: 0x060167BB RID: 92091 RVA: 0x00338004 File Offset: 0x00336204
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

		// Token: 0x17006F47 RID: 28487
		// (get) Token: 0x060167BC RID: 92092 RVA: 0x00338044 File Offset: 0x00336244
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

		// Token: 0x17006F48 RID: 28488
		// (get) Token: 0x060167BD RID: 92093 RVA: 0x00338088 File Offset: 0x00336288
		public float Angle
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

		// Token: 0x17006F49 RID: 28489
		// (get) Token: 0x060167BE RID: 92094 RVA: 0x003380CC File Offset: 0x003362CC
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

		// Token: 0x060167BF RID: 92095 RVA: 0x00338109 File Offset: 0x00336309
		public static Offset<ICylinderSectorTipsActor> CreateICylinderSectorTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, float Angle = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICylinderSectorTipsActor.AddAngle(builder, Angle);
			ICylinderSectorTipsActor.AddHeight(builder, Height);
			ICylinderSectorTipsActor.AddRadius(builder, Radius);
			ICylinderSectorTipsActor.AddNullMask(builder, NullMask);
			ICylinderSectorTipsActor.AddColorType(builder, ColorType);
			ICylinderSectorTipsActor.AddType(builder, Type);
			return ICylinderSectorTipsActor.EndICylinderSectorTipsActor(builder);
		}

		// Token: 0x060167C0 RID: 92096 RVA: 0x00338145 File Offset: 0x00336345
		public static void StartICylinderSectorTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060167C1 RID: 92097 RVA: 0x0033814E File Offset: 0x0033634E
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167C2 RID: 92098 RVA: 0x00338159 File Offset: 0x00336359
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060167C3 RID: 92099 RVA: 0x00338164 File Offset: 0x00336364
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060167C4 RID: 92100 RVA: 0x00338177 File Offset: 0x00336377
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x060167C5 RID: 92101 RVA: 0x0033818A File Offset: 0x0033638A
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(4, angle, 0.0);
		}

		// Token: 0x060167C6 RID: 92102 RVA: 0x0033819D File Offset: 0x0033639D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060167C7 RID: 92103 RVA: 0x003381A8 File Offset: 0x003363A8
		public static Offset<ICylinderSectorTipsActor> EndICylinderSectorTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderSectorTipsActor>(builder.EndTable());
		}

		// Token: 0x060167C8 RID: 92104 RVA: 0x003381B8 File Offset: 0x003363B8
		public ICylinderSectorTipsActorT UnPack()
		{
			ICylinderSectorTipsActorT cylinderSectorTipsActorT = new ICylinderSectorTipsActorT();
			this.UnPackTo(cylinderSectorTipsActorT);
			return cylinderSectorTipsActorT;
		}

		// Token: 0x060167C9 RID: 92105 RVA: 0x003381D4 File Offset: 0x003363D4
		public void UnPackTo(ICylinderSectorTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.Angle = this.Angle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060167CA RID: 92106 RVA: 0x0033822C File Offset: 0x0033642C
		public static Offset<ICylinderSectorTipsActor> Pack(FlatBufferBuilder builder, ICylinderSectorTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderSectorTipsActor>);
			}
			return ICylinderSectorTipsActor.CreateICylinderSectorTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.Angle, _o.NullMask);
		}

		// Token: 0x0400BB6E RID: 47982
		private Table __p;
	}
}
