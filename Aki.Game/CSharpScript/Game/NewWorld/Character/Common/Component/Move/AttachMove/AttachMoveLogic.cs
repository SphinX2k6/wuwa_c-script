using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x020063B6 RID: 25526
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachMoveLogic
	{
		// Token: 0x0603DE35 RID: 253493 RVA: 0x011F6697 File Offset: 0x011F4897
		public virtual bool IsMoving()
		{
			return this.InState;
		}

		// Token: 0x0603DE36 RID: 253494 RVA: 0x011F669F File Offset: 0x011F489F
		public virtual void UpdateMove(float deltaSeconds)
		{
		}

		// Token: 0x0603DE37 RID: 253495 RVA: 0x011F66A1 File Offset: 0x011F48A1
		public virtual void StopMoveWithCallback(ELevelEventState result)
		{
			this.StopMove();
		}

		// Token: 0x0603DE38 RID: 253496 RVA: 0x011F66AC File Offset: 0x011F48AC
		public virtual void StopMove()
		{
			if (!this.InState)
			{
				return;
			}
			if (this.AttachHelper != null)
			{
				this.AttachHelper.DetachFromLeader();
			}
			BaseTagComponent tagComp = this.TagComp;
			AttachMoveParams @params = this.Params;
			this.RemoveTags(tagComp, (@params != null) ? @params.GameplayTagList : null);
			this.InState = false;
			this.Params = null;
			this.TagComp = null;
			this.AttachHelper = null;
			Action exitCallback = this.ExitCallback;
			this.ExitCallback = null;
			if (exitCallback == null)
			{
				return;
			}
			exitCallback();
		}

		// Token: 0x0603DE39 RID: 253497 RVA: 0x011F6726 File Offset: 0x011F4926
		public virtual void Dispose()
		{
			this.StopMove();
		}

		// Token: 0x0603DE3A RID: 253498 RVA: 0x011F672E File Offset: 0x011F492E
		[NullableContext(1)]
		public void StartHelpedAttachMoveWithData(Entity entity, CharacterActorComponent leader, BP_AttachMoveConfig_C data, [Nullable(2)] Action endCallback = null)
		{
			if (this.InState)
			{
				this.StopMove();
			}
			this.PrepareAttachMove(entity, data, endCallback);
			this.AddTags(this.TagComp, this.Params.GameplayTagList);
			this.ExecuteAttach(entity, leader);
		}

		// Token: 0x0603DE3B RID: 253499 RVA: 0x011F6768 File Offset: 0x011F4968
		[NullableContext(1)]
		protected void PrepareAttachMove(Entity entity, BP_AttachMoveConfig_C data, [Nullable(2)] Action endCallback = null)
		{
			this.Params = new AttachMoveParams(data);
			this.TagComp = entity.GetComponent<BaseTagComponent>();
			this.ExitCallback = endCallback;
			this.InState = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] PrepareAttachMove";
			string item = "PbDataId";
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.CreatureData.GetPbDataId()) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603DE3C RID: 253500 RVA: 0x011F67EC File Offset: 0x011F49EC
		[NullableContext(1)]
		protected bool ExecuteAttach(Entity entity, CharacterActorComponent leader)
		{
			if (this.Params == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.CWZ, "[AttachMove] ExecuteAttach 未 Prepare", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.AttachHelper = new FollowerAttachHelper();
			this.AttachHelper.Init(entity);
			if (!this.AttachHelper.AttachToLeader(leader, this.Params.AttachSocket, this.Params.AttachTransform))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.CWZ, "[AttachMove] ExecuteAttach Attach 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.RemoveTags(this.TagComp, this.Params.GameplayTagList);
				this.AttachHelper = null;
				this.Params = null;
				this.TagComp = null;
				this.InState = false;
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove] ExecuteAttach";
			string item = "PbDataId";
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.CreatureData.GetPbDataId()) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x0603DE3D RID: 253501 RVA: 0x011F68FB File Offset: 0x011F4AFB
		public virtual void StartAssistedWalk()
		{
		}

		// Token: 0x0603DE3E RID: 253502 RVA: 0x011F68FD File Offset: 0x011F4AFD
		public virtual void EnterAssistedWalkIdle()
		{
		}

		// Token: 0x0603DE3F RID: 253503 RVA: 0x011F68FF File Offset: 0x011F4AFF
		public virtual void EnterAssistedWalking()
		{
		}

		// Token: 0x0603DE40 RID: 253504 RVA: 0x011F6901 File Offset: 0x011F4B01
		public virtual void LeftAssistedWalking()
		{
		}

		// Token: 0x0603DE41 RID: 253505 RVA: 0x011F6904 File Offset: 0x011F4B04
		protected void AddTags(BaseTagComponent tagComp, List<int> tagList)
		{
			if (tagComp == null || this.Params == null || tagList == null || tagList.Count == 0)
			{
				return;
			}
			foreach (int tagId in tagList)
			{
				this.SetOnlyTag(tagComp, tagId, true, "AddTags");
			}
		}

		// Token: 0x0603DE42 RID: 253506 RVA: 0x011F6970 File Offset: 0x011F4B70
		protected void RemoveTags(BaseTagComponent tagComp, List<int> tagList)
		{
			if (tagComp == null || this.Params == null || tagList == null || tagList.Count == 0)
			{
				return;
			}
			foreach (int tagId in tagList)
			{
				this.SetOnlyTag(tagComp, tagId, false, "RemoveTags");
			}
		}

		// Token: 0x0603DE43 RID: 253507 RVA: 0x011F69DC File Offset: 0x011F4BDC
		[NullableContext(1)]
		protected void SetOnlyTag([Nullable(2)] BaseTagComponent tagComp, int tagId, bool add, string context)
		{
			if (tagComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove] SetOnlyTag tagComp 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Context", context);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (add && !tagComp.HasTag(tagId))
			{
				tagComp.AddTag(new int?(tagId));
				return;
			}
			if (!add && tagComp.HasTag(tagId))
			{
				tagComp.RemoveTag(new int?(tagId));
			}
		}

		// Token: 0x04020DD9 RID: 134617
		protected bool InState;

		// Token: 0x04020DDA RID: 134618
		protected Action ExitCallback;

		// Token: 0x04020DDB RID: 134619
		protected AttachMoveParams Params;

		// Token: 0x04020DDC RID: 134620
		protected BaseTagComponent TagComp;

		// Token: 0x04020DDD RID: 134621
		protected FollowerAttachHelper AttachHelper;
	}
}
