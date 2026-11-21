using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001029 RID: 4137
	public struct PlayerExp : IFlatbufferObject
	{
		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x002E3D04 File Offset: 0x002E1F04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x002E3D11 File Offset: 0x002E1F11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x002E3D18 File Offset: 0x002E1F18
		public static PlayerExp GetRootAsPlayerExp(ByteBuffer _bb)
		{
			return PlayerExp.GetRootAsPlayerExp(_bb, default(PlayerExp));
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x002E3D34 File Offset: 0x002E1F34
		public static PlayerExp GetRootAsPlayerExp(ByteBuffer _bb, PlayerExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x002E3D51 File Offset: 0x002E1F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x002E3D60 File Offset: 0x002E1F60
		public PlayerExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600B782 RID: 46978 RVA: 0x002E3D70 File Offset: 0x002E1F70
		public int PlayerLevel
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

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600B783 RID: 46979 RVA: 0x002E3DAC File Offset: 0x002E1FAC
		public int LevelExp
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

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600B784 RID: 46980 RVA: 0x002E3DE8 File Offset: 0x002E1FE8
		public string Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x002E3E1F File Offset: 0x002E201F
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x002E3E2E File Offset: 0x002E202E
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040055F6 RID: 22006
		private Table __p;
	}
}
