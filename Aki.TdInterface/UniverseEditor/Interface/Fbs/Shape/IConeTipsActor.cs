using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C01 RID: 15361
	public struct IConeTipsActor : IFlatbufferObject
	{
		// Token: 0x1700697E RID: 27006
		// (get) Token: 0x0601525F RID: 86623 RVA: 0x0031088F File Offset: 0x0030EA8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015260 RID: 86624 RVA: 0x0031089C File Offset: 0x0030EA9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015261 RID: 86625 RVA: 0x003108A4 File Offset: 0x0030EAA4
		public static IConeTipsActor GetRootAsIConeTipsActor(ByteBuffer _bb)
		{
			return IConeTipsActor.GetRootAsIConeTipsActor(_bb, default(IConeTipsActor));
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x003108C0 File Offset: 0x0030EAC0
		public static IConeTipsActor GetRootAsIConeTipsActor(ByteBuffer _bb, IConeTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015263 RID: 86627 RVA: 0x003108DD File Offset: 0x0030EADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015264 RID: 86628 RVA: 0x003108EC File Offset: 0x0030EAEC
		public IConeTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700697F RID: 27007
		// (get) Token: 0x06015265 RID: 86629 RVA: 0x003108FC File Offset: 0x0030EAFC
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

		// Token: 0x17006980 RID: 27008
		// (get) Token: 0x06015266 RID: 86630 RVA: 0x00310938 File Offset: 0x0030EB38
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

		// Token: 0x17006981 RID: 27009
		// (get) Token: 0x06015267 RID: 86631 RVA: 0x00310974 File Offset: 0x0030EB74
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

		// Token: 0x17006982 RID: 27010
		// (get) Token: 0x06015268 RID: 86632 RVA: 0x003109B4 File Offset: 0x0030EBB4
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

		// Token: 0x17006983 RID: 27011
		// (get) Token: 0x06015269 RID: 86633 RVA: 0x003109F8 File Offset: 0x0030EBF8
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

		// Token: 0x0601526A RID: 86634 RVA: 0x00310A35 File Offset: 0x0030EC35
		public static Offset<IConeTipsActor> CreateIConeTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Height = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IConeTipsActor.AddHeight(builder, Height);
			IConeTipsActor.AddRadius(builder, Radius);
			IConeTipsActor.AddNullMask(builder, NullMask);
			IConeTipsActor.AddColorType(builder, ColorType);
			IConeTipsActor.AddType(builder, Type);
			return IConeTipsActor.EndIConeTipsActor(builder);
		}

		// Token: 0x0601526B RID: 86635 RVA: 0x00310A69 File Offset: 0x0030EC69
		public static void StartIConeTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601526C RID: 86636 RVA: 0x00310A72 File Offset: 0x0030EC72
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601526D RID: 86637 RVA: 0x00310A7D File Offset: 0x0030EC7D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601526E RID: 86638 RVA: 0x00310A88 File Offset: 0x0030EC88
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x0601526F RID: 86639 RVA: 0x00310A9B File Offset: 0x0030EC9B
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(3, height, 0.0);
		}

		// Token: 0x06015270 RID: 86640 RVA: 0x00310AAE File Offset: 0x0030ECAE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015271 RID: 86641 RVA: 0x00310AB9 File Offset: 0x0030ECB9
		public static Offset<IConeTipsActor> EndIConeTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IConeTipsActor>(builder.EndTable());
		}

		// Token: 0x06015272 RID: 86642 RVA: 0x00310AC8 File Offset: 0x0030ECC8
		public IConeTipsActorT UnPack()
		{
			IConeTipsActorT coneTipsActorT = new IConeTipsActorT();
			this.UnPackTo(coneTipsActorT);
			return coneTipsActorT;
		}

		// Token: 0x06015273 RID: 86643 RVA: 0x00310AE3 File Offset: 0x0030ECE3
		public void UnPackTo(IConeTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015274 RID: 86644 RVA: 0x00310B24 File Offset: 0x0030ED24
		public static Offset<IConeTipsActor> Pack(FlatBufferBuilder builder, IConeTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConeTipsActor>);
			}
			return IConeTipsActor.CreateIConeTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Height, _o.NullMask);
		}

		// Token: 0x0400B1D3 RID: 45523
		private Table __p;
	}
}
