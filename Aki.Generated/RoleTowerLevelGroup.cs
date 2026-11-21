using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001150 RID: 4432
	public struct RoleTowerLevelGroup : IFlatbufferObject
	{
		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600D261 RID: 53857 RVA: 0x0031E83A File Offset: 0x0031CA3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D262 RID: 53858 RVA: 0x0031E847 File Offset: 0x0031CA47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D263 RID: 53859 RVA: 0x0031E850 File Offset: 0x0031CA50
		public static RoleTowerLevelGroup GetRootAsRoleTowerLevelGroup(ByteBuffer _bb)
		{
			return RoleTowerLevelGroup.GetRootAsRoleTowerLevelGroup(_bb, default(RoleTowerLevelGroup));
		}

		// Token: 0x0600D264 RID: 53860 RVA: 0x0031E86C File Offset: 0x0031CA6C
		public static RoleTowerLevelGroup GetRootAsRoleTowerLevelGroup(ByteBuffer _bb, RoleTowerLevelGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D265 RID: 53861 RVA: 0x0031E889 File Offset: 0x0031CA89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D266 RID: 53862 RVA: 0x0031E898 File Offset: 0x0031CA98
		public RoleTowerLevelGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600D267 RID: 53863 RVA: 0x0031E8A8 File Offset: 0x0031CAA8
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

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600D268 RID: 53864 RVA: 0x0031E8E4 File Offset: 0x0031CAE4
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

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600D269 RID: 53865 RVA: 0x0031E920 File Offset: 0x0031CB20
		public int Type
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

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600D26A RID: 53866 RVA: 0x0031E95C File Offset: 0x0031CB5C
		public string Name
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

		// Token: 0x0600D26B RID: 53867 RVA: 0x0031E994 File Offset: 0x0031CB94
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D26C RID: 53868 RVA: 0x0031E9A4 File Offset: 0x0031CBA4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x0031E9BC File Offset: 0x0031CBBC
		public int PerLevels(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600D26E RID: 53870 RVA: 0x0031E9FC File Offset: 0x0031CBFC
		public int PerLevelsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D26F RID: 53871 RVA: 0x0031EA28 File Offset: 0x0031CC28
		public Span<int> GetPerLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D270 RID: 53872 RVA: 0x0031EA38 File Offset: 0x0031CC38
		public int[] GetPerLevelsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x0031EA50 File Offset: 0x0031CC50
		[NullableContext(1)]
		public int[] PerLevels()
		{
			return this.GetPerLevelsArray();
		}

		// Token: 0x0600D272 RID: 53874 RVA: 0x0031EA58 File Offset: 0x0031CC58
		[NullableContext(1)]
		public IEnumerable<int> PerLevelsIter()
		{
			RoleTowerLevelGroup.<PerLevelsIter>d__24 <PerLevelsIter>d__ = new RoleTowerLevelGroup.<PerLevelsIter>d__24(-2);
			<PerLevelsIter>d__.<>3__<>4__this = this;
			return <PerLevelsIter>d__;
		}

		// Token: 0x04005757 RID: 22359
		private Table __p;
	}
}
