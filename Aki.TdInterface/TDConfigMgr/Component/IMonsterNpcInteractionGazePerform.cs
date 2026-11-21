using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000573 RID: 1395
	public class IMonsterNpcInteractionGazePerform : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001C36 RID: 7222 RVA: 0x00051890 File Offset: 0x0004FA90
		private IMonsterNpcInteractionGazePerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionGazePerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionGazePerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionGazePerform_SetValue());
			}
			return result;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000518C8 File Offset: 0x0004FAC8
		public static IMonsterNpcInteractionGazePerform Create([Nullable(2)] IMonsterNpcInteractionGazePerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionGazePerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000518DB File Offset: 0x0004FADB
		public static IMonsterNpcInteractionGazePerform CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionGazePerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionGazePerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000518EE File Offset: 0x0004FAEE
		public new IMonsterNpcInteractionGazePerform_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionGazePerform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00051901 File Offset: 0x0004FB01
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0005192C File Offset: 0x0004FB2C
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

		// Token: 0x04001478 RID: 5240
		[Nullable(2)]
		protected new IMonsterNpcInteractionGazePerform FbInstance;

		// Token: 0x04001479 RID: 5241
		[Nullable(2)]
		protected new IMonsterNpcInteractionGazePerform_SetValue PocoInterface;
	}
}
