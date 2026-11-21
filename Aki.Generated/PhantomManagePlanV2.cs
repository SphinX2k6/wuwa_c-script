using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD7 RID: 4055
	public struct PhantomManagePlanV2 : IFlatbufferObject
	{
		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600AFCD RID: 45005 RVA: 0x002D289C File Offset: 0x002D0A9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x002D28A9 File Offset: 0x002D0AA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x002D28B0 File Offset: 0x002D0AB0
		public static PhantomManagePlanV2 GetRootAsPhantomManagePlanV2(ByteBuffer _bb)
		{
			return PhantomManagePlanV2.GetRootAsPhantomManagePlanV2(_bb, default(PhantomManagePlanV2));
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x002D28CC File Offset: 0x002D0ACC
		public static PhantomManagePlanV2 GetRootAsPhantomManagePlanV2(ByteBuffer _bb, PhantomManagePlanV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x002D28E9 File Offset: 0x002D0AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x002D28F8 File Offset: 0x002D0AF8
		public PhantomManagePlanV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600AFD3 RID: 45011 RVA: 0x002D2908 File Offset: 0x002D0B08
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

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600AFD4 RID: 45012 RVA: 0x002D2944 File Offset: 0x002D0B44
		public int FetterId
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

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600AFD5 RID: 45013 RVA: 0x002D2980 File Offset: 0x002D0B80
		public int Cost
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

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x002D29BC File Offset: 0x002D0BBC
		public int LockGroup(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x002D29FC File Offset: 0x002D0BFC
		public int LockGroupLength
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

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x002D2A28 File Offset: 0x002D0C28
		public Span<int> GetLockGroupBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x002D2A38 File Offset: 0x002D0C38
		public int[] GetLockGroupArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x002D2A50 File Offset: 0x002D0C50
		public int DiscardGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600AFDB RID: 45019 RVA: 0x002D2A90 File Offset: 0x002D0C90
		public int DiscardGroupLength
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

		// Token: 0x0600AFDC RID: 45020 RVA: 0x002D2ABC File Offset: 0x002D0CBC
		public Span<int> GetDiscardGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x002D2ACC File Offset: 0x002D0CCC
		public int[] GetDiscardGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x002D2AE4 File Offset: 0x002D0CE4
		[NullableContext(1)]
		public int[] DiscardGroup()
		{
			return this.GetDiscardGroupArray();
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x002D2AEC File Offset: 0x002D0CEC
		[NullableContext(1)]
		public IEnumerable<int> DiscardGroupIter()
		{
			PhantomManagePlanV2.<DiscardGroupIter>d__25 <DiscardGroupIter>d__ = new PhantomManagePlanV2.<DiscardGroupIter>d__25(-2);
			<DiscardGroupIter>d__.<>3__<>4__this = this;
			return <DiscardGroupIter>d__;
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x002D2B01 File Offset: 0x002D0D01
		[NullableContext(1)]
		public int[] LockGroup()
		{
			return this.GetLockGroupArray();
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x002D2B09 File Offset: 0x002D0D09
		[NullableContext(1)]
		public IEnumerable<int> LockGroupIter()
		{
			PhantomManagePlanV2.<LockGroupIter>d__27 <LockGroupIter>d__ = new PhantomManagePlanV2.<LockGroupIter>d__27(-2);
			<LockGroupIter>d__.<>3__<>4__this = this;
			return <LockGroupIter>d__;
		}

		// Token: 0x0400559A RID: 21914
		private Table __p;
	}
}
