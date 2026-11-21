using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD4 RID: 4052
	public struct PhantomMainProperty : IFlatbufferObject
	{
		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x0600AFA0 RID: 44960 RVA: 0x002D2201 File Offset: 0x002D0401
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFA1 RID: 44961 RVA: 0x002D220E File Offset: 0x002D040E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x002D2218 File Offset: 0x002D0418
		public static PhantomMainProperty GetRootAsPhantomMainProperty(ByteBuffer _bb)
		{
			return PhantomMainProperty.GetRootAsPhantomMainProperty(_bb, default(PhantomMainProperty));
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x002D2234 File Offset: 0x002D0434
		public static PhantomMainProperty GetRootAsPhantomMainProperty(ByteBuffer _bb, PhantomMainProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x002D2251 File Offset: 0x002D0451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x002D2260 File Offset: 0x002D0460
		public PhantomMainProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x002D2270 File Offset: 0x002D0470
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

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600AFA7 RID: 44967 RVA: 0x002D22AC File Offset: 0x002D04AC
		public int RandGroupId
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

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x002D22E8 File Offset: 0x002D04E8
		public int PropGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600AFA9 RID: 44969 RVA: 0x002D2328 File Offset: 0x002D0528
		public int PropGroupLength
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

		// Token: 0x0600AFAA RID: 44970 RVA: 0x002D2353 File Offset: 0x002D0553
		public Span<int> GetPropGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x002D2362 File Offset: 0x002D0562
		public int[] GetPropGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x002D2379 File Offset: 0x002D0579
		[NullableContext(1)]
		public int[] PropGroup()
		{
			return this.GetPropGroupArray();
		}

		// Token: 0x0600AFAD RID: 44973 RVA: 0x002D2381 File Offset: 0x002D0581
		[NullableContext(1)]
		public IEnumerable<int> PropGroupIter()
		{
			PhantomMainProperty.<PropGroupIter>d__18 <PropGroupIter>d__ = new PhantomMainProperty.<PropGroupIter>d__18(-2);
			<PropGroupIter>d__.<>3__<>4__this = this;
			return <PropGroupIter>d__;
		}

		// Token: 0x04005596 RID: 21910
		private Table __p;
	}
}
