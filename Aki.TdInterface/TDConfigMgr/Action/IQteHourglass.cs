using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8B RID: 8075
	public class IQteHourglass : IUiGame
	{
		// Token: 0x0600ABA5 RID: 43941 RVA: 0x001846D8 File Offset: 0x001828D8
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

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x00184710 File Offset: 0x00182910
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

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x00184723 File Offset: 0x00182923
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

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x00184736 File Offset: 0x00182936
		public new IQteHourglass_SetValue ToSetValue()
		{
			return new IQteHourglass_SetValue
			{
				Type = this.Type,
				QteIds = this.QteIds,
				QteConfigs = this.QteConfigs
			};
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x00184761 File Offset: 0x00182961
		// (set) Token: 0x0600ABAA RID: 43946 RVA: 0x0018478C File Offset: 0x0018298C
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

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x0018479A File Offset: 0x0018299A
		// (set) Token: 0x0600ABAC RID: 43948 RVA: 0x001847C1 File Offset: 0x001829C1
		[Nullable(2)]
		public virtual List<int> QteIds
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().QteIds = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x001847D0 File Offset: 0x001829D0
		// (set) Token: 0x0600ABAE RID: 43950 RVA: 0x00184863 File Offset: 0x00182A63
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IQteHourglassConfig> QteConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().QteConfigs = value;
				this._QteConfigsInited = false;
			}
		}

		// Token: 0x040066BB RID: 26299
		[Nullable(2)]
		protected new IQteHourglass FbInstance;

		// Token: 0x040066BC RID: 26300
		[Nullable(2)]
		protected new IQteHourglass_SetValue PocoInterface;

		// Token: 0x040066BD RID: 26301
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IQteHourglassConfig> _QteConfigsCache;

		// Token: 0x040066BE RID: 26302
		private bool _QteConfigsInited;
	}
}
