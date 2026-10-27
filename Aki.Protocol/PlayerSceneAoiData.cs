using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAB RID: 3499
	public sealed class PlayerSceneAoiData : IMessage<PlayerSceneAoiData>, IMessage, IEquatable<PlayerSceneAoiData>, IDeepCloneable<PlayerSceneAoiData>, IBufferMessage
	{
		// Token: 0x06012D9E RID: 77214 RVA: 0x002BFD69 File Offset: 0x002BDF69
		[NullableContext(1)]
		public static PlayerSceneAoiData Create()
		{
			return new PlayerSceneAoiData();
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x06012D9F RID: 77215 RVA: 0x002BFD70 File Offset: 0x002BDF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x06012DA0 RID: 77216 RVA: 0x002BFD73 File Offset: 0x002BDF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneAoiData.Descriptor;
			}
		}

		// Token: 0x06012DA1 RID: 77217 RVA: 0x002BFD7A File Offset: 0x002BDF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData()
		{
		}

		// Token: 0x06012DA2 RID: 77218 RVA: 0x002BFDA4 File Offset: 0x002BDFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData(PlayerSceneAoiData other) : this()
		{
			this.dynamicEntityList_ = other.dynamicEntityList_.Clone();
			this.genIds_ = other.genIds_.Clone();
			this.entities_ = other.entities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DA3 RID: 77219 RVA: 0x002BFDFB File Offset: 0x002BDFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData Clone()
		{
			return new PlayerSceneAoiData(this);
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x06012DA4 RID: 77220 RVA: 0x002BFE03 File Offset: 0x002BE003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> DynamicEntityList
		{
			get
			{
				return this.dynamicEntityList_;
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x06012DA5 RID: 77221 RVA: 0x002BFE0B File Offset: 0x002BE00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> GenIds
		{
			get
			{
				return this.genIds_;
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x06012DA6 RID: 77222 RVA: 0x002BFE13 File Offset: 0x002BE013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> Entities
		{
			get
			{
				return this.entities_;
			}
		}

		// Token: 0x06012DA7 RID: 77223 RVA: 0x002BFE1B File Offset: 0x002BE01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneAoiData);
		}

		// Token: 0x06012DA8 RID: 77224 RVA: 0x002BFE2C File Offset: 0x002BE02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneAoiData other)
		{
			return other != null && (other == this || (this.dynamicEntityList_.Equals(other.dynamicEntityList_) && this.genIds_.Equals(other.genIds_) && this.entities_.Equals(other.entities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DA9 RID: 77225 RVA: 0x002BFE94 File Offset: 0x002BE094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dynamicEntityList_.GetHashCode();
			num ^= this.genIds_.GetHashCode();
			num ^= this.entities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012DAA RID: 77226 RVA: 0x002BFEE4 File Offset: 0x002BE0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DAB RID: 77227 RVA: 0x002BFEF1 File Offset: 0x002BE0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DAC RID: 77228 RVA: 0x002BFEFC File Offset: 0x002BE0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dynamicEntityList_.WriteTo(ref output, PlayerSceneAoiData._repeated_dynamicEntityList_codec);
			this.genIds_.WriteTo(ref output, PlayerSceneAoiData._repeated_genIds_codec);
			this.entities_.WriteTo(ref output, PlayerSceneAoiData._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012DAD RID: 77229 RVA: 0x002BFF50 File Offset: 0x002BE150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dynamicEntityList_.CalculateSize(PlayerSceneAoiData._repeated_dynamicEntityList_codec);
			num += this.genIds_.CalculateSize(PlayerSceneAoiData._repeated_genIds_codec);
			num += this.entities_.CalculateSize(PlayerSceneAoiData._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012DAE RID: 77230 RVA: 0x002BFFB0 File Offset: 0x002BE1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSceneAoiData other)
		{
			if (other == null)
			{
				return;
			}
			this.dynamicEntityList_.Add(other.dynamicEntityList_);
			this.genIds_.Add(other.genIds_);
			this.entities_.Add(other.entities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012DAF RID: 77231 RVA: 0x002C000B File Offset: 0x002BE20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DB0 RID: 77232 RVA: 0x002C0014 File Offset: 0x002BE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.dynamicEntityList_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_dynamicEntityList_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 26U)
					{
						this.entities_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_entities_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.genIds_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_genIds_codec);
			}
		}

		// Token: 0x040074AA RID: 29866
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074AB RID: 29867
		public const int DynamicEntityListFieldNumber = 1;

		// Token: 0x040074AC RID: 29868
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_dynamicEntityList_codec = FieldCodec.ForMessage<DynamicEntityInformation>(10U, DynamicEntityInformation.Parser);

		// Token: 0x040074AD RID: 29869
		private readonly RepeatedField<DynamicEntityInformation> dynamicEntityList_ = new RepeatedField<DynamicEntityInformation>();

		// Token: 0x040074AE RID: 29870
		public const int GenIdsFieldNumber = 2;

		// Token: 0x040074AF RID: 29871
		private static readonly FieldCodec<long> _repeated_genIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x040074B0 RID: 29872
		private readonly RepeatedField<long> genIds_ = new RepeatedField<long>();

		// Token: 0x040074B1 RID: 29873
		public const int EntitiesFieldNumber = 3;

		// Token: 0x040074B2 RID: 29874
		private static readonly FieldCodec<EntityPb> _repeated_entities_codec = FieldCodec.ForMessage<EntityPb>(26U, EntityPb.Parser);

		// Token: 0x040074B3 RID: 29875
		private readonly RepeatedField<EntityPb> entities_ = new RepeatedField<EntityPb>();
	}
}
