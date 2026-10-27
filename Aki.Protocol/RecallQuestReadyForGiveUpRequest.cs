using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC5 RID: 3781
	[NetMessage(EMessageId.RecallQuestReadyForGiveUpRequest)]
	public sealed class RecallQuestReadyForGiveUpRequest : IMessage<RecallQuestReadyForGiveUpRequest>, IMessage, IEquatable<RecallQuestReadyForGiveUpRequest>, IDeepCloneable<RecallQuestReadyForGiveUpRequest>, IBufferMessage
	{
		// Token: 0x06014467 RID: 83047 RVA: 0x002F2889 File Offset: 0x002F0A89
		[NullableContext(1)]
		public static RecallQuestReadyForGiveUpRequest Create()
		{
			return new RecallQuestReadyForGiveUpRequest();
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x06014468 RID: 83048 RVA: 0x002F2890 File Offset: 0x002F0A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x06014469 RID: 83049 RVA: 0x002F2893 File Offset: 0x002F0A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestReadyForGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x0601446A RID: 83050 RVA: 0x002F289A File Offset: 0x002F0A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest()
		{
		}

		// Token: 0x0601446B RID: 83051 RVA: 0x002F28A2 File Offset: 0x002F0AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest(RecallQuestReadyForGiveUpRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601446C RID: 83052 RVA: 0x002F28C7 File Offset: 0x002F0AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest Clone()
		{
			return new RecallQuestReadyForGiveUpRequest(this);
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0601446D RID: 83053 RVA: 0x002F28CF File Offset: 0x002F0ACF
		// (set) Token: 0x0601446E RID: 83054 RVA: 0x002F28D7 File Offset: 0x002F0AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x0601446F RID: 83055 RVA: 0x002F28E0 File Offset: 0x002F0AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestReadyForGiveUpRequest);
		}

		// Token: 0x06014470 RID: 83056 RVA: 0x002F28EE File Offset: 0x002F0AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestReadyForGiveUpRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014471 RID: 83057 RVA: 0x002F291C File Offset: 0x002F0B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014472 RID: 83058 RVA: 0x002F295B File Offset: 0x002F0B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014473 RID: 83059 RVA: 0x002F2968 File Offset: 0x002F0B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014474 RID: 83060 RVA: 0x002F2971 File Offset: 0x002F0B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014475 RID: 83061 RVA: 0x002F29A4 File Offset: 0x002F0BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014476 RID: 83062 RVA: 0x002F29E2 File Offset: 0x002F0BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestReadyForGiveUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014477 RID: 83063 RVA: 0x002F2A13 File Offset: 0x002F0C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014478 RID: 83064 RVA: 0x002F2A1C File Offset: 0x002F0C1C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B3C RID: 31548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B3D RID: 31549
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B3E RID: 31550
		private int recallQuestId_;
	}
}
