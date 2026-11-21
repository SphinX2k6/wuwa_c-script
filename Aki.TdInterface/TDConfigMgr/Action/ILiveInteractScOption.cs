using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D61 RID: 7521
	public class ILiveInteractScOption : ISystemOptionType
	{
		// Token: 0x06009FB1 RID: 40881 RVA: 0x0016E8D8 File Offset: 0x0016CAD8
		private ILiveInteractScOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractScOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractScOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractScOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x0016E910 File Offset: 0x0016CB10
		public static ILiveInteractScOption Create([Nullable(2)] ILiveInteractScOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractScOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x0016E923 File Offset: 0x0016CB23
		public static ILiveInteractScOption CreateFromSetValue([Nullable(2)] ILiveInteractScOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractScOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x0016E936 File Offset: 0x0016CB36
		public new ILiveInteractScOption_SetValue ToSetValue()
		{
			return new ILiveInteractScOption_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem,
				ScIds = this.ScIds
			};
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x0016E96D File Offset: 0x0016CB6D
		// (set) Token: 0x06009FB6 RID: 40886 RVA: 0x0016E998 File Offset: 0x0016CB98
		public override ESystemOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemOptionType.RogueRandomEvent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x0016E9A8 File Offset: 0x0016CBA8
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x0016EA3B File Offset: 0x0016CC3B
		public override List<ISystemOption> SystemOptions
		{
			get
			{
				if (this._SystemOptionsInited)
				{
					return this._SystemOptionsCache;
				}
				this._SystemOptionsInited = true;
				if (this.FbInstance != null)
				{
					List<ISystemOption> systemOptions = this.FbInstance.SystemOptions;
					if (systemOptions != null)
					{
						this._SystemOptionsCache = new List<ISystemOption>(systemOptions.Count);
						for (int i = 0; i < systemOptions.Count; i++)
						{
							this._SystemOptionsCache.Add(ISystemOption.Create(systemOptions[i]));
						}
					}
				}
				else
				{
					ILiveInteractScOption_SetValue pocoInterface = this.PocoInterface;
					this._SystemOptionsCache = ((pocoInterface != null) ? pocoInterface.SystemOptions : null);
				}
				return this._SystemOptionsCache;
			}
			set
			{
				this.GetOrCreatePoco().SystemOptions = value;
				this._SystemOptionsInited = false;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x0016EA50 File Offset: 0x0016CC50
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x0016EA8A File Offset: 0x0016CC8A
		public override bool? KeepPreTalkItem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPreTalkItem;
				}
				ILiveInteractScOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPreTalkItem;
			}
			set
			{
				this.GetOrCreatePoco().KeepPreTalkItem = value;
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x0016EA98 File Offset: 0x0016CC98
		// (set) Token: 0x06009FBC RID: 40892 RVA: 0x0016EABF File Offset: 0x0016CCBF
		public virtual List<int> ScIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScIds;
				}
				ILiveInteractScOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScIds;
			}
			set
			{
				this.GetOrCreatePoco().ScIds = value;
			}
		}

		// Token: 0x04006128 RID: 24872
		[Nullable(2)]
		protected new ILiveInteractScOption FbInstance;

		// Token: 0x04006129 RID: 24873
		[Nullable(2)]
		protected new ILiveInteractScOption_SetValue PocoInterface;

		// Token: 0x0400612A RID: 24874
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x0400612B RID: 24875
		private bool _SystemOptionsInited;
	}
}
