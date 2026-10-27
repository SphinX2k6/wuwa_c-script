using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D86 RID: 7558
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600A205 RID: 41477 RVA: 0x00170BDC File Offset: 0x0016EDDC
		private IRandomPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x00170C14 File Offset: 0x0016EE14
		public static IRandomPrefabConfig Create([Nullable(2)] IRandomPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x00170C27 File Offset: 0x0016EE27
		public static IRandomPrefabConfig CreateFromSetValue([Nullable(2)] IRandomPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x00170C3A File Offset: 0x0016EE3A
		public new IRandomPrefabConfig_SetValue ToSetValue()
		{
			return new IRandomPrefabConfig_SetValue
			{
				Type = this.Type,
				RandomPrefabId = this.RandomPrefabId
			};
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x00170C59 File Offset: 0x0016EE59
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x00170C84 File Offset: 0x0016EE84
		public override ECreatePrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECreatePrefabType.PrefabId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x00170C92 File Offset: 0x0016EE92
		// (set) Token: 0x0600A20C RID: 41484 RVA: 0x00170CBD File Offset: 0x0016EEBD
		public virtual int RandomPrefabId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RandomPrefabId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RandomPrefabId;
			}
			set
			{
				this.GetOrCreatePoco().RandomPrefabId = value;
			}
		}

		// Token: 0x04006161 RID: 24929
		[Nullable(2)]
		protected new IRandomPrefabConfig FbInstance;

		// Token: 0x04006162 RID: 24930
		[Nullable(2)]
		protected new IRandomPrefabConfig_SetValue PocoInterface;
	}
}
