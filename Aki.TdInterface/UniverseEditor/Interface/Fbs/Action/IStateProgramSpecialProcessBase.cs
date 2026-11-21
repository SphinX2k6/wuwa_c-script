using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007995 RID: 31125
	public struct IStateProgramSpecialProcessBase : IFlatbufferObject
	{
		// Token: 0x1700E45E RID: 58462
		// (get) Token: 0x06036D96 RID: 224662 RVA: 0x0075649D File Offset: 0x0075469D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036D97 RID: 224663 RVA: 0x007564AA File Offset: 0x007546AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036D98 RID: 224664 RVA: 0x007564B4 File Offset: 0x007546B4
		public static IStateProgramSpecialProcessBase GetRootAsIStateProgramSpecialProcessBase(ByteBuffer _bb)
		{
			return IStateProgramSpecialProcessBase.GetRootAsIStateProgramSpecialProcessBase(_bb, default(IStateProgramSpecialProcessBase));
		}

		// Token: 0x06036D99 RID: 224665 RVA: 0x007564D0 File Offset: 0x007546D0
		public static IStateProgramSpecialProcessBase GetRootAsIStateProgramSpecialProcessBase(ByteBuffer _bb, IStateProgramSpecialProcessBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036D9A RID: 224666 RVA: 0x007564ED File Offset: 0x007546ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036D9B RID: 224667 RVA: 0x007564FC File Offset: 0x007546FC
		public IStateProgramSpecialProcessBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E45F RID: 58463
		// (get) Token: 0x06036D9C RID: 224668 RVA: 0x0075650C File Offset: 0x0075470C
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.ChangeTeamOptimization;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036D9D RID: 224669 RVA: 0x00756548 File Offset: 0x00754748
		public static Offset<IStateProgramSpecialProcessBase> CreateIStateProgramSpecialProcessBase(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.ChangeTeamOptimization)
		{
			builder.StartTable(1);
			IStateProgramSpecialProcessBase.AddType(builder, Type);
			return IStateProgramSpecialProcessBase.EndIStateProgramSpecialProcessBase(builder);
		}

		// Token: 0x06036D9E RID: 224670 RVA: 0x0075655E File Offset: 0x0075475E
		public static void StartIStateProgramSpecialProcessBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036D9F RID: 224671 RVA: 0x00756567 File Offset: 0x00754767
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DA0 RID: 224672 RVA: 0x00756572 File Offset: 0x00754772
		public static Offset<IStateProgramSpecialProcessBase> EndIStateProgramSpecialProcessBase(FlatBufferBuilder builder)
		{
			return new Offset<IStateProgramSpecialProcessBase>(builder.EndTable());
		}

		// Token: 0x06036DA1 RID: 224673 RVA: 0x00756580 File Offset: 0x00754780
		public IStateProgramSpecialProcessBaseT UnPack()
		{
			IStateProgramSpecialProcessBaseT stateProgramSpecialProcessBaseT = new IStateProgramSpecialProcessBaseT();
			this.UnPackTo(stateProgramSpecialProcessBaseT);
			return stateProgramSpecialProcessBaseT;
		}

		// Token: 0x06036DA2 RID: 224674 RVA: 0x0075659B File Offset: 0x0075479B
		public void UnPackTo(IStateProgramSpecialProcessBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036DA3 RID: 224675 RVA: 0x007565AC File Offset: 0x007547AC
		public static Offset<IStateProgramSpecialProcessBase> Pack(FlatBufferBuilder builder, IStateProgramSpecialProcessBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateProgramSpecialProcessBase>);
			}
			return IStateProgramSpecialProcessBase.CreateIStateProgramSpecialProcessBase(builder, _o.Type);
		}

		// Token: 0x04012CA3 RID: 76963
		private Table __p;
	}
}
