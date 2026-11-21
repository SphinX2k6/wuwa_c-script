using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB5 RID: 8117
	public class IRemoveSceneUiSubtitle : ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600AC89 RID: 44169 RVA: 0x00186014 File Offset: 0x00184214
		private IRemoveSceneUiSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemoveSceneUiSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemoveSceneUiSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemoveSceneUiSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x0018604C File Offset: 0x0018424C
		public static IRemoveSceneUiSubtitle Create([Nullable(2)] IRemoveSceneUiSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveSceneUiSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x0018605F File Offset: 0x0018425F
		public static IRemoveSceneUiSubtitle CreateFromSetValue([Nullable(2)] IRemoveSceneUiSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemoveSceneUiSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x00186072 File Offset: 0x00184272
		public new IRemoveSceneUiSubtitle_SetValue ToSetValue()
		{
			return new IRemoveSceneUiSubtitle_SetValue
			{
				Type = this.Type,
				Mark = this.Mark
			};
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x00186091 File Offset: 0x00184291
		// (set) Token: 0x0600AC8E RID: 44174 RVA: 0x001860BC File Offset: 0x001842BC
		public override ESceneUiSubtitleOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x001860CA File Offset: 0x001842CA
		// (set) Token: 0x0600AC90 RID: 44176 RVA: 0x001860F5 File Offset: 0x001842F5
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x04006720 RID: 26400
		[Nullable(2)]
		protected new IRemoveSceneUiSubtitle FbInstance;

		// Token: 0x04006721 RID: 26401
		[Nullable(2)]
		protected new IRemoveSceneUiSubtitle_SetValue PocoInterface;
	}
}
