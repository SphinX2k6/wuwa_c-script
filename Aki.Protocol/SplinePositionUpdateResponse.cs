using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001271 RID: 4721
	[NetMessage(EMessageId.SplinePositionUpdateResponse)]
	public sealed class SplinePositionUpdateResponse : IMessage<SplinePositionUpdateResponse>, IMessage, IEquatable<SplinePositionUpdateResponse>, IDeepCloneable<SplinePositionUpdateResponse>, IBufferMessage
	{
		// Token: 0x06019264 RID: 103012 RVA: 0x003A8978 File Offset: 0x003A6B78
		[NullableContext(1)]
		public static SplinePositionUpdateResponse Create()
		{
			return new SplinePositionUpdateResponse();
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x06019265 RID: 103013 RVA: 0x003A897F File Offset: 0x003A6B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x06019266 RID: 103014 RVA: 0x003A8982 File Offset: 0x003A6B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06019267 RID: 103015 RVA: 0x003A8989 File Offset: 0x003A6B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse()
		{
		}

		// Token: 0x06019268 RID: 103016 RVA: 0x003A8991 File Offset: 0x003A6B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse(SplinePositionUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019269 RID: 103017 RVA: 0x003A89B6 File Offset: 0x003A6BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateResponse Clone()
		{
			return new SplinePositionUpdateResponse(this);
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x0601926A RID: 103018 RVA: 0x003A89BE File Offset: 0x003A6BBE
		// (set) Token: 0x0601926B RID: 103019 RVA: 0x003A89C6 File Offset: 0x003A6BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601926C RID: 103020 RVA: 0x003A89CF File Offset: 0x003A6BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionUpdateResponse);
		}

		// Token: 0x0601926D RID: 103021 RVA: 0x003A89DD File Offset: 0x003A6BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601926E RID: 103022 RVA: 0x003A8A0C File Offset: 0x003A6C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601926F RID: 103023 RVA: 0x003A8A51 File Offset: 0x003A6C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019270 RID: 103024 RVA: 0x003A8A5E File Offset: 0x003A6C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019271 RID: 103025 RVA: 0x003A8A67 File Offset: 0x003A6C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019272 RID: 103026 RVA: 0x003A8A9C File Offset: 0x003A6C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019273 RID: 103027 RVA: 0x003A8ADA File Offset: 0x003A6CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplinePositionUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019274 RID: 103028 RVA: 0x003A8B0B File Offset: 0x003A6D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019275 RID: 103029 RVA: 0x003A8B14 File Offset: 0x003A6D14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009409 RID: 37897
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400940A RID: 37898
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x0400940B RID: 37899
		private ErrorCode errCode_;
	}
}
