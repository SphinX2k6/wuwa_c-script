using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017AB RID: 6059
	public class EnableHostility : ActionParams
	{
		// Token: 0x06008333 RID: 33587 RVA: 0x0013A120 File Offset: 0x00138320
		private EnableHostility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableHostility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableHostility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableHostility_SetValue());
			}
			return result;
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0013A158 File Offset: 0x00138358
		public static EnableHostility Create([Nullable(2)] EnableHostility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableHostility
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0013A16B File Offset: 0x0013836B
		public static EnableHostility CreateFromSetValue([Nullable(2)] EnableHostility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableHostility
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x0013A17E File Offset: 0x0013837E
		public EnableHostility_SetValue ToSetValue()
		{
			return new EnableHostility_SetValue
			{
				IsEnable = this.IsEnable,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x06008337 RID: 33591 RVA: 0x0013A19D File Offset: 0x0013839D
		// (set) Token: 0x06008338 RID: 33592 RVA: 0x0013A1C8 File Offset: 0x001383C8
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x06008339 RID: 33593 RVA: 0x0013A1D6 File Offset: 0x001383D6
		// (set) Token: 0x0600833A RID: 33594 RVA: 0x0013A1FD File Offset: 0x001383FD
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EnableHostility_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04005056 RID: 20566
		[Nullable(2)]
		protected new EnableHostility FbInstance;

		// Token: 0x04005057 RID: 20567
		[Nullable(2)]
		protected EnableHostility_SetValue PocoInterface;
	}
}
