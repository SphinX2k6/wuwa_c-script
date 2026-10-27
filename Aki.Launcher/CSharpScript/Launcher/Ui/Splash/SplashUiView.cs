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
	// Token: 0x020000C4 RID: 196
	[NullableContext(2)]
	[Nullable(0)]
	public class SplashUiView : LaunchComponentsAction
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x000377D4 File Offset: 0x000359D4
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

		// Token: 0x06000671 RID: 1649 RVA: 0x00037820 File Offset: 0x00035A20
		protected UniTask LoadResourceAsync()
		{
			SplashUiView.<LoadResourceAsync>d__15 <LoadResourceAsync>d__;
			<LoadResourceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadResourceAsync>d__.<>4__this = this;
			<LoadResourceAsync>d__.<>1__state = -1;
			<LoadResourceAsync>d__.<>t__builder.Start<SplashUiView.<LoadResourceAsync>d__15>(ref <LoadResourceAsync>d__);
			return <LoadResourceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00037863 File Offset: 0x00035A63
		[NullableContext(1)]
		private void OnUiRootLoadCallback(AActor actor)
		{
			this.UiRoot = actor;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0003786C File Offset: 0x00035A6C
		[NullableContext(1)]
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
			this.UiActor = (this.RootItem.GetOwner() as AUIBaseActor);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0003788B File Offset: 0x00035A8B
		protected override void OnStart()
		{
			this.LanguageSuffixName = LauncherLanguageLib.Instance.PackageLanguage;
			this.DefaultLanguageSuffixName = LauncherLanguageLib.Instance.GetDefaultCulture(this.LanguageSuffixName);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000378B3 File Offset: 0x00035AB3
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

		// Token: 0x06000676 RID: 1654 RVA: 0x000378EE File Offset: 0x00035AEE
		private void OnInitAndShow()
		{
			this.UpdateTexture();
			this.UpdateText();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000378FC File Offset: 0x00035AFC
		private void UpdateTexture()
		{
			base.GetTexture(3).SetTexture(this.LogoTexture);
			base.GetTexture(3).SetSizeFromTexture();
			if (this.GetIfGlobal())
			{
				base.GetTexture(3).SetUIActive(true);
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00037931 File Offset: 0x00035B31
		private bool GetIfGlobal()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0003794C File Offset: 0x00035B4C
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

		// Token: 0x0600067A RID: 1658 RVA: 0x00037AF0 File Offset: 0x00035CF0
		public void PlayAnimationLogo(Action finishCallback = null)
		{
			if (this.GetIfGlobal())
			{
				this.PlaySequenceByName("LogoAnimation", finishCallback);
				return;
			}
			this.PlaySequenceByName("LogoAnimationMain", finishCallback);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00037B13 File Offset: 0x00035D13
		public void PlayWuthering(Action finishCallback = null)
		{
			this.PlaySequenceByName("WutheringWaveAnimation", finishCallback);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00037B21 File Offset: 0x00035D21
		public void PlayCautionAnimation(Action finishCallback = null)
		{
			this.PlaySequenceByName("CautionAnimation", finishCallback);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00037B2F File Offset: 0x00035D2F
		public void PlayPreventAddictionAnimation(Action finishCallback = null)
		{
			this.PlaySequenceByName("PreventAddiction", finishCallback);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00037B3D File Offset: 0x00035D3D
		public void StopCurrentAnimation()
		{
			this.StopCurrentSequence();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00037B45 File Offset: 0x00035D45
		[NullableContext(1)]
		private string GetLocalText(string culture, string textTableId)
		{
			return LauncherConfigLib.Instance.GetHotPatchText(textTableId) ?? "";
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00037B5C File Offset: 0x00035D5C
		private UniTask InitTextureAsync()
		{
			SplashUiView.<InitTextureAsync>d__30 <InitTextureAsync>d__;
			<InitTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTextureAsync>d__.<>4__this = this;
			<InitTextureAsync>d__.<>1__state = -1;
			<InitTextureAsync>d__.<>t__builder.Start<SplashUiView.<InitTextureAsync>d__30>(ref <InitTextureAsync>d__);
			return <InitTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00037BA0 File Offset: 0x00035DA0
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

		// Token: 0x06000682 RID: 1666 RVA: 0x00037BFC File Offset: 0x00035DFC
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

		// Token: 0x06000683 RID: 1667 RVA: 0x00037C64 File Offset: 0x00035E64
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

		// Token: 0x06000684 RID: 1668 RVA: 0x00037CB0 File Offset: 0x00035EB0
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

		// Token: 0x06000685 RID: 1669 RVA: 0x00037CFB File Offset: 0x00035EFB
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

		// Token: 0x040003E2 RID: 994
		[Nullable(1)]
		private const string ENCOMPANYNAME = "Company_en";

		// Token: 0x040003E3 RID: 995
		private AActor UiRoot;

		// Token: 0x040003E4 RID: 996
		private AUIBaseActor UiActor;

		// Token: 0x040003E5 RID: 997
		private UObject WorldContext;

		// Token: 0x040003E6 RID: 998
		private string CurrentSequenceName;

		// Token: 0x040003E7 RID: 999
		private string LanguageSuffixName;

		// Token: 0x040003E8 RID: 1000
		private string DefaultLanguageSuffixName;

		// Token: 0x040003E9 RID: 1001
		[Nullable(1)]
		private readonly string CompanyName = "Company_";

		// Token: 0x040003EA RID: 1002
		[Nullable(1)]
		private readonly string LogoName = "WutheringWave_";

		// Token: 0x040003EB RID: 1003
		private UTexture LogoTexture;

		// Token: 0x040003EC RID: 1004
		private UTexture GameSplashTexture;

		// Token: 0x040003ED RID: 1005
		private UDataTable DataTable;

		// Token: 0x040003EE RID: 1006
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, string> DataMap = new Dictionary<string, string>();

		// Token: 0x02000353 RID: 851
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001123 RID: 4387
			public const int NameA = 0;

			// Token: 0x04001124 RID: 4388
			public const int NameB = 1;

			// Token: 0x04001125 RID: 4389
			public const int LogoItem = 2;

			// Token: 0x04001126 RID: 4390
			public const int LogoTexture = 3;

			// Token: 0x04001127 RID: 4391
			public const int TipItem = 4;

			// Token: 0x04001128 RID: 4392
			public const int TxtTipTitle = 5;

			// Token: 0x04001129 RID: 4393
			public const int TxtTip = 6;

			// Token: 0x0400112A RID: 4394
			public const int TxtLoading = 7;
		}
	}
}
