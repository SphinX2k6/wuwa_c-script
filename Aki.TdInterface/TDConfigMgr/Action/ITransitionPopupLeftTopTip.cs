using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222F RID: 8751
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftTopTip : ITransitionPopupStyle
	{
		// Token: 0x0600BEC6 RID: 48838 RVA: 0x001B8900 File Offset: 0x001B6B00
		[NullableContext(0)]
		private ITransitionPopupLeftTopTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupLeftTopTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupLeftTopTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupLeftTopTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x001B8938 File Offset: 0x001B6B38
		[NullableContext(0)]
		public static ITransitionPopupLeftTopTip Create([Nullable(2)] ITransitionPopupLeftTopTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftTopTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x001B894B File Offset: 0x001B6B4B
		[NullableContext(0)]
		public static ITransitionPopupLeftTopTip CreateFromSetValue([Nullable(2)] ITransitionPopupLeftTopTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupLeftTopTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x001B895E File Offset: 0x001B6B5E
		[NullableContext(0)]
		public new ITransitionPopupLeftTopTip_SetValue ToSetValue()
		{
			return new ITransitionPopupLeftTopTip_SetValue
			{
				Type = this.Type,
				TitleText = this.TitleText,
				ContentText = this.ContentText
			};
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600BECA RID: 48842 RVA: 0x001B8989 File Offset: 0x001B6B89
		// (set) Token: 0x0600BECB RID: 48843 RVA: 0x001B89B4 File Offset: 0x001B6BB4
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

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600BECC RID: 48844 RVA: 0x001B89C2 File Offset: 0x001B6BC2
		// (set) Token: 0x0600BECD RID: 48845 RVA: 0x001B89E9 File Offset: 0x001B6BE9
		public virtual string TitleText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitleText;
				}
				ITransitionPopupLeftTopTip_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600BECE RID: 48846 RVA: 0x001B89F7 File Offset: 0x001B6BF7
		// (set) Token: 0x0600BECF RID: 48847 RVA: 0x001B8A1E File Offset: 0x001B6C1E
		public virtual string ContentText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ContentText;
				}
				ITransitionPopupLeftTopTip_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007265 RID: 29285
		protected new ITransitionPopupLeftTopTip FbInstance;

		// Token: 0x04007266 RID: 29286
		protected new ITransitionPopupLeftTopTip_SetValue PocoInterface;
	}
}
