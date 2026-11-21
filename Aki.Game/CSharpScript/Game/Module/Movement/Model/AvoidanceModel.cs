using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Movement.Model
{
	// Token: 0x02004375 RID: 17269
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AvoidanceModel : ModelBase
	{
		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x0602B9B8 RID: 178616 RVA: 0x00C3E330 File Offset: 0x00C3C530
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

		// Token: 0x0602B9B9 RID: 178617 RVA: 0x00C3E370 File Offset: 0x00C3C570
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
				FNavAvoidanceMask fnavAvoidanceMask = new FNavAvoidanceMask();
				fnavAvoidanceMask.bGroup0 = this.ZeroTuple32[0];
				fnavAvoidanceMask.bGroup1 = this.ZeroTuple32[1];
				fnavAvoidanceMask.bGroup2 = this.ZeroTuple32[2];
				fnavAvoidanceMask.bGroup3 = this.ZeroTuple32[3];
				fnavAvoidanceMask.bGroup4 = this.ZeroTuple32[4];
				fnavAvoidanceMask.bGroup5 = this.ZeroTuple32[5];
				fnavAvoidanceMask.bGroup6 = this.ZeroTuple32[6];
				fnavAvoidanceMask.bGroup7 = this.ZeroTuple32[7];
				fnavAvoidanceMask.bGroup8 = this.ZeroTuple32[8];
				fnavAvoidanceMask.bGroup9 = this.ZeroTuple32[9];
				fnavAvoidanceMask.bGroup10 = this.ZeroTuple32[10];
				fnavAvoidanceMask.bGroup11 = this.ZeroTuple32[11];
				fnavAvoidanceMask.bGroup12 = this.ZeroTuple32[12];
				fnavAvoidanceMask.bGroup13 = this.ZeroTuple32[13];
				fnavAvoidanceMask.bGroup14 = this.ZeroTuple32[14];
				fnavAvoidanceMask.bGroup15 = this.ZeroTuple32[15];
				fnavAvoidanceMask.bGroup16 = this.ZeroTuple32[16];
				fnavAvoidanceMask.bGroup17 = this.ZeroTuple32[17];
				fnavAvoidanceMask.bGroup18 = this.ZeroTuple32[18];
				fnavAvoidanceMask.bGroup19 = this.ZeroTuple32[19];
				fnavAvoidanceMask.bGroup20 = this.ZeroTuple32[20];
				fnavAvoidanceMask.bGroup21 = this.ZeroTuple32[21];
				fnavAvoidanceMask.bGroup22 = this.ZeroTuple32[22];
				fnavAvoidanceMask.bGroup23 = this.ZeroTuple32[23];
				fnavAvoidanceMask.bGroup24 = this.ZeroTuple32[24];
				fnavAvoidanceMask.bGroup25 = this.ZeroTuple32[25];
				fnavAvoidanceMask.bGroup26 = this.ZeroTuple32[26];
				fnavAvoidanceMask.bGroup27 = this.ZeroTuple32[27];
				fnavAvoidanceMask.bGroup28 = this.ZeroTuple32[28];
				fnavAvoidanceMask.bGroup29 = this.ZeroTuple32[29];
				fnavAvoidanceMask.bGroup30 = this.ZeroTuple32[30];
				fnavAvoidanceMask.bGroup31 = this.ZeroTuple32[31];
				this.ZeroTuple32[bitIndex] = false;
				return fnavAvoidanceMask;
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
			return new FNavAvoidanceMask
			{
				bGroup0 = this.SingleBitMask[bitIndex][0],
				bGroup1 = this.SingleBitMask[bitIndex][1],
				bGroup2 = this.SingleBitMask[bitIndex][2],
				bGroup3 = this.SingleBitMask[bitIndex][3],
				bGroup4 = this.SingleBitMask[bitIndex][4],
				bGroup5 = this.SingleBitMask[bitIndex][5],
				bGroup6 = this.SingleBitMask[bitIndex][6],
				bGroup7 = this.SingleBitMask[bitIndex][7],
				bGroup8 = this.SingleBitMask[bitIndex][8],
				bGroup9 = this.SingleBitMask[bitIndex][9],
				bGroup10 = this.SingleBitMask[bitIndex][10],
				bGroup11 = this.SingleBitMask[bitIndex][11],
				bGroup12 = this.SingleBitMask[bitIndex][12],
				bGroup13 = this.SingleBitMask[bitIndex][13],
				bGroup14 = this.SingleBitMask[bitIndex][14],
				bGroup15 = this.SingleBitMask[bitIndex][15],
				bGroup16 = this.SingleBitMask[bitIndex][16],
				bGroup17 = this.SingleBitMask[bitIndex][17],
				bGroup18 = this.SingleBitMask[bitIndex][18],
				bGroup19 = this.SingleBitMask[bitIndex][19],
				bGroup20 = this.SingleBitMask[bitIndex][20],
				bGroup21 = this.SingleBitMask[bitIndex][21],
				bGroup22 = this.SingleBitMask[bitIndex][22],
				bGroup23 = this.SingleBitMask[bitIndex][23],
				bGroup24 = this.SingleBitMask[bitIndex][24],
				bGroup25 = this.SingleBitMask[bitIndex][25],
				bGroup26 = this.SingleBitMask[bitIndex][26],
				bGroup27 = this.SingleBitMask[bitIndex][27],
				bGroup28 = this.SingleBitMask[bitIndex][28],
				bGroup29 = this.SingleBitMask[bitIndex][29],
				bGroup30 = this.SingleBitMask[bitIndex][30],
				bGroup31 = this.SingleBitMask[bitIndex][31]
			};
		}

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x0602B9BA RID: 178618 RVA: 0x00C3E83C File Offset: 0x00C3CA3C
		public FNavAvoidanceMask PlayerAvoidanceGroupMask
		{
			get
			{
				return this.GetSingleBitMask(31);
			}
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x0602B9BB RID: 178619 RVA: 0x00C3E846 File Offset: 0x00C3CA46
		public FNavAvoidanceMask SceneItemAvoidanceGroupMask
		{
			get
			{
				return this.GetSingleBitMask(6);
			}
		}

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x0602B9BC RID: 178620 RVA: 0x00C3E84F File Offset: 0x00C3CA4F
		public FNavAvoidanceMask SceneItemGroupsToAvoidMask
		{
			get
			{
				return this.GetSingleBitMask(31);
			}
		}

		// Token: 0x0602B9BD RID: 178621 RVA: 0x00C3E859 File Offset: 0x00C3CA59
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602B9BE RID: 178622 RVA: 0x00C3E85C File Offset: 0x00C3CA5C
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x0602B9BF RID: 178623 RVA: 0x00C3E85F File Offset: 0x00C3CA5F
		public static AvoidanceModel Instance
		{
			get
			{
				return AvoidanceModel._Instance;
			}
		}

		// Token: 0x0602B9C0 RID: 178624 RVA: 0x00C3E866 File Offset: 0x00C3CA66
		public static AvoidanceModel GetOrCreateInstance()
		{
			if (AvoidanceModel._Instance == null)
			{
				AvoidanceModel.CreateInstance();
			}
			return AvoidanceModel._Instance;
		}

		// Token: 0x0602B9C1 RID: 178625 RVA: 0x00C3E87A File Offset: 0x00C3CA7A
		public static bool CreateInstance()
		{
			if (AvoidanceModel._Instance != null)
			{
				return true;
			}
			AvoidanceModel._Instance = new AvoidanceModel();
			return true;
		}

		// Token: 0x0602B9C2 RID: 178626 RVA: 0x00C3E890 File Offset: 0x00C3CA90
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B9C3 RID: 178627 RVA: 0x00C3E892 File Offset: 0x00C3CA92
		public static void ResetStaticDefaultValue()
		{
			AvoidanceModel._Instance = null;
		}

		// Token: 0x0602B9C4 RID: 178628 RVA: 0x00C3E89A File Offset: 0x00C3CA9A
		static AvoidanceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AvoidanceModel.CreateStaticDefaultValue), new Action(AvoidanceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401789F RID: 96415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private bool[][] SingleBitMask;

		// Token: 0x040178A0 RID: 96416
		[Nullable(2)]
		private bool[] ZeroTuple32Internal;

		// Token: 0x040178A1 RID: 96417
		private readonly bool ReuseZeroTuple = true;

		// Token: 0x040178A2 RID: 96418
		public readonly bool UseRVOAvoidance;

		// Token: 0x040178A3 RID: 96419
		public readonly float SceneItemAvoidanceRadius = 200f;

		// Token: 0x040178A4 RID: 96420
		[Nullable(2)]
		private static AvoidanceModel _Instance;
	}
}
