using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDA RID: 7386
	[NullableContext(1)]
	[Nullable(0)]
	public class IPetalGrabConfig : ISportConfig
	{
		// Token: 0x06009E93 RID: 40595 RVA: 0x0016AA40 File Offset: 0x00168C40
		private IPetalGrabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x0016AA78 File Offset: 0x00168C78
		public static IPetalGrabConfig Create([Nullable(2)] IPetalGrabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x0016AA8B File Offset: 0x00168C8B
		public static IPetalGrabConfig CreateFromSetValue([Nullable(2)] IPetalGrabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x0016AA9E File Offset: 0x00168C9E
		public new IPetalGrabConfig_SetValue ToSetValue()
		{
			return new IPetalGrabConfig_SetValue
			{
				Type = this.Type,
				FirstGrabEntityId = this.FirstGrabEntityId
			};
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x06009E97 RID: 40599 RVA: 0x0016AABD File Offset: 0x00168CBD
		// (set) Token: 0x06009E98 RID: 40600 RVA: 0x0016AAE8 File Offset: 0x00168CE8
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

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x06009E99 RID: 40601 RVA: 0x0016AAF6 File Offset: 0x00168CF6
		// (set) Token: 0x06009E9A RID: 40602 RVA: 0x0016AB21 File Offset: 0x00168D21
		public virtual int FirstGrabEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FirstGrabEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FirstGrabEntityId;
			}
			set
			{
				this.GetOrCreatePoco().FirstGrabEntityId = value;
			}
		}

		// Token: 0x04005FD2 RID: 24530
		[Nullable(2)]
		protected new IPetalGrabConfig FbInstance;

		// Token: 0x04005FD3 RID: 24531
		[Nullable(2)]
		protected new IPetalGrabConfig_SetValue PocoInterface;
	}
}
