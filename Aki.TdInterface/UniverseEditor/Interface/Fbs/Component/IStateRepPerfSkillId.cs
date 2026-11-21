using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC9 RID: 24521
	public struct IStateRepPerfSkillId : IFlatbufferObject
	{
		// Token: 0x1700B595 RID: 46485
		// (get) Token: 0x0602942F RID: 169007 RVA: 0x005A1AA1 File Offset: 0x0059FCA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029430 RID: 169008 RVA: 0x005A1AAE File Offset: 0x0059FCAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029431 RID: 169009 RVA: 0x005A1AB8 File Offset: 0x0059FCB8
		public static IStateRepPerfSkillId GetRootAsIStateRepPerfSkillId(ByteBuffer _bb)
		{
			return IStateRepPerfSkillId.GetRootAsIStateRepPerfSkillId(_bb, default(IStateRepPerfSkillId));
		}

		// Token: 0x06029432 RID: 169010 RVA: 0x005A1AD4 File Offset: 0x0059FCD4
		public static IStateRepPerfSkillId GetRootAsIStateRepPerfSkillId(ByteBuffer _bb, IStateRepPerfSkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029433 RID: 169011 RVA: 0x005A1AF1 File Offset: 0x0059FCF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029434 RID: 169012 RVA: 0x005A1B00 File Offset: 0x0059FD00
		public IStateRepPerfSkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B596 RID: 46486
		// (get) Token: 0x06029435 RID: 169013 RVA: 0x005A1B10 File Offset: 0x0059FD10
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

		// Token: 0x1700B597 RID: 46487
		// (get) Token: 0x06029436 RID: 169014 RVA: 0x005A1B4C File Offset: 0x0059FD4C
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

		// Token: 0x06029437 RID: 169015 RVA: 0x005A1B89 File Offset: 0x0059FD89
		public static Offset<IStateRepPerfSkillId> CreateIStateRepPerfSkillId(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, long SkillId = 0L)
		{
			builder.StartTable(2);
			IStateRepPerfSkillId.AddSkillId(builder, SkillId);
			IStateRepPerfSkillId.AddType(builder, Type);
			return IStateRepPerfSkillId.EndIStateRepPerfSkillId(builder);
		}

		// Token: 0x06029438 RID: 169016 RVA: 0x005A1BA6 File Offset: 0x0059FDA6
		public static void StartIStateRepPerfSkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029439 RID: 169017 RVA: 0x005A1BAF File Offset: 0x0059FDAF
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602943A RID: 169018 RVA: 0x005A1BBA File Offset: 0x0059FDBA
		public static void AddSkillId(FlatBufferBuilder builder, long skillId)
		{
			builder.AddLong(1, skillId, 0L);
		}

		// Token: 0x0602943B RID: 169019 RVA: 0x005A1BC6 File Offset: 0x0059FDC6
		public static Offset<IStateRepPerfSkillId> EndIStateRepPerfSkillId(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfSkillId>(builder.EndTable());
		}

		// Token: 0x0602943C RID: 169020 RVA: 0x005A1BD4 File Offset: 0x0059FDD4
		public IStateRepPerfSkillIdT UnPack()
		{
			IStateRepPerfSkillIdT stateRepPerfSkillIdT = new IStateRepPerfSkillIdT();
			this.UnPackTo(stateRepPerfSkillIdT);
			return stateRepPerfSkillIdT;
		}

		// Token: 0x0602943D RID: 169021 RVA: 0x005A1BEF File Offset: 0x0059FDEF
		public void UnPackTo(IStateRepPerfSkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0602943E RID: 169022 RVA: 0x005A1C0C File Offset: 0x0059FE0C
		public static Offset<IStateRepPerfSkillId> Pack(FlatBufferBuilder builder, IStateRepPerfSkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfSkillId>);
			}
			return IStateRepPerfSkillId.CreateIStateRepPerfSkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400FCC5 RID: 64709
		private Table __p;
	}
}
