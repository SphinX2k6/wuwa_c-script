using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE7 RID: 7655
	public class IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600A285 RID: 41605 RVA: 0x00173DA4 File Offset: 0x00171FA4
		private IMonsterNpcInteractConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x00173DDC File Offset: 0x00171FDC
		public static IMonsterNpcInteractConfigBase Create([Nullable(2)] IMonsterNpcInteractConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x00173DEF File Offset: 0x00171FEF
		public static IMonsterNpcInteractConfigBase CreateFromSetValue([Nullable(2)] IMonsterNpcInteractConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x00173E02 File Offset: 0x00172002
		public IMonsterNpcInteractConfigBase_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x00173E15 File Offset: 0x00172015
		// (set) Token: 0x0600A28A RID: 41610 RVA: 0x00173E40 File Offset: 0x00172040
		public virtual EMonsterNpcInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractType.TriggerHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006285 RID: 25221
		[Nullable(2)]
		protected IMonsterNpcInteractConfigBase FbInstance;

		// Token: 0x04006286 RID: 25222
		[Nullable(2)]
		protected IMonsterNpcInteractConfigBase_SetValue PocoInterface;
	}
}
