using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006969 RID: 26985
	public struct IInstrumentConfig : IFlatbufferObject
	{
		// Token: 0x1700C81D RID: 51229
		// (get) Token: 0x0602F1CA RID: 192970 RVA: 0x0066B3D6 File Offset: 0x006695D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1CB RID: 192971 RVA: 0x0066B3E3 File Offset: 0x006695E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1CC RID: 192972 RVA: 0x0066B3EC File Offset: 0x006695EC
		public static IInstrumentConfig GetRootAsIInstrumentConfig(ByteBuffer _bb)
		{
			return IInstrumentConfig.GetRootAsIInstrumentConfig(_bb, default(IInstrumentConfig));
		}

		// Token: 0x0602F1CD RID: 192973 RVA: 0x0066B408 File Offset: 0x00669608
		public static IInstrumentConfig GetRootAsIInstrumentConfig(ByteBuffer _bb, IInstrumentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1CE RID: 192974 RVA: 0x0066B425 File Offset: 0x00669625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1CF RID: 192975 RVA: 0x0066B434 File Offset: 0x00669634
		public IInstrumentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C81E RID: 51230
		// (get) Token: 0x0602F1D0 RID: 192976 RVA: 0x0066B444 File Offset: 0x00669644
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C81F RID: 51231
		// (get) Token: 0x0602F1D1 RID: 192977 RVA: 0x0066B480 File Offset: 0x00669680
		public EInstrumentType InstrumentType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EInstrumentType.ChineseZither;
				}
				return (EInstrumentType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C820 RID: 51232
		// (get) Token: 0x0602F1D2 RID: 192978 RVA: 0x0066B4BC File Offset: 0x006696BC
		public IInstrumentKeyConfigs? KeyConfigs
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IInstrumentKeyConfigs?(default(IInstrumentKeyConfigs).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F1D3 RID: 192979 RVA: 0x0066B519 File Offset: 0x00669719
		public static Offset<IInstrumentConfig> CreateIInstrumentConfig(FlatBufferBuilder builder, int Id = 0, EInstrumentType InstrumentType = EInstrumentType.ChineseZither, Offset<IInstrumentKeyConfigs> KeyConfigsOffset = default(Offset<IInstrumentKeyConfigs>))
		{
			builder.StartTable(3);
			IInstrumentConfig.AddKeyConfigs(builder, KeyConfigsOffset);
			IInstrumentConfig.AddId(builder, Id);
			IInstrumentConfig.AddInstrumentType(builder, InstrumentType);
			return IInstrumentConfig.EndIInstrumentConfig(builder);
		}

		// Token: 0x0602F1D4 RID: 192980 RVA: 0x0066B53D File Offset: 0x0066973D
		public static void StartIInstrumentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F1D5 RID: 192981 RVA: 0x0066B546 File Offset: 0x00669746
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602F1D6 RID: 192982 RVA: 0x0066B551 File Offset: 0x00669751
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x0602F1D7 RID: 192983 RVA: 0x0066B55C File Offset: 0x0066975C
		public static void AddKeyConfigs(FlatBufferBuilder builder, Offset<IInstrumentKeyConfigs> keyConfigsOffset)
		{
			builder.AddOffset(2, keyConfigsOffset.Value, 0);
		}

		// Token: 0x0602F1D8 RID: 192984 RVA: 0x0066B56C File Offset: 0x0066976C
		public static Offset<IInstrumentConfig> EndIInstrumentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentConfig>(builder.EndTable());
		}

		// Token: 0x0602F1D9 RID: 192985 RVA: 0x0066B57C File Offset: 0x0066977C
		public IInstrumentConfigT UnPack()
		{
			IInstrumentConfigT instrumentConfigT = new IInstrumentConfigT();
			this.UnPackTo(instrumentConfigT);
			return instrumentConfigT;
		}

		// Token: 0x0602F1DA RID: 192986 RVA: 0x0066B598 File Offset: 0x00669798
		public void UnPackTo(IInstrumentConfigT _o)
		{
			_o.Id = this.Id;
			_o.InstrumentType = this.InstrumentType;
			_o.KeyConfigs = ((this.KeyConfigs != null) ? this.KeyConfigs.Value.UnPack() : null);
		}

		// Token: 0x0602F1DB RID: 192987 RVA: 0x0066B5EC File Offset: 0x006697EC
		public static Offset<IInstrumentConfig> Pack(FlatBufferBuilder builder, IInstrumentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentConfig>);
			}
			Offset<IInstrumentKeyConfigs> keyConfigsOffset = (_o.KeyConfigs == null) ? default(Offset<IInstrumentKeyConfigs>) : IInstrumentKeyConfigs.Pack(builder, _o.KeyConfigs);
			return IInstrumentConfig.CreateIInstrumentConfig(builder, _o.Id, _o.InstrumentType, keyConfigsOffset);
		}

		// Token: 0x040110EB RID: 69867
		private Table __p;
	}
}
