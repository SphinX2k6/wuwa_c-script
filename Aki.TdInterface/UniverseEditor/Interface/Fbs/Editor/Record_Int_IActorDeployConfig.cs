using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CB RID: 18635
	public struct Record_Int_IActorDeployConfig : IFlatbufferObject
	{
		// Token: 0x1700874B RID: 34635
		// (get) Token: 0x0601D23A RID: 119354 RVA: 0x0041D2DC File Offset: 0x0041B4DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D23B RID: 119355 RVA: 0x0041D2E9 File Offset: 0x0041B4E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D23C RID: 119356 RVA: 0x0041D2F0 File Offset: 0x0041B4F0
		public static Record_Int_IActorDeployConfig GetRootAsRecord_Int_IActorDeployConfig(ByteBuffer _bb)
		{
			return Record_Int_IActorDeployConfig.GetRootAsRecord_Int_IActorDeployConfig(_bb, default(Record_Int_IActorDeployConfig));
		}

		// Token: 0x0601D23D RID: 119357 RVA: 0x0041D30C File Offset: 0x0041B50C
		public static Record_Int_IActorDeployConfig GetRootAsRecord_Int_IActorDeployConfig(ByteBuffer _bb, Record_Int_IActorDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D23E RID: 119358 RVA: 0x0041D329 File Offset: 0x0041B529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D23F RID: 119359 RVA: 0x0041D338 File Offset: 0x0041B538
		public Record_Int_IActorDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700874C RID: 34636
		// (get) Token: 0x0601D240 RID: 119360 RVA: 0x0041D348 File Offset: 0x0041B548
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

		// Token: 0x1700874D RID: 34637
		// (get) Token: 0x0601D241 RID: 119361 RVA: 0x0041D384 File Offset: 0x0041B584
		public IActorDeployConfig? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActorDeployConfig?(default(IActorDeployConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D242 RID: 119362 RVA: 0x0041D3E1 File Offset: 0x0041B5E1
		public static Offset<Record_Int_IActorDeployConfig> CreateRecord_Int_IActorDeployConfig(FlatBufferBuilder builder, int Key = 0, Offset<IActorDeployConfig> ValueOffset = default(Offset<IActorDeployConfig>))
		{
			builder.StartTable(2);
			Record_Int_IActorDeployConfig.AddValue(builder, ValueOffset);
			Record_Int_IActorDeployConfig.AddKey(builder, Key);
			return Record_Int_IActorDeployConfig.EndRecord_Int_IActorDeployConfig(builder);
		}

		// Token: 0x0601D243 RID: 119363 RVA: 0x0041D3FE File Offset: 0x0041B5FE
		public static void StartRecord_Int_IActorDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D244 RID: 119364 RVA: 0x0041D407 File Offset: 0x0041B607
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D245 RID: 119365 RVA: 0x0041D412 File Offset: 0x0041B612
		public static void AddValue(FlatBufferBuilder builder, Offset<IActorDeployConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601D246 RID: 119366 RVA: 0x0041D422 File Offset: 0x0041B622
		public static Offset<Record_Int_IActorDeployConfig> EndRecord_Int_IActorDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IActorDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601D247 RID: 119367 RVA: 0x0041D430 File Offset: 0x0041B630
		public Record_Int_IActorDeployConfigT UnPack()
		{
			Record_Int_IActorDeployConfigT record_Int_IActorDeployConfigT = new Record_Int_IActorDeployConfigT();
			this.UnPackTo(record_Int_IActorDeployConfigT);
			return record_Int_IActorDeployConfigT;
		}

		// Token: 0x0601D248 RID: 119368 RVA: 0x0041D44C File Offset: 0x0041B64C
		public void UnPackTo(Record_Int_IActorDeployConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601D249 RID: 119369 RVA: 0x0041D494 File Offset: 0x0041B694
		public static Offset<Record_Int_IActorDeployConfig> Pack(FlatBufferBuilder builder, Record_Int_IActorDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IActorDeployConfig>);
			}
			Offset<IActorDeployConfig> valueOffset = (_o.Value == null) ? default(Offset<IActorDeployConfig>) : IActorDeployConfig.Pack(builder, _o.Value);
			return Record_Int_IActorDeployConfig.CreateRecord_Int_IActorDeployConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400CED5 RID: 52949
		private Table __p;
	}
}
