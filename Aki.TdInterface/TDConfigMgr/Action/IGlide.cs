using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD5 RID: 6869
	[NullableContext(1)]
	[Nullable(0)]
	public class IGlide : ILeisureInteractType
	{
		// Token: 0x0600933C RID: 37692 RVA: 0x00155CF0 File Offset: 0x00153EF0
		private IGlide_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGlide 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGlide_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGlide_SetValue());
			}
			return result;
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x00155D28 File Offset: 0x00153F28
		public static IGlide Create([Nullable(2)] IGlide instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGlide
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00155D3B File Offset: 0x00153F3B
		public static IGlide CreateFromSetValue([Nullable(2)] IGlide_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGlide
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x00155D4E File Offset: 0x00153F4E
		public new IGlide_SetValue ToSetValue()
		{
			return new IGlide_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x00155D61 File Offset: 0x00153F61
		// (set) Token: 0x06009341 RID: 37697 RVA: 0x00155D8C File Offset: 0x00153F8C
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

		// Token: 0x04005A85 RID: 23173
		[Nullable(2)]
		protected new IGlide FbInstance;

		// Token: 0x04005A86 RID: 23174
		[Nullable(2)]
		protected new IGlide_SetValue PocoInterface;
	}
}
