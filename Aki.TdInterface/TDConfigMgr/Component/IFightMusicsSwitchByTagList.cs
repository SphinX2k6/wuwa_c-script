using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037C RID: 892
	[NullableContext(1)]
	[Nullable(0)]
	public class IFightMusicsSwitchByTagList : IFightMusicsSwitchType
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x0003B670 File Offset: 0x00039870
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

		// Token: 0x060011B6 RID: 4534 RVA: 0x0003B6A8 File Offset: 0x000398A8
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

		// Token: 0x060011B7 RID: 4535 RVA: 0x0003B6BB File Offset: 0x000398BB
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

		// Token: 0x060011B8 RID: 4536 RVA: 0x0003B6CE File Offset: 0x000398CE
		public new IFightMusicsSwitchByTagList_SetValue ToSetValue()
		{
			return new IFightMusicsSwitchByTagList_SetValue
			{
				Type = this.Type,
				Element = this.Element
			};
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0003B6ED File Offset: 0x000398ED
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0003B718 File Offset: 0x00039918
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0003B728 File Offset: 0x00039928
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0003B7BB File Offset: 0x000399BB
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

		// Token: 0x04000E75 RID: 3701
		[Nullable(2)]
		protected new IFightMusicsSwitchByTagList FbInstance;

		// Token: 0x04000E76 RID: 3702
		[Nullable(2)]
		protected new IFightMusicsSwitchByTagList_SetValue PocoInterface;

		// Token: 0x04000E77 RID: 3703
		private List<IFightMusicSwitchByTag> _ElementCache;

		// Token: 0x04000E78 RID: 3704
		private bool _ElementInited;
	}
}
