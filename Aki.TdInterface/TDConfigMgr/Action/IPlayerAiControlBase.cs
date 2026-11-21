using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0D RID: 7949
	[JsonConverter(typeof(IPlayerAiControlBaseConverter))]
	public class IPlayerAiControlBase
	{
		// Token: 0x0600A937 RID: 43319 RVA: 0x001803F4 File Offset: 0x0017E5F4
		private IPlayerAiControlBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerAiControlBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerAiControlBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerAiControlBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x0018042C File Offset: 0x0017E62C
		public static IPlayerAiControlBase Create([Nullable(2)] IPlayerAiControlBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAiControlBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A939 RID: 43321 RVA: 0x0018043F File Offset: 0x0017E63F
		public static IPlayerAiControlBase CreateFromSetValue([Nullable(2)] IPlayerAiControlBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerAiControlBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x00180452 File Offset: 0x0017E652
		public IPlayerAiControlBase_SetValue ToSetValue()
		{
			return new IPlayerAiControlBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600A93B RID: 43323 RVA: 0x00180465 File Offset: 0x0017E665
		// (set) Token: 0x0600A93C RID: 43324 RVA: 0x00180490 File Offset: 0x0017E690
		public virtual EPlayerAiControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerAiControlType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065A7 RID: 26023
		[Nullable(2)]
		protected IPlayerAiControlBase FbInstance;

		// Token: 0x040065A8 RID: 26024
		[Nullable(2)]
		protected IPlayerAiControlBase_SetValue PocoInterface;
	}
}
