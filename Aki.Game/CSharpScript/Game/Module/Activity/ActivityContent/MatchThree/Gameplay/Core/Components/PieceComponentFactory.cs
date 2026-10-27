using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x0200653C RID: 25916
	public static class PieceComponentFactory
	{
		// Token: 0x06040F36 RID: 266038 RVA: 0x00FBCCE0 File Offset: 0x00FBAEE0
		[NullableContext(2)]
		public unsafe static IPieceComponent Create(int componentId)
		{
			MatchThreeComponent? componentConfig = MatchThreeConfig.Instance.GetComponentConfig(componentId);
			if (componentConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "组件配置缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", componentId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EPieceComponentType type = (EPieceComponentType)componentConfig.Value.Type;
			switch (type)
			{
			case EPieceComponentType.Fallable:
				return new FallableComponent();
			case EPieceComponentType.Swappable:
				return new SwappableComponent();
			case EPieceComponentType.Bomb:
				return new BombComponent(componentConfig.Value.Params(0), componentConfig.Value.Params(1));
			case EPieceComponentType.Ultimate:
				return new UltimateComponent();
			case EPieceComponentType.AdjacentBreak:
				return new AdjacentBreakComponent();
			case EPieceComponentType.LandRemove:
				return new LandRemoveComponent();
			case EPieceComponentType.TurnGain:
				return new TurnGainComponent(componentConfig.Value.Params(0));
			case EPieceComponentType.ChargeGain:
				return new ChargeGainComponent(componentConfig.Value.Params(0));
			case EPieceComponentType.CrossClear:
				return new CrossClearComponent();
			case EPieceComponentType.Matchable:
				return new MatchableComponent();
			case EPieceComponentType.Block:
				return new BlockComponent();
			case EPieceComponentType.Chain:
				return new ChainComponent(componentConfig.Value.Params(0));
			case EPieceComponentType.Clearable:
				return new ClearableComponent();
			case EPieceComponentType.Health:
				return new HealthComponent(componentConfig.Value.Params(0));
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.MatchThree;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "未知组件类型";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", (int)type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", componentId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x06040F37 RID: 266039 RVA: 0x00FBCEA8 File Offset: 0x00FBB0A8
		[NullableContext(1)]
		public static EPieceComponentType GetComponentType(IPieceComponent comp)
		{
			if (comp is FallableComponent)
			{
				return EPieceComponentType.Fallable;
			}
			if (comp is SwappableComponent)
			{
				return EPieceComponentType.Swappable;
			}
			if (comp is BlockComponent)
			{
				return EPieceComponentType.Block;
			}
			if (comp is LandRemoveComponent)
			{
				return EPieceComponentType.LandRemove;
			}
			if (comp is UltimateComponent)
			{
				return EPieceComponentType.Ultimate;
			}
			if (comp is CrossClearComponent)
			{
				return EPieceComponentType.CrossClear;
			}
			if (comp is ClearableComponent)
			{
				return EPieceComponentType.Clearable;
			}
			if (comp is MatchableComponent)
			{
				return EPieceComponentType.Matchable;
			}
			if (comp is AdjacentBreakComponent)
			{
				return EPieceComponentType.AdjacentBreak;
			}
			if (comp is HealthComponent)
			{
				return EPieceComponentType.Health;
			}
			if (comp is ChargeGainComponent)
			{
				return EPieceComponentType.ChargeGain;
			}
			if (comp is TurnGainComponent)
			{
				return EPieceComponentType.TurnGain;
			}
			if (comp is BombComponent)
			{
				return EPieceComponentType.Bomb;
			}
			if (comp is ChainComponent)
			{
				return EPieceComponentType.Chain;
			}
			return (EPieceComponentType)0;
		}
	}
}
