using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.Splash
{
	// Token: 0x020000C7 RID: 199
	[NullableContext(2)]
	[Nullable(0)]
	public class SplashUiView : LaunchComponentsAction
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x00039304 File Offset: 0x00037504
		[NullableContext(1)]
		public UniTask InitAsync(UObject worldContext)
		{
			SplashUiView.<InitAsync>d__14 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.worldContext = worldContext;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<SplashUiView.<InitAsync>d__14>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00039350 File Offset: 0x00037550
		protected UniTask LoadResourceAsync()
		{
			SplashUiView.<LoadResourceAsync>d__15 <LoadResourceAsync>d__;
			<LoadResourceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadResourceAsync>d__.<>4__this = this;
			<LoadResourceAsync>d__.<>1__state = -1;
			<LoadResourceAsync>d__.<>t__builder.Start<SplashUiView.<LoadResourceAsync>d__15>(ref <LoadResourceAsync>d__);
			return <LoadResourceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00039393 File Offset: 0x00037593
		[NullableContext(1)]
		private void OnUiRootLoadCallback(AActor actor)
		{
			this.UiRoot = actor;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0003939C File Offset: 0x0003759C
		[NullableContext(1)]
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
			this.UiActor = (this.RootItem.GetOwner() as AUIBaseActor);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000393BB File Offset: 0x000375BB
		protected override void OnStart()
		{
			this.LanguageSuffixName = LauncherLanguageLib.Instance.PackageLanguage;
			this.DefaultLanguageSuffixName = LauncherLanguageLib.Instance.GetDefaultCulture(this.LanguageSuffixName);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000393E3 File Offset: 0x000375E3
		protected override void OnBeforeDestroy()
		{
			if (this.DataTable != null)
			{
				this.DataTable = null;
			}
			this.UiActor = null;
			this.DataMap = null;
			this.LogoTexture = null;
			this.GameSplashTexture = null;
			this.LanguageSuffixName = null;
			this.DefaultLanguageSuffixName = null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0003941E File Offset: 0x0003761E
		private void OnInitAndShow()
		{
			this.UpdateTexture();
			this.UpdateText();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0003942C File Offset: 0x0003762C
		private void UpdateTexture()
		{
			base.GetTexture(3).SetTexture(this.LogoTexture);
			base.GetTexture(3).SetSizeFromTexture();
			if (this.GetIfGlobal())
			{
				base.GetTexture(3).SetUIActive(true);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00039461 File Offset: 0x00037661
		private bool GetIfGlobal()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0003947C File Offset: 0x0003767C
		private void UpdateText()
		{
			bool ifGlobal = this.GetIfGlobal();
			LauncherLog instance = LauncherLog.Instance;
			string message = "TsSplash";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ifglobal", ifGlobal);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			string localText = this.GetLocalText(this.LanguageSuffixName, "SplashCautionTitle");
			if (localText == "" || localText == null)
			{
				localText = this.GetLocalText(this.DefaultLanguageSuffixName, "SplashCautionTitle");
			}
			base.GetText(5).SetText(localText, true);
			string localText2 = this.GetLocalText(this.LanguageSuffixName, "SplashCautionContent");
			if (localText2 == "" || localText2 == null)
			{
				localText2 = this.GetLocalText(this.DefaultLanguageSuffixName, "SplashCautionContent");
			}
			base.GetText(6).SetText(localText2, true);
			string localText3 = this.GetLocalText(this.LanguageSuffixName, "SplashLoading");
			if (localText3 == "" || localText3 == null)
			{
				localText3 = this.GetLocalText(this.DefaultLanguageSuffixName, "SplashLoading");
			}
			base.GetText(7).SetText(localText3, true);
			string text = "";
			if (!ifGlobal)
			{
				text = this.GetLocalText(this.LanguageSuffixName, "SplashHealthyGamingAdvisory");
				if (text == "" || text == null)
				{
					text = this.GetLocalText(this.DefaultLanguageSuffixName, "SplashHealthyGamingAdvisory");
				}
			}
			base.GetText(0).SetText(text, true);
			string text2 = "";
			if (!ifGlobal)
			{
				text2 = this.GetLocalText(this.LanguageSuffixName, "SplashCopyrightInformation");
				if (text2 == "" || text2 == null)
				{
					text2 = this.GetLocalText(this.DefaultLanguageSuffixName, "SplashCopyrightInformation");
				}
			}
			base.GetText(1).SetText(text2, true);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00039620 File Offset: 0x00037820
		public void PlayAnimationLogo(Action finishCallback = null)
		{
			if (this.GetIfGlobal())
			{
				this.PlaySequenceByName("LogoAnimation", finishCallback);
				return;
			}
			this.PlaySequenceByName("LogoAnimationMain", finishCallback);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00039643 File Offset: 0x00037843
		public void PlayWuthering(Action finishCallback = null)
		{
			this.PlaySequenceByName("WutheringWaveAnimation", finishCallback);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00039651 File Offset: 0x00037851
		public void PlayCautionAnimation(Action finishCallback = null)
		{
			this.PlaySequenceByName("CautionAnimation", finishCallback);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0003965F File Offset: 0x0003785F
		public void PlayPreventAddictionAnimation(Action finishCallback = null)
		{
			this.PlaySequenceByName("PreventAddiction", finishCallback);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0003966D File Offset: 0x0003786D
		public void StopCurrentAnimation()
		{
			this.StopCurrentSequence();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00039675 File Offset: 0x00037875
		[NullableContext(1)]
		private string GetLocalText(string culture, string textTableId)
		{
			return LauncherConfigLib.Instance.GetHotPatchText(textTableId) ?? "";
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0003968C File Offset: 0x0003788C
		private UniTask InitTextureAsync()
		{
			SplashUiView.<InitTextureAsync>d__30 <InitTextureAsync>d__;
			<InitTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTextureAsync>d__.<>4__this = this;
			<InitTextureAsync>d__.<>1__state = -1;
			<InitTextureAsync>d__.<>t__builder.Start<SplashUiView.<InitTextureAsync>d__30>(ref <InitTextureAsync>d__);
			return <InitTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000396D0 File Offset: 0x000378D0
		[NullableContext(1)]
		private void PlaySequenceByName(string name, [Nullable(2)] Action finishCallback = null)
		{
			this.StopCurrentSequence();
			USequencePlayContext sequencePlayContextOfKey = this.UiActor.GetSequencePlayContextOfKey(name);
			if (sequencePlayContextOfKey == null)
			{
				return;
			}
			sequencePlayContextOfKey.OnFinish.Bind(delegate()
			{
				this.CurrentSequenceName = null;
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			});
			this.CurrentSequenceName = name;
			sequencePlayContextOfKey.ExecutePlay();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003972C File Offset: 0x0003792C
		private void StopCurrentSequence()
		{
			if (this.CurrentSequenceName == null)
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = this.UiActor.GetSequencePlayerByKey(this.CurrentSequenceName);
			if (sequencePlayerByKey != null)
			{
				AUIBaseActor uiActor = this.UiActor;
				string currentSequenceName = this.CurrentSequenceName;
				FFrameTime time = sequencePlayerByKey.SequencePlayer.GetDuration().Time;
				uiActor.SequenceJumpToSecondByKey(currentSequenceName, time);
				this.UiActor.StopSequenceByKey(this.CurrentSequenceName);
			}
			this.CurrentSequenceName = null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00039794 File Offset: 0x00037994
		[NullableContext(1)]
		private UniTask LoadTableAsync(string path)
		{
			SplashUiView.<LoadTableAsync>d__33 <LoadTableAsync>d__;
			<LoadTableAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTableAsync>d__.<>4__this = this;
			<LoadTableAsync>d__.path = path;
			<LoadTableAsync>d__.<>1__state = -1;
			<LoadTableAsync>d__.<>t__builder.Start<SplashUiView.<LoadTableAsync>d__33>(ref <LoadTableAsync>d__);
			return <LoadTableAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000397E0 File Offset: 0x000379E0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UTexture> LoadTextureAsync(string name)
		{
			SplashUiView.<LoadTextureAsync>d__34 <LoadTextureAsync>d__;
			<LoadTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture>.Create();
			<LoadTextureAsync>d__.<>4__this = this;
			<LoadTextureAsync>d__.name = name;
			<LoadTextureAsync>d__.<>1__state = -1;
			<LoadTextureAsync>d__.<>t__builder.Start<SplashUiView.<LoadTextureAsync>d__34>(ref <LoadTextureAsync>d__);
			return <LoadTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0003982B File Offset: 0x00037A2B
		public override void Destroy()
		{
			base.Destroy();
			if (this.UiRoot != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.UiRoot, true);
				this.UiRoot = null;
			}
			if (this.WorldContext != null)
			{
				this.WorldContext = null;
			}
		}

		// Token: 0x04000411 RID: 1041
		[Nullable(1)]
		private const string ENCOMPANYNAME = "Company_en";

		// Token: 0x04000412 RID: 1042
		private AActor UiRoot;

		// Token: 0x04000413 RID: 1043
		private AUIBaseActor UiActor;

		// Token: 0x04000414 RID: 1044
		private UObject WorldContext;

		// Token: 0x04000415 RID: 1045
		private string CurrentSequenceName;

		// Token: 0x04000416 RID: 1046
		private string LanguageSuffixName;

		// Token: 0x04000417 RID: 1047
		private string DefaultLanguageSuffixName;

		// Token: 0x04000418 RID: 1048
		[Nullable(1)]
		private readonly string CompanyName = "Company_";

		// Token: 0x04000419 RID: 1049
		[Nullable(1)]
		private readonly string LogoName = "WutheringWave_";

		// Token: 0x0400041A RID: 1050
		private UTexture LogoTexture;

		// Token: 0x0400041B RID: 1051
		private UTexture GameSplashTexture;

		// Token: 0x0400041C RID: 1052
		private UDataTable DataTable;

		// Token: 0x0400041D RID: 1053
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> DataMap = new Dictionary<string, string>();

		// Token: 0x0200035E RID: 862
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001185 RID: 4485
			public const int NameA = 0;

			// Token: 0x04001186 RID: 4486
			public const int NameB = 1;

			// Token: 0x04001187 RID: 4487
			public const int LogoItem = 2;

			// Token: 0x04001188 RID: 4488
			public const int LogoTexture = 3;

			// Token: 0x04001189 RID: 4489
			public const int TipItem = 4;

			// Token: 0x0400118A RID: 4490
			public const int TxtTipTitle = 5;

			// Token: 0x0400118B RID: 4491
			public const int TxtTip = 6;

			// Token: 0x0400118C RID: 4492
			public const int TxtLoading = 7;
		}
	}
}
