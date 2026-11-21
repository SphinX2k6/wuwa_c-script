using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F89 RID: 8073
	public class IQiuyuanQinggongStraight : ILeisureInteractType
	{
		// Token: 0x0600AB9D RID: 43933 RVA: 0x0018461C File Offset: 0x0018281C
		private IQiuyuanQinggongStraight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongStraight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongStraight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongStraight_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x00184654 File Offset: 0x00182854
		public static IQiuyuanQinggongStraight Create([Nullable(2)] IQiuyuanQinggongStraight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongStraight
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x00184667 File Offset: 0x00182867
		public static IQiuyuanQinggongStraight CreateFromSetValue([Nullable(2)] IQiuyuanQinggongStraight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongStraight
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x0018467A File Offset: 0x0018287A
		public new IQiuyuanQinggongStraight_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongStraight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x0018468D File Offset: 0x0018288D
		// (set) Token: 0x0600ABA2 RID: 43938 RVA: 0x001846B8 File Offset: 0x001828B8
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

		// Token: 0x040066B8 RID: 26296
		[Nullable(2)]
		protected new IQiuyuanQinggongStraight FbInstance;

		// Token: 0x040066B9 RID: 26297
		[Nullable(2)]
		protected new IQiuyuanQinggongStraight_SetValue PocoInterface;
	}
}
