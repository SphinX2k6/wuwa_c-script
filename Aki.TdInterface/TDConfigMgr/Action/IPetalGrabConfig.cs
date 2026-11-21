using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE3 RID: 7907
	public class IPetalGrabConfig : ISportConfig
	{
		// Token: 0x0600A849 RID: 43081 RVA: 0x0017E75C File Offset: 0x0017C95C
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

		// Token: 0x0600A84A RID: 43082 RVA: 0x0017E794 File Offset: 0x0017C994
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

		// Token: 0x0600A84B RID: 43083 RVA: 0x0017E7A7 File Offset: 0x0017C9A7
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

		// Token: 0x0600A84C RID: 43084 RVA: 0x0017E7BA File Offset: 0x0017C9BA
		public new IPetalGrabConfig_SetValue ToSetValue()
		{
			return new IPetalGrabConfig_SetValue
			{
				Type = this.Type,
				FirstGrabEntityId = this.FirstGrabEntityId
			};
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x0017E7D9 File Offset: 0x0017C9D9
		// (set) Token: 0x0600A84E RID: 43086 RVA: 0x0017E804 File Offset: 0x0017CA04
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

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600A84F RID: 43087 RVA: 0x0017E812 File Offset: 0x0017CA12
		// (set) Token: 0x0600A850 RID: 43088 RVA: 0x0017E83D File Offset: 0x0017CA3D
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

		// Token: 0x04006531 RID: 25905
		[Nullable(2)]
		protected new IPetalGrabConfig FbInstance;

		// Token: 0x04006532 RID: 25906
		[Nullable(2)]
		protected new IPetalGrabConfig_SetValue PocoInterface;
	}
}
