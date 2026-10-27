using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020047B2 RID: 18354
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapPlayerComponent : MapComponent
	{
		// Token: 0x06030107 RID: 196871 RVA: 0x00B23F80 File Offset: 0x00B22180
		public WorldMapPlayerComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x1700785C RID: 30812
		// (get) Token: 0x06030108 RID: 196872 RVA: 0x00B23FA6 File Offset: 0x00B221A6
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapPlayer;
			}
		}

		// Token: 0x1700785D RID: 30813
		// (get) Token: 0x06030109 RID: 196873 RVA: 0x00B23FA9 File Offset: 0x00B221A9
		// (set) Token: 0x0603010A RID: 196874 RVA: 0x00B23FB1 File Offset: 0x00B221B1
		public Vector2D PlayerUiPosition { get; private set; } = Vector2D.Create(0.0, 0.0);

		// Token: 0x1700785E RID: 30814
		// (get) Token: 0x0603010B RID: 196875 RVA: 0x00B23FBA File Offset: 0x00B221BA
		// (set) Token: 0x0603010C RID: 196876 RVA: 0x00B23FC2 File Offset: 0x00B221C2
		public Vector PlayerWorldPosition { get; private set; }

		// Token: 0x1700785F RID: 30815
		// (get) Token: 0x0603010D RID: 196877 RVA: 0x00B23FCB File Offset: 0x00B221CB
		// (set) Token: 0x0603010E RID: 196878 RVA: 0x00B23FD3 File Offset: 0x00B221D3
		public float PlayerRotation { get; set; }

		// Token: 0x17007860 RID: 30816
		// (get) Token: 0x0603010F RID: 196879 RVA: 0x00B23FDC File Offset: 0x00B221DC
		// (set) Token: 0x06030110 RID: 196880 RVA: 0x00B23FE4 File Offset: 0x00B221E4
		public bool PlayerOutOfBound { get; set; }

		// Token: 0x06030111 RID: 196881 RVA: 0x00B23FF0 File Offset: 0x00B221F0
		public void UpdatePlayerPosition()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return;
			}
			WorldEntity entity = getCurrentEntity.Entity;
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent == null)
			{
				return;
			}
			if (!MapModel.Instance.CurrentInWorld)
			{
				Vector lastBigScenePlayerPosition = MapUtil.GetLastBigScenePlayerPosition();
				this.PlayerWorldPosition = lastBigScenePlayerPosition;
			}
			else
			{
				this.PlayerWorldPosition = characterActorComponent.ActorLocationProxy;
			}
			Vector2D vector2D = Vector2D.Create(this.PlayerWorldPosition.X, this.PlayerWorldPosition.Y);
			this.PlayerUiPosition = MapUtil.WorldPosition2UiPosition2D(vector2D, vector2D);
			this.PlayerRotation = -(characterActorComponent.ActorRotation.Yaw + 90f);
		}
	}
}
