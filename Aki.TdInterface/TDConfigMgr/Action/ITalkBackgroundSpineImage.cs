using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F20 RID: 7968
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundSpineImage : ITalkBackground
	{
		// Token: 0x0600AA5A RID: 43610 RVA: 0x0017F988 File Offset: 0x0017DB88
		private ITalkBackgroundSpineImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundSpineImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundSpineImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundSpineImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x0017F9C0 File Offset: 0x0017DBC0
		public static ITalkBackgroundSpineImage Create([Nullable(2)] ITalkBackgroundSpineImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x0017F9D3 File Offset: 0x0017DBD3
		public static ITalkBackgroundSpineImage CreateFromSetValue([Nullable(2)] ITalkBackgroundSpineImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x0017F9E6 File Offset: 0x0017DBE6
		public new ITalkBackgroundSpineImage_SetValue ToSetValue()
		{
			return new ITalkBackgroundSpineImage_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				IsLoop = this.IsLoop
			};
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x0017FA11 File Offset: 0x0017DC11
		// (set) Token: 0x0600AA5F RID: 43615 RVA: 0x0017FA3C File Offset: 0x0017DC3C
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x0017FA4A File Offset: 0x0017DC4A
		// (set) Token: 0x0600AA61 RID: 43617 RVA: 0x0017FA75 File Offset: 0x0017DC75
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x0017FA84 File Offset: 0x0017DC84
		// (set) Token: 0x0600AA63 RID: 43619 RVA: 0x0017FABE File Offset: 0x0017DCBE
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				ITalkBackgroundSpineImage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x04006531 RID: 25905
		[Nullable(2)]
		protected new ITalkBackgroundSpineImage FbInstance;

		// Token: 0x04006532 RID: 25906
		[Nullable(2)]
		protected new ITalkBackgroundSpineImage_SetValue PocoInterface;
	}
}
