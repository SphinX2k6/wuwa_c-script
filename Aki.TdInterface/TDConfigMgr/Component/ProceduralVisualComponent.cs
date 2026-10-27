using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085B RID: 2139
	[NullableContext(1)]
	[Nullable(0)]
	public class ProceduralVisualComponent : IComponentBase
	{
		// Token: 0x06002F37 RID: 12087 RVA: 0x00079E40 File Offset: 0x00078040
		private ProceduralVisualComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ProceduralVisualComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ProceduralVisualComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ProceduralVisualComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00079E78 File Offset: 0x00078078
		public static ProceduralVisualComponent Create([Nullable(2)] ProceduralVisualComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProceduralVisualComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00079E8B File Offset: 0x0007808B
		public static ProceduralVisualComponent CreateFromSetValue([Nullable(2)] ProceduralVisualComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ProceduralVisualComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00079E9E File Offset: 0x0007809E
		public new ProceduralVisualComponent_SetValue ToSetValue()
		{
			return new ProceduralVisualComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Configs = this.Configs
			};
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x00079ECC File Offset: 0x000780CC
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00079F06 File Offset: 0x00078106
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ProceduralVisualComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x00079F14 File Offset: 0x00078114
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x00079F3E File Offset: 0x0007813E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x00079F4C File Offset: 0x0007814C
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x00079F73 File Offset: 0x00078173
		public virtual List<IProceduralVisualBase> Configs
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Configs;
				}
				ProceduralVisualComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Configs;
			}
			set
			{
				this.GetOrCreatePoco().Configs = value;
			}
		}

		// Token: 0x04001F2A RID: 7978
		[Nullable(2)]
		protected new ProceduralVisualComponent FbInstance;

		// Token: 0x04001F2B RID: 7979
		[Nullable(2)]
		protected new ProceduralVisualComponent_SetValue PocoInterface;
	}
}
