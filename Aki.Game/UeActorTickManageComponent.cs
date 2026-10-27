using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02003278 RID: 12920
[NullableContext(1)]
[Nullable(0)]
public class UeActorTickManageComponent : EntityComponent, IComponentDependency
{
	// Token: 0x17002696 RID: 9878
	// (get) Token: 0x0601BF5B RID: 114523 RVA: 0x007C3447 File Offset: 0x007C1647
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x0601BF5C RID: 114524 RVA: 0x007C345C File Offset: 0x007C165C
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		return true;
	}

	// Token: 0x0601BF5D RID: 114525 RVA: 0x007C3470 File Offset: 0x007C1670
	protected override void OnActivate()
	{
		this.ActorComp.Owner.SetKuroOnlyTickOutside(true);
	}

	// Token: 0x0601BF5E RID: 114526 RVA: 0x007C3484 File Offset: 0x007C1684
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

	// Token: 0x0601BF5F RID: 114527 RVA: 0x007C3594 File Offset: 0x007C1794
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

	// Token: 0x0601BF60 RID: 114528 RVA: 0x007C36E0 File Offset: 0x007C18E0
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

	// Token: 0x0601BF61 RID: 114529 RVA: 0x007C382C File Offset: 0x007C1A2C
	public string DumpDisableTickInfo()
	{
		return base.DumpDisableInfo();
	}

	// Token: 0x0601BF62 RID: 114530 RVA: 0x007C3834 File Offset: 0x007C1A34
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeActorTickManageComponent ueActorTickManageComponent = (UeActorTickManageComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (ueActorTickManageComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DCDF RID: 56543
	[Nullable(2)]
	private BaseActorComponent ActorComp;
}
