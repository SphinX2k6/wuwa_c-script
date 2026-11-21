using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF2 RID: 16370
	public struct IActorParam : IFlatbufferObject
	{
		// Token: 0x17006EDA RID: 28378
		// (get) Token: 0x06016643 RID: 91715 RVA: 0x00334E50 File Offset: 0x00333050
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016644 RID: 91716 RVA: 0x00334E5D File Offset: 0x0033305D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016645 RID: 91717 RVA: 0x00334E64 File Offset: 0x00333064
		public static IActorParam GetRootAsIActorParam(ByteBuffer _bb)
		{
			return IActorParam.GetRootAsIActorParam(_bb, default(IActorParam));
		}

		// Token: 0x06016646 RID: 91718 RVA: 0x00334E80 File Offset: 0x00333080
		public static IActorParam GetRootAsIActorParam(ByteBuffer _bb, IActorParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016647 RID: 91719 RVA: 0x00334E9D File Offset: 0x0033309D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016648 RID: 91720 RVA: 0x00334EAC File Offset: 0x003330AC
		public IActorParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EDB RID: 28379
		// (get) Token: 0x06016649 RID: 91721 RVA: 0x00334EBC File Offset: 0x003330BC
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

		// Token: 0x17006EDC RID: 28380
		// (get) Token: 0x0601664A RID: 91722 RVA: 0x00334EF8 File Offset: 0x003330F8
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

		// Token: 0x17006EDD RID: 28381
		// (get) Token: 0x0601664B RID: 91723 RVA: 0x00334F34 File Offset: 0x00333134
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

		// Token: 0x0601664C RID: 91724 RVA: 0x00334F70 File Offset: 0x00333170
		public static Offset<IActorParam> CreateIActorParam(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorParam.AddNullMask(builder, NullMask);
			IActorParam.AddColorType(builder, ColorType);
			IActorParam.AddType(builder, Type);
			return IActorParam.EndIActorParam(builder);
		}

		// Token: 0x0601664D RID: 91725 RVA: 0x00334F94 File Offset: 0x00333194
		public static void StartIActorParam(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601664E RID: 91726 RVA: 0x00334F9D File Offset: 0x0033319D
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601664F RID: 91727 RVA: 0x00334FA8 File Offset: 0x003331A8
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016650 RID: 91728 RVA: 0x00334FB3 File Offset: 0x003331B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06016651 RID: 91729 RVA: 0x00334FBE File Offset: 0x003331BE
		public static Offset<IActorParam> EndIActorParam(FlatBufferBuilder builder)
		{
			return new Offset<IActorParam>(builder.EndTable());
		}

		// Token: 0x06016652 RID: 91730 RVA: 0x00334FCC File Offset: 0x003331CC
		public IActorParamT UnPack()
		{
			IActorParamT actorParamT = new IActorParamT();
			this.UnPackTo(actorParamT);
			return actorParamT;
		}

		// Token: 0x06016653 RID: 91731 RVA: 0x00334FE7 File Offset: 0x003331E7
		public void UnPackTo(IActorParamT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016654 RID: 91732 RVA: 0x00335010 File Offset: 0x00333210
		public static Offset<IActorParam> Pack(FlatBufferBuilder builder, IActorParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorParam>);
			}
			return IActorParam.CreateIActorParam(builder, _o.Type, _o.ColorType, _o.NullMask);
		}

		// Token: 0x0400BB34 RID: 47924
		private Table __p;
	}
}
