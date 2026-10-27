using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD2 RID: 7378
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformerAiMoveToPlayer : IPerformerAiMoveConfig
	{
		// Token: 0x06009E69 RID: 40553 RVA: 0x0016A4C8 File Offset: 0x001686C8
		private IPerformerAiMoveToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformerAiMoveToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformerAiMoveToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformerAiMoveToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x0016A500 File Offset: 0x00168700
		public static IPerformerAiMoveToPlayer Create([Nullable(2)] IPerformerAiMoveToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0016A513 File Offset: 0x00168713
		public static IPerformerAiMoveToPlayer CreateFromSetValue([Nullable(2)] IPerformerAiMoveToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformerAiMoveToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0016A526 File Offset: 0x00168726
		public new IPerformerAiMoveToPlayer_SetValue ToSetValue()
		{
			return new IPerformerAiMoveToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x06009E6D RID: 40557 RVA: 0x0016A539 File Offset: 0x00168739
		// (set) Token: 0x06009E6E RID: 40558 RVA: 0x0016A564 File Offset: 0x00168764
		public override EPerformerAiMoveToType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPerformerAiMoveToType.Position;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FBB RID: 24507
		[Nullable(2)]
		protected new IPerformerAiMoveToPlayer FbInstance;

		// Token: 0x04005FBC RID: 24508
		[Nullable(2)]
		protected new IPerformerAiMoveToPlayer_SetValue PocoInterface;
	}
}
