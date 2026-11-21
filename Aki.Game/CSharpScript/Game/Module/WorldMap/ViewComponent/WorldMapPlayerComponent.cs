using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E3 RID: 14051
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapPlayerComponent : MapComponent
	{
		// Token: 0x060248D6 RID: 149718 RVA: 0x00A53F0C File Offset: 0x00A5210C
		public WorldMapPlayerComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x060248D7 RID: 149719 RVA: 0x00A53F32 File Offset: 0x00A52132
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapPlayer;
			}
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x060248D8 RID: 149720 RVA: 0x00A53F35 File Offset: 0x00A52135
		// (set) Token: 0x060248D9 RID: 149721 RVA: 0x00A53F3D File Offset: 0x00A5213D
		public Vector2D PlayerUiPosition { get; private set; } = Vector2D.Create(0.0, 0.0);

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x060248DA RID: 149722 RVA: 0x00A53F46 File Offset: 0x00A52146
		// (set) Token: 0x060248DB RID: 149723 RVA: 0x00A53F4E File Offset: 0x00A5214E
		public Vector PlayerWorldPosition { get; private set; }

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x060248DC RID: 149724 RVA: 0x00A53F57 File Offset: 0x00A52157
		// (set) Token: 0x060248DD RID: 149725 RVA: 0x00A53F5F File Offset: 0x00A5215F
		public float PlayerRotation { get; set; }

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x060248DE RID: 149726 RVA: 0x00A53F68 File Offset: 0x00A52168
		// (set) Token: 0x060248DF RID: 149727 RVA: 0x00A53F70 File Offset: 0x00A52170
		public bool PlayerOutOfBound { get; set; }

		// Token: 0x060248E0 RID: 149728 RVA: 0x00A53F7C File Offset: 0x00A5217C
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
