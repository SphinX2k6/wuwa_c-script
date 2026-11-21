using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B4D RID: 6989
	public class IDragActor : IUiGame
	{
		// Token: 0x0600947B RID: 38011 RVA: 0x0015AB9C File Offset: 0x00158D9C
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

		// Token: 0x0600947C RID: 38012 RVA: 0x0015ABD4 File Offset: 0x00158DD4
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

		// Token: 0x0600947D RID: 38013 RVA: 0x0015ABE7 File Offset: 0x00158DE7
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

		// Token: 0x0600947E RID: 38014 RVA: 0x0015ABFA File Offset: 0x00158DFA
		public new IDragActor_SetValue ToSetValue()
		{
			return new IDragActor_SetValue
			{
				Type = this.Type,
				TargetEntityId = this.TargetEntityId
			};
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x0015AC19 File Offset: 0x00158E19
		// (set) Token: 0x06009480 RID: 38016 RVA: 0x0015AC44 File Offset: 0x00158E44
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

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x0015AC52 File Offset: 0x00158E52
		// (set) Token: 0x06009482 RID: 38018 RVA: 0x0015AC7D File Offset: 0x00158E7D
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

		// Token: 0x04005C1B RID: 23579
		[Nullable(2)]
		protected new IDragActor FbInstance;

		// Token: 0x04005C1C RID: 23580
		[Nullable(2)]
		protected new IDragActor_SetValue PocoInterface;
	}
}
