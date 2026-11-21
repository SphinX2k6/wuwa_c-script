using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6F RID: 7791
	public class INpcGroupSequenceStaticEntityBinding : INpcGroupSequenceBindingBase
	{
		// Token: 0x0600A59B RID: 42395 RVA: 0x00179A40 File Offset: 0x00177C40
		private INpcGroupSequenceStaticEntityBinding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequenceStaticEntityBinding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequenceStaticEntityBinding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequenceStaticEntityBinding_SetValue());
			}
			return result;
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x00179A78 File Offset: 0x00177C78
		public static INpcGroupSequenceStaticEntityBinding Create([Nullable(2)] INpcGroupSequenceStaticEntityBinding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceStaticEntityBinding
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x00179A8B File Offset: 0x00177C8B
		public static INpcGroupSequenceStaticEntityBinding CreateFromSetValue([Nullable(2)] INpcGroupSequenceStaticEntityBinding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequenceStaticEntityBinding
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x00179A9E File Offset: 0x00177C9E
		public new INpcGroupSequenceStaticEntityBinding_SetValue ToSetValue()
		{
			return new INpcGroupSequenceStaticEntityBinding_SetValue
			{
				Type = this.Type,
				Actors = this.Actors
			};
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A59F RID: 42399 RVA: 0x00179ABD File Offset: 0x00177CBD
		// (set) Token: 0x0600A5A0 RID: 42400 RVA: 0x00179AE8 File Offset: 0x00177CE8
		public override ENpcGroupSequenceBindingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupSequenceBindingType.StaticEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A5A1 RID: 42401 RVA: 0x00179AF6 File Offset: 0x00177CF6
		// (set) Token: 0x0600A5A2 RID: 42402 RVA: 0x00179B1D File Offset: 0x00177D1D
		public virtual List<int> Actors
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Actors;
				}
				INpcGroupSequenceStaticEntityBinding_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Actors;
			}
			set
			{
				this.GetOrCreatePoco().Actors = value;
			}
		}

		// Token: 0x040063FE RID: 25598
		[Nullable(2)]
		protected new INpcGroupSequenceStaticEntityBinding FbInstance;

		// Token: 0x040063FF RID: 25599
		[Nullable(2)]
		protected new INpcGroupSequenceStaticEntityBinding_SetValue PocoInterface;
	}
}
