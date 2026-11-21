using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C2 RID: 8898
	public class IVisualNovelOptionGroupNormal : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600C1BA RID: 49594 RVA: 0x001BDA58 File Offset: 0x001BBC58
		private IVisualNovelOptionGroupNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelOptionGroupNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelOptionGroupNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelOptionGroupNormal_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x001BDA90 File Offset: 0x001BBC90
		public static IVisualNovelOptionGroupNormal Create([Nullable(2)] IVisualNovelOptionGroupNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1BC RID: 49596 RVA: 0x001BDAA3 File Offset: 0x001BBCA3
		public static IVisualNovelOptionGroupNormal CreateFromSetValue([Nullable(2)] IVisualNovelOptionGroupNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x001BDAB6 File Offset: 0x001BBCB6
		public new IVisualNovelOptionGroupNormal_SetValue ToSetValue()
		{
			return new IVisualNovelOptionGroupNormal_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x001BDAC9 File Offset: 0x001BBCC9
		// (set) Token: 0x0600C1BF RID: 49599 RVA: 0x001BDAF4 File Offset: 0x001BBCF4
		public override EVisualNovelOptionGroupType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelOptionGroupType.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040073AD RID: 29613
		[Nullable(2)]
		protected new IVisualNovelOptionGroupNormal FbInstance;

		// Token: 0x040073AE RID: 29614
		[Nullable(2)]
		protected new IVisualNovelOptionGroupNormal_SetValue PocoInterface;
	}
}
