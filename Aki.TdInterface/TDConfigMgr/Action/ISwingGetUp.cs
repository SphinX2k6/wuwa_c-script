using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002132 RID: 8498
	public class ISwingGetUp : ILeisureInteractType
	{
		// Token: 0x0600B464 RID: 46180 RVA: 0x00194434 File Offset: 0x00192634
		private ISwingGetUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwingGetUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwingGetUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwingGetUp_SetValue());
			}
			return result;
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x0019446C File Offset: 0x0019266C
		public static ISwingGetUp Create([Nullable(2)] ISwingGetUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x0019447F File Offset: 0x0019267F
		public static ISwingGetUp CreateFromSetValue([Nullable(2)] ISwingGetUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x00194492 File Offset: 0x00192692
		public new ISwingGetUp_SetValue ToSetValue()
		{
			return new ISwingGetUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x001944A5 File Offset: 0x001926A5
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x001944D0 File Offset: 0x001926D0
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

		// Token: 0x04006ACB RID: 27339
		[Nullable(2)]
		protected new ISwingGetUp FbInstance;

		// Token: 0x04006ACC RID: 27340
		[Nullable(2)]
		protected new ISwingGetUp_SetValue PocoInterface;
	}
}
