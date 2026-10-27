using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6C RID: 3180
	public struct FightPhotoTab : IFlatbufferObject
	{
		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06006E1B RID: 28187 RVA: 0x0022E4A5 File Offset: 0x0022C6A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x0022E4B2 File Offset: 0x0022C6B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x0022E4BC File Offset: 0x0022C6BC
		public static FightPhotoTab GetRootAsFightPhotoTab(ByteBuffer _bb)
		{
			return FightPhotoTab.GetRootAsFightPhotoTab(_bb, default(FightPhotoTab));
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x0022E4D8 File Offset: 0x0022C6D8
		public static FightPhotoTab GetRootAsFightPhotoTab(ByteBuffer _bb, FightPhotoTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x0022E4F5 File Offset: 0x0022C6F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x0022E504 File Offset: 0x0022C704
		public FightPhotoTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06006E21 RID: 28193 RVA: 0x0022E514 File Offset: 0x0022C714
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

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x0022E550 File Offset: 0x0022C750
		public int SortId
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

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06006E23 RID: 28195 RVA: 0x0022E58C File Offset: 0x0022C78C
		public string Name
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

		// Token: 0x06006E24 RID: 28196 RVA: 0x0022E5C3 File Offset: 0x0022C7C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x0022E5D2 File Offset: 0x0022C7D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x0022E5EC File Offset: 0x0022C7EC
		public string Icon
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

		// Token: 0x06006E27 RID: 28199 RVA: 0x0022E624 File Offset: 0x0022C824
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0022E634 File Offset: 0x0022C834
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x0022E64C File Offset: 0x0022C84C
		public string UnselectedIcon
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

		// Token: 0x06006E2A RID: 28202 RVA: 0x0022E684 File Offset: 0x0022C884
		public Span<byte> GetUnselectedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x0022E694 File Offset: 0x0022C894
		public byte[] GetUnselectedIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x0022E6AC File Offset: 0x0022C8AC
		public bool IsShowRedDot
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004CB7 RID: 19639
		private Table __p;
	}
}
