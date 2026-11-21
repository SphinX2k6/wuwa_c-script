using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FD1 RID: 4049
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchCardDataComponent)]
public class FloroRanchCardDataComponent : FloroRanchEntityDataBaseComponent
{
	// Token: 0x0600A1AF RID: 41391 RVA: 0x002F8504 File Offset: 0x002F6704
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

	// Token: 0x0600A1B0 RID: 41392 RVA: 0x002F8573 File Offset: 0x002F6773
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

	// Token: 0x0600A1B1 RID: 41393 RVA: 0x002F8599 File Offset: 0x002F6799
	public bool EvolveDataValid()
	{
		return this.EvolveData != null && this.EvolveData.IsValid;
	}

	// Token: 0x0600A1B2 RID: 41394 RVA: 0x002F85B0 File Offset: 0x002F67B0
	public override string Info()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CardData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.CardData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600A1B3 RID: 41395 RVA: 0x002F8600 File Offset: 0x002F6800
	public override string DebugInfo()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CardData.Id);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(this.CardData.Name);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04005F1C RID: 24348
	[Nullable(2)]
	public FloroRanchCardData CardData;

	// Token: 0x04005F1D RID: 24349
	[Nullable(2)]
	public FloroRanchEvolveData EvolveData;
}
