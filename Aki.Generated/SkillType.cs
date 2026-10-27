using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C7 RID: 4295
	public struct SkillType : IFlatbufferObject
	{
		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x00319100 File Offset: 0x00317300
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x0031910D File Offset: 0x0031730D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x00319114 File Offset: 0x00317314
		public static SkillType GetRootAsSkillType(ByteBuffer _bb)
		{
			return SkillType.GetRootAsSkillType(_bb, default(SkillType));
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x00319130 File Offset: 0x00317330
		public static SkillType GetRootAsSkillType(ByteBuffer _bb, SkillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x0031914D File Offset: 0x0031734D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x0031915C File Offset: 0x0031735C
		public SkillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600D5CA RID: 54730 RVA: 0x0031916C File Offset: 0x0031736C
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

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x003191A8 File Offset: 0x003173A8
		public string TypeName
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

		// Token: 0x0600D5CC RID: 54732 RVA: 0x003191DF File Offset: 0x003173DF
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x003191EE File Offset: 0x003173EE
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051F5 RID: 20981
		private Table __p;
	}
}
