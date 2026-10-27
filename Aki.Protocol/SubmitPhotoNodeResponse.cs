using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A6 RID: 4774
	[NetMessage(EMessageId.SubmitPhotoNodeResponse)]
	public sealed class SubmitPhotoNodeResponse : IMessage<SubmitPhotoNodeResponse>, IMessage, IEquatable<SubmitPhotoNodeResponse>, IDeepCloneable<SubmitPhotoNodeResponse>, IBufferMessage
	{
		// Token: 0x0601968C RID: 104076 RVA: 0x003B17F1 File Offset: 0x003AF9F1
		[NullableContext(1)]
		public static SubmitPhotoNodeResponse Create()
		{
			return new SubmitPhotoNodeResponse();
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x0601968D RID: 104077 RVA: 0x003B17F8 File Offset: 0x003AF9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x0601968E RID: 104078 RVA: 0x003B17FB File Offset: 0x003AF9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitPhotoNodeResponse.Descriptor;
			}
		}

		// Token: 0x0601968F RID: 104079 RVA: 0x003B1802 File Offset: 0x003AFA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse()
		{
		}

		// Token: 0x06019690 RID: 104080 RVA: 0x003B180A File Offset: 0x003AFA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse(SubmitPhotoNodeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019691 RID: 104081 RVA: 0x003B182F File Offset: 0x003AFA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse Clone()
		{
			return new SubmitPhotoNodeResponse(this);
		}

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x06019692 RID: 104082 RVA: 0x003B1837 File Offset: 0x003AFA37
		// (set) Token: 0x06019693 RID: 104083 RVA: 0x003B183F File Offset: 0x003AFA3F
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

		// Token: 0x06019694 RID: 104084 RVA: 0x003B1848 File Offset: 0x003AFA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitPhotoNodeResponse);
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x003B1856 File Offset: 0x003AFA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitPhotoNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019696 RID: 104086 RVA: 0x003B1884 File Offset: 0x003AFA84
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

		// Token: 0x06019697 RID: 104087 RVA: 0x003B18C9 File Offset: 0x003AFAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019698 RID: 104088 RVA: 0x003B18D6 File Offset: 0x003AFAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019699 RID: 104089 RVA: 0x003B18DF File Offset: 0x003AFADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601969A RID: 104090 RVA: 0x003B1914 File Offset: 0x003AFB14
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

		// Token: 0x0601969B RID: 104091 RVA: 0x003B1952 File Offset: 0x003AFB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitPhotoNodeResponse other)
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

		// Token: 0x0601969C RID: 104092 RVA: 0x003B1983 File Offset: 0x003AFB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601969D RID: 104093 RVA: 0x003B198C File Offset: 0x003AFB8C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009535 RID: 38197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009536 RID: 38198
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04009537 RID: 38199
		private ErrorCode errorId_;
	}
}
