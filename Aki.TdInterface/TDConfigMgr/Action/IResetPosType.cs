using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB2 RID: 7602
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IResetPosTypeConverter))]
	public class IResetPosType
	{
		// Token: 0x0600A2DD RID: 41693 RVA: 0x001722A0 File Offset: 0x001704A0
		private IResetPosType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPosType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPosType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPosType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x001722D8 File Offset: 0x001704D8
		public static IResetPosType Create([Nullable(2)] IResetPosType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x001722EB File Offset: 0x001704EB
		public static IResetPosType CreateFromSetValue([Nullable(2)] IResetPosType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPosType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x001722FE File Offset: 0x001704FE
		public IResetPosType_SetValue ToSetValue()
		{
			return new IResetPosType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x00172311 File Offset: 0x00170511
		// (set) Token: 0x0600A2E2 RID: 41698 RVA: 0x0017233C File Offset: 0x0017053C
		public virtual EResetPosType Type
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

		// Token: 0x040061C1 RID: 25025
		[Nullable(2)]
		protected IResetPosType FbInstance;

		// Token: 0x040061C2 RID: 25026
		[Nullable(2)]
		protected IResetPosType_SetValue PocoInterface;
	}
}
