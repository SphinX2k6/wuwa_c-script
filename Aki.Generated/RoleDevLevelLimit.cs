using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112C RID: 4396
	public struct RoleDevLevelLimit : IFlatbufferObject
	{
		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x003152C7 File Offset: 0x003134C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE5A RID: 52826 RVA: 0x003152D4 File Offset: 0x003134D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE5B RID: 52827 RVA: 0x003152DC File Offset: 0x003134DC
		public static RoleDevLevelLimit GetRootAsRoleDevLevelLimit(ByteBuffer _bb)
		{
			return RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(_bb, default(RoleDevLevelLimit));
		}

		// Token: 0x0600CE5C RID: 52828 RVA: 0x003152F8 File Offset: 0x003134F8
		public static RoleDevLevelLimit GetRootAsRoleDevLevelLimit(ByteBuffer _bb, RoleDevLevelLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE5D RID: 52829 RVA: 0x00315315 File Offset: 0x00313515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE5E RID: 52830 RVA: 0x00315324 File Offset: 0x00313524
		public RoleDevLevelLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x00315334 File Offset: 0x00313534
		public int ProjectNum
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

		// Token: 0x0600CE60 RID: 52832 RVA: 0x00315370 File Offset: 0x00313570
		public IntPair? PlayerLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600CE61 RID: 52833 RVA: 0x003153D0 File Offset: 0x003135D0
		public int PlayerLevelLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x003153FB File Offset: 0x003135FB
		[NullableContext(1)]
		public IntPair[] PlayerLevel()
		{
			return this.PlayerLevelIter().ToArray<IntPair>();
		}

		// Token: 0x0600CE63 RID: 52835 RVA: 0x00315408 File Offset: 0x00313608
		[NullableContext(1)]
		public IEnumerable<IntPair> PlayerLevelIter()
		{
			RoleDevLevelLimit.<PlayerLevelIter>d__14 <PlayerLevelIter>d__ = new RoleDevLevelLimit.<PlayerLevelIter>d__14(-2);
			<PlayerLevelIter>d__.<>3__<>4__this = this;
			return <PlayerLevelIter>d__;
		}

		// Token: 0x0400572A RID: 22314
		private Table __p;
	}
}
