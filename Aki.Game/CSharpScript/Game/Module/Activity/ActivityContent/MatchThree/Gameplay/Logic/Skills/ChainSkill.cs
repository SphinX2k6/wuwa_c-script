using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02005482 RID: 21634
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class ChainSkill : ISkill
	{
		// Token: 0x06035B57 RID: 219991 RVA: 0x00F0235C File Offset: 0x00F0055C
		public ChainSkill(MatchThreeSkill cfg)
		{
			int[] chainExtra;
			if (cfg.Type != 4)
			{
				(chainExtra = new int[1])[0] = 15;
			}
			else
			{
				(chainExtra = new int[1])[0] = 16;
			}
			this.ChainExtra = chainExtra;
			this.Id = cfg.Id;
			this.EnergyNode = cfg.Energy;
			this.Icon = cfg.Icon;
			this.Name = cfg.Name;
			base..ctor();
		}

		// Token: 0x17006876 RID: 26742
		// (get) Token: 0x06035B58 RID: 219992 RVA: 0x00F023E8 File Offset: 0x00F005E8
		public int Id { get; }

		// Token: 0x17006877 RID: 26743
		// (get) Token: 0x06035B59 RID: 219993 RVA: 0x00F023F0 File Offset: 0x00F005F0
		public int EnergyNode { get; }

		// Token: 0x17006878 RID: 26744
		// (get) Token: 0x06035B5A RID: 219994 RVA: 0x00F023F8 File Offset: 0x00F005F8
		public string Icon { get; }

		// Token: 0x17006879 RID: 26745
		// (get) Token: 0x06035B5B RID: 219995 RVA: 0x00F02400 File Offset: 0x00F00600
		public string Name { get; }

		// Token: 0x1700687A RID: 26746
		// (get) Token: 0x06035B5C RID: 219996 RVA: 0x00F02408 File Offset: 0x00F00608
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Chain;
			}
		}

		// Token: 0x06035B5D RID: 219997 RVA: 0x00F0240C File Offset: 0x00F0060C
		[NullableContext(1)]
		public unsafe void Release(ISkillContext ctx)
		{
			if (this.Params.Length < 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[ChainSkill] 技能参数缺失（需 [个数]）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ParamCount", this.Params.Length);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			bool flag;
			IReadOnlyList<GridPosition> readOnlyList = ctx.PickChainCells(this.Params[0], out flag);
			for (int i = 0; i < readOnlyList.Count; i++)
			{
				ctx.AttachChain(readOnlyList[i], this.ChainExtra, !flag && i == 0, !this.IsUltimate);
			}
		}

		// Token: 0x0401C69C RID: 116380
		[Nullable(1)]
		private readonly int[] Params = cfg.GetParamsArray();

		// Token: 0x0401C69D RID: 116381
		private readonly bool IsUltimate = cfg.Type == 4;

		// Token: 0x0401C69E RID: 116382
		[Nullable(1)]
		private readonly int[] ChainExtra;
	}
}
