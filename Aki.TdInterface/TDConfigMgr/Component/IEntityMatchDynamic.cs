using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000329 RID: 809
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchDynamic : IEntityMatchConfig
	{
		// Token: 0x06000FE8 RID: 4072 RVA: 0x00037B6C File Offset: 0x00035D6C
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

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00037BA4 File Offset: 0x00035DA4
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

		// Token: 0x06000FEA RID: 4074 RVA: 0x00037BB7 File Offset: 0x00035DB7
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

		// Token: 0x06000FEB RID: 4075 RVA: 0x00037BCA File Offset: 0x00035DCA
		public new IEntityMatchDynamic_SetValue ToSetValue()
		{
			return new IEntityMatchDynamic_SetValue
			{
				Type = this.Type,
				MatchEntity = this.MatchEntity
			};
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00037BE9 File Offset: 0x00035DE9
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00037C14 File Offset: 0x00035E14
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00037C24 File Offset: 0x00035E24
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00037CB7 File Offset: 0x00035EB7
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

		// Token: 0x04000D7E RID: 3454
		[Nullable(2)]
		protected new IEntityMatchDynamic FbInstance;

		// Token: 0x04000D7F RID: 3455
		[Nullable(2)]
		protected new IEntityMatchDynamic_SetValue PocoInterface;

		// Token: 0x04000D80 RID: 3456
		private List<IDynamicEntityMatch> _MatchEntityCache;

		// Token: 0x04000D81 RID: 3457
		private bool _MatchEntityInited;
	}
}
