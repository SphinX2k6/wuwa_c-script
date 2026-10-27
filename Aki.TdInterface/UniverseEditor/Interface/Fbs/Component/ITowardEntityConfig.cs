using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABD RID: 23229
	public struct ITowardEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700AEF0 RID: 44784
		// (get) Token: 0x06027948 RID: 162120 RVA: 0x00571A0A File Offset: 0x0056FC0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027949 RID: 162121 RVA: 0x00571A17 File Offset: 0x0056FC17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602794A RID: 162122 RVA: 0x00571A20 File Offset: 0x0056FC20
		public static ITowardEntityConfig GetRootAsITowardEntityConfig(ByteBuffer _bb)
		{
			return ITowardEntityConfig.GetRootAsITowardEntityConfig(_bb, default(ITowardEntityConfig));
		}

		// Token: 0x0602794B RID: 162123 RVA: 0x00571A3C File Offset: 0x0056FC3C
		public static ITowardEntityConfig GetRootAsITowardEntityConfig(ByteBuffer _bb, ITowardEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602794C RID: 162124 RVA: 0x00571A59 File Offset: 0x0056FC59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602794D RID: 162125 RVA: 0x00571A68 File Offset: 0x0056FC68
		public ITowardEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEF1 RID: 44785
		// (get) Token: 0x0602794E RID: 162126 RVA: 0x00571A78 File Offset: 0x0056FC78
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

		// Token: 0x0602794F RID: 162127 RVA: 0x00571AAF File Offset: 0x0056FCAF
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027950 RID: 162128 RVA: 0x00571ABE File Offset: 0x0056FCBE
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AEF2 RID: 44786
		// (get) Token: 0x06027951 RID: 162129 RVA: 0x00571ACC File Offset: 0x0056FCCC
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

		// Token: 0x06027952 RID: 162130 RVA: 0x00571B08 File Offset: 0x0056FD08
		public static Offset<ITowardEntityConfig> CreateITowardEntityConfig(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), int TargetEntityId = 0)
		{
			builder.StartTable(2);
			ITowardEntityConfig.AddTargetEntityId(builder, TargetEntityId);
			ITowardEntityConfig.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			return ITowardEntityConfig.EndITowardEntityConfig(builder);
		}

		// Token: 0x06027953 RID: 162131 RVA: 0x00571B25 File Offset: 0x0056FD25
		public static void StartITowardEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027954 RID: 162132 RVA: 0x00571B2E File Offset: 0x0056FD2E
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x06027955 RID: 162133 RVA: 0x00571B3E File Offset: 0x0056FD3E
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x06027956 RID: 162134 RVA: 0x00571B49 File Offset: 0x0056FD49
		public static Offset<ITowardEntityConfig> EndITowardEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITowardEntityConfig>(builder.EndTable());
		}

		// Token: 0x06027957 RID: 162135 RVA: 0x00571B58 File Offset: 0x0056FD58
		public ITowardEntityConfigT UnPack()
		{
			ITowardEntityConfigT towardEntityConfigT = new ITowardEntityConfigT();
			this.UnPackTo(towardEntityConfigT);
			return towardEntityConfigT;
		}

		// Token: 0x06027958 RID: 162136 RVA: 0x00571B73 File Offset: 0x0056FD73
		public void UnPackTo(ITowardEntityConfigT _o)
		{
			_o.ReferenceActorKey = this.ReferenceActorKey;
			_o.TargetEntityId = this.TargetEntityId;
		}

		// Token: 0x06027959 RID: 162137 RVA: 0x00571B90 File Offset: 0x0056FD90
		public static Offset<ITowardEntityConfig> Pack(FlatBufferBuilder builder, ITowardEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITowardEntityConfig>);
			}
			StringOffset referenceActorKeyOffset = (_o.ReferenceActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ReferenceActorKey);
			return ITowardEntityConfig.CreateITowardEntityConfig(builder, referenceActorKeyOffset, _o.TargetEntityId);
		}

		// Token: 0x0400F186 RID: 61830
		private Table __p;
	}
}
