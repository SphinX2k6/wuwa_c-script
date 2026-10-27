using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B53 RID: 23379
	public struct IWaterStagnationActorConfig : IFlatbufferObject
	{
		// Token: 0x1700B093 RID: 45203
		// (get) Token: 0x06027FCD RID: 163789 RVA: 0x0057F86F File Offset: 0x0057DA6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FCE RID: 163790 RVA: 0x0057F87C File Offset: 0x0057DA7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FCF RID: 163791 RVA: 0x0057F884 File Offset: 0x0057DA84
		public static IWaterStagnationActorConfig GetRootAsIWaterStagnationActorConfig(ByteBuffer _bb)
		{
			return IWaterStagnationActorConfig.GetRootAsIWaterStagnationActorConfig(_bb, default(IWaterStagnationActorConfig));
		}

		// Token: 0x06027FD0 RID: 163792 RVA: 0x0057F8A0 File Offset: 0x0057DAA0
		public static IWaterStagnationActorConfig GetRootAsIWaterStagnationActorConfig(ByteBuffer _bb, IWaterStagnationActorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FD1 RID: 163793 RVA: 0x0057F8BD File Offset: 0x0057DABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FD2 RID: 163794 RVA: 0x0057F8CC File Offset: 0x0057DACC
		public IWaterStagnationActorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B094 RID: 45204
		// (get) Token: 0x06027FD3 RID: 163795 RVA: 0x0057F8DC File Offset: 0x0057DADC
		public int SeqRefEntity
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

		// Token: 0x06027FD4 RID: 163796 RVA: 0x0057F918 File Offset: 0x0057DB18
		public static Offset<IWaterStagnationActorConfig> CreateIWaterStagnationActorConfig(FlatBufferBuilder builder, int SeqRefEntity = 0)
		{
			builder.StartTable(1);
			IWaterStagnationActorConfig.AddSeqRefEntity(builder, SeqRefEntity);
			return IWaterStagnationActorConfig.EndIWaterStagnationActorConfig(builder);
		}

		// Token: 0x06027FD5 RID: 163797 RVA: 0x0057F92E File Offset: 0x0057DB2E
		public static void StartIWaterStagnationActorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027FD6 RID: 163798 RVA: 0x0057F937 File Offset: 0x0057DB37
		public static void AddSeqRefEntity(FlatBufferBuilder builder, int seqRefEntity)
		{
			builder.AddInt(0, seqRefEntity, 0);
		}

		// Token: 0x06027FD7 RID: 163799 RVA: 0x0057F942 File Offset: 0x0057DB42
		public static Offset<IWaterStagnationActorConfig> EndIWaterStagnationActorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWaterStagnationActorConfig>(builder.EndTable());
		}

		// Token: 0x06027FD8 RID: 163800 RVA: 0x0057F950 File Offset: 0x0057DB50
		public IWaterStagnationActorConfigT UnPack()
		{
			IWaterStagnationActorConfigT waterStagnationActorConfigT = new IWaterStagnationActorConfigT();
			this.UnPackTo(waterStagnationActorConfigT);
			return waterStagnationActorConfigT;
		}

		// Token: 0x06027FD9 RID: 163801 RVA: 0x0057F96B File Offset: 0x0057DB6B
		public void UnPackTo(IWaterStagnationActorConfigT _o)
		{
			_o.SeqRefEntity = this.SeqRefEntity;
		}

		// Token: 0x06027FDA RID: 163802 RVA: 0x0057F97C File Offset: 0x0057DB7C
		public static Offset<IWaterStagnationActorConfig> Pack(FlatBufferBuilder builder, IWaterStagnationActorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterStagnationActorConfig>);
			}
			return IWaterStagnationActorConfig.CreateIWaterStagnationActorConfig(builder, _o.SeqRefEntity);
		}

		// Token: 0x0400F293 RID: 62099
		private Table __p;
	}
}
