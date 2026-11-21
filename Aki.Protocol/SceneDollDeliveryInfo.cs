using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001187 RID: 4487
	public sealed class SceneDollDeliveryInfo : IMessage<SceneDollDeliveryInfo>, IMessage, IEquatable<SceneDollDeliveryInfo>, IDeepCloneable<SceneDollDeliveryInfo>, IBufferMessage
	{
		// Token: 0x06017F6A RID: 98154 RVA: 0x0037CC09 File Offset: 0x0037AE09
		[NullableContext(1)]
		public static SceneDollDeliveryInfo Create()
		{
			return new SceneDollDeliveryInfo();
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x06017F6B RID: 98155 RVA: 0x0037CC10 File Offset: 0x0037AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneDollDeliveryInfo> Parser
		{
			get
			{
				return SceneDollDeliveryInfo._parser;
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x06017F6C RID: 98156 RVA: 0x0037CC17 File Offset: 0x0037AE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x06017F6D RID: 98157 RVA: 0x0037CC1A File Offset: 0x0037AE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneDollDeliveryInfo.Descriptor;
			}
		}

		// Token: 0x06017F6E RID: 98158 RVA: 0x0037CC21 File Offset: 0x0037AE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo()
		{
		}

		// Token: 0x06017F6F RID: 98159 RVA: 0x0037CC34 File Offset: 0x0037AE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo(SceneDollDeliveryInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.dollDeliveryInfos_ = other.dollDeliveryInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F70 RID: 98160 RVA: 0x0037CC6A File Offset: 0x0037AE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDollDeliveryInfo Clone()
		{
			return new SceneDollDeliveryInfo(this);
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x06017F71 RID: 98161 RVA: 0x0037CC72 File Offset: 0x0037AE72
		// (set) Token: 0x06017F72 RID: 98162 RVA: 0x0037CC7A File Offset: 0x0037AE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x06017F73 RID: 98163 RVA: 0x0037CC83 File Offset: 0x0037AE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollDeliveryInfo> DollDeliveryInfos
		{
			get
			{
				return this.dollDeliveryInfos_;
			}
		}

		// Token: 0x06017F74 RID: 98164 RVA: 0x0037CC8B File Offset: 0x0037AE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneDollDeliveryInfo);
		}

		// Token: 0x06017F75 RID: 98165 RVA: 0x0037CC9C File Offset: 0x0037AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneDollDeliveryInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.dollDeliveryInfos_.Equals(other.dollDeliveryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F76 RID: 98166 RVA: 0x0037CCEC File Offset: 0x0037AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.dollDeliveryInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F77 RID: 98167 RVA: 0x0037CD39 File Offset: 0x0037AF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F78 RID: 98168 RVA: 0x0037CD46 File Offset: 0x0037AF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F79 RID: 98169 RVA: 0x0037CD50 File Offset: 0x0037AF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.dollDeliveryInfos_.WriteTo(ref output, SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F7A RID: 98170 RVA: 0x0037CDA0 File Offset: 0x0037AFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.dollDeliveryInfos_.CalculateSize(SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F7B RID: 98171 RVA: 0x0037CDF4 File Offset: 0x0037AFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneDollDeliveryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.dollDeliveryInfos_.Add(other.dollDeliveryInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F7C RID: 98172 RVA: 0x0037CE41 File Offset: 0x0037B041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F7D RID: 98173 RVA: 0x0037CE4C File Offset: 0x0037B04C
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dollDeliveryInfos_.AddEntriesFrom(ref input, SceneDollDeliveryInfo._repeated_dollDeliveryInfos_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EBF RID: 36543
		private static readonly MessageParser<SceneDollDeliveryInfo> _parser = new MessageParser<SceneDollDeliveryInfo>(() => new SceneDollDeliveryInfo());

		// Token: 0x04008EC0 RID: 36544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EC1 RID: 36545
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008EC2 RID: 36546
		private int instId_;

		// Token: 0x04008EC3 RID: 36547
		public const int DollDeliveryInfosFieldNumber = 2;

		// Token: 0x04008EC4 RID: 36548
		private static readonly FieldCodec<DollDeliveryInfo> _repeated_dollDeliveryInfos_codec = FieldCodec.ForMessage<DollDeliveryInfo>(18U, DollDeliveryInfo.Parser);

		// Token: 0x04008EC5 RID: 36549
		private readonly RepeatedField<DollDeliveryInfo> dollDeliveryInfos_ = new RepeatedField<DollDeliveryInfo>();
	}
}
