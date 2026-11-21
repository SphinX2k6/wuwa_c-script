using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E6 RID: 29414
	public struct INewSplineMoveType : IFlatbufferObject
	{
		// Token: 0x1700D7B1 RID: 55217
		// (get) Token: 0x0603349F RID: 210079 RVA: 0x006EB230 File Offset: 0x006E9430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334A0 RID: 210080 RVA: 0x006EB23D File Offset: 0x006E943D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334A1 RID: 210081 RVA: 0x006EB244 File Offset: 0x006E9444
		public static INewSplineMoveType GetRootAsINewSplineMoveType(ByteBuffer _bb)
		{
			return INewSplineMoveType.GetRootAsINewSplineMoveType(_bb, default(INewSplineMoveType));
		}

		// Token: 0x060334A2 RID: 210082 RVA: 0x006EB260 File Offset: 0x006E9460
		public static INewSplineMoveType GetRootAsINewSplineMoveType(ByteBuffer _bb, INewSplineMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334A3 RID: 210083 RVA: 0x006EB27D File Offset: 0x006E947D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334A4 RID: 210084 RVA: 0x006EB28C File Offset: 0x006E948C
		public INewSplineMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7B2 RID: 55218
		// (get) Token: 0x060334A5 RID: 210085 RVA: 0x006EB29C File Offset: 0x006E949C
		public ENewSplineMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveType.FrontAxleTracking;
				}
				return (ENewSplineMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060334A6 RID: 210086 RVA: 0x006EB2D8 File Offset: 0x006E94D8
		public static Offset<INewSplineMoveType> CreateINewSplineMoveType(FlatBufferBuilder builder, ENewSplineMoveType Type = ENewSplineMoveType.FrontAxleTracking)
		{
			builder.StartTable(1);
			INewSplineMoveType.AddType(builder, Type);
			return INewSplineMoveType.EndINewSplineMoveType(builder);
		}

		// Token: 0x060334A7 RID: 210087 RVA: 0x006EB2EE File Offset: 0x006E94EE
		public static void StartINewSplineMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060334A8 RID: 210088 RVA: 0x006EB2F7 File Offset: 0x006E94F7
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060334A9 RID: 210089 RVA: 0x006EB302 File Offset: 0x006E9502
		public static Offset<INewSplineMoveType> EndINewSplineMoveType(FlatBufferBuilder builder)
		{
			return new Offset<INewSplineMoveType>(builder.EndTable());
		}

		// Token: 0x060334AA RID: 210090 RVA: 0x006EB310 File Offset: 0x006E9510
		public INewSplineMoveTypeT UnPack()
		{
			INewSplineMoveTypeT newSplineMoveTypeT = new INewSplineMoveTypeT();
			this.UnPackTo(newSplineMoveTypeT);
			return newSplineMoveTypeT;
		}

		// Token: 0x060334AB RID: 210091 RVA: 0x006EB32B File Offset: 0x006E952B
		public void UnPackTo(INewSplineMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060334AC RID: 210092 RVA: 0x006EB33C File Offset: 0x006E953C
		public static Offset<INewSplineMoveType> Pack(FlatBufferBuilder builder, INewSplineMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewSplineMoveType>);
			}
			return INewSplineMoveType.CreateINewSplineMoveType(builder, _o.Type);
		}

		// Token: 0x04012395 RID: 74645
		private Table __p;
	}
}
