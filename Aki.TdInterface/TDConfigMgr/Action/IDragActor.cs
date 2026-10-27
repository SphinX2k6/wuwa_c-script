using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C0 RID: 6592
	[NullableContext(1)]
	[Nullable(0)]
	public class IDragActor : IUiGame
	{
		// Token: 0x06008D39 RID: 36153 RVA: 0x0014B090 File Offset: 0x00149290
		private IDragActor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDragActor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDragActor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDragActor_SetValue());
			}
			return result;
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x0014B0C8 File Offset: 0x001492C8
		public static IDragActor Create([Nullable(2)] IDragActor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragActor
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x0014B0DB File Offset: 0x001492DB
		public static IDragActor CreateFromSetValue([Nullable(2)] IDragActor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDragActor
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x0014B0EE File Offset: 0x001492EE
		public new IDragActor_SetValue ToSetValue()
		{
			return new IDragActor_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x0014B10D File Offset: 0x0014930D
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x0014B138 File Offset: 0x00149338
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

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0014B146 File Offset: 0x00149346
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x0014B171 File Offset: 0x00149371
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

		// Token: 0x040057C6 RID: 22470
		[Nullable(2)]
		protected new IDragActor FbInstance;

		// Token: 0x040057C7 RID: 22471
		[Nullable(2)]
		protected new IDragActor_SetValue PocoInterface;
	}
}
