using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAE RID: 7086
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtBubbleEntity : IDefaultLookAtType
	{
		// Token: 0x060097BB RID: 38843 RVA: 0x0015DE78 File Offset: 0x0015C078
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

		// Token: 0x060097BC RID: 38844 RVA: 0x0015DEB0 File Offset: 0x0015C0B0
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

		// Token: 0x060097BD RID: 38845 RVA: 0x0015DEC3 File Offset: 0x0015C0C3
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

		// Token: 0x060097BE RID: 38846 RVA: 0x0015DED6 File Offset: 0x0015C0D6
		public new ILookAtBubbleEntity_SetValue ToSetValue()
		{
			return new ILookAtBubbleEntity_SetValue
			{
				Type = this.Type,
				BubbleEntityConfig = this.BubbleEntityConfig
			};
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0015DEF5 File Offset: 0x0015C0F5
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x0015DF20 File Offset: 0x0015C120
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

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x0015DF30 File Offset: 0x0015C130
		// (set) Token: 0x060097C2 RID: 38850 RVA: 0x0015DFC3 File Offset: 0x0015C1C3
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

		// Token: 0x04005C98 RID: 23704
		[Nullable(2)]
		protected new ILookAtBubbleEntity FbInstance;

		// Token: 0x04005C99 RID: 23705
		[Nullable(2)]
		protected new ILookAtBubbleEntity_SetValue PocoInterface;

		// Token: 0x04005C9A RID: 23706
		private List<ILookAtBubbleEntityConfig> _BubbleEntityConfigCache;

		// Token: 0x04005C9B RID: 23707
		private bool _BubbleEntityConfigInited;
	}
}
