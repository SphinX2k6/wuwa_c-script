using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C36 RID: 7222
	public class IFlowTemplateInitialLookAt
	{
		// Token: 0x060099A2 RID: 39330 RVA: 0x0016403C File Offset: 0x0016223C
		private IFlowTemplateInitialLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTemplateInitialLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTemplateInitialLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTemplateInitialLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00164074 File Offset: 0x00162274
		public static IFlowTemplateInitialLookAt Create([Nullable(2)] IFlowTemplateInitialLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00164087 File Offset: 0x00162287
		public static IFlowTemplateInitialLookAt CreateFromSetValue([Nullable(2)] IFlowTemplateInitialLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x0016409A File Offset: 0x0016229A
		public IFlowTemplateInitialLookAt_SetValue ToSetValue()
		{
			return new IFlowTemplateInitialLookAt_SetValue
			{
				ActorIndex = this.ActorIndex,
				Target = this.Target
			};
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x001640B9 File Offset: 0x001622B9
		// (set) Token: 0x060099A7 RID: 39335 RVA: 0x001640E4 File Offset: 0x001622E4
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x001640F2 File Offset: 0x001622F2
		// (set) Token: 0x060099A9 RID: 39337 RVA: 0x00164119 File Offset: 0x00162319
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IFlowTemplateInitialLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x04005E76 RID: 24182
		[Nullable(2)]
		protected IFlowTemplateInitialLookAt FbInstance;

		// Token: 0x04005E77 RID: 24183
		[Nullable(2)]
		protected IFlowTemplateInitialLookAt_SetValue PocoInterface;
	}
}
