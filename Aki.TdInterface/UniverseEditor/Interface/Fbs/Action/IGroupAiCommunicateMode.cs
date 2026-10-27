using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A6 RID: 26790
	public struct IGroupAiCommunicateMode : IFlatbufferObject
	{
		// Token: 0x1700C6E4 RID: 50916
		// (get) Token: 0x0602EBA6 RID: 191398 RVA: 0x0065EB7D File Offset: 0x0065CD7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBA7 RID: 191399 RVA: 0x0065EB8A File Offset: 0x0065CD8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBA8 RID: 191400 RVA: 0x0065EB94 File Offset: 0x0065CD94
		public static IGroupAiCommunicateMode GetRootAsIGroupAiCommunicateMode(ByteBuffer _bb)
		{
			return IGroupAiCommunicateMode.GetRootAsIGroupAiCommunicateMode(_bb, default(IGroupAiCommunicateMode));
		}

		// Token: 0x0602EBA9 RID: 191401 RVA: 0x0065EBB0 File Offset: 0x0065CDB0
		public static IGroupAiCommunicateMode GetRootAsIGroupAiCommunicateMode(ByteBuffer _bb, IGroupAiCommunicateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBAA RID: 191402 RVA: 0x0065EBCD File Offset: 0x0065CDCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBAB RID: 191403 RVA: 0x0065EBDC File Offset: 0x0065CDDC
		public IGroupAiCommunicateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6E5 RID: 50917
		// (get) Token: 0x0602EBAC RID: 191404 RVA: 0x0065EBEC File Offset: 0x0065CDEC
		public EGroupAiCommunicateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return (EGroupAiCommunicateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EBAD RID: 191405 RVA: 0x0065EC28 File Offset: 0x0065CE28
		public static Offset<IGroupAiCommunicateMode> CreateIGroupAiCommunicateMode(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag)
		{
			builder.StartTable(1);
			IGroupAiCommunicateMode.AddType(builder, Type);
			return IGroupAiCommunicateMode.EndIGroupAiCommunicateMode(builder);
		}

		// Token: 0x0602EBAE RID: 191406 RVA: 0x0065EC3E File Offset: 0x0065CE3E
		public static void StartIGroupAiCommunicateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EBAF RID: 191407 RVA: 0x0065EC47 File Offset: 0x0065CE47
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EBB0 RID: 191408 RVA: 0x0065EC52 File Offset: 0x0065CE52
		public static Offset<IGroupAiCommunicateMode> EndIGroupAiCommunicateMode(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateMode>(builder.EndTable());
		}

		// Token: 0x0602EBB1 RID: 191409 RVA: 0x0065EC60 File Offset: 0x0065CE60
		public IGroupAiCommunicateModeT UnPack()
		{
			IGroupAiCommunicateModeT groupAiCommunicateModeT = new IGroupAiCommunicateModeT();
			this.UnPackTo(groupAiCommunicateModeT);
			return groupAiCommunicateModeT;
		}

		// Token: 0x0602EBB2 RID: 191410 RVA: 0x0065EC7B File Offset: 0x0065CE7B
		public void UnPackTo(IGroupAiCommunicateModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EBB3 RID: 191411 RVA: 0x0065EC8C File Offset: 0x0065CE8C
		public static Offset<IGroupAiCommunicateMode> Pack(FlatBufferBuilder builder, IGroupAiCommunicateModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiCommunicateMode>);
			}
			return IGroupAiCommunicateMode.CreateIGroupAiCommunicateMode(builder, _o.Type);
		}

		// Token: 0x04010FF7 RID: 69623
		private Table __p;
	}
}
