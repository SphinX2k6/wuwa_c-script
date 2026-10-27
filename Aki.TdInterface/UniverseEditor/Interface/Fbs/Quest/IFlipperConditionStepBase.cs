using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5D RID: 15965
	public struct IFlipperConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17006EB5 RID: 28341
		// (get) Token: 0x0601679A RID: 92058 RVA: 0x0033FDB8 File Offset: 0x0033DFB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601679B RID: 92059 RVA: 0x0033FDC5 File Offset: 0x0033DFC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601679C RID: 92060 RVA: 0x0033FDCC File Offset: 0x0033DFCC
		public static IFlipperConditionStepBase GetRootAsIFlipperConditionStepBase(ByteBuffer _bb)
		{
			return IFlipperConditionStepBase.GetRootAsIFlipperConditionStepBase(_bb, default(IFlipperConditionStepBase));
		}

		// Token: 0x0601679D RID: 92061 RVA: 0x0033FDE8 File Offset: 0x0033DFE8
		public static IFlipperConditionStepBase GetRootAsIFlipperConditionStepBase(ByteBuffer _bb, IFlipperConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601679E RID: 92062 RVA: 0x0033FE05 File Offset: 0x0033E005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601679F RID: 92063 RVA: 0x0033FE14 File Offset: 0x0033E014
		public IFlipperConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EB6 RID: 28342
		// (get) Token: 0x060167A0 RID: 92064 RVA: 0x0033FE24 File Offset: 0x0033E024
		public EFlipperConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlipperConditionStep.Fight;
				}
				return (EFlipperConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060167A1 RID: 92065 RVA: 0x0033FE60 File Offset: 0x0033E060
		public static Offset<IFlipperConditionStepBase> CreateIFlipperConditionStepBase(FlatBufferBuilder builder, EFlipperConditionStep Type = EFlipperConditionStep.Fight)
		{
			builder.StartTable(1);
			IFlipperConditionStepBase.AddType(builder, Type);
			return IFlipperConditionStepBase.EndIFlipperConditionStepBase(builder);
		}

		// Token: 0x060167A2 RID: 92066 RVA: 0x0033FE76 File Offset: 0x0033E076
		public static void StartIFlipperConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060167A3 RID: 92067 RVA: 0x0033FE7F File Offset: 0x0033E07F
		public static void AddType(FlatBufferBuilder builder, EFlipperConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167A4 RID: 92068 RVA: 0x0033FE8A File Offset: 0x0033E08A
		public static Offset<IFlipperConditionStepBase> EndIFlipperConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperConditionStepBase>(builder.EndTable());
		}

		// Token: 0x060167A5 RID: 92069 RVA: 0x0033FE98 File Offset: 0x0033E098
		public IFlipperConditionStepBaseT UnPack()
		{
			IFlipperConditionStepBaseT flipperConditionStepBaseT = new IFlipperConditionStepBaseT();
			this.UnPackTo(flipperConditionStepBaseT);
			return flipperConditionStepBaseT;
		}

		// Token: 0x060167A6 RID: 92070 RVA: 0x0033FEB3 File Offset: 0x0033E0B3
		public void UnPackTo(IFlipperConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060167A7 RID: 92071 RVA: 0x0033FEC4 File Offset: 0x0033E0C4
		public static Offset<IFlipperConditionStepBase> Pack(FlatBufferBuilder builder, IFlipperConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperConditionStepBase>);
			}
			return IFlipperConditionStepBase.CreateIFlipperConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400B80D RID: 47117
		private Table __p;
	}
}
