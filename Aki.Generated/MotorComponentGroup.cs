using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F14 RID: 3860
	public struct MotorComponentGroup : IFlatbufferObject
	{
		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x002A8D78 File Offset: 0x002A6F78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x002A8D85 File Offset: 0x002A6F85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x002A8D8C File Offset: 0x002A6F8C
		public static MotorComponentGroup GetRootAsMotorComponentGroup(ByteBuffer _bb)
		{
			return MotorComponentGroup.GetRootAsMotorComponentGroup(_bb, default(MotorComponentGroup));
		}

		// Token: 0x06009CDB RID: 40155 RVA: 0x002A8DA8 File Offset: 0x002A6FA8
		public static MotorComponentGroup GetRootAsMotorComponentGroup(ByteBuffer _bb, MotorComponentGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x002A8DC5 File Offset: 0x002A6FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x002A8DD4 File Offset: 0x002A6FD4
		public MotorComponentGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06009CDE RID: 40158 RVA: 0x002A8DE4 File Offset: 0x002A6FE4
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

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06009CDF RID: 40159 RVA: 0x002A8E20 File Offset: 0x002A7020
		public string Desc
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

		// Token: 0x06009CE0 RID: 40160 RVA: 0x002A8E57 File Offset: 0x002A7057
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x002A8E66 File Offset: 0x002A7066
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x002A8E80 File Offset: 0x002A7080
		public int ConflictGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06009CE3 RID: 40163 RVA: 0x002A8EC0 File Offset: 0x002A70C0
		public int ConflictGroupLength
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

		// Token: 0x06009CE4 RID: 40164 RVA: 0x002A8EEB File Offset: 0x002A70EB
		public Span<int> GetConflictGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x002A8EFA File Offset: 0x002A70FA
		public int[] GetConflictGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x002A8F14 File Offset: 0x002A7114
		public string Region(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06009CE7 RID: 40167 RVA: 0x002A8F50 File Offset: 0x002A7150
		public int RegionLength
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

		// Token: 0x06009CE8 RID: 40168 RVA: 0x002A8F7C File Offset: 0x002A717C
		[NullableContext(1)]
		public int[] ConflictGroup()
		{
			return this.GetConflictGroupArray();
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x002A8F84 File Offset: 0x002A7184
		[NullableContext(1)]
		public IEnumerable<int> ConflictGroupIter()
		{
			MotorComponentGroup.<ConflictGroupIter>d__23 <ConflictGroupIter>d__ = new MotorComponentGroup.<ConflictGroupIter>d__23(-2);
			<ConflictGroupIter>d__.<>3__<>4__this = this;
			return <ConflictGroupIter>d__;
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x002A8F99 File Offset: 0x002A7199
		[NullableContext(1)]
		public string[] Region()
		{
			return this.RegionIter().ToArray<string>();
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x002A8FA6 File Offset: 0x002A71A6
		[NullableContext(1)]
		public IEnumerable<string> RegionIter()
		{
			MotorComponentGroup.<RegionIter>d__25 <RegionIter>d__ = new MotorComponentGroup.<RegionIter>d__25(-2);
			<RegionIter>d__.<>3__<>4__this = this;
			return <RegionIter>d__;
		}

		// Token: 0x040054B9 RID: 21689
		private Table __p;
	}
}
