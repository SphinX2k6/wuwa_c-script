using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A5 RID: 1445
	[NetMessage(EMessageId.FloroRanchPlayEventChoiceRequest)]
	public sealed class FloroRanchPlayEventChoiceRequest : IMessage<FloroRanchPlayEventChoiceRequest>, IMessage, IEquatable<FloroRanchPlayEventChoiceRequest>, IDeepCloneable<FloroRanchPlayEventChoiceRequest>, IBufferMessage
	{
		// Token: 0x06008609 RID: 34313 RVA: 0x0014311D File Offset: 0x0014131D
		[NullableContext(1)]
		public static FloroRanchPlayEventChoiceRequest Create()
		{
			return new FloroRanchPlayEventChoiceRequest();
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600860A RID: 34314 RVA: 0x00143124 File Offset: 0x00141324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x00143127 File Offset: 0x00141327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEventChoiceRequest.Descriptor;
			}
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x0014312E File Offset: 0x0014132E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest()
		{
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x00143138 File Offset: 0x00141338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest(FloroRanchPlayEventChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.eventId_ = other.eventId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x0014318C File Offset: 0x0014138C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest Clone()
		{
			return new FloroRanchPlayEventChoiceRequest(this);
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x00143194 File Offset: 0x00141394
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x0014319C File Offset: 0x0014139C
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

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x001431A5 File Offset: 0x001413A5
		// (set) Token: 0x06008612 RID: 34322 RVA: 0x001431AD File Offset: 0x001413AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06008613 RID: 34323 RVA: 0x001431B6 File Offset: 0x001413B6
		// (set) Token: 0x06008614 RID: 34324 RVA: 0x001431BE File Offset: 0x001413BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x001431C7 File Offset: 0x001413C7
		// (set) Token: 0x06008616 RID: 34326 RVA: 0x001431CF File Offset: 0x001413CF
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

		// Token: 0x06008617 RID: 34327 RVA: 0x001431D8 File Offset: 0x001413D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEventChoiceRequest);
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x001431E8 File Offset: 0x001413E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEventChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.EventId == other.EventId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x00143254 File Offset: 0x00141454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
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

		// Token: 0x0600861A RID: 34330 RVA: 0x001432DE File Offset: 0x001414DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x001432EB File Offset: 0x001414EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600861C RID: 34332 RVA: 0x001432F4 File Offset: 0x001414F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600861D RID: 34333 RVA: 0x00143384 File Offset: 0x00141584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
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

		// Token: 0x0600861E RID: 34334 RVA: 0x0014340C File Offset: 0x0014160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayEventChoiceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x00143484 File Offset: 0x00141684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x00143490 File Offset: 0x00141690
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
						this.ChoiceId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042B6 RID: 17078
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042B7 RID: 17079
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040042B8 RID: 17080
		private int activityId_;

		// Token: 0x040042B9 RID: 17081
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x040042BA RID: 17082
		private int subInsId_;

		// Token: 0x040042BB RID: 17083
		public const int EventIdFieldNumber = 14;

		// Token: 0x040042BC RID: 17084
		private int eventId_;

		// Token: 0x040042BD RID: 17085
		public const int ChoiceIdFieldNumber = 1;

		// Token: 0x040042BE RID: 17086
		private int choiceId_;
	}
}
