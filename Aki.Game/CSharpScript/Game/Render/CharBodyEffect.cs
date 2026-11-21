using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C5 RID: 13509
	[NullableContext(1)]
	[Nullable(0)]
	public class CharBodyEffect : CharRenderBase
	{
		// Token: 0x06022606 RID: 140806 RVA: 0x009BD15E File Offset: 0x009BB35E
		public override string GetStatName()
		{
			return "CharBodyEffect";
		}

		// Token: 0x06022607 RID: 140807 RVA: 0x009BD165 File Offset: 0x009BB365
		public override int GetComponentId()
		{
			return 9;
		}

		// Token: 0x06022608 RID: 140808 RVA: 0x009BD169 File Offset: 0x009BB369
		public override void Awake(CharRenderingComponent renderComponent)
		{
			base.Awake(renderComponent);
		}

		// Token: 0x06022609 RID: 140809 RVA: 0x009BD174 File Offset: 0x009BB374
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

		// Token: 0x0602260A RID: 140810 RVA: 0x009BD1B8 File Offset: 0x009BB3B8
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

		// Token: 0x0602260B RID: 140811 RVA: 0x009BD250 File Offset: 0x009BB450
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

		// Token: 0x0602260C RID: 140812 RVA: 0x009BD2A4 File Offset: 0x009BB4A4
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

		// Token: 0x0602260D RID: 140813 RVA: 0x009BD40C File Offset: 0x009BB60C
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

		// Token: 0x0602260E RID: 140814 RVA: 0x009BD4D0 File Offset: 0x009BB6D0
		public override void LateUpdate()
		{
		}

		// Token: 0x0602260F RID: 140815 RVA: 0x009BD4D4 File Offset: 0x009BB6D4
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

		// Token: 0x06022610 RID: 140816 RVA: 0x009BD5C4 File Offset: 0x009BB7C4
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

		// Token: 0x06022611 RID: 140817 RVA: 0x009BD623 File Offset: 0x009BB823
		public float GetOpacityConsiderVisibility()
		{
			if (!this.Visible)
			{
				return 0f;
			}
			return this.Opacity;
		}

		// Token: 0x06022612 RID: 140818 RVA: 0x009BD639 File Offset: 0x009BB839
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

		// Token: 0x06022613 RID: 140819 RVA: 0x009BD673 File Offset: 0x009BB873
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

		// Token: 0x06022614 RID: 140820 RVA: 0x009BD6AD File Offset: 0x009BB8AD
		protected void OnSetActorVisible(int id, bool visible)
		{
			if (this.Entity != null && id != this.Entity.Id)
			{
				return;
			}
			this.SetVisible(visible);
		}

		// Token: 0x06022615 RID: 140821 RVA: 0x009BD6D0 File Offset: 0x009BB8D0
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

		// Token: 0x06022616 RID: 140822 RVA: 0x009BD74C File Offset: 0x009BB94C
		private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			WorldEntity entity = newEntityHandle.Entity;
			Entity entity2 = this.Entity;
		}

		// Token: 0x06022617 RID: 140823 RVA: 0x009BD75C File Offset: 0x009BB95C
		private void OnGoDownFinish()
		{
			this.SetVisible(false);
		}

		// Token: 0x04012EB5 RID: 77493
		[Nullable(2)]
		protected Entity Entity;

		// Token: 0x04012EB6 RID: 77494
		[Nullable(2)]
		private EntityHandle Handle;

		// Token: 0x04012EB7 RID: 77495
		protected bool CastShadow = true;

		// Token: 0x04012EB8 RID: 77496
		protected bool Visible = true;

		// Token: 0x04012EB9 RID: 77497
		protected float Opacity = 1f;

		// Token: 0x04012EBA RID: 77498
		protected bool PendingCastShadow = true;

		// Token: 0x04012EBB RID: 77499
		protected bool PendingVisible = true;

		// Token: 0x04012EBC RID: 77500
		protected float[] PendingOpacityList = new float[3];

		// Token: 0x04012EBD RID: 77501
		protected List<int> EffectHandles = new List<int>();

		// Token: 0x04012EBE RID: 77502
		protected bool NeedUpdate;
	}
}
