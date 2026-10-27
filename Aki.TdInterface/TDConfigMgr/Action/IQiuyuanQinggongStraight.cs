using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D78 RID: 7544
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongStraight : ILeisureInteractType
	{
		// Token: 0x0600A1B1 RID: 41393 RVA: 0x001701F8 File Offset: 0x0016E3F8
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

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x00170230 File Offset: 0x0016E430
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

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x00170243 File Offset: 0x0016E443
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

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00170256 File Offset: 0x0016E456
		public new IQiuyuanQinggongStraight_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongStraight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A1B5 RID: 41397 RVA: 0x00170269 File Offset: 0x0016E469
		// (set) Token: 0x0600A1B6 RID: 41398 RVA: 0x00170294 File Offset: 0x0016E494
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

		// Token: 0x0400613C RID: 24892
		[Nullable(2)]
		protected new IQiuyuanQinggongStraight FbInstance;

		// Token: 0x0400613D RID: 24893
		[Nullable(2)]
		protected new IQiuyuanQinggongStraight_SetValue PocoInterface;
	}
}
