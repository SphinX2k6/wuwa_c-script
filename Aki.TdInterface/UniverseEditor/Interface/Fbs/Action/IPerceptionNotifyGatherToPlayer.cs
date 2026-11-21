using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DC RID: 29660
	public struct IPerceptionNotifyGatherToPlayer : IFlatbufferObject
	{
		// Token: 0x1700D9ED RID: 55789
		// (get) Token: 0x06033E36 RID: 212534 RVA: 0x006FF416 File Offset: 0x006FD616
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E37 RID: 212535 RVA: 0x006FF423 File Offset: 0x006FD623
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E38 RID: 212536 RVA: 0x006FF42C File Offset: 0x006FD62C
		public static IPerceptionNotifyGatherToPlayer GetRootAsIPerceptionNotifyGatherToPlayer(ByteBuffer _bb)
		{
			return IPerceptionNotifyGatherToPlayer.GetRootAsIPerceptionNotifyGatherToPlayer(_bb, default(IPerceptionNotifyGatherToPlayer));
		}

		// Token: 0x06033E39 RID: 212537 RVA: 0x006FF448 File Offset: 0x006FD648
		public static IPerceptionNotifyGatherToPlayer GetRootAsIPerceptionNotifyGatherToPlayer(ByteBuffer _bb, IPerceptionNotifyGatherToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E3A RID: 212538 RVA: 0x006FF465 File Offset: 0x006FD665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E3B RID: 212539 RVA: 0x006FF474 File Offset: 0x006FD674
		public IPerceptionNotifyGatherToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9EE RID: 55790
		// (get) Token: 0x06033E3C RID: 212540 RVA: 0x006FF484 File Offset: 0x006FD684
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

		// Token: 0x06033E3D RID: 212541 RVA: 0x006FF4C0 File Offset: 0x006FD6C0
		public static Offset<IPerceptionNotifyGatherToPlayer> CreateIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer)
		{
			builder.StartTable(1);
			IPerceptionNotifyGatherToPlayer.AddType(builder, Type);
			return IPerceptionNotifyGatherToPlayer.EndIPerceptionNotifyGatherToPlayer(builder);
		}

		// Token: 0x06033E3E RID: 212542 RVA: 0x006FF4D6 File Offset: 0x006FD6D6
		public static void StartIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033E3F RID: 212543 RVA: 0x006FF4DF File Offset: 0x006FD6DF
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E40 RID: 212544 RVA: 0x006FF4EA File Offset: 0x006FD6EA
		public static Offset<IPerceptionNotifyGatherToPlayer> EndIPerceptionNotifyGatherToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPerceptionNotifyGatherToPlayer>(builder.EndTable());
		}

		// Token: 0x06033E41 RID: 212545 RVA: 0x006FF4F8 File Offset: 0x006FD6F8
		public IPerceptionNotifyGatherToPlayerT UnPack()
		{
			IPerceptionNotifyGatherToPlayerT perceptionNotifyGatherToPlayerT = new IPerceptionNotifyGatherToPlayerT();
			this.UnPackTo(perceptionNotifyGatherToPlayerT);
			return perceptionNotifyGatherToPlayerT;
		}

		// Token: 0x06033E42 RID: 212546 RVA: 0x006FF513 File Offset: 0x006FD713
		public void UnPackTo(IPerceptionNotifyGatherToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033E43 RID: 212547 RVA: 0x006FF524 File Offset: 0x006FD724
		public static Offset<IPerceptionNotifyGatherToPlayer> Pack(FlatBufferBuilder builder, IPerceptionNotifyGatherToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerceptionNotifyGatherToPlayer>);
			}
			return IPerceptionNotifyGatherToPlayer.CreateIPerceptionNotifyGatherToPlayer(builder, _o.Type);
		}

		// Token: 0x04012520 RID: 75040
		private Table __p;
	}
}
