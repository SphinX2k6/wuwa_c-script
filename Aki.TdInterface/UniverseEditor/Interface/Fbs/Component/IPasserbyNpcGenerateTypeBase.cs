using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7E RID: 23678
	public struct IPasserbyNpcGenerateTypeBase : IFlatbufferObject
	{
		// Token: 0x1700ADFC RID: 44540
		// (get) Token: 0x0602747B RID: 160891 RVA: 0x0056128F File Offset: 0x0055F48F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602747C RID: 160892 RVA: 0x0056129C File Offset: 0x0055F49C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602747D RID: 160893 RVA: 0x005612A4 File Offset: 0x0055F4A4
		public static IPasserbyNpcGenerateTypeBase GetRootAsIPasserbyNpcGenerateTypeBase(ByteBuffer _bb)
		{
			return IPasserbyNpcGenerateTypeBase.GetRootAsIPasserbyNpcGenerateTypeBase(_bb, default(IPasserbyNpcGenerateTypeBase));
		}

		// Token: 0x0602747E RID: 160894 RVA: 0x005612C0 File Offset: 0x0055F4C0
		public static IPasserbyNpcGenerateTypeBase GetRootAsIPasserbyNpcGenerateTypeBase(ByteBuffer _bb, IPasserbyNpcGenerateTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602747F RID: 160895 RVA: 0x005612DD File Offset: 0x0055F4DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027480 RID: 160896 RVA: 0x005612EC File Offset: 0x0055F4EC
		public IPasserbyNpcGenerateTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADFD RID: 44541
		// (get) Token: 0x06027481 RID: 160897 RVA: 0x005612FC File Offset: 0x0055F4FC
		public EPasserbyNpcGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcGenerateType.RandomStand;
				}
				return (EPasserbyNpcGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027482 RID: 160898 RVA: 0x00561338 File Offset: 0x0055F538
		public static Offset<IPasserbyNpcGenerateTypeBase> CreateIPasserbyNpcGenerateTypeBase(FlatBufferBuilder builder, EPasserbyNpcGenerateType Type = EPasserbyNpcGenerateType.RandomStand)
		{
			builder.StartTable(1);
			IPasserbyNpcGenerateTypeBase.AddType(builder, Type);
			return IPasserbyNpcGenerateTypeBase.EndIPasserbyNpcGenerateTypeBase(builder);
		}

		// Token: 0x06027483 RID: 160899 RVA: 0x0056134E File Offset: 0x0055F54E
		public static void StartIPasserbyNpcGenerateTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027484 RID: 160900 RVA: 0x00561357 File Offset: 0x0055F557
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027485 RID: 160901 RVA: 0x00561362 File Offset: 0x0055F562
		public static Offset<IPasserbyNpcGenerateTypeBase> EndIPasserbyNpcGenerateTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcGenerateTypeBase>(builder.EndTable());
		}

		// Token: 0x06027486 RID: 160902 RVA: 0x00561370 File Offset: 0x0055F570
		public IPasserbyNpcGenerateTypeBaseT UnPack()
		{
			IPasserbyNpcGenerateTypeBaseT passerbyNpcGenerateTypeBaseT = new IPasserbyNpcGenerateTypeBaseT();
			this.UnPackTo(passerbyNpcGenerateTypeBaseT);
			return passerbyNpcGenerateTypeBaseT;
		}

		// Token: 0x06027487 RID: 160903 RVA: 0x0056138B File Offset: 0x0055F58B
		public void UnPackTo(IPasserbyNpcGenerateTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027488 RID: 160904 RVA: 0x0056139C File Offset: 0x0055F59C
		public static Offset<IPasserbyNpcGenerateTypeBase> Pack(FlatBufferBuilder builder, IPasserbyNpcGenerateTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcGenerateTypeBase>);
			}
			return IPasserbyNpcGenerateTypeBase.CreateIPasserbyNpcGenerateTypeBase(builder, _o.Type);
		}

		// Token: 0x0400F786 RID: 63366
		private Table __p;
	}
}
