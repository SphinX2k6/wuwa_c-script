using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD2 RID: 7378
	public class IICenterTextShowAll : ICenterTextShowType
	{
		// Token: 0x06009CA6 RID: 40102 RVA: 0x00169080 File Offset: 0x00167280
		private IICenterTextShowAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextShowAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextShowAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextShowAll_SetValue());
			}
			return result;
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x001690B8 File Offset: 0x001672B8
		public static IICenterTextShowAll Create([Nullable(2)] IICenterTextShowAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x001690CB File Offset: 0x001672CB
		public static IICenterTextShowAll CreateFromSetValue([Nullable(2)] IICenterTextShowAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x001690DE File Offset: 0x001672DE
		public new IICenterTextShowAll_SetValue ToSetValue()
		{
			return new IICenterTextShowAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x001690F1 File Offset: 0x001672F1
		// (set) Token: 0x06009CAB RID: 40107 RVA: 0x0016911C File Offset: 0x0016731C
		public override ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FBE RID: 24510
		[Nullable(2)]
		protected new IICenterTextShowAll FbInstance;

		// Token: 0x04005FBF RID: 24511
		[Nullable(2)]
		protected new IICenterTextShowAll_SetValue PocoInterface;
	}
}
