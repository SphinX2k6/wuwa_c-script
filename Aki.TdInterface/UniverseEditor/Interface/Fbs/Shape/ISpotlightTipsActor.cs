using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C4F RID: 15439
	public struct ISpotlightTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A6B RID: 27243
		// (get) Token: 0x06015575 RID: 87413 RVA: 0x00316628 File Offset: 0x00314828
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015576 RID: 87414 RVA: 0x00316635 File Offset: 0x00314835
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015577 RID: 87415 RVA: 0x0031663C File Offset: 0x0031483C
		public static ISpotlightTipsActor GetRootAsISpotlightTipsActor(ByteBuffer _bb)
		{
			return ISpotlightTipsActor.GetRootAsISpotlightTipsActor(_bb, default(ISpotlightTipsActor));
		}

		// Token: 0x06015578 RID: 87416 RVA: 0x00316658 File Offset: 0x00314858
		public static ISpotlightTipsActor GetRootAsISpotlightTipsActor(ByteBuffer _bb, ISpotlightTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015579 RID: 87417 RVA: 0x00316675 File Offset: 0x00314875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601557A RID: 87418 RVA: 0x00316684 File Offset: 0x00314884
		public ISpotlightTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A6C RID: 27244
		// (get) Token: 0x0601557B RID: 87419 RVA: 0x00316694 File Offset: 0x00314894
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

		// Token: 0x17006A6D RID: 27245
		// (get) Token: 0x0601557C RID: 87420 RVA: 0x003166D0 File Offset: 0x003148D0
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

		// Token: 0x17006A6E RID: 27246
		// (get) Token: 0x0601557D RID: 87421 RVA: 0x0031670C File Offset: 0x0031490C
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

		// Token: 0x17006A6F RID: 27247
		// (get) Token: 0x0601557E RID: 87422 RVA: 0x0031674C File Offset: 0x0031494C
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

		// Token: 0x17006A70 RID: 27248
		// (get) Token: 0x0601557F RID: 87423 RVA: 0x00316790 File Offset: 0x00314990
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

		// Token: 0x06015580 RID: 87424 RVA: 0x003167CD File Offset: 0x003149CD
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

		// Token: 0x06015581 RID: 87425 RVA: 0x00316801 File Offset: 0x00314A01
		public static void StartISpotlightTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015582 RID: 87426 RVA: 0x0031680A File Offset: 0x00314A0A
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015583 RID: 87427 RVA: 0x00316815 File Offset: 0x00314A15
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015584 RID: 87428 RVA: 0x00316820 File Offset: 0x00314A20
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06015585 RID: 87429 RVA: 0x00316833 File Offset: 0x00314A33
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x06015586 RID: 87430 RVA: 0x00316846 File Offset: 0x00314A46
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015587 RID: 87431 RVA: 0x00316851 File Offset: 0x00314A51
		public static Offset<ISpotlightTipsActor> EndISpotlightTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISpotlightTipsActor>(builder.EndTable());
		}

		// Token: 0x06015588 RID: 87432 RVA: 0x00316860 File Offset: 0x00314A60
		public ISpotlightTipsActorT UnPack()
		{
			ISpotlightTipsActorT spotlightTipsActorT = new ISpotlightTipsActorT();
			this.UnPackTo(spotlightTipsActorT);
			return spotlightTipsActorT;
		}

		// Token: 0x06015589 RID: 87433 RVA: 0x0031687B File Offset: 0x00314A7B
		public void UnPackTo(ISpotlightTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601558A RID: 87434 RVA: 0x003168BC File Offset: 0x00314ABC
		public static Offset<ISpotlightTipsActor> Pack(FlatBufferBuilder builder, ISpotlightTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpotlightTipsActor>);
			}
			return ISpotlightTipsActor.CreateISpotlightTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400B25D RID: 45661
		private Table __p;
	}
}
