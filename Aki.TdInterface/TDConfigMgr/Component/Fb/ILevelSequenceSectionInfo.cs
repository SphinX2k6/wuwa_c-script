using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7A RID: 3450
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelSequenceSectionInfo
	{
		// Token: 0x06004E7E RID: 20094 RVA: 0x000C2B56 File Offset: 0x000C0D56
		public static ILevelSequenceSectionInfo Create(ILevelSequenceSectionInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06004E7F RID: 20095 RVA: 0x000C2B75 File Offset: 0x000C0D75
		public virtual ELevelSequenceSectionType Type
		{
			get
			{
				return (ELevelSequenceSectionType)this.Instance.Type;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x000C2B82 File Offset: 0x000C0D82
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x000C2B8F File Offset: 0x000C0D8F
		public virtual int FrameId
		{
			get
			{
				return this.Instance.FrameId;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x000C2B9C File Offset: 0x000C0D9C
		[Nullable(2)]
		public virtual string State
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x000C2BAC File Offset: 0x000C0DAC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> LoopStates
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._LoopStatesInited)
				{
					return this._LoopStatesCache;
				}
				this._LoopStatesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int loopStatesLength = this.Instance.LoopStatesLength;
				this._LoopStatesCache = new List<string>(loopStatesLength);
				for (int i = 0; i < loopStatesLength; i++)
				{
					this._LoopStatesCache.Add(this.Instance.LoopStates(i));
				}
				return this._LoopStatesCache;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06004E84 RID: 20100 RVA: 0x000C2C24 File Offset: 0x000C0E24
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> ActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int actionListLength = this.Instance.ActionListLength;
				this._ActionListCache = new List<ActionInfo>(actionListLength);
				for (int i = 0; i < actionListLength; i++)
				{
					this._ActionListCache.Add(ActionInfo.Create(this.Instance.ActionList(i)));
				}
				return this._ActionListCache;
			}
		}

		// Token: 0x04002D0D RID: 11533
		private ILevelSequenceSectionInfo Instance;

		// Token: 0x04002D0E RID: 11534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _LoopStatesCache;

		// Token: 0x04002D0F RID: 11535
		private bool _LoopStatesInited;

		// Token: 0x04002D10 RID: 11536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionListCache;

		// Token: 0x04002D11 RID: 11537
		private bool _ActionListInited;
	}
}
