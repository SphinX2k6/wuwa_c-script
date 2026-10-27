using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0E RID: 2830
	public struct AtmosphereLevel : IFlatbufferObject
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x001D9FC4 File Offset: 0x001D81C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x001D9FD1 File Offset: 0x001D81D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x001D9FD8 File Offset: 0x001D81D8
		public static AtmosphereLevel GetRootAsAtmosphereLevel(ByteBuffer _bb)
		{
			return AtmosphereLevel.GetRootAsAtmosphereLevel(_bb, default(AtmosphereLevel));
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x001D9FF4 File Offset: 0x001D81F4
		public static AtmosphereLevel GetRootAsAtmosphereLevel(ByteBuffer _bb, AtmosphereLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x001DA011 File Offset: 0x001D8211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x001DA020 File Offset: 0x001D8220
		public AtmosphereLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x001DA030 File Offset: 0x001D8230
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x001DA06C File Offset: 0x001D826C
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

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x001DA0A8 File Offset: 0x001D82A8
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x001DA0E4 File Offset: 0x001D82E4
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

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x001DA124 File Offset: 0x001D8324
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x001DA164 File Offset: 0x001D8364
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

		// Token: 0x06004992 RID: 18834 RVA: 0x001DA1A4 File Offset: 0x001D83A4
		public int UnlockFunction(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x001DA1E4 File Offset: 0x001D83E4
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

		// Token: 0x06004994 RID: 18836 RVA: 0x001DA210 File Offset: 0x001D8410
		public Span<int> GetUnlockFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x001DA220 File Offset: 0x001D8420
		public int[] GetUnlockFunctionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x001DA238 File Offset: 0x001D8438
		public int UpgradeWay(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x001DA278 File Offset: 0x001D8478
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

		// Token: 0x06004998 RID: 18840 RVA: 0x001DA2A4 File Offset: 0x001D84A4
		public Span<int> GetUpgradeWayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x001DA2B4 File Offset: 0x001D84B4
		public int[] GetUpgradeWayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x001DA2CC File Offset: 0x001D84CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockFunctionIter()或GetUnlockFunctionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockFunction()
		{
			AtmosphereLevel atmosphereLevel = this;
			return atmosphereLevel.GetUnlockFunctionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x001DA2F0 File Offset: 0x001D84F0
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockFunctionIter()
		{
			AtmosphereLevel.<UnlockFunctionIter>d__31 <UnlockFunctionIter>d__ = new AtmosphereLevel.<UnlockFunctionIter>d__31(-2);
			<UnlockFunctionIter>d__.<>3__<>4__this = this;
			return <UnlockFunctionIter>d__;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x001DA308 File Offset: 0x001D8508
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpgradeWayIter()或GetUpgradeWayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UpgradeWay()
		{
			AtmosphereLevel atmosphereLevel = this;
			return atmosphereLevel.GetUpgradeWayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x001DA32C File Offset: 0x001D852C
		[NullableContext(1)]
		public readonly IEnumerable<int> UpgradeWayIter()
		{
			AtmosphereLevel.<UpgradeWayIter>d__33 <UpgradeWayIter>d__ = new AtmosphereLevel.<UpgradeWayIter>d__33(-2);
			<UpgradeWayIter>d__.<>3__<>4__this = this;
			return <UpgradeWayIter>d__;
		}

		// Token: 0x04004AF6 RID: 19190
		private Table __p;
	}
}
