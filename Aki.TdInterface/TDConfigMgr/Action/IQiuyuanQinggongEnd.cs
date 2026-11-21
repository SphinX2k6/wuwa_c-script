using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F7D RID: 8061
	public class IQiuyuanQinggongEnd : ILeisureInteractType
	{
		// Token: 0x0600AB6D RID: 43885 RVA: 0x001841B4 File Offset: 0x001823B4
		private IQiuyuanQinggongEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongEnd_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x001841EC File Offset: 0x001823EC
		public static IQiuyuanQinggongEnd Create([Nullable(2)] IQiuyuanQinggongEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x001841FF File Offset: 0x001823FF
		public static IQiuyuanQinggongEnd CreateFromSetValue([Nullable(2)] IQiuyuanQinggongEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x00184212 File Offset: 0x00182412
		public new IQiuyuanQinggongEnd_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x00184225 File Offset: 0x00182425
		// (set) Token: 0x0600AB72 RID: 43890 RVA: 0x00184250 File Offset: 0x00182450
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040066A6 RID: 26278
		[Nullable(2)]
		protected new IQiuyuanQinggongEnd FbInstance;

		// Token: 0x040066A7 RID: 26279
		[Nullable(2)]
		protected new IQiuyuanQinggongEnd_SetValue PocoInterface;
	}
}
