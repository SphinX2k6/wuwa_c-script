using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F0 RID: 25584
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourPlayerMarkItem : UiPanelBase
	{
		// Token: 0x060405A0 RID: 263584 RVA: 0x00F9098C File Offset: 0x00F8EB8C
		public void UpdatePosition(float scale, Vector2D centerOffset)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				return;
			}
			Vector vector = GeneralLogicTreeUtil.Instance.GetPlayerLocation() ?? Vector.ZeroVectorProxy;
			Vector2D vector2D = MapUtil.WorldPosition2UiPosition2D(new Vector2D(vector.X, vector.Y), null);
			Vector2D vector2D2 = Vector2D.Create();
			vector2D.Multiply((double)scale, vector2D2).Subtraction(centerOffset, vector2D2);
			this.SetAnchorOffset(vector2D2, null);
			int num = 90;
			float num2 = -(component.ActorRotationProxy.Yaw + (float)num);
			if (Math.Abs(this.TempPlayerRotator.Yaw - num2) > 10f)
			{
				this.TempPlayerRotator.Yaw = num2;
				this.RootItem.SetUIRelativeRotation(this.TempPlayerRotator);
			}
		}

		// Token: 0x060405A1 RID: 263585 RVA: 0x00F90A60 File Offset: 0x00F8EC60
		public void UpdateOthersPosition(float scale, Vector2D centerOffset)
		{
			if (this.PlayerId == 0)
			{
				base.SetUiActive(false);
				return;
			}
			ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(this.PlayerId);
			Vector vector = (scenePlayerData != null) ? scenePlayerData.GetLocation() : null;
			if (vector == null || vector.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			Vector2D vector2D = MapUtil.WorldPosition2UiPosition2D(new Vector2D(vector.X, vector.Y), null);
			Vector2D vector2D2 = Vector2D.Create();
			vector2D.Multiply((double)scale, vector2D2).Subtraction(centerOffset, vector2D2);
			this.SetAnchorOffset(vector2D2, null);
		}

		// Token: 0x060405A2 RID: 263586 RVA: 0x00F90AF8 File Offset: 0x00F8ECF8
		public void SetAnchorOffset(Vector2D value, [Nullable(new byte[]
		{
			2,
			1
		})] List<UUIItem> relativeItems = null)
		{
			if (!value.Equals(this.CurrentAnchorOffset, 9.999999747378752E-05))
			{
				UUIItem rootItem = base.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetAnchorOffset(value.ToUeVector2D(false));
				}
				if (relativeItems != null)
				{
					foreach (UUIItem uuiitem in relativeItems)
					{
						uuiitem.SetAnchorOffset(value.ToUeVector2D(false));
					}
				}
				this.CurrentAnchorOffset.Set(value.X, value.Y);
			}
		}

		// Token: 0x04021794 RID: 137108
		private const int PLAYER_ROTATE_UPDATE_THRESHOLD = 10;

		// Token: 0x04021795 RID: 137109
		public int PlayerId;

		// Token: 0x04021796 RID: 137110
		private readonly Vector2D CurrentAnchorOffset = Vector2D.Create(0.0, 0.0);

		// Token: 0x04021797 RID: 137111
		private FRotator TempPlayerRotator = new FRotator(0f, 0f, 0f);
	}
}
