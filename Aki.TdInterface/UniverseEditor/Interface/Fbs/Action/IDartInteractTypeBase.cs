using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653D RID: 25917
	public struct IDartInteractTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C0A7 RID: 49319
		// (get) Token: 0x0602CF62 RID: 184162 RVA: 0x0062C550 File Offset: 0x0062A750
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF63 RID: 184163 RVA: 0x0062C55D File Offset: 0x0062A75D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF64 RID: 184164 RVA: 0x0062C564 File Offset: 0x0062A764
		public static IDartInteractTypeBase GetRootAsIDartInteractTypeBase(ByteBuffer _bb)
		{
			return IDartInteractTypeBase.GetRootAsIDartInteractTypeBase(_bb, default(IDartInteractTypeBase));
		}

		// Token: 0x0602CF65 RID: 184165 RVA: 0x0062C580 File Offset: 0x0062A780
		public static IDartInteractTypeBase GetRootAsIDartInteractTypeBase(ByteBuffer _bb, IDartInteractTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF66 RID: 184166 RVA: 0x0062C59D File Offset: 0x0062A79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF67 RID: 184167 RVA: 0x0062C5AC File Offset: 0x0062A7AC
		public IDartInteractTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0A8 RID: 49320
		// (get) Token: 0x0602CF68 RID: 184168 RVA: 0x0062C5BC File Offset: 0x0062A7BC
		public EDartInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartInteractType.Machine;
				}
				return (EDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CF69 RID: 184169 RVA: 0x0062C5F8 File Offset: 0x0062A7F8
		public static Offset<IDartInteractTypeBase> CreateIDartInteractTypeBase(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine)
		{
			builder.StartTable(1);
			IDartInteractTypeBase.AddType(builder, Type);
			return IDartInteractTypeBase.EndIDartInteractTypeBase(builder);
		}

		// Token: 0x0602CF6A RID: 184170 RVA: 0x0062C60E File Offset: 0x0062A80E
		public static void StartIDartInteractTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CF6B RID: 184171 RVA: 0x0062C617 File Offset: 0x0062A817
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF6C RID: 184172 RVA: 0x0062C622 File Offset: 0x0062A822
		public static Offset<IDartInteractTypeBase> EndIDartInteractTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IDartInteractTypeBase>(builder.EndTable());
		}

		// Token: 0x0602CF6D RID: 184173 RVA: 0x0062C630 File Offset: 0x0062A830
		public IDartInteractTypeBaseT UnPack()
		{
			IDartInteractTypeBaseT dartInteractTypeBaseT = new IDartInteractTypeBaseT();
			this.UnPackTo(dartInteractTypeBaseT);
			return dartInteractTypeBaseT;
		}

		// Token: 0x0602CF6E RID: 184174 RVA: 0x0062C64B File Offset: 0x0062A84B
		public void UnPackTo(IDartInteractTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CF6F RID: 184175 RVA: 0x0062C65C File Offset: 0x0062A85C
		public static Offset<IDartInteractTypeBase> Pack(FlatBufferBuilder builder, IDartInteractTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartInteractTypeBase>);
			}
			return IDartInteractTypeBase.CreateIDartInteractTypeBase(builder, _o.Type);
		}

		// Token: 0x04010B85 RID: 68485
		private Table __p;
	}
}
