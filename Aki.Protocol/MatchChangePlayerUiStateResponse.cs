using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AF RID: 2479
	[NetMessage(EMessageId.MatchChangePlayerUiStateResponse)]
	public sealed class MatchChangePlayerUiStateResponse : IMessage<MatchChangePlayerUiStateResponse>, IMessage, IEquatable<MatchChangePlayerUiStateResponse>, IDeepCloneable<MatchChangePlayerUiStateResponse>, IBufferMessage
	{
		// Token: 0x0600D99F RID: 55711 RVA: 0x001FF784 File Offset: 0x001FD984
		[NullableContext(1)]
		public static MatchChangePlayerUiStateResponse Create()
		{
			return new MatchChangePlayerUiStateResponse();
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x001FF78B File Offset: 0x001FD98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600D9A1 RID: 55713 RVA: 0x001FF78E File Offset: 0x001FD98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateResponse.Descriptor;
			}
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x001FF795 File Offset: 0x001FD995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse()
		{
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x001FF79D File Offset: 0x001FD99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse(MatchChangePlayerUiStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9A4 RID: 55716 RVA: 0x001FF7C2 File Offset: 0x001FD9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse Clone()
		{
			return new MatchChangePlayerUiStateResponse(this);
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600D9A5 RID: 55717 RVA: 0x001FF7CA File Offset: 0x001FD9CA
		// (set) Token: 0x0600D9A6 RID: 55718 RVA: 0x001FF7D2 File Offset: 0x001FD9D2
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

		// Token: 0x0600D9A7 RID: 55719 RVA: 0x001FF7DB File Offset: 0x001FD9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateResponse);
		}

		// Token: 0x0600D9A8 RID: 55720 RVA: 0x001FF7E9 File Offset: 0x001FD9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x001FF818 File Offset: 0x001FDA18
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

		// Token: 0x0600D9AA RID: 55722 RVA: 0x001FF85D File Offset: 0x001FDA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x001FF86A File Offset: 0x001FDA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x001FF873 File Offset: 0x001FDA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x001FF8A8 File Offset: 0x001FDAA8
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

		// Token: 0x0600D9AE RID: 55726 RVA: 0x001FF8E6 File Offset: 0x001FDAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangePlayerUiStateResponse other)
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

		// Token: 0x0600D9AF RID: 55727 RVA: 0x001FF917 File Offset: 0x001FDB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x001FF920 File Offset: 0x001FDB20
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A82 RID: 23170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A83 RID: 23171
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005A84 RID: 23172
		private ErrorCode errorCode_;
	}
}
