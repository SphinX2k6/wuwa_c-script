using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E24 RID: 15908
	public struct IFastReturnPosBase : IFlatbufferObject
	{
		// Token: 0x17006E02 RID: 28162
		// (get) Token: 0x060164AB RID: 91307 RVA: 0x00338120 File Offset: 0x00336320
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164AC RID: 91308 RVA: 0x0033812D File Offset: 0x0033632D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164AD RID: 91309 RVA: 0x00338134 File Offset: 0x00336334
		public static IFastReturnPosBase GetRootAsIFastReturnPosBase(ByteBuffer _bb)
		{
			return IFastReturnPosBase.GetRootAsIFastReturnPosBase(_bb, default(IFastReturnPosBase));
		}

		// Token: 0x060164AE RID: 91310 RVA: 0x00338150 File Offset: 0x00336350
		public static IFastReturnPosBase GetRootAsIFastReturnPosBase(ByteBuffer _bb, IFastReturnPosBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164AF RID: 91311 RVA: 0x0033816D File Offset: 0x0033636D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164B0 RID: 91312 RVA: 0x0033817C File Offset: 0x0033637C
		public IFastReturnPosBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E03 RID: 28163
		// (get) Token: 0x060164B1 RID: 91313 RVA: 0x0033818C File Offset: 0x0033638C
		public EFastReturnPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFastReturnPosType.EntityPos;
				}
				return (EFastReturnPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060164B2 RID: 91314 RVA: 0x003381C8 File Offset: 0x003363C8
		public static Offset<IFastReturnPosBase> CreateIFastReturnPosBase(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos)
		{
			builder.StartTable(1);
			IFastReturnPosBase.AddType(builder, Type);
			return IFastReturnPosBase.EndIFastReturnPosBase(builder);
		}

		// Token: 0x060164B3 RID: 91315 RVA: 0x003381DE File Offset: 0x003363DE
		public static void StartIFastReturnPosBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060164B4 RID: 91316 RVA: 0x003381E7 File Offset: 0x003363E7
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060164B5 RID: 91317 RVA: 0x003381F2 File Offset: 0x003363F2
		public static Offset<IFastReturnPosBase> EndIFastReturnPosBase(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnPosBase>(builder.EndTable());
		}

		// Token: 0x060164B6 RID: 91318 RVA: 0x00338200 File Offset: 0x00336400
		public IFastReturnPosBaseT UnPack()
		{
			IFastReturnPosBaseT fastReturnPosBaseT = new IFastReturnPosBaseT();
			this.UnPackTo(fastReturnPosBaseT);
			return fastReturnPosBaseT;
		}

		// Token: 0x060164B7 RID: 91319 RVA: 0x0033821B File Offset: 0x0033641B
		public void UnPackTo(IFastReturnPosBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060164B8 RID: 91320 RVA: 0x0033822C File Offset: 0x0033642C
		public static Offset<IFastReturnPosBase> Pack(FlatBufferBuilder builder, IFastReturnPosBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnPosBase>);
			}
			return IFastReturnPosBase.CreateIFastReturnPosBase(builder, _o.Type);
		}

		// Token: 0x0400B7A5 RID: 47013
		private Table __p;
	}
}
