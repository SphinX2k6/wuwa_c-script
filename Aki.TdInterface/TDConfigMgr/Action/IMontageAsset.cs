using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DED RID: 7661
	public class IMontageAsset : IMontageConfig
	{
		// Token: 0x0600A2A5 RID: 41637 RVA: 0x00174118 File Offset: 0x00172318
		private IMontageAsset_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageAsset 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageAsset_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageAsset_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x00174150 File Offset: 0x00172350
		public static IMontageAsset Create([Nullable(2)] IMontageAsset instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x00174163 File Offset: 0x00172363
		public static IMontageAsset CreateFromSetValue([Nullable(2)] IMontageAsset_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x00174176 File Offset: 0x00172376
		public new IMontageAsset_SetValue ToSetValue()
		{
			return new IMontageAsset_SetValue
			{
				Type = this.Type,
				Asset = this.Asset
			};
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x00174195 File Offset: 0x00172395
		// (set) Token: 0x0600A2AA RID: 41642 RVA: 0x001741C0 File Offset: 0x001723C0
		public override EMontageConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMontageConfigType.Asset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x001741CE File Offset: 0x001723CE
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x001741F9 File Offset: 0x001723F9
		public virtual string Asset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Asset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Asset;
			}
			set
			{
				this.GetOrCreatePoco().Asset = value;
			}
		}

		// Token: 0x04006292 RID: 25234
		[Nullable(2)]
		protected new IMontageAsset FbInstance;

		// Token: 0x04006293 RID: 25235
		[Nullable(2)]
		protected new IMontageAsset_SetValue PocoInterface;
	}
}
