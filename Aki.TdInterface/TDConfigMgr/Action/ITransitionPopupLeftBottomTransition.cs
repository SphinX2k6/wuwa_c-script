using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222D RID: 8749
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftBottomTransition : ITransitionPopupStyle
	{
		// Token: 0x0600BEBA RID: 48826 RVA: 0x001B87C4 File Offset: 0x001B69C4
		[NullableContext(0)]
		private ITransitionPopupLeftBottomTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupLeftBottomTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupLeftBottomTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupLeftBottomTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x001B87FC File Offset: 0x001B69FC
		[NullableContext(0)]
		public static ITransitionPopupLeftBottomTransition Create([Nullable(2)] ITransitionPopupLeftBottomTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftBottomTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x001B880F File Offset: 0x001B6A0F
		[NullableContext(0)]
		public static ITransitionPopupLeftBottomTransition CreateFromSetValue([Nullable(2)] ITransitionPopupLeftBottomTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupLeftBottomTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x001B8822 File Offset: 0x001B6A22
		[NullableContext(0)]
		public new ITransitionPopupLeftBottomTransition_SetValue ToSetValue()
		{
			return new ITransitionPopupLeftBottomTransition_SetValue
			{
				Type = this.Type,
				TitleText = this.TitleText,
				ContentText = this.ContentText
			};
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600BEBE RID: 48830 RVA: 0x001B884D File Offset: 0x001B6A4D
		// (set) Token: 0x0600BEBF RID: 48831 RVA: 0x001B8878 File Offset: 0x001B6A78
		public override ETransitionPopupStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600BEC0 RID: 48832 RVA: 0x001B8886 File Offset: 0x001B6A86
		// (set) Token: 0x0600BEC1 RID: 48833 RVA: 0x001B88AD File Offset: 0x001B6AAD
		public virtual string TitleText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitleText;
				}
				ITransitionPopupLeftBottomTransition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TitleText;
			}
			set
			{
				this.GetOrCreatePoco().TitleText = value;
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x001B88BB File Offset: 0x001B6ABB
		// (set) Token: 0x0600BEC3 RID: 48835 RVA: 0x001B88E2 File Offset: 0x001B6AE2
		public virtual string ContentText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ContentText;
				}
				ITransitionPopupLeftBottomTransition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ContentText;
			}
			set
			{
				this.GetOrCreatePoco().ContentText = value;
			}
		}

		// Token: 0x04007260 RID: 29280
		protected new ITransitionPopupLeftBottomTransition FbInstance;

		// Token: 0x04007261 RID: 29281
		protected new ITransitionPopupLeftBottomTransition_SetValue PocoInterface;
	}
}
