using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9D RID: 3997
	public struct RealmBetweenTask : IFlatbufferObject
	{
		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x002D85A0 File Offset: 0x002D67A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x002D85AD File Offset: 0x002D67AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x002D85B4 File Offset: 0x002D67B4
		public static RealmBetweenTask GetRootAsRealmBetweenTask(ByteBuffer _bb)
		{
			return RealmBetweenTask.GetRootAsRealmBetweenTask(_bb, default(RealmBetweenTask));
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x002D85D0 File Offset: 0x002D67D0
		public static RealmBetweenTask GetRootAsRealmBetweenTask(ByteBuffer _bb, RealmBetweenTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x002D85ED File Offset: 0x002D67ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x002D85FC File Offset: 0x002D67FC
		public RealmBetweenTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x002D860C File Offset: 0x002D680C
		public int TaskId
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

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600B97C RID: 47484 RVA: 0x002D8648 File Offset: 0x002D6848
		public int ActivityId
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

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x002D8684 File Offset: 0x002D6884
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

		// Token: 0x0600B97E RID: 47486 RVA: 0x002D86BB File Offset: 0x002D68BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x002D86CA File Offset: 0x002D68CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x002D86E4 File Offset: 0x002D68E4
		public int TaskReward
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

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x002D8724 File Offset: 0x002D6924
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x002D8764 File Offset: 0x002D6964
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400506D RID: 20589
		private Table __p;
	}
}
