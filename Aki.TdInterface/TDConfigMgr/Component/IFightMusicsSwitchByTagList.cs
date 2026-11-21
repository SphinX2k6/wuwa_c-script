using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C5 RID: 965
	public class IFightMusicsSwitchByTagList : IFightMusicsSwitchType
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x0003E954 File Offset: 0x0003CB54
		private IFightMusicsSwitchByTagList_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFightMusicsSwitchByTagList 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFightMusicsSwitchByTagList_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFightMusicsSwitchByTagList_SetValue());
			}
			return result;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0003E98C File Offset: 0x0003CB8C
		public static IFightMusicsSwitchByTagList Create([Nullable(2)] IFightMusicsSwitchByTagList instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicsSwitchByTagList
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0003E99F File Offset: 0x0003CB9F
		public static IFightMusicsSwitchByTagList CreateFromSetValue([Nullable(2)] IFightMusicsSwitchByTagList_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFightMusicsSwitchByTagList
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0003E9B2 File Offset: 0x0003CBB2
		public new IFightMusicsSwitchByTagList_SetValue ToSetValue()
		{
			return new IFightMusicsSwitchByTagList_SetValue
			{
				Type = this.Type,
				Element = this.Element
			};
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0003E9D1 File Offset: 0x0003CBD1
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0003E9FC File Offset: 0x0003CBFC
		public override EFightMusicsSwitchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0003EA0C File Offset: 0x0003CC0C
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x0003EA9F File Offset: 0x0003CC9F
		public virtual List<IFightMusicSwitchByTag> Element
		{
			get
			{
				if (this._ElementInited)
				{
					return this._ElementCache;
				}
				this._ElementInited = true;
				if (this.FbInstance != null)
				{
					List<IFightMusicSwitchByTag> element = this.FbInstance.Element;
					if (element != null)
					{
						this._ElementCache = new List<IFightMusicSwitchByTag>(element.Count);
						for (int i = 0; i < element.Count; i++)
						{
							this._ElementCache.Add(IFightMusicSwitchByTag.Create(element[i]));
						}
					}
				}
				else
				{
					IFightMusicsSwitchByTagList_SetValue pocoInterface = this.PocoInterface;
					this._ElementCache = ((pocoInterface != null) ? pocoInterface.Element : null);
				}
				return this._ElementCache;
			}
			set
			{
				this.GetOrCreatePoco().Element = value;
				this._ElementInited = false;
			}
		}

		// Token: 0x04000F6C RID: 3948
		[Nullable(2)]
		protected new IFightMusicsSwitchByTagList FbInstance;

		// Token: 0x04000F6D RID: 3949
		[Nullable(2)]
		protected new IFightMusicsSwitchByTagList_SetValue PocoInterface;

		// Token: 0x04000F6E RID: 3950
		private List<IFightMusicSwitchByTag> _ElementCache;

		// Token: 0x04000F6F RID: 3951
		private bool _ElementInited;
	}
}
