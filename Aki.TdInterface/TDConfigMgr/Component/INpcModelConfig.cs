using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C9 RID: 1481
	public class INpcModelConfig
	{
		// Token: 0x06001E38 RID: 7736 RVA: 0x00055C84 File Offset: 0x00053E84
		private INpcModelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcModelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcModelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcModelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00055CBC File Offset: 0x00053EBC
		public static INpcModelConfig Create([Nullable(2)] INpcModelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcModelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00055CCF File Offset: 0x00053ECF
		public static INpcModelConfig CreateFromSetValue([Nullable(2)] INpcModelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcModelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00055CE2 File Offset: 0x00053EE2
		public INpcModelConfig_SetValue ToSetValue()
		{
			return new INpcModelConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00055CF5 File Offset: 0x00053EF5
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00055D20 File Offset: 0x00053F20
		public virtual ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001598 RID: 5528
		[Nullable(2)]
		protected INpcModelConfig FbInstance;

		// Token: 0x04001599 RID: 5529
		[Nullable(2)]
		protected INpcModelConfig_SetValue PocoInterface;
	}
}
