using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001157 RID: 4439
	[NetMessage(EMessageId.RoverRogueResultRequest)]
	public sealed class RoverRogueResultRequest : IMessage<RoverRogueResultRequest>, IMessage, IEquatable<RoverRogueResultRequest>, IDeepCloneable<RoverRogueResultRequest>, IBufferMessage
	{
		// Token: 0x06017B8F RID: 97167 RVA: 0x00374414 File Offset: 0x00372614
		[NullableContext(1)]
		public static RoverRogueResultRequest Create()
		{
			return new RoverRogueResultRequest();
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06017B90 RID: 97168 RVA: 0x0037441B File Offset: 0x0037261B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06017B91 RID: 97169 RVA: 0x0037441E File Offset: 0x0037261E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultRequest.Descriptor;
			}
		}

		// Token: 0x06017B92 RID: 97170 RVA: 0x00374425 File Offset: 0x00372625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest()
		{
		}

		// Token: 0x06017B93 RID: 97171 RVA: 0x0037442D File Offset: 0x0037262D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest(RoverRogueResultRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B94 RID: 97172 RVA: 0x0037445E File Offset: 0x0037265E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest Clone()
		{
			return new RoverRogueResultRequest(this);
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x06017B95 RID: 97173 RVA: 0x00374466 File Offset: 0x00372666
		// (set) Token: 0x06017B96 RID: 97174 RVA: 0x0037446E File Offset: 0x0037266E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06017B97 RID: 97175 RVA: 0x00374477 File Offset: 0x00372677
		// (set) Token: 0x06017B98 RID: 97176 RVA: 0x0037447F File Offset: 0x0037267F
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

		// Token: 0x06017B99 RID: 97177 RVA: 0x00374488 File Offset: 0x00372688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultRequest);
		}

		// Token: 0x06017B9A RID: 97178 RVA: 0x00374496 File Offset: 0x00372696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B9B RID: 97179 RVA: 0x003744D4 File Offset: 0x003726D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B9C RID: 97180 RVA: 0x0037452C File Offset: 0x0037272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B9D RID: 97181 RVA: 0x00374539 File Offset: 0x00372739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B9E RID: 97182 RVA: 0x00374544 File Offset: 0x00372744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B9F RID: 97183 RVA: 0x003745A0 File Offset: 0x003727A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017BA0 RID: 97184 RVA: 0x003745F8 File Offset: 0x003727F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017BA1 RID: 97185 RVA: 0x00374648 File Offset: 0x00372848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BA2 RID: 97186 RVA: 0x00374654 File Offset: 0x00372854
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D9E RID: 36254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D9F RID: 36255
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04008DA0 RID: 36256
		private int activityId_;

		// Token: 0x04008DA1 RID: 36257
		public const int InstIdFieldNumber = 2;

		// Token: 0x04008DA2 RID: 36258
		private int instId_;
	}
}
