using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA0 RID: 3744
	public sealed class RealmBetweenMotorcycleInfo : IMessage<RealmBetweenMotorcycleInfo>, IMessage, IEquatable<RealmBetweenMotorcycleInfo>, IDeepCloneable<RealmBetweenMotorcycleInfo>, IBufferMessage
	{
		// Token: 0x06014191 RID: 82321 RVA: 0x002ECEB5 File Offset: 0x002EB0B5
		[NullableContext(1)]
		public static RealmBetweenMotorcycleInfo Create()
		{
			return new RealmBetweenMotorcycleInfo();
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x06014192 RID: 82322 RVA: 0x002ECEBC File Offset: 0x002EB0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RealmBetweenMotorcycleInfo> Parser
		{
			get
			{
				return RealmBetweenMotorcycleInfo._parser;
			}
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x06014193 RID: 82323 RVA: 0x002ECEC3 File Offset: 0x002EB0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x06014194 RID: 82324 RVA: 0x002ECEC6 File Offset: 0x002EB0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorcycleInfo.Descriptor;
			}
		}

		// Token: 0x06014195 RID: 82325 RVA: 0x002ECECD File Offset: 0x002EB0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo()
		{
		}

		// Token: 0x06014196 RID: 82326 RVA: 0x002ECEE0 File Offset: 0x002EB0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo(RealmBetweenMotorcycleInfo other) : this()
		{
			this.motorcyclePlayId_ = other.motorcyclePlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014197 RID: 82327 RVA: 0x002ECF2D File Offset: 0x002EB12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorcycleInfo Clone()
		{
			return new RealmBetweenMotorcycleInfo(this);
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x06014198 RID: 82328 RVA: 0x002ECF35 File Offset: 0x002EB135
		// (set) Token: 0x06014199 RID: 82329 RVA: 0x002ECF3D File Offset: 0x002EB13D
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

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x0601419A RID: 82330 RVA: 0x002ECF46 File Offset: 0x002EB146
		// (set) Token: 0x0601419B RID: 82331 RVA: 0x002ECF4E File Offset: 0x002EB14E
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

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x0601419C RID: 82332 RVA: 0x002ECF57 File Offset: 0x002EB157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x0601419D RID: 82333 RVA: 0x002ECF5F File Offset: 0x002EB15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorcycleInfo);
		}

		// Token: 0x0601419E RID: 82334 RVA: 0x002ECF70 File Offset: 0x002EB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorcycleInfo other)
		{
			return other != null && (other == this || (this.MotorcyclePlayId == other.MotorcyclePlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601419F RID: 82335 RVA: 0x002ECFD0 File Offset: 0x002EB1D0
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

		// Token: 0x060141A0 RID: 82336 RVA: 0x002ED036 File Offset: 0x002EB236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141A1 RID: 82337 RVA: 0x002ED043 File Offset: 0x002EB243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141A2 RID: 82338 RVA: 0x002ED04C File Offset: 0x002EB24C
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

		// Token: 0x060141A3 RID: 82339 RVA: 0x002ED0B8 File Offset: 0x002EB2B8
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

		// Token: 0x060141A4 RID: 82340 RVA: 0x002ED124 File Offset: 0x002EB324
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

		// Token: 0x060141A5 RID: 82341 RVA: 0x002ED185 File Offset: 0x002EB385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141A6 RID: 82342 RVA: 0x002ED190 File Offset: 0x002EB390
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

		// Token: 0x04007A81 RID: 31361
		private static readonly MessageParser<RealmBetweenMotorcycleInfo> _parser = new MessageParser<RealmBetweenMotorcycleInfo>(() => new RealmBetweenMotorcycleInfo());

		// Token: 0x04007A82 RID: 31362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A83 RID: 31363
		public const int MotorcyclePlayIdFieldNumber = 1;

		// Token: 0x04007A84 RID: 31364
		private int motorcyclePlayId_;

		// Token: 0x04007A85 RID: 31365
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x04007A86 RID: 31366
		private int historySoarScore_;

		// Token: 0x04007A87 RID: 31367
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x04007A88 RID: 31368
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007A89 RID: 31369
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
