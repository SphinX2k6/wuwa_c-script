using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549D RID: 21661
	public struct IItemLockingConfig : IFlatbufferObject
	{
		// Token: 0x17009F7E RID: 40830
		// (get) Token: 0x06023A6A RID: 146026 RVA: 0x004EDD2C File Offset: 0x004EBF2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A6B RID: 146027 RVA: 0x004EDD39 File Offset: 0x004EBF39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A6C RID: 146028 RVA: 0x004EDD40 File Offset: 0x004EBF40
		public static IItemLockingConfig GetRootAsIItemLockingConfig(ByteBuffer _bb)
		{
			return IItemLockingConfig.GetRootAsIItemLockingConfig(_bb, default(IItemLockingConfig));
		}

		// Token: 0x06023A6D RID: 146029 RVA: 0x004EDD5C File Offset: 0x004EBF5C
		public static IItemLockingConfig GetRootAsIItemLockingConfig(ByteBuffer _bb, IItemLockingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A6E RID: 146030 RVA: 0x004EDD79 File Offset: 0x004EBF79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A6F RID: 146031 RVA: 0x004EDD88 File Offset: 0x004EBF88
		public IItemLockingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F7F RID: 40831
		// (get) Token: 0x06023A70 RID: 146032 RVA: 0x004EDD98 File Offset: 0x004EBF98
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A71 RID: 146033 RVA: 0x004EDDCF File Offset: 0x004EBFCF
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023A72 RID: 146034 RVA: 0x004EDDDE File Offset: 0x004EBFDE
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009F80 RID: 40832
		// (get) Token: 0x06023A73 RID: 146035 RVA: 0x004EDDEC File Offset: 0x004EBFEC
		public ETeleControlLockingPerform TeleControlPerform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETeleControlLockingPerform.RightMatch;
				}
				return (ETeleControlLockingPerform)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F81 RID: 40833
		// (get) Token: 0x06023A74 RID: 146036 RVA: 0x004EDE28 File Offset: 0x004EC028
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

		// Token: 0x06023A75 RID: 146037 RVA: 0x004EDE64 File Offset: 0x004EC064
		public static Offset<IItemLockingConfig> CreateIItemLockingConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), ETeleControlLockingPerform TeleControlPerform = ETeleControlLockingPerform.RightMatch, byte NullMask = 0)
		{
			builder.StartTable(3);
			IItemLockingConfig.AddEffectPath(builder, EffectPathOffset);
			IItemLockingConfig.AddNullMask(builder, NullMask);
			IItemLockingConfig.AddTeleControlPerform(builder, TeleControlPerform);
			return IItemLockingConfig.EndIItemLockingConfig(builder);
		}

		// Token: 0x06023A76 RID: 146038 RVA: 0x004EDE88 File Offset: 0x004EC088
		public static void StartIItemLockingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023A77 RID: 146039 RVA: 0x004EDE91 File Offset: 0x004EC091
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06023A78 RID: 146040 RVA: 0x004EDEA1 File Offset: 0x004EC0A1
		public static void AddTeleControlPerform(FlatBufferBuilder builder, ETeleControlLockingPerform teleControlPerform)
		{
			builder.AddByte(1, (byte)teleControlPerform, 0);
		}

		// Token: 0x06023A79 RID: 146041 RVA: 0x004EDEAC File Offset: 0x004EC0AC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023A7A RID: 146042 RVA: 0x004EDEB7 File Offset: 0x004EC0B7
		public static Offset<IItemLockingConfig> EndIItemLockingConfig(FlatBufferBuilder builder)
		{
			return new Offset<IItemLockingConfig>(builder.EndTable());
		}

		// Token: 0x06023A7B RID: 146043 RVA: 0x004EDEC4 File Offset: 0x004EC0C4
		public IItemLockingConfigT UnPack()
		{
			IItemLockingConfigT itemLockingConfigT = new IItemLockingConfigT();
			this.UnPackTo(itemLockingConfigT);
			return itemLockingConfigT;
		}

		// Token: 0x06023A7C RID: 146044 RVA: 0x004EDEDF File Offset: 0x004EC0DF
		public void UnPackTo(IItemLockingConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.TeleControlPerform = this.TeleControlPerform;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023A7D RID: 146045 RVA: 0x004EDF08 File Offset: 0x004EC108
		public static Offset<IItemLockingConfig> Pack(FlatBufferBuilder builder, IItemLockingConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemLockingConfig>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return IItemLockingConfig.CreateIItemLockingConfig(builder, effectPathOffset, _o.TeleControlPerform, _o.NullMask);
		}

		// Token: 0x0400E738 RID: 59192
		private Table __p;
	}
}
