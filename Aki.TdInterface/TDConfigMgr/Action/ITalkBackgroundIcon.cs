using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F1A RID: 7962
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundIcon : ITalkBackground
	{
		// Token: 0x0600AA3A RID: 43578 RVA: 0x0017F644 File Offset: 0x0017D844
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

		// Token: 0x0600AA3B RID: 43579 RVA: 0x0017F67C File Offset: 0x0017D87C
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

		// Token: 0x0600AA3C RID: 43580 RVA: 0x0017F68F File Offset: 0x0017D88F
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

		// Token: 0x0600AA3D RID: 43581 RVA: 0x0017F6A2 File Offset: 0x0017D8A2
		public new ITalkBackgroundIcon_SetValue ToSetValue()
		{
			return new ITalkBackgroundIcon_SetValue
			{
				Type = this.Type,
				ImageAsset = this.ImageAsset
			};
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600AA3E RID: 43582 RVA: 0x0017F6C1 File Offset: 0x0017D8C1
		// (set) Token: 0x0600AA3F RID: 43583 RVA: 0x0017F6EC File Offset: 0x0017D8EC
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

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x0017F6FA File Offset: 0x0017D8FA
		// (set) Token: 0x0600AA41 RID: 43585 RVA: 0x0017F725 File Offset: 0x0017D925
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

		// Token: 0x04006524 RID: 25892
		[Nullable(2)]
		protected new ITalkBackgroundIcon FbInstance;

		// Token: 0x04006525 RID: 25893
		[Nullable(2)]
		protected new ITalkBackgroundIcon_SetValue PocoInterface;
	}
}
