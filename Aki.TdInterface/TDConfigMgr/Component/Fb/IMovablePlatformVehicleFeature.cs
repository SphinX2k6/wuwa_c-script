using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E44 RID: 3652
	public class IMovablePlatformVehicleFeature : IVehicleFeature
	{
		// Token: 0x060052AA RID: 21162 RVA: 0x000CC4E0 File Offset: 0x000CA6E0
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

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x000CC4FF File Offset: 0x000CA6FF
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x000CC50C File Offset: 0x000CA70C
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

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x000CC570 File Offset: 0x000CA770
		public virtual int SafePointId
		{
			get
			{
				return this.Instance.SafePointId;
			}
		}

		// Token: 0x04002F35 RID: 12085
		private IMovablePlatformVehicleFeature Instance;

		// Token: 0x04002F36 RID: 12086
		private List<int> _PlayerAttachTagsCache;

		// Token: 0x04002F37 RID: 12087
		private bool _PlayerAttachTagsInited;
	}
}
