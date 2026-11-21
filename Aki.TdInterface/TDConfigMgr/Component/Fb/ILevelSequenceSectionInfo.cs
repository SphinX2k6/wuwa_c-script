using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E76 RID: 3702
	public class ILevelSequenceSectionInfo
	{
		// Token: 0x060053A3 RID: 21411 RVA: 0x000CE3A6 File Offset: 0x000CC5A6
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x000CE3C5 File Offset: 0x000CC5C5
		public virtual ELevelSequenceSectionType Type
		{
			get
			{
				return (ELevelSequenceSectionType)this.Instance.Type;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x000CE3D2 File Offset: 0x000CC5D2
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x000CE3DF File Offset: 0x000CC5DF
		public virtual int FrameId
		{
			get
			{
				return this.Instance.FrameId;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x000CE3EC File Offset: 0x000CC5EC
		[Nullable(2)]
		public virtual string State
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x000CE3FC File Offset: 0x000CC5FC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> LoopStates
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x000CE474 File Offset: 0x000CC674
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> ActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002FD3 RID: 12243
		private ILevelSequenceSectionInfo Instance;

		// Token: 0x04002FD4 RID: 12244
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _LoopStatesCache;

		// Token: 0x04002FD5 RID: 12245
		private bool _LoopStatesInited;

		// Token: 0x04002FD6 RID: 12246
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionListCache;

		// Token: 0x04002FD7 RID: 12247
		private bool _ActionListInited;
	}
}
