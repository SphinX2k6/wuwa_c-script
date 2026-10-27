using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AAD RID: 6829
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusOnCustomMapMark : IFocusOnMapMark
	{
		// Token: 0x06009278 RID: 37496 RVA: 0x00154850 File Offset: 0x00152A50
		private IFocusOnCustomMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusOnCustomMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusOnCustomMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusOnCustomMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x00154888 File Offset: 0x00152A88
		public static IFocusOnCustomMapMark Create([Nullable(2)] IFocusOnCustomMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x0015489B File Offset: 0x00152A9B
		public static IFocusOnCustomMapMark CreateFromSetValue([Nullable(2)] IFocusOnCustomMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x001548AE File Offset: 0x00152AAE
		public new IFocusOnCustomMapMark_SetValue ToSetValue()
		{
			return new IFocusOnCustomMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600927C RID: 37500 RVA: 0x001548CD File Offset: 0x00152ACD
		// (set) Token: 0x0600927D RID: 37501 RVA: 0x001548F8 File Offset: 0x00152AF8
		public override EMapMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkType.Custom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600927E RID: 37502 RVA: 0x00154906 File Offset: 0x00152B06
		// (set) Token: 0x0600927F RID: 37503 RVA: 0x00154931 File Offset: 0x00152B31
		public virtual int MarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MarkId;
			}
			set
			{
				this.GetOrCreatePoco().MarkId = value;
			}
		}

		// Token: 0x04005A31 RID: 23089
		[Nullable(2)]
		protected new IFocusOnCustomMapMark FbInstance;

		// Token: 0x04005A32 RID: 23090
		[Nullable(2)]
		protected new IFocusOnCustomMapMark_SetValue PocoInterface;
	}
}
