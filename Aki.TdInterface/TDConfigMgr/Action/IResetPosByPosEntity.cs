using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC5 RID: 8133
	[JsonConverter(typeof(IResetPosByPosEntityConverter))]
	public class IResetPosByPosEntity : IResetPosType
	{
		// Token: 0x0600ACD5 RID: 44245 RVA: 0x0018680C File Offset: 0x00184A0C
		private IResetPosByPosEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPosByPosEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPosByPosEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPosByPosEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x00186844 File Offset: 0x00184A44
		public static IResetPosByPosEntity Create([Nullable(2)] IResetPosByPosEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByPosEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x00186857 File Offset: 0x00184A57
		public static IResetPosByPosEntity CreateFromSetValue([Nullable(2)] IResetPosByPosEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPosByPosEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x0018686A File Offset: 0x00184A6A
		public new IResetPosByPosEntity_SetValue ToSetValue()
		{
			return new IResetPosByPosEntity_SetValue
			{
				Type = this.Type,
				Entity = this.Entity
			};
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600ACD9 RID: 44249 RVA: 0x00186889 File Offset: 0x00184A89
		// (set) Token: 0x0600ACDA RID: 44250 RVA: 0x001868B4 File Offset: 0x00184AB4
		public override EResetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPosType.PosEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600ACDB RID: 44251 RVA: 0x001868C2 File Offset: 0x00184AC2
		// (set) Token: 0x0600ACDC RID: 44252 RVA: 0x001868ED File Offset: 0x00184AED
		public virtual int Entity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Entity;
			}
			set
			{
				this.GetOrCreatePoco().Entity = value;
			}
		}

		// Token: 0x04006742 RID: 26434
		[Nullable(2)]
		protected new IResetPosByPosEntity FbInstance;

		// Token: 0x04006743 RID: 26435
		[Nullable(2)]
		protected new IResetPosByPosEntity_SetValue PocoInterface;
	}
}
