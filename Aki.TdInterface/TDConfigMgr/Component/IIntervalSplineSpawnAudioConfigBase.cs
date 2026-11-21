using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F4 RID: 1268
	public class IIntervalSplineSpawnAudioConfigBase
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x0004B868 File Offset: 0x00049A68
		private IIntervalSplineSpawnAudioConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IIntervalSplineSpawnAudioConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IIntervalSplineSpawnAudioConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IIntervalSplineSpawnAudioConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		public static IIntervalSplineSpawnAudioConfigBase Create([Nullable(2)] IIntervalSplineSpawnAudioConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIntervalSplineSpawnAudioConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x0004B8B3 File Offset: 0x00049AB3
		public static IIntervalSplineSpawnAudioConfigBase CreateFromSetValue([Nullable(2)] IIntervalSplineSpawnAudioConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IIntervalSplineSpawnAudioConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0004B8C6 File Offset: 0x00049AC6
		public IIntervalSplineSpawnAudioConfigBase_SetValue ToSetValue()
		{
			return new IIntervalSplineSpawnAudioConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0004B8D9 File Offset: 0x00049AD9
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0004B904 File Offset: 0x00049B04
		public virtual EIntervalSplineSpawnAudioConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012E1 RID: 4833
		[Nullable(2)]
		protected IIntervalSplineSpawnAudioConfigBase FbInstance;

		// Token: 0x040012E2 RID: 4834
		[Nullable(2)]
		protected IIntervalSplineSpawnAudioConfigBase_SetValue PocoInterface;
	}
}
