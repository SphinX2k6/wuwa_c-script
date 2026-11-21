using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101A RID: 4122
	public struct PinballRank : IFlatbufferObject
	{
		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0600B601 RID: 46593 RVA: 0x002E079D File Offset: 0x002DE99D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x002E07AA File Offset: 0x002DE9AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x002E07B4 File Offset: 0x002DE9B4
		public static PinballRank GetRootAsPinballRank(ByteBuffer _bb)
		{
			return PinballRank.GetRootAsPinballRank(_bb, default(PinballRank));
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x002E07D0 File Offset: 0x002DE9D0
		public static PinballRank GetRootAsPinballRank(ByteBuffer _bb, PinballRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x002E07ED File Offset: 0x002DE9ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x002E07FC File Offset: 0x002DE9FC
		public PinballRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0600B607 RID: 46599 RVA: 0x002E080C File Offset: 0x002DEA0C
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

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x002E0848 File Offset: 0x002DEA48
		public int Tower
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

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600B609 RID: 46601 RVA: 0x002E0884 File Offset: 0x002DEA84
		public int PassTime
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

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600B60A RID: 46602 RVA: 0x002E08C0 File Offset: 0x002DEAC0
		public int DisplayThreshold
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

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600B60B RID: 46603 RVA: 0x002E0900 File Offset: 0x002DEB00
		public string PlayerName
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

		// Token: 0x0600B60C RID: 46604 RVA: 0x002E0938 File Offset: 0x002DEB38
		public Span<byte> GetPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x002E0948 File Offset: 0x002DEB48
		public byte[] GetPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x002E0960 File Offset: 0x002DEB60
		public string RoleList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x002E099C File Offset: 0x002DEB9C
		public int RoleListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B610 RID: 46608 RVA: 0x002E09C8 File Offset: 0x002DEBC8
		[NullableContext(1)]
		public string[] RoleList()
		{
			return this.RoleListIter().ToArray<string>();
		}

		// Token: 0x0600B611 RID: 46609 RVA: 0x002E09D5 File Offset: 0x002DEBD5
		[NullableContext(1)]
		public IEnumerable<string> RoleListIter()
		{
			PinballRank.<RoleListIter>d__24 <RoleListIter>d__ = new PinballRank.<RoleListIter>d__24(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x040055E4 RID: 21988
		private Table __p;
	}
}
