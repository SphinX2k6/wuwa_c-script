using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012ED RID: 4845
	[NetMessage(EMessageId.SpringSignDrawRewardResponse)]
	public sealed class SpringSignDrawRewardResponse : IMessage<SpringSignDrawRewardResponse>, IMessage, IEquatable<SpringSignDrawRewardResponse>, IDeepCloneable<SpringSignDrawRewardResponse>, IBufferMessage
	{
		// Token: 0x06019DAA RID: 105898 RVA: 0x003C5A35 File Offset: 0x003C3C35
		[NullableContext(1)]
		public static SpringSignDrawRewardResponse Create()
		{
			return new SpringSignDrawRewardResponse();
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x06019DAB RID: 105899 RVA: 0x003C5A3C File Offset: 0x003C3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x06019DAC RID: 105900 RVA: 0x003C5A3F File Offset: 0x003C3C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019DAD RID: 105901 RVA: 0x003C5A46 File Offset: 0x003C3C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse()
		{
		}

		// Token: 0x06019DAE RID: 105902 RVA: 0x003C5A4E File Offset: 0x003C3C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse(SpringSignDrawRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DAF RID: 105903 RVA: 0x003C5A73 File Offset: 0x003C3C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardResponse Clone()
		{
			return new SpringSignDrawRewardResponse(this);
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x06019DB0 RID: 105904 RVA: 0x003C5A7B File Offset: 0x003C3C7B
		// (set) Token: 0x06019DB1 RID: 105905 RVA: 0x003C5A83 File Offset: 0x003C3C83
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

		// Token: 0x06019DB2 RID: 105906 RVA: 0x003C5A8C File Offset: 0x003C3C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRewardResponse);
		}

		// Token: 0x06019DB3 RID: 105907 RVA: 0x003C5A9A File Offset: 0x003C3C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DB4 RID: 105908 RVA: 0x003C5AC8 File Offset: 0x003C3CC8
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

		// Token: 0x06019DB5 RID: 105909 RVA: 0x003C5B0D File Offset: 0x003C3D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DB6 RID: 105910 RVA: 0x003C5B1A File Offset: 0x003C3D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DB7 RID: 105911 RVA: 0x003C5B23 File Offset: 0x003C3D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DB8 RID: 105912 RVA: 0x003C5B54 File Offset: 0x003C3D54
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

		// Token: 0x06019DB9 RID: 105913 RVA: 0x003C5B92 File Offset: 0x003C3D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRewardResponse other)
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

		// Token: 0x06019DBA RID: 105914 RVA: 0x003C5BC3 File Offset: 0x003C3DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DBB RID: 105915 RVA: 0x003C5BCC File Offset: 0x003C3DCC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400988F RID: 39055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009890 RID: 39056
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009891 RID: 39057
		private ErrorCode errorCode_;
	}
}
