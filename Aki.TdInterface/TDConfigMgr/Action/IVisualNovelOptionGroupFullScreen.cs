using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C0 RID: 8896
	public class IVisualNovelOptionGroupFullScreen : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600C1B2 RID: 49586 RVA: 0x001BD99C File Offset: 0x001BBB9C
		private IVisualNovelOptionGroupFullScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelOptionGroupFullScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelOptionGroupFullScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelOptionGroupFullScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x001BD9D4 File Offset: 0x001BBBD4
		public static IVisualNovelOptionGroupFullScreen Create([Nullable(2)] IVisualNovelOptionGroupFullScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupFullScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x001BD9E7 File Offset: 0x001BBBE7
		public static IVisualNovelOptionGroupFullScreen CreateFromSetValue([Nullable(2)] IVisualNovelOptionGroupFullScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupFullScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x001BD9FA File Offset: 0x001BBBFA
		public new IVisualNovelOptionGroupFullScreen_SetValue ToSetValue()
		{
			return new IVisualNovelOptionGroupFullScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600C1B6 RID: 49590 RVA: 0x001BDA0D File Offset: 0x001BBC0D
		// (set) Token: 0x0600C1B7 RID: 49591 RVA: 0x001BDA38 File Offset: 0x001BBC38
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

		// Token: 0x040073AA RID: 29610
		[Nullable(2)]
		protected new IVisualNovelOptionGroupFullScreen FbInstance;

		// Token: 0x040073AB RID: 29611
		[Nullable(2)]
		protected new IVisualNovelOptionGroupFullScreen_SetValue PocoInterface;
	}
}
