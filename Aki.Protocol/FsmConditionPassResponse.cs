using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000669 RID: 1641
	[NetMessage(EMessageId.FsmConditionPassResponse)]
	public sealed class FsmConditionPassResponse : IMessage<FsmConditionPassResponse>, IMessage, IEquatable<FsmConditionPassResponse>, IDeepCloneable<FsmConditionPassResponse>, IBufferMessage
	{
		// Token: 0x06009691 RID: 38545 RVA: 0x0016B383 File Offset: 0x00169583
		[NullableContext(1)]
		public static FsmConditionPassResponse Create()
		{
			return new FsmConditionPassResponse();
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06009692 RID: 38546 RVA: 0x0016B38A File Offset: 0x0016958A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x0016B38D File Offset: 0x0016958D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassResponse.Descriptor;
			}
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x0016B394 File Offset: 0x00169594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse()
		{
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x0016B39C File Offset: 0x0016959C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse(FsmConditionPassResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009696 RID: 38550 RVA: 0x0016B3E8 File Offset: 0x001695E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassResponse Clone()
		{
			return new FsmConditionPassResponse(this);
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06009697 RID: 38551 RVA: 0x0016B3F0 File Offset: 0x001695F0
		// (set) Token: 0x06009698 RID: 38552 RVA: 0x0016B3F8 File Offset: 0x001695F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x0016B401 File Offset: 0x00169601
		// (set) Token: 0x0600969A RID: 38554 RVA: 0x0016B409 File Offset: 0x00169609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x0016B412 File Offset: 0x00169612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassResponse);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x0016B420 File Offset: 0x00169620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x0016B470 File Offset: 0x00169670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0016B4C5 File Offset: 0x001696C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x0016B4D2 File Offset: 0x001696D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0016B4DC File Offset: 0x001696DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FsmId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0016B538 File Offset: 0x00169738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x0016B590 File Offset: 0x00169790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmConditionPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x0016B5F8 File Offset: 0x001697F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x0016B604 File Offset: 0x00169804
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
				if (num != 40U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040047BD RID: 18365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047BE RID: 18366
		public const int FsmIdFieldNumber = 5;

		// Token: 0x040047BF RID: 18367
		private int fsmId_;

		// Token: 0x040047C0 RID: 18368
		public const int ErrorFieldNumber = 9;

		// Token: 0x040047C1 RID: 18369
		private DErrorResult error_;
	}
}
