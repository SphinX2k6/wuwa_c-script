using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200122D RID: 4653
	public struct SurvivorsActivityConfig : IFlatbufferObject
	{
		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600E755 RID: 59221 RVA: 0x0034E20C File Offset: 0x0034C40C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x0034E219 File Offset: 0x0034C419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x0034E220 File Offset: 0x0034C420
		public static SurvivorsActivityConfig GetRootAsSurvivorsActivityConfig(ByteBuffer _bb)
		{
			return SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(_bb, default(SurvivorsActivityConfig));
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x0034E23C File Offset: 0x0034C43C
		public static SurvivorsActivityConfig GetRootAsSurvivorsActivityConfig(ByteBuffer _bb, SurvivorsActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x0034E259 File Offset: 0x0034C459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x0034E268 File Offset: 0x0034C468
		public SurvivorsActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600E75B RID: 59227 RVA: 0x0034E278 File Offset: 0x0034C478
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

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600E75C RID: 59228 RVA: 0x0034E2B4 File Offset: 0x0034C4B4
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

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600E75D RID: 59229 RVA: 0x0034E2F0 File Offset: 0x0034C4F0
		public int CurrencyItemId
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600E75E RID: 59230 RVA: 0x0034E32C File Offset: 0x0034C52C
		public int ScoreItemId
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

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600E75F RID: 59231 RVA: 0x0034E36C File Offset: 0x0034C56C
		public int TalentTreeItemId
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

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600E760 RID: 59232 RVA: 0x0034E3AC File Offset: 0x0034C5AC
		public int MaxTalentTreeItemCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600E761 RID: 59233 RVA: 0x0034E3F0 File Offset: 0x0034C5F0
		public int TaskDisplayItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E762 RID: 59234 RVA: 0x0034E430 File Offset: 0x0034C630
		public DicIntString? TaskType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600E763 RID: 59235 RVA: 0x0034E494 File Offset: 0x0034C694
		public int TaskTypeLength
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

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600E764 RID: 59236 RVA: 0x0034E4C0 File Offset: 0x0034C6C0
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x0034E500 File Offset: 0x0034C700
		public int AreaBoundLevelId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x0034E540 File Offset: 0x0034C740
		public int AreaBoundLevelIdLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E767 RID: 59239 RVA: 0x0034E56C File Offset: 0x0034C76C
		public Span<int> GetAreaBoundLevelIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x0034E57C File Offset: 0x0034C77C
		public int[] GetAreaBoundLevelIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x0034E594 File Offset: 0x0034C794
		[NullableContext(1)]
		public int[] AreaBoundLevelId()
		{
			return this.GetAreaBoundLevelIdArray();
		}

		// Token: 0x0600E76A RID: 59242 RVA: 0x0034E59C File Offset: 0x0034C79C
		[NullableContext(1)]
		public IEnumerable<int> AreaBoundLevelIdIter()
		{
			SurvivorsActivityConfig.<AreaBoundLevelIdIter>d__33 <AreaBoundLevelIdIter>d__ = new SurvivorsActivityConfig.<AreaBoundLevelIdIter>d__33(-2);
			<AreaBoundLevelIdIter>d__.<>3__<>4__this = this;
			return <AreaBoundLevelIdIter>d__;
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x0034E5B4 File Offset: 0x0034C7B4
		[NullableContext(1)]
		public Dictionary<int, string> TaskType()
		{
			return this.TaskTypeIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x0034E60A File Offset: 0x0034C80A
		[NullableContext(1)]
		public IEnumerable<DicIntString> TaskTypeIter()
		{
			SurvivorsActivityConfig.<TaskTypeIter>d__35 <TaskTypeIter>d__ = new SurvivorsActivityConfig.<TaskTypeIter>d__35(-2);
			<TaskTypeIter>d__.<>3__<>4__this = this;
			return <TaskTypeIter>d__;
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x0034E620 File Offset: 0x0034C820
		[NullableContext(2)]
		public string GetTaskType(int key)
		{
			this.EnsureTaskTypeCacheIfNeeded();
			string result;
			if (!this.TaskTypeCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x0034E648 File Offset: 0x0034C848
		private void EnsureTaskTypeCacheIfNeeded()
		{
			if (this.TaskTypeCache != null)
			{
				return;
			}
			this.TaskTypeCache = this.TaskTypeIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E76F RID: 59247 RVA: 0x0034E6AE File Offset: 0x0034C8AE
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTaskTypeFrozenDict()
		{
			this.EnsureTaskTypeCacheIfNeeded();
			return this.TaskTypeCache;
		}

		// Token: 0x0400586F RID: 22639
		private Table __p;

		// Token: 0x04005870 RID: 22640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TaskTypeCache;
	}
}
