using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004718 RID: 18200
	public struct Record_String_IRunningFlowInfo : IFlatbufferObject
	{
		// Token: 0x17008266 RID: 33382
		// (get) Token: 0x0601BF13 RID: 114451 RVA: 0x003F5F3E File Offset: 0x003F413E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF14 RID: 114452 RVA: 0x003F5F4B File Offset: 0x003F414B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF15 RID: 114453 RVA: 0x003F5F54 File Offset: 0x003F4154
		public static Record_String_IRunningFlowInfo GetRootAsRecord_String_IRunningFlowInfo(ByteBuffer _bb)
		{
			return Record_String_IRunningFlowInfo.GetRootAsRecord_String_IRunningFlowInfo(_bb, default(Record_String_IRunningFlowInfo));
		}

		// Token: 0x0601BF16 RID: 114454 RVA: 0x003F5F70 File Offset: 0x003F4170
		public static Record_String_IRunningFlowInfo GetRootAsRecord_String_IRunningFlowInfo(ByteBuffer _bb, Record_String_IRunningFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF17 RID: 114455 RVA: 0x003F5F8D File Offset: 0x003F418D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF18 RID: 114456 RVA: 0x003F5F9C File Offset: 0x003F419C
		public Record_String_IRunningFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008267 RID: 33383
		// (get) Token: 0x0601BF19 RID: 114457 RVA: 0x003F5FAC File Offset: 0x003F41AC
		public string Key
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

		// Token: 0x0601BF1A RID: 114458 RVA: 0x003F5FE3 File Offset: 0x003F41E3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BF1B RID: 114459 RVA: 0x003F5FF2 File Offset: 0x003F41F2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008268 RID: 33384
		// (get) Token: 0x0601BF1C RID: 114460 RVA: 0x003F6000 File Offset: 0x003F4200
		public IRunningFlowInfo? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRunningFlowInfo?(default(IRunningFlowInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BF1D RID: 114461 RVA: 0x003F605D File Offset: 0x003F425D
		public static Offset<Record_String_IRunningFlowInfo> CreateRecord_String_IRunningFlowInfo(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IRunningFlowInfo> ValueOffset = default(Offset<IRunningFlowInfo>))
		{
			builder.StartTable(2);
			Record_String_IRunningFlowInfo.AddValue(builder, ValueOffset);
			Record_String_IRunningFlowInfo.AddKey(builder, KeyOffset);
			return Record_String_IRunningFlowInfo.EndRecord_String_IRunningFlowInfo(builder);
		}

		// Token: 0x0601BF1E RID: 114462 RVA: 0x003F607A File Offset: 0x003F427A
		public static void StartRecord_String_IRunningFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BF1F RID: 114463 RVA: 0x003F6083 File Offset: 0x003F4283
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0601BF20 RID: 114464 RVA: 0x003F6093 File Offset: 0x003F4293
		public static void AddValue(FlatBufferBuilder builder, Offset<IRunningFlowInfo> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601BF21 RID: 114465 RVA: 0x003F60A3 File Offset: 0x003F42A3
		public static Offset<Record_String_IRunningFlowInfo> EndRecord_String_IRunningFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_IRunningFlowInfo>(builder.EndTable());
		}

		// Token: 0x0601BF22 RID: 114466 RVA: 0x003F60B0 File Offset: 0x003F42B0
		public Record_String_IRunningFlowInfoT UnPack()
		{
			Record_String_IRunningFlowInfoT record_String_IRunningFlowInfoT = new Record_String_IRunningFlowInfoT();
			this.UnPackTo(record_String_IRunningFlowInfoT);
			return record_String_IRunningFlowInfoT;
		}

		// Token: 0x0601BF23 RID: 114467 RVA: 0x003F60CC File Offset: 0x003F42CC
		public void UnPackTo(Record_String_IRunningFlowInfoT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601BF24 RID: 114468 RVA: 0x003F6114 File Offset: 0x003F4314
		public static Offset<Record_String_IRunningFlowInfo> Pack(FlatBufferBuilder builder, Record_String_IRunningFlowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_IRunningFlowInfo>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IRunningFlowInfo> valueOffset = (_o.Value == null) ? default(Offset<IRunningFlowInfo>) : IRunningFlowInfo.Pack(builder, _o.Value);
			return Record_String_IRunningFlowInfo.CreateRecord_String_IRunningFlowInfo(builder, keyOffset, valueOffset);
		}

		// Token: 0x0400C9EA RID: 51690
		private Table __p;
	}
}
