using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB1 RID: 7857
	[NullableContext(1)]
	[Nullable(0)]
	public class IStandControl : ILeisureInteractType
	{
		// Token: 0x0600A812 RID: 43026 RVA: 0x0017B9AC File Offset: 0x00179BAC
		private IStandControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStandControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStandControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStandControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x0017B9E4 File Offset: 0x00179BE4
		public static IStandControl Create([Nullable(2)] IStandControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x0017B9F7 File Offset: 0x00179BF7
		public static IStandControl CreateFromSetValue([Nullable(2)] IStandControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStandControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x0017BA0A File Offset: 0x00179C0A
		public new IStandControl_SetValue ToSetValue()
		{
			return new IStandControl_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A816 RID: 43030 RVA: 0x0017BA1D File Offset: 0x00179C1D
		// (set) Token: 0x0600A817 RID: 43031 RVA: 0x0017BA48 File Offset: 0x00179C48
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

		// Token: 0x0400642C RID: 25644
		[Nullable(2)]
		protected new IStandControl FbInstance;

		// Token: 0x0400642D RID: 25645
		[Nullable(2)]
		protected new IStandControl_SetValue PocoInterface;
	}
}
