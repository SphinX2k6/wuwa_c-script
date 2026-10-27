using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002711 RID: 10001
	public class IUnlockPhotoMemoryCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600DF1D RID: 57117 RVA: 0x00211195 File Offset: 0x0020F395
		[NullableContext(1)]
		public static IUnlockPhotoMemoryCollectSystemItem Create(IUnlockPhotoMemoryCollectSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockPhotoMemoryCollectSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x002111B4 File Offset: 0x0020F3B4
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x002111C1 File Offset: 0x0020F3C1
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007BD1 RID: 31697
		private IUnlockPhotoMemoryCollectSystemItem Instance;
	}
}
