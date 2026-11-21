using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF4 RID: 3828
	public struct MonsterBodyTypeConfig : IFlatbufferObject
	{
		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x002A4492 File Offset: 0x002A2692
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x002A449F File Offset: 0x002A269F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x002A44A8 File Offset: 0x002A26A8
		public static MonsterBodyTypeConfig GetRootAsMonsterBodyTypeConfig(ByteBuffer _bb)
		{
			return MonsterBodyTypeConfig.GetRootAsMonsterBodyTypeConfig(_bb, default(MonsterBodyTypeConfig));
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x002A44C4 File Offset: 0x002A26C4
		public static MonsterBodyTypeConfig GetRootAsMonsterBodyTypeConfig(ByteBuffer _bb, MonsterBodyTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AA8 RID: 39592 RVA: 0x002A44E1 File Offset: 0x002A26E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AA9 RID: 39593 RVA: 0x002A44F0 File Offset: 0x002A26F0
		public MonsterBodyTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x002A4500 File Offset: 0x002A2700
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

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06009AAB RID: 39595 RVA: 0x002A453C File Offset: 0x002A273C
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

		// Token: 0x06009AAC RID: 39596 RVA: 0x002A4573 File Offset: 0x002A2773
		public Span<byte> GetHandBookCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x002A4582 File Offset: 0x002A2782
		public byte[] GetHandBookCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06009AAE RID: 39598 RVA: 0x002A459C File Offset: 0x002A279C
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

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06009AAF RID: 39599 RVA: 0x002A45D8 File Offset: 0x002A27D8
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x002A4618 File Offset: 0x002A2818
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

		// Token: 0x06009AB1 RID: 39601 RVA: 0x002A4650 File Offset: 0x002A2850
		public Span<byte> GetMoveForwardCurvePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x002A4660 File Offset: 0x002A2860
		public byte[] GetMoveForwardCurvePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005499 RID: 21657
		private Table __p;
	}
}
