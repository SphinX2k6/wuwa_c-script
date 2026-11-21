using System;
using System.Runtime.CompilerServices;

// Token: 0x0200274D RID: 10061
[NullableContext(1)]
[Nullable(0)]
public class PerformActionChangeMaterial : PerformAction
{
	// Token: 0x06019409 RID: 103433 RVA: 0x007B683C File Offset: 0x007B4A3C
	public override void Register(Entity entity)
	{
		base.Register(entity);
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		this.NpcMatController = component.MaterialController;
	}

	// Token: 0x0601940A RID: 103434 RVA: 0x007B6863 File Offset: 0x007B4A63
	public override void UnRegister()
	{
		this.NpcMatController = null;
		base.UnRegister();
	}

	// Token: 0x0601940B RID: 103435 RVA: 0x007B6872 File Offset: 0x007B4A72
	public override void Begin()
	{
		if (this.Entity == null)
		{
			return;
		}
		if (this.DaPath == "")
		{
			return;
		}
		this.Handle = this.NpcMatController.ApplyMaterialEffect(this.DaPath);
	}

	// Token: 0x0601940C RID: 103436 RVA: 0x007B68A7 File Offset: 0x007B4AA7
	public override void End()
	{
		if (this.Entity == null)
		{
			return;
		}
		if (this.DaPath == "")
		{
			return;
		}
		this.NpcMatController.RemoveMaterialEffect(this.Handle);
		this.Handle = 0;
	}

	// Token: 0x0400DCF3 RID: 56563
	public new EPerformActionType Type = EPerformActionType.ChangeMaterial;

	// Token: 0x0400DCF4 RID: 56564
	public string DaPath = "";

	// Token: 0x0400DCF5 RID: 56565
	public int Handle;

	// Token: 0x0400DCF6 RID: 56566
	[Nullable(2)]
	public NpcMaterialController NpcMatController;
}
