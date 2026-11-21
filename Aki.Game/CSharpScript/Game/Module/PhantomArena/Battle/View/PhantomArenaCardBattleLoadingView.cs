using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200421E RID: 16926
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardBattleLoadingView : LoadingViewBase
	{
		// Token: 0x0602AC70 RID: 175216 RVA: 0x00C0B0D8 File Offset: 0x00C092D8
		public PhantomArenaCardBattleLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AC71 RID: 175217 RVA: 0x00C0B0E4 File Offset: 0x00C092E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUITexture))
			};
		}

		// Token: 0x0602AC72 RID: 175218 RVA: 0x00C0B208 File Offset: 0x00C09408
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardBattleLoadingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardBattleLoadingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC73 RID: 175219 RVA: 0x00C0B24B File Offset: 0x00C0944B
		protected override void OnStart()
		{
			base.OnStart();
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimEnd), false);
			this.InitPlayerInfo();
			this.InitNpcInfo();
		}

		// Token: 0x0602AC74 RID: 175220 RVA: 0x00C0B288 File Offset: 0x00C09488
		protected override void UpdateProgressRate(float rate)
		{
		}

		// Token: 0x0602AC75 RID: 175221 RVA: 0x00C0B28A File Offset: 0x00C0948A
		protected override void UpdateProgressValue(float value)
		{
			this.SetTextProgressValue(0, value, "");
			if (value == 100f)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.StopSequenceByKey("Loop", false, false);
			}
		}

		// Token: 0x0602AC76 RID: 175222 RVA: 0x00C0B2B8 File Offset: 0x00C094B8
		protected override void OnLevelSequencePlayerBandStateChange(bool state)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0602AC77 RID: 175223 RVA: 0x00C0B2E8 File Offset: 0x00C094E8
		private UniTask InitBg()
		{
			PhantomArenaCardBattleLoadingView.<InitBg>d__9 <InitBg>d__;
			<InitBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBg>d__.<>4__this = this;
			<InitBg>d__.<>1__state = -1;
			<InitBg>d__.<>t__builder.Start<PhantomArenaCardBattleLoadingView.<InitBg>d__9>(ref <InitBg>d__);
			return <InitBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC78 RID: 175224 RVA: 0x00C0B32C File Offset: 0x00C0952C
		private void InitPlayerInfo()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			int activityId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).ActivityId;
			int masterLevel = PhantomArenaModel.Instance.GetMasterLevel(activityId);
			int masterTitleId = PhantomArenaModel.Instance.GetMasterTitleId(activityId);
			PhantomBattleMasterTitle phantomBattleMasterTitleById = PhantomArenaConfig.Instance.GetPhantomBattleMasterTitleById(masterTitleId);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(phantomBattleMasterTitleById.Name, phantomBattleMasterTitleById.Name);
			PhantomBattleEnterCtx loadingConfig = PhantomArenaBattleModel.Instance.LoadingConfig;
			if (loadingConfig == null)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.WHJ, "Cant get Phantom fighter Config", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int cardRoleId = loadingConfig.CardRoleId;
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(cardRoleId);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(playerName ?? "", true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(masterLevel);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(multiTextByKey);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(phantomBattleCardRole.RoleHeadTexture, base.GetTexture(1), null, null);
		}

		// Token: 0x0602AC79 RID: 175225 RVA: 0x00C0B478 File Offset: 0x00C09678
		private void InitNpcInfo()
		{
			PhantomBattleEnterCtx loadingConfig = PhantomArenaBattleModel.Instance.LoadingConfig;
			if (loadingConfig == null)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.WHJ, "Cant get Phantom fighter Config", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int challengeId = loadingConfig.ChallengeId;
			PhantomBattleChallenge phantomBattleChallengeConfig = PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(challengeId);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(phantomBattleChallengeConfig.NpcName, phantomBattleChallengeConfig.NpcName);
			string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(phantomBattleChallengeConfig.NpcTitle, phantomBattleChallengeConfig.NpcTitle);
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(multiTextByKey, true);
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomBattleChallengeConfig.NpcLevel);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(multiTextByKey2);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(phantomBattleChallengeConfig.NpcHead, base.GetTexture(4), null, null);
		}

		// Token: 0x0602AC7A RID: 175226 RVA: 0x00C0B580 File Offset: 0x00C09780
		private void OnAnimEnd(string name)
		{
			if (name == "Start")
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}

		// Token: 0x040172D5 RID: 94933
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x02009E36 RID: 40502
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040312FF RID: 201471
			public const int Progress = 0;

			// Token: 0x04031300 RID: 201472
			public const int TexRoleLeft = 1;

			// Token: 0x04031301 RID: 201473
			public const int TxtRoleNameLeft = 2;

			// Token: 0x04031302 RID: 201474
			public const int TxtRoleLevelLeft = 3;

			// Token: 0x04031303 RID: 201475
			public const int TexRoleRight = 4;

			// Token: 0x04031304 RID: 201476
			public const int TxtRoleNameRight = 5;

			// Token: 0x04031305 RID: 201477
			public const int TxtRoleLevelRight = 6;

			// Token: 0x04031306 RID: 201478
			public const int TextureBg = 7;

			// Token: 0x04031307 RID: 201479
			public const int TextureTriangleBg = 8;

			// Token: 0x04031308 RID: 201480
			public const int TextureLeftHand = 9;

			// Token: 0x04031309 RID: 201481
			public const int TextureRightHand = 10;

			// Token: 0x0403130A RID: 201482
			public const int TextureHandShadow = 11;
		}
	}
}
