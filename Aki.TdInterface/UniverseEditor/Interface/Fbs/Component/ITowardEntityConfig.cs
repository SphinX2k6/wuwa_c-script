using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060CA RID: 24778
	public struct ITowardEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700B82C RID: 47148
		// (get) Token: 0x06029ECE RID: 171726 RVA: 0x005B8CF2 File Offset: 0x005B6EF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029ECF RID: 171727 RVA: 0x005B8CFF File Offset: 0x005B6EFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029ED0 RID: 171728 RVA: 0x005B8D08 File Offset: 0x005B6F08
		public static ITowardEntityConfig GetRootAsITowardEntityConfig(ByteBuffer _bb)
		{
			return ITowardEntityConfig.GetRootAsITowardEntityConfig(_bb, default(ITowardEntityConfig));
		}

		// Token: 0x06029ED1 RID: 171729 RVA: 0x005B8D24 File Offset: 0x005B6F24
		public static ITowardEntityConfig GetRootAsITowardEntityConfig(ByteBuffer _bb, ITowardEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029ED2 RID: 171730 RVA: 0x005B8D41 File Offset: 0x005B6F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029ED3 RID: 171731 RVA: 0x005B8D50 File Offset: 0x005B6F50
		public ITowardEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B82D RID: 47149
		// (get) Token: 0x06029ED4 RID: 171732 RVA: 0x005B8D60 File Offset: 0x005B6F60
		public string ReferenceActorKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029ED5 RID: 171733 RVA: 0x005B8D97 File Offset: 0x005B6F97
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029ED6 RID: 171734 RVA: 0x005B8DA6 File Offset: 0x005B6FA6
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B82E RID: 47150
		// (get) Token: 0x06029ED7 RID: 171735 RVA: 0x005B8DB4 File Offset: 0x005B6FB4
		public int TargetEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029ED8 RID: 171736 RVA: 0x005B8DF0 File Offset: 0x005B6FF0
		public static Offset<ITowardEntityConfig> CreateITowardEntityConfig(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), int TargetEntityId = 0)
		{
			builder.StartTable(2);
			ITowardEntityConfig.AddTargetEntityId(builder, TargetEntityId);
			ITowardEntityConfig.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			return ITowardEntityConfig.EndITowardEntityConfig(builder);
		}

		// Token: 0x06029ED9 RID: 171737 RVA: 0x005B8E0D File Offset: 0x005B700D
		public static void StartITowardEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029EDA RID: 171738 RVA: 0x005B8E16 File Offset: 0x005B7016
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x06029EDB RID: 171739 RVA: 0x005B8E26 File Offset: 0x005B7026
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x06029EDC RID: 171740 RVA: 0x005B8E31 File Offset: 0x005B7031
		public static Offset<ITowardEntityConfig> EndITowardEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITowardEntityConfig>(builder.EndTable());
		}

		// Token: 0x06029EDD RID: 171741 RVA: 0x005B8E40 File Offset: 0x005B7040
		public ITowardEntityConfigT UnPack()
		{
			ITowardEntityConfigT towardEntityConfigT = new ITowardEntityConfigT();
			this.UnPackTo(towardEntityConfigT);
			return towardEntityConfigT;
		}

		// Token: 0x06029EDE RID: 171742 RVA: 0x005B8E5B File Offset: 0x005B705B
		public void UnPackTo(ITowardEntityConfigT _o)
		{
			_o.ReferenceActorKey = this.ReferenceActorKey;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x06029EDF RID: 171743 RVA: 0x005B8E78 File Offset: 0x005B7078
		public static Offset<ITowardEntityConfig> Pack(FlatBufferBuilder builder, ITowardEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITowardEntityConfig>);
			}
			StringOffset referenceActorKeyOffset = (_o.ReferenceActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ReferenceActorKey);
			return ITowardEntityConfig.CreateITowardEntityConfig(builder, referenceActorKeyOffset, _o.TargetEntityId);
		}

		// Token: 0x0400FE7F RID: 65151
		private Table __p;
	}
}
