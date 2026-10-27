using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D1 RID: 18641
	public struct Record_Int_IEntityDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008755 RID: 34645
		// (get) Token: 0x0601D266 RID: 119398 RVA: 0x0041D7F4 File Offset: 0x0041B9F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D267 RID: 119399 RVA: 0x0041D801 File Offset: 0x0041BA01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D268 RID: 119400 RVA: 0x0041D808 File Offset: 0x0041BA08
		public static Record_Int_IEntityDeployConfig GetRootAsRecord_Int_IEntityDeployConfig(ByteBuffer _bb)
		{
			return Record_Int_IEntityDeployConfig.GetRootAsRecord_Int_IEntityDeployConfig(_bb, default(Record_Int_IEntityDeployConfig));
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x0041D824 File Offset: 0x0041BA24
		public static Record_Int_IEntityDeployConfig GetRootAsRecord_Int_IEntityDeployConfig(ByteBuffer _bb, Record_Int_IEntityDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D26A RID: 119402 RVA: 0x0041D841 File Offset: 0x0041BA41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D26B RID: 119403 RVA: 0x0041D850 File Offset: 0x0041BA50
		public Record_Int_IEntityDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008756 RID: 34646
		// (get) Token: 0x0601D26C RID: 119404 RVA: 0x0041D860 File Offset: 0x0041BA60
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

		// Token: 0x17008757 RID: 34647
		// (get) Token: 0x0601D26D RID: 119405 RVA: 0x0041D89C File Offset: 0x0041BA9C
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

		// Token: 0x0601D26E RID: 119406 RVA: 0x0041D8F9 File Offset: 0x0041BAF9
		public static Offset<Record_Int_IEntityDeployConfig> CreateRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder, int Key = 0, Offset<IEntityDeployConfig> ValueOffset = default(Offset<IEntityDeployConfig>))
		{
			builder.StartTable(2);
			Record_Int_IEntityDeployConfig.AddValue(builder, ValueOffset);
			Record_Int_IEntityDeployConfig.AddKey(builder, Key);
			return Record_Int_IEntityDeployConfig.EndRecord_Int_IEntityDeployConfig(builder);
		}

		// Token: 0x0601D26F RID: 119407 RVA: 0x0041D916 File Offset: 0x0041BB16
		public static void StartRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D270 RID: 119408 RVA: 0x0041D91F File Offset: 0x0041BB1F
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D271 RID: 119409 RVA: 0x0041D92A File Offset: 0x0041BB2A
		public static void AddValue(FlatBufferBuilder builder, Offset<IEntityDeployConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601D272 RID: 119410 RVA: 0x0041D93A File Offset: 0x0041BB3A
		public static Offset<Record_Int_IEntityDeployConfig> EndRecord_Int_IEntityDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IEntityDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601D273 RID: 119411 RVA: 0x0041D948 File Offset: 0x0041BB48
		public Record_Int_IEntityDeployConfigT UnPack()
		{
			Record_Int_IEntityDeployConfigT record_Int_IEntityDeployConfigT = new Record_Int_IEntityDeployConfigT();
			this.UnPackTo(record_Int_IEntityDeployConfigT);
			return record_Int_IEntityDeployConfigT;
		}

		// Token: 0x0601D274 RID: 119412 RVA: 0x0041D964 File Offset: 0x0041BB64
		public void UnPackTo(Record_Int_IEntityDeployConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601D275 RID: 119413 RVA: 0x0041D9AC File Offset: 0x0041BBAC
		public static Offset<Record_Int_IEntityDeployConfig> Pack(FlatBufferBuilder builder, Record_Int_IEntityDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IEntityDeployConfig>);
			}
			Offset<IEntityDeployConfig> valueOffset = (_o.Value == null) ? default(Offset<IEntityDeployConfig>) : IEntityDeployConfig.Pack(builder, _o.Value);
			return Record_Int_IEntityDeployConfig.CreateRecord_Int_IEntityDeployConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400CEDB RID: 52955
		private Table __p;
	}
}
