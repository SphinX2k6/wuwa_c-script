using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE4 RID: 28388
	public struct IFollowShooterResetToPlayer : IFlatbufferObject
	{
		// Token: 0x1700D02B RID: 53291
		// (get) Token: 0x060311D1 RID: 201169 RVA: 0x006A8968 File Offset: 0x006A6B68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311D2 RID: 201170 RVA: 0x006A8975 File Offset: 0x006A6B75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311D3 RID: 201171 RVA: 0x006A897C File Offset: 0x006A6B7C
		public static IFollowShooterResetToPlayer GetRootAsIFollowShooterResetToPlayer(ByteBuffer _bb)
		{
			return IFollowShooterResetToPlayer.GetRootAsIFollowShooterResetToPlayer(_bb, default(IFollowShooterResetToPlayer));
		}

		// Token: 0x060311D4 RID: 201172 RVA: 0x006A8998 File Offset: 0x006A6B98
		public static IFollowShooterResetToPlayer GetRootAsIFollowShooterResetToPlayer(ByteBuffer _bb, IFollowShooterResetToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311D5 RID: 201173 RVA: 0x006A89B5 File Offset: 0x006A6BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311D6 RID: 201174 RVA: 0x006A89C4 File Offset: 0x006A6BC4
		public IFollowShooterResetToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D02C RID: 53292
		// (get) Token: 0x060311D7 RID: 201175 RVA: 0x006A89D4 File Offset: 0x006A6BD4
		public EFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060311D8 RID: 201176 RVA: 0x006A8A10 File Offset: 0x006A6C10
		public static Offset<IFollowShooterResetToPlayer> CreateIFollowShooterResetToPlayer(FlatBufferBuilder builder, EFollowShooterLeisureInteractType Type = EFollowShooterLeisureInteractType.ResetToPlayer)
		{
			builder.StartTable(1);
			IFollowShooterResetToPlayer.AddType(builder, Type);
			return IFollowShooterResetToPlayer.EndIFollowShooterResetToPlayer(builder);
		}

		// Token: 0x060311D9 RID: 201177 RVA: 0x006A8A26 File Offset: 0x006A6C26
		public static void StartIFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060311DA RID: 201178 RVA: 0x006A8A2F File Offset: 0x006A6C2F
		public static void AddType(FlatBufferBuilder builder, EFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060311DB RID: 201179 RVA: 0x006A8A3A File Offset: 0x006A6C3A
		public static Offset<IFollowShooterResetToPlayer> EndIFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterResetToPlayer>(builder.EndTable());
		}

		// Token: 0x060311DC RID: 201180 RVA: 0x006A8A48 File Offset: 0x006A6C48
		public IFollowShooterResetToPlayerT UnPack()
		{
			IFollowShooterResetToPlayerT followShooterResetToPlayerT = new IFollowShooterResetToPlayerT();
			this.UnPackTo(followShooterResetToPlayerT);
			return followShooterResetToPlayerT;
		}

		// Token: 0x060311DD RID: 201181 RVA: 0x006A8A63 File Offset: 0x006A6C63
		public void UnPackTo(IFollowShooterResetToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060311DE RID: 201182 RVA: 0x006A8A74 File Offset: 0x006A6C74
		public static Offset<IFollowShooterResetToPlayer> Pack(FlatBufferBuilder builder, IFollowShooterResetToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterResetToPlayer>);
			}
			return IFollowShooterResetToPlayer.CreateIFollowShooterResetToPlayer(builder, _o.Type);
		}

		// Token: 0x04011DE5 RID: 73189
		private Table __p;
	}
}
