using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D5B RID: 32091
	public struct IVisualNovelCgBase : IFlatbufferObject
	{
		// Token: 0x1700F01D RID: 61469
		// (get) Token: 0x06039ED8 RID: 237272 RVA: 0x007CFEF2 File Offset: 0x007CE0F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039ED9 RID: 237273 RVA: 0x007CFEFF File Offset: 0x007CE0FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039EDA RID: 237274 RVA: 0x007CFF08 File Offset: 0x007CE108
		public static IVisualNovelCgBase GetRootAsIVisualNovelCgBase(ByteBuffer _bb)
		{
			return IVisualNovelCgBase.GetRootAsIVisualNovelCgBase(_bb, default(IVisualNovelCgBase));
		}

		// Token: 0x06039EDB RID: 237275 RVA: 0x007CFF24 File Offset: 0x007CE124
		public static IVisualNovelCgBase GetRootAsIVisualNovelCgBase(ByteBuffer _bb, IVisualNovelCgBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039EDC RID: 237276 RVA: 0x007CFF41 File Offset: 0x007CE141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039EDD RID: 237277 RVA: 0x007CFF50 File Offset: 0x007CE150
		public IVisualNovelCgBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F01E RID: 61470
		// (get) Token: 0x06039EDE RID: 237278 RVA: 0x007CFF60 File Offset: 0x007CE160
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039EDF RID: 237279 RVA: 0x007CFF9C File Offset: 0x007CE19C
		public static Offset<IVisualNovelCgBase> CreateIVisualNovelCgBase(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadPrefab)
		{
			builder.StartTable(1);
			IVisualNovelCgBase.AddType(builder, Type);
			return IVisualNovelCgBase.EndIVisualNovelCgBase(builder);
		}

		// Token: 0x06039EE0 RID: 237280 RVA: 0x007CFFB2 File Offset: 0x007CE1B2
		public static void StartIVisualNovelCgBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039EE1 RID: 237281 RVA: 0x007CFFBB File Offset: 0x007CE1BB
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039EE2 RID: 237282 RVA: 0x007CFFC6 File Offset: 0x007CE1C6
		public static Offset<IVisualNovelCgBase> EndIVisualNovelCgBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgBase>(builder.EndTable());
		}

		// Token: 0x06039EE3 RID: 237283 RVA: 0x007CFFD4 File Offset: 0x007CE1D4
		public IVisualNovelCgBaseT UnPack()
		{
			IVisualNovelCgBaseT visualNovelCgBaseT = new IVisualNovelCgBaseT();
			this.UnPackTo(visualNovelCgBaseT);
			return visualNovelCgBaseT;
		}

		// Token: 0x06039EE4 RID: 237284 RVA: 0x007CFFEF File Offset: 0x007CE1EF
		public void UnPackTo(IVisualNovelCgBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039EE5 RID: 237285 RVA: 0x007D0000 File Offset: 0x007CE200
		public static Offset<IVisualNovelCgBase> Pack(FlatBufferBuilder builder, IVisualNovelCgBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgBase>);
			}
			return IVisualNovelCgBase.CreateIVisualNovelCgBase(builder, _o.Type);
		}

		// Token: 0x04013492 RID: 78994
		private Table __p;
	}
}
