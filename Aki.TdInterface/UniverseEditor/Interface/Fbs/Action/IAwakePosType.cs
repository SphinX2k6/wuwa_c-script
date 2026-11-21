using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683E RID: 26686
	public struct IAwakePosType : IFlatbufferObject
	{
		// Token: 0x1700C43C RID: 50236
		// (get) Token: 0x0602D9CD RID: 186829 RVA: 0x0063DA49 File Offset: 0x0063BC49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9CE RID: 186830 RVA: 0x0063DA56 File Offset: 0x0063BC56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9CF RID: 186831 RVA: 0x0063DA60 File Offset: 0x0063BC60
		public static IAwakePosType GetRootAsIAwakePosType(ByteBuffer _bb)
		{
			return IAwakePosType.GetRootAsIAwakePosType(_bb, default(IAwakePosType));
		}

		// Token: 0x0602D9D0 RID: 186832 RVA: 0x0063DA7C File Offset: 0x0063BC7C
		public static IAwakePosType GetRootAsIAwakePosType(ByteBuffer _bb, IAwakePosType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9D1 RID: 186833 RVA: 0x0063DA99 File Offset: 0x0063BC99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9D2 RID: 186834 RVA: 0x0063DAA8 File Offset: 0x0063BCA8
		public IAwakePosType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C43D RID: 50237
		// (get) Token: 0x0602D9D3 RID: 186835 RVA: 0x0063DAB8 File Offset: 0x0063BCB8
		public EAwakePosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAwakePosType.TransformVar;
				}
				return (EAwakePosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D9D4 RID: 186836 RVA: 0x0063DAF4 File Offset: 0x0063BCF4
		public static Offset<IAwakePosType> CreateIAwakePosType(FlatBufferBuilder builder, EAwakePosType Type = EAwakePosType.TransformVar)
		{
			builder.StartTable(1);
			IAwakePosType.AddType(builder, Type);
			return IAwakePosType.EndIAwakePosType(builder);
		}

		// Token: 0x0602D9D5 RID: 186837 RVA: 0x0063DB0A File Offset: 0x0063BD0A
		public static void StartIAwakePosType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D9D6 RID: 186838 RVA: 0x0063DB13 File Offset: 0x0063BD13
		public static void AddType(FlatBufferBuilder builder, EAwakePosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D9D7 RID: 186839 RVA: 0x0063DB1E File Offset: 0x0063BD1E
		public static Offset<IAwakePosType> EndIAwakePosType(FlatBufferBuilder builder)
		{
			return new Offset<IAwakePosType>(builder.EndTable());
		}

		// Token: 0x0602D9D8 RID: 186840 RVA: 0x0063DB2C File Offset: 0x0063BD2C
		public IAwakePosTypeT UnPack()
		{
			IAwakePosTypeT awakePosTypeT = new IAwakePosTypeT();
			this.UnPackTo(awakePosTypeT);
			return awakePosTypeT;
		}

		// Token: 0x0602D9D9 RID: 186841 RVA: 0x0063DB47 File Offset: 0x0063BD47
		public void UnPackTo(IAwakePosTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D9DA RID: 186842 RVA: 0x0063DB58 File Offset: 0x0063BD58
		public static Offset<IAwakePosType> Pack(FlatBufferBuilder builder, IAwakePosTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakePosType>);
			}
			return IAwakePosType.CreateIAwakePosType(builder, _o.Type);
		}

		// Token: 0x0401150B RID: 70923
		private Table __p;
	}
}
