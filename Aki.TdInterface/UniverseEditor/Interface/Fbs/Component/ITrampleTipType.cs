using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060DC RID: 24796
	public struct ITrampleTipType : IFlatbufferObject
	{
		// Token: 0x1700B871 RID: 47217
		// (get) Token: 0x06029FD8 RID: 171992 RVA: 0x005BB5EE File Offset: 0x005B97EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029FD9 RID: 171993 RVA: 0x005BB5FB File Offset: 0x005B97FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029FDA RID: 171994 RVA: 0x005BB604 File Offset: 0x005B9804
		public static ITrampleTipType GetRootAsITrampleTipType(ByteBuffer _bb)
		{
			return ITrampleTipType.GetRootAsITrampleTipType(_bb, default(ITrampleTipType));
		}

		// Token: 0x06029FDB RID: 171995 RVA: 0x005BB620 File Offset: 0x005B9820
		public static ITrampleTipType GetRootAsITrampleTipType(ByteBuffer _bb, ITrampleTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029FDC RID: 171996 RVA: 0x005BB63D File Offset: 0x005B983D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029FDD RID: 171997 RVA: 0x005BB64C File Offset: 0x005B984C
		public ITrampleTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B872 RID: 47218
		// (get) Token: 0x06029FDE RID: 171998 RVA: 0x005BB65C File Offset: 0x005B985C
		public ETrampleTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return (ETrampleTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029FDF RID: 171999 RVA: 0x005BB698 File Offset: 0x005B9898
		public static Offset<ITrampleTipType> CreateITrampleTipType(FlatBufferBuilder builder, ETrampleTipType Type = ETrampleTipType.CountDownTextTip)
		{
			builder.StartTable(1);
			ITrampleTipType.AddType(builder, Type);
			return ITrampleTipType.EndITrampleTipType(builder);
		}

		// Token: 0x06029FE0 RID: 172000 RVA: 0x005BB6AE File Offset: 0x005B98AE
		public static void StartITrampleTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029FE1 RID: 172001 RVA: 0x005BB6B7 File Offset: 0x005B98B7
		public static void AddType(FlatBufferBuilder builder, ETrampleTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029FE2 RID: 172002 RVA: 0x005BB6C2 File Offset: 0x005B98C2
		public static Offset<ITrampleTipType> EndITrampleTipType(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleTipType>(builder.EndTable());
		}

		// Token: 0x06029FE3 RID: 172003 RVA: 0x005BB6D0 File Offset: 0x005B98D0
		public ITrampleTipTypeT UnPack()
		{
			ITrampleTipTypeT trampleTipTypeT = new ITrampleTipTypeT();
			this.UnPackTo(trampleTipTypeT);
			return trampleTipTypeT;
		}

		// Token: 0x06029FE4 RID: 172004 RVA: 0x005BB6EB File Offset: 0x005B98EB
		public void UnPackTo(ITrampleTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029FE5 RID: 172005 RVA: 0x005BB6FC File Offset: 0x005B98FC
		public static Offset<ITrampleTipType> Pack(FlatBufferBuilder builder, ITrampleTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleTipType>);
			}
			return ITrampleTipType.CreateITrampleTipType(builder, _o.Type);
		}

		// Token: 0x0400FEA4 RID: 65188
		private Table __p;
	}
}
