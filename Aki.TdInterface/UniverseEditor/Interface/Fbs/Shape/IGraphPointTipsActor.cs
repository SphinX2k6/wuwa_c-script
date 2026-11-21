using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004022 RID: 16418
	public struct IGraphPointTipsActor : IFlatbufferObject
	{
		// Token: 0x17006F71 RID: 28529
		// (get) Token: 0x0601683F RID: 92223 RVA: 0x00339044 File Offset: 0x00337244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016840 RID: 92224 RVA: 0x00339051 File Offset: 0x00337251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016841 RID: 92225 RVA: 0x00339058 File Offset: 0x00337258
		public static IGraphPointTipsActor GetRootAsIGraphPointTipsActor(ByteBuffer _bb)
		{
			return IGraphPointTipsActor.GetRootAsIGraphPointTipsActor(_bb, default(IGraphPointTipsActor));
		}

		// Token: 0x06016842 RID: 92226 RVA: 0x00339074 File Offset: 0x00337274
		public static IGraphPointTipsActor GetRootAsIGraphPointTipsActor(ByteBuffer _bb, IGraphPointTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x00339091 File Offset: 0x00337291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016844 RID: 92228 RVA: 0x003390A0 File Offset: 0x003372A0
		public IGraphPointTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F72 RID: 28530
		// (get) Token: 0x06016845 RID: 92229 RVA: 0x003390B0 File Offset: 0x003372B0
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

		// Token: 0x17006F73 RID: 28531
		// (get) Token: 0x06016846 RID: 92230 RVA: 0x003390EC File Offset: 0x003372EC
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

		// Token: 0x17006F74 RID: 28532
		// (get) Token: 0x06016847 RID: 92231 RVA: 0x00339128 File Offset: 0x00337328
		public float Size
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

		// Token: 0x17006F75 RID: 28533
		// (get) Token: 0x06016848 RID: 92232 RVA: 0x00339168 File Offset: 0x00337368
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

		// Token: 0x06016849 RID: 92233 RVA: 0x003391A5 File Offset: 0x003373A5
		public static Offset<IGraphPointTipsActor> CreateIGraphPointTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Size = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGraphPointTipsActor.AddSize(builder, Size);
			IGraphPointTipsActor.AddNullMask(builder, NullMask);
			IGraphPointTipsActor.AddColorType(builder, ColorType);
			IGraphPointTipsActor.AddType(builder, Type);
			return IGraphPointTipsActor.EndIGraphPointTipsActor(builder);
		}

		// Token: 0x0601684A RID: 92234 RVA: 0x003391D1 File Offset: 0x003373D1
		public static void StartIGraphPointTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601684B RID: 92235 RVA: 0x003391DA File Offset: 0x003373DA
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601684C RID: 92236 RVA: 0x003391E5 File Offset: 0x003373E5
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601684D RID: 92237 RVA: 0x003391F0 File Offset: 0x003373F0
		public static void AddSize(FlatBufferBuilder builder, float size)
		{
			builder.AddFloat(2, size, 0.0);
		}

		// Token: 0x0601684E RID: 92238 RVA: 0x00339203 File Offset: 0x00337403
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601684F RID: 92239 RVA: 0x0033920E File Offset: 0x0033740E
		public static Offset<IGraphPointTipsActor> EndIGraphPointTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IGraphPointTipsActor>(builder.EndTable());
		}

		// Token: 0x06016850 RID: 92240 RVA: 0x0033921C File Offset: 0x0033741C
		public IGraphPointTipsActorT UnPack()
		{
			IGraphPointTipsActorT graphPointTipsActorT = new IGraphPointTipsActorT();
			this.UnPackTo(graphPointTipsActorT);
			return graphPointTipsActorT;
		}

		// Token: 0x06016851 RID: 92241 RVA: 0x00339237 File Offset: 0x00337437
		public void UnPackTo(IGraphPointTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Size = this.Size;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016852 RID: 92242 RVA: 0x0033926C File Offset: 0x0033746C
		public static Offset<IGraphPointTipsActor> Pack(FlatBufferBuilder builder, IGraphPointTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraphPointTipsActor>);
			}
			return IGraphPointTipsActor.CreateIGraphPointTipsActor(builder, _o.Type, _o.ColorType, _o.Size, _o.NullMask);
		}

		// Token: 0x0400BB87 RID: 48007
		private Table __p;
	}
}
