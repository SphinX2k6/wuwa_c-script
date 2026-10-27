using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002843 RID: 10307
	[NullableContext(1)]
	[Nullable(0)]
	public class IProjectionMachine : IUiGame
	{
		// Token: 0x0600E480 RID: 58496 RVA: 0x0021A139 File Offset: 0x00218339
		public static IProjectionMachine Create(IProjectionMachine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectionMachine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x0600E481 RID: 58497 RVA: 0x0021A158 File Offset: 0x00218358
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x0600E482 RID: 58498 RVA: 0x0021A165 File Offset: 0x00218365
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x0600E483 RID: 58499 RVA: 0x0021A172 File Offset: 0x00218372
		public virtual string PhotoAsset
		{
			get
			{
				return this.Instance.PhotoAsset;
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x0600E484 RID: 58500 RVA: 0x0021A180 File Offset: 0x00218380
		public virtual bool? HideFixedPhoto
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideFixedPhoto);
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x0600E485 RID: 58501 RVA: 0x0021A1B6 File Offset: 0x002183B6
		[Nullable(2)]
		public virtual IProjectionMachinePhotoFilter PhotoFilter
		{
			[NullableContext(2)]
			get
			{
				if (this._PhotoFilterInited)
				{
					return this._PhotoFilterCache;
				}
				this._PhotoFilterInited = true;
				this._PhotoFilterCache = IProjectionMachinePhotoFilter.Create(this.Instance.PhotoFilter);
				return this._PhotoFilterCache;
			}
		}

		// Token: 0x04007E6B RID: 32363
		private IProjectionMachine Instance;

		// Token: 0x04007E6C RID: 32364
		[Nullable(2)]
		private IProjectionMachinePhotoFilter _PhotoFilterCache;

		// Token: 0x04007E6D RID: 32365
		private bool _PhotoFilterInited;
	}
}
