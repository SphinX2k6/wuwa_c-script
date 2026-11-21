using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108C RID: 4236
	public struct RecordConfig : IFlatbufferObject
	{
		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600C0A3 RID: 49315 RVA: 0x002F70DC File Offset: 0x002F52DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x002F70E9 File Offset: 0x002F52E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x002F70F0 File Offset: 0x002F52F0
		public static RecordConfig GetRootAsRecordConfig(ByteBuffer _bb)
		{
			return RecordConfig.GetRootAsRecordConfig(_bb, default(RecordConfig));
		}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x002F710C File Offset: 0x002F530C
		public static RecordConfig GetRootAsRecordConfig(ByteBuffer _bb, RecordConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x002F7129 File Offset: 0x002F5329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x002F7138 File Offset: 0x002F5338
		public RecordConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600C0A9 RID: 49321 RVA: 0x002F7148 File Offset: 0x002F5348
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

		// Token: 0x0600C0AA RID: 49322 RVA: 0x002F7184 File Offset: 0x002F5384
		public DicStringString? LimitParams(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600C0AB RID: 49323 RVA: 0x002F71E4 File Offset: 0x002F53E4
		public int LimitParamsLength
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

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x002F7210 File Offset: 0x002F5410
		public int ProgressNeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600C0AD RID: 49325 RVA: 0x002F724C File Offset: 0x002F544C
		public bool SaveRecord
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C0AE RID: 49326 RVA: 0x002F728C File Offset: 0x002F548C
		[NullableContext(1)]
		public Dictionary<string, string> LimitParams()
		{
			return this.LimitParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x002F72E2 File Offset: 0x002F54E2
		[NullableContext(1)]
		public IEnumerable<DicStringString> LimitParamsIter()
		{
			RecordConfig.<LimitParamsIter>d__18 <LimitParamsIter>d__ = new RecordConfig.<LimitParamsIter>d__18(-2);
			<LimitParamsIter>d__.<>3__<>4__this = this;
			return <LimitParamsIter>d__;
		}

		// Token: 0x0600C0B0 RID: 49328 RVA: 0x002F72F8 File Offset: 0x002F54F8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetLimitParams(string key)
		{
			this.EnsureLimitParamsCacheIfNeeded();
			string result;
			if (!this.LimitParamsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x002F7320 File Offset: 0x002F5520
		private void EnsureLimitParamsCacheIfNeeded()
		{
			if (this.LimitParamsCache != null)
			{
				return;
			}
			this.LimitParamsCache = this.LimitParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x002F7386 File Offset: 0x002F5586
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetLimitParamsFrozenDict()
		{
			this.EnsureLimitParamsCacheIfNeeded();
			return this.LimitParamsCache;
		}

		// Token: 0x04005664 RID: 22116
		private Table __p;

		// Token: 0x04005665 RID: 22117
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> LimitParamsCache;
	}
}
