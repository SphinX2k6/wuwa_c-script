using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.DigitalScreen
{
	// Token: 0x02006095 RID: 24725
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DigitalScreenModel : ModelBase
	{
		// Token: 0x0603B509 RID: 242953 RVA: 0x010C9B04 File Offset: 0x010C7D04
		public unsafe bool InitDigitalScreen(int index)
		{
			this.StartTimes = Array.Empty<float>();
			this.EndTimes = Array.Empty<float>();
			this.DelayTimes = Array.Empty<float>();
			this.DuringTimes = Array.Empty<float>();
			this.TextLength = Array.Empty<int>();
			this.Font = Array.Empty<int>();
			this.ContentPos = Array.Empty<int>();
			this.During = 0f;
			this.Text = "";
			DigitalScreen value = ConfigDigitalScreenById.GetConfig(index, true).Value;
			this.ExistTime = value.ExistTime;
			this.TextFactor = value.TextFactor;
			this.BackgroundPicture = value.BackgroundPicture;
			this.LogoIcon = value.LogoIconPath;
			this.ViewType = value.Prefab;
			Span<int> textIdBytes = value.GetTextIdBytes();
			this.Size = textIdBytes.Length;
			Span<int> span = textIdBytes;
			for (int i = 0; i < span.Length; i++)
			{
				DigitalScreenText? config = ConfigDigitalScreenTextById.GetConfig(*span[i], true);
				float[] array = this.StartTimes;
				int num = 0;
				float[] array2 = new float[1 + array.Length];
				ReadOnlySpan<float> readOnlySpan = new ReadOnlySpan<float>(array);
				readOnlySpan.CopyTo(new Span<float>(array2).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array2[num] = config.Value.ShowStartFrame;
				this.StartTimes = array2;
				array2 = this.EndTimes;
				num = 0;
				array = new float[1 + array2.Length];
				readOnlySpan = new ReadOnlySpan<float>(array2);
				readOnlySpan.CopyTo(new Span<float>(array).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array[num] = config.Value.ShowEndFrame;
				this.EndTimes = array;
				float num2 = config.Value.ShowEndFrame - config.Value.ShowStartFrame;
				this.During += ((num2 >= 0f) ? num2 : 1f);
				array = this.DuringTimes;
				num = 0;
				array2 = new float[1 + array.Length];
				readOnlySpan = new ReadOnlySpan<float>(array);
				readOnlySpan.CopyTo(new Span<float>(array2).Slice(num, readOnlySpan.Length));
				num += readOnlySpan.Length;
				array2[num] = ((num2 >= 0f) ? num2 : 1f);
				this.DuringTimes = array2;
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(config.Value.TextContentId, null);
				this.Text += localTextNew;
				int num3 = (localTextNew.Length == 0) ? 1 : localTextNew.Length;
				int[] array3 = this.TextLength;
				num = 0;
				int[] array4 = new int[1 + array3.Length];
				ReadOnlySpan<int> readOnlySpan2 = new ReadOnlySpan<int>(array3);
				readOnlySpan2.CopyTo(new Span<int>(array4).Slice(num, readOnlySpan2.Length));
				num += readOnlySpan2.Length;
				array4[num] = num3;
				this.TextLength = array4;
				int num4 = (config.Value.FontSize == 0) ? 12 : config.Value.FontSize;
				array4 = this.Font;
				num = 0;
				array3 = new int[1 + array4.Length];
				readOnlySpan2 = new ReadOnlySpan<int>(array4);
				readOnlySpan2.CopyTo(new Span<int>(array3).Slice(num, readOnlySpan2.Length));
				num += readOnlySpan2.Length;
				array3[num] = num4;
				this.Font = array3;
				array3 = this.ContentPos;
				num = 0;
				array4 = new int[1 + array3.Length];
				readOnlySpan2 = new ReadOnlySpan<int>(array3);
				readOnlySpan2.CopyTo(new Span<int>(array4).Slice(num, readOnlySpan2.Length));
				num += readOnlySpan2.Length;
				array4[num] = config.Value.Alignment;
				this.ContentPos = array4;
			}
			for (int j = 0; j < this.StartTimes.Length - 1; j++)
			{
				if (this.EndTimes[j] < this.StartTimes[j + 1])
				{
					float[] array2 = this.DelayTimes;
					int i = 0;
					float[] array = new float[1 + array2.Length];
					ReadOnlySpan<float> readOnlySpan = new ReadOnlySpan<float>(array2);
					readOnlySpan.CopyTo(new Span<float>(array).Slice(i, readOnlySpan.Length));
					i += readOnlySpan.Length;
					array[i] = this.StartTimes[j + 1] - this.EndTimes[j];
					this.DelayTimes = array;
				}
				else
				{
					float[] array = this.DelayTimes;
					int i = 0;
					float[] array2 = new float[1 + array.Length];
					ReadOnlySpan<float> readOnlySpan = new ReadOnlySpan<float>(array);
					readOnlySpan.CopyTo(new Span<float>(array2).Slice(i, readOnlySpan.Length));
					i += readOnlySpan.Length;
					array2[i] = 0f;
					this.DelayTimes = array2;
				}
			}
			return true;
		}

		// Token: 0x0603B50A RID: 242954 RVA: 0x010CA01C File Offset: 0x010C821C
		public DigitalScreen? GetDataConfig(int index)
		{
			return ConfigDigitalScreenById.GetConfig(index, true);
		}

		// Token: 0x1700703F RID: 28735
		// (get) Token: 0x0603B50B RID: 242955 RVA: 0x010CA025 File Offset: 0x010C8225
		public static DigitalScreenModel Instance
		{
			get
			{
				return DigitalScreenModel._Instance;
			}
		}

		// Token: 0x0603B50C RID: 242956 RVA: 0x010CA02C File Offset: 0x010C822C
		public static DigitalScreenModel GetOrCreateInstance()
		{
			if (DigitalScreenModel._Instance == null)
			{
				DigitalScreenModel.CreateInstance();
			}
			return DigitalScreenModel._Instance;
		}

		// Token: 0x0603B50D RID: 242957 RVA: 0x010CA040 File Offset: 0x010C8240
		public static bool CreateInstance()
		{
			if (DigitalScreenModel._Instance != null)
			{
				return true;
			}
			DigitalScreenModel._Instance = new DigitalScreenModel();
			return true;
		}

		// Token: 0x0603B50E RID: 242958 RVA: 0x010CA056 File Offset: 0x010C8256
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B50F RID: 242959 RVA: 0x010CA058 File Offset: 0x010C8258
		public static void ResetStaticDefaultValue()
		{
			DigitalScreenModel._Instance = null;
		}

		// Token: 0x0603B510 RID: 242960 RVA: 0x010CA060 File Offset: 0x010C8260
		static DigitalScreenModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DigitalScreenModel.CreateStaticDefaultValue), new Action(DigitalScreenModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F3F2 RID: 127986
		public int ExistTime;

		// Token: 0x0401F3F3 RID: 127987
		public string BackgroundPicture = "";

		// Token: 0x0401F3F4 RID: 127988
		public string LogoIcon = "";

		// Token: 0x0401F3F5 RID: 127989
		public float TextFactor;

		// Token: 0x0401F3F6 RID: 127990
		public float[] StartTimes = Array.Empty<float>();

		// Token: 0x0401F3F7 RID: 127991
		private float[] EndTimes = Array.Empty<float>();

		// Token: 0x0401F3F8 RID: 127992
		public float[] DelayTimes = Array.Empty<float>();

		// Token: 0x0401F3F9 RID: 127993
		public float[] DuringTimes = Array.Empty<float>();

		// Token: 0x0401F3FA RID: 127994
		public int[] TextLength = Array.Empty<int>();

		// Token: 0x0401F3FB RID: 127995
		public int[] Font = Array.Empty<int>();

		// Token: 0x0401F3FC RID: 127996
		public int[] ContentPos = Array.Empty<int>();

		// Token: 0x0401F3FD RID: 127997
		public float During;

		// Token: 0x0401F3FE RID: 127998
		[Nullable(2)]
		public string Text = "";

		// Token: 0x0401F3FF RID: 127999
		public int ViewType;

		// Token: 0x0401F400 RID: 128000
		public int Size;

		// Token: 0x0401F401 RID: 128001
		[Nullable(2)]
		private static DigitalScreenModel _Instance;
	}
}
