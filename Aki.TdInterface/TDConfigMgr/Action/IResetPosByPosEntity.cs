using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DAE RID: 7598
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IResetPosByPosEntityConverter))]
	public class IResetPosByPosEntity : IResetPosType
	{
		// Token: 0x0600A2CB RID: 41675 RVA: 0x001720E4 File Offset: 0x001702E4
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

		// Token: 0x0600A2CC RID: 41676 RVA: 0x0017211C File Offset: 0x0017031C
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

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0017212F File Offset: 0x0017032F
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

		// Token: 0x0600A2CE RID: 41678 RVA: 0x00172142 File Offset: 0x00170342
		public new IResetPosByPosEntity_SetValue ToSetValue()
		{
			return new IResetPosByPosEntity_SetValue
			{
				Type = this.Type,
				Entity = this.Entity
			};
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A2CF RID: 41679 RVA: 0x00172161 File Offset: 0x00170361
		// (set) Token: 0x0600A2D0 RID: 41680 RVA: 0x0017218C File Offset: 0x0017038C
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

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x0017219A File Offset: 0x0017039A
		// (set) Token: 0x0600A2D2 RID: 41682 RVA: 0x001721C5 File Offset: 0x001703C5
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

		// Token: 0x040061BA RID: 25018
		[Nullable(2)]
		protected new IResetPosByPosEntity FbInstance;

		// Token: 0x040061BB RID: 25019
		[Nullable(2)]
		protected new IResetPosByPosEntity_SetValue PocoInterface;
	}
}
