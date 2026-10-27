using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BEC RID: 15340
	public struct IBottomAlignSemiBoxTipsActor : IFlatbufferObject
	{
		// Token: 0x1700693C RID: 26940
		// (get) Token: 0x06015179 RID: 86393 RVA: 0x0030E6CD File Offset: 0x0030C8CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601517A RID: 86394 RVA: 0x0030E6DA File Offset: 0x0030C8DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601517B RID: 86395 RVA: 0x0030E6E4 File Offset: 0x0030C8E4
		public static IBottomAlignSemiBoxTipsActor GetRootAsIBottomAlignSemiBoxTipsActor(ByteBuffer _bb)
		{
			return IBottomAlignSemiBoxTipsActor.GetRootAsIBottomAlignSemiBoxTipsActor(_bb, default(IBottomAlignSemiBoxTipsActor));
		}

		// Token: 0x0601517C RID: 86396 RVA: 0x0030E700 File Offset: 0x0030C900
		public static IBottomAlignSemiBoxTipsActor GetRootAsIBottomAlignSemiBoxTipsActor(ByteBuffer _bb, IBottomAlignSemiBoxTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601517D RID: 86397 RVA: 0x0030E71D File Offset: 0x0030C91D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601517E RID: 86398 RVA: 0x0030E72C File Offset: 0x0030C92C
		public IBottomAlignSemiBoxTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700693D RID: 26941
		// (get) Token: 0x0601517F RID: 86399 RVA: 0x0030E73C File Offset: 0x0030C93C
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

		// Token: 0x1700693E RID: 26942
		// (get) Token: 0x06015180 RID: 86400 RVA: 0x0030E778 File Offset: 0x0030C978
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

		// Token: 0x1700693F RID: 26943
		// (get) Token: 0x06015181 RID: 86401 RVA: 0x0030E7B4 File Offset: 0x0030C9B4
		public float X
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

		// Token: 0x17006940 RID: 26944
		// (get) Token: 0x06015182 RID: 86402 RVA: 0x0030E7F4 File Offset: 0x0030C9F4
		public float Y
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

		// Token: 0x17006941 RID: 26945
		// (get) Token: 0x06015183 RID: 86403 RVA: 0x0030E838 File Offset: 0x0030CA38
		public float Z
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

		// Token: 0x17006942 RID: 26946
		// (get) Token: 0x06015184 RID: 86404 RVA: 0x0030E87C File Offset: 0x0030CA7C
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

		// Token: 0x06015185 RID: 86405 RVA: 0x0030E8B9 File Offset: 0x0030CAB9
		public static Offset<IBottomAlignSemiBoxTipsActor> CreateIBottomAlignSemiBoxTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float X = 0f, float Y = 0f, float Z = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IBottomAlignSemiBoxTipsActor.AddZ(builder, Z);
			IBottomAlignSemiBoxTipsActor.AddY(builder, Y);
			IBottomAlignSemiBoxTipsActor.AddX(builder, X);
			IBottomAlignSemiBoxTipsActor.AddNullMask(builder, NullMask);
			IBottomAlignSemiBoxTipsActor.AddColorType(builder, ColorType);
			IBottomAlignSemiBoxTipsActor.AddType(builder, Type);
			return IBottomAlignSemiBoxTipsActor.EndIBottomAlignSemiBoxTipsActor(builder);
		}

		// Token: 0x06015186 RID: 86406 RVA: 0x0030E8F5 File Offset: 0x0030CAF5
		public static void StartIBottomAlignSemiBoxTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015187 RID: 86407 RVA: 0x0030E8FE File Offset: 0x0030CAFE
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015188 RID: 86408 RVA: 0x0030E909 File Offset: 0x0030CB09
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06015189 RID: 86409 RVA: 0x0030E914 File Offset: 0x0030CB14
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(2, x, 0.0);
		}

		// Token: 0x0601518A RID: 86410 RVA: 0x0030E927 File Offset: 0x0030CB27
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(3, y, 0.0);
		}

		// Token: 0x0601518B RID: 86411 RVA: 0x0030E93A File Offset: 0x0030CB3A
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(4, z, 0.0);
		}

		// Token: 0x0601518C RID: 86412 RVA: 0x0030E94D File Offset: 0x0030CB4D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601518D RID: 86413 RVA: 0x0030E958 File Offset: 0x0030CB58
		public static Offset<IBottomAlignSemiBoxTipsActor> EndIBottomAlignSemiBoxTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IBottomAlignSemiBoxTipsActor>(builder.EndTable());
		}

		// Token: 0x0601518E RID: 86414 RVA: 0x0030E968 File Offset: 0x0030CB68
		public IBottomAlignSemiBoxTipsActorT UnPack()
		{
			IBottomAlignSemiBoxTipsActorT bottomAlignSemiBoxTipsActorT = new IBottomAlignSemiBoxTipsActorT();
			this.UnPackTo(bottomAlignSemiBoxTipsActorT);
			return bottomAlignSemiBoxTipsActorT;
		}

		// Token: 0x0601518F RID: 86415 RVA: 0x0030E984 File Offset: 0x0030CB84
		public void UnPackTo(IBottomAlignSemiBoxTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015190 RID: 86416 RVA: 0x0030E9DC File Offset: 0x0030CBDC
		public static Offset<IBottomAlignSemiBoxTipsActor> Pack(FlatBufferBuilder builder, IBottomAlignSemiBoxTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBottomAlignSemiBoxTipsActor>);
			}
			return IBottomAlignSemiBoxTipsActor.CreateIBottomAlignSemiBoxTipsActor(builder, _o.Type, _o.ColorType, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400B1AF RID: 45487
		private Table __p;
	}
}
