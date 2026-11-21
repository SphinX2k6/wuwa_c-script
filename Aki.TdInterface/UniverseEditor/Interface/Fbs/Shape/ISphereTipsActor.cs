using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200404F RID: 16463
	public struct ISphereTipsActor : IFlatbufferObject
	{
		// Token: 0x17006FF3 RID: 28659
		// (get) Token: 0x060169FB RID: 92667 RVA: 0x0033C53D File Offset: 0x0033A73D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169FC RID: 92668 RVA: 0x0033C54A File Offset: 0x0033A74A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169FD RID: 92669 RVA: 0x0033C554 File Offset: 0x0033A754
		public static ISphereTipsActor GetRootAsISphereTipsActor(ByteBuffer _bb)
		{
			return ISphereTipsActor.GetRootAsISphereTipsActor(_bb, default(ISphereTipsActor));
		}

		// Token: 0x060169FE RID: 92670 RVA: 0x0033C570 File Offset: 0x0033A770
		public static ISphereTipsActor GetRootAsISphereTipsActor(ByteBuffer _bb, ISphereTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169FF RID: 92671 RVA: 0x0033C58D File Offset: 0x0033A78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A00 RID: 92672 RVA: 0x0033C59C File Offset: 0x0033A79C
		public ISphereTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FF4 RID: 28660
		// (get) Token: 0x06016A01 RID: 92673 RVA: 0x0033C5AC File Offset: 0x0033A7AC
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

		// Token: 0x17006FF5 RID: 28661
		// (get) Token: 0x06016A02 RID: 92674 RVA: 0x0033C5E8 File Offset: 0x0033A7E8
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

		// Token: 0x17006FF6 RID: 28662
		// (get) Token: 0x06016A03 RID: 92675 RVA: 0x0033C624 File Offset: 0x0033A824
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

		// Token: 0x17006FF7 RID: 28663
		// (get) Token: 0x06016A04 RID: 92676 RVA: 0x0033C664 File Offset: 0x0033A864
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

		// Token: 0x06016A05 RID: 92677 RVA: 0x0033C6A1 File Offset: 0x0033A8A1
		public static Offset<ISphereTipsActor> CreateISphereTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISphereTipsActor.AddRadius(builder, Radius);
			ISphereTipsActor.AddNullMask(builder, NullMask);
			ISphereTipsActor.AddColorType(builder, ColorType);
			ISphereTipsActor.AddType(builder, Type);
			return ISphereTipsActor.EndISphereTipsActor(builder);
		}

		// Token: 0x06016A06 RID: 92678 RVA: 0x0033C6CD File Offset: 0x0033A8CD
		public static void StartISphereTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016A07 RID: 92679 RVA: 0x0033C6D6 File Offset: 0x0033A8D6
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A08 RID: 92680 RVA: 0x0033C6E1 File Offset: 0x0033A8E1
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016A09 RID: 92681 RVA: 0x0033C6EC File Offset: 0x0033A8EC
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x06016A0A RID: 92682 RVA: 0x0033C6FF File Offset: 0x0033A8FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016A0B RID: 92683 RVA: 0x0033C70A File Offset: 0x0033A90A
		public static Offset<ISphereTipsActor> EndISphereTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTipsActor>(builder.EndTable());
		}

		// Token: 0x06016A0C RID: 92684 RVA: 0x0033C718 File Offset: 0x0033A918
		public ISphereTipsActorT UnPack()
		{
			ISphereTipsActorT sphereTipsActorT = new ISphereTipsActorT();
			this.UnPackTo(sphereTipsActorT);
			return sphereTipsActorT;
		}

		// Token: 0x06016A0D RID: 92685 RVA: 0x0033C733 File Offset: 0x0033A933
		public void UnPackTo(ISphereTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016A0E RID: 92686 RVA: 0x0033C768 File Offset: 0x0033A968
		public static Offset<ISphereTipsActor> Pack(FlatBufferBuilder builder, ISphereTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTipsActor>);
			}
			return ISphereTipsActor.CreateISphereTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.NullMask);
		}

		// Token: 0x0400BBD6 RID: 48086
		private Table __p;
	}
}
