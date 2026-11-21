using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D67 RID: 23911
	public struct IPointGroupGenerateType : IFlatbufferObject
	{
		// Token: 0x1700AFFF RID: 45055
		// (get) Token: 0x06027CE5 RID: 163045 RVA: 0x00572192 File Offset: 0x00570392
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027CE6 RID: 163046 RVA: 0x0057219F File Offset: 0x0057039F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027CE7 RID: 163047 RVA: 0x005721A8 File Offset: 0x005703A8
		public static IPointGroupGenerateType GetRootAsIPointGroupGenerateType(ByteBuffer _bb)
		{
			return IPointGroupGenerateType.GetRootAsIPointGroupGenerateType(_bb, default(IPointGroupGenerateType));
		}

		// Token: 0x06027CE8 RID: 163048 RVA: 0x005721C4 File Offset: 0x005703C4
		public static IPointGroupGenerateType GetRootAsIPointGroupGenerateType(ByteBuffer _bb, IPointGroupGenerateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027CE9 RID: 163049 RVA: 0x005721E1 File Offset: 0x005703E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027CEA RID: 163050 RVA: 0x005721F0 File Offset: 0x005703F0
		public IPointGroupGenerateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B000 RID: 45056
		// (get) Token: 0x06027CEB RID: 163051 RVA: 0x00572200 File Offset: 0x00570400
		public EPointGroupGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointGroupGenerateType.Layer;
				}
				return (EPointGroupGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027CEC RID: 163052 RVA: 0x0057223C File Offset: 0x0057043C
		public static Offset<IPointGroupGenerateType> CreateIPointGroupGenerateType(FlatBufferBuilder builder, EPointGroupGenerateType Type = EPointGroupGenerateType.Layer)
		{
			builder.StartTable(1);
			IPointGroupGenerateType.AddType(builder, Type);
			return IPointGroupGenerateType.EndIPointGroupGenerateType(builder);
		}

		// Token: 0x06027CED RID: 163053 RVA: 0x00572252 File Offset: 0x00570452
		public static void StartIPointGroupGenerateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027CEE RID: 163054 RVA: 0x0057225B File Offset: 0x0057045B
		public static void AddType(FlatBufferBuilder builder, EPointGroupGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027CEF RID: 163055 RVA: 0x00572266 File Offset: 0x00570466
		public static Offset<IPointGroupGenerateType> EndIPointGroupGenerateType(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroupGenerateType>(builder.EndTable());
		}

		// Token: 0x06027CF0 RID: 163056 RVA: 0x00572274 File Offset: 0x00570474
		public IPointGroupGenerateTypeT UnPack()
		{
			IPointGroupGenerateTypeT pointGroupGenerateTypeT = new IPointGroupGenerateTypeT();
			this.UnPackTo(pointGroupGenerateTypeT);
			return pointGroupGenerateTypeT;
		}

		// Token: 0x06027CF1 RID: 163057 RVA: 0x0057228F File Offset: 0x0057048F
		public void UnPackTo(IPointGroupGenerateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027CF2 RID: 163058 RVA: 0x005722A0 File Offset: 0x005704A0
		public static Offset<IPointGroupGenerateType> Pack(FlatBufferBuilder builder, IPointGroupGenerateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointGroupGenerateType>);
			}
			return IPointGroupGenerateType.CreateIPointGroupGenerateType(builder, _o.Type);
		}

		// Token: 0x0400F8EC RID: 63724
		private Table __p;
	}
}
