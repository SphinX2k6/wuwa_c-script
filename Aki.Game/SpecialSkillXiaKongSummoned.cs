using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200319C RID: 12700
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXiaKongSummoned
{
	// Token: 0x0601B59A RID: 112026 RVA: 0x00778AF8 File Offset: 0x00776CF8
	public void Init(EntityHandle entityHandle)
	{
		if (entityHandle.Valid && entityHandle.Entity != null)
		{
			this.EntityHandle = entityHandle;
			this.AnimComp = entityHandle.Entity.GetComponent<CharacterAnimationComponent>();
			EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0601B59B RID: 112027 RVA: 0x00778B50 File Offset: 0x00776D50
	public void Destroy()
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (((entityHandle != null) ? entityHandle.Entity : null) != null)
		{
			EventSystem.Instance.RemoveWithTarget(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
		this.EntityHandle = null;
		this.AnimComp = null;
	}

	// Token: 0x0601B59C RID: 112028 RVA: 0x00778BA1 File Offset: 0x00776DA1
	private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
	{
		this.Destroy();
	}

	// Token: 0x0400D602 RID: 54786
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400D603 RID: 54787
	[Nullable(2)]
	public CharacterAnimationComponent AnimComp;
}
