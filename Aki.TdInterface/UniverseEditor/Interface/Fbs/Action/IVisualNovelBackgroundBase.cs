using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D4F RID: 32079
	public struct IVisualNovelBackgroundBase : IFlatbufferObject
	{
		// Token: 0x1700F010 RID: 61456
		// (get) Token: 0x06039E90 RID: 237200 RVA: 0x007CF8BA File Offset: 0x007CDABA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E91 RID: 237201 RVA: 0x007CF8C7 File Offset: 0x007CDAC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E92 RID: 237202 RVA: 0x007CF8D0 File Offset: 0x007CDAD0
		public static IVisualNovelBackgroundBase GetRootAsIVisualNovelBackgroundBase(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundBase.GetRootAsIVisualNovelBackgroundBase(_bb, default(IVisualNovelBackgroundBase));
		}

		// Token: 0x06039E93 RID: 237203 RVA: 0x007CF8EC File Offset: 0x007CDAEC
		public static IVisualNovelBackgroundBase GetRootAsIVisualNovelBackgroundBase(ByteBuffer _bb, IVisualNovelBackgroundBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E94 RID: 237204 RVA: 0x007CF909 File Offset: 0x007CDB09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E95 RID: 237205 RVA: 0x007CF918 File Offset: 0x007CDB18
		public IVisualNovelBackgroundBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F011 RID: 61457
		// (get) Token: 0x06039E96 RID: 237206 RVA: 0x007CF928 File Offset: 0x007CDB28
		public EVisualNovelBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return (EVisualNovelBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039E97 RID: 237207 RVA: 0x007CF964 File Offset: 0x007CDB64
		public static Offset<IVisualNovelBackgroundBase> CreateIVisualNovelBackgroundBase(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load)
		{
			builder.StartTable(1);
			IVisualNovelBackgroundBase.AddType(builder, Type);
			return IVisualNovelBackgroundBase.EndIVisualNovelBackgroundBase(builder);
		}

		// Token: 0x06039E98 RID: 237208 RVA: 0x007CF97A File Offset: 0x007CDB7A
		public static void StartIVisualNovelBackgroundBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039E99 RID: 237209 RVA: 0x007CF983 File Offset: 0x007CDB83
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E9A RID: 237210 RVA: 0x007CF98E File Offset: 0x007CDB8E
		public static Offset<IVisualNovelBackgroundBase> EndIVisualNovelBackgroundBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundBase>(builder.EndTable());
		}

		// Token: 0x06039E9B RID: 237211 RVA: 0x007CF99C File Offset: 0x007CDB9C
		public IVisualNovelBackgroundBaseT UnPack()
		{
			IVisualNovelBackgroundBaseT visualNovelBackgroundBaseT = new IVisualNovelBackgroundBaseT();
			this.UnPackTo(visualNovelBackgroundBaseT);
			return visualNovelBackgroundBaseT;
		}

		// Token: 0x06039E9C RID: 237212 RVA: 0x007CF9B7 File Offset: 0x007CDBB7
		public void UnPackTo(IVisualNovelBackgroundBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039E9D RID: 237213 RVA: 0x007CF9C8 File Offset: 0x007CDBC8
		public static Offset<IVisualNovelBackgroundBase> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundBase>);
			}
			return IVisualNovelBackgroundBase.CreateIVisualNovelBackgroundBase(builder, _o.Type);
		}

		// Token: 0x04013484 RID: 78980
		private Table __p;
	}
}
