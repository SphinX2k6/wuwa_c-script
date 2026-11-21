using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002153 RID: 8531
	public class ITalkBackgroundIcon : ITalkBackground
	{
		// Token: 0x0600B50C RID: 46348 RVA: 0x0019563C File Offset: 0x0019383C
		private ITalkBackgroundIcon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundIcon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundIcon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundIcon_SetValue());
			}
			return result;
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x00195674 File Offset: 0x00193874
		public static ITalkBackgroundIcon Create([Nullable(2)] ITalkBackgroundIcon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundIcon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x00195687 File Offset: 0x00193887
		public static ITalkBackgroundIcon CreateFromSetValue([Nullable(2)] ITalkBackgroundIcon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundIcon
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x0019569A File Offset: 0x0019389A
		public new ITalkBackgroundIcon_SetValue ToSetValue()
		{
			return new ITalkBackgroundIcon_SetValue
			{
				Type = this.Type,
				ImageAsset = this.ImageAsset
			};
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600B510 RID: 46352 RVA: 0x001956B9 File Offset: 0x001938B9
		// (set) Token: 0x0600B511 RID: 46353 RVA: 0x001956E4 File Offset: 0x001938E4
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600B512 RID: 46354 RVA: 0x001956F2 File Offset: 0x001938F2
		// (set) Token: 0x0600B513 RID: 46355 RVA: 0x0019571D File Offset: 0x0019391D
		public virtual string ImageAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAsset;
			}
			set
			{
				this.GetOrCreatePoco().ImageAsset = value;
			}
		}

		// Token: 0x04006B13 RID: 27411
		[Nullable(2)]
		protected new ITalkBackgroundIcon FbInstance;

		// Token: 0x04006B14 RID: 27412
		[Nullable(2)]
		protected new ITalkBackgroundIcon_SetValue PocoInterface;
	}
}
