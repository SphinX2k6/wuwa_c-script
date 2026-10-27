using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.DigitalScreen
{
	// Token: 0x02006F14 RID: 28436
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DigitalScreenModel : ModelBase
	{
		// Token: 0x0604535B RID: 283483 RVA: 0x0111FB64 File Offset: 0x0111DD64
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

		// Token: 0x0604535C RID: 283484 RVA: 0x0112007C File Offset: 0x0111E27C
		public DigitalScreen? GetDataConfig(int index)
		{
			return ConfigDigitalScreenById.GetConfig(index, true);
		}

		// Token: 0x17009B00 RID: 39680
		// (get) Token: 0x0604535D RID: 283485 RVA: 0x01120085 File Offset: 0x0111E285
		public static DigitalScreenModel Instance
		{
			get
			{
				return DigitalScreenModel._Instance;
			}
		}

		// Token: 0x0604535E RID: 283486 RVA: 0x0112008C File Offset: 0x0111E28C
		public static DigitalScreenModel GetOrCreateInstance()
		{
			if (DigitalScreenModel._Instance == null)
			{
				DigitalScreenModel.CreateInstance();
			}
			return DigitalScreenModel._Instance;
		}

		// Token: 0x0604535F RID: 283487 RVA: 0x011200A0 File Offset: 0x0111E2A0
		public static bool CreateInstance()
		{
			if (DigitalScreenModel._Instance != null)
			{
				return true;
			}
			DigitalScreenModel._Instance = new DigitalScreenModel();
			return true;
		}

		// Token: 0x06045360 RID: 283488 RVA: 0x011200B6 File Offset: 0x0111E2B6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045361 RID: 283489 RVA: 0x011200B8 File Offset: 0x0111E2B8
		public static void ResetStaticDefaultValue()
		{
			DigitalScreenModel._Instance = null;
		}

		// Token: 0x06045362 RID: 283490 RVA: 0x011200C0 File Offset: 0x0111E2C0
		static DigitalScreenModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DigitalScreenModel.CreateStaticDefaultValue), new Action(DigitalScreenModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402413D RID: 147773
		public int ExistTime;

		// Token: 0x0402413E RID: 147774
		public string BackgroundPicture = "";

		// Token: 0x0402413F RID: 147775
		public string LogoIcon = "";

		// Token: 0x04024140 RID: 147776
		public float TextFactor;

		// Token: 0x04024141 RID: 147777
		public float[] StartTimes = Array.Empty<float>();

		// Token: 0x04024142 RID: 147778
		private float[] EndTimes = Array.Empty<float>();

		// Token: 0x04024143 RID: 147779
		public float[] DelayTimes = Array.Empty<float>();

		// Token: 0x04024144 RID: 147780
		public float[] DuringTimes = Array.Empty<float>();

		// Token: 0x04024145 RID: 147781
		public int[] TextLength = Array.Empty<int>();

		// Token: 0x04024146 RID: 147782
		public int[] Font = Array.Empty<int>();

		// Token: 0x04024147 RID: 147783
		public int[] ContentPos = Array.Empty<int>();

		// Token: 0x04024148 RID: 147784
		public float During;

		// Token: 0x04024149 RID: 147785
		[Nullable(2)]
		public string Text = "";

		// Token: 0x0402414A RID: 147786
		public int ViewType;

		// Token: 0x0402414B RID: 147787
		public int Size;

		// Token: 0x0402414C RID: 147788
		[Nullable(2)]
		private static DigitalScreenModel _Instance;
	}
}
