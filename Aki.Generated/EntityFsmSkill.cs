using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D17 RID: 3351
	public struct EntityFsmSkill : IFlatbufferObject
	{
		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06006F66 RID: 28518 RVA: 0x00242E35 File Offset: 0x00241035
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00242E42 File Offset: 0x00241042
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00242E4C File Offset: 0x0024104C
		public static EntityFsmSkill GetRootAsEntityFsmSkill(ByteBuffer _bb)
		{
			return EntityFsmSkill.GetRootAsEntityFsmSkill(_bb, default(EntityFsmSkill));
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x00242E68 File Offset: 0x00241068
		public static EntityFsmSkill GetRootAsEntityFsmSkill(ByteBuffer _bb, EntityFsmSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00242E85 File Offset: 0x00241085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00242E94 File Offset: 0x00241094
		public EntityFsmSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x00242EA4 File Offset: 0x002410A4
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

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x00242EE0 File Offset: 0x002410E0
		public int ConfigId
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

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06006F6E RID: 28526 RVA: 0x00242F1C File Offset: 0x0024111C
		public string SkillName
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

		// Token: 0x06006F6F RID: 28527 RVA: 0x00242F53 File Offset: 0x00241153
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00242F62 File Offset: 0x00241162
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06006F71 RID: 28529 RVA: 0x00242F7C File Offset: 0x0024117C
		public int SkillId
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

		// Token: 0x04005257 RID: 21079
		private Table __p;
	}
}
