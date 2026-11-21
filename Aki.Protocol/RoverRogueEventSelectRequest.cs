using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001135 RID: 4405
	[NetMessage(EMessageId.RoverRogueEventSelectRequest)]
	public sealed class RoverRogueEventSelectRequest : IMessage<RoverRogueEventSelectRequest>, IMessage, IEquatable<RoverRogueEventSelectRequest>, IDeepCloneable<RoverRogueEventSelectRequest>, IBufferMessage
	{
		// Token: 0x06017884 RID: 96388 RVA: 0x0036C6CB File Offset: 0x0036A8CB
		[NullableContext(1)]
		public static RoverRogueEventSelectRequest Create()
		{
			return new RoverRogueEventSelectRequest();
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06017885 RID: 96389 RVA: 0x0036C6D2 File Offset: 0x0036A8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06017886 RID: 96390 RVA: 0x0036C6D5 File Offset: 0x0036A8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventSelectRequest.Descriptor;
			}
		}

		// Token: 0x06017887 RID: 96391 RVA: 0x0036C6DC File Offset: 0x0036A8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest()
		{
		}

		// Token: 0x06017888 RID: 96392 RVA: 0x0036C6E4 File Offset: 0x0036A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest(RoverRogueEventSelectRequest other) : this()
		{
			this.eventIncId_ = other.eventIncId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017889 RID: 96393 RVA: 0x0036C715 File Offset: 0x0036A915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectRequest Clone()
		{
			return new RoverRogueEventSelectRequest(this);
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x0601788A RID: 96394 RVA: 0x0036C71D File Offset: 0x0036A91D
		// (set) Token: 0x0601788B RID: 96395 RVA: 0x0036C725 File Offset: 0x0036A925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventIncId
		{
			get
			{
				return this.eventIncId_;
			}
			set
			{
				this.eventIncId_ = value;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x0601788C RID: 96396 RVA: 0x0036C72E File Offset: 0x0036A92E
		// (set) Token: 0x0601788D RID: 96397 RVA: 0x0036C736 File Offset: 0x0036A936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x0601788E RID: 96398 RVA: 0x0036C73F File Offset: 0x0036A93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventSelectRequest);
		}

		// Token: 0x0601788F RID: 96399 RVA: 0x0036C74D File Offset: 0x0036A94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventSelectRequest other)
		{
			return other != null && (other == this || (this.EventIncId == other.EventIncId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017890 RID: 96400 RVA: 0x0036C78C File Offset: 0x0036A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventIncId != 0)
			{
				num ^= this.EventIncId.GetHashCode();
			}
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017891 RID: 96401 RVA: 0x0036C7E4 File Offset: 0x0036A9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017892 RID: 96402 RVA: 0x0036C7F1 File Offset: 0x0036A9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017893 RID: 96403 RVA: 0x0036C7FC File Offset: 0x0036A9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.EventIncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EventIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017894 RID: 96404 RVA: 0x0036C858 File Offset: 0x0036AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventIncId);
			}
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017895 RID: 96405 RVA: 0x0036C8B0 File Offset: 0x0036AAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventIncId != 0)
			{
				this.EventIncId = other.EventIncId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017896 RID: 96406 RVA: 0x0036C900 File Offset: 0x0036AB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017897 RID: 96407 RVA: 0x0036C90C File Offset: 0x0036AB0C
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventIncId = input.ReadInt32();
					}
				}
				else
				{
					this.ChoiceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C6D RID: 35949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C6E RID: 35950
		public const int EventIncIdFieldNumber = 10;

		// Token: 0x04008C6F RID: 35951
		private int eventIncId_;

		// Token: 0x04008C70 RID: 35952
		public const int ChoiceIdFieldNumber = 7;

		// Token: 0x04008C71 RID: 35953
		private int choiceId_;
	}
}
