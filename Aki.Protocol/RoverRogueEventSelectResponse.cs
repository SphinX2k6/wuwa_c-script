using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FC RID: 4348
	[NetMessage(EMessageId.RoverRogueEventSelectResponse)]
	public sealed class RoverRogueEventSelectResponse : IMessage<RoverRogueEventSelectResponse>, IMessage, IEquatable<RoverRogueEventSelectResponse>, IDeepCloneable<RoverRogueEventSelectResponse>, IBufferMessage
	{
		// Token: 0x060172F7 RID: 94967 RVA: 0x0035D610 File Offset: 0x0035B810
		[NullableContext(1)]
		public static RoverRogueEventSelectResponse Create()
		{
			return new RoverRogueEventSelectResponse();
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x060172F8 RID: 94968 RVA: 0x0035D617 File Offset: 0x0035B817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x060172F9 RID: 94969 RVA: 0x0035D61A File Offset: 0x0035B81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventSelectResponse.Descriptor;
			}
		}

		// Token: 0x060172FA RID: 94970 RVA: 0x0035D621 File Offset: 0x0035B821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse()
		{
		}

		// Token: 0x060172FB RID: 94971 RVA: 0x0035D629 File Offset: 0x0035B829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse(RoverRogueEventSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172FC RID: 94972 RVA: 0x0035D64E File Offset: 0x0035B84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventSelectResponse Clone()
		{
			return new RoverRogueEventSelectResponse(this);
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x060172FD RID: 94973 RVA: 0x0035D656 File Offset: 0x0035B856
		// (set) Token: 0x060172FE RID: 94974 RVA: 0x0035D65E File Offset: 0x0035B85E
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

		// Token: 0x060172FF RID: 94975 RVA: 0x0035D667 File Offset: 0x0035B867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventSelectResponse);
		}

		// Token: 0x06017300 RID: 94976 RVA: 0x0035D675 File Offset: 0x0035B875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017301 RID: 94977 RVA: 0x0035D6A4 File Offset: 0x0035B8A4
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

		// Token: 0x06017302 RID: 94978 RVA: 0x0035D6E9 File Offset: 0x0035B8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017303 RID: 94979 RVA: 0x0035D6F6 File Offset: 0x0035B8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017304 RID: 94980 RVA: 0x0035D6FF File Offset: 0x0035B8FF
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

		// Token: 0x06017305 RID: 94981 RVA: 0x0035D734 File Offset: 0x0035B934
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

		// Token: 0x06017306 RID: 94982 RVA: 0x0035D772 File Offset: 0x0035B972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventSelectResponse other)
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

		// Token: 0x06017307 RID: 94983 RVA: 0x0035D7A3 File Offset: 0x0035B9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017308 RID: 94984 RVA: 0x0035D7AC File Offset: 0x0035B9AC
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

		// Token: 0x040089DF RID: 35295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089E0 RID: 35296
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040089E1 RID: 35297
		private ErrorCode errorCode_;
	}
}
