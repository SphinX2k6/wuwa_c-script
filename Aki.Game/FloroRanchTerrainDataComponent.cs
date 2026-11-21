using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FD8 RID: 4056
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchTerrainDataComponent)]
public class FloroRanchTerrainDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600A1DD RID: 41437 RVA: 0x002F8F9C File Offset: 0x002F719C
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

	// Token: 0x0600A1DE RID: 41438 RVA: 0x002F8FFE File Offset: 0x002F71FE
	public override string Info()
	{
		return "Name:" + this.TerrainData.Name;
	}

	// Token: 0x0600A1DF RID: 41439 RVA: 0x002F9015 File Offset: 0x002F7215
	public override string DebugInfo()
	{
		return this.TerrainData.Name ?? "";
	}

	// Token: 0x04005F34 RID: 24372
	[Nullable(2)]
	public FloroRanchTerrainData TerrainData;
}
