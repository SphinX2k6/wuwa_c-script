using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D95 RID: 7573
	public class ILookAtBubbleEntity : IDefaultLookAtType
	{
		// Token: 0x0600A0BF RID: 41151 RVA: 0x00170938 File Offset: 0x0016EB38
		private ILookAtBubbleEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtBubbleEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtBubbleEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtBubbleEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x00170970 File Offset: 0x0016EB70
		public static ILookAtBubbleEntity Create([Nullable(2)] ILookAtBubbleEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtBubbleEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x00170983 File Offset: 0x0016EB83
		public static ILookAtBubbleEntity CreateFromSetValue([Nullable(2)] ILookAtBubbleEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtBubbleEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00170996 File Offset: 0x0016EB96
		public new ILookAtBubbleEntity_SetValue ToSetValue()
		{
			return new ILookAtBubbleEntity_SetValue
			{
				Type = this.Type,
				BubbleEntityConfig = this.BubbleEntityConfig
			};
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x001709B5 File Offset: 0x0016EBB5
		// (set) Token: 0x0600A0C4 RID: 41156 RVA: 0x001709E0 File Offset: 0x0016EBE0
		public override EDefaultLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x001709F0 File Offset: 0x0016EBF0
		// (set) Token: 0x0600A0C6 RID: 41158 RVA: 0x00170A83 File Offset: 0x0016EC83
		public virtual List<ILookAtBubbleEntityConfig> BubbleEntityConfig
		{
			get
			{
				if (this._BubbleEntityConfigInited)
				{
					return this._BubbleEntityConfigCache;
				}
				this._BubbleEntityConfigInited = true;
				if (this.FbInstance != null)
				{
					List<ILookAtBubbleEntityConfig> bubbleEntityConfig = this.FbInstance.BubbleEntityConfig;
					if (bubbleEntityConfig != null)
					{
						this._BubbleEntityConfigCache = new List<ILookAtBubbleEntityConfig>(bubbleEntityConfig.Count);
						for (int i = 0; i < bubbleEntityConfig.Count; i++)
						{
							this._BubbleEntityConfigCache.Add(ILookAtBubbleEntityConfig.Create(bubbleEntityConfig[i]));
						}
					}
				}
				else
				{
					ILookAtBubbleEntity_SetValue pocoInterface = this.PocoInterface;
					this._BubbleEntityConfigCache = ((pocoInterface != null) ? pocoInterface.BubbleEntityConfig : null);
				}
				return this._BubbleEntityConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().BubbleEntityConfig = value;
				this._BubbleEntityConfigInited = false;
			}
		}

		// Token: 0x040061AD RID: 25005
		[Nullable(2)]
		protected new ILookAtBubbleEntity FbInstance;

		// Token: 0x040061AE RID: 25006
		[Nullable(2)]
		protected new ILookAtBubbleEntity_SetValue PocoInterface;

		// Token: 0x040061AF RID: 25007
		private List<ILookAtBubbleEntityConfig> _BubbleEntityConfigCache;

		// Token: 0x040061B0 RID: 25008
		private bool _BubbleEntityConfigInited;
	}
}
