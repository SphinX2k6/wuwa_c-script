using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C2 RID: 2242
	public class JigsawItem : IComponentBase
	{
		// Token: 0x06003063 RID: 12387 RVA: 0x0007C600 File Offset: 0x0007A800
		private JigsawItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("JigsawItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			JigsawItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new JigsawItem_SetValue());
			}
			return result;
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0007C638 File Offset: 0x0007A838
		public static JigsawItem Create([Nullable(2)] JigsawItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new JigsawItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0007C64B File Offset: 0x0007A84B
		public static JigsawItem CreateFromSetValue([Nullable(2)] JigsawItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new JigsawItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0007C65E File Offset: 0x0007A85E
		public new JigsawItem_SetValue ToSetValue()
		{
			return new JigsawItem_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				FillCfg = this.FillCfg
			};
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x0007C68C File Offset: 0x0007A88C
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x0007C6C6 File Offset: 0x0007A8C6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				JigsawItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0007C6D4 File Offset: 0x0007A8D4
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x0007C6FE File Offset: 0x0007A8FE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x0007C70C File Offset: 0x0007A90C
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x0007C733 File Offset: 0x0007A933
		[Nullable(2)]
		public virtual IFillType FillCfg
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FillCfg;
				}
				JigsawItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FillCfg;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FillCfg = value;
			}
		}

		// Token: 0x04001FFA RID: 8186
		[Nullable(2)]
		protected new JigsawItem FbInstance;

		// Token: 0x04001FFB RID: 8187
		[Nullable(2)]
		protected new JigsawItem_SetValue PocoInterface;
	}
}
