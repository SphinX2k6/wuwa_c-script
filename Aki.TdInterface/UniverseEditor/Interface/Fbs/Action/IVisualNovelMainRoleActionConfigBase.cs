using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007589 RID: 30089
	public struct IVisualNovelMainRoleActionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E42B RID: 58411
		// (get) Token: 0x06036BC4 RID: 224196 RVA: 0x0076E4D6 File Offset: 0x0076C6D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BC5 RID: 224197 RVA: 0x0076E4E3 File Offset: 0x0076C6E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BC6 RID: 224198 RVA: 0x0076E4EC File Offset: 0x0076C6EC
		public static IVisualNovelMainRoleActionConfigBase GetRootAsIVisualNovelMainRoleActionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelMainRoleActionConfigBase.GetRootAsIVisualNovelMainRoleActionConfigBase(_bb, default(IVisualNovelMainRoleActionConfigBase));
		}

		// Token: 0x06036BC7 RID: 224199 RVA: 0x0076E508 File Offset: 0x0076C708
		public static IVisualNovelMainRoleActionConfigBase GetRootAsIVisualNovelMainRoleActionConfigBase(ByteBuffer _bb, IVisualNovelMainRoleActionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BC8 RID: 224200 RVA: 0x0076E525 File Offset: 0x0076C725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BC9 RID: 224201 RVA: 0x0076E534 File Offset: 0x0076C734
		public IVisualNovelMainRoleActionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E42C RID: 58412
		// (get) Token: 0x06036BCA RID: 224202 RVA: 0x0076E544 File Offset: 0x0076C744
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

		// Token: 0x06036BCB RID: 224203 RVA: 0x0076E580 File Offset: 0x0076C780
		public static Offset<IVisualNovelMainRoleActionConfigBase> CreateIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelMainRoleActionConfigBase.AddType(builder, Type);
			return IVisualNovelMainRoleActionConfigBase.EndIVisualNovelMainRoleActionConfigBase(builder);
		}

		// Token: 0x06036BCC RID: 224204 RVA: 0x0076E596 File Offset: 0x0076C796
		public static void StartIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036BCD RID: 224205 RVA: 0x0076E59F File Offset: 0x0076C79F
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036BCE RID: 224206 RVA: 0x0076E5AA File Offset: 0x0076C7AA
		public static Offset<IVisualNovelMainRoleActionConfigBase> EndIVisualNovelMainRoleActionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelMainRoleActionConfigBase>(builder.EndTable());
		}

		// Token: 0x06036BCF RID: 224207 RVA: 0x0076E5B8 File Offset: 0x0076C7B8
		public IVisualNovelMainRoleActionConfigBaseT UnPack()
		{
			IVisualNovelMainRoleActionConfigBaseT visualNovelMainRoleActionConfigBaseT = new IVisualNovelMainRoleActionConfigBaseT();
			this.UnPackTo(visualNovelMainRoleActionConfigBaseT);
			return visualNovelMainRoleActionConfigBaseT;
		}

		// Token: 0x06036BD0 RID: 224208 RVA: 0x0076E5D3 File Offset: 0x0076C7D3
		public void UnPackTo(IVisualNovelMainRoleActionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036BD1 RID: 224209 RVA: 0x0076E5E4 File Offset: 0x0076C7E4
		public static Offset<IVisualNovelMainRoleActionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelMainRoleActionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelMainRoleActionConfigBase>);
			}
			return IVisualNovelMainRoleActionConfigBase.CreateIVisualNovelMainRoleActionConfigBase(builder, _o.Type);
		}

		// Token: 0x04012490 RID: 74896
		private Table __p;
	}
}
