using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AD RID: 4781
	[NetMessage(EMessageId.Summon3Response)]
	public sealed class Summon3Response : IMessage<Summon3Response>, IMessage, IEquatable<Summon3Response>, IDeepCloneable<Summon3Response>, IBufferMessage
	{
		// Token: 0x06019718 RID: 104216 RVA: 0x003B2AEB File Offset: 0x003B0CEB
		[NullableContext(1)]
		public static Summon3Response Create()
		{
			return new Summon3Response();
		}

		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x06019719 RID: 104217 RVA: 0x003B2AF2 File Offset: 0x003B0CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x0601971A RID: 104218 RVA: 0x003B2AF5 File Offset: 0x003B0CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon3Response.Descriptor;
			}
		}

		// Token: 0x0601971B RID: 104219 RVA: 0x003B2AFC File Offset: 0x003B0CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response()
		{
		}

		// Token: 0x0601971C RID: 104220 RVA: 0x003B2B04 File Offset: 0x003B0D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response(Summon3Response other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601971D RID: 104221 RVA: 0x003B2B29 File Offset: 0x003B0D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Response Clone()
		{
			return new Summon3Response(this);
		}

		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x0601971E RID: 104222 RVA: 0x003B2B31 File Offset: 0x003B0D31
		// (set) Token: 0x0601971F RID: 104223 RVA: 0x003B2B39 File Offset: 0x003B0D39
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

		// Token: 0x06019720 RID: 104224 RVA: 0x003B2B42 File Offset: 0x003B0D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon3Response);
		}

		// Token: 0x06019721 RID: 104225 RVA: 0x003B2B50 File Offset: 0x003B0D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon3Response other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019722 RID: 104226 RVA: 0x003B2B80 File Offset: 0x003B0D80
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

		// Token: 0x06019723 RID: 104227 RVA: 0x003B2BC5 File Offset: 0x003B0DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019724 RID: 104228 RVA: 0x003B2BD2 File Offset: 0x003B0DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019725 RID: 104229 RVA: 0x003B2BDB File Offset: 0x003B0DDB
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

		// Token: 0x06019726 RID: 104230 RVA: 0x003B2C10 File Offset: 0x003B0E10
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

		// Token: 0x06019727 RID: 104231 RVA: 0x003B2C4E File Offset: 0x003B0E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon3Response other)
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

		// Token: 0x06019728 RID: 104232 RVA: 0x003B2C7F File Offset: 0x003B0E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019729 RID: 104233 RVA: 0x003B2C88 File Offset: 0x003B0E88
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

		// Token: 0x04009558 RID: 38232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009559 RID: 38233
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400955A RID: 38234
		private ErrorCode errorCode_;
	}
}
