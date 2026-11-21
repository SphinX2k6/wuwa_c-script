using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200270A RID: 9994
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXiaKongSummoned
{
	// Token: 0x060190BA RID: 102586 RVA: 0x007A0D84 File Offset: 0x0079EF84
	public void Init(EntityHandle entityHandle)
	{
		if (entityHandle.Valid && entityHandle.Entity != null)
		{
			this.EntityHandle = entityHandle;
			this.AnimComp = entityHandle.Entity.GetComponent<CharacterAnimationComponent>();
			EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x060190BB RID: 102587 RVA: 0x007A0DDC File Offset: 0x0079EFDC
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

	// Token: 0x060190BC RID: 102588 RVA: 0x007A0E2D File Offset: 0x0079F02D
	private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
	{
		this.Destroy();
	}

	// Token: 0x0400DA85 RID: 55941
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400DA86 RID: 55942
	[Nullable(2)]
	public CharacterAnimationComponent AnimComp;
}
