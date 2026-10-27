using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02006504 RID: 25860
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class ChainSkill : ISkill
	{
		// Token: 0x06040E93 RID: 265875 RVA: 0x00FBB32C File Offset: 0x00FB952C
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

		// Token: 0x17009514 RID: 38164
		// (get) Token: 0x06040E94 RID: 265876 RVA: 0x00FBB3B8 File Offset: 0x00FB95B8
		public int Id { get; }

		// Token: 0x17009515 RID: 38165
		// (get) Token: 0x06040E95 RID: 265877 RVA: 0x00FBB3C0 File Offset: 0x00FB95C0
		public int EnergyNode { get; }

		// Token: 0x17009516 RID: 38166
		// (get) Token: 0x06040E96 RID: 265878 RVA: 0x00FBB3C8 File Offset: 0x00FB95C8
		public string Icon { get; }

		// Token: 0x17009517 RID: 38167
		// (get) Token: 0x06040E97 RID: 265879 RVA: 0x00FBB3D0 File Offset: 0x00FB95D0
		public string Name { get; }

		// Token: 0x17009518 RID: 38168
		// (get) Token: 0x06040E98 RID: 265880 RVA: 0x00FBB3D8 File Offset: 0x00FB95D8
		public ESkillCastEffect CastEffect
		{
			get
			{
				return ESkillCastEffect.Chain;
			}
		}

		// Token: 0x06040E99 RID: 265881 RVA: 0x00FBB3DC File Offset: 0x00FB95DC
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

		// Token: 0x04021D6B RID: 138603
		[Nullable(1)]
		private readonly int[] Params = cfg.GetParamsArray();

		// Token: 0x04021D6C RID: 138604
		private readonly bool IsUltimate = cfg.Type == 4;

		// Token: 0x04021D6D RID: 138605
		[Nullable(1)]
		private readonly int[] ChainExtra;
	}
}
