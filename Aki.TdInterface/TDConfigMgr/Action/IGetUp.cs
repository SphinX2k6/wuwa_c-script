using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7A RID: 7290
	public class IGetUp : ILeisureInteractType
	{
		// Token: 0x06009AF2 RID: 39666 RVA: 0x00166454 File Offset: 0x00164654
		private IGetUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGetUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGetUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGetUp_SetValue());
			}
			return result;
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x0016648C File Offset: 0x0016468C
		public static IGetUp Create([Nullable(2)] IGetUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x0016649F File Offset: 0x0016469F
		public static IGetUp CreateFromSetValue([Nullable(2)] IGetUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGetUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x001664B2 File Offset: 0x001646B2
		public new IGetUp_SetValue ToSetValue()
		{
			return new IGetUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x001664C5 File Offset: 0x001646C5
		// (set) Token: 0x06009AF7 RID: 39671 RVA: 0x001664F0 File Offset: 0x001646F0
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F0C RID: 24332
		[Nullable(2)]
		protected new IGetUp FbInstance;

		// Token: 0x04005F0D RID: 24333
		[Nullable(2)]
		protected new IGetUp_SetValue PocoInterface;
	}
}
