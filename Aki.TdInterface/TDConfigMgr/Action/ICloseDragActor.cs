using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018DA RID: 6362
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseDragActor : ICloseUiGame
	{
		// Token: 0x0600886B RID: 34923 RVA: 0x00142B3C File Offset: 0x00140D3C
		private ICloseDragActor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseDragActor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseDragActor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseDragActor_SetValue());
			}
			return result;
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x00142B74 File Offset: 0x00140D74
		public static ICloseDragActor Create([Nullable(2)] ICloseDragActor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseDragActor
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x00142B87 File Offset: 0x00140D87
		public static ICloseDragActor CreateFromSetValue([Nullable(2)] ICloseDragActor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseDragActor
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00142B9A File Offset: 0x00140D9A
		public new ICloseDragActor_SetValue ToSetValue()
		{
			return new ICloseDragActor_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600886F RID: 34927 RVA: 0x00142BB9 File Offset: 0x00140DB9
		// (set) Token: 0x06008870 RID: 34928 RVA: 0x00142BE4 File Offset: 0x00140DE4
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06008871 RID: 34929 RVA: 0x00142BF2 File Offset: 0x00140DF2
		// (set) Token: 0x06008872 RID: 34930 RVA: 0x00142C1D File Offset: 0x00140E1D
		public virtual int TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x040055AC RID: 21932
		[Nullable(2)]
		protected new ICloseDragActor FbInstance;

		// Token: 0x040055AD RID: 21933
		[Nullable(2)]
		protected new ICloseDragActor_SetValue PocoInterface;
	}
}
