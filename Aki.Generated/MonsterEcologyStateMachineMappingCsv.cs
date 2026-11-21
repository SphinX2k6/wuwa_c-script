using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF9 RID: 3833
	public struct MonsterEcologyStateMachineMappingCsv : IFlatbufferObject
	{
		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06009B02 RID: 39682 RVA: 0x002A5130 File Offset: 0x002A3330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x002A513D File Offset: 0x002A333D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x002A5144 File Offset: 0x002A3344
		public static MonsterEcologyStateMachineMappingCsv GetRootAsMonsterEcologyStateMachineMappingCsv(ByteBuffer _bb)
		{
			return MonsterEcologyStateMachineMappingCsv.GetRootAsMonsterEcologyStateMachineMappingCsv(_bb, default(MonsterEcologyStateMachineMappingCsv));
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x002A5160 File Offset: 0x002A3360
		public static MonsterEcologyStateMachineMappingCsv GetRootAsMonsterEcologyStateMachineMappingCsv(ByteBuffer _bb, MonsterEcologyStateMachineMappingCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x002A517D File Offset: 0x002A337D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x002A518C File Offset: 0x002A338C
		public MonsterEcologyStateMachineMappingCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x002A519C File Offset: 0x002A339C
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

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06009B09 RID: 39689 RVA: 0x002A51D8 File Offset: 0x002A33D8
		public string ActionTag
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

		// Token: 0x06009B0A RID: 39690 RVA: 0x002A520F File Offset: 0x002A340F
		public Span<byte> GetActionTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x002A521E File Offset: 0x002A341E
		public byte[] GetActionTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x002A5238 File Offset: 0x002A3438
		public string StateTag
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

		// Token: 0x06009B0D RID: 39693 RVA: 0x002A526F File Offset: 0x002A346F
		public Span<byte> GetStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x002A527E File Offset: 0x002A347E
		public byte[] GetStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06009B0F RID: 39695 RVA: 0x002A5298 File Offset: 0x002A3498
		public string Remark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x002A52D0 File Offset: 0x002A34D0
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x002A52E0 File Offset: 0x002A34E0
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400549E RID: 21662
		private Table __p;
	}
}
