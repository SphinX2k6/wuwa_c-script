using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB6 RID: 7094
	public class IExecuteTag : IInteractEffect
	{
		// Token: 0x060096B0 RID: 38576 RVA: 0x0015EA0C File Offset: 0x0015CC0C
		private IExecuteTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExecuteTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExecuteTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExecuteTag_SetValue());
			}
			return result;
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x0015EA44 File Offset: 0x0015CC44
		public static IExecuteTag Create([Nullable(2)] IExecuteTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecuteTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x0015EA57 File Offset: 0x0015CC57
		public static IExecuteTag CreateFromSetValue([Nullable(2)] IExecuteTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExecuteTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x0015EA6A File Offset: 0x0015CC6A
		public new IExecuteTag_SetValue ToSetValue()
		{
			return new IExecuteTag_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				Tags = this.Tags
			};
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x0015EA95 File Offset: 0x0015CC95
		// (set) Token: 0x060096B5 RID: 38581 RVA: 0x0015EAC0 File Offset: 0x0015CCC0
		public override EInteractEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x0015EAD0 File Offset: 0x0015CCD0
		// (set) Token: 0x060096B7 RID: 38583 RVA: 0x0015EB0A File Offset: 0x0015CD0A
		public override float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IExecuteTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0015EB18 File Offset: 0x0015CD18
		// (set) Token: 0x060096B9 RID: 38585 RVA: 0x0015EB3F File Offset: 0x0015CD3F
		public virtual List<int> Tags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tags;
				}
				IExecuteTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Tags;
			}
			set
			{
				this.GetOrCreatePoco().Tags = value;
			}
		}

		// Token: 0x04005D11 RID: 23825
		[Nullable(2)]
		protected new IExecuteTag FbInstance;

		// Token: 0x04005D12 RID: 23826
		[Nullable(2)]
		protected new IExecuteTag_SetValue PocoInterface;
	}
}
