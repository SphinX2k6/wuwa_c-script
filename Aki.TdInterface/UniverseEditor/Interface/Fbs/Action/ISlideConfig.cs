using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200790B RID: 30987
	public struct ISlideConfig : IFlatbufferObject
	{
		// Token: 0x1700E34E RID: 58190
		// (get) Token: 0x060368F2 RID: 223474 RVA: 0x0074D77E File Offset: 0x0074B97E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368F3 RID: 223475 RVA: 0x0074D78B File Offset: 0x0074B98B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368F4 RID: 223476 RVA: 0x0074D794 File Offset: 0x0074B994
		public static ISlideConfig GetRootAsISlideConfig(ByteBuffer _bb)
		{
			return ISlideConfig.GetRootAsISlideConfig(_bb, default(ISlideConfig));
		}

		// Token: 0x060368F5 RID: 223477 RVA: 0x0074D7B0 File Offset: 0x0074B9B0
		public static ISlideConfig GetRootAsISlideConfig(ByteBuffer _bb, ISlideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368F6 RID: 223478 RVA: 0x0074D7CD File Offset: 0x0074B9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368F7 RID: 223479 RVA: 0x0074D7DC File Offset: 0x0074B9DC
		public ISlideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E34F RID: 58191
		// (get) Token: 0x060368F8 RID: 223480 RVA: 0x0074D7EC File Offset: 0x0074B9EC
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E350 RID: 58192
		// (get) Token: 0x060368F9 RID: 223481 RVA: 0x0074D828 File Offset: 0x0074BA28
		public int SlideId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060368FA RID: 223482 RVA: 0x0074D864 File Offset: 0x0074BA64
		public static Offset<ISlideConfig> CreateISlideConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, int SlideId = 0)
		{
			builder.StartTable(2);
			ISlideConfig.AddSlideId(builder, SlideId);
			ISlideConfig.AddType(builder, Type);
			return ISlideConfig.EndISlideConfig(builder);
		}

		// Token: 0x060368FB RID: 223483 RVA: 0x0074D881 File Offset: 0x0074BA81
		public static void StartISlideConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060368FC RID: 223484 RVA: 0x0074D88A File Offset: 0x0074BA8A
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060368FD RID: 223485 RVA: 0x0074D895 File Offset: 0x0074BA95
		public static void AddSlideId(FlatBufferBuilder builder, int slideId)
		{
			builder.AddInt(1, slideId, 0);
		}

		// Token: 0x060368FE RID: 223486 RVA: 0x0074D8A0 File Offset: 0x0074BAA0
		public static Offset<ISlideConfig> EndISlideConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlideConfig>(builder.EndTable());
		}

		// Token: 0x060368FF RID: 223487 RVA: 0x0074D8B0 File Offset: 0x0074BAB0
		public ISlideConfigT UnPack()
		{
			ISlideConfigT slideConfigT = new ISlideConfigT();
			this.UnPackTo(slideConfigT);
			return slideConfigT;
		}

		// Token: 0x06036900 RID: 223488 RVA: 0x0074D8CB File Offset: 0x0074BACB
		public void UnPackTo(ISlideConfigT _o)
		{
			_o.Type = this.Type;
			_o.SlideId = this.SlideId;
		}

		// Token: 0x06036901 RID: 223489 RVA: 0x0074D8E8 File Offset: 0x0074BAE8
		public static Offset<ISlideConfig> Pack(FlatBufferBuilder builder, ISlideConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideConfig>);
			}
			return ISlideConfig.CreateISlideConfig(builder, _o.Type, _o.SlideId);
		}

		// Token: 0x04012BC8 RID: 76744
		private Table __p;
	}
}
