using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B9 RID: 2489
	[NetMessage(EMessageId.MatchConfirmResponse)]
	public sealed class MatchConfirmResponse : IMessage<MatchConfirmResponse>, IMessage, IEquatable<MatchConfirmResponse>, IDeepCloneable<MatchConfirmResponse>, IBufferMessage
	{
		// Token: 0x0600DA5D RID: 55901 RVA: 0x00200EA9 File Offset: 0x001FF0A9
		[NullableContext(1)]
		public static MatchConfirmResponse Create()
		{
			return new MatchConfirmResponse();
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600DA5E RID: 55902 RVA: 0x00200EB0 File Offset: 0x001FF0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600DA5F RID: 55903 RVA: 0x00200EB3 File Offset: 0x001FF0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmResponse.Descriptor;
			}
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x00200EBA File Offset: 0x001FF0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse()
		{
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x00200EC2 File Offset: 0x001FF0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse(MatchConfirmResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA62 RID: 55906 RVA: 0x00200EE7 File Offset: 0x001FF0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse Clone()
		{
			return new MatchConfirmResponse(this);
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600DA63 RID: 55907 RVA: 0x00200EEF File Offset: 0x001FF0EF
		// (set) Token: 0x0600DA64 RID: 55908 RVA: 0x00200EF7 File Offset: 0x001FF0F7
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

		// Token: 0x0600DA65 RID: 55909 RVA: 0x00200F00 File Offset: 0x001FF100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmResponse);
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x00200F0E File Offset: 0x001FF10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA67 RID: 55911 RVA: 0x00200F3C File Offset: 0x001FF13C
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

		// Token: 0x0600DA68 RID: 55912 RVA: 0x00200F81 File Offset: 0x001FF181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA69 RID: 55913 RVA: 0x00200F8E File Offset: 0x001FF18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA6A RID: 55914 RVA: 0x00200F97 File Offset: 0x001FF197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA6B RID: 55915 RVA: 0x00200FCC File Offset: 0x001FF1CC
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

		// Token: 0x0600DA6C RID: 55916 RVA: 0x0020100A File Offset: 0x001FF20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmResponse other)
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

		// Token: 0x0600DA6D RID: 55917 RVA: 0x0020103B File Offset: 0x001FF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA6E RID: 55918 RVA: 0x00201044 File Offset: 0x001FF244
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005AAF RID: 23215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB0 RID: 23216
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005AB1 RID: 23217
		private ErrorCode errorCode_;
	}
}
