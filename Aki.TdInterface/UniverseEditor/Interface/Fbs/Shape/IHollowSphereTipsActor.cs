using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200402B RID: 16427
	public struct IHollowSphereTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F92 RID: 28562
		// (get) Token: 0x060168A5 RID: 92325 RVA: 0x00339C0B File Offset: 0x00337E0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168A6 RID: 92326 RVA: 0x00339C18 File Offset: 0x00337E18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168A7 RID: 92327 RVA: 0x00339C20 File Offset: 0x00337E20
		public static IHollowSphereTipsActor GetRootAsIHollowSphereTipsActor(ByteBuffer _bb)
		{
			return IHollowSphereTipsActor.GetRootAsIHollowSphereTipsActor(_bb, default(IHollowSphereTipsActor));
		}

		// Token: 0x060168A8 RID: 92328 RVA: 0x00339C3C File Offset: 0x00337E3C
		public static IHollowSphereTipsActor GetRootAsIHollowSphereTipsActor(ByteBuffer _bb, IHollowSphereTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168A9 RID: 92329 RVA: 0x00339C59 File Offset: 0x00337E59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168AA RID: 92330 RVA: 0x00339C68 File Offset: 0x00337E68
		public IHollowSphereTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F93 RID: 28563
		// (get) Token: 0x060168AB RID: 92331 RVA: 0x00339C78 File Offset: 0x00337E78
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

		// Token: 0x17006F94 RID: 28564
		// (get) Token: 0x060168AC RID: 92332 RVA: 0x00339CB4 File Offset: 0x00337EB4
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

		// Token: 0x17006F95 RID: 28565
		// (get) Token: 0x060168AD RID: 92333 RVA: 0x00339CF0 File Offset: 0x00337EF0
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

		// Token: 0x17006F96 RID: 28566
		// (get) Token: 0x060168AE RID: 92334 RVA: 0x00339D30 File Offset: 0x00337F30
		public float InnerRadius
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

		// Token: 0x17006F97 RID: 28567
		// (get) Token: 0x060168AF RID: 92335 RVA: 0x00339D74 File Offset: 0x00337F74
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

		// Token: 0x060168B0 RID: 92336 RVA: 0x00339DB1 File Offset: 0x00337FB1
		public static Offset<IHollowSphereTipsActor> CreateIHollowSphereTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float InnerRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHollowSphereTipsActor.AddInnerRadius(builder, InnerRadius);
			IHollowSphereTipsActor.AddRadius(builder, Radius);
			IHollowSphereTipsActor.AddNullMask(builder, NullMask);
			IHollowSphereTipsActor.AddColorType(builder, ColorType);
			IHollowSphereTipsActor.AddType(builder, Type);
			return IHollowSphereTipsActor.EndIHollowSphereTipsActor(builder);
		}

		// Token: 0x060168B1 RID: 92337 RVA: 0x00339DE5 File Offset: 0x00337FE5
		public static void StartIHollowSphereTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060168B2 RID: 92338 RVA: 0x00339DEE File Offset: 0x00337FEE
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060168B3 RID: 92339 RVA: 0x00339DF9 File Offset: 0x00337FF9
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060168B4 RID: 92340 RVA: 0x00339E04 File Offset: 0x00338004
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060168B5 RID: 92341 RVA: 0x00339E17 File Offset: 0x00338017
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(3, innerRadius, 0.0);
		}

		// Token: 0x060168B6 RID: 92342 RVA: 0x00339E2A File Offset: 0x0033802A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x00339E35 File Offset: 0x00338035
		public static Offset<IHollowSphereTipsActor> EndIHollowSphereTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IHollowSphereTipsActor>(builder.EndTable());
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x00339E44 File Offset: 0x00338044
		public IHollowSphereTipsActorT UnPack()
		{
			IHollowSphereTipsActorT hollowSphereTipsActorT = new IHollowSphereTipsActorT();
			this.UnPackTo(hollowSphereTipsActorT);
			return hollowSphereTipsActorT;
		}

		// Token: 0x060168B9 RID: 92345 RVA: 0x00339E5F File Offset: 0x0033805F
		public void UnPackTo(IHollowSphereTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x00339EA0 File Offset: 0x003380A0
		public static Offset<IHollowSphereTipsActor> Pack(FlatBufferBuilder builder, IHollowSphereTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowSphereTipsActor>);
			}
			return IHollowSphereTipsActor.CreateIHollowSphereTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.InnerRadius, _o.NullMask);
		}

		// Token: 0x0400BB99 RID: 48025
		private Table __p;
	}
}
