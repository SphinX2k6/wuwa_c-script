using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DED RID: 3565
	public class TimeStopComponent : IComponentBase
	{
		// Token: 0x060050D6 RID: 20694 RVA: 0x000C87F4 File Offset: 0x000C69F4
		public static TimeStopComponent Create(ITimeStopComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeStopComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x000C8814 File Offset: 0x000C6A14
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x000C884C File Offset: 0x000C6A4C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060050D9 RID: 20697 RVA: 0x000C8862 File Offset: 0x000C6A62
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x000C886F File Offset: 0x000C6A6F
		public virtual int StopTime
		{
			get
			{
				return this.Instance.StopTime;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x060050DB RID: 20699 RVA: 0x000C887C File Offset: 0x000C6A7C
		public virtual ITimeStopTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ITimeStopTarget.Create(this.Instance.Target);
				return this._TargetCache;
			}
		}

		// Token: 0x04002E10 RID: 11792
		private ITimeStopComponent Instance;

		// Token: 0x04002E11 RID: 11793
		[Nullable(2)]
		private ITimeStopTarget _TargetCache;

		// Token: 0x04002E12 RID: 11794
		private bool _TargetInited;
	}
}
