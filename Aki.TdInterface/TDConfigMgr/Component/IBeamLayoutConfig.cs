using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200021A RID: 538
	public class IBeamLayoutConfig
	{
		// Token: 0x0600089E RID: 2206 RVA: 0x00027CD4 File Offset: 0x00025ED4
		private IBeamLayoutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBeamLayoutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBeamLayoutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBeamLayoutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00027D0C File Offset: 0x00025F0C
		public static IBeamLayoutConfig Create([Nullable(2)] IBeamLayoutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00027D1F File Offset: 0x00025F1F
		public static IBeamLayoutConfig CreateFromSetValue([Nullable(2)] IBeamLayoutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00027D32 File Offset: 0x00025F32
		public IBeamLayoutConfig_SetValue ToSetValue()
		{
			return new IBeamLayoutConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00027D45 File Offset: 0x00025F45
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00027D70 File Offset: 0x00025F70
		public virtual EBeamLayoutType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBeamLayoutType.BeamWall;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400098C RID: 2444
		[Nullable(2)]
		protected IBeamLayoutConfig FbInstance;

		// Token: 0x0400098D RID: 2445
		[Nullable(2)]
		protected IBeamLayoutConfig_SetValue PocoInterface;
	}
}
