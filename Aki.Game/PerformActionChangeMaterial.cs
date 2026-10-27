using System;
using System.Runtime.CompilerServices;

// Token: 0x020031DE RID: 12766
[NullableContext(1)]
[Nullable(0)]
public class PerformActionChangeMaterial : PerformAction
{
	// Token: 0x0601B890 RID: 112784 RVA: 0x0078DF44 File Offset: 0x0078C144
	public override void Register(Entity entity)
	{
		base.Register(entity);
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		this.NpcMatController = component.MaterialController;
	}

	// Token: 0x0601B891 RID: 112785 RVA: 0x0078DF6B File Offset: 0x0078C16B
	public override void UnRegister()
	{
		this.NpcMatController = null;
		base.UnRegister();
	}

	// Token: 0x0601B892 RID: 112786 RVA: 0x0078DF7A File Offset: 0x0078C17A
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

	// Token: 0x0601B893 RID: 112787 RVA: 0x0078DFAF File Offset: 0x0078C1AF
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

	// Token: 0x0400D855 RID: 55381
	public new EPerformActionType Type = EPerformActionType.ChangeMaterial;

	// Token: 0x0400D856 RID: 55382
	public string DaPath = "";

	// Token: 0x0400D857 RID: 55383
	public int Handle;

	// Token: 0x0400D858 RID: 55384
	[Nullable(2)]
	public NpcMaterialController NpcMatController;
}
