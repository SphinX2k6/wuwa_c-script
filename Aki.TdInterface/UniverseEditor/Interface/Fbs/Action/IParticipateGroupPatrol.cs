using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C60 RID: 27744
	public struct IParticipateGroupPatrol : IFlatbufferObject
	{
		// Token: 0x1700CE9C RID: 52892
		// (get) Token: 0x06030E17 RID: 200215 RVA: 0x006A3971 File Offset: 0x006A1B71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E18 RID: 200216 RVA: 0x006A397E File Offset: 0x006A1B7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E19 RID: 200217 RVA: 0x006A3988 File Offset: 0x006A1B88
		public static IParticipateGroupPatrol GetRootAsIParticipateGroupPatrol(ByteBuffer _bb)
		{
			return IParticipateGroupPatrol.GetRootAsIParticipateGroupPatrol(_bb, default(IParticipateGroupPatrol));
		}

		// Token: 0x06030E1A RID: 200218 RVA: 0x006A39A4 File Offset: 0x006A1BA4
		public static IParticipateGroupPatrol GetRootAsIParticipateGroupPatrol(ByteBuffer _bb, IParticipateGroupPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E1B RID: 200219 RVA: 0x006A39C1 File Offset: 0x006A1BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E1C RID: 200220 RVA: 0x006A39D0 File Offset: 0x006A1BD0
		public IParticipateGroupPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE9D RID: 52893
		// (get) Token: 0x06030E1D RID: 200221 RVA: 0x006A39E0 File Offset: 0x006A1BE0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE9E RID: 52894
		// (get) Token: 0x06030E1E RID: 200222 RVA: 0x006A3A1C File Offset: 0x006A1C1C
		public int GroupAiEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030E1F RID: 200223 RVA: 0x006A3A58 File Offset: 0x006A1C58
		public static Offset<IParticipateGroupPatrol> CreateIParticipateGroupPatrol(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int GroupAiEntityId = 0)
		{
			builder.StartTable(2);
			IParticipateGroupPatrol.AddGroupAiEntityId(builder, GroupAiEntityId);
			IParticipateGroupPatrol.AddType(builder, Type);
			return IParticipateGroupPatrol.EndIParticipateGroupPatrol(builder);
		}

		// Token: 0x06030E20 RID: 200224 RVA: 0x006A3A75 File Offset: 0x006A1C75
		public static void StartIParticipateGroupPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E21 RID: 200225 RVA: 0x006A3A7E File Offset: 0x006A1C7E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E22 RID: 200226 RVA: 0x006A3A89 File Offset: 0x006A1C89
		public static void AddGroupAiEntityId(FlatBufferBuilder builder, int groupAiEntityId)
		{
			builder.AddInt(1, groupAiEntityId, 0);
		}

		// Token: 0x06030E23 RID: 200227 RVA: 0x006A3A94 File Offset: 0x006A1C94
		public static Offset<IParticipateGroupPatrol> EndIParticipateGroupPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IParticipateGroupPatrol>(builder.EndTable());
		}

		// Token: 0x06030E24 RID: 200228 RVA: 0x006A3AA4 File Offset: 0x006A1CA4
		public IParticipateGroupPatrolT UnPack()
		{
			IParticipateGroupPatrolT participateGroupPatrolT = new IParticipateGroupPatrolT();
			this.UnPackTo(participateGroupPatrolT);
			return participateGroupPatrolT;
		}

		// Token: 0x06030E25 RID: 200229 RVA: 0x006A3ABF File Offset: 0x006A1CBF
		public void UnPackTo(IParticipateGroupPatrolT _o)
		{
			_o.Type = this.Type;
			_o.GroupAiEntityId = this.GroupAiEntityId;
		}

		// Token: 0x06030E26 RID: 200230 RVA: 0x006A3ADC File Offset: 0x006A1CDC
		public static Offset<IParticipateGroupPatrol> Pack(FlatBufferBuilder builder, IParticipateGroupPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParticipateGroupPatrol>);
			}
			return IParticipateGroupPatrol.CreateIParticipateGroupPatrol(builder, _o.Type, _o.GroupAiEntityId);
		}

		// Token: 0x040115A4 RID: 71076
		private Table __p;
	}
}
