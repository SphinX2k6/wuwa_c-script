using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B6 RID: 4534
	public struct SkillButtonText : IFlatbufferObject
	{
		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600DBF4 RID: 56308 RVA: 0x00333EDC File Offset: 0x003320DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00333EE9 File Offset: 0x003320E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBF6 RID: 56310 RVA: 0x00333EF0 File Offset: 0x003320F0
		public static SkillButtonText GetRootAsSkillButtonText(ByteBuffer _bb)
		{
			return SkillButtonText.GetRootAsSkillButtonText(_bb, default(SkillButtonText));
		}

		// Token: 0x0600DBF7 RID: 56311 RVA: 0x00333F0C File Offset: 0x0033210C
		public static SkillButtonText GetRootAsSkillButtonText(ByteBuffer _bb, SkillButtonText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBF8 RID: 56312 RVA: 0x00333F29 File Offset: 0x00332129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBF9 RID: 56313 RVA: 0x00333F38 File Offset: 0x00332138
		public SkillButtonText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x00333F48 File Offset: 0x00332148
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

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600DBFB RID: 56315 RVA: 0x00333F84 File Offset: 0x00332184
		public string Name
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

		// Token: 0x0600DBFC RID: 56316 RVA: 0x00333FBB File Offset: 0x003321BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DBFD RID: 56317 RVA: 0x00333FCA File Offset: 0x003321CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040057D9 RID: 22489
		private Table __p;
	}
}
