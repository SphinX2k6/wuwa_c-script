using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C33 RID: 3123
	public struct EntityCommonTagInfo : IFlatbufferObject
	{
		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600695A RID: 26970 RVA: 0x002239CA File Offset: 0x00221BCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x002239D7 File Offset: 0x00221BD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x002239E0 File Offset: 0x00221BE0
		public static EntityCommonTagInfo GetRootAsEntityCommonTagInfo(ByteBuffer _bb)
		{
			return EntityCommonTagInfo.GetRootAsEntityCommonTagInfo(_bb, default(EntityCommonTagInfo));
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x002239FC File Offset: 0x00221BFC
		public static EntityCommonTagInfo GetRootAsEntityCommonTagInfo(ByteBuffer _bb, EntityCommonTagInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00223A19 File Offset: 0x00221C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x00223A28 File Offset: 0x00221C28
		public EntityCommonTagInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x00223A38 File Offset: 0x00221C38
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

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x00223A74 File Offset: 0x00221C74
		public string UglyTagName
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

		// Token: 0x06006962 RID: 26978 RVA: 0x00223AAB File Offset: 0x00221CAB
		public Span<byte> GetUglyTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00223ABA File Offset: 0x00221CBA
		public byte[] GetUglyTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C73 RID: 19571
		private Table __p;
	}
}
