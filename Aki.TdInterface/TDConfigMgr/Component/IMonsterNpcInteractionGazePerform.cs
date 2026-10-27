using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050C RID: 1292
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionGazePerform : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x0004CAD4 File Offset: 0x0004ACD4
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

		// Token: 0x06001A3B RID: 6715 RVA: 0x0004CB0C File Offset: 0x0004AD0C
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

		// Token: 0x06001A3C RID: 6716 RVA: 0x0004CB1F File Offset: 0x0004AD1F
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

		// Token: 0x06001A3D RID: 6717 RVA: 0x0004CB32 File Offset: 0x0004AD32
		public new IMonsterNpcInteractionGazePerform_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionGazePerform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x0004CB45 File Offset: 0x0004AD45
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0004CB70 File Offset: 0x0004AD70
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

		// Token: 0x0400130E RID: 4878
		[Nullable(2)]
		protected new IMonsterNpcInteractionGazePerform FbInstance;

		// Token: 0x0400130F RID: 4879
		[Nullable(2)]
		protected new IMonsterNpcInteractionGazePerform_SetValue PocoInterface;
	}
}
