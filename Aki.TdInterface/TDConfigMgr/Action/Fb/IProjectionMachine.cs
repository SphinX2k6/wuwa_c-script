using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B16 RID: 11030
	public class IProjectionMachine : IUiGame
	{
		// Token: 0x0600F2A5 RID: 62117 RVA: 0x00236F9D File Offset: 0x0023519D
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

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x0600F2A6 RID: 62118 RVA: 0x00236FBC File Offset: 0x002351BC
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x0600F2A7 RID: 62119 RVA: 0x00236FC9 File Offset: 0x002351C9
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x0600F2A8 RID: 62120 RVA: 0x00236FD6 File Offset: 0x002351D6
		public virtual string PhotoAsset
		{
			get
			{
				return this.Instance.PhotoAsset;
			}
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x0600F2A9 RID: 62121 RVA: 0x00236FE4 File Offset: 0x002351E4
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

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x0600F2AA RID: 62122 RVA: 0x0023701A File Offset: 0x0023521A
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

		// Token: 0x04008528 RID: 34088
		private IProjectionMachine Instance;

		// Token: 0x04008529 RID: 34089
		[Nullable(2)]
		private IProjectionMachinePhotoFilter _PhotoFilterCache;

		// Token: 0x0400852A RID: 34090
		private bool _PhotoFilterInited;
	}
}
