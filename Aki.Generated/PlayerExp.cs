using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F44 RID: 3908
	public struct PlayerExp : IFlatbufferObject
	{
		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600B15B RID: 45403 RVA: 0x002C7480 File Offset: 0x002C5680
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x002C748D File Offset: 0x002C568D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x002C7494 File Offset: 0x002C5694
		public static PlayerExp GetRootAsPlayerExp(ByteBuffer _bb)
		{
			return PlayerExp.GetRootAsPlayerExp(_bb, default(PlayerExp));
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x002C74B0 File Offset: 0x002C56B0
		public static PlayerExp GetRootAsPlayerExp(ByteBuffer _bb, PlayerExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x002C74CD File Offset: 0x002C56CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x002C74DC File Offset: 0x002C56DC
		public PlayerExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600B161 RID: 45409 RVA: 0x002C74EC File Offset: 0x002C56EC
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

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600B162 RID: 45410 RVA: 0x002C7528 File Offset: 0x002C5728
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

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0600B163 RID: 45411 RVA: 0x002C7564 File Offset: 0x002C5764
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

		// Token: 0x0600B164 RID: 45412 RVA: 0x002C759B File Offset: 0x002C579B
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x002C75AA File Offset: 0x002C57AA
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005011 RID: 20497
		private Table __p;
	}
}
