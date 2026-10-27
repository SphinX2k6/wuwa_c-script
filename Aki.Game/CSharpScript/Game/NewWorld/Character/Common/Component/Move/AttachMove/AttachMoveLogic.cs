using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x02007106 RID: 28934
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachMoveLogic
	{
		// Token: 0x06046A36 RID: 289334 RVA: 0x011C7677 File Offset: 0x011C5877
		public virtual bool IsMoving()
		{
			return this.InState;
		}

		// Token: 0x06046A37 RID: 289335 RVA: 0x011C767F File Offset: 0x011C587F
		public virtual void UpdateMove(float deltaSeconds)
		{
		}

		// Token: 0x06046A38 RID: 289336 RVA: 0x011C7681 File Offset: 0x011C5881
		public virtual void StopMoveWithCallback(ELevelEventState result)
		{
			this.StopMove();
		}

		// Token: 0x06046A39 RID: 289337 RVA: 0x011C768C File Offset: 0x011C588C
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

		// Token: 0x06046A3A RID: 289338 RVA: 0x011C7706 File Offset: 0x011C5906
		public virtual void Dispose()
		{
			this.StopMove();
		}

		// Token: 0x06046A3B RID: 289339 RVA: 0x011C770E File Offset: 0x011C590E
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

		// Token: 0x06046A3C RID: 289340 RVA: 0x011C7748 File Offset: 0x011C5948
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

		// Token: 0x06046A3D RID: 289341 RVA: 0x011C77CC File Offset: 0x011C59CC
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

		// Token: 0x06046A3E RID: 289342 RVA: 0x011C78DB File Offset: 0x011C5ADB
		public virtual void StartAssistedWalk()
		{
		}

		// Token: 0x06046A3F RID: 289343 RVA: 0x011C78DD File Offset: 0x011C5ADD
		public virtual void EnterAssistedWalkIdle()
		{
		}

		// Token: 0x06046A40 RID: 289344 RVA: 0x011C78DF File Offset: 0x011C5ADF
		public virtual void EnterAssistedWalking()
		{
		}

		// Token: 0x06046A41 RID: 289345 RVA: 0x011C78E1 File Offset: 0x011C5AE1
		public virtual void LeftAssistedWalking()
		{
		}

		// Token: 0x06046A42 RID: 289346 RVA: 0x011C78E4 File Offset: 0x011C5AE4
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

		// Token: 0x06046A43 RID: 289347 RVA: 0x011C7950 File Offset: 0x011C5B50
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

		// Token: 0x06046A44 RID: 289348 RVA: 0x011C79BC File Offset: 0x011C5BBC
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

		// Token: 0x04025144 RID: 151876
		protected bool InState;

		// Token: 0x04025145 RID: 151877
		protected Action ExitCallback;

		// Token: 0x04025146 RID: 151878
		protected AttachMoveParams Params;

		// Token: 0x04025147 RID: 151879
		protected BaseTagComponent TagComp;

		// Token: 0x04025148 RID: 151880
		protected FollowerAttachHelper AttachHelper;
	}
}
