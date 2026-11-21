using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE8 RID: 3048
	public struct AtmosphereLevel : IFlatbufferObject
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x001F9734 File Offset: 0x001F7934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x001F9741 File Offset: 0x001F7941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x001F9748 File Offset: 0x001F7948
		public static AtmosphereLevel GetRootAsAtmosphereLevel(ByteBuffer _bb)
		{
			return AtmosphereLevel.GetRootAsAtmosphereLevel(_bb, default(AtmosphereLevel));
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x001F9764 File Offset: 0x001F7964
		public static AtmosphereLevel GetRootAsAtmosphereLevel(ByteBuffer _bb, AtmosphereLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x001F9781 File Offset: 0x001F7981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x001F9790 File Offset: 0x001F7990
		public AtmosphereLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x001F97A0 File Offset: 0x001F79A0
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x001F97DC File Offset: 0x001F79DC
		public int Level
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

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x001F9818 File Offset: 0x001F7A18
		public int ActivityId
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

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x001F9854 File Offset: 0x001F7A54
		public int AtmosphereNext
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x001F9894 File Offset: 0x001F7A94
		public int AtmosphereNeed
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x001F98D4 File Offset: 0x001F7AD4
		public int DropId
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

		// Token: 0x06004ED9 RID: 20185 RVA: 0x001F9914 File Offset: 0x001F7B14
		public int UnlockFunction(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06004EDA RID: 20186 RVA: 0x001F9954 File Offset: 0x001F7B54
		public int UnlockFunctionLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x001F9980 File Offset: 0x001F7B80
		public Span<int> GetUnlockFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x001F9990 File Offset: 0x001F7B90
		public int[] GetUnlockFunctionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x001F99A8 File Offset: 0x001F7BA8
		public int UpgradeWay(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06004EDE RID: 20190 RVA: 0x001F99E8 File Offset: 0x001F7BE8
		public int UpgradeWayLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x001F9A14 File Offset: 0x001F7C14
		public Span<int> GetUpgradeWayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x001F9A24 File Offset: 0x001F7C24
		public int[] GetUpgradeWayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x001F9A3C File Offset: 0x001F7C3C
		[NullableContext(1)]
		public int[] UnlockFunction()
		{
			return this.GetUnlockFunctionArray();
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x001F9A44 File Offset: 0x001F7C44
		[NullableContext(1)]
		public IEnumerable<int> UnlockFunctionIter()
		{
			AtmosphereLevel.<UnlockFunctionIter>d__31 <UnlockFunctionIter>d__ = new AtmosphereLevel.<UnlockFunctionIter>d__31(-2);
			<UnlockFunctionIter>d__.<>3__<>4__this = this;
			return <UnlockFunctionIter>d__;
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x001F9A59 File Offset: 0x001F7C59
		[NullableContext(1)]
		public int[] UpgradeWay()
		{
			return this.GetUpgradeWayArray();
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x001F9A61 File Offset: 0x001F7C61
		[NullableContext(1)]
		public IEnumerable<int> UpgradeWayIter()
		{
			AtmosphereLevel.<UpgradeWayIter>d__33 <UpgradeWayIter>d__ = new AtmosphereLevel.<UpgradeWayIter>d__33(-2);
			<UpgradeWayIter>d__.<>3__<>4__this = this;
			return <UpgradeWayIter>d__;
		}

		// Token: 0x040050D0 RID: 20688
		private Table __p;
	}
}
