using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699C RID: 27036
	public struct IInteractPointConfig : IFlatbufferObject
	{
		// Token: 0x1700C89B RID: 51355
		// (get) Token: 0x0602F3DD RID: 193501 RVA: 0x0066F8A1 File Offset: 0x0066DAA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3DE RID: 193502 RVA: 0x0066F8AE File Offset: 0x0066DAAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3DF RID: 193503 RVA: 0x0066F8B8 File Offset: 0x0066DAB8
		public static IInteractPointConfig GetRootAsIInteractPointConfig(ByteBuffer _bb)
		{
			return IInteractPointConfig.GetRootAsIInteractPointConfig(_bb, default(IInteractPointConfig));
		}

		// Token: 0x0602F3E0 RID: 193504 RVA: 0x0066F8D4 File Offset: 0x0066DAD4
		public static IInteractPointConfig GetRootAsIInteractPointConfig(ByteBuffer _bb, IInteractPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3E1 RID: 193505 RVA: 0x0066F8F1 File Offset: 0x0066DAF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3E2 RID: 193506 RVA: 0x0066F900 File Offset: 0x0066DB00
		public IInteractPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C89C RID: 51356
		// (get) Token: 0x0602F3E3 RID: 193507 RVA: 0x0066F910 File Offset: 0x0066DB10
		public EInteractUnlockType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractUnlockType.Sequence;
				}
				return (EInteractUnlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3E4 RID: 193508 RVA: 0x0066F94C File Offset: 0x0066DB4C
		public static Offset<IInteractPointConfig> CreateIInteractPointConfig(FlatBufferBuilder builder, EInteractUnlockType Type = EInteractUnlockType.Sequence)
		{
			builder.StartTable(1);
			IInteractPointConfig.AddType(builder, Type);
			return IInteractPointConfig.EndIInteractPointConfig(builder);
		}

		// Token: 0x0602F3E5 RID: 193509 RVA: 0x0066F962 File Offset: 0x0066DB62
		public static void StartIInteractPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F3E6 RID: 193510 RVA: 0x0066F96B File Offset: 0x0066DB6B
		public static void AddType(FlatBufferBuilder builder, EInteractUnlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F3E7 RID: 193511 RVA: 0x0066F976 File Offset: 0x0066DB76
		public static Offset<IInteractPointConfig> EndIInteractPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointConfig>(builder.EndTable());
		}

		// Token: 0x0602F3E8 RID: 193512 RVA: 0x0066F984 File Offset: 0x0066DB84
		public IInteractPointConfigT UnPack()
		{
			IInteractPointConfigT interactPointConfigT = new IInteractPointConfigT();
			this.UnPackTo(interactPointConfigT);
			return interactPointConfigT;
		}

		// Token: 0x0602F3E9 RID: 193513 RVA: 0x0066F99F File Offset: 0x0066DB9F
		public void UnPackTo(IInteractPointConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F3EA RID: 193514 RVA: 0x0066F9B0 File Offset: 0x0066DBB0
		public static Offset<IInteractPointConfig> Pack(FlatBufferBuilder builder, IInteractPointConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointConfig>);
			}
			return IInteractPointConfig.CreateIInteractPointConfig(builder, _o.Type);
		}

		// Token: 0x04011140 RID: 69952
		private Table __p;
	}
}
