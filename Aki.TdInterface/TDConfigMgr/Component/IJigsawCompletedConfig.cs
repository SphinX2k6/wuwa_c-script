using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004FD RID: 1277
	public class IJigsawCompletedConfig
	{
		// Token: 0x06001986 RID: 6534 RVA: 0x0004BBC8 File Offset: 0x00049DC8
		private IJigsawCompletedConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawCompletedConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawCompletedConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawCompletedConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0004BC00 File Offset: 0x00049E00
		public static IJigsawCompletedConfig Create([Nullable(2)] IJigsawCompletedConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawCompletedConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0004BC13 File Offset: 0x00049E13
		public static IJigsawCompletedConfig CreateFromSetValue([Nullable(2)] IJigsawCompletedConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawCompletedConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0004BC26 File Offset: 0x00049E26
		public IJigsawCompletedConfig_SetValue ToSetValue()
		{
			return new IJigsawCompletedConfig_SetValue
			{
				IsSilentPiece = this.IsSilentPiece,
				IsSilentFoundation = this.IsSilentFoundation
			};
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0004BC48 File Offset: 0x00049E48
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0004BC82 File Offset: 0x00049E82
		public virtual bool? IsSilentPiece
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSilentPiece;
				}
				IJigsawCompletedConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSilentPiece;
			}
			set
			{
				this.GetOrCreatePoco().IsSilentPiece = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x0004BC90 File Offset: 0x00049E90
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0004BCCA File Offset: 0x00049ECA
		public virtual bool? IsSilentFoundation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSilentFoundation;
				}
				IJigsawCompletedConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSilentFoundation;
			}
			set
			{
				this.GetOrCreatePoco().IsSilentFoundation = value;
			}
		}

		// Token: 0x040012EF RID: 4847
		[Nullable(2)]
		protected IJigsawCompletedConfig FbInstance;

		// Token: 0x040012F0 RID: 4848
		[Nullable(2)]
		protected IJigsawCompletedConfig_SetValue PocoInterface;
	}
}
