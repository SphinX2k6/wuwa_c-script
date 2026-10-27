using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000137 RID: 311
	[NetMessage(EMessageId.AvoidBlockSubmitOverNodeResponse)]
	public sealed class AvoidBlockSubmitOverNodeResponse : IMessage<AvoidBlockSubmitOverNodeResponse>, IMessage, IEquatable<AvoidBlockSubmitOverNodeResponse>, IDeepCloneable<AvoidBlockSubmitOverNodeResponse>, IBufferMessage
	{
		// Token: 0x060028C5 RID: 10437 RVA: 0x0006B547 File Offset: 0x00069747
		[NullableContext(1)]
		public static AvoidBlockSubmitOverNodeResponse Create()
		{
			return new AvoidBlockSubmitOverNodeResponse();
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x0006B54E File Offset: 0x0006974E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0006B551 File Offset: 0x00069751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSubmitOverNodeResponse.Descriptor;
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0006B558 File Offset: 0x00069758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse()
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0006B560 File Offset: 0x00069760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse(AvoidBlockSubmitOverNodeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0006B585 File Offset: 0x00069785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeResponse Clone()
		{
			return new AvoidBlockSubmitOverNodeResponse(this);
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x0006B58D File Offset: 0x0006978D
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x0006B595 File Offset: 0x00069795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0006B59E File Offset: 0x0006979E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSubmitOverNodeResponse);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0006B5AC File Offset: 0x000697AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSubmitOverNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0006B5DC File Offset: 0x000697DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0006B621 File Offset: 0x00069821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0006B62E File Offset: 0x0006982E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0006B637 File Offset: 0x00069837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0006B66C File Offset: 0x0006986C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0006B6AA File Offset: 0x000698AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockSubmitOverNodeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0006B6DB File Offset: 0x000698DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0006B6E4 File Offset: 0x000698E4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040026C5 RID: 9925
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C6 RID: 9926
		public const int ErrorIdFieldNumber = 14;

		// Token: 0x040026C7 RID: 9927
		private ErrorCode errorId_;
	}
}
