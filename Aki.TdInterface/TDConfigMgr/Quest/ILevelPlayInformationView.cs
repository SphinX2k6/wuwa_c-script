using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF1 RID: 4081
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayInformationView : IInformationViewType
	{
		// Token: 0x06005ACE RID: 23246 RVA: 0x000DC660 File Offset: 0x000DA860
		private ILevelPlayInformationView_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayInformationView 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayInformationView_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayInformationView_SetValue());
			}
			return result;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x000DC698 File Offset: 0x000DA898
		public static ILevelPlayInformationView Create([Nullable(2)] ILevelPlayInformationView instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayInformationView
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x000DC6AB File Offset: 0x000DA8AB
		public static ILevelPlayInformationView CreateFromSetValue([Nullable(2)] ILevelPlayInformationView_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayInformationView
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x000DC6BE File Offset: 0x000DA8BE
		public new ILevelPlayInformationView_SetValue ToSetValue()
		{
			return new ILevelPlayInformationView_SetValue
			{
				Type = this.Type,
				InformationConfig = this.InformationConfig
			};
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06005AD2 RID: 23250 RVA: 0x000DC6DD File Offset: 0x000DA8DD
		// (set) Token: 0x06005AD3 RID: 23251 RVA: 0x000DC708 File Offset: 0x000DA908
		public override EInformationViewType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationViewType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06005AD4 RID: 23252 RVA: 0x000DC718 File Offset: 0x000DA918
		// (set) Token: 0x06005AD5 RID: 23253 RVA: 0x000DC7AB File Offset: 0x000DA9AB
		public virtual List<ILevelPlayInformation> InformationConfig
		{
			get
			{
				if (this._InformationConfigInited)
				{
					return this._InformationConfigCache;
				}
				this._InformationConfigInited = true;
				if (this.FbInstance != null)
				{
					List<ILevelPlayInformation> informationConfig = this.FbInstance.InformationConfig;
					if (informationConfig != null)
					{
						this._InformationConfigCache = new List<ILevelPlayInformation>(informationConfig.Count);
						for (int i = 0; i < informationConfig.Count; i++)
						{
							this._InformationConfigCache.Add(ILevelPlayInformation.Create(informationConfig[i]));
						}
					}
				}
				else
				{
					ILevelPlayInformationView_SetValue pocoInterface = this.PocoInterface;
					this._InformationConfigCache = ((pocoInterface != null) ? pocoInterface.InformationConfig : null);
				}
				return this._InformationConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InformationConfig = value;
				this._InformationConfigInited = false;
			}
		}

		// Token: 0x040036A6 RID: 13990
		[Nullable(2)]
		protected new ILevelPlayInformationView FbInstance;

		// Token: 0x040036A7 RID: 13991
		[Nullable(2)]
		protected new ILevelPlayInformationView_SetValue PocoInterface;

		// Token: 0x040036A8 RID: 13992
		private List<ILevelPlayInformation> _InformationConfigCache;

		// Token: 0x040036A9 RID: 13993
		private bool _InformationConfigInited;
	}
}
