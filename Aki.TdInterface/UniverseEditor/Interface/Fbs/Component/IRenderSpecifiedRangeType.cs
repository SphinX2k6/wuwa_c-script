using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E59 RID: 24153
	public struct IRenderSpecifiedRangeType : IFlatbufferObject
	{
		// Token: 0x1700B221 RID: 45601
		// (get) Token: 0x06028615 RID: 165397 RVA: 0x00585A52 File Offset: 0x00583C52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028616 RID: 165398 RVA: 0x00585A5F File Offset: 0x00583C5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028617 RID: 165399 RVA: 0x00585A68 File Offset: 0x00583C68
		public static IRenderSpecifiedRangeType GetRootAsIRenderSpecifiedRangeType(ByteBuffer _bb)
		{
			return IRenderSpecifiedRangeType.GetRootAsIRenderSpecifiedRangeType(_bb, default(IRenderSpecifiedRangeType));
		}

		// Token: 0x06028618 RID: 165400 RVA: 0x00585A84 File Offset: 0x00583C84
		public static IRenderSpecifiedRangeType GetRootAsIRenderSpecifiedRangeType(ByteBuffer _bb, IRenderSpecifiedRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028619 RID: 165401 RVA: 0x00585AA1 File Offset: 0x00583CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602861A RID: 165402 RVA: 0x00585AB0 File Offset: 0x00583CB0
		public IRenderSpecifiedRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B222 RID: 45602
		// (get) Token: 0x0602861B RID: 165403 RVA: 0x00585AC0 File Offset: 0x00583CC0
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602861C RID: 165404 RVA: 0x00585AFC File Offset: 0x00583CFC
		public static Offset<IRenderSpecifiedRangeType> CreateIRenderSpecifiedRangeType(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge)
		{
			builder.StartTable(1);
			IRenderSpecifiedRangeType.AddType(builder, Type);
			return IRenderSpecifiedRangeType.EndIRenderSpecifiedRangeType(builder);
		}

		// Token: 0x0602861D RID: 165405 RVA: 0x00585B12 File Offset: 0x00583D12
		public static void StartIRenderSpecifiedRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602861E RID: 165406 RVA: 0x00585B1B File Offset: 0x00583D1B
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602861F RID: 165407 RVA: 0x00585B26 File Offset: 0x00583D26
		public static Offset<IRenderSpecifiedRangeType> EndIRenderSpecifiedRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IRenderSpecifiedRangeType>(builder.EndTable());
		}

		// Token: 0x06028620 RID: 165408 RVA: 0x00585B34 File Offset: 0x00583D34
		public IRenderSpecifiedRangeTypeT UnPack()
		{
			IRenderSpecifiedRangeTypeT renderSpecifiedRangeTypeT = new IRenderSpecifiedRangeTypeT();
			this.UnPackTo(renderSpecifiedRangeTypeT);
			return renderSpecifiedRangeTypeT;
		}

		// Token: 0x06028621 RID: 165409 RVA: 0x00585B4F File Offset: 0x00583D4F
		public void UnPackTo(IRenderSpecifiedRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028622 RID: 165410 RVA: 0x00585B60 File Offset: 0x00583D60
		public static Offset<IRenderSpecifiedRangeType> Pack(FlatBufferBuilder builder, IRenderSpecifiedRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderSpecifiedRangeType>);
			}
			return IRenderSpecifiedRangeType.CreateIRenderSpecifiedRangeType(builder, _o.Type);
		}

		// Token: 0x0400FA65 RID: 64101
		private Table __p;
	}
}
