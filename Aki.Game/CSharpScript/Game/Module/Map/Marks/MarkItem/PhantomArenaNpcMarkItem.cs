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
	// Token: 0x020054F1 RID: 21745
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItem : ConfigMarkItem
	{
		// Token: 0x060378B3 RID: 227507 RVA: 0x00D2FF3D File Offset: 0x00D2E13D
		public PhantomArenaNpcMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060378B4 RID: 227508 RVA: 0x00D2FF53 File Offset: 0x00D2E153
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
		}

		// Token: 0x060378B5 RID: 227509 RVA: 0x00D2FF64 File Offset: 0x00D2E164
		private void UpdateGamePlayState()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleChallenge? phantomBattleChallenge = (instance != null) ? instance.GetPhantomBattleChallengeByMarkId(this.MarkId) : null;
			if (phantomBattleChallenge == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "PhantomArenaNpcMarkItem找不到对应的挑战数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", this.MarkId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PhantomArenaModel instance3 = PhantomArenaModel.Instance;
			EChallengeState? echallengeState = (instance3 != null) ? new EChallengeState?(instance3.GetPermanentChallengeStateById(phantomBattleChallenge.Value.Id)) : null;
			base.MarkItemEntity.GamePlay.GamePlayState = ((echallengeState.GetValueOrDefault() == EChallengeState.Finish) ? EMarkGamePlayState.Finish : EMarkGamePlayState.Processing);
		}

		// Token: 0x060378B6 RID: 227510 RVA: 0x00D3001D File Offset: 0x00D2E21D
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PhantomArenaNpcMarkItemView;
		}

		// Token: 0x060378B7 RID: 227511 RVA: 0x00D30021 File Offset: 0x00D2E221
		[PreserveBaseOverrides]
		protected new virtual PhantomArenaNpcMarkItemView CreateView()
		{
			return new PhantomArenaNpcMarkItemView(this);
		}

		// Token: 0x060378B8 RID: 227512 RVA: 0x00D3002C File Offset: 0x00D2E22C
		public override string GetTitleText()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleChallenge? phantomBattleChallenge = (instance != null) ? instance.GetPhantomBattleChallengeByMarkId(this.MarkId) : null;
			if (phantomBattleChallenge == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取挑战信息失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", this.MarkId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			PhantomBattleChallengeInfo permanentChallengeData = PhantomArenaModel.Instance.GetPermanentChallengeData(phantomBattleChallenge.Value.Id);
			bool flag = permanentChallengeData == null || permanentChallengeData.IsUncover;
			return MapConfig.Instance.GetLocalText(flag ? this.MarkConfig.Value.MarkTitle : EPhantomArenaTextId.TextMysteryNpcName.ToString());
		}

		// Token: 0x060378B9 RID: 227513 RVA: 0x00D300F8 File Offset: 0x00D2E2F8
		public override bool CheckCanShowView()
		{
			if (this.CachedIsWorldMapShowMark == null)
			{
				PhantomArenaConfig instance = PhantomArenaConfig.Instance;
				PhantomBattleChallenge? phantomBattleChallenge = (instance != null) ? instance.GetPhantomBattleChallengeByMarkId(this.MarkId) : null;
				if (phantomBattleChallenge == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.CB;
					string message = "PhantomArenaNpcMarkItem找不到对应的挑战数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", this.MarkId);
					instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				this.CachedIsWorldMapShowMark = new bool?(phantomBattleChallenge.Value.IsWorldMapShowMark);
			}
			MapModel instance3 = MapModel.Instance;
			return (instance3 != null && instance3.IsExtraUiMarkType(base.MapType, this.MarkType)) || (this.CachedIsWorldMapShowMark.Value && base.CheckCanShowView());
		}

		// Token: 0x0401D3C7 RID: 119751
		[Nullable(2)]
		public PhantomArenaNpcMarkItemView InnerView;

		// Token: 0x0401D3C8 RID: 119752
		private bool? CachedIsWorldMapShowMark;
	}
}
