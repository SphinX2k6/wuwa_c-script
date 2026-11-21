using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000605 RID: 1541
	[NetMessage(EMessageId.FollowTrackResponse)]
	public sealed class FollowTrackResponse : IMessage<FollowTrackResponse>, IMessage, IEquatable<FollowTrackResponse>, IDeepCloneable<FollowTrackResponse>, IBufferMessage
	{
		// Token: 0x06008EC8 RID: 36552 RVA: 0x0015A4D1 File Offset: 0x001586D1
		[NullableContext(1)]
		public static FollowTrackResponse Create()
		{
			return new FollowTrackResponse();
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x0015A4D8 File Offset: 0x001586D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x0015A4DB File Offset: 0x001586DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowTrackResponse.Descriptor;
			}
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0015A4E2 File Offset: 0x001586E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse()
		{
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0015A4EA File Offset: 0x001586EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse(FollowTrackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x0015A50F File Offset: 0x0015870F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse Clone()
		{
			return new FollowTrackResponse(this);
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06008ECE RID: 36558 RVA: 0x0015A517 File Offset: 0x00158717
		// (set) Token: 0x06008ECF RID: 36559 RVA: 0x0015A51F File Offset: 0x0015871F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x0015A528 File Offset: 0x00158728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowTrackResponse);
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x0015A536 File Offset: 0x00158736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowTrackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x0015A564 File Offset: 0x00158764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0015A5A9 File Offset: 0x001587A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0015A5B6 File Offset: 0x001587B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x0015A5BF File Offset: 0x001587BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x0015A5F4 File Offset: 0x001587F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008ED7 RID: 36567 RVA: 0x0015A632 File Offset: 0x00158832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowTrackResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0015A663 File Offset: 0x00158863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0015A66C File Offset: 0x0015886C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040045CC RID: 17868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045CD RID: 17869
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040045CE RID: 17870
		private ErrorCode errorCode_;
	}
}
