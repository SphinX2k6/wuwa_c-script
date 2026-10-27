using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E2 RID: 2274
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionItemComponent : IComponentBase
	{
		// Token: 0x06003391 RID: 13201 RVA: 0x00084110 File Offset: 0x00082310
		private VisionItemComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VisionItemComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VisionItemComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VisionItemComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00084148 File Offset: 0x00082348
		public static VisionItemComponent Create([Nullable(2)] VisionItemComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionItemComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0008415B File Offset: 0x0008235B
		public static VisionItemComponent CreateFromSetValue([Nullable(2)] VisionItemComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VisionItemComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0008416E File Offset: 0x0008236E
		public new VisionItemComponent_SetValue ToSetValue()
		{
			return new VisionItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x00084190 File Offset: 0x00082390
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x000841CA File Offset: 0x000823CA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				VisionItemComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06003397 RID: 13207 RVA: 0x000841D8 File Offset: 0x000823D8
		// (set) Token: 0x06003398 RID: 13208 RVA: 0x00084202 File Offset: 0x00082402
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x040021CA RID: 8650
		[Nullable(2)]
		protected new VisionItemComponent FbInstance;

		// Token: 0x040021CB RID: 8651
		[Nullable(2)]
		protected new VisionItemComponent_SetValue PocoInterface;
	}
}
