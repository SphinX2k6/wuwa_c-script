using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F5 RID: 6645
	public class IChangeElementalBoxStateTargetBoxId : IChangeElementalBoxStateTarget
	{
		// Token: 0x06008D6D RID: 36205 RVA: 0x0014E8CC File Offset: 0x0014CACC
		private IChangeElementalBoxStateTargetBoxId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeElementalBoxStateTargetBoxId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeElementalBoxStateTargetBoxId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeElementalBoxStateTargetBoxId_SetValue());
			}
			return result;
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x0014E904 File Offset: 0x0014CB04
		public static IChangeElementalBoxStateTargetBoxId Create([Nullable(2)] IChangeElementalBoxStateTargetBoxId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x0014E917 File Offset: 0x0014CB17
		public static IChangeElementalBoxStateTargetBoxId CreateFromSetValue([Nullable(2)] IChangeElementalBoxStateTargetBoxId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTargetBoxId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x0014E92A File Offset: 0x0014CB2A
		public new IChangeElementalBoxStateTargetBoxId_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStateTargetBoxId_SetValue
			{
				Type = this.Type,
				TargetBoxId = this.TargetBoxId
			};
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x06008D71 RID: 36209 RVA: 0x0014E949 File Offset: 0x0014CB49
		// (set) Token: 0x06008D72 RID: 36210 RVA: 0x0014E974 File Offset: 0x0014CB74
		public override EChangeElementalBoxStateTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x06008D73 RID: 36211 RVA: 0x0014E982 File Offset: 0x0014CB82
		// (set) Token: 0x06008D74 RID: 36212 RVA: 0x0014E9AD File Offset: 0x0014CBAD
		public virtual int TargetBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetBoxId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetBoxId;
			}
			set
			{
				this.GetOrCreatePoco().TargetBoxId = value;
			}
		}

		// Token: 0x04005904 RID: 22788
		[Nullable(2)]
		protected new IChangeElementalBoxStateTargetBoxId FbInstance;

		// Token: 0x04005905 RID: 22789
		[Nullable(2)]
		protected new IChangeElementalBoxStateTargetBoxId_SetValue PocoInterface;
	}
}
