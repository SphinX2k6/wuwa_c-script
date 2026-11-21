using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D36 RID: 19766
	public struct Record_Int_IEntityDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008D9D RID: 36253
		// (get) Token: 0x0601EA53 RID: 125523 RVA: 0x00449F90 File Offset: 0x00448190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA54 RID: 125524 RVA: 0x00449F9D File Offset: 0x0044819D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA55 RID: 125525 RVA: 0x00449FA4 File Offset: 0x004481A4
		public static Record_Int_IEntityDeployConfig GetRootAsRecord_Int_IEntityDeployConfig(ByteBuffer _bb)
		{
			return Record_Int_IEntityDeployConfig.GetRootAsRecord_Int_IEntityDeployConfig(_bb, default(Record_Int_IEntityDeployConfig));
		}

		// Token: 0x0601EA56 RID: 125526 RVA: 0x00449FC0 File Offset: 0x004481C0
		public static Record_Int_IEntityDeployConfig GetRootAsRecord_Int_IEntityDeployConfig(ByteBuffer _bb, Record_Int_IEntityDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA57 RID: 125527 RVA: 0x00449FDD File Offset: 0x004481DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA58 RID: 125528 RVA: 0x00449FEC File Offset: 0x004481EC
		public Record_Int_IEntityDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D9E RID: 36254
		// (get) Token: 0x0601EA59 RID: 125529 RVA: 0x00449FFC File Offset: 0x004481FC
		public int Key
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

		// Token: 0x17008D9F RID: 36255
		// (get) Token: 0x0601EA5A RID: 125530 RVA: 0x0044A038 File Offset: 0x00448238
		public IEntityDeployConfig? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityDeployConfig?(default(IEntityDeployConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601EA5B RID: 125531 RVA: 0x0044A095 File Offset: 0x00448295
		public static Offset<Record_Int_IEntityDeployConfig> CreateRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder, int Key = 0, Offset<IEntityDeployConfig> ValueOffset = default(Offset<IEntityDeployConfig>))
		{
			builder.StartTable(2);
			Record_Int_IEntityDeployConfig.AddValue(builder, ValueOffset);
			Record_Int_IEntityDeployConfig.AddKey(builder, Key);
			return Record_Int_IEntityDeployConfig.EndRecord_Int_IEntityDeployConfig(builder);
		}

		// Token: 0x0601EA5C RID: 125532 RVA: 0x0044A0B2 File Offset: 0x004482B2
		public static void StartRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EA5D RID: 125533 RVA: 0x0044A0BB File Offset: 0x004482BB
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EA5E RID: 125534 RVA: 0x0044A0C6 File Offset: 0x004482C6
		public static void AddValue(FlatBufferBuilder builder, Offset<IEntityDeployConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601EA5F RID: 125535 RVA: 0x0044A0D6 File Offset: 0x004482D6
		public static Offset<Record_Int_IEntityDeployConfig> EndRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IEntityDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601EA60 RID: 125536 RVA: 0x0044A0E4 File Offset: 0x004482E4
		public Record_Int_IEntityDeployConfigT UnPack()
		{
			Record_Int_IEntityDeployConfigT record_Int_IEntityDeployConfigT = new Record_Int_IEntityDeployConfigT();
			this.UnPackTo(record_Int_IEntityDeployConfigT);
			return record_Int_IEntityDeployConfigT;
		}

		// Token: 0x0601EA61 RID: 125537 RVA: 0x0044A100 File Offset: 0x00448300
		public void UnPackTo(Record_Int_IEntityDeployConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601EA62 RID: 125538 RVA: 0x0044A148 File Offset: 0x00448348
		public static Offset<Record_Int_IEntityDeployConfig> Pack(FlatBufferBuilder builder, Record_Int_IEntityDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IEntityDeployConfig>);
			}
			Offset<IEntityDeployConfig> valueOffset = (_o.Value == null) ? default(Offset<IEntityDeployConfig>) : IEntityDeployConfig.Pack(builder, _o.Value);
			return Record_Int_IEntityDeployConfig.CreateRecord_Int_IEntityDeployConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400D914 RID: 55572
		private Table __p;
	}
}
