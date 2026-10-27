using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C4 RID: 18884
	public struct ICheckDataLayerCondition : IFlatbufferObject
	{
		// Token: 0x17008887 RID: 34951
		// (get) Token: 0x0601D7B2 RID: 120754 RVA: 0x00427056 File Offset: 0x00425256
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7B3 RID: 120755 RVA: 0x00427063 File Offset: 0x00425263
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7B4 RID: 120756 RVA: 0x0042706C File Offset: 0x0042526C
		public static ICheckDataLayerCondition GetRootAsICheckDataLayerCondition(ByteBuffer _bb)
		{
			return ICheckDataLayerCondition.GetRootAsICheckDataLayerCondition(_bb, default(ICheckDataLayerCondition));
		}

		// Token: 0x0601D7B5 RID: 120757 RVA: 0x00427088 File Offset: 0x00425288
		public static ICheckDataLayerCondition GetRootAsICheckDataLayerCondition(ByteBuffer _bb, ICheckDataLayerCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7B6 RID: 120758 RVA: 0x004270A5 File Offset: 0x004252A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7B7 RID: 120759 RVA: 0x004270B4 File Offset: 0x004252B4
		public ICheckDataLayerCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008888 RID: 34952
		// (get) Token: 0x0601D7B8 RID: 120760 RVA: 0x004270C4 File Offset: 0x004252C4
		public int DataLayerId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008889 RID: 34953
		// (get) Token: 0x0601D7B9 RID: 120761 RVA: 0x00427100 File Offset: 0x00425300
		public bool IsLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700888A RID: 34954
		// (get) Token: 0x0601D7BA RID: 120762 RVA: 0x00427140 File Offset: 0x00425340
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D7BB RID: 120763 RVA: 0x0042717C File Offset: 0x0042537C
		public static Offset<ICheckDataLayerCondition> CreateICheckDataLayerCondition(FlatBufferBuilder builder, int DataLayerId = 0, bool IsLoad = false, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(3);
			ICheckDataLayerCondition.AddDataLayerId(builder, DataLayerId);
			ICheckDataLayerCondition.AddType(builder, Type);
			ICheckDataLayerCondition.AddIsLoad(builder, IsLoad);
			return ICheckDataLayerCondition.EndICheckDataLayerCondition(builder);
		}

		// Token: 0x0601D7BC RID: 120764 RVA: 0x004271A0 File Offset: 0x004253A0
		public static void StartICheckDataLayerCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D7BD RID: 120765 RVA: 0x004271A9 File Offset: 0x004253A9
		public static void AddDataLayerId(FlatBufferBuilder builder, int dataLayerId)
		{
			builder.AddInt(0, dataLayerId, 0);
		}

		// Token: 0x0601D7BE RID: 120766 RVA: 0x004271B4 File Offset: 0x004253B4
		public static void AddIsLoad(FlatBufferBuilder builder, bool isLoad)
		{
			builder.AddBool(1, isLoad, false);
		}

		// Token: 0x0601D7BF RID: 120767 RVA: 0x004271BF File Offset: 0x004253BF
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601D7C0 RID: 120768 RVA: 0x004271CA File Offset: 0x004253CA
		public static Offset<ICheckDataLayerCondition> EndICheckDataLayerCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDataLayerCondition>(builder.EndTable());
		}

		// Token: 0x0601D7C1 RID: 120769 RVA: 0x004271D8 File Offset: 0x004253D8
		public ICheckDataLayerConditionT UnPack()
		{
			ICheckDataLayerConditionT checkDataLayerConditionT = new ICheckDataLayerConditionT();
			this.UnPackTo(checkDataLayerConditionT);
			return checkDataLayerConditionT;
		}

		// Token: 0x0601D7C2 RID: 120770 RVA: 0x004271F3 File Offset: 0x004253F3
		public void UnPackTo(ICheckDataLayerConditionT _o)
		{
			_o.DataLayerId = this.DataLayerId;
			_o.IsLoad = this.IsLoad;
			_o.Type = this.Type;
		}

		// Token: 0x0601D7C3 RID: 120771 RVA: 0x0042721C File Offset: 0x0042541C
		public static Offset<ICheckDataLayerCondition> Pack(FlatBufferBuilder builder, ICheckDataLayerConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDataLayerCondition>);
			}
			return ICheckDataLayerCondition.CreateICheckDataLayerCondition(builder, _o.DataLayerId, _o.IsLoad, _o.Type);
		}

		// Token: 0x0400D1EC RID: 53740
		private Table __p;
	}
}
