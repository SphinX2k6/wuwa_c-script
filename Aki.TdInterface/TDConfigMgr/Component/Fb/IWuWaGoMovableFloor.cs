using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E08 RID: 3592
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoMovableFloor : IWuWaGoEntityBase
	{
		// Token: 0x06005150 RID: 20816 RVA: 0x000C89AB File Offset: 0x000C6BAB
		public static IWuWaGoMovableFloor Create(IWuWaGoMovableFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoMovableFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x000C89CA File Offset: 0x000C6BCA
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x000C89D7 File Offset: 0x000C6BD7
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				this._LinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.LinkData);
				return this._LinkDataCache;
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x000C8A0B File Offset: 0x000C6C0B
		[Nullable(2)]
		public virtual IWuWaGoGridLinkData GearLinkData
		{
			[NullableContext(2)]
			get
			{
				if (this._GearLinkDataInited)
				{
					return this._GearLinkDataCache;
				}
				this._GearLinkDataInited = true;
				this._GearLinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.GearLinkData);
				return this._GearLinkDataCache;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x000C8A40 File Offset: 0x000C6C40
		public virtual List<IWuWaGoMovableGridStatePos> MoveData
		{
			get
			{
				if (this._MoveDataInited)
				{
					return this._MoveDataCache;
				}
				this._MoveDataInited = true;
				int moveDataLength = this.Instance.MoveDataLength;
				this._MoveDataCache = new List<IWuWaGoMovableGridStatePos>(moveDataLength);
				for (int i = 0; i < moveDataLength; i++)
				{
					this._MoveDataCache.Add(IWuWaGoMovableGridStatePos.Create(this.Instance.MoveData(i)));
				}
				return this._MoveDataCache;
			}
		}

		// Token: 0x04002ECB RID: 11979
		private IWuWaGoMovableFloor Instance;

		// Token: 0x04002ECC RID: 11980
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002ECD RID: 11981
		private bool _LinkDataInited;

		// Token: 0x04002ECE RID: 11982
		[Nullable(2)]
		private IWuWaGoGridLinkData _GearLinkDataCache;

		// Token: 0x04002ECF RID: 11983
		private bool _GearLinkDataInited;

		// Token: 0x04002ED0 RID: 11984
		private List<IWuWaGoMovableGridStatePos> _MoveDataCache;

		// Token: 0x04002ED1 RID: 11985
		private bool _MoveDataInited;
	}
}
