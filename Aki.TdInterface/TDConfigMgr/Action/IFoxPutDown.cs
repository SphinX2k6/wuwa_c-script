using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABD RID: 6845
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxPutDown : ILeisureInteractType
	{
		// Token: 0x060092CC RID: 37580 RVA: 0x00155144 File Offset: 0x00153344
		private IFoxPutDown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPutDown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPutDown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPutDown_SetValue());
			}
			return result;
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x0015517C File Offset: 0x0015337C
		public static IFoxPutDown Create([Nullable(2)] IFoxPutDown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x0015518F File Offset: 0x0015338F
		public static IFoxPutDown CreateFromSetValue([Nullable(2)] IFoxPutDown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x001551A2 File Offset: 0x001533A2
		public new IFoxPutDown_SetValue ToSetValue()
		{
			return new IFoxPutDown_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x001551B5 File Offset: 0x001533B5
		// (set) Token: 0x060092D1 RID: 37585 RVA: 0x001551E0 File Offset: 0x001533E0
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

		// Token: 0x04005A55 RID: 23125
		[Nullable(2)]
		protected new IFoxPutDown FbInstance;

		// Token: 0x04005A56 RID: 23126
		[Nullable(2)]
		protected new IFoxPutDown_SetValue PocoInterface;
	}
}
