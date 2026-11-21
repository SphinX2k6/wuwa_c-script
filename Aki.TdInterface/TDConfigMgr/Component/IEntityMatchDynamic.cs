using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000370 RID: 880
	public class IEntityMatchDynamic : IEntityMatchConfig
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x0003AB38 File Offset: 0x00038D38
		private IEntityMatchDynamic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchDynamic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchDynamic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchDynamic_SetValue());
			}
			return result;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0003AB70 File Offset: 0x00038D70
		public static IEntityMatchDynamic Create([Nullable(2)] IEntityMatchDynamic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchDynamic
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0003AB83 File Offset: 0x00038D83
		public static IEntityMatchDynamic CreateFromSetValue([Nullable(2)] IEntityMatchDynamic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchDynamic
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0003AB96 File Offset: 0x00038D96
		public new IEntityMatchDynamic_SetValue ToSetValue()
		{
			return new IEntityMatchDynamic_SetValue
			{
				Type = this.Type,
				MatchEntity = this.MatchEntity
			};
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0003ABB5 File Offset: 0x00038DB5
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x0003ABE0 File Offset: 0x00038DE0
		public override EEntityMatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityMatchType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0003ABF0 File Offset: 0x00038DF0
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x0003AC83 File Offset: 0x00038E83
		public virtual List<IDynamicEntityMatch> MatchEntity
		{
			get
			{
				if (this._MatchEntityInited)
				{
					return this._MatchEntityCache;
				}
				this._MatchEntityInited = true;
				if (this.FbInstance != null)
				{
					List<IDynamicEntityMatch> matchEntity = this.FbInstance.MatchEntity;
					if (matchEntity != null)
					{
						this._MatchEntityCache = new List<IDynamicEntityMatch>(matchEntity.Count);
						for (int i = 0; i < matchEntity.Count; i++)
						{
							this._MatchEntityCache.Add(IDynamicEntityMatch.Create(matchEntity[i]));
						}
					}
				}
				else
				{
					IEntityMatchDynamic_SetValue pocoInterface = this.PocoInterface;
					this._MatchEntityCache = ((pocoInterface != null) ? pocoInterface.MatchEntity : null);
				}
				return this._MatchEntityCache;
			}
			set
			{
				this.GetOrCreatePoco().MatchEntity = value;
				this._MatchEntityInited = false;
			}
		}

		// Token: 0x04000E69 RID: 3689
		[Nullable(2)]
		protected new IEntityMatchDynamic FbInstance;

		// Token: 0x04000E6A RID: 3690
		[Nullable(2)]
		protected new IEntityMatchDynamic_SetValue PocoInterface;

		// Token: 0x04000E6B RID: 3691
		private List<IDynamicEntityMatch> _MatchEntityCache;

		// Token: 0x04000E6C RID: 3692
		private bool _MatchEntityInited;
	}
}
