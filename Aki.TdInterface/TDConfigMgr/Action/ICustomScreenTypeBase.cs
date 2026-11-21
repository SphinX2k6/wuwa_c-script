using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE1 RID: 6881
	public class ICustomScreenTypeBase
	{
		// Token: 0x06009229 RID: 37417 RVA: 0x00156944 File Offset: 0x00154B44
		private ICustomScreenTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x0015697C File Offset: 0x00154B7C
		public static ICustomScreenTypeBase Create([Nullable(2)] ICustomScreenTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x0015698F File Offset: 0x00154B8F
		public static ICustomScreenTypeBase CreateFromSetValue([Nullable(2)] ICustomScreenTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x001569A2 File Offset: 0x00154BA2
		public ICustomScreenTypeBase_SetValue ToSetValue()
		{
			return new ICustomScreenTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x001569B5 File Offset: 0x00154BB5
		// (set) Token: 0x0600922E RID: 37422 RVA: 0x001569E0 File Offset: 0x00154BE0
		public virtual ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B14 RID: 23316
		[Nullable(2)]
		protected ICustomScreenTypeBase FbInstance;

		// Token: 0x04005B15 RID: 23317
		[Nullable(2)]
		protected ICustomScreenTypeBase_SetValue PocoInterface;
	}
}
