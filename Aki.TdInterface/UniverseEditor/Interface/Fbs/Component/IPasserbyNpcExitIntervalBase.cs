using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C66 RID: 23654
	public struct IPasserbyNpcExitIntervalBase : IFlatbufferObject
	{
		// Token: 0x1700ADDB RID: 44507
		// (get) Token: 0x060273E5 RID: 160741 RVA: 0x00560463 File Offset: 0x0055E663
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060273E6 RID: 160742 RVA: 0x00560470 File Offset: 0x0055E670
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060273E7 RID: 160743 RVA: 0x00560478 File Offset: 0x0055E678
		public static IPasserbyNpcExitIntervalBase GetRootAsIPasserbyNpcExitIntervalBase(ByteBuffer _bb)
		{
			return IPasserbyNpcExitIntervalBase.GetRootAsIPasserbyNpcExitIntervalBase(_bb, default(IPasserbyNpcExitIntervalBase));
		}

		// Token: 0x060273E8 RID: 160744 RVA: 0x00560494 File Offset: 0x0055E694
		public static IPasserbyNpcExitIntervalBase GetRootAsIPasserbyNpcExitIntervalBase(ByteBuffer _bb, IPasserbyNpcExitIntervalBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060273E9 RID: 160745 RVA: 0x005604B1 File Offset: 0x0055E6B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060273EA RID: 160746 RVA: 0x005604C0 File Offset: 0x0055E6C0
		public IPasserbyNpcExitIntervalBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADDC RID: 44508
		// (get) Token: 0x060273EB RID: 160747 RVA: 0x005604D0 File Offset: 0x0055E6D0
		public EPasserbyNpcExitIntervalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitIntervalType.PerNpcRandom;
				}
				return (EPasserbyNpcExitIntervalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060273EC RID: 160748 RVA: 0x0056050C File Offset: 0x0055E70C
		public static Offset<IPasserbyNpcExitIntervalBase> CreateIPasserbyNpcExitIntervalBase(FlatBufferBuilder builder, EPasserbyNpcExitIntervalType Type = EPasserbyNpcExitIntervalType.PerNpcRandom)
		{
			builder.StartTable(1);
			IPasserbyNpcExitIntervalBase.AddType(builder, Type);
			return IPasserbyNpcExitIntervalBase.EndIPasserbyNpcExitIntervalBase(builder);
		}

		// Token: 0x060273ED RID: 160749 RVA: 0x00560522 File Offset: 0x0055E722
		public static void StartIPasserbyNpcExitIntervalBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060273EE RID: 160750 RVA: 0x0056052B File Offset: 0x0055E72B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitIntervalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060273EF RID: 160751 RVA: 0x00560536 File Offset: 0x0055E736
		public static Offset<IPasserbyNpcExitIntervalBase> EndIPasserbyNpcExitIntervalBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcExitIntervalBase>(builder.EndTable());
		}

		// Token: 0x060273F0 RID: 160752 RVA: 0x00560544 File Offset: 0x0055E744
		public IPasserbyNpcExitIntervalBaseT UnPack()
		{
			IPasserbyNpcExitIntervalBaseT passerbyNpcExitIntervalBaseT = new IPasserbyNpcExitIntervalBaseT();
			this.UnPackTo(passerbyNpcExitIntervalBaseT);
			return passerbyNpcExitIntervalBaseT;
		}

		// Token: 0x060273F1 RID: 160753 RVA: 0x0056055F File Offset: 0x0055E75F
		public void UnPackTo(IPasserbyNpcExitIntervalBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060273F2 RID: 160754 RVA: 0x00560570 File Offset: 0x0055E770
		public static Offset<IPasserbyNpcExitIntervalBase> Pack(FlatBufferBuilder builder, IPasserbyNpcExitIntervalBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcExitIntervalBase>);
			}
			return IPasserbyNpcExitIntervalBase.CreateIPasserbyNpcExitIntervalBase(builder, _o.Type);
		}

		// Token: 0x0400F764 RID: 63332
		private Table __p;
	}
}
