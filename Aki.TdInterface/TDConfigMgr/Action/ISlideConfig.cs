using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BA RID: 8378
	public class ISlideConfig : ISportConfig
	{
		// Token: 0x0600B1E4 RID: 45540 RVA: 0x0018FC9C File Offset: 0x0018DE9C
		private ISlideConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x0018FCD4 File Offset: 0x0018DED4
		public static ISlideConfig Create([Nullable(2)] ISlideConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x0018FCE7 File Offset: 0x0018DEE7
		public static ISlideConfig CreateFromSetValue([Nullable(2)] ISlideConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x0018FCFA File Offset: 0x0018DEFA
		public new ISlideConfig_SetValue ToSetValue()
		{
			return new ISlideConfig_SetValue
			{
				Type = this.Type,
				SlideId = this.SlideId
			};
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600B1E8 RID: 45544 RVA: 0x0018FD19 File Offset: 0x0018DF19
		// (set) Token: 0x0600B1E9 RID: 45545 RVA: 0x0018FD44 File Offset: 0x0018DF44
		public override ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x0018FD52 File Offset: 0x0018DF52
		// (set) Token: 0x0600B1EB RID: 45547 RVA: 0x0018FD7D File Offset: 0x0018DF7D
		public virtual int SlideId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlideId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SlideId;
			}
			set
			{
				this.GetOrCreatePoco().SlideId = value;
			}
		}

		// Token: 0x040069A7 RID: 27047
		[Nullable(2)]
		protected new ISlideConfig FbInstance;

		// Token: 0x040069A8 RID: 27048
		[Nullable(2)]
		protected new ISlideConfig_SetValue PocoInterface;
	}
}
