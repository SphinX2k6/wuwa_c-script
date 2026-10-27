using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B19 RID: 6937
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchTerrainDataComponent)]
public class FloroRanchTerrainDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600CDCC RID: 52684 RVA: 0x002EDEBC File Offset: 0x002EC0BC
	public override void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		if (entityData.Type != FloroRanchActionUnitType.Terrain)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTerrainDataComponent刷新数据类型错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityType", entityData.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FloroRanchTerrainData floroRanchTerrain = FloroRanchModel.Instance.GetFloroRanchTerrain(entityData.Id);
		this.TerrainData = floroRanchTerrain;
	}

	// Token: 0x0600CDCD RID: 52685 RVA: 0x002EDF1E File Offset: 0x002EC11E
	public override string Info()
	{
		return "Name:" + this.TerrainData.Name;
	}

	// Token: 0x0600CDCE RID: 52686 RVA: 0x002EDF35 File Offset: 0x002EC135
	public override string DebugInfo()
	{
		return this.TerrainData.Name ?? "";
	}

	// Token: 0x04005E65 RID: 24165
	[Nullable(2)]
	public FloroRanchTerrainData TerrainData;
}
