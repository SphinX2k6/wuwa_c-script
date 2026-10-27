using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B5 RID: 1461
	[NetMessage(EMessageId.FloroRanchOutRequest)]
	public sealed class FloroRanchOutRequest : IMessage<FloroRanchOutRequest>, IMessage, IEquatable<FloroRanchOutRequest>, IDeepCloneable<FloroRanchOutRequest>, IBufferMessage
	{
		// Token: 0x060086F7 RID: 34551 RVA: 0x0014458F File Offset: 0x0014278F
		[NullableContext(1)]
		public static FloroRanchOutRequest Create()
		{
			return new FloroRanchOutRequest();
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x060086F8 RID: 34552 RVA: 0x00144596 File Offset: 0x00142796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x060086F9 RID: 34553 RVA: 0x00144599 File Offset: 0x00142799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchOutRequest.Descriptor;
			}
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x001445A0 File Offset: 0x001427A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest()
		{
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x001445A8 File Offset: 0x001427A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest(FloroRanchOutRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x001445D9 File Offset: 0x001427D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest Clone()
		{
			return new FloroRanchOutRequest(this);
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x001445E1 File Offset: 0x001427E1
		// (set) Token: 0x060086FE RID: 34558 RVA: 0x001445E9 File Offset: 0x001427E9
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

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x060086FF RID: 34559 RVA: 0x001445F2 File Offset: 0x001427F2
		// (set) Token: 0x06008700 RID: 34560 RVA: 0x001445FA File Offset: 0x001427FA
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

		// Token: 0x06008701 RID: 34561 RVA: 0x00144603 File Offset: 0x00142803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchOutRequest);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00144611 File Offset: 0x00142811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchOutRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x00144650 File Offset: 0x00142850
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x001446A8 File Offset: 0x001428A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x001446B5 File Offset: 0x001428B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x001446C0 File Offset: 0x001428C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x0014471C File Offset: 0x0014291C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x00144774 File Offset: 0x00142974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchOutRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x001447C4 File Offset: 0x001429C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x001447D0 File Offset: 0x001429D0
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
				if (num != 88U)
				{
					if (num != 96U)
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
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400427C RID: 17020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400427D RID: 17021
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x0400427E RID: 17022
		private int activityId_;

		// Token: 0x0400427F RID: 17023
		public const int SubInsIdFieldNumber = 11;

		// Token: 0x04004280 RID: 17024
		private int subInsId_;
	}
}
