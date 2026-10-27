using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C6D RID: 15469
	public struct ITriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17006AB4 RID: 27316
		// (get) Token: 0x0601568F RID: 87695 RVA: 0x00318666 File Offset: 0x00316866
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015690 RID: 87696 RVA: 0x00318673 File Offset: 0x00316873
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015691 RID: 87697 RVA: 0x0031867C File Offset: 0x0031687C
		public static ITriggerTipShape GetRootAsITriggerTipShape(ByteBuffer _bb)
		{
			return ITriggerTipShape.GetRootAsITriggerTipShape(_bb, default(ITriggerTipShape));
		}

		// Token: 0x06015692 RID: 87698 RVA: 0x00318698 File Offset: 0x00316898
		public static ITriggerTipShape GetRootAsITriggerTipShape(ByteBuffer _bb, ITriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015693 RID: 87699 RVA: 0x003186B5 File Offset: 0x003168B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015694 RID: 87700 RVA: 0x003186C4 File Offset: 0x003168C4
		public ITriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AB5 RID: 27317
		// (get) Token: 0x06015695 RID: 87701 RVA: 0x003186D4 File Offset: 0x003168D4
		public ETriggerTipShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerTipShape.Box;
				}
				return (ETriggerTipShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015696 RID: 87702 RVA: 0x00318710 File Offset: 0x00316910
		public static Offset<ITriggerTipShape> CreateITriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box)
		{
			builder.StartTable(1);
			ITriggerTipShape.AddType(builder, Type);
			return ITriggerTipShape.EndITriggerTipShape(builder);
		}

		// Token: 0x06015697 RID: 87703 RVA: 0x00318726 File Offset: 0x00316926
		public static void StartITriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015698 RID: 87704 RVA: 0x0031872F File Offset: 0x0031692F
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015699 RID: 87705 RVA: 0x0031873A File Offset: 0x0031693A
		public static Offset<ITriggerTipShape> EndITriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerTipShape>(builder.EndTable());
		}

		// Token: 0x0601569A RID: 87706 RVA: 0x00318748 File Offset: 0x00316948
		public ITriggerTipShapeT UnPack()
		{
			ITriggerTipShapeT triggerTipShapeT = new ITriggerTipShapeT();
			this.UnPackTo(triggerTipShapeT);
			return triggerTipShapeT;
		}

		// Token: 0x0601569B RID: 87707 RVA: 0x00318763 File Offset: 0x00316963
		public void UnPackTo(ITriggerTipShapeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601569C RID: 87708 RVA: 0x00318774 File Offset: 0x00316974
		public static Offset<ITriggerTipShape> Pack(FlatBufferBuilder builder, ITriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerTipShape>);
			}
			return ITriggerTipShape.CreateITriggerTipShape(builder, _o.Type);
		}

		// Token: 0x0400B2A0 RID: 45728
		private Table __p;
	}
}
