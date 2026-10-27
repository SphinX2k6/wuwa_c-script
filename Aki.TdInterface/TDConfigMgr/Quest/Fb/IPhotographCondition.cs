using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001404 RID: 5124
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographCondition
	{
		// Token: 0x06007486 RID: 29830 RVA: 0x00116A9C File Offset: 0x00114C9C
		public static IPhotographCondition Create(IPhotographCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x00116ABB File Offset: 0x00114CBB
		public virtual string TidTip
		{
			get
			{
				return this.Instance.TidTip;
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x00116AC8 File Offset: 0x00114CC8
		public virtual IPhotographTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = QuestReadHelper.ReadIPhotographCondition_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06007489 RID: 29833 RVA: 0x00116AF7 File Offset: 0x00114CF7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPhotographSubTarget> SubTargets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._SubTargetsInited)
				{
					return this._SubTargetsCache;
				}
				this._SubTargetsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				this._SubTargetsCache = QuestReadHelper.ReadIPhotographCondition_SubTargets(this.Instance);
				return this._SubTargetsCache;
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x00116B37 File Offset: 0x00114D37
		[Nullable(2)]
		public virtual string EdTidTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400436C RID: 17260
		private IPhotographCondition Instance;

		// Token: 0x0400436D RID: 17261
		private IPhotographTarget _TargetCache;

		// Token: 0x0400436E RID: 17262
		private bool _TargetInited;

		// Token: 0x0400436F RID: 17263
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPhotographSubTarget> _SubTargetsCache;

		// Token: 0x04004370 RID: 17264
		private bool _SubTargetsInited;
	}
}
