using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC1 RID: 3009
	public struct AiBase : IFlatbufferObject
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06004B75 RID: 19317 RVA: 0x001F1A21 File Offset: 0x001EFC21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x001F1A2E File Offset: 0x001EFC2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x001F1A38 File Offset: 0x001EFC38
		public static AiBase GetRootAsAiBase(ByteBuffer _bb)
		{
			return AiBase.GetRootAsAiBase(_bb, default(AiBase));
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x001F1A54 File Offset: 0x001EFC54
		public static AiBase GetRootAsAiBase(ByteBuffer _bb, AiBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x001F1A71 File Offset: 0x001EFC71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x001F1A80 File Offset: 0x001EFC80
		public AiBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x001F1A90 File Offset: 0x001EFC90
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x001F1ACC File Offset: 0x001EFCCC
		public string StateMachine
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

		// Token: 0x06004B7D RID: 19325 RVA: 0x001F1B03 File Offset: 0x001EFD03
		public Span<byte> GetStateMachineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x001F1B12 File Offset: 0x001EFD12
		public byte[] GetStateMachineArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x001F1B2C File Offset: 0x001EFD2C
		public string AiController
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x001F1B63 File Offset: 0x001EFD63
		public Span<byte> GetAiControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x001F1B72 File Offset: 0x001EFD72
		public byte[] GetAiControllerArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x001F1B8C File Offset: 0x001EFD8C
		public string BehaviorTree
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
		public Span<byte> GetBehaviorTreeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x001F1BD4 File Offset: 0x001EFDD4
		public byte[] GetBehaviorTreeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x001F1BEC File Offset: 0x001EFDEC
		public DicStringString? SubBehaviorConfigs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x001F1C50 File Offset: 0x001EFE50
		public int SubBehaviorConfigsLength
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06004B87 RID: 19335 RVA: 0x001F1C7C File Offset: 0x001EFE7C
		public bool Team
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x001F1CBC File Offset: 0x001EFEBC
		public int MonsterType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 4;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x001F1CFC File Offset: 0x001EFEFC
		[NullableContext(1)]
		public Dictionary<string, string> SubBehaviorConfigs()
		{
			return this.SubBehaviorConfigsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x001F1D52 File Offset: 0x001EFF52
		[NullableContext(1)]
		public IEnumerable<DicStringString> SubBehaviorConfigsIter()
		{
			AiBase.<SubBehaviorConfigsIter>d__30 <SubBehaviorConfigsIter>d__ = new AiBase.<SubBehaviorConfigsIter>d__30(-2);
			<SubBehaviorConfigsIter>d__.<>3__<>4__this = this;
			return <SubBehaviorConfigsIter>d__;
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x001F1D68 File Offset: 0x001EFF68
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetSubBehaviorConfigs(string key)
		{
			this.EnsureSubBehaviorConfigsCacheIfNeeded();
			string result;
			if (!this.SubBehaviorConfigsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x001F1D90 File Offset: 0x001EFF90
		private void EnsureSubBehaviorConfigsCacheIfNeeded()
		{
			if (this.SubBehaviorConfigsCache != null)
			{
				return;
			}
			this.SubBehaviorConfigsCache = this.SubBehaviorConfigsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x001F1DF6 File Offset: 0x001EFFF6
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetSubBehaviorConfigsFrozenDict()
		{
			this.EnsureSubBehaviorConfigsCacheIfNeeded();
			return this.SubBehaviorConfigsCache;
		}

		// Token: 0x040050A1 RID: 20641
		private Table __p;

		// Token: 0x040050A2 RID: 20642
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> SubBehaviorConfigsCache;
	}
}
