using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001074 RID: 4212
	public struct RacingBetsOddsUpdate : IFlatbufferObject
	{
		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x002F2900 File Offset: 0x002F0B00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEAD RID: 48813 RVA: 0x002F290D File Offset: 0x002F0B0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEAE RID: 48814 RVA: 0x002F2914 File Offset: 0x002F0B14
		public static RacingBetsOddsUpdate GetRootAsRacingBetsOddsUpdate(ByteBuffer _bb)
		{
			return RacingBetsOddsUpdate.GetRootAsRacingBetsOddsUpdate(_bb, default(RacingBetsOddsUpdate));
		}

		// Token: 0x0600BEAF RID: 48815 RVA: 0x002F2930 File Offset: 0x002F0B30
		public static RacingBetsOddsUpdate GetRootAsRacingBetsOddsUpdate(ByteBuffer _bb, RacingBetsOddsUpdate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x002F294D File Offset: 0x002F0B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEB1 RID: 48817 RVA: 0x002F295C File Offset: 0x002F0B5C
		public RacingBetsOddsUpdate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x002F296C File Offset: 0x002F0B6C
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

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x002F29A8 File Offset: 0x002F0BA8
		public int IndexId
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

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x002F29E4 File Offset: 0x002F0BE4
		public string OddsUpdatePoint(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600BEB5 RID: 48821 RVA: 0x002F2A20 File Offset: 0x002F0C20
		public int OddsUpdatePointLength
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

		// Token: 0x0600BEB6 RID: 48822 RVA: 0x002F2A4B File Offset: 0x002F0C4B
		[NullableContext(1)]
		public string[] OddsUpdatePoint()
		{
			return this.OddsUpdatePointIter().ToArray<string>();
		}

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x002F2A58 File Offset: 0x002F0C58
		[NullableContext(1)]
		public IEnumerable<string> OddsUpdatePointIter()
		{
			RacingBetsOddsUpdate.<OddsUpdatePointIter>d__16 <OddsUpdatePointIter>d__ = new RacingBetsOddsUpdate.<OddsUpdatePointIter>d__16(-2);
			<OddsUpdatePointIter>d__.<>3__<>4__this = this;
			return <OddsUpdatePointIter>d__;
		}

		// Token: 0x04005643 RID: 22083
		private Table __p;
	}
}
