using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B20 RID: 2848
	public struct BabelTowerDeTermMutex : IFlatbufferObject
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06004ADD RID: 19165 RVA: 0x001DD20C File Offset: 0x001DB40C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x001DD219 File Offset: 0x001DB419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x001DD220 File Offset: 0x001DB420
		public static BabelTowerDeTermMutex GetRootAsBabelTowerDeTermMutex(ByteBuffer _bb)
		{
			return BabelTowerDeTermMutex.GetRootAsBabelTowerDeTermMutex(_bb, default(BabelTowerDeTermMutex));
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x001DD23C File Offset: 0x001DB43C
		public static BabelTowerDeTermMutex GetRootAsBabelTowerDeTermMutex(ByteBuffer _bb, BabelTowerDeTermMutex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x001DD259 File Offset: 0x001DB459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x001DD268 File Offset: 0x001DB468
		public BabelTowerDeTermMutex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x001DD278 File Offset: 0x001DB478
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

		// Token: 0x06004AE4 RID: 19172 RVA: 0x001DD2B4 File Offset: 0x001DB4B4
		public int MutexDeTermGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x001DD2F4 File Offset: 0x001DB4F4
		public int MutexDeTermGroupLength
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

		// Token: 0x06004AE6 RID: 19174 RVA: 0x001DD31F File Offset: 0x001DB51F
		public Span<int> GetMutexDeTermGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x001DD32E File Offset: 0x001DB52E
		public int[] GetMutexDeTermGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x001DD348 File Offset: 0x001DB548
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MutexDeTermGroupIter()或GetMutexDeTermGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MutexDeTermGroup()
		{
			BabelTowerDeTermMutex babelTowerDeTermMutex = this;
			return babelTowerDeTermMutex.GetMutexDeTermGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x001DD36C File Offset: 0x001DB56C
		[NullableContext(1)]
		public readonly IEnumerable<int> MutexDeTermGroupIter()
		{
			BabelTowerDeTermMutex.<MutexDeTermGroupIter>d__16 <MutexDeTermGroupIter>d__ = new BabelTowerDeTermMutex.<MutexDeTermGroupIter>d__16(-2);
			<MutexDeTermGroupIter>d__.<>3__<>4__this = this;
			return <MutexDeTermGroupIter>d__;
		}

		// Token: 0x04004B11 RID: 19217
		private Table __p;
	}
}
