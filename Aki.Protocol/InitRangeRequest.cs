using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080E RID: 2062
	[NetMessage(EMessageId.InitRangeRequest)]
	public sealed class InitRangeRequest : IMessage<InitRangeRequest>, IMessage, IEquatable<InitRangeRequest>, IDeepCloneable<InitRangeRequest>, IBufferMessage
	{
		// Token: 0x0600B86C RID: 47212 RVA: 0x001B7468 File Offset: 0x001B5668
		[NullableContext(1)]
		public static InitRangeRequest Create()
		{
			return new InitRangeRequest();
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x001B746F File Offset: 0x001B566F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x0600B86E RID: 47214 RVA: 0x001B7472 File Offset: 0x001B5672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitRangeRequest.Descriptor;
			}
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x001B7479 File Offset: 0x001B5679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest()
		{
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x001B748C File Offset: 0x001B568C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest(InitRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.inRangeEntityIds_ = other.inRangeEntityIds_.Clone();
			this.isPlayerInRange_ = other.isPlayerInRange_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x001B74D9 File Offset: 0x001B56D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest Clone()
		{
			return new InitRangeRequest(this);
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x0600B872 RID: 47218 RVA: 0x001B74E1 File Offset: 0x001B56E1
		// (set) Token: 0x0600B873 RID: 47219 RVA: 0x001B74E9 File Offset: 0x001B56E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x0600B874 RID: 47220 RVA: 0x001B74F2 File Offset: 0x001B56F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InRangeEntityIds
		{
			get
			{
				return this.inRangeEntityIds_;
			}
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x001B74FA File Offset: 0x001B56FA
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x001B7502 File Offset: 0x001B5702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPlayerInRange
		{
			get
			{
				return this.isPlayerInRange_;
			}
			set
			{
				this.isPlayerInRange_ = value;
			}
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x001B750B File Offset: 0x001B570B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitRangeRequest);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x001B751C File Offset: 0x001B571C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InitRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.inRangeEntityIds_.Equals(other.inRangeEntityIds_) && this.IsPlayerInRange == other.IsPlayerInRange && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x001B757C File Offset: 0x001B577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			num ^= this.inRangeEntityIds_.GetHashCode();
			if (this.IsPlayerInRange)
			{
				num ^= this.IsPlayerInRange.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x001B75E2 File Offset: 0x001B57E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x001B75EF File Offset: 0x001B57EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x001B75F8 File Offset: 0x001B57F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.inRangeEntityIds_.WriteTo(ref output, InitRangeRequest._repeated_inRangeEntityIds_codec);
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this.IsPlayerInRange)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsPlayerInRange);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x001B7664 File Offset: 0x001B5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			num += this.inRangeEntityIds_.CalculateSize(InitRangeRequest._repeated_inRangeEntityIds_codec);
			if (this.IsPlayerInRange)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x001B76C4 File Offset: 0x001B58C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InitRangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			this.inRangeEntityIds_.Add(other.inRangeEntityIds_);
			if (other.IsPlayerInRange)
			{
				this.IsPlayerInRange = other.IsPlayerInRange;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x001B7725 File Offset: 0x001B5925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x001B7730 File Offset: 0x001B5930
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.inRangeEntityIds_.AddEntriesFrom(ref input, InitRangeRequest._repeated_inRangeEntityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.IsPlayerInRange = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400513B RID: 20795
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400513C RID: 20796
		public const int RangeEntityIdFieldNumber = 8;

		// Token: 0x0400513D RID: 20797
		private long rangeEntityId_;

		// Token: 0x0400513E RID: 20798
		public const int InRangeEntityIdsFieldNumber = 1;

		// Token: 0x0400513F RID: 20799
		private static readonly FieldCodec<long> _repeated_inRangeEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04005140 RID: 20800
		private readonly RepeatedField<long> inRangeEntityIds_ = new RepeatedField<long>();

		// Token: 0x04005141 RID: 20801
		public const int IsPlayerInRangeFieldNumber = 10;

		// Token: 0x04005142 RID: 20802
		private bool isPlayerInRange_;
	}
}
