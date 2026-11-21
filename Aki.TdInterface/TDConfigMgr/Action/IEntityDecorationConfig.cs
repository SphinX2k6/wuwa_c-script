using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9F RID: 7071
	public class IEntityDecorationConfig
	{
		// Token: 0x06009639 RID: 38457 RVA: 0x0015DC14 File Offset: 0x0015BE14
		private IEntityDecorationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityDecorationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityDecorationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityDecorationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x0015DC4C File Offset: 0x0015BE4C
		public static IEntityDecorationConfig Create([Nullable(2)] IEntityDecorationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityDecorationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x0015DC5F File Offset: 0x0015BE5F
		public static IEntityDecorationConfig CreateFromSetValue([Nullable(2)] IEntityDecorationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityDecorationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x0015DC72 File Offset: 0x0015BE72
		public IEntityDecorationConfig_SetValue ToSetValue()
		{
			return new IEntityDecorationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600963D RID: 38461 RVA: 0x0015DC85 File Offset: 0x0015BE85
		// (set) Token: 0x0600963E RID: 38462 RVA: 0x0015DCB0 File Offset: 0x0015BEB0
		public virtual EEntityDecorationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityDecorationType.Add;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CD7 RID: 23767
		[Nullable(2)]
		protected IEntityDecorationConfig FbInstance;

		// Token: 0x04005CD8 RID: 23768
		[Nullable(2)]
		protected IEntityDecorationConfig_SetValue PocoInterface;
	}
}
