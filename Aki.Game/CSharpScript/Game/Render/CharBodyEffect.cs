using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200459D RID: 17821
	[NullableContext(1)]
	[Nullable(0)]
	public class CharBodyEffect : CharRenderBase
	{
		// Token: 0x0602DF1C RID: 188188 RVA: 0x00A90F3E File Offset: 0x00A8F13E
		public override string GetStatName()
		{
			return "CharBodyEffect";
		}

		// Token: 0x0602DF1D RID: 188189 RVA: 0x00A90F45 File Offset: 0x00A8F145
		public override int GetComponentId()
		{
			return 9;
		}

		// Token: 0x0602DF1E RID: 188190 RVA: 0x00A90F49 File Offset: 0x00A8F149
		public override void Awake(CharRenderingComponent renderComponent)
		{
			base.Awake(renderComponent);
		}

		// Token: 0x0602DF1F RID: 188191 RVA: 0x00A90F54 File Offset: 0x00A8F154
		private void OnEffectFinish(int handleId)
		{
			int num = this.EffectHandles.IndexOf(handleId);
			if (num < 0)
			{
				return;
			}
			this.EffectHandles.RemoveAt(num);
			EffectSystem.Instance.RemoveFinishCallback(handleId, new Action<int>(this.OnEffectFinish));
		}

		// Token: 0x0602DF20 RID: 188192 RVA: 0x00A90F98 File Offset: 0x00A8F198
		public void RegisterEffect(int handleId)
		{
			if (this.EffectHandles.IndexOf(handleId) >= 0)
			{
				EffectSystem.Instance.UpdateBodyEffect(handleId, this.Opacity, this.Visible, this.CastShadow);
				return;
			}
			this.EffectHandles.Add(handleId);
			if (this.Opacity != 1f || !this.Visible || !this.CastShadow)
			{
				EffectSystem.Instance.UpdateBodyEffect(handleId, this.Opacity, this.Visible, this.CastShadow);
			}
			EffectSystem.Instance.AddFinishCallback(handleId, new Action<int>(this.OnEffectFinish));
		}

		// Token: 0x0602DF21 RID: 188193 RVA: 0x00A91030 File Offset: 0x00A8F230
		public void UnregisterEffect(int handleId)
		{
			int num = this.EffectHandles.IndexOf(handleId);
			if (num < 0)
			{
				return;
			}
			EffectSystem.Instance.UpdateBodyEffect(handleId, 1f, true, true);
			this.EffectHandles.RemoveAt(num);
			EffectSystem.Instance.RemoveFinishCallback(handleId, new Action<int>(this.OnEffectFinish));
		}

		// Token: 0x0602DF22 RID: 188194 RVA: 0x00A91084 File Offset: 0x00A8F284
		public override void Start()
		{
			this.Opacity = 1f;
			for (int i = 0; i < 3; i++)
			{
				this.PendingOpacityList[i] = 1f;
			}
			TsBaseCharacter tsBaseCharacter = base.GetRenderingComponent().GetOwner() as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				if (((characterActorComponent != null) ? characterActorComponent.Entity : null) != null)
				{
					this.Entity = tsBaseCharacter.CharacterActorComponent.Entity;
					this.Handle = CreatureModel.Instance.GetEntityById(this.Entity.Id);
					if (this.Handle != null)
					{
						EventSystem.Instance.AddWithTarget(this.Handle, EEventName.OnSetActorHidden, new Action<int, bool>(this.OnSetActorVisible));
					}
					CharRenderingComponent renderingComponent = base.GetRenderingComponent();
					bool flag;
					if (renderingComponent == null)
					{
						flag = false;
					}
					else
					{
						ECharacterRenderingType? renderType = renderingComponent.RenderType;
						ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.LocalPlayer;
						flag = (renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null);
					}
					if (!flag)
					{
						CharRenderingComponent renderingComponent2 = base.GetRenderingComponent();
						bool flag2;
						if (renderingComponent2 == null)
						{
							flag2 = false;
						}
						else
						{
							ECharacterRenderingType? renderType = renderingComponent2.RenderType;
							ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.RemotePlayer;
							flag2 = (renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null);
						}
						if (!flag2)
						{
							goto IL_154;
						}
					}
					EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
					EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
					EventSystem.Instance.AddWithTarget(this.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnGoDownFinish));
				}
			}
			IL_154:
			base.OnInitSuccess();
		}

		// Token: 0x0602DF23 RID: 188195 RVA: 0x00A911EC File Offset: 0x00A8F3EC
		public override void Update()
		{
			if (this.NeedUpdate)
			{
				this.Visible = this.PendingVisible;
				this.Opacity = 1f;
				for (int i = 0; i < 3; i++)
				{
					this.Opacity = Math.Min(this.Opacity, this.PendingOpacityList[i]);
				}
				this.CastShadow = this.PendingCastShadow;
				foreach (int id in this.EffectHandles)
				{
					EffectSystem.Instance.UpdateBodyEffect(id, this.Opacity, this.Visible, this.CastShadow);
				}
				this.NeedUpdate = false;
			}
		}

		// Token: 0x0602DF24 RID: 188196 RVA: 0x00A912B0 File Offset: 0x00A8F4B0
		public override void LateUpdate()
		{
		}

		// Token: 0x0602DF25 RID: 188197 RVA: 0x00A912B4 File Offset: 0x00A8F4B4
		public override void Destroy()
		{
			if (this.Handle != null)
			{
				EventSystem.Instance.RemoveWithTarget(this.Handle, EEventName.OnSetActorHidden, new Action<int, bool>(this.OnSetActorVisible));
			}
			if (this.Entity != null)
			{
				CharRenderingComponent renderingComponent = base.GetRenderingComponent();
				bool flag;
				if (renderingComponent == null)
				{
					flag = false;
				}
				else
				{
					ECharacterRenderingType? renderType = renderingComponent.RenderType;
					ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.LocalPlayer;
					flag = (renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null);
				}
				if (!flag)
				{
					CharRenderingComponent renderingComponent2 = base.GetRenderingComponent();
					bool flag2;
					if (renderingComponent2 == null)
					{
						flag2 = false;
					}
					else
					{
						ECharacterRenderingType? renderType = renderingComponent2.RenderType;
						ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.RemotePlayer;
						flag2 = (renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null);
					}
					if (!flag2)
					{
						return;
					}
				}
				EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
				EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
				EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnGoDownFinish));
			}
		}

		// Token: 0x0602DF26 RID: 188198 RVA: 0x00A913A4 File Offset: 0x00A8F5A4
		public void SetOpacity(float opacity, ECharBodyEffectOpacityType type = ECharBodyEffectOpacityType.Default)
		{
			if (!this.NeedUpdate && MathUtils.Instance.IsNearlyEqual((double)this.PendingOpacityList[(int)type], (double)opacity, null))
			{
				return;
			}
			this.PendingOpacityList[(int)type] = opacity;
			this.NeedUpdate = true;
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.Update();
			}, null, null);
		}

		// Token: 0x0602DF27 RID: 188199 RVA: 0x00A91403 File Offset: 0x00A8F603
		public float GetOpacityConsiderVisibility()
		{
			if (!this.Visible)
			{
				return 0f;
			}
			return this.Opacity;
		}

		// Token: 0x0602DF28 RID: 188200 RVA: 0x00A91419 File Offset: 0x00A8F619
		private void SetVisible(bool visible)
		{
			if (this.NeedUpdate || this.Visible != visible)
			{
				this.PendingVisible = visible;
				this.NeedUpdate = true;
				TimerSystem.Instance.Next(delegate(float _)
				{
					this.Update();
				}, null, null);
			}
		}

		// Token: 0x0602DF29 RID: 188201 RVA: 0x00A91453 File Offset: 0x00A8F653
		public void SetCastShadow(bool castShadow)
		{
			if (this.NeedUpdate || this.CastShadow != castShadow)
			{
				this.PendingCastShadow = castShadow;
				this.NeedUpdate = true;
				TimerSystem.Instance.Next(delegate(float _)
				{
					this.Update();
				}, null, null);
			}
		}

		// Token: 0x0602DF2A RID: 188202 RVA: 0x00A9148D File Offset: 0x00A8F68D
		protected void OnSetActorVisible(int id, bool visible)
		{
			if (this.Entity != null && id != this.Entity.Id)
			{
				return;
			}
			this.SetVisible(visible);
		}

		// Token: 0x0602DF2B RID: 188203 RVA: 0x00A914B0 File Offset: 0x00A8F6B0
		private void OnChangeTeam()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
			{
				if (sceneTeamItem.IsControl())
				{
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					if (((entityHandle != null) ? entityHandle.Entity : null) == this.Entity)
					{
						return;
					}
				}
			}
			this.SetVisible(false);
		}

		// Token: 0x0602DF2C RID: 188204 RVA: 0x00A9152C File Offset: 0x00A8F72C
		private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			WorldEntity entity = newEntityHandle.Entity;
			Entity entity2 = this.Entity;
		}

		// Token: 0x0602DF2D RID: 188205 RVA: 0x00A9153C File Offset: 0x00A8F73C
		private void OnGoDownFinish()
		{
			this.SetVisible(false);
		}

		// Token: 0x0401887A RID: 100474
		[Nullable(2)]
		protected Entity Entity;

		// Token: 0x0401887B RID: 100475
		[Nullable(2)]
		private EntityHandle Handle;

		// Token: 0x0401887C RID: 100476
		protected bool CastShadow = true;

		// Token: 0x0401887D RID: 100477
		protected bool Visible = true;

		// Token: 0x0401887E RID: 100478
		protected float Opacity = 1f;

		// Token: 0x0401887F RID: 100479
		protected bool PendingCastShadow = true;

		// Token: 0x04018880 RID: 100480
		protected bool PendingVisible = true;

		// Token: 0x04018881 RID: 100481
		protected float[] PendingOpacityList = new float[3];

		// Token: 0x04018882 RID: 100482
		protected List<int> EffectHandles = new List<int>();

		// Token: 0x04018883 RID: 100483
		protected bool NeedUpdate;
	}
}
