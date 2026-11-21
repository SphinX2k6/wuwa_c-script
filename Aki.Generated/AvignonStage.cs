using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF4 RID: 3060
	public struct AvignonStage : IFlatbufferObject
	{
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x001FB0F0 File Offset: 0x001F92F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x001FB0FD File Offset: 0x001F92FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x001FB104 File Offset: 0x001F9304
		public static AvignonStage GetRootAsAvignonStage(ByteBuffer _bb)
		{
			return AvignonStage.GetRootAsAvignonStage(_bb, default(AvignonStage));
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x001FB120 File Offset: 0x001F9320
		public static AvignonStage GetRootAsAvignonStage(ByteBuffer _bb, AvignonStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x001FB13D File Offset: 0x001F933D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x001FB14C File Offset: 0x001F934C
		public AvignonStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06004FAA RID: 20394 RVA: 0x001FB15C File Offset: 0x001F935C
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x001FB198 File Offset: 0x001F9398
		public string Title
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

		// Token: 0x06004FAC RID: 20396 RVA: 0x001FB1CF File Offset: 0x001F93CF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x001FB1DE File Offset: 0x001F93DE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x001FB1F8 File Offset: 0x001F93F8
		public int OpenConditionId
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x001FB234 File Offset: 0x001F9434
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

		// Token: 0x06004FB0 RID: 20400 RVA: 0x001FB26C File Offset: 0x001F946C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x001FB27C File Offset: 0x001F947C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x001FB294 File Offset: 0x001F9494
		public string FemaleIcon
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

		// Token: 0x06004FB3 RID: 20403 RVA: 0x001FB2CC File Offset: 0x001F94CC
		public Span<byte> GetFemaleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x001FB2DC File Offset: 0x001F94DC
		public byte[] GetFemaleIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x001FB2F4 File Offset: 0x001F94F4
		public string RomaIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x001FB32C File Offset: 0x001F952C
		public Span<byte> GetRomaIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x001FB33C File Offset: 0x001F953C
		public byte[] GetRomaIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x001FB354 File Offset: 0x001F9554
		public int QuestionId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050DC RID: 20700
		private Table __p;
	}
}
