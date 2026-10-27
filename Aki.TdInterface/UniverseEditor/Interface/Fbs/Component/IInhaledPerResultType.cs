using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005413 RID: 21523
	public struct IInhaledPerResultType : IFlatbufferObject
	{
		// Token: 0x17009E5C RID: 40540
		// (get) Token: 0x0602359D RID: 144797 RVA: 0x004E4971 File Offset: 0x004E2B71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602359E RID: 144798 RVA: 0x004E497E File Offset: 0x004E2B7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602359F RID: 144799 RVA: 0x004E4988 File Offset: 0x004E2B88
		public static IInhaledPerResultType GetRootAsIInhaledPerResultType(ByteBuffer _bb)
		{
			return IInhaledPerResultType.GetRootAsIInhaledPerResultType(_bb, default(IInhaledPerResultType));
		}

		// Token: 0x060235A0 RID: 144800 RVA: 0x004E49A4 File Offset: 0x004E2BA4
		public static IInhaledPerResultType GetRootAsIInhaledPerResultType(ByteBuffer _bb, IInhaledPerResultType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235A1 RID: 144801 RVA: 0x004E49C1 File Offset: 0x004E2BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235A2 RID: 144802 RVA: 0x004E49D0 File Offset: 0x004E2BD0
		public IInhaledPerResultType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E5D RID: 40541
		// (get) Token: 0x060235A3 RID: 144803 RVA: 0x004E49E0 File Offset: 0x004E2BE0
		public EInhaledPerResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return (EInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060235A4 RID: 144804 RVA: 0x004E4A1C File Offset: 0x004E2C1C
		public static Offset<IInhaledPerResultType> CreateIInhaledPerResultType(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf)
		{
			builder.StartTable(1);
			IInhaledPerResultType.AddType(builder, Type);
			return IInhaledPerResultType.EndIInhaledPerResultType(builder);
		}

		// Token: 0x060235A5 RID: 144805 RVA: 0x004E4A32 File Offset: 0x004E2C32
		public static void StartIInhaledPerResultType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060235A6 RID: 144806 RVA: 0x004E4A3B File Offset: 0x004E2C3B
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060235A7 RID: 144807 RVA: 0x004E4A46 File Offset: 0x004E2C46
		public static Offset<IInhaledPerResultType> EndIInhaledPerResultType(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledPerResultType>(builder.EndTable());
		}

		// Token: 0x060235A8 RID: 144808 RVA: 0x004E4A54 File Offset: 0x004E2C54
		public IInhaledPerResultTypeT UnPack()
		{
			IInhaledPerResultTypeT inhaledPerResultTypeT = new IInhaledPerResultTypeT();
			this.UnPackTo(inhaledPerResultTypeT);
			return inhaledPerResultTypeT;
		}

		// Token: 0x060235A9 RID: 144809 RVA: 0x004E4A6F File Offset: 0x004E2C6F
		public void UnPackTo(IInhaledPerResultTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060235AA RID: 144810 RVA: 0x004E4A80 File Offset: 0x004E2C80
		public static Offset<IInhaledPerResultType> Pack(FlatBufferBuilder builder, IInhaledPerResultTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledPerResultType>);
			}
			return IInhaledPerResultType.CreateIInhaledPerResultType(builder, _o.Type);
		}

		// Token: 0x0400E65C RID: 58972
		private Table __p;
	}
}
