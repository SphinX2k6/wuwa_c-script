using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004298 RID: 17048
	public struct IFlipperConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007499 RID: 29849
		// (get) Token: 0x06017DC1 RID: 97729 RVA: 0x003688E8 File Offset: 0x00366AE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DC2 RID: 97730 RVA: 0x003688F5 File Offset: 0x00366AF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DC3 RID: 97731 RVA: 0x003688FC File Offset: 0x00366AFC
		public static IFlipperConditionStepBase GetRootAsIFlipperConditionStepBase(ByteBuffer _bb)
		{
			return IFlipperConditionStepBase.GetRootAsIFlipperConditionStepBase(_bb, default(IFlipperConditionStepBase));
		}

		// Token: 0x06017DC4 RID: 97732 RVA: 0x00368918 File Offset: 0x00366B18
		public static IFlipperConditionStepBase GetRootAsIFlipperConditionStepBase(ByteBuffer _bb, IFlipperConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DC5 RID: 97733 RVA: 0x00368935 File Offset: 0x00366B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DC6 RID: 97734 RVA: 0x00368944 File Offset: 0x00366B44
		public IFlipperConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700749A RID: 29850
		// (get) Token: 0x06017DC7 RID: 97735 RVA: 0x00368954 File Offset: 0x00366B54
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

		// Token: 0x06017DC8 RID: 97736 RVA: 0x00368990 File Offset: 0x00366B90
		public static Offset<IFlipperConditionStepBase> CreateIFlipperConditionStepBase(FlatBufferBuilder builder, EFlipperConditionStep Type = EFlipperConditionStep.Fight)
		{
			builder.StartTable(1);
			IFlipperConditionStepBase.AddType(builder, Type);
			return IFlipperConditionStepBase.EndIFlipperConditionStepBase(builder);
		}

		// Token: 0x06017DC9 RID: 97737 RVA: 0x003689A6 File Offset: 0x00366BA6
		public static void StartIFlipperConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017DCA RID: 97738 RVA: 0x003689AF File Offset: 0x00366BAF
		public static void AddType(FlatBufferBuilder builder, EFlipperConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017DCB RID: 97739 RVA: 0x003689BA File Offset: 0x00366BBA
		public static Offset<IFlipperConditionStepBase> EndIFlipperConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06017DCC RID: 97740 RVA: 0x003689C8 File Offset: 0x00366BC8
		public IFlipperConditionStepBaseT UnPack()
		{
			IFlipperConditionStepBaseT flipperConditionStepBaseT = new IFlipperConditionStepBaseT();
			this.UnPackTo(flipperConditionStepBaseT);
			return flipperConditionStepBaseT;
		}

		// Token: 0x06017DCD RID: 97741 RVA: 0x003689E3 File Offset: 0x00366BE3
		public void UnPackTo(IFlipperConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017DCE RID: 97742 RVA: 0x003689F4 File Offset: 0x00366BF4
		public static Offset<IFlipperConditionStepBase> Pack(FlatBufferBuilder builder, IFlipperConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperConditionStepBase>);
			}
			return IFlipperConditionStepBase.CreateIFlipperConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C1E4 RID: 49636
		private Table __p;
	}
}
