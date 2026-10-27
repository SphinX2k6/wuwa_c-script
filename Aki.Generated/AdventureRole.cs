using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD2 RID: 2770
	public struct AdventureRole : IFlatbufferObject
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x001CE0AD File Offset: 0x001CC2AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x001CE0BA File Offset: 0x001CC2BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x001CE0C4 File Offset: 0x001CC2C4
		public static AdventureRole GetRootAsAdventureRole(ByteBuffer _bb)
		{
			return AdventureRole.GetRootAsAdventureRole(_bb, default(AdventureRole));
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x001CE0E0 File Offset: 0x001CC2E0
		public static AdventureRole GetRootAsAdventureRole(ByteBuffer _bb, AdventureRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x001CE0FD File Offset: 0x001CC2FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x001CE10C File Offset: 0x001CC30C
		public AdventureRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x001CE11C File Offset: 0x001CC31C
		public int RoleId
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x001CE158 File Offset: 0x001CC358
		public string DesText
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

		// Token: 0x06004450 RID: 17488 RVA: 0x001CE18F File Offset: 0x001CC38F
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x001CE19E File Offset: 0x001CC39E
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x001CE1B8 File Offset: 0x001CC3B8
		public string HeadCard
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

		// Token: 0x06004453 RID: 17491 RVA: 0x001CE1EF File Offset: 0x001CC3EF
		public Span<byte> GetHeadCardBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x001CE1FE File Offset: 0x001CC3FE
		public byte[] GetHeadCardArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x001CE218 File Offset: 0x001CC418
		public int TrialRoleId
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

		// Token: 0x04004AAF RID: 19119
		private Table __p;
	}
}
