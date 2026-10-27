using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BC RID: 22972
	public struct IStateRepPerfSkillId : IFlatbufferObject
	{
		// Token: 0x1700AC61 RID: 44129
		// (get) Token: 0x06026EC5 RID: 159429 RVA: 0x0055AE35 File Offset: 0x00559035
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026EC6 RID: 159430 RVA: 0x0055AE42 File Offset: 0x00559042
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026EC7 RID: 159431 RVA: 0x0055AE4C File Offset: 0x0055904C
		public static IStateRepPerfSkillId GetRootAsIStateRepPerfSkillId(ByteBuffer _bb)
		{
			return IStateRepPerfSkillId.GetRootAsIStateRepPerfSkillId(_bb, default(IStateRepPerfSkillId));
		}

		// Token: 0x06026EC8 RID: 159432 RVA: 0x0055AE68 File Offset: 0x00559068
		public static IStateRepPerfSkillId GetRootAsIStateRepPerfSkillId(ByteBuffer _bb, IStateRepPerfSkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026EC9 RID: 159433 RVA: 0x0055AE85 File Offset: 0x00559085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026ECA RID: 159434 RVA: 0x0055AE94 File Offset: 0x00559094
		public IStateRepPerfSkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC62 RID: 44130
		// (get) Token: 0x06026ECB RID: 159435 RVA: 0x0055AEA4 File Offset: 0x005590A4
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC63 RID: 44131
		// (get) Token: 0x06026ECC RID: 159436 RVA: 0x0055AEE0 File Offset: 0x005590E0
		public long SkillId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026ECD RID: 159437 RVA: 0x0055AF1D File Offset: 0x0055911D
		public static Offset<IStateRepPerfSkillId> CreateIStateRepPerfSkillId(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, long SkillId = 0L)
		{
			builder.StartTable(2);
			IStateRepPerfSkillId.AddSkillId(builder, SkillId);
			IStateRepPerfSkillId.AddType(builder, Type);
			return IStateRepPerfSkillId.EndIStateRepPerfSkillId(builder);
		}

		// Token: 0x06026ECE RID: 159438 RVA: 0x0055AF3A File Offset: 0x0055913A
		public static void StartIStateRepPerfSkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026ECF RID: 159439 RVA: 0x0055AF43 File Offset: 0x00559143
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026ED0 RID: 159440 RVA: 0x0055AF4E File Offset: 0x0055914E
		public static void AddSkillId(FlatBufferBuilder builder, long skillId)
		{
			builder.AddLong(1, skillId, 0L);
		}

		// Token: 0x06026ED1 RID: 159441 RVA: 0x0055AF5A File Offset: 0x0055915A
		public static Offset<IStateRepPerfSkillId> EndIStateRepPerfSkillId(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfSkillId>(builder.EndTable());
		}

		// Token: 0x06026ED2 RID: 159442 RVA: 0x0055AF68 File Offset: 0x00559168
		public IStateRepPerfSkillIdT UnPack()
		{
			IStateRepPerfSkillIdT stateRepPerfSkillIdT = new IStateRepPerfSkillIdT();
			this.UnPackTo(stateRepPerfSkillIdT);
			return stateRepPerfSkillIdT;
		}

		// Token: 0x06026ED3 RID: 159443 RVA: 0x0055AF83 File Offset: 0x00559183
		public void UnPackTo(IStateRepPerfSkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x06026ED4 RID: 159444 RVA: 0x0055AFA0 File Offset: 0x005591A0
		public static Offset<IStateRepPerfSkillId> Pack(FlatBufferBuilder builder, IStateRepPerfSkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfSkillId>);
			}
			return IStateRepPerfSkillId.CreateIStateRepPerfSkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400EFD0 RID: 61392
		private Table __p;
	}
}
