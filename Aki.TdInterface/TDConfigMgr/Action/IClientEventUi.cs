using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B2 RID: 6322
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventUi
	{
		// Token: 0x060087AF RID: 34735 RVA: 0x001417D0 File Offset: 0x0013F9D0
		private IClientEventUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventUi_SetValue());
			}
			return result;
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00141808 File Offset: 0x0013FA08
		public static IClientEventUi Create([Nullable(2)] IClientEventUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x0014181B File Offset: 0x0013FA1B
		public static IClientEventUi CreateFromSetValue([Nullable(2)] IClientEventUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x0014182E File Offset: 0x0013FA2E
		public IClientEventUi_SetValue ToSetValue()
		{
			return new IClientEventUi_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x060087B3 RID: 34739 RVA: 0x00141841 File Offset: 0x0013FA41
		// (set) Token: 0x060087B4 RID: 34740 RVA: 0x0014186C File Offset: 0x0013FA6C
		public virtual EClientEventUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventUiType.PlayPiano;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400555A RID: 21850
		[Nullable(2)]
		protected IClientEventUi FbInstance;

		// Token: 0x0400555B RID: 21851
		[Nullable(2)]
		protected IClientEventUi_SetValue PocoInterface;
	}
}
