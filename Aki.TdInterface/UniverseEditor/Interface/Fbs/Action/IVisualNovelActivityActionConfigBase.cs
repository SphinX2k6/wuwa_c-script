using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D46 RID: 32070
	public struct IVisualNovelActivityActionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F006 RID: 61446
		// (get) Token: 0x06039E5C RID: 237148 RVA: 0x007CF445 File Offset: 0x007CD645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E5D RID: 237149 RVA: 0x007CF452 File Offset: 0x007CD652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E5E RID: 237150 RVA: 0x007CF45C File Offset: 0x007CD65C
		public static IVisualNovelActivityActionConfigBase GetRootAsIVisualNovelActivityActionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelActivityActionConfigBase.GetRootAsIVisualNovelActivityActionConfigBase(_bb, default(IVisualNovelActivityActionConfigBase));
		}

		// Token: 0x06039E5F RID: 237151 RVA: 0x007CF478 File Offset: 0x007CD678
		public static IVisualNovelActivityActionConfigBase GetRootAsIVisualNovelActivityActionConfigBase(ByteBuffer _bb, IVisualNovelActivityActionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E60 RID: 237152 RVA: 0x007CF495 File Offset: 0x007CD695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E61 RID: 237153 RVA: 0x007CF4A4 File Offset: 0x007CD6A4
		public IVisualNovelActivityActionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F007 RID: 61447
		// (get) Token: 0x06039E62 RID: 237154 RVA: 0x007CF4B4 File Offset: 0x007CD6B4
		public EVisualNovelSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039E63 RID: 237155 RVA: 0x007CF4F0 File Offset: 0x007CD6F0
		public static Offset<IVisualNovelActivityActionConfigBase> CreateIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelActivityActionConfigBase.AddType(builder, Type);
			return IVisualNovelActivityActionConfigBase.EndIVisualNovelActivityActionConfigBase(builder);
		}

		// Token: 0x06039E64 RID: 237156 RVA: 0x007CF506 File Offset: 0x007CD706
		public static void StartIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039E65 RID: 237157 RVA: 0x007CF50F File Offset: 0x007CD70F
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E66 RID: 237158 RVA: 0x007CF51A File Offset: 0x007CD71A
		public static Offset<IVisualNovelActivityActionConfigBase> EndIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelActivityActionConfigBase>(builder.EndTable());
		}

		// Token: 0x06039E67 RID: 237159 RVA: 0x007CF528 File Offset: 0x007CD728
		public IVisualNovelActivityActionConfigBaseT UnPack()
		{
			IVisualNovelActivityActionConfigBaseT visualNovelActivityActionConfigBaseT = new IVisualNovelActivityActionConfigBaseT();
			this.UnPackTo(visualNovelActivityActionConfigBaseT);
			return visualNovelActivityActionConfigBaseT;
		}

		// Token: 0x06039E68 RID: 237160 RVA: 0x007CF543 File Offset: 0x007CD743
		public void UnPackTo(IVisualNovelActivityActionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039E69 RID: 237161 RVA: 0x007CF554 File Offset: 0x007CD754
		public static Offset<IVisualNovelActivityActionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelActivityActionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelActivityActionConfigBase>);
			}
			return IVisualNovelActivityActionConfigBase.CreateIVisualNovelActivityActionConfigBase(builder, _o.Type);
		}

		// Token: 0x04013479 RID: 78969
		private Table __p;
	}
}
