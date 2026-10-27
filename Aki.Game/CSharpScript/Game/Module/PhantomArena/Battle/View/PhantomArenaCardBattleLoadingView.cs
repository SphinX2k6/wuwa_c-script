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
	// Token: 0x0200524E RID: 21070
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardBattleLoadingView : LoadingViewBase
	{
		// Token: 0x06035D75 RID: 220533 RVA: 0x00CBDA48 File Offset: 0x00CBBC48
		public PhantomArenaCardBattleLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035D76 RID: 220534 RVA: 0x00CBDA54 File Offset: 0x00CBBC54
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

		// Token: 0x06035D77 RID: 220535 RVA: 0x00CBDB78 File Offset: 0x00CBBD78
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCardBattleLoadingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCardBattleLoadingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D78 RID: 220536 RVA: 0x00CBDBBB File Offset: 0x00CBBDBB
		protected override void OnStart()
		{
			base.OnStart();
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimEnd), false);
			this.InitPlayerInfo();
			this.InitNpcInfo();
		}

		// Token: 0x06035D79 RID: 220537 RVA: 0x00CBDBF8 File Offset: 0x00CBBDF8
		protected override void UpdateProgressRate(float rate)
		{
		}

		// Token: 0x06035D7A RID: 220538 RVA: 0x00CBDBFA File Offset: 0x00CBBDFA
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

		// Token: 0x06035D7B RID: 220539 RVA: 0x00CBDC28 File Offset: 0x00CBBE28
		protected override void OnLevelSequencePlayerBandStateChange(bool state)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06035D7C RID: 220540 RVA: 0x00CBDC58 File Offset: 0x00CBBE58
		private UniTask InitBg()
		{
			PhantomArenaCardBattleLoadingView.<InitBg>d__9 <InitBg>d__;
			<InitBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBg>d__.<>4__this = this;
			<InitBg>d__.<>1__state = -1;
			<InitBg>d__.<>t__builder.Start<PhantomArenaCardBattleLoadingView.<InitBg>d__9>(ref <InitBg>d__);
			return <InitBg>d__.<>t__builder.Task;
		}

		// Token: 0x06035D7D RID: 220541 RVA: 0x00CBDC9C File Offset: 0x00CBBE9C
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

		// Token: 0x06035D7E RID: 220542 RVA: 0x00CBDDE8 File Offset: 0x00CBBFE8
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

		// Token: 0x06035D7F RID: 220543 RVA: 0x00CBDEF0 File Offset: 0x00CBC0F0
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

		// Token: 0x0401C8A0 RID: 116896
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B3FE RID: 46078
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040368AC RID: 223404
			public const int Progress = 0;

			// Token: 0x040368AD RID: 223405
			public const int TexRoleLeft = 1;

			// Token: 0x040368AE RID: 223406
			public const int TxtRoleNameLeft = 2;

			// Token: 0x040368AF RID: 223407
			public const int TxtRoleLevelLeft = 3;

			// Token: 0x040368B0 RID: 223408
			public const int TexRoleRight = 4;

			// Token: 0x040368B1 RID: 223409
			public const int TxtRoleNameRight = 5;

			// Token: 0x040368B2 RID: 223410
			public const int TxtRoleLevelRight = 6;

			// Token: 0x040368B3 RID: 223411
			public const int TextureBg = 7;

			// Token: 0x040368B4 RID: 223412
			public const int TextureTriangleBg = 8;

			// Token: 0x040368B5 RID: 223413
			public const int TextureLeftHand = 9;

			// Token: 0x040368B6 RID: 223414
			public const int TextureRightHand = 10;

			// Token: 0x040368B7 RID: 223415
			public const int TextureHandShadow = 11;
		}
	}
}
