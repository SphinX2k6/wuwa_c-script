using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B12 RID: 6930
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchCardDataComponent)]
public class FloroRanchCardDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600CD9E RID: 52638 RVA: 0x002ED418 File Offset: 0x002EB618
	public override void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		if (entityData.Type != FloroRanchActionUnitType.Phantom)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchCardDataComponent刷新数据类型错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityType", entityData.Type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FloroRanchCardData floroRanchCardData = FloroRanchModel.Instance.GetFloroRanchCardData(entityData.Id);
		this.CardData = floroRanchCardData;
		this.RefreshEvolveData(entityData.EvolveData);
	}

	// Token: 0x0600CD9F RID: 52639 RVA: 0x002ED487 File Offset: 0x002EB687
	[NullableContext(2)]
	public void RefreshEvolveData(FREvolveData evolveData)
	{
		if (this.EvolveData == null)
		{
			if (evolveData != null)
			{
				this.EvolveData = new FloroRanchEvolveData(evolveData);
				return;
			}
		}
		else
		{
			this.EvolveData.Refresh(evolveData);
		}
	}

	// Token: 0x0600CDA0 RID: 52640 RVA: 0x002ED4AD File Offset: 0x002EB6AD
	public bool EvolveDataValid()
	{
		return this.EvolveData != null && this.EvolveData.IsValid;
	}

	// Token: 0x0600CDA1 RID: 52641 RVA: 0x002ED4C4 File Offset: 0x002EB6C4
	public override string Info()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CardData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.CardData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600CDA2 RID: 52642 RVA: 0x002ED514 File Offset: 0x002EB714
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CardData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.CardData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04005E4D RID: 24141
	[Nullable(2)]
	public FloroRanchCardData CardData;

	// Token: 0x04005E4E RID: 24142
	[Nullable(2)]
	public FloroRanchEvolveData EvolveData;
}
