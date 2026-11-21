using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007971 RID: 31089
	public struct ISportConfig : IFlatbufferObject
	{
		// Token: 0x1700E3F8 RID: 58360
		// (get) Token: 0x06036C08 RID: 224264 RVA: 0x0075308E File Offset: 0x0075128E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C09 RID: 224265 RVA: 0x0075309B File Offset: 0x0075129B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C0A RID: 224266 RVA: 0x007530A4 File Offset: 0x007512A4
		public static ISportConfig GetRootAsISportConfig(ByteBuffer _bb)
		{
			return ISportConfig.GetRootAsISportConfig(_bb, default(ISportConfig));
		}

		// Token: 0x06036C0B RID: 224267 RVA: 0x007530C0 File Offset: 0x007512C0
		public static ISportConfig GetRootAsISportConfig(ByteBuffer _bb, ISportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C0C RID: 224268 RVA: 0x007530DD File Offset: 0x007512DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C0D RID: 224269 RVA: 0x007530EC File Offset: 0x007512EC
		public ISportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3F9 RID: 58361
		// (get) Token: 0x06036C0E RID: 224270 RVA: 0x007530FC File Offset: 0x007512FC
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

		// Token: 0x06036C0F RID: 224271 RVA: 0x00753138 File Offset: 0x00751338
		public static Offset<ISportConfig> CreateISportConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide)
		{
			builder.StartTable(1);
			ISportConfig.AddType(builder, Type);
			return ISportConfig.EndISportConfig(builder);
		}

		// Token: 0x06036C10 RID: 224272 RVA: 0x0075314E File Offset: 0x0075134E
		public static void StartISportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036C11 RID: 224273 RVA: 0x00753157 File Offset: 0x00751357
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C12 RID: 224274 RVA: 0x00753162 File Offset: 0x00751362
		public static Offset<ISportConfig> EndISportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISportConfig>(builder.EndTable());
		}

		// Token: 0x06036C13 RID: 224275 RVA: 0x00753170 File Offset: 0x00751370
		public ISportConfigT UnPack()
		{
			ISportConfigT sportConfigT = new ISportConfigT();
			this.UnPackTo(sportConfigT);
			return sportConfigT;
		}

		// Token: 0x06036C14 RID: 224276 RVA: 0x0075318B File Offset: 0x0075138B
		public void UnPackTo(ISportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036C15 RID: 224277 RVA: 0x0075319C File Offset: 0x0075139C
		public static Offset<ISportConfig> Pack(FlatBufferBuilder builder, ISportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISportConfig>);
			}
			return ISportConfig.CreateISportConfig(builder, _o.Type);
		}

		// Token: 0x04012C5E RID: 76894
		private Table __p;
	}
}
