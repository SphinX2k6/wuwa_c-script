using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D7F RID: 32127
	public struct IVisualNovelMainRoleActionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F05B RID: 61531
		// (get) Token: 0x06039FEC RID: 237548 RVA: 0x007D1A7A File Offset: 0x007CFC7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039FED RID: 237549 RVA: 0x007D1A87 File Offset: 0x007CFC87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039FEE RID: 237550 RVA: 0x007D1A90 File Offset: 0x007CFC90
		public static IVisualNovelMainRoleActionConfigBase GetRootAsIVisualNovelMainRoleActionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelMainRoleActionConfigBase.GetRootAsIVisualNovelMainRoleActionConfigBase(_bb, default(IVisualNovelMainRoleActionConfigBase));
		}

		// Token: 0x06039FEF RID: 237551 RVA: 0x007D1AAC File Offset: 0x007CFCAC
		public static IVisualNovelMainRoleActionConfigBase GetRootAsIVisualNovelMainRoleActionConfigBase(ByteBuffer _bb, IVisualNovelMainRoleActionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039FF0 RID: 237552 RVA: 0x007D1AC9 File Offset: 0x007CFCC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039FF1 RID: 237553 RVA: 0x007D1AD8 File Offset: 0x007CFCD8
		public IVisualNovelMainRoleActionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F05C RID: 61532
		// (get) Token: 0x06039FF2 RID: 237554 RVA: 0x007D1AE8 File Offset: 0x007CFCE8
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

		// Token: 0x06039FF3 RID: 237555 RVA: 0x007D1B24 File Offset: 0x007CFD24
		public static Offset<IVisualNovelMainRoleActionConfigBase> CreateIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelMainRoleActionConfigBase.AddType(builder, Type);
			return IVisualNovelMainRoleActionConfigBase.EndIVisualNovelMainRoleActionConfigBase(builder);
		}

		// Token: 0x06039FF4 RID: 237556 RVA: 0x007D1B3A File Offset: 0x007CFD3A
		public static void StartIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039FF5 RID: 237557 RVA: 0x007D1B43 File Offset: 0x007CFD43
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039FF6 RID: 237558 RVA: 0x007D1B4E File Offset: 0x007CFD4E
		public static Offset<IVisualNovelMainRoleActionConfigBase> EndIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelMainRoleActionConfigBase>(builder.EndTable());
		}

		// Token: 0x06039FF7 RID: 237559 RVA: 0x007D1B5C File Offset: 0x007CFD5C
		public IVisualNovelMainRoleActionConfigBaseT UnPack()
		{
			IVisualNovelMainRoleActionConfigBaseT visualNovelMainRoleActionConfigBaseT = new IVisualNovelMainRoleActionConfigBaseT();
			this.UnPackTo(visualNovelMainRoleActionConfigBaseT);
			return visualNovelMainRoleActionConfigBaseT;
		}

		// Token: 0x06039FF8 RID: 237560 RVA: 0x007D1B77 File Offset: 0x007CFD77
		public void UnPackTo(IVisualNovelMainRoleActionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039FF9 RID: 237561 RVA: 0x007D1B88 File Offset: 0x007CFD88
		public static Offset<IVisualNovelMainRoleActionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelMainRoleActionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelMainRoleActionConfigBase>);
			}
			return IVisualNovelMainRoleActionConfigBase.CreateIVisualNovelMainRoleActionConfigBase(builder, _o.Type);
		}

		// Token: 0x040134C4 RID: 79044
		private Table __p;
	}
}
