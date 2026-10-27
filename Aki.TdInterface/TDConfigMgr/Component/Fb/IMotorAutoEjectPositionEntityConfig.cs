using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B0D RID: 2829
	public class IMotorAutoEjectPositionEntityConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06004157 RID: 16727 RVA: 0x000A7CBF File Offset: 0x000A5EBF
		[NullableContext(1)]
		public static IMotorAutoEjectPositionEntityConfig Create(IMotorAutoEjectPositionEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectPositionEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x000A7CDE File Offset: 0x000A5EDE
		public override EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000A7CEB File Offset: 0x000A5EEB
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040024CE RID: 9422
		private IMotorAutoEjectPositionEntityConfig Instance;
	}
}
