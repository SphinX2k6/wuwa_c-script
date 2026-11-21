using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E57 RID: 3671
	public class IInhalationMatching
	{
		// Token: 0x06005310 RID: 21264 RVA: 0x000CD2C1 File Offset: 0x000CB4C1
		public static IInhalationMatching Create(IInhalationMatching? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationMatching
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x000CD2E0 File Offset: 0x000CB4E0
		public virtual int InhalationStrength
		{
			get
			{
				return this.Instance.InhalationStrength;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x000CD2ED File Offset: 0x000CB4ED
		public virtual ICategoryMatchingCondition EntityMatch
		{
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				this._EntityMatchCache = ICategoryMatchingCondition.Create(this.Instance.EntityMatch);
				return this._EntityMatchCache;
			}
		}

		// Token: 0x04002F70 RID: 12144
		private IInhalationMatching Instance;

		// Token: 0x04002F71 RID: 12145
		[Nullable(2)]
		private ICategoryMatchingCondition _EntityMatchCache;

		// Token: 0x04002F72 RID: 12146
		private bool _EntityMatchInited;
	}
}
