using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FD9 RID: 4057
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchToyDataComponent)]
public class FloroRanchToyDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600A1E1 RID: 41441 RVA: 0x002F9034 File Offset: 0x002F7234
	public override void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		if (entityData.Type != FloroRanchActionUnitType.Toy)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchToyDataComponent刷新数据类型错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityType", entityData.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FloroRanchToyData floroRanchToyData = FloroRanchModel.Instance.GetFloroRanchToyData(entityData.Id);
		this.ToyData = floroRanchToyData;
		this.Level = (int)MathUtils.Instance.LongToBigInt(entityData.ToyLv);
	}

	// Token: 0x0600A1E2 RID: 41442 RVA: 0x002F90AE File Offset: 0x002F72AE
	public void RefreshLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x0600A1E3 RID: 41443 RVA: 0x002F90B7 File Offset: 0x002F72B7
	public override string Info()
	{
		return "Name:" + this.ToyData.Name;
	}

	// Token: 0x0600A1E4 RID: 41444 RVA: 0x002F90D0 File Offset: 0x002F72D0
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ToyData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.ToyData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04005F35 RID: 24373
	[Nullable(2)]
	public FloroRanchToyData ToyData;

	// Token: 0x04005F36 RID: 24374
	public int Level;
}
