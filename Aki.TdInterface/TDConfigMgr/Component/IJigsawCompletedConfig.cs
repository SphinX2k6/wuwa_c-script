using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A4 RID: 1188
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawCompletedConfig
	{
		// Token: 0x060017EC RID: 6124 RVA: 0x00047E80 File Offset: 0x00046080
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

		// Token: 0x060017ED RID: 6125 RVA: 0x00047EB8 File Offset: 0x000460B8
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

		// Token: 0x060017EE RID: 6126 RVA: 0x00047ECB File Offset: 0x000460CB
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

		// Token: 0x060017EF RID: 6127 RVA: 0x00047EDE File Offset: 0x000460DE
		public IJigsawCompletedConfig_SetValue ToSetValue()
		{
			return new IJigsawCompletedConfig_SetValue
			{
				IsSilentPiece = this.IsSilentPiece,
				IsSilentFoundation = this.IsSilentFoundation
			};
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00047F00 File Offset: 0x00046100
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00047F3A File Offset: 0x0004613A
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

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00047F48 File Offset: 0x00046148
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00047F82 File Offset: 0x00046182
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

		// Token: 0x040011CD RID: 4557
		[Nullable(2)]
		protected IJigsawCompletedConfig FbInstance;

		// Token: 0x040011CE RID: 4558
		[Nullable(2)]
		protected IJigsawCompletedConfig_SetValue PocoInterface;
	}
}
