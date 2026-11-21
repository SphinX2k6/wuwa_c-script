using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F1A RID: 20250
	public struct ICheckHonamiStoryChestOpenTime : IFlatbufferObject
	{
		// Token: 0x17009098 RID: 37016
		// (get) Token: 0x0601F765 RID: 128869 RVA: 0x00461574 File Offset: 0x0045F774
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F766 RID: 128870 RVA: 0x00461581 File Offset: 0x0045F781
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F767 RID: 128871 RVA: 0x00461588 File Offset: 0x0045F788
		public static ICheckHonamiStoryChestOpenTime GetRootAsICheckHonamiStoryChestOpenTime(ByteBuffer _bb)
		{
			return ICheckHonamiStoryChestOpenTime.GetRootAsICheckHonamiStoryChestOpenTime(_bb, default(ICheckHonamiStoryChestOpenTime));
		}

		// Token: 0x0601F768 RID: 128872 RVA: 0x004615A4 File Offset: 0x0045F7A4
		public static ICheckHonamiStoryChestOpenTime GetRootAsICheckHonamiStoryChestOpenTime(ByteBuffer _bb, ICheckHonamiStoryChestOpenTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F769 RID: 128873 RVA: 0x004615C1 File Offset: 0x0045F7C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F76A RID: 128874 RVA: 0x004615D0 File Offset: 0x0045F7D0
		public ICheckHonamiStoryChestOpenTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009099 RID: 37017
		// (get) Token: 0x0601F76B RID: 128875 RVA: 0x004615E0 File Offset: 0x0045F7E0
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

		// Token: 0x1700909A RID: 37018
		// (get) Token: 0x0601F76C RID: 128876 RVA: 0x0046161C File Offset: 0x0045F81C
		public EHonamiStoryChestType ChestType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHonamiStoryChestType.CommonChest;
				}
				return (EHonamiStoryChestType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700909B RID: 37019
		// (get) Token: 0x0601F76D RID: 128877 RVA: 0x00461658 File Offset: 0x0045F858
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700909C RID: 37020
		// (get) Token: 0x0601F76E RID: 128878 RVA: 0x00461694 File Offset: 0x0045F894
		public int Time
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F76F RID: 128879 RVA: 0x004616D1 File Offset: 0x0045F8D1
		public static Offset<ICheckHonamiStoryChestOpenTime> CreateICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EHonamiStoryChestType ChestType = EHonamiStoryChestType.CommonChest, ECompare Compare = ECompare.Eq, int Time = 0)
		{
			builder.StartTable(4);
			ICheckHonamiStoryChestOpenTime.AddTime(builder, Time);
			ICheckHonamiStoryChestOpenTime.AddCompare(builder, Compare);
			ICheckHonamiStoryChestOpenTime.AddChestType(builder, ChestType);
			ICheckHonamiStoryChestOpenTime.AddType(builder, Type);
			return ICheckHonamiStoryChestOpenTime.EndICheckHonamiStoryChestOpenTime(builder);
		}

		// Token: 0x0601F770 RID: 128880 RVA: 0x004616FD File Offset: 0x0045F8FD
		public static void StartICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F771 RID: 128881 RVA: 0x00461706 File Offset: 0x0045F906
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F772 RID: 128882 RVA: 0x00461711 File Offset: 0x0045F911
		public static void AddChestType(FlatBufferBuilder builder, EHonamiStoryChestType chestType)
		{
			builder.AddByte(1, (byte)chestType, 0);
		}

		// Token: 0x0601F773 RID: 128883 RVA: 0x0046171C File Offset: 0x0045F91C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F774 RID: 128884 RVA: 0x00461727 File Offset: 0x0045F927
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(3, time, 0);
		}

		// Token: 0x0601F775 RID: 128885 RVA: 0x00461732 File Offset: 0x0045F932
		public static Offset<ICheckHonamiStoryChestOpenTime> EndICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryChestOpenTime>(builder.EndTable());
		}

		// Token: 0x0601F776 RID: 128886 RVA: 0x00461740 File Offset: 0x0045F940
		public ICheckHonamiStoryChestOpenTimeT UnPack()
		{
			ICheckHonamiStoryChestOpenTimeT checkHonamiStoryChestOpenTimeT = new ICheckHonamiStoryChestOpenTimeT();
			this.UnPackTo(checkHonamiStoryChestOpenTimeT);
			return checkHonamiStoryChestOpenTimeT;
		}

		// Token: 0x0601F777 RID: 128887 RVA: 0x0046175B File Offset: 0x0045F95B
		public void UnPackTo(ICheckHonamiStoryChestOpenTimeT _o)
		{
			_o.Type = this.Type;
			_o.ChestType = this.ChestType;
			_o.Compare = this.Compare;
			_o.Time = this.Time;
		}

		// Token: 0x0601F778 RID: 128888 RVA: 0x00461790 File Offset: 0x0045F990
		public static Offset<ICheckHonamiStoryChestOpenTime> Pack(FlatBufferBuilder builder, ICheckHonamiStoryChestOpenTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryChestOpenTime>);
			}
			return ICheckHonamiStoryChestOpenTime.CreateICheckHonamiStoryChestOpenTime(builder, _o.Type, _o.ChestType, _o.Compare, _o.Time);
		}

		// Token: 0x0400DD8A RID: 56714
		private Table __p;
	}
}
