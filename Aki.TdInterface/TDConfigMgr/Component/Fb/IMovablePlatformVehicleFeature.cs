using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4A RID: 3402
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovablePlatformVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D8E RID: 19854 RVA: 0x000C0D9C File Offset: 0x000BEF9C
		public static IMovablePlatformVehicleFeature Create(IMovablePlatformVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovablePlatformVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06004D8F RID: 19855 RVA: 0x000C0DBB File Offset: 0x000BEFBB
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x000C0DC8 File Offset: 0x000BEFC8
		public virtual List<int> PlayerAttachTags
		{
			get
			{
				if (this._PlayerAttachTagsInited)
				{
					return this._PlayerAttachTagsCache;
				}
				this._PlayerAttachTagsInited = true;
				int playerAttachTagsLength = this.Instance.PlayerAttachTagsLength;
				this._PlayerAttachTagsCache = new List<int>(playerAttachTagsLength);
				for (int i = 0; i < playerAttachTagsLength; i++)
				{
					this._PlayerAttachTagsCache.Add(this.Instance.PlayerAttachTags(i));
				}
				return this._PlayerAttachTagsCache;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06004D91 RID: 19857 RVA: 0x000C0E2C File Offset: 0x000BF02C
		public virtual int SafePointId
		{
			get
			{
				return this.Instance.SafePointId;
			}
		}

		// Token: 0x04002C75 RID: 11381
		private IMovablePlatformVehicleFeature Instance;

		// Token: 0x04002C76 RID: 11382
		private List<int> _PlayerAttachTagsCache;

		// Token: 0x04002C77 RID: 11383
		private bool _PlayerAttachTagsInited;
	}
}
