using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200405E RID: 16478
	public struct ISpotlightTipsActor : IFlatbufferObject
	{
		// Token: 0x1700701C RID: 28700
		// (get) Token: 0x06016A89 RID: 92809 RVA: 0x0033D4C8 File Offset: 0x0033B6C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A8A RID: 92810 RVA: 0x0033D4D5 File Offset: 0x0033B6D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A8B RID: 92811 RVA: 0x0033D4DC File Offset: 0x0033B6DC
		public static ISpotlightTipsActor GetRootAsISpotlightTipsActor(ByteBuffer _bb)
		{
			return ISpotlightTipsActor.GetRootAsISpotlightTipsActor(_bb, default(ISpotlightTipsActor));
		}

		// Token: 0x06016A8C RID: 92812 RVA: 0x0033D4F8 File Offset: 0x0033B6F8
		public static ISpotlightTipsActor GetRootAsISpotlightTipsActor(ByteBuffer _bb, ISpotlightTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A8D RID: 92813 RVA: 0x0033D515 File Offset: 0x0033B715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A8E RID: 92814 RVA: 0x0033D524 File Offset: 0x0033B724
		public ISpotlightTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700701D RID: 28701
		// (get) Token: 0x06016A8F RID: 92815 RVA: 0x0033D534 File Offset: 0x0033B734
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

		// Token: 0x1700701E RID: 28702
		// (get) Token: 0x06016A90 RID: 92816 RVA: 0x0033D570 File Offset: 0x0033B770
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

		// Token: 0x1700701F RID: 28703
		// (get) Token: 0x06016A91 RID: 92817 RVA: 0x0033D5AC File Offset: 0x0033B7AC
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

		// Token: 0x17007020 RID: 28704
		// (get) Token: 0x06016A92 RID: 92818 RVA: 0x0033D5EC File Offset: 0x0033B7EC
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

		// Token: 0x17007021 RID: 28705
		// (get) Token: 0x06016A93 RID: 92819 RVA: 0x0033D630 File Offset: 0x0033B830
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

		// Token: 0x06016A94 RID: 92820 RVA: 0x0033D66D File Offset: 0x0033B86D
		public static Offset<ISpotlightTipsActor> CreateISpotlightTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISpotlightTipsActor.AddHeight(builder, Height);
			ISpotlightTipsActor.AddRadius(builder, Radius);
			ISpotlightTipsActor.AddNullMask(builder, NullMask);
			ISpotlightTipsActor.AddColorType(builder, ColorType);
			ISpotlightTipsActor.AddType(builder, Type);
			return ISpotlightTipsActor.EndISpotlightTipsActor(builder);
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x0033D6A1 File Offset: 0x0033B8A1
		public static void StartISpotlightTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016A96 RID: 92822 RVA: 0x0033D6AA File Offset: 0x0033B8AA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x0033D6B5 File Offset: 0x0033B8B5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016A98 RID: 92824 RVA: 0x0033D6C0 File Offset: 0x0033B8C0
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06016A99 RID: 92825 RVA: 0x0033D6D3 File Offset: 0x0033B8D3
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x06016A9A RID: 92826 RVA: 0x0033D6E6 File Offset: 0x0033B8E6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016A9B RID: 92827 RVA: 0x0033D6F1 File Offset: 0x0033B8F1
		public static Offset<ISpotlightTipsActor> EndISpotlightTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISpotlightTipsActor>(builder.EndTable());
		}

		// Token: 0x06016A9C RID: 92828 RVA: 0x0033D700 File Offset: 0x0033B900
		public ISpotlightTipsActorT UnPack()
		{
			ISpotlightTipsActorT spotlightTipsActorT = new ISpotlightTipsActorT();
			this.UnPackTo(spotlightTipsActorT);
			return spotlightTipsActorT;
		}

		// Token: 0x06016A9D RID: 92829 RVA: 0x0033D71B File Offset: 0x0033B91B
		public void UnPackTo(ISpotlightTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x0033D75C File Offset: 0x0033B95C
		public static Offset<ISpotlightTipsActor> Pack(FlatBufferBuilder builder, ISpotlightTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpotlightTipsActor>);
			}
			return ISpotlightTipsActor.CreateISpotlightTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400BBED RID: 48109
		private Table __p;
	}
}
