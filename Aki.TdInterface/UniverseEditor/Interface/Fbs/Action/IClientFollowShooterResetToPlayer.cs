using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A47 RID: 27207
	public struct IClientFollowShooterResetToPlayer : IFlatbufferObject
	{
		// Token: 0x1700C7E6 RID: 51174
		// (get) Token: 0x0602EAAC RID: 191148 RVA: 0x0065C87E File Offset: 0x0065AA7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EAAD RID: 191149 RVA: 0x0065C88B File Offset: 0x0065AA8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EAAE RID: 191150 RVA: 0x0065C894 File Offset: 0x0065AA94
		public static IClientFollowShooterResetToPlayer GetRootAsIClientFollowShooterResetToPlayer(ByteBuffer _bb)
		{
			return IClientFollowShooterResetToPlayer.GetRootAsIClientFollowShooterResetToPlayer(_bb, default(IClientFollowShooterResetToPlayer));
		}

		// Token: 0x0602EAAF RID: 191151 RVA: 0x0065C8B0 File Offset: 0x0065AAB0
		public static IClientFollowShooterResetToPlayer GetRootAsIClientFollowShooterResetToPlayer(ByteBuffer _bb, IClientFollowShooterResetToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EAB0 RID: 191152 RVA: 0x0065C8CD File Offset: 0x0065AACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EAB1 RID: 191153 RVA: 0x0065C8DC File Offset: 0x0065AADC
		public IClientFollowShooterResetToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7E7 RID: 51175
		// (get) Token: 0x0602EAB2 RID: 191154 RVA: 0x0065C8EC File Offset: 0x0065AAEC
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EAB3 RID: 191155 RVA: 0x0065C928 File Offset: 0x0065AB28
		public static Offset<IClientFollowShooterResetToPlayer> CreateIClientFollowShooterResetToPlayer(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.PlayAnimation)
		{
			builder.StartTable(1);
			IClientFollowShooterResetToPlayer.AddType(builder, Type);
			return IClientFollowShooterResetToPlayer.EndIClientFollowShooterResetToPlayer(builder);
		}

		// Token: 0x0602EAB4 RID: 191156 RVA: 0x0065C93E File Offset: 0x0065AB3E
		public static void StartIClientFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EAB5 RID: 191157 RVA: 0x0065C947 File Offset: 0x0065AB47
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EAB6 RID: 191158 RVA: 0x0065C952 File Offset: 0x0065AB52
		public static Offset<IClientFollowShooterResetToPlayer> EndIClientFollowShooterResetToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterResetToPlayer>(builder.EndTable());
		}

		// Token: 0x0602EAB7 RID: 191159 RVA: 0x0065C960 File Offset: 0x0065AB60
		public IClientFollowShooterResetToPlayerT UnPack()
		{
			IClientFollowShooterResetToPlayerT clientFollowShooterResetToPlayerT = new IClientFollowShooterResetToPlayerT();
			this.UnPackTo(clientFollowShooterResetToPlayerT);
			return clientFollowShooterResetToPlayerT;
		}

		// Token: 0x0602EAB8 RID: 191160 RVA: 0x0065C97B File Offset: 0x0065AB7B
		public void UnPackTo(IClientFollowShooterResetToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EAB9 RID: 191161 RVA: 0x0065C98C File Offset: 0x0065AB8C
		public static Offset<IClientFollowShooterResetToPlayer> Pack(FlatBufferBuilder builder, IClientFollowShooterResetToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterResetToPlayer>);
			}
			return IClientFollowShooterResetToPlayer.CreateIClientFollowShooterResetToPlayer(builder, _o.Type);
		}

		// Token: 0x040117C8 RID: 71624
		private Table __p;
	}
}
