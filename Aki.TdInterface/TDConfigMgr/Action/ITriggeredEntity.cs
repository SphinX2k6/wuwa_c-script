using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFC RID: 8188
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggeredEntity : ITargetEntityType
	{
		// Token: 0x0600B414 RID: 46100 RVA: 0x001A2E88 File Offset: 0x001A1088
		private ITriggeredEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggeredEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggeredEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggeredEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x001A2EC0 File Offset: 0x001A10C0
		public static ITriggeredEntity Create([Nullable(2)] ITriggeredEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x001A2ED3 File Offset: 0x001A10D3
		public static ITriggeredEntity CreateFromSetValue([Nullable(2)] ITriggeredEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x001A2EE6 File Offset: 0x001A10E6
		public new ITriggeredEntity_SetValue ToSetValue()
		{
			return new ITriggeredEntity_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600B418 RID: 46104 RVA: 0x001A2EF9 File Offset: 0x001A10F9
		// (set) Token: 0x0600B419 RID: 46105 RVA: 0x001A2F24 File Offset: 0x001A1124
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C91 RID: 27793
		[Nullable(2)]
		protected new ITriggeredEntity FbInstance;

		// Token: 0x04006C92 RID: 27794
		[Nullable(2)]
		protected new ITriggeredEntity_SetValue PocoInterface;
	}
}
