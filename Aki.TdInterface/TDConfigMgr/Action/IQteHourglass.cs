using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7A RID: 7546
	[NullableContext(2)]
	[Nullable(0)]
	public class IQteHourglass : IUiGame
	{
		// Token: 0x0600A1B9 RID: 41401 RVA: 0x001702B4 File Offset: 0x0016E4B4
		[NullableContext(1)]
		private IQteHourglass_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQteHourglass 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQteHourglass_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQteHourglass_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x001702EC File Offset: 0x0016E4EC
		[NullableContext(1)]
		public static IQteHourglass Create([Nullable(2)] IQteHourglass instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteHourglass
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x001702FF File Offset: 0x0016E4FF
		[NullableContext(1)]
		public static IQteHourglass CreateFromSetValue([Nullable(2)] IQteHourglass_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQteHourglass
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x00170312 File Offset: 0x0016E512
		[NullableContext(1)]
		public new IQteHourglass_SetValue ToSetValue()
		{
			return new IQteHourglass_SetValue
			{
				Type = this.Type,
				QteIds = this.QteIds,
				QteConfigs = this.QteConfigs
			};
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x0017033D File Offset: 0x0016E53D
		// (set) Token: 0x0600A1BE RID: 41406 RVA: 0x00170368 File Offset: 0x0016E568
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x00170376 File Offset: 0x0016E576
		// (set) Token: 0x0600A1C0 RID: 41408 RVA: 0x0017039D File Offset: 0x0016E59D
		public virtual List<int> QteIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteIds;
				}
				IQteHourglass_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.QteIds;
			}
			set
			{
				this.GetOrCreatePoco().QteIds = value;
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x001703AC File Offset: 0x0016E5AC
		// (set) Token: 0x0600A1C2 RID: 41410 RVA: 0x0017043F File Offset: 0x0016E63F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IQteHourglassConfig> QteConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._QteConfigsInited)
				{
					return this._QteConfigsCache;
				}
				this._QteConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IQteHourglassConfig> qteConfigs = this.FbInstance.QteConfigs;
					if (qteConfigs != null)
					{
						this._QteConfigsCache = new List<IQteHourglassConfig>(qteConfigs.Count);
						for (int i = 0; i < qteConfigs.Count; i++)
						{
							this._QteConfigsCache.Add(IQteHourglassConfig.Create(qteConfigs[i]));
						}
					}
				}
				else
				{
					IQteHourglass_SetValue pocoInterface = this.PocoInterface;
					this._QteConfigsCache = ((pocoInterface != null) ? pocoInterface.QteConfigs : null);
				}
				return this._QteConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().QteConfigs = value;
				this._QteConfigsInited = false;
			}
		}

		// Token: 0x0400613F RID: 24895
		protected new IQteHourglass FbInstance;

		// Token: 0x04006140 RID: 24896
		protected new IQteHourglass_SetValue PocoInterface;

		// Token: 0x04006141 RID: 24897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IQteHourglassConfig> _QteConfigsCache;

		// Token: 0x04006142 RID: 24898
		private bool _QteConfigsInited;
	}
}
