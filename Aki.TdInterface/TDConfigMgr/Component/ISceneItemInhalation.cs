using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000745 RID: 1861
	public class ISceneItemInhalation : IInhalationPerformanceType
	{
		// Token: 0x0600278A RID: 10122 RVA: 0x00069B64 File Offset: 0x00067D64
		private ISceneItemInhalation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemInhalation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemInhalation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemInhalation_SetValue());
			}
			return result;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00069B9C File Offset: 0x00067D9C
		public static ISceneItemInhalation Create([Nullable(2)] ISceneItemInhalation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00069BAF File Offset: 0x00067DAF
		public static ISceneItemInhalation CreateFromSetValue([Nullable(2)] ISceneItemInhalation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00069BC2 File Offset: 0x00067DC2
		public new ISceneItemInhalation_SetValue ToSetValue()
		{
			return new ISceneItemInhalation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x00069BD5 File Offset: 0x00067DD5
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x00069C00 File Offset: 0x00067E00
		public override EInhalationPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhalationPerformanceType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AFF RID: 6911
		[Nullable(2)]
		protected new ISceneItemInhalation FbInstance;

		// Token: 0x04001B00 RID: 6912
		[Nullable(2)]
		protected new ISceneItemInhalation_SetValue PocoInterface;
	}
}
