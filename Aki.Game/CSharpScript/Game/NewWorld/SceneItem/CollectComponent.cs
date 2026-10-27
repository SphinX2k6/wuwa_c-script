using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200715D RID: 29021
	public class CollectComponent : EntityComponent
	{
		// Token: 0x06046D73 RID: 290163 RVA: 0x011DBB24 File Offset: 0x011D9D24
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CollectComponent collectComponent = (CollectComponent)args.GetP1<CreateEntityData>().GetParam<CollectComponent>();
			this.IsDisableOneClickCollection = collectComponent.IsDisableOneClickCollection.GetValueOrDefault();
			return true;
		}

		// Token: 0x06046D74 RID: 290164 RVA: 0x011DBB57 File Offset: 0x011D9D57
		public bool GetIsDisableOneClickCollection()
		{
			return this.IsDisableOneClickCollection;
		}

		// Token: 0x06046D75 RID: 290165 RVA: 0x011DBB60 File Offset: 0x011D9D60
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CollectComponent collectComponent = (CollectComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsDisableOneClickCollection"))
			{
				this.IsDisableOneClickCollection = collectComponent.IsDisableOneClickCollection;
			}
			return true;
		}

		// Token: 0x040252D6 RID: 152278
		private bool IsDisableOneClickCollection;
	}
}
