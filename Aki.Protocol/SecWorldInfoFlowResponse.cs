using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F1 RID: 4593
	[NetMessage(EMessageId.SecWorldInfoFlowResponse)]
	public sealed class SecWorldInfoFlowResponse : IMessage<SecWorldInfoFlowResponse>, IMessage, IEquatable<SecWorldInfoFlowResponse>, IDeepCloneable<SecWorldInfoFlowResponse>, IBufferMessage
	{
		// Token: 0x060188B3 RID: 100531 RVA: 0x003943BA File Offset: 0x003925BA
		[NullableContext(1)]
		public static SecWorldInfoFlowResponse Create()
		{
			return new SecWorldInfoFlowResponse();
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x060188B4 RID: 100532 RVA: 0x003943C1 File Offset: 0x003925C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x060188B5 RID: 100533 RVA: 0x003943C4 File Offset: 0x003925C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldInfoFlowResponse.Descriptor;
			}
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x003943CB File Offset: 0x003925CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse()
		{
		}

		// Token: 0x060188B7 RID: 100535 RVA: 0x003943D4 File Offset: 0x003925D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse(SecWorldInfoFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188B8 RID: 100536 RVA: 0x00394420 File Offset: 0x00392620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowResponse Clone()
		{
			return new SecWorldInfoFlowResponse(this);
		}

		// Token: 0x170052E4 RID: 21220
		// (get) Token: 0x060188B9 RID: 100537 RVA: 0x00394428 File Offset: 0x00392628
		// (set) Token: 0x060188BA RID: 100538 RVA: 0x00394430 File Offset: 0x00392630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x060188BB RID: 100539 RVA: 0x00394439 File Offset: 0x00392639
		// (set) Token: 0x060188BC RID: 100540 RVA: 0x00394441 File Offset: 0x00392641
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

		// Token: 0x060188BD RID: 100541 RVA: 0x0039444A File Offset: 0x0039264A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldInfoFlowResponse);
		}

		// Token: 0x060188BE RID: 100542 RVA: 0x00394458 File Offset: 0x00392658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldInfoFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188BF RID: 100543 RVA: 0x003944A8 File Offset: 0x003926A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
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

		// Token: 0x060188C0 RID: 100544 RVA: 0x003944FD File Offset: 0x003926FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188C1 RID: 100545 RVA: 0x0039450A File Offset: 0x0039270A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188C2 RID: 100546 RVA: 0x00394514 File Offset: 0x00392714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LogId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188C3 RID: 100547 RVA: 0x00394570 File Offset: 0x00392770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
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

		// Token: 0x060188C4 RID: 100548 RVA: 0x003945C8 File Offset: 0x003927C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldInfoFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
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

		// Token: 0x060188C5 RID: 100549 RVA: 0x00394630 File Offset: 0x00392830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188C6 RID: 100550 RVA: 0x0039463C File Offset: 0x0039283C
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
					if (num != 66U)
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
					this.LogId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040091FB RID: 37371
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091FC RID: 37372
		public const int LogIdFieldNumber = 5;

		// Token: 0x040091FD RID: 37373
		private long logId_;

		// Token: 0x040091FE RID: 37374
		public const int ErrorFieldNumber = 8;

		// Token: 0x040091FF RID: 37375
		private DErrorResult error_;
	}
}
