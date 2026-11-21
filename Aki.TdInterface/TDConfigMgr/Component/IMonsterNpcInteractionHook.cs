using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000575 RID: 1397
	public class IMonsterNpcInteractionHook : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001C3E RID: 7230 RVA: 0x0005194C File Offset: 0x0004FB4C
		private IMonsterNpcInteractionHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00051984 File Offset: 0x0004FB84
		public static IMonsterNpcInteractionHook Create([Nullable(2)] IMonsterNpcInteractionHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00051997 File Offset: 0x0004FB97
		public static IMonsterNpcInteractionHook CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000519AA File Offset: 0x0004FBAA
		public new IMonsterNpcInteractionHook_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionHook_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000519BD File Offset: 0x0004FBBD
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x000519E8 File Offset: 0x0004FBE8
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400147B RID: 5243
		[Nullable(2)]
		protected new IMonsterNpcInteractionHook FbInstance;

		// Token: 0x0400147C RID: 5244
		[Nullable(2)]
		protected new IMonsterNpcInteractionHook_SetValue PocoInterface;
	}
}
