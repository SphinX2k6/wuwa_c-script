using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0F RID: 3599
	public struct MonsterBodyTypeConfig : IFlatbufferObject
	{
		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06009484 RID: 38020 RVA: 0x002866AD File Offset: 0x002848AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x002866BA File Offset: 0x002848BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x002866C4 File Offset: 0x002848C4
		public static MonsterBodyTypeConfig GetRootAsMonsterBodyTypeConfig(ByteBuffer _bb)
		{
			return MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(_bb, default(MonsterBodyTypeConfig));
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x002866E0 File Offset: 0x002848E0
		public static MonsterBodyTypeConfig GetRootAsMonsterBodyTypeConfig(ByteBuffer _bb, MonsterBodyTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x002866FD File Offset: 0x002848FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x0028670C File Offset: 0x0028490C
		public MonsterBodyTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x0028671C File Offset: 0x0028491C
		public int Id
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

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x00286758 File Offset: 0x00284958
		public string HandBookCameraId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x0028678F File Offset: 0x0028498F
		public Span<byte> GetHandBookCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x0028679E File Offset: 0x0028499E
		public byte[] GetHandBookCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600948E RID: 38030 RVA: 0x002867B8 File Offset: 0x002849B8
		public int MoveForwardDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600948F RID: 38031 RVA: 0x002867F4 File Offset: 0x002849F4
		public int MoveForwardDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06009490 RID: 38032 RVA: 0x00286834 File Offset: 0x00284A34
		public string MoveForwardCurvePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x0028686C File Offset: 0x00284A6C
		public Span<byte> GetMoveForwardCurvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0028687C File Offset: 0x00284A7C
		public byte[] GetMoveForwardCurvePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EB4 RID: 20148
		private Table __p;
	}
}
