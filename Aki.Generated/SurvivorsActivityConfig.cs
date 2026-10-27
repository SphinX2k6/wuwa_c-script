using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F7 RID: 4343
	public struct SurvivorsActivityConfig : IFlatbufferObject
	{
		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x00322D40 File Offset: 0x00320F40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x00322D4D File Offset: 0x00320F4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x00322D54 File Offset: 0x00320F54
		public static SurvivorsActivityConfig GetRootAsSurvivorsActivityConfig(ByteBuffer _bb)
		{
			return SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(_bb, default(SurvivorsActivityConfig));
		}

		// Token: 0x0600DA0D RID: 55821 RVA: 0x00322D70 File Offset: 0x00320F70
		public static SurvivorsActivityConfig GetRootAsSurvivorsActivityConfig(ByteBuffer _bb, SurvivorsActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA0E RID: 55822 RVA: 0x00322D8D File Offset: 0x00320F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x00322D9C File Offset: 0x00320F9C
		public SurvivorsActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600DA10 RID: 55824 RVA: 0x00322DAC File Offset: 0x00320FAC
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

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x00322DE8 File Offset: 0x00320FE8
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

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x00322E24 File Offset: 0x00321024
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

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x00322E60 File Offset: 0x00321060
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

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x00322EA0 File Offset: 0x003210A0
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

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600DA15 RID: 55829 RVA: 0x00322EE0 File Offset: 0x003210E0
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

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x00322F24 File Offset: 0x00321124
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

		// Token: 0x0600DA17 RID: 55831 RVA: 0x00322F64 File Offset: 0x00321164
		public DicIntString? TaskType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600DA18 RID: 55832 RVA: 0x00322FC8 File Offset: 0x003211C8
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

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600DA19 RID: 55833 RVA: 0x00322FF4 File Offset: 0x003211F4
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

		// Token: 0x0600DA1A RID: 55834 RVA: 0x00323034 File Offset: 0x00321234
		public int AreaBoundLevelId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x00323074 File Offset: 0x00321274
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

		// Token: 0x0600DA1C RID: 55836 RVA: 0x003230A0 File Offset: 0x003212A0
		public Span<int> GetAreaBoundLevelIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x003230B0 File Offset: 0x003212B0
		public int[] GetAreaBoundLevelIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA1E RID: 55838 RVA: 0x003230C8 File Offset: 0x003212C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaBoundLevelIdIter()或GetAreaBoundLevelIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaBoundLevelId()
		{
			SurvivorsActivityConfig survivorsActivityConfig = this;
			return survivorsActivityConfig.GetAreaBoundLevelIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DA1F RID: 55839 RVA: 0x003230EC File Offset: 0x003212EC
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaBoundLevelIdIter()
		{
			SurvivorsActivityConfig.<AreaBoundLevelIdIter>d__33 <AreaBoundLevelIdIter>d__ = new SurvivorsActivityConfig.<AreaBoundLevelIdIter>d__33(-2);
			<AreaBoundLevelIdIter>d__.<>3__<>4__this = this;
			return <AreaBoundLevelIdIter>d__;
		}

		// Token: 0x0600DA20 RID: 55840 RVA: 0x00323104 File Offset: 0x00321304
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskTypeFrozenDict()缓存字典，遍历请使用TaskTypeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TaskType()
		{
			return this.TaskTypeIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600DA21 RID: 55841 RVA: 0x0032315A File Offset: 0x0032135A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TaskTypeIter()
		{
			SurvivorsActivityConfig.<TaskTypeIter>d__35 <TaskTypeIter>d__ = new SurvivorsActivityConfig.<TaskTypeIter>d__35(-2);
			<TaskTypeIter>d__.<>3__<>4__this = this;
			return <TaskTypeIter>d__;
		}

		// Token: 0x0600DA22 RID: 55842 RVA: 0x00323170 File Offset: 0x00321370
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

		// Token: 0x0600DA23 RID: 55843 RVA: 0x00323198 File Offset: 0x00321398
		private void EnsureTaskTypeCacheIfNeeded()
		{
			if (this.TaskTypeCache != null)
			{
				return;
			}
			this.TaskTypeCache = this.TaskTypeIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x003231FE File Offset: 0x003213FE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTaskTypeFrozenDict(int key)
		{
			this.EnsureTaskTypeCacheIfNeeded();
			return this.TaskTypeCache;
		}

		// Token: 0x0400522C RID: 21036
		private Table __p;

		// Token: 0x0400522D RID: 21037
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TaskTypeCache;
	}
}
