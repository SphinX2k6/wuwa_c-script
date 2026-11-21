using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001152 RID: 4434
	public struct RoleTowerReward : IFlatbufferObject
	{
		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600D284 RID: 53892 RVA: 0x0031ECD0 File Offset: 0x0031CED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x0031ECDD File Offset: 0x0031CEDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x0031ECE4 File Offset: 0x0031CEE4
		public static RoleTowerReward GetRootAsRoleTowerReward(ByteBuffer _bb)
		{
			return RoleTowerReward.GetRootAsRoleTowerReward(_bb, default(RoleTowerReward));
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x0031ED00 File Offset: 0x0031CF00
		public static RoleTowerReward GetRootAsRoleTowerReward(ByteBuffer _bb, RoleTowerReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x0031ED1D File Offset: 0x0031CF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x0031ED2C File Offset: 0x0031CF2C
		public RoleTowerReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600D28A RID: 53898 RVA: 0x0031ED3C File Offset: 0x0031CF3C
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

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600D28B RID: 53899 RVA: 0x0031ED78 File Offset: 0x0031CF78
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

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600D28C RID: 53900 RVA: 0x0031EDB4 File Offset: 0x0031CFB4
		public int TabId
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

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600D28D RID: 53901 RVA: 0x0031EDF0 File Offset: 0x0031CFF0
		public int ProgressType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600D28E RID: 53902 RVA: 0x0031EE30 File Offset: 0x0031D030
		public int DropId
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

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600D28F RID: 53903 RVA: 0x0031EE70 File Offset: 0x0031D070
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D290 RID: 53904 RVA: 0x0031EEA8 File Offset: 0x0031D0A8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D291 RID: 53905 RVA: 0x0031EEB8 File Offset: 0x0031D0B8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x0031EED0 File Offset: 0x0031D0D0
		public string DescParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600D293 RID: 53907 RVA: 0x0031EF0C File Offset: 0x0031D10C
		public int DescParamLength
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

		// Token: 0x0600D294 RID: 53908 RVA: 0x0031EF38 File Offset: 0x0031D138
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x0031EF45 File Offset: 0x0031D145
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RoleTowerReward.<DescParamIter>d__26 <DescParamIter>d__ = new RoleTowerReward.<DescParamIter>d__26(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x04005759 RID: 22361
		private Table __p;
	}
}
