using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E90 RID: 3728
	public sealed class RealmBetweenMotorcycleInfo : IMessage<RealmBetweenMotorcycleInfo>, IMessage, IEquatable<RealmBetweenMotorcycleInfo>, IDeepCloneable<RealmBetweenMotorcycleInfo>, IBufferMessage
	{
		// Token: 0x060140AC RID: 82092 RVA: 0x002EB808 File Offset: 0x002E9A08
		[NullableContext(1)]
		public static RealmBetweenMotorcycleInfo Create()
		{
			return new RealmBetweenMotorcycleInfo();
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x060140AD RID: 82093 RVA: 0x002EB80F File Offset: 0x002E9A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RealmBetweenMotorcycleInfo> Parser
		{
			get
			{
				return RealmBetweenMotorcycleInfo._parser;
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x060140AE RID: 82094 RVA: 0x002EB816 File Offset: 0x002E9A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x060140AF RID: 82095 RVA: 0x002EB819 File Offset: 0x002E9A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorcycleInfo.Descriptor;
			}
		}

		// Token: 0x060140B0 RID: 82096 RVA: 0x002EB820 File Offset: 0x002E9A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo()
		{
		}

		// Token: 0x060140B1 RID: 82097 RVA: 0x002EB834 File Offset: 0x002E9A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo(RealmBetweenMotorcycleInfo other) : this()
		{
			this.motorcyclePlayId_ = other.motorcyclePlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140B2 RID: 82098 RVA: 0x002EB881 File Offset: 0x002E9A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo Clone()
		{
			return new RealmBetweenMotorcycleInfo(this);
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x060140B3 RID: 82099 RVA: 0x002EB889 File Offset: 0x002E9A89
		// (set) Token: 0x060140B4 RID: 82100 RVA: 0x002EB891 File Offset: 0x002E9A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorcyclePlayId
		{
			get
			{
				return this.motorcyclePlayId_;
			}
			set
			{
				this.motorcyclePlayId_ = value;
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x060140B5 RID: 82101 RVA: 0x002EB89A File Offset: 0x002E9A9A
		// (set) Token: 0x060140B6 RID: 82102 RVA: 0x002EB8A2 File Offset: 0x002E9AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistorySoarScore
		{
			get
			{
				return this.historySoarScore_;
			}
			set
			{
				this.historySoarScore_ = value;
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x060140B7 RID: 82103 RVA: 0x002EB8AB File Offset: 0x002E9AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x060140B8 RID: 82104 RVA: 0x002EB8B3 File Offset: 0x002E9AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorcycleInfo);
		}

		// Token: 0x060140B9 RID: 82105 RVA: 0x002EB8C4 File Offset: 0x002E9AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorcycleInfo other)
		{
			return other != null && (other == this || (this.MotorcyclePlayId == other.MotorcyclePlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140BA RID: 82106 RVA: 0x002EB924 File Offset: 0x002E9B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorcyclePlayId != 0)
			{
				num ^= this.MotorcyclePlayId.GetHashCode();
			}
			if (this.HistorySoarScore != 0)
			{
				num ^= this.HistorySoarScore.GetHashCode();
			}
			num ^= this.receiveIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060140BB RID: 82107 RVA: 0x002EB98A File Offset: 0x002E9B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140BC RID: 82108 RVA: 0x002EB997 File Offset: 0x002E9B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140BD RID: 82109 RVA: 0x002EB9A0 File Offset: 0x002E9BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorcyclePlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorcyclePlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HistorySoarScore);
			}
			this.receiveIds_.WriteTo(ref output, RealmBetweenMotorcycleInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140BE RID: 82110 RVA: 0x002EBA0C File Offset: 0x002E9C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorcyclePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorcyclePlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistorySoarScore);
			}
			num += this.receiveIds_.CalculateSize(RealmBetweenMotorcycleInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140BF RID: 82111 RVA: 0x002EBA78 File Offset: 0x002E9C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenMotorcycleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorcyclePlayId != 0)
			{
				this.MotorcyclePlayId = other.MotorcyclePlayId;
			}
			if (other.HistorySoarScore != 0)
			{
				this.HistorySoarScore = other.HistorySoarScore;
			}
			this.receiveIds_.Add(other.receiveIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140C0 RID: 82112 RVA: 0x002EBAD9 File Offset: 0x002E9CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140C1 RID: 82113 RVA: 0x002EBAE4 File Offset: 0x002E9CE4
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
					if (num == 8U)
					{
						this.MotorcyclePlayId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HistorySoarScore = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.receiveIds_.AddEntriesFrom(ref input, RealmBetweenMotorcycleInfo._repeated_receiveIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007AAB RID: 31403
		private static readonly MessageParser<RealmBetweenMotorcycleInfo> _parser = new MessageParser<RealmBetweenMotorcycleInfo>(() => new RealmBetweenMotorcycleInfo());

		// Token: 0x04007AAC RID: 31404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AAD RID: 31405
		public const int MotorcyclePlayIdFieldNumber = 1;

		// Token: 0x04007AAE RID: 31406
		private int motorcyclePlayId_;

		// Token: 0x04007AAF RID: 31407
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x04007AB0 RID: 31408
		private int historySoarScore_;

		// Token: 0x04007AB1 RID: 31409
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x04007AB2 RID: 31410
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007AB3 RID: 31411
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
