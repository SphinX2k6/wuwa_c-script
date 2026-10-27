using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF5 RID: 3317
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeStopComponent : IComponentBase
	{
		// Token: 0x06004BC8 RID: 19400 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
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

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x000BD2E4 File Offset: 0x000BB4E4
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

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x000BD31C File Offset: 0x000BB51C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x000BD332 File Offset: 0x000BB532
		public virtual string ActiveState
		{
			get
			{
				return this.Instance.ActiveState;
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x000BD33F File Offset: 0x000BB53F
		public virtual int StopTime
		{
			get
			{
				return this.Instance.StopTime;
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x000BD34C File Offset: 0x000BB54C
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

		// Token: 0x04002B56 RID: 11094
		private ITimeStopComponent Instance;

		// Token: 0x04002B57 RID: 11095
		[Nullable(2)]
		private ITimeStopTarget _TargetCache;

		// Token: 0x04002B58 RID: 11096
		private bool _TargetInited;
	}
}
