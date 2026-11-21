using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F3 RID: 1779
	public class IRandomPoolChoose : IMonsterChooseType
	{
		// Token: 0x060025BA RID: 9658 RVA: 0x00066294 File Offset: 0x00064494
		private IRandomPoolChoose_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomPoolChoose 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomPoolChoose_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomPoolChoose_SetValue());
			}
			return result;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000662CC File Offset: 0x000644CC
		public static IRandomPoolChoose Create([Nullable(2)] IRandomPoolChoose instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPoolChoose
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000662DF File Offset: 0x000644DF
		public static IRandomPoolChoose CreateFromSetValue([Nullable(2)] IRandomPoolChoose_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomPoolChoose
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000662F2 File Offset: 0x000644F2
		public new IRandomPoolChoose_SetValue ToSetValue()
		{
			return new IRandomPoolChoose_SetValue
			{
				Type = this.Type,
				RandomPoolConfigs = this.RandomPoolConfigs
			};
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x00066311 File Offset: 0x00064511
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0006633C File Offset: 0x0006453C
		public override EMonsterChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0006634C File Offset: 0x0006454C
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x000663DF File Offset: 0x000645DF
		public virtual List<IRandomPoolConfig> RandomPoolConfigs
		{
			get
			{
				if (this._RandomPoolConfigsInited)
				{
					return this._RandomPoolConfigsCache;
				}
				this._RandomPoolConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IRandomPoolConfig> randomPoolConfigs = this.FbInstance.RandomPoolConfigs;
					if (randomPoolConfigs != null)
					{
						this._RandomPoolConfigsCache = new List<IRandomPoolConfig>(randomPoolConfigs.Count);
						for (int i = 0; i < randomPoolConfigs.Count; i++)
						{
							this._RandomPoolConfigsCache.Add(IRandomPoolConfig.Create(randomPoolConfigs[i]));
						}
					}
				}
				else
				{
					IRandomPoolChoose_SetValue pocoInterface = this.PocoInterface;
					this._RandomPoolConfigsCache = ((pocoInterface != null) ? pocoInterface.RandomPoolConfigs : null);
				}
				return this._RandomPoolConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().RandomPoolConfigs = value;
				this._RandomPoolConfigsInited = false;
			}
		}

		// Token: 0x04001A0C RID: 6668
		[Nullable(2)]
		protected new IRandomPoolChoose FbInstance;

		// Token: 0x04001A0D RID: 6669
		[Nullable(2)]
		protected new IRandomPoolChoose_SetValue PocoInterface;

		// Token: 0x04001A0E RID: 6670
		private List<IRandomPoolConfig> _RandomPoolConfigsCache;

		// Token: 0x04001A0F RID: 6671
		private bool _RandomPoolConfigsInited;
	}
}
