using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E98 RID: 3736
	public struct KurotatoSpawn : IFlatbufferObject
	{
		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x00290CFD File Offset: 0x0028EEFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x00290D0A File Offset: 0x0028EF0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x00290D14 File Offset: 0x0028EF14
		public static KurotatoSpawn GetRootAsKurotatoSpawn(ByteBuffer _bb)
		{
			return KurotatoSpawn.GetRootAsKurotatoSpawn(_bb, default(KurotatoSpawn));
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x00290D30 File Offset: 0x0028EF30
		public static KurotatoSpawn GetRootAsKurotatoSpawn(ByteBuffer _bb, KurotatoSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x00290D4D File Offset: 0x0028EF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x00290D5C File Offset: 0x0028EF5C
		public KurotatoSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x060091AE RID: 37294 RVA: 0x00290D6C File Offset: 0x0028EF6C
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

		// Token: 0x060091AF RID: 37295 RVA: 0x00290DA8 File Offset: 0x0028EFA8
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x060091B0 RID: 37296 RVA: 0x00290DE8 File Offset: 0x0028EFE8
		public int MonsterIdsLength
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

		// Token: 0x060091B1 RID: 37297 RVA: 0x00290E13 File Offset: 0x0028F013
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x00290E22 File Offset: 0x0028F022
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x00290E3C File Offset: 0x0028F03C
		public int WaypointIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x060091B4 RID: 37300 RVA: 0x00290E7C File Offset: 0x0028F07C
		public int WaypointIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00290EA7 File Offset: 0x0028F0A7
		public Span<int> GetWaypointIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00290EB6 File Offset: 0x0028F0B6
		public int[] GetWaypointIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00290ED0 File Offset: 0x0028F0D0
		public bool WaypointLoop(int j)
		{
			int num = this.__p.__offset(10);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x00290F14 File Offset: 0x0028F114
		public int WaypointLoopLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x00290F40 File Offset: 0x0028F140
		public Span<bool> GetWaypointLoopBytes()
		{
			return this.__p.__vector_as_span<bool>(10, 1);
		}

		// Token: 0x060091BA RID: 37306 RVA: 0x00290F50 File Offset: 0x0028F150
		public bool[] GetWaypointLoopArray()
		{
			return this.__p.__vector_as_array<bool>(10) ?? Array.Empty<bool>();
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x00290F68 File Offset: 0x0028F168
		[NullableContext(1)]
		public int[] MonsterIds()
		{
			return this.GetMonsterIdsArray();
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x00290F70 File Offset: 0x0028F170
		[NullableContext(1)]
		public IEnumerable<int> MonsterIdsIter()
		{
			KurotatoSpawn.<MonsterIdsIter>d__26 <MonsterIdsIter>d__ = new KurotatoSpawn.<MonsterIdsIter>d__26(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x00290F85 File Offset: 0x0028F185
		[NullableContext(1)]
		public int[] WaypointIds()
		{
			return this.GetWaypointIdsArray();
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x00290F8D File Offset: 0x0028F18D
		[NullableContext(1)]
		public IEnumerable<int> WaypointIdsIter()
		{
			KurotatoSpawn.<WaypointIdsIter>d__28 <WaypointIdsIter>d__ = new KurotatoSpawn.<WaypointIdsIter>d__28(-2);
			<WaypointIdsIter>d__.<>3__<>4__this = this;
			return <WaypointIdsIter>d__;
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x00290FA2 File Offset: 0x0028F1A2
		[NullableContext(1)]
		public bool[] WaypointLoop()
		{
			return this.GetWaypointLoopArray();
		}

		// Token: 0x060091C0 RID: 37312 RVA: 0x00290FAA File Offset: 0x0028F1AA
		[NullableContext(1)]
		public IEnumerable<bool> WaypointLoopIter()
		{
			KurotatoSpawn.<WaypointLoopIter>d__30 <WaypointLoopIter>d__ = new KurotatoSpawn.<WaypointLoopIter>d__30(-2);
			<WaypointLoopIter>d__.<>3__<>4__this = this;
			return <WaypointLoopIter>d__;
		}

		// Token: 0x0400542A RID: 21546
		private Table __p;
	}
}
