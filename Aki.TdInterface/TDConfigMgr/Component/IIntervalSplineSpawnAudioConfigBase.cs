using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049B RID: 1179
	[NullableContext(1)]
	[Nullable(0)]
	public class IIntervalSplineSpawnAudioConfigBase
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x00047B20 File Offset: 0x00045D20
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

		// Token: 0x060017C9 RID: 6089 RVA: 0x00047B58 File Offset: 0x00045D58
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

		// Token: 0x060017CA RID: 6090 RVA: 0x00047B6B File Offset: 0x00045D6B
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

		// Token: 0x060017CB RID: 6091 RVA: 0x00047B7E File Offset: 0x00045D7E
		public IIntervalSplineSpawnAudioConfigBase_SetValue ToSetValue()
		{
			return new IIntervalSplineSpawnAudioConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00047B91 File Offset: 0x00045D91
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00047BBC File Offset: 0x00045DBC
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

		// Token: 0x040011BF RID: 4543
		[Nullable(2)]
		protected IIntervalSplineSpawnAudioConfigBase FbInstance;

		// Token: 0x040011C0 RID: 4544
		[Nullable(2)]
		protected IIntervalSplineSpawnAudioConfigBase_SetValue PocoInterface;
	}
}
