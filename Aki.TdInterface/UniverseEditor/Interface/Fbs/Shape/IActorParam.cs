using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE6 RID: 15334
	public struct IActorParam : IFlatbufferObject
	{
		// Token: 0x17006932 RID: 26930
		// (get) Token: 0x0601514D RID: 86349 RVA: 0x0030E2C8 File Offset: 0x0030C4C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601514E RID: 86350 RVA: 0x0030E2D5 File Offset: 0x0030C4D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601514F RID: 86351 RVA: 0x0030E2DC File Offset: 0x0030C4DC
		public static IActorParam GetRootAsIActorParam(ByteBuffer _bb)
		{
			return IActorParam.GetRootAsIActorParam(_bb, default(IActorParam));
		}

		// Token: 0x06015150 RID: 86352 RVA: 0x0030E2F8 File Offset: 0x0030C4F8
		public static IActorParam GetRootAsIActorParam(ByteBuffer _bb, IActorParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015151 RID: 86353 RVA: 0x0030E315 File Offset: 0x0030C515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015152 RID: 86354 RVA: 0x0030E324 File Offset: 0x0030C524
		public IActorParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006933 RID: 26931
		// (get) Token: 0x06015153 RID: 86355 RVA: 0x0030E334 File Offset: 0x0030C534
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

		// Token: 0x17006934 RID: 26932
		// (get) Token: 0x06015154 RID: 86356 RVA: 0x0030E370 File Offset: 0x0030C570
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

		// Token: 0x17006935 RID: 26933
		// (get) Token: 0x06015155 RID: 86357 RVA: 0x0030E3AC File Offset: 0x0030C5AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015156 RID: 86358 RVA: 0x0030E3E8 File Offset: 0x0030C5E8
		public static Offset<IActorParam> CreateIActorParam(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorParam.AddNullMask(builder, NullMask);
			IActorParam.AddColorType(builder, ColorType);
			IActorParam.AddType(builder, Type);
			return IActorParam.EndIActorParam(builder);
		}

		// Token: 0x06015157 RID: 86359 RVA: 0x0030E40C File Offset: 0x0030C60C
		public static void StartIActorParam(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015158 RID: 86360 RVA: 0x0030E415 File Offset: 0x0030C615
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015159 RID: 86361 RVA: 0x0030E420 File Offset: 0x0030C620
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601515A RID: 86362 RVA: 0x0030E42B File Offset: 0x0030C62B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601515B RID: 86363 RVA: 0x0030E436 File Offset: 0x0030C636
		public static Offset<IActorParam> EndIActorParam(FlatBufferBuilder builder)
		{
			return new Offset<IActorParam>(builder.EndTable());
		}

		// Token: 0x0601515C RID: 86364 RVA: 0x0030E444 File Offset: 0x0030C644
		public IActorParamT UnPack()
		{
			IActorParamT actorParamT = new IActorParamT();
			this.UnPackTo(actorParamT);
			return actorParamT;
		}

		// Token: 0x0601515D RID: 86365 RVA: 0x0030E45F File Offset: 0x0030C65F
		public void UnPackTo(IActorParamT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601515E RID: 86366 RVA: 0x0030E488 File Offset: 0x0030C688
		public static Offset<IActorParam> Pack(FlatBufferBuilder builder, IActorParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorParam>);
			}
			return IActorParam.CreateIActorParam(builder, _o.Type, _o.ColorType, _o.NullMask);
		}

		// Token: 0x0400B1A9 RID: 45481
		private Table __p;
	}
}
