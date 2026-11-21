using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E93 RID: 20115
	public struct ICheckDrinksPreferenceLevel : IFlatbufferObject
	{
		// Token: 0x17008F78 RID: 36728
		// (get) Token: 0x0601F2A9 RID: 127657 RVA: 0x00458BBC File Offset: 0x00456DBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2AA RID: 127658 RVA: 0x00458BC9 File Offset: 0x00456DC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2AB RID: 127659 RVA: 0x00458BD0 File Offset: 0x00456DD0
		public static ICheckDrinksPreferenceLevel GetRootAsICheckDrinksPreferenceLevel(ByteBuffer _bb)
		{
			return ICheckDrinksPreferenceLevel.GetRootAsICheckDrinksPreferenceLevel(_bb, default(ICheckDrinksPreferenceLevel));
		}

		// Token: 0x0601F2AC RID: 127660 RVA: 0x00458BEC File Offset: 0x00456DEC
		public static ICheckDrinksPreferenceLevel GetRootAsICheckDrinksPreferenceLevel(ByteBuffer _bb, ICheckDrinksPreferenceLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2AD RID: 127661 RVA: 0x00458C09 File Offset: 0x00456E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2AE RID: 127662 RVA: 0x00458C18 File Offset: 0x00456E18
		public ICheckDrinksPreferenceLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F79 RID: 36729
		// (get) Token: 0x0601F2AF RID: 127663 RVA: 0x00458C28 File Offset: 0x00456E28
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

		// Token: 0x17008F7A RID: 36730
		// (get) Token: 0x0601F2B0 RID: 127664 RVA: 0x00458C64 File Offset: 0x00456E64
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

		// Token: 0x17008F7B RID: 36731
		// (get) Token: 0x0601F2B1 RID: 127665 RVA: 0x00458CA0 File Offset: 0x00456EA0
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

		// Token: 0x0601F2B2 RID: 127666 RVA: 0x00458CDC File Offset: 0x00456EDC
		public static Offset<ICheckDrinksPreferenceLevel> CreateICheckDrinksPreferenceLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, EDrinksPreferenceLevel Level = EDrinksPreferenceLevel.DisLike)
		{
			builder.StartTable(3);
			ICheckDrinksPreferenceLevel.AddLevel(builder, Level);
			ICheckDrinksPreferenceLevel.AddCompare(builder, Compare);
			ICheckDrinksPreferenceLevel.AddType(builder, Type);
			return ICheckDrinksPreferenceLevel.EndICheckDrinksPreferenceLevel(builder);
		}

		// Token: 0x0601F2B3 RID: 127667 RVA: 0x00458D00 File Offset: 0x00456F00
		public static void StartICheckDrinksPreferenceLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F2B4 RID: 127668 RVA: 0x00458D09 File Offset: 0x00456F09
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2B5 RID: 127669 RVA: 0x00458D14 File Offset: 0x00456F14
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F2B6 RID: 127670 RVA: 0x00458D1F File Offset: 0x00456F1F
		public static void AddLevel(FlatBufferBuilder builder, EDrinksPreferenceLevel level)
		{
			builder.AddByte(2, (byte)level, 0);
		}

		// Token: 0x0601F2B7 RID: 127671 RVA: 0x00458D2A File Offset: 0x00456F2A
		public static Offset<ICheckDrinksPreferenceLevel> EndICheckDrinksPreferenceLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDrinksPreferenceLevel>(builder.EndTable());
		}

		// Token: 0x0601F2B8 RID: 127672 RVA: 0x00458D38 File Offset: 0x00456F38
		public ICheckDrinksPreferenceLevelT UnPack()
		{
			ICheckDrinksPreferenceLevelT checkDrinksPreferenceLevelT = new ICheckDrinksPreferenceLevelT();
			this.UnPackTo(checkDrinksPreferenceLevelT);
			return checkDrinksPreferenceLevelT;
		}

		// Token: 0x0601F2B9 RID: 127673 RVA: 0x00458D53 File Offset: 0x00456F53
		public void UnPackTo(ICheckDrinksPreferenceLevelT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F2BA RID: 127674 RVA: 0x00458D7C File Offset: 0x00456F7C
		public static Offset<ICheckDrinksPreferenceLevel> Pack(FlatBufferBuilder builder, ICheckDrinksPreferenceLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDrinksPreferenceLevel>);
			}
			return ICheckDrinksPreferenceLevel.CreateICheckDrinksPreferenceLevel(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400DCD3 RID: 56531
		private Table __p;
	}
}
