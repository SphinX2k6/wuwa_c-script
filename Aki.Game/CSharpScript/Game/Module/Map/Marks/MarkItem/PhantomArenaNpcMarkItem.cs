using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.PhantomArena;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C4 RID: 17604
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C77E RID: 182142 RVA: 0x00C7DF35 File Offset: 0x00C7C135
		public PhantomArenaNpcMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C77F RID: 182143 RVA: 0x00C7DF4C File Offset: 0x00C7C14C
		public override bool IsMarkDisabled()
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleChallengeByMarkId(this.MarkId) == null && base.IsMarkDisabled();
		}

		// Token: 0x0602C780 RID: 182144 RVA: 0x00C7DF7C File Offset: 0x00C7C17C
		protected override bool IsGamePlayFinishRaw()
		{
			PhantomBattleChallenge? phantomBattleChallengeByMarkId = PhantomArenaConfig.Instance.GetPhantomBattleChallengeByMarkId(this.MarkId);
			return phantomBattleChallengeByMarkId != null && PhantomArenaModel.Instance.GetPermanentChallengeStateById(phantomBattleChallengeByMarkId.Value.Id) == EChallengeState.Finish;
		}

		// Token: 0x0602C781 RID: 182145 RVA: 0x00C7DFC1 File Offset: 0x00C7C1C1
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PhantomArenaNpcMarkItemView;
		}

		// Token: 0x0602C782 RID: 182146 RVA: 0x00C7DFC5 File Offset: 0x00C7C1C5
		[PreserveBaseOverrides]
		protected new virtual PhantomArenaNpcMarkItemView CreateView()
		{
			return new PhantomArenaNpcMarkItemView(this);
		}

		// Token: 0x0602C783 RID: 182147 RVA: 0x00C7DFD0 File Offset: 0x00C7C1D0
		public override string GetTitleText()
		{
			PhantomBattleChallenge? phantomBattleChallengeByMarkId = PhantomArenaConfig.Instance.GetPhantomBattleChallengeByMarkId(this.MarkId);
			if (phantomBattleChallengeByMarkId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取挑战信息失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", this.MarkId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			PhantomBattleChallengeInfo permanentChallengeData = PhantomArenaModel.Instance.GetPermanentChallengeData(phantomBattleChallengeByMarkId.Value.Id);
			bool flag = permanentChallengeData == null || permanentChallengeData.IsUncover;
			return MapConfig.Instance.GetLocalText(flag ? base.MarkConfig.Value.MarkTitle : EPhantomArenaTextId.TextMysteryNpcName.ToString());
		}

		// Token: 0x0602C784 RID: 182148 RVA: 0x00C7E090 File Offset: 0x00C7C290
		public override bool CheckCanShowView()
		{
			if (this.CachedIsWorldMapShowMark == null)
			{
				PhantomBattleChallenge? phantomBattleChallengeByMarkId = PhantomArenaConfig.Instance.GetPhantomBattleChallengeByMarkId(this.MarkId);
				if (phantomBattleChallengeByMarkId == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.CB;
					string message = "PhantomArenaNpcMarkItem找不到对应的挑战数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", this.MarkId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				this.CachedIsWorldMapShowMark = new bool?(phantomBattleChallengeByMarkId.Value.IsWorldMapShowMark);
			}
			return MapModel.Instance.IsExtraUiMarkType(base.MapType, this.MarkType) || (this.CachedIsWorldMapShowMark.Value && base.CheckCanShowView());
		}

		// Token: 0x04017E50 RID: 97872
		private bool? CachedIsWorldMapShowMark;
	}
}
