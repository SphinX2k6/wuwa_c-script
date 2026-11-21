using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020027E8 RID: 10216
[NullableContext(1)]
[Nullable(0)]
public class UeActorTickManageComponent : EntityComponent
{
	// Token: 0x1700293A RID: 10554
	// (get) Token: 0x06019B47 RID: 105287 RVA: 0x007EA82A File Offset: 0x007E8A2A
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x06019B48 RID: 105288 RVA: 0x007EA83F File Offset: 0x007E8A3F
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		return true;
	}

	// Token: 0x06019B49 RID: 105289 RVA: 0x007EA853 File Offset: 0x007E8A53
	protected override void OnActivate()
	{
		this.ActorComp.Owner.SetKuroOnlyTickOutside(true);
	}

	// Token: 0x06019B4A RID: 105290 RVA: 0x007EA868 File Offset: 0x007E8A68
	protected override void OnTick(float delta)
	{
		if (PerformanceController.Instance.IsOpenCatchWorldEntity)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 3);
			defaultInterpolatedStringHandler.AppendLiteral("DeltaSeconds: ");
			defaultInterpolatedStringHandler.AppendFormatted(base.Entity.GetDeltaSeconds().ToString("F2"));
			defaultInterpolatedStringHandler.AppendLiteral(", TickInterval: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(base.Entity.GetTickInterval());
			defaultInterpolatedStringHandler.AppendLiteral(", Distance: ");
			defaultInterpolatedStringHandler.AppendFormatted(base.Entity.DistanceWithCamera.ToString("F2"));
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			if (component != null)
			{
				bool isInFighting = component.IsInFighting;
				string str = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral(" IsInFight: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(isInFighting);
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Stat.CreateNoFlameGraph(text, "", "");
		}
		this.ActorComp.Owner.KuroTickActorOutside(delta * 0.001f);
	}

	// Token: 0x06019B4B RID: 105291 RVA: 0x007EA978 File Offset: 0x007E8B78
	public unsafe int DisableTickWithLog(string reason)
	{
		int num = base.Disable(reason);
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.ActorComp.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "DisableTick";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.ActorComp.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.ActorComp.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		return num;
	}

	// Token: 0x06019B4C RID: 105292 RVA: 0x007EAAC4 File Offset: 0x007E8CC4
	public unsafe bool EnableTickWithLog(int handle, string reason)
	{
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.ActorComp.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "EnableTick";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.ActorComp.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.ActorComp.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		return base.Enable(new int?(handle), reason);
	}

	// Token: 0x06019B4D RID: 105293 RVA: 0x007EAC10 File Offset: 0x007E8E10
	public string DumpDisableTickInfo()
	{
		return base.DumpDisableInfo();
	}

	// Token: 0x06019B4E RID: 105294 RVA: 0x007EAC18 File Offset: 0x007E8E18
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		if (((UeActorTickManageComponent)componentTemplate).ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x1700293B RID: 10555
	// (get) Token: 0x06019B4F RID: 105295 RVA: 0x007EAC56 File Offset: 0x007E8E56
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700293C RID: 10556
	// (get) Token: 0x06019B50 RID: 105296 RVA: 0x007EAC59 File Offset: 0x007E8E59
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E181 RID: 57729
	[Nullable(2)]
	private BaseActorComponent ActorComp;
}
