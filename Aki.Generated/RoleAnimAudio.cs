using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001037 RID: 4151
	public struct RoleAnimAudio : IFlatbufferObject
	{
		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600C727 RID: 50983 RVA: 0x002F755D File Offset: 0x002F575D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x002F756A File Offset: 0x002F576A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x002F7574 File Offset: 0x002F5774
		public static RoleAnimAudio GetRootAsRoleAnimAudio(ByteBuffer _bb)
		{
			return RoleAnimAudio.GetRootAsRoleAnimAudio(_bb, default(RoleAnimAudio));
		}

		// Token: 0x0600C72A RID: 50986 RVA: 0x002F7590 File Offset: 0x002F5790
		public static RoleAnimAudio GetRootAsRoleAnimAudio(ByteBuffer _bb, RoleAnimAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x002F75AD File Offset: 0x002F57AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x002F75BC File Offset: 0x002F57BC
		public RoleAnimAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600C72D RID: 50989 RVA: 0x002F75CC File Offset: 0x002F57CC
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

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600C72E RID: 50990 RVA: 0x002F7608 File Offset: 0x002F5808
		public int RoleId
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

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600C72F RID: 50991 RVA: 0x002F7644 File Offset: 0x002F5844
		public string ActionName
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

		// Token: 0x0600C730 RID: 50992 RVA: 0x002F767B File Offset: 0x002F587B
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x002F768A File Offset: 0x002F588A
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600C732 RID: 50994 RVA: 0x002F76A4 File Offset: 0x002F58A4
		public string AudioPath
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

		// Token: 0x0600C733 RID: 50995 RVA: 0x002F76DC File Offset: 0x002F58DC
		public Span<byte> GetAudioPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x002F76EC File Offset: 0x002F58EC
		public byte[] GetAudioPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600C735 RID: 50997 RVA: 0x002F7704 File Offset: 0x002F5904
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005134 RID: 20788
		private Table __p;
	}
}
