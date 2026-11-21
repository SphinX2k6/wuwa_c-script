using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001090 RID: 4240
	[NetMessage(EMessageId.RoleQuestAcceptRequest)]
	public sealed class RoleQuestAcceptRequest : IMessage<RoleQuestAcceptRequest>, IMessage, IEquatable<RoleQuestAcceptRequest>, IDeepCloneable<RoleQuestAcceptRequest>, IBufferMessage
	{
		// Token: 0x06016ACF RID: 92879 RVA: 0x0034C5E2 File Offset: 0x0034A7E2
		[NullableContext(1)]
		public static RoleQuestAcceptRequest Create()
		{
			return new RoleQuestAcceptRequest();
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x06016AD0 RID: 92880 RVA: 0x0034C5E9 File Offset: 0x0034A7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06016AD1 RID: 92881 RVA: 0x0034C5EC File Offset: 0x0034A7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestAcceptRequest.Descriptor;
			}
		}

		// Token: 0x06016AD2 RID: 92882 RVA: 0x0034C5F3 File Offset: 0x0034A7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest()
		{
		}

		// Token: 0x06016AD3 RID: 92883 RVA: 0x0034C5FB File Offset: 0x0034A7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest(RoleQuestAcceptRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AD4 RID: 92884 RVA: 0x0034C620 File Offset: 0x0034A820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest Clone()
		{
			return new RoleQuestAcceptRequest(this);
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06016AD5 RID: 92885 RVA: 0x0034C628 File Offset: 0x0034A828
		// (set) Token: 0x06016AD6 RID: 92886 RVA: 0x0034C630 File Offset: 0x0034A830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x06016AD7 RID: 92887 RVA: 0x0034C639 File Offset: 0x0034A839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestAcceptRequest);
		}

		// Token: 0x06016AD8 RID: 92888 RVA: 0x0034C647 File Offset: 0x0034A847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestAcceptRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AD9 RID: 92889 RVA: 0x0034C678 File Offset: 0x0034A878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x0034C6B7 File Offset: 0x0034A8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016ADB RID: 92891 RVA: 0x0034C6C4 File Offset: 0x0034A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ADC RID: 92892 RVA: 0x0034C6CD File Offset: 0x0034A8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016ADD RID: 92893 RVA: 0x0034C700 File Offset: 0x0034A900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x0034C73E File Offset: 0x0034A93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestAcceptRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016ADF RID: 92895 RVA: 0x0034C76F File Offset: 0x0034A96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AE0 RID: 92896 RVA: 0x0034C778 File Offset: 0x0034A978
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087F4 RID: 34804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087F5 RID: 34805
		public const int QuestIdFieldNumber = 6;

		// Token: 0x040087F6 RID: 34806
		private int questId_;
	}
}
