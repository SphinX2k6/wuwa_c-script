using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CF RID: 2511
	[NetMessage(EMessageId.MixDrinkTopicSelectRequest)]
	public sealed class MixDrinkTopicSelectRequest : IMessage<MixDrinkTopicSelectRequest>, IMessage, IEquatable<MixDrinkTopicSelectRequest>, IDeepCloneable<MixDrinkTopicSelectRequest>, IBufferMessage
	{
		// Token: 0x0600DC6F RID: 56431 RVA: 0x00205D91 File Offset: 0x00203F91
		[NullableContext(1)]
		public static MixDrinkTopicSelectRequest Create()
		{
			return new MixDrinkTopicSelectRequest();
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x00205D98 File Offset: 0x00203F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x00205D9B File Offset: 0x00203F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkTopicSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x00205DA2 File Offset: 0x00203FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest()
		{
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x00205DAA File Offset: 0x00203FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest(MixDrinkTopicSelectRequest other) : this()
		{
			this.topicId_ = other.topicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x00205DCF File Offset: 0x00203FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest Clone()
		{
			return new MixDrinkTopicSelectRequest(this);
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600DC75 RID: 56437 RVA: 0x00205DD7 File Offset: 0x00203FD7
		// (set) Token: 0x0600DC76 RID: 56438 RVA: 0x00205DDF File Offset: 0x00203FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TopicId
		{
			get
			{
				return this.topicId_;
			}
			set
			{
				this.topicId_ = value;
			}
		}

		// Token: 0x0600DC77 RID: 56439 RVA: 0x00205DE8 File Offset: 0x00203FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkTopicSelectRequest);
		}

		// Token: 0x0600DC78 RID: 56440 RVA: 0x00205DF6 File Offset: 0x00203FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkTopicSelectRequest other)
		{
			return other != null && (other == this || (this.TopicId == other.TopicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x00205E24 File Offset: 0x00204024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TopicId != 0)
			{
				num ^= this.TopicId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00205E63 File Offset: 0x00204063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00205E70 File Offset: 0x00204070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00205E79 File Offset: 0x00204079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TopicId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TopicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x00205EAC File Offset: 0x002040AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TopicId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TopicId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC7E RID: 56446 RVA: 0x00205EEA File Offset: 0x002040EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkTopicSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TopicId != 0)
			{
				this.TopicId = other.TopicId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x00205F1B File Offset: 0x0020411B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC80 RID: 56448 RVA: 0x00205F24 File Offset: 0x00204124
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TopicId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005BA1 RID: 23457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BA2 RID: 23458
		public const int TopicIdFieldNumber = 13;

		// Token: 0x04005BA3 RID: 23459
		private int topicId_;
	}
}
