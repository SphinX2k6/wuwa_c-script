using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA8 RID: 3752
	public struct LevelPlayNodeData : IFlatbufferObject
	{
		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060093A8 RID: 37800 RVA: 0x00294FA9 File Offset: 0x002931A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00294FB6 File Offset: 0x002931B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x00294FC0 File Offset: 0x002931C0
		public static LevelPlayNodeData GetRootAsLevelPlayNodeData(ByteBuffer _bb)
		{
			return LevelPlayNodeData.GetRootAsLevelPlayNodeData(_bb, default(LevelPlayNodeData));
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x00294FDC File Offset: 0x002931DC
		public static LevelPlayNodeData GetRootAsLevelPlayNodeData(ByteBuffer _bb, LevelPlayNodeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x00294FF9 File Offset: 0x002931F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00295008 File Offset: 0x00293208
		public LevelPlayNodeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060093AE RID: 37806 RVA: 0x00295018 File Offset: 0x00293218
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x0029504F File Offset: 0x0029324F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x0029505E File Offset: 0x0029325E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060093B1 RID: 37809 RVA: 0x00295078 File Offset: 0x00293278
		public string Data
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

		// Token: 0x060093B2 RID: 37810 RVA: 0x002950AF File Offset: 0x002932AF
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x002950BE File Offset: 0x002932BE
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400543E RID: 21566
		private Table __p;
	}
}
