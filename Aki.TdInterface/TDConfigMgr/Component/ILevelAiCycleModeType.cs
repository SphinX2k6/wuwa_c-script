using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B6 RID: 1206
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAiCycleModeType
	{
		// Token: 0x06001858 RID: 6232 RVA: 0x00048DF4 File Offset: 0x00046FF4
		private ILevelAiCycleModeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAiCycleModeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAiCycleModeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAiCycleModeType_SetValue());
			}
			return result;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00048E2C File Offset: 0x0004702C
		public static ILevelAiCycleModeType Create([Nullable(2)] ILevelAiCycleModeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAiCycleModeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00048E3F File Offset: 0x0004703F
		public static ILevelAiCycleModeType CreateFromSetValue([Nullable(2)] ILevelAiCycleModeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAiCycleModeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00048E52 File Offset: 0x00047052
		public ILevelAiCycleModeType_SetValue ToSetValue()
		{
			return new ILevelAiCycleModeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00048E65 File Offset: 0x00047065
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00048E90 File Offset: 0x00047090
		public virtual ELevelAiCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelAiCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400120E RID: 4622
		[Nullable(2)]
		protected ILevelAiCycleModeType FbInstance;

		// Token: 0x0400120F RID: 4623
		[Nullable(2)]
		protected ILevelAiCycleModeType_SetValue PocoInterface;
	}
}
