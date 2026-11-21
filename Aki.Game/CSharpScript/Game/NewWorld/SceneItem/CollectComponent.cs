using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006211 RID: 25105
	public class CollectComponent : EntityComponent
	{
		// Token: 0x0603C5B3 RID: 247219 RVA: 0x011378C4 File Offset: 0x01135AC4
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CollectComponent collectComponent = (CollectComponent)args.GetP1<CreateEntityData>().GetParam<CollectComponent>();
			this.IsDisableOneClickCollection = collectComponent.IsDisableOneClickCollection.GetValueOrDefault();
			return true;
		}

		// Token: 0x0603C5B4 RID: 247220 RVA: 0x011378F7 File Offset: 0x01135AF7
		public bool GetIsDisableOneClickCollection()
		{
			return this.IsDisableOneClickCollection;
		}

		// Token: 0x0603C5B5 RID: 247221 RVA: 0x01137900 File Offset: 0x01135B00
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CollectComponent collectComponent = (CollectComponent)componentTemplate;
			this.IsDisableOneClickCollection = collectComponent.IsDisableOneClickCollection;
			return true;
		}

		// Token: 0x0401FF3D RID: 130877
		private bool IsDisableOneClickCollection;
	}
}
