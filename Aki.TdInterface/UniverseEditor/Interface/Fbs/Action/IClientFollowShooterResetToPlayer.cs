using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CA RID: 25546
	public struct IClientFollowShooterResetToPlayer : IFlatbufferObject
	{
		// Token: 0x1700BE55 RID: 48725
		// (get) Token: 0x0602C301 RID: 180993 RVA: 0x00611131 File Offset: 0x0060F331
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C302 RID: 180994 RVA: 0x0061113E File Offset: 0x0060F33E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C303 RID: 180995 RVA: 0x00611148 File Offset: 0x0060F348
		public static IClientFollowShooterResetToPlayer GetRootAsIClientFollowShooterResetToPlayer(ByteBuffer _bb)
		{
			return IClientFollowShooterResetToPlayer.GetRootAsIClientFollowShooterResetToPlayer(_bb, default(IClientFollowShooterResetToPlayer));
		}

		// Token: 0x0602C304 RID: 180996 RVA: 0x00611164 File Offset: 0x0060F364
		public static IClientFollowShooterResetToPlayer GetRootAsIClientFollowShooterResetToPlayer(ByteBuffer _bb, IClientFollowShooterResetToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C305 RID: 180997 RVA: 0x00611181 File Offset: 0x0060F381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C306 RID: 180998 RVA: 0x00611190 File Offset: 0x0060F390
		public IClientFollowShooterResetToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE56 RID: 48726
		// (get) Token: 0x0602C307 RID: 180999 RVA: 0x006111A0 File Offset: 0x0060F3A0
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C308 RID: 181000 RVA: 0x006111DC File Offset: 0x0060F3DC
		public static Offset<IClientFollowShooterResetToPlayer> CreateIClientFollowShooterResetToPlayer(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.ResetToPlayer)
		{
			builder.StartTable(1);
			IClientFollowShooterResetToPlayer.AddType(builder, Type);
			return IClientFollowShooterResetToPlayer.EndIClientFollowShooterResetToPlayer(builder);
		}

		// Token: 0x0602C309 RID: 181001 RVA: 0x006111F2 File Offset: 0x0060F3F2
		public static void StartIClientFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C30A RID: 181002 RVA: 0x006111FB File Offset: 0x0060F3FB
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C30B RID: 181003 RVA: 0x00611206 File Offset: 0x0060F406
		public static Offset<IClientFollowShooterResetToPlayer> EndIClientFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterResetToPlayer>(builder.EndTable());
		}

		// Token: 0x0602C30C RID: 181004 RVA: 0x00611214 File Offset: 0x0060F414
		public IClientFollowShooterResetToPlayerT UnPack()
		{
			IClientFollowShooterResetToPlayerT clientFollowShooterResetToPlayerT = new IClientFollowShooterResetToPlayerT();
			this.UnPackTo(clientFollowShooterResetToPlayerT);
			return clientFollowShooterResetToPlayerT;
		}

		// Token: 0x0602C30D RID: 181005 RVA: 0x0061122F File Offset: 0x0060F42F
		public void UnPackTo(IClientFollowShooterResetToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C30E RID: 181006 RVA: 0x00611240 File Offset: 0x0060F440
		public static Offset<IClientFollowShooterResetToPlayer> Pack(FlatBufferBuilder builder, IClientFollowShooterResetToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterResetToPlayer>);
			}
			return IClientFollowShooterResetToPlayer.CreateIClientFollowShooterResetToPlayer(builder, _o.Type);
		}

		// Token: 0x040109A7 RID: 68007
		private Table __p;
	}
}
