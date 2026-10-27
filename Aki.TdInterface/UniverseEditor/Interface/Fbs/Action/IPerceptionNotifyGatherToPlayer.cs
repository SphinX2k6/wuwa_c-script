using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C75 RID: 27765
	public struct IPerceptionNotifyGatherToPlayer : IFlatbufferObject
	{
		// Token: 0x1700CED2 RID: 52946
		// (get) Token: 0x06030EDB RID: 200411 RVA: 0x006A4F16 File Offset: 0x006A3116
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EDC RID: 200412 RVA: 0x006A4F23 File Offset: 0x006A3123
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EDD RID: 200413 RVA: 0x006A4F2C File Offset: 0x006A312C
		public static IPerceptionNotifyGatherToPlayer GetRootAsIPerceptionNotifyGatherToPlayer(ByteBuffer _bb)
		{
			return IPerceptionNotifyGatherToPlayer.GetRootAsIPerceptionNotifyGatherToPlayer(_bb, default(IPerceptionNotifyGatherToPlayer));
		}

		// Token: 0x06030EDE RID: 200414 RVA: 0x006A4F48 File Offset: 0x006A3148
		public static IPerceptionNotifyGatherToPlayer GetRootAsIPerceptionNotifyGatherToPlayer(ByteBuffer _bb, IPerceptionNotifyGatherToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030EDF RID: 200415 RVA: 0x006A4F65 File Offset: 0x006A3165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030EE0 RID: 200416 RVA: 0x006A4F74 File Offset: 0x006A3174
		public IPerceptionNotifyGatherToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CED3 RID: 52947
		// (get) Token: 0x06030EE1 RID: 200417 RVA: 0x006A4F84 File Offset: 0x006A3184
		public EBattleStatePerceptionBehavior Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return (EBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030EE2 RID: 200418 RVA: 0x006A4FC0 File Offset: 0x006A31C0
		public static Offset<IPerceptionNotifyGatherToPlayer> CreateIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer)
		{
			builder.StartTable(1);
			IPerceptionNotifyGatherToPlayer.AddType(builder, Type);
			return IPerceptionNotifyGatherToPlayer.EndIPerceptionNotifyGatherToPlayer(builder);
		}

		// Token: 0x06030EE3 RID: 200419 RVA: 0x006A4FD6 File Offset: 0x006A31D6
		public static void StartIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030EE4 RID: 200420 RVA: 0x006A4FDF File Offset: 0x006A31DF
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030EE5 RID: 200421 RVA: 0x006A4FEA File Offset: 0x006A31EA
		public static Offset<IPerceptionNotifyGatherToPlayer> EndIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPerceptionNotifyGatherToPlayer>(builder.EndTable());
		}

		// Token: 0x06030EE6 RID: 200422 RVA: 0x006A4FF8 File Offset: 0x006A31F8
		public IPerceptionNotifyGatherToPlayerT UnPack()
		{
			IPerceptionNotifyGatherToPlayerT perceptionNotifyGatherToPlayerT = new IPerceptionNotifyGatherToPlayerT();
			this.UnPackTo(perceptionNotifyGatherToPlayerT);
			return perceptionNotifyGatherToPlayerT;
		}

		// Token: 0x06030EE7 RID: 200423 RVA: 0x006A5013 File Offset: 0x006A3213
		public void UnPackTo(IPerceptionNotifyGatherToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030EE8 RID: 200424 RVA: 0x006A5024 File Offset: 0x006A3224
		public static Offset<IPerceptionNotifyGatherToPlayer> Pack(FlatBufferBuilder builder, IPerceptionNotifyGatherToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerceptionNotifyGatherToPlayer>);
			}
			return IPerceptionNotifyGatherToPlayer.CreateIPerceptionNotifyGatherToPlayer(builder, _o.Type);
		}

		// Token: 0x040115C8 RID: 71112
		private Table __p;
	}
}
