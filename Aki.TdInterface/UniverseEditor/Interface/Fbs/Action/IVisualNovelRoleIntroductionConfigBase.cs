using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D7 RID: 30167
	public struct IVisualNovelRoleIntroductionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E533 RID: 58675
		// (get) Token: 0x06036F42 RID: 225090 RVA: 0x00775484 File Offset: 0x00773684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F43 RID: 225091 RVA: 0x00775491 File Offset: 0x00773691
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F44 RID: 225092 RVA: 0x00775498 File Offset: 0x00773698
		public static IVisualNovelRoleIntroductionConfigBase GetRootAsIVisualNovelRoleIntroductionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelRoleIntroductionConfigBase.GetRootAsIVisualNovelRoleIntroductionConfigBase(_bb, default(IVisualNovelRoleIntroductionConfigBase));
		}

		// Token: 0x06036F45 RID: 225093 RVA: 0x007754B4 File Offset: 0x007736B4
		public static IVisualNovelRoleIntroductionConfigBase GetRootAsIVisualNovelRoleIntroductionConfigBase(ByteBuffer _bb, IVisualNovelRoleIntroductionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F46 RID: 225094 RVA: 0x007754D1 File Offset: 0x007736D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F47 RID: 225095 RVA: 0x007754E0 File Offset: 0x007736E0
		public IVisualNovelRoleIntroductionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E534 RID: 58676
		// (get) Token: 0x06036F48 RID: 225096 RVA: 0x007754F0 File Offset: 0x007736F0
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

		// Token: 0x06036F49 RID: 225097 RVA: 0x0077552C File Offset: 0x0077372C
		public static Offset<IVisualNovelRoleIntroductionConfigBase> CreateIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelRoleIntroductionConfigBase.AddType(builder, Type);
			return IVisualNovelRoleIntroductionConfigBase.EndIVisualNovelRoleIntroductionConfigBase(builder);
		}

		// Token: 0x06036F4A RID: 225098 RVA: 0x00775542 File Offset: 0x00773742
		public static void StartIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036F4B RID: 225099 RVA: 0x0077554B File Offset: 0x0077374B
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F4C RID: 225100 RVA: 0x00775556 File Offset: 0x00773756
		public static Offset<IVisualNovelRoleIntroductionConfigBase> EndIVisualNovelRoleIntroductionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleIntroductionConfigBase>(builder.EndTable());
		}

		// Token: 0x06036F4D RID: 225101 RVA: 0x00775564 File Offset: 0x00773764
		public IVisualNovelRoleIntroductionConfigBaseT UnPack()
		{
			IVisualNovelRoleIntroductionConfigBaseT visualNovelRoleIntroductionConfigBaseT = new IVisualNovelRoleIntroductionConfigBaseT();
			this.UnPackTo(visualNovelRoleIntroductionConfigBaseT);
			return visualNovelRoleIntroductionConfigBaseT;
		}

		// Token: 0x06036F4E RID: 225102 RVA: 0x0077557F File Offset: 0x0077377F
		public void UnPackTo(IVisualNovelRoleIntroductionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036F4F RID: 225103 RVA: 0x00775590 File Offset: 0x00773790
		public static Offset<IVisualNovelRoleIntroductionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelRoleIntroductionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleIntroductionConfigBase>);
			}
			return IVisualNovelRoleIntroductionConfigBase.CreateIVisualNovelRoleIntroductionConfigBase(builder, _o.Type);
		}

		// Token: 0x0401253A RID: 75066
		private Table __p;
	}
}
