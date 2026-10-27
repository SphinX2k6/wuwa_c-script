using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002518 RID: 9496
	public class ITalkOptionVisualNovel : ITalkOptionParamType
	{
		// Token: 0x0600D3C4 RID: 54212 RVA: 0x001F5F1E File Offset: 0x001F411E
		[NullableContext(1)]
		public static ITalkOptionVisualNovel Create(ITalkOptionVisualNovel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600D3C5 RID: 54213 RVA: 0x001F5F3D File Offset: 0x001F413D
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600D3C6 RID: 54214 RVA: 0x001F5F4C File Offset: 0x001F414C
		public virtual int? PlotOptionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PlotOptionId);
			}
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600D3C7 RID: 54215 RVA: 0x001F5F82 File Offset: 0x001F4182
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> OptionPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OptionPerformancesInited)
				{
					return this._OptionPerformancesCache;
				}
				this._OptionPerformancesInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				this._OptionPerformancesCache = ActionReadHelper.ReadITalkOptionVisualNovel_OptionPerformances(this.Instance);
				return this._OptionPerformancesCache;
			}
		}

		// Token: 0x0400740A RID: 29706
		private ITalkOptionVisualNovel Instance;

		// Token: 0x0400740B RID: 29707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IVisualNovelPerformanceBase> _OptionPerformancesCache;

		// Token: 0x0400740C RID: 29708
		private bool _OptionPerformancesInited;
	}
}
