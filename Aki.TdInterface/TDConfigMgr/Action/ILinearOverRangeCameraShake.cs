using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9A RID: 7066
	[NullableContext(1)]
	[Nullable(0)]
	public class ILinearOverRangeCameraShake : ICameraShakeConfig
	{
		// Token: 0x06009743 RID: 38723 RVA: 0x0015CEC4 File Offset: 0x0015B0C4
		private ILinearOverRangeCameraShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILinearOverRangeCameraShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILinearOverRangeCameraShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILinearOverRangeCameraShake_SetValue());
			}
			return result;
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0015CEFC File Offset: 0x0015B0FC
		public static ILinearOverRangeCameraShake Create([Nullable(2)] ILinearOverRangeCameraShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinearOverRangeCameraShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0015CF0F File Offset: 0x0015B10F
		public static ILinearOverRangeCameraShake CreateFromSetValue([Nullable(2)] ILinearOverRangeCameraShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILinearOverRangeCameraShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0015CF22 File Offset: 0x0015B122
		public new ILinearOverRangeCameraShake_SetValue ToSetValue()
		{
			return new ILinearOverRangeCameraShake_SetValue
			{
				Type = this.Type,
				CenterEntityId = this.CenterEntityId,
				MinRange = this.MinRange,
				MaxRange = this.MaxRange
			};
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009747 RID: 38727 RVA: 0x0015CF59 File Offset: 0x0015B159
		// (set) Token: 0x06009748 RID: 38728 RVA: 0x0015CF84 File Offset: 0x0015B184
		public override ECameraShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraShakeType.Constant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009749 RID: 38729 RVA: 0x0015CF92 File Offset: 0x0015B192
		// (set) Token: 0x0600974A RID: 38730 RVA: 0x0015CFBD File Offset: 0x0015B1BD
		public virtual int CenterEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CenterEntityId;
			}
			set
			{
				this.GetOrCreatePoco().CenterEntityId = value;
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600974B RID: 38731 RVA: 0x0015CFCB File Offset: 0x0015B1CB
		// (set) Token: 0x0600974C RID: 38732 RVA: 0x0015CFF6 File Offset: 0x0015B1F6
		public virtual int MinRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinRange;
			}
			set
			{
				this.GetOrCreatePoco().MinRange = value;
			}
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600974D RID: 38733 RVA: 0x0015D004 File Offset: 0x0015B204
		// (set) Token: 0x0600974E RID: 38734 RVA: 0x0015D02F File Offset: 0x0015B22F
		public virtual int MaxRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxRange;
			}
			set
			{
				this.GetOrCreatePoco().MaxRange = value;
			}
		}

		// Token: 0x04005C56 RID: 23638
		[Nullable(2)]
		protected new ILinearOverRangeCameraShake FbInstance;

		// Token: 0x04005C57 RID: 23639
		[Nullable(2)]
		protected new ILinearOverRangeCameraShake_SetValue PocoInterface;
	}
}
