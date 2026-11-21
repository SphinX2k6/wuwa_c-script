using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D30 RID: 19760
	public struct Record_Int_IActorDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008D93 RID: 36243
		// (get) Token: 0x0601EA27 RID: 125479 RVA: 0x00449A78 File Offset: 0x00447C78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA28 RID: 125480 RVA: 0x00449A85 File Offset: 0x00447C85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA29 RID: 125481 RVA: 0x00449A8C File Offset: 0x00447C8C
		public static Record_Int_IActorDeployConfig GetRootAsRecord_Int_IActorDeployConfig(ByteBuffer _bb)
		{
			return Record_Int_IActorDeployConfig.GetRootAsRecord_Int_IActorDeployConfig(_bb, default(Record_Int_IActorDeployConfig));
		}

		// Token: 0x0601EA2A RID: 125482 RVA: 0x00449AA8 File Offset: 0x00447CA8
		public static Record_Int_IActorDeployConfig GetRootAsRecord_Int_IActorDeployConfig(ByteBuffer _bb, Record_Int_IActorDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA2B RID: 125483 RVA: 0x00449AC5 File Offset: 0x00447CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA2C RID: 125484 RVA: 0x00449AD4 File Offset: 0x00447CD4
		public Record_Int_IActorDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D94 RID: 36244
		// (get) Token: 0x0601EA2D RID: 125485 RVA: 0x00449AE4 File Offset: 0x00447CE4
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

		// Token: 0x17008D95 RID: 36245
		// (get) Token: 0x0601EA2E RID: 125486 RVA: 0x00449B20 File Offset: 0x00447D20
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

		// Token: 0x0601EA2F RID: 125487 RVA: 0x00449B7D File Offset: 0x00447D7D
		public static Offset<Record_Int_IActorDeployConfig> CreateRecord_Int_IActorDeployConfig(FlatBufferBuilder builder, int Key = 0, Offset<IActorDeployConfig> ValueOffset = default(Offset<IActorDeployConfig>))
		{
			builder.StartTable(2);
			Record_Int_IActorDeployConfig.AddValue(builder, ValueOffset);
			Record_Int_IActorDeployConfig.AddKey(builder, Key);
			return Record_Int_IActorDeployConfig.EndRecord_Int_IActorDeployConfig(builder);
		}

		// Token: 0x0601EA30 RID: 125488 RVA: 0x00449B9A File Offset: 0x00447D9A
		public static void StartRecord_Int_IActorDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EA31 RID: 125489 RVA: 0x00449BA3 File Offset: 0x00447DA3
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EA32 RID: 125490 RVA: 0x00449BAE File Offset: 0x00447DAE
		public static void AddValue(FlatBufferBuilder builder, Offset<IActorDeployConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601EA33 RID: 125491 RVA: 0x00449BBE File Offset: 0x00447DBE
		public static Offset<Record_Int_IActorDeployConfig> EndRecord_Int_IActorDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IActorDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601EA34 RID: 125492 RVA: 0x00449BCC File Offset: 0x00447DCC
		public Record_Int_IActorDeployConfigT UnPack()
		{
			Record_Int_IActorDeployConfigT record_Int_IActorDeployConfigT = new Record_Int_IActorDeployConfigT();
			this.UnPackTo(record_Int_IActorDeployConfigT);
			return record_Int_IActorDeployConfigT;
		}

		// Token: 0x0601EA35 RID: 125493 RVA: 0x00449BE8 File Offset: 0x00447DE8
		public void UnPackTo(Record_Int_IActorDeployConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601EA36 RID: 125494 RVA: 0x00449C30 File Offset: 0x00447E30
		public static Offset<Record_Int_IActorDeployConfig> Pack(FlatBufferBuilder builder, Record_Int_IActorDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IActorDeployConfig>);
			}
			Offset<IActorDeployConfig> valueOffset = (_o.Value == null) ? default(Offset<IActorDeployConfig>) : IActorDeployConfig.Pack(builder, _o.Value);
			return Record_Int_IActorDeployConfig.CreateRecord_Int_IActorDeployConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x0400D90E RID: 55566
		private Table __p;
	}
}
