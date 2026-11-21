using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004283 RID: 17027
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideSettingCard : PhantomArenaBattleGuideDataBase<IBvbDeploy>
	{
		// Token: 0x0602B17A RID: 176506 RVA: 0x00C1D6F8 File Offset: 0x00C1B8F8
		public PhantomArenaBattleGuideSettingCard(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0602B17B RID: 176507 RVA: 0x00C1D704 File Offset: 0x00C1B904
		public unsafe override bool CheckCanExecute(params object[] params_)
		{
			if (params_.Length < 2)
			{
				return false;
			}
			int num = (int)params_[0];
			int num2 = (int)params_[1];
			if (num == -1 || num2 == -1)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "PhantomArenaBattleGuideSettingCard invalid value";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handIndex", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("battleIndex", num2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return (this.Data.HandCardIndex == null || this.Data.HandCardIndex.Value - 1 == num) && (this.Data.BoardPosIndexList == null || this.Data.BoardPosIndexList.Contains(num2 + 1));
		}
	}
}
