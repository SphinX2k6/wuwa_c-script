using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A95 RID: 23189
	public struct ILookAtTargetBase : IFlatbufferObject
	{
		// Token: 0x1700A901 RID: 43265
		// (get) Token: 0x0602602F RID: 155695 RVA: 0x00535C5C File Offset: 0x00533E5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026030 RID: 155696 RVA: 0x00535C69 File Offset: 0x00533E69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026031 RID: 155697 RVA: 0x00535C70 File Offset: 0x00533E70
		public static ILookAtTargetBase GetRootAsILookAtTargetBase(ByteBuffer _bb)
		{
			return ILookAtTargetBase.GetRootAsILookAtTargetBase(_bb, default(ILookAtTargetBase));
		}

		// Token: 0x06026032 RID: 155698 RVA: 0x00535C8C File Offset: 0x00533E8C
		public static ILookAtTargetBase GetRootAsILookAtTargetBase(ByteBuffer _bb, ILookAtTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026033 RID: 155699 RVA: 0x00535CA9 File Offset: 0x00533EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026034 RID: 155700 RVA: 0x00535CB8 File Offset: 0x00533EB8
		public ILookAtTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A902 RID: 43266
		// (get) Token: 0x06026035 RID: 155701 RVA: 0x00535CC8 File Offset: 0x00533EC8
		public ELookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELookAtTargetType.Entity;
				}
				return (ELookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026036 RID: 155702 RVA: 0x00535D04 File Offset: 0x00533F04
		public static Offset<ILookAtTargetBase> CreateILookAtTargetBase(FlatBufferBuilder builder, ELookAtTargetType Type = ELookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ILookAtTargetBase.AddType(builder, Type);
			return ILookAtTargetBase.EndILookAtTargetBase(builder);
		}

		// Token: 0x06026037 RID: 155703 RVA: 0x00535D1A File Offset: 0x00533F1A
		public static void StartILookAtTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026038 RID: 155704 RVA: 0x00535D23 File Offset: 0x00533F23
		public static void AddType(FlatBufferBuilder builder, ELookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026039 RID: 155705 RVA: 0x00535D2E File Offset: 0x00533F2E
		public static Offset<ILookAtTargetBase> EndILookAtTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTargetBase>(builder.EndTable());
		}

		// Token: 0x0602603A RID: 155706 RVA: 0x00535D3C File Offset: 0x00533F3C
		public ILookAtTargetBaseT UnPack()
		{
			ILookAtTargetBaseT lookAtTargetBaseT = new ILookAtTargetBaseT();
			this.UnPackTo(lookAtTargetBaseT);
			return lookAtTargetBaseT;
		}

		// Token: 0x0602603B RID: 155707 RVA: 0x00535D57 File Offset: 0x00533F57
		public void UnPackTo(ILookAtTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602603C RID: 155708 RVA: 0x00535D68 File Offset: 0x00533F68
		public static Offset<ILookAtTargetBase> Pack(FlatBufferBuilder builder, ILookAtTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTargetBase>);
			}
			return ILookAtTargetBase.CreateILookAtTargetBase(builder, _o.Type);
		}

		// Token: 0x0400F432 RID: 62514
		private Table __p;
	}
}
