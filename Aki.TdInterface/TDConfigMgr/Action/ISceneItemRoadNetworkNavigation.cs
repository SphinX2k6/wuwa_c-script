using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE6 RID: 7654
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemRoadNetworkNavigation : IRoadNetworkNavigationTarget
	{
		// Token: 0x0600A3D7 RID: 41943 RVA: 0x00173DB0 File Offset: 0x00171FB0
		private ISceneItemRoadNetworkNavigation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemRoadNetworkNavigation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemRoadNetworkNavigation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemRoadNetworkNavigation_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x00173DE8 File Offset: 0x00171FE8
		public static ISceneItemRoadNetworkNavigation Create([Nullable(2)] ISceneItemRoadNetworkNavigation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemRoadNetworkNavigation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x00173DFB File Offset: 0x00171FFB
		public static ISceneItemRoadNetworkNavigation CreateFromSetValue([Nullable(2)] ISceneItemRoadNetworkNavigation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemRoadNetworkNavigation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x00173E0E File Offset: 0x0017200E
		public new ISceneItemRoadNetworkNavigation_SetValue ToSetValue()
		{
			return new ISceneItemRoadNetworkNavigation_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A3DB RID: 41947 RVA: 0x00173E2D File Offset: 0x0017202D
		// (set) Token: 0x0600A3DC RID: 41948 RVA: 0x00173E58 File Offset: 0x00172058
		public override ERoadNetworkNavigationTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoadNetworkNavigationTarget.SceneItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A3DD RID: 41949 RVA: 0x00173E66 File Offset: 0x00172066
		// (set) Token: 0x0600A3DE RID: 41950 RVA: 0x00173E91 File Offset: 0x00172091
		public virtual int TargetId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetId;
			}
			set
			{
				this.GetOrCreatePoco().TargetId = value;
			}
		}

		// Token: 0x04006230 RID: 25136
		[Nullable(2)]
		protected new ISceneItemRoadNetworkNavigation FbInstance;

		// Token: 0x04006231 RID: 25137
		[Nullable(2)]
		protected new ISceneItemRoadNetworkNavigation_SetValue PocoInterface;
	}
}
