using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758C RID: 30092
	public struct IVisualNovelOptionGroupConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E42E RID: 58414
		// (get) Token: 0x06036BD6 RID: 224214 RVA: 0x0076E64D File Offset: 0x0076C84D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BD7 RID: 224215 RVA: 0x0076E65A File Offset: 0x0076C85A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BD8 RID: 224216 RVA: 0x0076E664 File Offset: 0x0076C864
		public static IVisualNovelOptionGroupConfigBase GetRootAsIVisualNovelOptionGroupConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelOptionGroupConfigBase.GetRootAsIVisualNovelOptionGroupConfigBase(_bb, default(IVisualNovelOptionGroupConfigBase));
		}

		// Token: 0x06036BD9 RID: 224217 RVA: 0x0076E680 File Offset: 0x0076C880
		public static IVisualNovelOptionGroupConfigBase GetRootAsIVisualNovelOptionGroupConfigBase(ByteBuffer _bb, IVisualNovelOptionGroupConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BDA RID: 224218 RVA: 0x0076E69D File Offset: 0x0076C89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BDB RID: 224219 RVA: 0x0076E6AC File Offset: 0x0076C8AC
		public IVisualNovelOptionGroupConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E42F RID: 58415
		// (get) Token: 0x06036BDC RID: 224220 RVA: 0x0076E6BC File Offset: 0x0076C8BC
		public EVisualNovelOptionGroupType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelOptionGroupType.SolarSchoolExam;
				}
				return (EVisualNovelOptionGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036BDD RID: 224221 RVA: 0x0076E6F8 File Offset: 0x0076C8F8
		public static Offset<IVisualNovelOptionGroupConfigBase> CreateIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder, EVisualNovelOptionGroupType Type = EVisualNovelOptionGroupType.SolarSchoolExam)
		{
			builder.StartTable(1);
			IVisualNovelOptionGroupConfigBase.AddType(builder, Type);
			return IVisualNovelOptionGroupConfigBase.EndIVisualNovelOptionGroupConfigBase(builder);
		}

		// Token: 0x06036BDE RID: 224222 RVA: 0x0076E70E File Offset: 0x0076C90E
		public static void StartIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036BDF RID: 224223 RVA: 0x0076E717 File Offset: 0x0076C917
		public static void AddType(FlatBufferBuilder builder, EVisualNovelOptionGroupType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036BE0 RID: 224224 RVA: 0x0076E722 File Offset: 0x0076C922
		public static Offset<IVisualNovelOptionGroupConfigBase> EndIVisualNovelOptionGroupConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelOptionGroupConfigBase>(builder.EndTable());
		}

		// Token: 0x06036BE1 RID: 224225 RVA: 0x0076E730 File Offset: 0x0076C930
		public IVisualNovelOptionGroupConfigBaseT UnPack()
		{
			IVisualNovelOptionGroupConfigBaseT visualNovelOptionGroupConfigBaseT = new IVisualNovelOptionGroupConfigBaseT();
			this.UnPackTo(visualNovelOptionGroupConfigBaseT);
			return visualNovelOptionGroupConfigBaseT;
		}

		// Token: 0x06036BE2 RID: 224226 RVA: 0x0076E74B File Offset: 0x0076C94B
		public void UnPackTo(IVisualNovelOptionGroupConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036BE3 RID: 224227 RVA: 0x0076E75C File Offset: 0x0076C95C
		public static Offset<IVisualNovelOptionGroupConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelOptionGroupConfigBase>);
			}
			return IVisualNovelOptionGroupConfigBase.CreateIVisualNovelOptionGroupConfigBase(builder, _o.Type);
		}

		// Token: 0x04012492 RID: 74898
		private Table __p;
	}
}
