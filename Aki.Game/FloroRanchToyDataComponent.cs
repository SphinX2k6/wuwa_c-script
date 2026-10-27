using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B1A RID: 6938
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchToyDataComponent)]
public class FloroRanchToyDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600CDD0 RID: 52688 RVA: 0x002EDF54 File Offset: 0x002EC154
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

	// Token: 0x0600CDD1 RID: 52689 RVA: 0x002EDFCE File Offset: 0x002EC1CE
	public void RefreshLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x0600CDD2 RID: 52690 RVA: 0x002EDFD7 File Offset: 0x002EC1D7
	public override string Info()
	{
		return "Name:" + this.ToyData.Name;
	}

	// Token: 0x0600CDD3 RID: 52691 RVA: 0x002EDFF0 File Offset: 0x002EC1F0
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ToyData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.ToyData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04005E66 RID: 24166
	[Nullable(2)]
	public FloroRanchToyData ToyData;

	// Token: 0x04005E67 RID: 24167
	public int Level;
}
