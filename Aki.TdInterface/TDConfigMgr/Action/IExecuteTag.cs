using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A21 RID: 6689
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecuteTag : IInteractEffect
	{
		// Token: 0x06008F46 RID: 36678 RVA: 0x0014EAE0 File Offset: 0x0014CCE0
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

		// Token: 0x06008F47 RID: 36679 RVA: 0x0014EB18 File Offset: 0x0014CD18
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

		// Token: 0x06008F48 RID: 36680 RVA: 0x0014EB2B File Offset: 0x0014CD2B
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

		// Token: 0x06008F49 RID: 36681 RVA: 0x0014EB3E File Offset: 0x0014CD3E
		public new IExecuteTag_SetValue ToSetValue()
		{
			return new IExecuteTag_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				Tags = this.Tags
			};
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x0014EB69 File Offset: 0x0014CD69
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x0014EB94 File Offset: 0x0014CD94
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

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x0014EBA4 File Offset: 0x0014CDA4
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x0014EBDE File Offset: 0x0014CDDE
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

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x0014EBEC File Offset: 0x0014CDEC
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x0014EC13 File Offset: 0x0014CE13
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

		// Token: 0x040058AC RID: 22700
		[Nullable(2)]
		protected new IExecuteTag FbInstance;

		// Token: 0x040058AD RID: 22701
		[Nullable(2)]
		protected new IExecuteTag_SetValue PocoInterface;
	}
}
