using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001862 RID: 6242
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeActorMPC : IModifyMaterialConfig
	{
		// Token: 0x0600861D RID: 34333 RVA: 0x0013EC98 File Offset: 0x0013CE98
		private IChangeActorMPC_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeActorMPC 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeActorMPC_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeActorMPC_SetValue());
			}
			return result;
		}

		// Token: 0x0600861E RID: 34334 RVA: 0x0013ECD0 File Offset: 0x0013CED0
		public static IChangeActorMPC Create([Nullable(2)] IChangeActorMPC instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeActorMPC
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x0013ECE3 File Offset: 0x0013CEE3
		public static IChangeActorMPC CreateFromSetValue([Nullable(2)] IChangeActorMPC_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeActorMPC
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x0013ECF6 File Offset: 0x0013CEF6
		public new IChangeActorMPC_SetValue ToSetValue()
		{
			return new IChangeActorMPC_SetValue
			{
				Type = this.Type,
				MpcData = this.MpcData
			};
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x0013ED15 File Offset: 0x0013CF15
		// (set) Token: 0x06008622 RID: 34338 RVA: 0x0013ED40 File Offset: 0x0013CF40
		public override EModifyActorMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x0013ED4E File Offset: 0x0013CF4E
		// (set) Token: 0x06008624 RID: 34340 RVA: 0x0013ED79 File Offset: 0x0013CF79
		public virtual string MpcData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MpcData;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MpcData;
			}
			set
			{
				this.GetOrCreatePoco().MpcData = value;
			}
		}

		// Token: 0x040054A7 RID: 21671
		[Nullable(2)]
		protected new IChangeActorMPC FbInstance;

		// Token: 0x040054A8 RID: 21672
		[Nullable(2)]
		protected new IChangeActorMPC_SetValue PocoInterface;
	}
}
