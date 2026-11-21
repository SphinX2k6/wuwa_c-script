using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701C RID: 28700
	public struct IInstrumentConfig : IFlatbufferObject
	{
		// Token: 0x1700D220 RID: 53792
		// (get) Token: 0x06031B9A RID: 203674 RVA: 0x006BB8BE File Offset: 0x006B9ABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B9B RID: 203675 RVA: 0x006BB8CB File Offset: 0x006B9ACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B9C RID: 203676 RVA: 0x006BB8D4 File Offset: 0x006B9AD4
		public static IInstrumentConfig GetRootAsIInstrumentConfig(ByteBuffer _bb)
		{
			return IInstrumentConfig.GetRootAsIInstrumentConfig(_bb, default(IInstrumentConfig));
		}

		// Token: 0x06031B9D RID: 203677 RVA: 0x006BB8F0 File Offset: 0x006B9AF0
		public static IInstrumentConfig GetRootAsIInstrumentConfig(ByteBuffer _bb, IInstrumentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B9E RID: 203678 RVA: 0x006BB90D File Offset: 0x006B9B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B9F RID: 203679 RVA: 0x006BB91C File Offset: 0x006B9B1C
		public IInstrumentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D221 RID: 53793
		// (get) Token: 0x06031BA0 RID: 203680 RVA: 0x006BB92C File Offset: 0x006B9B2C
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

		// Token: 0x1700D222 RID: 53794
		// (get) Token: 0x06031BA1 RID: 203681 RVA: 0x006BB968 File Offset: 0x006B9B68
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

		// Token: 0x1700D223 RID: 53795
		// (get) Token: 0x06031BA2 RID: 203682 RVA: 0x006BB9A4 File Offset: 0x006B9BA4
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

		// Token: 0x06031BA3 RID: 203683 RVA: 0x006BBA01 File Offset: 0x006B9C01
		public static Offset<IInstrumentConfig> CreateIInstrumentConfig(FlatBufferBuilder builder, int Id = 0, EInstrumentType InstrumentType = EInstrumentType.ChineseZither, Offset<IInstrumentKeyConfigs> KeyConfigsOffset = default(Offset<IInstrumentKeyConfigs>))
		{
			builder.StartTable(3);
			IInstrumentConfig.AddKeyConfigs(builder, KeyConfigsOffset);
			IInstrumentConfig.AddId(builder, Id);
			IInstrumentConfig.AddInstrumentType(builder, InstrumentType);
			return IInstrumentConfig.EndIInstrumentConfig(builder);
		}

		// Token: 0x06031BA4 RID: 203684 RVA: 0x006BBA25 File Offset: 0x006B9C25
		public static void StartIInstrumentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031BA5 RID: 203685 RVA: 0x006BBA2E File Offset: 0x006B9C2E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06031BA6 RID: 203686 RVA: 0x006BBA39 File Offset: 0x006B9C39
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x06031BA7 RID: 203687 RVA: 0x006BBA44 File Offset: 0x006B9C44
		public static void AddKeyConfigs(FlatBufferBuilder builder, Offset<IInstrumentKeyConfigs> keyConfigsOffset)
		{
			builder.AddOffset(2, keyConfigsOffset.Value, 0);
		}

		// Token: 0x06031BA8 RID: 203688 RVA: 0x006BBA54 File Offset: 0x006B9C54
		public static Offset<IInstrumentConfig> EndIInstrumentConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentConfig>(builder.EndTable());
		}

		// Token: 0x06031BA9 RID: 203689 RVA: 0x006BBA64 File Offset: 0x006B9C64
		public IInstrumentConfigT UnPack()
		{
			IInstrumentConfigT instrumentConfigT = new IInstrumentConfigT();
			this.UnPackTo(instrumentConfigT);
			return instrumentConfigT;
		}

		// Token: 0x06031BAA RID: 203690 RVA: 0x006BBA80 File Offset: 0x006B9C80
		public void UnPackTo(IInstrumentConfigT _o)
		{
			_o.Id = this.Id;
			_o.InstrumentType = this.InstrumentType;
			_o.KeyConfigs = ((this.KeyConfigs != null) ? this.KeyConfigs.Value.UnPack() : null);
		}

		// Token: 0x06031BAB RID: 203691 RVA: 0x006BBAD4 File Offset: 0x006B9CD4
		public static Offset<IInstrumentConfig> Pack(FlatBufferBuilder builder, IInstrumentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentConfig>);
			}
			Offset<IInstrumentKeyConfigs> keyConfigsOffset = (_o.KeyConfigs == null) ? default(Offset<IInstrumentKeyConfigs>) : IInstrumentKeyConfigs.Pack(builder, _o.KeyConfigs);
			return IInstrumentConfig.CreateIInstrumentConfig(builder, _o.Id, _o.InstrumentType, keyConfigsOffset);
		}

		// Token: 0x04011F57 RID: 73559
		private Table __p;
	}
}
