using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Movement.Model
{
	// Token: 0x02005392 RID: 21394
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AvoidanceModel : ModelBase
	{
		// Token: 0x170083A2 RID: 33698
		// (get) Token: 0x06036A72 RID: 223858 RVA: 0x00CEF408 File Offset: 0x00CED608
		public bool[] ZeroTuple32
		{
			get
			{
				if (this.ZeroTuple32Internal == null)
				{
					this.ZeroTuple32Internal = new bool[32];
					for (int i = 0; i < 32; i++)
					{
						this.ZeroTuple32Internal[i] = false;
					}
				}
				return this.ZeroTuple32Internal;
			}
		}

		// Token: 0x06036A73 RID: 223859 RVA: 0x00CEF448 File Offset: 0x00CED648
		public FNavAvoidanceMask GetSingleBitMask(int bitIndex)
		{
			if (bitIndex < 0 || bitIndex >= 32)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.XDW;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[AvoidanceModel.GetSingleBitMask] ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(bitIndex);
				defaultInterpolatedStringHandler.AppendLiteral("非法");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return new FNavAvoidanceMask();
			}
			if (this.ReuseZeroTuple)
			{
				this.ZeroTuple32[bitIndex] = true;
				FNavAvoidanceMask result = new FNavAvoidanceMask(this.ZeroTuple32[0], this.ZeroTuple32[1], this.ZeroTuple32[2], this.ZeroTuple32[3], this.ZeroTuple32[4], this.ZeroTuple32[5], this.ZeroTuple32[6], this.ZeroTuple32[7], this.ZeroTuple32[8], this.ZeroTuple32[9], this.ZeroTuple32[10], this.ZeroTuple32[11], this.ZeroTuple32[12], this.ZeroTuple32[13], this.ZeroTuple32[14], this.ZeroTuple32[15], this.ZeroTuple32[16], this.ZeroTuple32[17], this.ZeroTuple32[18], this.ZeroTuple32[19], this.ZeroTuple32[20], this.ZeroTuple32[21], this.ZeroTuple32[22], this.ZeroTuple32[23], this.ZeroTuple32[24], this.ZeroTuple32[25], this.ZeroTuple32[26], this.ZeroTuple32[27], this.ZeroTuple32[28], this.ZeroTuple32[29], this.ZeroTuple32[30], this.ZeroTuple32[31]);
				this.ZeroTuple32[bitIndex] = false;
				return result;
			}
			if (this.SingleBitMask == null)
			{
				this.SingleBitMask = new bool[32][];
			}
			if (this.SingleBitMask[bitIndex].Length == 0)
			{
				this.SingleBitMask[bitIndex] = new bool[32];
				for (int i = 0; i < 32; i++)
				{
					this.SingleBitMask[bitIndex][i] = false;
				}
				this.SingleBitMask[bitIndex][bitIndex] = true;
			}
			return new FNavAvoidanceMask(this.SingleBitMask[bitIndex][0], this.SingleBitMask[bitIndex][1], this.SingleBitMask[bitIndex][2], this.SingleBitMask[bitIndex][3], this.SingleBitMask[bitIndex][4], this.SingleBitMask[bitIndex][5], this.SingleBitMask[bitIndex][6], this.SingleBitMask[bitIndex][7], this.SingleBitMask[bitIndex][8], this.SingleBitMask[bitIndex][9], this.SingleBitMask[bitIndex][10], this.SingleBitMask[bitIndex][11], this.SingleBitMask[bitIndex][12], this.SingleBitMask[bitIndex][13], this.SingleBitMask[bitIndex][14], this.SingleBitMask[bitIndex][15], this.SingleBitMask[bitIndex][16], this.SingleBitMask[bitIndex][17], this.SingleBitMask[bitIndex][18], this.SingleBitMask[bitIndex][19], this.SingleBitMask[bitIndex][20], this.SingleBitMask[bitIndex][21], this.SingleBitMask[bitIndex][22], this.SingleBitMask[bitIndex][23], this.SingleBitMask[bitIndex][24], this.SingleBitMask[bitIndex][25], this.SingleBitMask[bitIndex][26], this.SingleBitMask[bitIndex][27], this.SingleBitMask[bitIndex][28], this.SingleBitMask[bitIndex][29], this.SingleBitMask[bitIndex][30], this.SingleBitMask[bitIndex][31]);
		}

		// Token: 0x170083A3 RID: 33699
		// (get) Token: 0x06036A74 RID: 223860 RVA: 0x00CEF794 File Offset: 0x00CED994
		public FNavAvoidanceMask PlayerAvoidanceGroupMask
		{
			get
			{
				return this.GetSingleBitMask(31);
			}
		}

		// Token: 0x170083A4 RID: 33700
		// (get) Token: 0x06036A75 RID: 223861 RVA: 0x00CEF79E File Offset: 0x00CED99E
		public FNavAvoidanceMask SceneItemAvoidanceGroupMask
		{
			get
			{
				return this.GetSingleBitMask(6);
			}
		}

		// Token: 0x170083A5 RID: 33701
		// (get) Token: 0x06036A76 RID: 223862 RVA: 0x00CEF7A7 File Offset: 0x00CED9A7
		public FNavAvoidanceMask SceneItemGroupsToAvoidMask
		{
			get
			{
				return this.GetSingleBitMask(31);
			}
		}

		// Token: 0x06036A77 RID: 223863 RVA: 0x00CEF7B1 File Offset: 0x00CED9B1
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036A78 RID: 223864 RVA: 0x00CEF7B4 File Offset: 0x00CED9B4
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x170083A6 RID: 33702
		// (get) Token: 0x06036A79 RID: 223865 RVA: 0x00CEF7B7 File Offset: 0x00CED9B7
		public static AvoidanceModel Instance
		{
			get
			{
				return AvoidanceModel._Instance;
			}
		}

		// Token: 0x06036A7A RID: 223866 RVA: 0x00CEF7BE File Offset: 0x00CED9BE
		public static AvoidanceModel GetOrCreateInstance()
		{
			if (AvoidanceModel._Instance == null)
			{
				AvoidanceModel.CreateInstance();
			}
			return AvoidanceModel._Instance;
		}

		// Token: 0x06036A7B RID: 223867 RVA: 0x00CEF7D2 File Offset: 0x00CED9D2
		public static bool CreateInstance()
		{
			if (AvoidanceModel._Instance != null)
			{
				return true;
			}
			AvoidanceModel._Instance = new AvoidanceModel();
			return true;
		}

		// Token: 0x06036A7C RID: 223868 RVA: 0x00CEF7E8 File Offset: 0x00CED9E8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036A7D RID: 223869 RVA: 0x00CEF7EA File Offset: 0x00CED9EA
		public static void ResetStaticDefaultValue()
		{
			AvoidanceModel._Instance = null;
		}

		// Token: 0x06036A7E RID: 223870 RVA: 0x00CEF7F2 File Offset: 0x00CED9F2
		static AvoidanceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AvoidanceModel.CreateStaticDefaultValue), new Action(AvoidanceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE07 RID: 118279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private bool[][] SingleBitMask;

		// Token: 0x0401CE08 RID: 118280
		[Nullable(2)]
		private bool[] ZeroTuple32Internal;

		// Token: 0x0401CE09 RID: 118281
		private readonly bool ReuseZeroTuple = true;

		// Token: 0x0401CE0A RID: 118282
		public readonly bool UseRVOAvoidance;

		// Token: 0x0401CE0B RID: 118283
		public readonly float SceneItemAvoidanceRadius = 200f;

		// Token: 0x0401CE0C RID: 118284
		[Nullable(2)]
		private static AvoidanceModel _Instance;
	}
}
