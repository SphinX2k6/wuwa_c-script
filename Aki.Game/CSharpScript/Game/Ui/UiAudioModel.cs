using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046CC RID: 18124
	[NullableContext(1)]
	[Nullable(0)]
	public class UiAudioModel : Singleton
	{
		// Token: 0x0602EBBE RID: 191422 RVA: 0x00AD0D33 File Offset: 0x00ACEF33
		[NullableContext(2)]
		public void AddAudioStateData(AudioStateData state)
		{
			this.DataSet.Add(state);
		}

		// Token: 0x0602EBBF RID: 191423 RVA: 0x00AD0D42 File Offset: 0x00ACEF42
		public bool RemoveAudioStateData(AudioStateData state)
		{
			return this.DataSet.Remove(state);
		}

		// Token: 0x0602EBC0 RID: 191424 RVA: 0x00AD0D50 File Offset: 0x00ACEF50
		private float CalculateLevel()
		{
			float num = 0f;
			foreach (AudioStateData audioStateData in this.DataSet)
			{
				if (num < audioStateData.Level)
				{
					num = audioStateData.Level;
				}
			}
			return num;
		}

		// Token: 0x0602EBC1 RID: 191425 RVA: 0x00AD0DB4 File Offset: 0x00ACEFB4
		private float CalculateAlpha()
		{
			float num = 0f;
			foreach (AudioStateData audioStateData in this.DataSet)
			{
				num = num + audioStateData.Alpha - num * audioStateData.Alpha;
			}
			return num;
		}

		// Token: 0x0602EBC2 RID: 191426 RVA: 0x00AD0E1C File Offset: 0x00ACF01C
		public unsafe void SetLoopAudioEventShow(int viewId, AActor actor, string eventName)
		{
			if (this.LastLoopAudio.Item1 == 0)
			{
				int item = AudioSystem.Instance.PostEvent(eventName);
				this.LastLoopAudio = new Tuple<int, string, int>(viewId, eventName, item);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "Audio BGM, New View";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("event", eventName);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (viewId != this.LastLoopAudio.Item1 && eventName != this.LastLoopAudio.Item2)
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio.Item3, EAudioActionType.Stop, null);
				int item2 = AudioSystem.Instance.PostEvent(eventName);
				this.LastLoopAudio = new Tuple<int, string, int>(viewId, eventName, item2);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.WDX;
				string message2 = "Audio BGM, New BGM";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("viewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("event", eventName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			int item3 = this.LastLoopAudio.Item3;
			this.LastLoopAudio = new Tuple<int, string, int>(viewId, eventName, item3);
			AudioSystem.Instance.ExecuteAction(item3, EAudioActionType.Resume, null);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Audio;
			ELogAuthor author3 = ELogAuthor.WDX;
			string message3 = "Audio BGM, Show Same";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("viewId", viewId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("event", eventName);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
		}

		// Token: 0x0602EBC3 RID: 191427 RVA: 0x00AD0FF0 File Offset: 0x00ACF1F0
		public void KeepLoopAudioEventShow(int viewId, AActor actor)
		{
			if (this.LastLoopAudio.Item1 == 0)
			{
				return;
			}
			string item = this.LastLoopAudio.Item2;
			UiAudioModel.Instance.SetLoopAudioEventShow(viewId, actor, item);
		}

		// Token: 0x0602EBC4 RID: 191428 RVA: 0x00AD1024 File Offset: 0x00ACF224
		public void KeepLoopAudioEventHide(int viewId, AActor actor)
		{
			if (this.LastLoopAudio.Item1 != viewId)
			{
				return;
			}
			string item = this.LastLoopAudio.Item2;
			UiAudioModel.Instance.SetLoopAudioEventHide(viewId, actor, item);
		}

		// Token: 0x0602EBC5 RID: 191429 RVA: 0x00AD105C File Offset: 0x00ACF25C
		public void KeepLoopAudioEventDestroy(int viewId, AActor actor)
		{
			if (this.LastLoopAudio.Item1 != viewId)
			{
				return;
			}
			string item = this.LastLoopAudio.Item2;
			UiAudioModel.Instance.SetLoopAudioEventDestroy(viewId, actor, item);
		}

		// Token: 0x0602EBC6 RID: 191430 RVA: 0x00AD1094 File Offset: 0x00ACF294
		public unsafe void SetLoopAudioEventHide(int viewId, AActor actor, string eventName)
		{
			if (viewId == this.LastLoopAudio.Item1)
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio.Item3, EAudioActionType.Pause, null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "Audio BGM, Hide";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("event", eventName);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602EBC7 RID: 191431 RVA: 0x00AD1128 File Offset: 0x00ACF328
		public unsafe void SetLoopAudioEventDestroy(int viewId, AActor actor, string eventName)
		{
			if (viewId == this.LastLoopAudio.Item1)
			{
				AudioSystem.Instance.ExecuteAction(this.LastLoopAudio.Item3, EAudioActionType.Stop, null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.WDX;
				string message = "Audio BGM, Destroy";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewId", viewId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("event", eventName);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.LastLoopAudio = new Tuple<int, string, int>(0, "", 0);
			}
		}

		// Token: 0x0602EBC8 RID: 191432 RVA: 0x00AD11D0 File Offset: 0x00ACF3D0
		public void SetRtpcLevelOpening(float level)
		{
			AudioSystem.Instance.SetRtpcValue("RPTC_COVER_LEVEL_OPENING", level, null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Audio计算结果";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RPTC_COVER_LEVEL_OPENING", level);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EBC9 RID: 191433 RVA: 0x00AD1224 File Offset: 0x00ACF424
		public void SetRtpcLevelClosing(float level)
		{
			AudioSystem.Instance.SetRtpcValue("RPTC_COVER_LEVEL_CLOSING", level, null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Audio计算结果";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RPTC_COVER_LEVEL_CLOSING", level);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EBCA RID: 191434 RVA: 0x00AD1278 File Offset: 0x00ACF478
		public unsafe void CalculateRtpcValueAndApply()
		{
			float num = this.CalculateLevel();
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_LEVEL", num, null);
			float num2 = this.CalculateAlpha();
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_ALPHA", num, null);
			float num3 = num - this.TempLastLevel;
			this.TempLastLevel = num;
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_LEVEL_DELTA", num, null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Audio计算结果";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RTPC_COVER_LEVEL", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RTPC_COVER_ALPHA", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RTPC_COVER_LEVEL_DELTA", num3);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x17007675 RID: 30325
		// (get) Token: 0x0602EBCB RID: 191435 RVA: 0x00AD136B File Offset: 0x00ACF56B
		public static UiAudioModel Instance
		{
			get
			{
				if (UiAudioModel._instance == null)
				{
					UiAudioModel._instance = new UiAudioModel();
					UiAudioModel._instance.OnInit();
				}
				return UiAudioModel._instance;
			}
		}

		// Token: 0x0602EBCC RID: 191436 RVA: 0x00AD138E File Offset: 0x00ACF58E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EBCD RID: 191437 RVA: 0x00AD1390 File Offset: 0x00ACF590
		public static void ResetStaticDefaultValue()
		{
			UiAudioModel instance = UiAudioModel._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiAudioModel._instance = null;
		}

		// Token: 0x0602EBCE RID: 191438 RVA: 0x00AD13A9 File Offset: 0x00ACF5A9
		static UiAudioModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiAudioModel.CreateStaticDefaultValue), new Action(UiAudioModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401970D RID: 104205
		public const string RPTC_COVER_LEVEL_CLOSING = "RPTC_COVER_LEVEL_CLOSING";

		// Token: 0x0401970E RID: 104206
		public const string RPTC_COVER_LEVEL_OPENING = "RPTC_COVER_LEVEL_OPENING";

		// Token: 0x0401970F RID: 104207
		public const string RTPC_COVER_ALPHA = "RTPC_COVER_ALPHA";

		// Token: 0x04019710 RID: 104208
		public const string RTPC_COVER_LEVEL = "RTPC_COVER_LEVEL";

		// Token: 0x04019711 RID: 104209
		public const string RTPC_COVER_LEVEL_DELTA = "RTPC_COVER_LEVEL_DELTA";

		// Token: 0x04019712 RID: 104210
		private readonly HashSet<AudioStateData> DataSet = new HashSet<AudioStateData>();

		// Token: 0x04019713 RID: 104211
		private float TempLastLevel;

		// Token: 0x04019714 RID: 104212
		public Tuple<int, string, int> LastLoopAudio = new Tuple<int, string, int>(0, "", 0);

		// Token: 0x04019715 RID: 104213
		[Nullable(2)]
		private static UiAudioModel _instance;
	}
}
