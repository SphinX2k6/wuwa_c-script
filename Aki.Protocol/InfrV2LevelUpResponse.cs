using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FD RID: 2045
	[NetMessage(EMessageId.InfrV2LevelUpResponse)]
	public sealed class InfrV2LevelUpResponse : IMessage<InfrV2LevelUpResponse>, IMessage, IEquatable<InfrV2LevelUpResponse>, IDeepCloneable<InfrV2LevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600B72A RID: 46890 RVA: 0x001B4DAE File Offset: 0x001B2FAE
		[NullableContext(1)]
		public static InfrV2LevelUpResponse Create()
		{
			return new InfrV2LevelUpResponse();
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600B72B RID: 46891 RVA: 0x001B4DB5 File Offset: 0x001B2FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x0600B72C RID: 46892 RVA: 0x001B4DB8 File Offset: 0x001B2FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2LevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x001B4DBF File Offset: 0x001B2FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse()
		{
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x001B4DC7 File Offset: 0x001B2FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse(InfrV2LevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x001B4DEC File Offset: 0x001B2FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpResponse Clone()
		{
			return new InfrV2LevelUpResponse(this);
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x0600B730 RID: 46896 RVA: 0x001B4DF4 File Offset: 0x001B2FF4
		// (set) Token: 0x0600B731 RID: 46897 RVA: 0x001B4DFC File Offset: 0x001B2FFC
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

		// Token: 0x0600B732 RID: 46898 RVA: 0x001B4E05 File Offset: 0x001B3005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2LevelUpResponse);
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x001B4E13 File Offset: 0x001B3013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2LevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x001B4E44 File Offset: 0x001B3044
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

		// Token: 0x0600B735 RID: 46901 RVA: 0x001B4E89 File Offset: 0x001B3089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x001B4E96 File Offset: 0x001B3096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x001B4E9F File Offset: 0x001B309F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x001B4ED4 File Offset: 0x001B30D4
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

		// Token: 0x0600B739 RID: 46905 RVA: 0x001B4F12 File Offset: 0x001B3112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2LevelUpResponse other)
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

		// Token: 0x0600B73A RID: 46906 RVA: 0x001B4F43 File Offset: 0x001B3143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x001B4F4C File Offset: 0x001B314C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050F0 RID: 20720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F1 RID: 20721
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040050F2 RID: 20722
		private ErrorCode errorCode_;
	}
}
