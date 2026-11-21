using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FE RID: 8958
	public class IVisualNovelTransitionLocation : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600C33C RID: 49980 RVA: 0x001C0AB8 File Offset: 0x001BECB8
		private IVisualNovelTransitionLocation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionLocation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionLocation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionLocation_SetValue());
			}
			return result;
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x001C0AF0 File Offset: 0x001BECF0
		public static IVisualNovelTransitionLocation Create([Nullable(2)] IVisualNovelTransitionLocation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x001C0B03 File Offset: 0x001BED03
		public static IVisualNovelTransitionLocation CreateFromSetValue([Nullable(2)] IVisualNovelTransitionLocation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x001C0B16 File Offset: 0x001BED16
		public new IVisualNovelTransitionLocation_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionLocation_SetValue
			{
				Type = this.Type,
				LocationId = this.LocationId,
				TransitionBackgroundId = this.TransitionBackgroundId
			};
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600C340 RID: 49984 RVA: 0x001C0B41 File Offset: 0x001BED41
		// (set) Token: 0x0600C341 RID: 49985 RVA: 0x001C0B6C File Offset: 0x001BED6C
		public override EVisualNovelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelTransitionType.Location;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600C342 RID: 49986 RVA: 0x001C0B7A File Offset: 0x001BED7A
		// (set) Token: 0x0600C343 RID: 49987 RVA: 0x001C0BA5 File Offset: 0x001BEDA5
		public virtual int LocationId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LocationId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LocationId;
			}
			set
			{
				this.GetOrCreatePoco().LocationId = value;
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600C344 RID: 49988 RVA: 0x001C0BB4 File Offset: 0x001BEDB4
		// (set) Token: 0x0600C345 RID: 49989 RVA: 0x001C0BEE File Offset: 0x001BEDEE
		public virtual int? TransitionBackgroundId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionBackgroundId;
				}
				IVisualNovelTransitionLocation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionBackgroundId;
			}
			set
			{
				this.GetOrCreatePoco().TransitionBackgroundId = value;
			}
		}

		// Token: 0x04007470 RID: 29808
		[Nullable(2)]
		protected new IVisualNovelTransitionLocation FbInstance;

		// Token: 0x04007471 RID: 29809
		[Nullable(2)]
		protected new IVisualNovelTransitionLocation_SetValue PocoInterface;
	}
}
