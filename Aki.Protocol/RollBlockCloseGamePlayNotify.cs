using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001110 RID: 4368
	[NetMessage(EMessageId.RollBlockCloseGamePlayNotify)]
	public sealed class RollBlockCloseGamePlayNotify : IMessage<RollBlockCloseGamePlayNotify>, IMessage, IEquatable<RollBlockCloseGamePlayNotify>, IDeepCloneable<RollBlockCloseGamePlayNotify>, IBufferMessage
	{
		// Token: 0x06017587 RID: 95623 RVA: 0x00365870 File Offset: 0x00363A70
		[NullableContext(1)]
		public static RollBlockCloseGamePlayNotify Create()
		{
			return new RollBlockCloseGamePlayNotify();
		}

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x06017588 RID: 95624 RVA: 0x00365877 File Offset: 0x00363A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06017589 RID: 95625 RVA: 0x0036587A File Offset: 0x00363A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockCloseGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x0601758A RID: 95626 RVA: 0x00365881 File Offset: 0x00363A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify()
		{
		}

		// Token: 0x0601758B RID: 95627 RVA: 0x00365889 File Offset: 0x00363A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify(RollBlockCloseGamePlayNotify other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601758C RID: 95628 RVA: 0x003658AE File Offset: 0x00363AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify Clone()
		{
			return new RollBlockCloseGamePlayNotify(this);
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x0601758D RID: 95629 RVA: 0x003658B6 File Offset: 0x00363AB6
		// (set) Token: 0x0601758E RID: 95630 RVA: 0x003658BE File Offset: 0x00363ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601758F RID: 95631 RVA: 0x003658C7 File Offset: 0x00363AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockCloseGamePlayNotify);
		}

		// Token: 0x06017590 RID: 95632 RVA: 0x003658D5 File Offset: 0x00363AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockCloseGamePlayNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017591 RID: 95633 RVA: 0x00365904 File Offset: 0x00363B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017592 RID: 95634 RVA: 0x00365943 File Offset: 0x00363B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017593 RID: 95635 RVA: 0x00365950 File Offset: 0x00363B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017594 RID: 95636 RVA: 0x00365959 File Offset: 0x00363B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017595 RID: 95637 RVA: 0x0036598C File Offset: 0x00363B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017596 RID: 95638 RVA: 0x003659CA File Offset: 0x00363BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockCloseGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017597 RID: 95639 RVA: 0x003659FB File Offset: 0x00363BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017598 RID: 95640 RVA: 0x00365A04 File Offset: 0x00363C04
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B7B RID: 35707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B7C RID: 35708
		public const int IncIdFieldNumber = 11;

		// Token: 0x04008B7D RID: 35709
		private int incId_;
	}
}
