using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF8 RID: 16376
	public struct IBottomAlignSemiBoxTipsActor : IFlatbufferObject
	{
		// Token: 0x17006EE4 RID: 28388
		// (get) Token: 0x0601666F RID: 91759 RVA: 0x00335255 File Offset: 0x00333455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016670 RID: 91760 RVA: 0x00335262 File Offset: 0x00333462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016671 RID: 91761 RVA: 0x0033526C File Offset: 0x0033346C
		public static IBottomAlignSemiBoxTipsActor GetRootAsIBottomAlignSemiBoxTipsActor(ByteBuffer _bb)
		{
			return IBottomAlignSemiBoxTipsActor.GetRootAsIBottomAlignSemiBoxTipsActor(_bb, default(IBottomAlignSemiBoxTipsActor));
		}

		// Token: 0x06016672 RID: 91762 RVA: 0x00335288 File Offset: 0x00333488
		public static IBottomAlignSemiBoxTipsActor GetRootAsIBottomAlignSemiBoxTipsActor(ByteBuffer _bb, IBottomAlignSemiBoxTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016673 RID: 91763 RVA: 0x003352A5 File Offset: 0x003334A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016674 RID: 91764 RVA: 0x003352B4 File Offset: 0x003334B4
		public IBottomAlignSemiBoxTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EE5 RID: 28389
		// (get) Token: 0x06016675 RID: 91765 RVA: 0x003352C4 File Offset: 0x003334C4
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

		// Token: 0x17006EE6 RID: 28390
		// (get) Token: 0x06016676 RID: 91766 RVA: 0x00335300 File Offset: 0x00333500
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

		// Token: 0x17006EE7 RID: 28391
		// (get) Token: 0x06016677 RID: 91767 RVA: 0x0033533C File Offset: 0x0033353C
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

		// Token: 0x17006EE8 RID: 28392
		// (get) Token: 0x06016678 RID: 91768 RVA: 0x0033537C File Offset: 0x0033357C
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

		// Token: 0x17006EE9 RID: 28393
		// (get) Token: 0x06016679 RID: 91769 RVA: 0x003353C0 File Offset: 0x003335C0
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

		// Token: 0x17006EEA RID: 28394
		// (get) Token: 0x0601667A RID: 91770 RVA: 0x00335404 File Offset: 0x00333604
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

		// Token: 0x0601667B RID: 91771 RVA: 0x00335441 File Offset: 0x00333641
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

		// Token: 0x0601667C RID: 91772 RVA: 0x0033547D File Offset: 0x0033367D
		public static void StartIBottomAlignSemiBoxTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601667D RID: 91773 RVA: 0x00335486 File Offset: 0x00333686
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601667E RID: 91774 RVA: 0x00335491 File Offset: 0x00333691
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x0601667F RID: 91775 RVA: 0x0033549C File Offset: 0x0033369C
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(2, x, 0.0);
		}

		// Token: 0x06016680 RID: 91776 RVA: 0x003354AF File Offset: 0x003336AF
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(3, y, 0.0);
		}

		// Token: 0x06016681 RID: 91777 RVA: 0x003354C2 File Offset: 0x003336C2
		public static void AddZ(FlatBufferBuilder builder, float z)
		{
			builder.AddFloat(4, z, 0.0);
		}

		// Token: 0x06016682 RID: 91778 RVA: 0x003354D5 File Offset: 0x003336D5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016683 RID: 91779 RVA: 0x003354E0 File Offset: 0x003336E0
		public static Offset<IBottomAlignSemiBoxTipsActor> EndIBottomAlignSemiBoxTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<IBottomAlignSemiBoxTipsActor>(builder.EndTable());
		}

		// Token: 0x06016684 RID: 91780 RVA: 0x003354F0 File Offset: 0x003336F0
		public IBottomAlignSemiBoxTipsActorT UnPack()
		{
			IBottomAlignSemiBoxTipsActorT bottomAlignSemiBoxTipsActorT = new IBottomAlignSemiBoxTipsActorT();
			this.UnPackTo(bottomAlignSemiBoxTipsActorT);
			return bottomAlignSemiBoxTipsActorT;
		}

		// Token: 0x06016685 RID: 91781 RVA: 0x0033550C File Offset: 0x0033370C
		public void UnPackTo(IBottomAlignSemiBoxTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016686 RID: 91782 RVA: 0x00335564 File Offset: 0x00333764
		public static Offset<IBottomAlignSemiBoxTipsActor> Pack(FlatBufferBuilder builder, IBottomAlignSemiBoxTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBottomAlignSemiBoxTipsActor>);
			}
			return IBottomAlignSemiBoxTipsActor.CreateIBottomAlignSemiBoxTipsActor(builder, _o.Type, _o.ColorType, _o.X, _o.Y, _o.Z, _o.NullMask);
		}

		// Token: 0x0400BB3A RID: 47930
		private Table __p;
	}
}
