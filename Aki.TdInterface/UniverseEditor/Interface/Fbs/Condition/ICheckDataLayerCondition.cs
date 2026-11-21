using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E81 RID: 20097
	public struct ICheckDataLayerCondition : IFlatbufferObject
	{
		// Token: 0x17008F50 RID: 36688
		// (get) Token: 0x0601F20B RID: 127499 RVA: 0x00457A32 File Offset: 0x00455C32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F20C RID: 127500 RVA: 0x00457A3F File Offset: 0x00455C3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F20D RID: 127501 RVA: 0x00457A48 File Offset: 0x00455C48
		public static ICheckDataLayerCondition GetRootAsICheckDataLayerCondition(ByteBuffer _bb)
		{
			return ICheckDataLayerCondition.GetRootAsICheckDataLayerCondition(_bb, default(ICheckDataLayerCondition));
		}

		// Token: 0x0601F20E RID: 127502 RVA: 0x00457A64 File Offset: 0x00455C64
		public static ICheckDataLayerCondition GetRootAsICheckDataLayerCondition(ByteBuffer _bb, ICheckDataLayerCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F20F RID: 127503 RVA: 0x00457A81 File Offset: 0x00455C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F210 RID: 127504 RVA: 0x00457A90 File Offset: 0x00455C90
		public ICheckDataLayerCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F51 RID: 36689
		// (get) Token: 0x0601F211 RID: 127505 RVA: 0x00457AA0 File Offset: 0x00455CA0
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

		// Token: 0x17008F52 RID: 36690
		// (get) Token: 0x0601F212 RID: 127506 RVA: 0x00457ADC File Offset: 0x00455CDC
		public bool IsLoad
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008F53 RID: 36691
		// (get) Token: 0x0601F213 RID: 127507 RVA: 0x00457B1C File Offset: 0x00455D1C
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

		// Token: 0x0601F214 RID: 127508 RVA: 0x00457B58 File Offset: 0x00455D58
		public static Offset<ICheckDataLayerCondition> CreateICheckDataLayerCondition(FlatBufferBuilder builder, int DataLayerId = 0, bool IsLoad = false, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(3);
			ICheckDataLayerCondition.AddDataLayerId(builder, DataLayerId);
			ICheckDataLayerCondition.AddType(builder, Type);
			ICheckDataLayerCondition.AddIsLoad(builder, IsLoad);
			return ICheckDataLayerCondition.EndICheckDataLayerCondition(builder);
		}

		// Token: 0x0601F215 RID: 127509 RVA: 0x00457B7C File Offset: 0x00455D7C
		public static void StartICheckDataLayerCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F216 RID: 127510 RVA: 0x00457B85 File Offset: 0x00455D85
		public static void AddDataLayerId(FlatBufferBuilder builder, int dataLayerId)
		{
			builder.AddInt(0, dataLayerId, 0);
		}

		// Token: 0x0601F217 RID: 127511 RVA: 0x00457B90 File Offset: 0x00455D90
		public static void AddIsLoad(FlatBufferBuilder builder, bool isLoad)
		{
			builder.AddBool(1, isLoad, false);
		}

		// Token: 0x0601F218 RID: 127512 RVA: 0x00457B9B File Offset: 0x00455D9B
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601F219 RID: 127513 RVA: 0x00457BA6 File Offset: 0x00455DA6
		public static Offset<ICheckDataLayerCondition> EndICheckDataLayerCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDataLayerCondition>(builder.EndTable());
		}

		// Token: 0x0601F21A RID: 127514 RVA: 0x00457BB4 File Offset: 0x00455DB4
		public ICheckDataLayerConditionT UnPack()
		{
			ICheckDataLayerConditionT checkDataLayerConditionT = new ICheckDataLayerConditionT();
			this.UnPackTo(checkDataLayerConditionT);
			return checkDataLayerConditionT;
		}

		// Token: 0x0601F21B RID: 127515 RVA: 0x00457BCF File Offset: 0x00455DCF
		public void UnPackTo(ICheckDataLayerConditionT _o)
		{
			_o.DataLayerId = this.DataLayerId;
			_o.IsLoad = this.IsLoad;
			_o.Type = this.Type;
		}

		// Token: 0x0601F21C RID: 127516 RVA: 0x00457BF8 File Offset: 0x00455DF8
		public static Offset<ICheckDataLayerCondition> Pack(FlatBufferBuilder builder, ICheckDataLayerConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDataLayerCondition>);
			}
			return ICheckDataLayerCondition.CreateICheckDataLayerCondition(builder, _o.DataLayerId, _o.IsLoad, _o.Type);
		}

		// Token: 0x0400DCBC RID: 56508
		private Table __p;
	}
}
