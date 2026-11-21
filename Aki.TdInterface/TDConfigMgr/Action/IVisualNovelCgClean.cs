using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AA RID: 8874
	public class IVisualNovelCgClean : IVisualNovelCgBase
	{
		// Token: 0x0600C140 RID: 49472 RVA: 0x001BCD68 File Offset: 0x001BAF68
		private IVisualNovelCgClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x001BCDA0 File Offset: 0x001BAFA0
		public static IVisualNovelCgClean Create([Nullable(2)] IVisualNovelCgClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x001BCDB3 File Offset: 0x001BAFB3
		public static IVisualNovelCgClean CreateFromSetValue([Nullable(2)] IVisualNovelCgClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x001BCDC6 File Offset: 0x001BAFC6
		public new IVisualNovelCgClean_SetValue ToSetValue()
		{
			return new IVisualNovelCgClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600C144 RID: 49476 RVA: 0x001BCDD9 File Offset: 0x001BAFD9
		// (set) Token: 0x0600C145 RID: 49477 RVA: 0x001BCE04 File Offset: 0x001BB004
		public override EVisualNovelCgType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400737A RID: 29562
		[Nullable(2)]
		protected new IVisualNovelCgClean FbInstance;

		// Token: 0x0400737B RID: 29563
		[Nullable(2)]
		protected new IVisualNovelCgClean_SetValue PocoInterface;
	}
}
