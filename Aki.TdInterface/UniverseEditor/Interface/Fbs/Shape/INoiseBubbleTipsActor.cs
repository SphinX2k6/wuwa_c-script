using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004037 RID: 16439
	public struct INoiseBubbleTipsActor : IFlatbufferObject
	{
		// Token: 0x17006FB6 RID: 28598
		// (get) Token: 0x0601691D RID: 92445 RVA: 0x0033AA48 File Offset: 0x00338C48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601691E RID: 92446 RVA: 0x0033AA55 File Offset: 0x00338C55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601691F RID: 92447 RVA: 0x0033AA5C File Offset: 0x00338C5C
		public static INoiseBubbleTipsActor GetRootAsINoiseBubbleTipsActor(ByteBuffer _bb)
		{
			return INoiseBubbleTipsActor.GetRootAsINoiseBubbleTipsActor(_bb, default(INoiseBubbleTipsActor));
		}

		// Token: 0x06016920 RID: 92448 RVA: 0x0033AA78 File Offset: 0x00338C78
		public static INoiseBubbleTipsActor GetRootAsINoiseBubbleTipsActor(ByteBuffer _bb, INoiseBubbleTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016921 RID: 92449 RVA: 0x0033AA95 File Offset: 0x00338C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016922 RID: 92450 RVA: 0x0033AAA4 File Offset: 0x00338CA4
		public INoiseBubbleTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FB7 RID: 28599
		// (get) Token: 0x06016923 RID: 92451 RVA: 0x0033AAB4 File Offset: 0x00338CB4
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

		// Token: 0x17006FB8 RID: 28600
		// (get) Token: 0x06016924 RID: 92452 RVA: 0x0033AAF0 File Offset: 0x00338CF0
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

		// Token: 0x17006FB9 RID: 28601
		// (get) Token: 0x06016925 RID: 92453 RVA: 0x0033AB2C File Offset: 0x00338D2C
		public ENoiseBubbleColor Color
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ENoiseBubbleColor.Green;
				}
				return (ENoiseBubbleColor)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FBA RID: 28602
		// (get) Token: 0x06016926 RID: 92454 RVA: 0x0033AB68 File Offset: 0x00338D68
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016927 RID: 92455 RVA: 0x0033ABA5 File Offset: 0x00338DA5
		public static Offset<INoiseBubbleTipsActor> CreateINoiseBubbleTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, ENoiseBubbleColor Color = ENoiseBubbleColor.Green, byte NullMask = 0)
		{
			builder.StartTable(4);
			INoiseBubbleTipsActor.AddNullMask(builder, NullMask);
			INoiseBubbleTipsActor.AddColor(builder, Color);
			INoiseBubbleTipsActor.AddColorType(builder, ColorType);
			INoiseBubbleTipsActor.AddType(builder, Type);
			return INoiseBubbleTipsActor.EndINoiseBubbleTipsActor(builder);
		}

		// Token: 0x06016928 RID: 92456 RVA: 0x0033ABD1 File Offset: 0x00338DD1
		public static void StartINoiseBubbleTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016929 RID: 92457 RVA: 0x0033ABDA File Offset: 0x00338DDA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601692A RID: 92458 RVA: 0x0033ABE5 File Offset: 0x00338DE5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601692B RID: 92459 RVA: 0x0033ABF0 File Offset: 0x00338DF0
		public static void AddColor(FlatBufferBuilder builder, ENoiseBubbleColor color)
		{
			builder.AddByte(2, (byte)color, 0);
		}

		// Token: 0x0601692C RID: 92460 RVA: 0x0033ABFB File Offset: 0x00338DFB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601692D RID: 92461 RVA: 0x0033AC06 File Offset: 0x00338E06
		public static Offset<INoiseBubbleTipsActor> EndINoiseBubbleTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<INoiseBubbleTipsActor>(builder.EndTable());
		}

		// Token: 0x0601692E RID: 92462 RVA: 0x0033AC14 File Offset: 0x00338E14
		public INoiseBubbleTipsActorT UnPack()
		{
			INoiseBubbleTipsActorT noiseBubbleTipsActorT = new INoiseBubbleTipsActorT();
			this.UnPackTo(noiseBubbleTipsActorT);
			return noiseBubbleTipsActorT;
		}

		// Token: 0x0601692F RID: 92463 RVA: 0x0033AC2F File Offset: 0x00338E2F
		public void UnPackTo(INoiseBubbleTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Color = this.Color;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016930 RID: 92464 RVA: 0x0033AC64 File Offset: 0x00338E64
		public static Offset<INoiseBubbleTipsActor> Pack(FlatBufferBuilder builder, INoiseBubbleTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseBubbleTipsActor>);
			}
			return INoiseBubbleTipsActor.CreateINoiseBubbleTipsActor(builder, _o.Type, _o.ColorType, _o.Color, _o.NullMask);
		}

		// Token: 0x0400BBAD RID: 48045
		private Table __p;
	}
}
