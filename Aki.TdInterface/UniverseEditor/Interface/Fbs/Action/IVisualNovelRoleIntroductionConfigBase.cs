using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DDC RID: 32220
	public struct IVisualNovelRoleIntroductionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700F167 RID: 61799
		// (get) Token: 0x0603A3B1 RID: 238513 RVA: 0x007D90D8 File Offset: 0x007D72D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A3B2 RID: 238514 RVA: 0x007D90E5 File Offset: 0x007D72E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A3B3 RID: 238515 RVA: 0x007D90EC File Offset: 0x007D72EC
		public static IVisualNovelRoleIntroductionConfigBase GetRootAsIVisualNovelRoleIntroductionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelRoleIntroductionConfigBase.GetRootAsIVisualNovelRoleIntroductionConfigBase(_bb, default(IVisualNovelRoleIntroductionConfigBase));
		}

		// Token: 0x0603A3B4 RID: 238516 RVA: 0x007D9108 File Offset: 0x007D7308
		public static IVisualNovelRoleIntroductionConfigBase GetRootAsIVisualNovelRoleIntroductionConfigBase(ByteBuffer _bb, IVisualNovelRoleIntroductionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A3B5 RID: 238517 RVA: 0x007D9125 File Offset: 0x007D7325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A3B6 RID: 238518 RVA: 0x007D9134 File Offset: 0x007D7334
		public IVisualNovelRoleIntroductionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F168 RID: 61800
		// (get) Token: 0x0603A3B7 RID: 238519 RVA: 0x007D9144 File Offset: 0x007D7344
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

		// Token: 0x0603A3B8 RID: 238520 RVA: 0x007D9180 File Offset: 0x007D7380
		public static Offset<IVisualNovelRoleIntroductionConfigBase> CreateIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelRoleIntroductionConfigBase.AddType(builder, Type);
			return IVisualNovelRoleIntroductionConfigBase.EndIVisualNovelRoleIntroductionConfigBase(builder);
		}

		// Token: 0x0603A3B9 RID: 238521 RVA: 0x007D9196 File Offset: 0x007D7396
		public static void StartIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A3BA RID: 238522 RVA: 0x007D919F File Offset: 0x007D739F
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A3BB RID: 238523 RVA: 0x007D91AA File Offset: 0x007D73AA
		public static Offset<IVisualNovelRoleIntroductionConfigBase> EndIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleIntroductionConfigBase>(builder.EndTable());
		}

		// Token: 0x0603A3BC RID: 238524 RVA: 0x007D91B8 File Offset: 0x007D73B8
		public IVisualNovelRoleIntroductionConfigBaseT UnPack()
		{
			IVisualNovelRoleIntroductionConfigBaseT visualNovelRoleIntroductionConfigBaseT = new IVisualNovelRoleIntroductionConfigBaseT();
			this.UnPackTo(visualNovelRoleIntroductionConfigBaseT);
			return visualNovelRoleIntroductionConfigBaseT;
		}

		// Token: 0x0603A3BD RID: 238525 RVA: 0x007D91D3 File Offset: 0x007D73D3
		public void UnPackTo(IVisualNovelRoleIntroductionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A3BE RID: 238526 RVA: 0x007D91E4 File Offset: 0x007D73E4
		public static Offset<IVisualNovelRoleIntroductionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelRoleIntroductionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleIntroductionConfigBase>);
			}
			return IVisualNovelRoleIntroductionConfigBase.CreateIVisualNovelRoleIntroductionConfigBase(builder, _o.Type);
		}

		// Token: 0x04013579 RID: 79225
		private Table __p;
	}
}
