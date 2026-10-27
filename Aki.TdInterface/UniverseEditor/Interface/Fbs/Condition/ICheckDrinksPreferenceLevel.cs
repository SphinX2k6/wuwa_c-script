using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D3 RID: 18899
	public struct ICheckDrinksPreferenceLevel : IFlatbufferObject
	{
		// Token: 0x170088A8 RID: 34984
		// (get) Token: 0x0601D836 RID: 120886 RVA: 0x00427F50 File Offset: 0x00426150
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D837 RID: 120887 RVA: 0x00427F5D File Offset: 0x0042615D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D838 RID: 120888 RVA: 0x00427F64 File Offset: 0x00426164
		public static ICheckDrinksPreferenceLevel GetRootAsICheckDrinksPreferenceLevel(ByteBuffer _bb)
		{
			return ICheckDrinksPreferenceLevel.GetRootAsICheckDrinksPreferenceLevel(_bb, default(ICheckDrinksPreferenceLevel));
		}

		// Token: 0x0601D839 RID: 120889 RVA: 0x00427F80 File Offset: 0x00426180
		public static ICheckDrinksPreferenceLevel GetRootAsICheckDrinksPreferenceLevel(ByteBuffer _bb, ICheckDrinksPreferenceLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D83A RID: 120890 RVA: 0x00427F9D File Offset: 0x0042619D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D83B RID: 120891 RVA: 0x00427FAC File Offset: 0x004261AC
		public ICheckDrinksPreferenceLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088A9 RID: 34985
		// (get) Token: 0x0601D83C RID: 120892 RVA: 0x00427FBC File Offset: 0x004261BC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088AA RID: 34986
		// (get) Token: 0x0601D83D RID: 120893 RVA: 0x00427FF8 File Offset: 0x004261F8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088AB RID: 34987
		// (get) Token: 0x0601D83E RID: 120894 RVA: 0x00428034 File Offset: 0x00426234
		public EDrinksPreferenceLevel Level
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EDrinksPreferenceLevel.DisLike;
				}
				return (EDrinksPreferenceLevel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D83F RID: 120895 RVA: 0x00428070 File Offset: 0x00426270
		public static Offset<ICheckDrinksPreferenceLevel> CreateICheckDrinksPreferenceLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, EDrinksPreferenceLevel Level = EDrinksPreferenceLevel.DisLike)
		{
			builder.StartTable(3);
			ICheckDrinksPreferenceLevel.AddLevel(builder, Level);
			ICheckDrinksPreferenceLevel.AddCompare(builder, Compare);
			ICheckDrinksPreferenceLevel.AddType(builder, Type);
			return ICheckDrinksPreferenceLevel.EndICheckDrinksPreferenceLevel(builder);
		}

		// Token: 0x0601D840 RID: 120896 RVA: 0x00428094 File Offset: 0x00426294
		public static void StartICheckDrinksPreferenceLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D841 RID: 120897 RVA: 0x0042809D File Offset: 0x0042629D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D842 RID: 120898 RVA: 0x004280A8 File Offset: 0x004262A8
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601D843 RID: 120899 RVA: 0x004280B3 File Offset: 0x004262B3
		public static void AddLevel(FlatBufferBuilder builder, EDrinksPreferenceLevel level)
		{
			builder.AddByte(2, (byte)level, 0);
		}

		// Token: 0x0601D844 RID: 120900 RVA: 0x004280BE File Offset: 0x004262BE
		public static Offset<ICheckDrinksPreferenceLevel> EndICheckDrinksPreferenceLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDrinksPreferenceLevel>(builder.EndTable());
		}

		// Token: 0x0601D845 RID: 120901 RVA: 0x004280CC File Offset: 0x004262CC
		public ICheckDrinksPreferenceLevelT UnPack()
		{
			ICheckDrinksPreferenceLevelT checkDrinksPreferenceLevelT = new ICheckDrinksPreferenceLevelT();
			this.UnPackTo(checkDrinksPreferenceLevelT);
			return checkDrinksPreferenceLevelT;
		}

		// Token: 0x0601D846 RID: 120902 RVA: 0x004280E7 File Offset: 0x004262E7
		public void UnPackTo(ICheckDrinksPreferenceLevelT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601D847 RID: 120903 RVA: 0x00428110 File Offset: 0x00426310
		public static Offset<ICheckDrinksPreferenceLevel> Pack(FlatBufferBuilder builder, ICheckDrinksPreferenceLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDrinksPreferenceLevel>);
			}
			return ICheckDrinksPreferenceLevel.CreateICheckDrinksPreferenceLevel(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400D1FF RID: 53759
		private Table __p;
	}
}
