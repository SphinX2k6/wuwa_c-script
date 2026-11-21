using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BE RID: 10174
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkOptionVisualNovel : ITalkOptionParamType
	{
		// Token: 0x0600E120 RID: 57632 RVA: 0x00211916 File Offset: 0x0020FB16
		[NullableContext(0)]
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

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600E121 RID: 57633 RVA: 0x00211935 File Offset: 0x0020FB35
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600E122 RID: 57634 RVA: 0x00211944 File Offset: 0x0020FB44
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

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600E123 RID: 57635 RVA: 0x0021197A File Offset: 0x0020FB7A
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> OptionPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600E124 RID: 57636 RVA: 0x002119BA File Offset: 0x0020FBBA
		public virtual ITalkOptionVisualNovelDoubleConfirm DoubleConfirm
		{
			get
			{
				if (this._DoubleConfirmInited)
				{
					return this._DoubleConfirmCache;
				}
				this._DoubleConfirmInited = true;
				this._DoubleConfirmCache = ITalkOptionVisualNovelDoubleConfirm.Create(this.Instance.DoubleConfirm);
				return this._DoubleConfirmCache;
			}
		}

		// Token: 0x04007A5C RID: 31324
		private ITalkOptionVisualNovel Instance;

		// Token: 0x04007A5D RID: 31325
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IVisualNovelPerformanceBase> _OptionPerformancesCache;

		// Token: 0x04007A5E RID: 31326
		private bool _OptionPerformancesInited;

		// Token: 0x04007A5F RID: 31327
		private ITalkOptionVisualNovelDoubleConfirm _DoubleConfirmCache;

		// Token: 0x04007A60 RID: 31328
		private bool _DoubleConfirmInited;
	}
}
