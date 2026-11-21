using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006169 RID: 24937
	public struct IWaterStagnationActorConfig : IFlatbufferObject
	{
		// Token: 0x1700B9DB RID: 47579
		// (get) Token: 0x0602A591 RID: 173457 RVA: 0x005C72FF File Offset: 0x005C54FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A592 RID: 173458 RVA: 0x005C730C File Offset: 0x005C550C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A593 RID: 173459 RVA: 0x005C7314 File Offset: 0x005C5514
		public static IWaterStagnationActorConfig GetRootAsIWaterStagnationActorConfig(ByteBuffer _bb)
		{
			return IWaterStagnationActorConfig.GetRootAsIWaterStagnationActorConfig(_bb, default(IWaterStagnationActorConfig));
		}

		// Token: 0x0602A594 RID: 173460 RVA: 0x005C7330 File Offset: 0x005C5530
		public static IWaterStagnationActorConfig GetRootAsIWaterStagnationActorConfig(ByteBuffer _bb, IWaterStagnationActorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A595 RID: 173461 RVA: 0x005C734D File Offset: 0x005C554D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A596 RID: 173462 RVA: 0x005C735C File Offset: 0x005C555C
		public IWaterStagnationActorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9DC RID: 47580
		// (get) Token: 0x0602A597 RID: 173463 RVA: 0x005C736C File Offset: 0x005C556C
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

		// Token: 0x0602A598 RID: 173464 RVA: 0x005C73A8 File Offset: 0x005C55A8
		public static Offset<IWaterStagnationActorConfig> CreateIWaterStagnationActorConfig(FlatBufferBuilder builder, int SeqRefEntity = 0)
		{
			builder.StartTable(1);
			IWaterStagnationActorConfig.AddSeqRefEntity(builder, SeqRefEntity);
			return IWaterStagnationActorConfig.EndIWaterStagnationActorConfig(builder);
		}

		// Token: 0x0602A599 RID: 173465 RVA: 0x005C73BE File Offset: 0x005C55BE
		public static void StartIWaterStagnationActorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A59A RID: 173466 RVA: 0x005C73C7 File Offset: 0x005C55C7
		public static void AddSeqRefEntity(FlatBufferBuilder builder, int seqRefEntity)
		{
			builder.AddInt(0, seqRefEntity, 0);
		}

		// Token: 0x0602A59B RID: 173467 RVA: 0x005C73D2 File Offset: 0x005C55D2
		public static Offset<IWaterStagnationActorConfig> EndIWaterStagnationActorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWaterStagnationActorConfig>(builder.EndTable());
		}

		// Token: 0x0602A59C RID: 173468 RVA: 0x005C73E0 File Offset: 0x005C55E0
		public IWaterStagnationActorConfigT UnPack()
		{
			IWaterStagnationActorConfigT waterStagnationActorConfigT = new IWaterStagnationActorConfigT();
			this.UnPackTo(waterStagnationActorConfigT);
			return waterStagnationActorConfigT;
		}

		// Token: 0x0602A59D RID: 173469 RVA: 0x005C73FB File Offset: 0x005C55FB
		public void UnPackTo(IWaterStagnationActorConfigT _o)
		{
			_o.SeqRefEntity = this.SeqRefEntity;
		}

		// Token: 0x0602A59E RID: 173470 RVA: 0x005C740C File Offset: 0x005C560C
		public static Offset<IWaterStagnationActorConfig> Pack(FlatBufferBuilder builder, IWaterStagnationActorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterStagnationActorConfig>);
			}
			return IWaterStagnationActorConfig.CreateIWaterStagnationActorConfig(builder, _o.SeqRefEntity);
		}

		// Token: 0x0400FF99 RID: 65433
		private Table __p;
	}
}
