using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101E RID: 4126
	public struct PinballSpawnConfig : IFlatbufferObject
	{
		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600B682 RID: 46722 RVA: 0x002E198E File Offset: 0x002DFB8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B683 RID: 46723 RVA: 0x002E199B File Offset: 0x002DFB9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x002E19A4 File Offset: 0x002DFBA4
		public static PinballSpawnConfig GetRootAsPinballSpawnConfig(ByteBuffer _bb)
		{
			return PinballSpawnConfig.GetRootAsPinballSpawnConfig(_bb, default(PinballSpawnConfig));
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x002E19C0 File Offset: 0x002DFBC0
		public static PinballSpawnConfig GetRootAsPinballSpawnConfig(ByteBuffer _bb, PinballSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B686 RID: 46726 RVA: 0x002E19DD File Offset: 0x002DFBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x002E19EC File Offset: 0x002DFBEC
		public PinballSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600B688 RID: 46728 RVA: 0x002E19FC File Offset: 0x002DFBFC
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

		// Token: 0x0600B689 RID: 46729 RVA: 0x002E1A38 File Offset: 0x002DFC38
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x002E1A78 File Offset: 0x002DFC78
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

		// Token: 0x0600B68B RID: 46731 RVA: 0x002E1AA3 File Offset: 0x002DFCA3
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x002E1AB2 File Offset: 0x002DFCB2
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x002E1AC9 File Offset: 0x002DFCC9
		[NullableContext(1)]
		public int[] MonsterIds()
		{
			return this.GetMonsterIdsArray();
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x002E1AD1 File Offset: 0x002DFCD1
		[NullableContext(1)]
		public IEnumerable<int> MonsterIdsIter()
		{
			PinballSpawnConfig.<MonsterIdsIter>d__16 <MonsterIdsIter>d__ = new PinballSpawnConfig.<MonsterIdsIter>d__16(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x040055E8 RID: 21992
		private Table __p;
	}
}
