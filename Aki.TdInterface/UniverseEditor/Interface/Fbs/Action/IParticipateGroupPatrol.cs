using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C7 RID: 29639
	public struct IParticipateGroupPatrol : IFlatbufferObject
	{
		// Token: 0x1700D9B7 RID: 55735
		// (get) Token: 0x06033D72 RID: 212338 RVA: 0x006FDE71 File Offset: 0x006FC071
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D73 RID: 212339 RVA: 0x006FDE7E File Offset: 0x006FC07E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D74 RID: 212340 RVA: 0x006FDE88 File Offset: 0x006FC088
		public static IParticipateGroupPatrol GetRootAsIParticipateGroupPatrol(ByteBuffer _bb)
		{
			return IParticipateGroupPatrol.GetRootAsIParticipateGroupPatrol(_bb, default(IParticipateGroupPatrol));
		}

		// Token: 0x06033D75 RID: 212341 RVA: 0x006FDEA4 File Offset: 0x006FC0A4
		public static IParticipateGroupPatrol GetRootAsIParticipateGroupPatrol(ByteBuffer _bb, IParticipateGroupPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D76 RID: 212342 RVA: 0x006FDEC1 File Offset: 0x006FC0C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D77 RID: 212343 RVA: 0x006FDED0 File Offset: 0x006FC0D0
		public IParticipateGroupPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9B8 RID: 55736
		// (get) Token: 0x06033D78 RID: 212344 RVA: 0x006FDEE0 File Offset: 0x006FC0E0
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

		// Token: 0x1700D9B9 RID: 55737
		// (get) Token: 0x06033D79 RID: 212345 RVA: 0x006FDF1C File Offset: 0x006FC11C
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

		// Token: 0x06033D7A RID: 212346 RVA: 0x006FDF58 File Offset: 0x006FC158
		public static Offset<IParticipateGroupPatrol> CreateIParticipateGroupPatrol(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int GroupAiEntityId = 0)
		{
			builder.StartTable(2);
			IParticipateGroupPatrol.AddGroupAiEntityId(builder, GroupAiEntityId);
			IParticipateGroupPatrol.AddType(builder, Type);
			return IParticipateGroupPatrol.EndIParticipateGroupPatrol(builder);
		}

		// Token: 0x06033D7B RID: 212347 RVA: 0x006FDF75 File Offset: 0x006FC175
		public static void StartIParticipateGroupPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033D7C RID: 212348 RVA: 0x006FDF7E File Offset: 0x006FC17E
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D7D RID: 212349 RVA: 0x006FDF89 File Offset: 0x006FC189
		public static void AddGroupAiEntityId(FlatBufferBuilder builder, int groupAiEntityId)
		{
			builder.AddInt(1, groupAiEntityId, 0);
		}

		// Token: 0x06033D7E RID: 212350 RVA: 0x006FDF94 File Offset: 0x006FC194
		public static Offset<IParticipateGroupPatrol> EndIParticipateGroupPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IParticipateGroupPatrol>(builder.EndTable());
		}

		// Token: 0x06033D7F RID: 212351 RVA: 0x006FDFA4 File Offset: 0x006FC1A4
		public IParticipateGroupPatrolT UnPack()
		{
			IParticipateGroupPatrolT participateGroupPatrolT = new IParticipateGroupPatrolT();
			this.UnPackTo(participateGroupPatrolT);
			return participateGroupPatrolT;
		}

		// Token: 0x06033D80 RID: 212352 RVA: 0x006FDFBF File Offset: 0x006FC1BF
		public void UnPackTo(IParticipateGroupPatrolT _o)
		{
			_o.Type = this.Type;
			_o.GroupAiEntityId = this.GroupAiEntityId;
		}

		// Token: 0x06033D81 RID: 212353 RVA: 0x006FDFDC File Offset: 0x006FC1DC
		public static Offset<IParticipateGroupPatrol> Pack(FlatBufferBuilder builder, IParticipateGroupPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParticipateGroupPatrol>);
			}
			return IParticipateGroupPatrol.CreateIParticipateGroupPatrol(builder, _o.Type, _o.GroupAiEntityId);
		}

		// Token: 0x040124FC RID: 75004
		private Table __p;
	}
}
