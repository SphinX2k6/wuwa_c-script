using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A54 RID: 19028
	public struct ICheckHonamiStoryChestOpenTime : IFlatbufferObject
	{
		// Token: 0x170089BC RID: 35260
		// (get) Token: 0x0601DCC2 RID: 122050 RVA: 0x004303E8 File Offset: 0x0042E5E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCC3 RID: 122051 RVA: 0x004303F5 File Offset: 0x0042E5F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCC4 RID: 122052 RVA: 0x004303FC File Offset: 0x0042E5FC
		public static ICheckHonamiStoryChestOpenTime GetRootAsICheckHonamiStoryChestOpenTime(ByteBuffer _bb)
		{
			return ICheckHonamiStoryChestOpenTime.GetRootAsICheckHonamiStoryChestOpenTime(_bb, default(ICheckHonamiStoryChestOpenTime));
		}

		// Token: 0x0601DCC5 RID: 122053 RVA: 0x00430418 File Offset: 0x0042E618
		public static ICheckHonamiStoryChestOpenTime GetRootAsICheckHonamiStoryChestOpenTime(ByteBuffer _bb, ICheckHonamiStoryChestOpenTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCC6 RID: 122054 RVA: 0x00430435 File Offset: 0x0042E635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCC7 RID: 122055 RVA: 0x00430444 File Offset: 0x0042E644
		public ICheckHonamiStoryChestOpenTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089BD RID: 35261
		// (get) Token: 0x0601DCC8 RID: 122056 RVA: 0x00430454 File Offset: 0x0042E654
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

		// Token: 0x170089BE RID: 35262
		// (get) Token: 0x0601DCC9 RID: 122057 RVA: 0x00430490 File Offset: 0x0042E690
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

		// Token: 0x170089BF RID: 35263
		// (get) Token: 0x0601DCCA RID: 122058 RVA: 0x004304CC File Offset: 0x0042E6CC
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

		// Token: 0x170089C0 RID: 35264
		// (get) Token: 0x0601DCCB RID: 122059 RVA: 0x00430508 File Offset: 0x0042E708
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

		// Token: 0x0601DCCC RID: 122060 RVA: 0x00430545 File Offset: 0x0042E745
		public static Offset<ICheckHonamiStoryChestOpenTime> CreateICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EHonamiStoryChestType ChestType = EHonamiStoryChestType.CommonChest, ECompare Compare = ECompare.Eq, int Time = 0)
		{
			builder.StartTable(4);
			ICheckHonamiStoryChestOpenTime.AddTime(builder, Time);
			ICheckHonamiStoryChestOpenTime.AddCompare(builder, Compare);
			ICheckHonamiStoryChestOpenTime.AddChestType(builder, ChestType);
			ICheckHonamiStoryChestOpenTime.AddType(builder, Type);
			return ICheckHonamiStoryChestOpenTime.EndICheckHonamiStoryChestOpenTime(builder);
		}

		// Token: 0x0601DCCD RID: 122061 RVA: 0x00430571 File Offset: 0x0042E771
		public static void StartICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DCCE RID: 122062 RVA: 0x0043057A File Offset: 0x0042E77A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DCCF RID: 122063 RVA: 0x00430585 File Offset: 0x0042E785
		public static void AddChestType(FlatBufferBuilder builder, EHonamiStoryChestType chestType)
		{
			builder.AddByte(1, (byte)chestType, 0);
		}

		// Token: 0x0601DCD0 RID: 122064 RVA: 0x00430590 File Offset: 0x0042E790
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601DCD1 RID: 122065 RVA: 0x0043059B File Offset: 0x0042E79B
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(3, time, 0);
		}

		// Token: 0x0601DCD2 RID: 122066 RVA: 0x004305A6 File Offset: 0x0042E7A6
		public static Offset<ICheckHonamiStoryChestOpenTime> EndICheckHonamiStoryChestOpenTime(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryChestOpenTime>(builder.EndTable());
		}

		// Token: 0x0601DCD3 RID: 122067 RVA: 0x004305B4 File Offset: 0x0042E7B4
		public ICheckHonamiStoryChestOpenTimeT UnPack()
		{
			ICheckHonamiStoryChestOpenTimeT checkHonamiStoryChestOpenTimeT = new ICheckHonamiStoryChestOpenTimeT();
			this.UnPackTo(checkHonamiStoryChestOpenTimeT);
			return checkHonamiStoryChestOpenTimeT;
		}

		// Token: 0x0601DCD4 RID: 122068 RVA: 0x004305CF File Offset: 0x0042E7CF
		public void UnPackTo(ICheckHonamiStoryChestOpenTimeT _o)
		{
			_o.Type = this.Type;
			_o.ChestType = this.ChestType;
			_o.Compare = this.Compare;
			_o.Time = this.Time;
		}

		// Token: 0x0601DCD5 RID: 122069 RVA: 0x00430604 File Offset: 0x0042E804
		public static Offset<ICheckHonamiStoryChestOpenTime> Pack(FlatBufferBuilder builder, ICheckHonamiStoryChestOpenTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryChestOpenTime>);
			}
			return ICheckHonamiStoryChestOpenTime.CreateICheckHonamiStoryChestOpenTime(builder, _o.Type, _o.ChestType, _o.Compare, _o.Time);
		}

		// Token: 0x0400D2AF RID: 53935
		private Table __p;
	}
}
