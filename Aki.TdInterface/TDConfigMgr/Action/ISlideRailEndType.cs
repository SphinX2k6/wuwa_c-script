using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E87 RID: 7815
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlideRailEndType
	{
		// Token: 0x0600A736 RID: 42806 RVA: 0x0017A09C File Offset: 0x0017829C
		private ISlideRailEndType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideRailEndType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideRailEndType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideRailEndType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x0017A0D4 File Offset: 0x001782D4
		public static ISlideRailEndType Create([Nullable(2)] ISlideRailEndType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x0017A0E7 File Offset: 0x001782E7
		public static ISlideRailEndType CreateFromSetValue([Nullable(2)] ISlideRailEndType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x0017A0FA File Offset: 0x001782FA
		public ISlideRailEndType_SetValue ToSetValue()
		{
			return new ISlideRailEndType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A73A RID: 42810 RVA: 0x0017A10D File Offset: 0x0017830D
		// (set) Token: 0x0600A73B RID: 42811 RVA: 0x0017A138 File Offset: 0x00178338
		public virtual ESlideRailEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlideRailEndType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063C7 RID: 25543
		[Nullable(2)]
		protected ISlideRailEndType FbInstance;

		// Token: 0x040063C8 RID: 25544
		[Nullable(2)]
		protected ISlideRailEndType_SetValue PocoInterface;
	}
}
