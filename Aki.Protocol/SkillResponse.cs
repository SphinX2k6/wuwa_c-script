using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001240 RID: 4672
	[NetMessage(EMessageId.SkillResponse)]
	public sealed class SkillResponse : IMessage<SkillResponse>, IMessage, IEquatable<SkillResponse>, IDeepCloneable<SkillResponse>, IBufferMessage
	{
		// Token: 0x06018E69 RID: 101993 RVA: 0x0039FD66 File Offset: 0x0039DF66
		[NullableContext(1)]
		public static SkillResponse Create()
		{
			return new SkillResponse();
		}

		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x06018E6A RID: 101994 RVA: 0x0039FD6D File Offset: 0x0039DF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x06018E6B RID: 101995 RVA: 0x0039FD70 File Offset: 0x0039DF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillResponse.Descriptor;
			}
		}

		// Token: 0x06018E6C RID: 101996 RVA: 0x0039FD77 File Offset: 0x0039DF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse()
		{
		}

		// Token: 0x06018E6D RID: 101997 RVA: 0x0039FD7F File Offset: 0x0039DF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse(SkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E6E RID: 101998 RVA: 0x0039FDA4 File Offset: 0x0039DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse Clone()
		{
			return new SkillResponse(this);
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x06018E6F RID: 101999 RVA: 0x0039FDAC File Offset: 0x0039DFAC
		// (set) Token: 0x06018E70 RID: 102000 RVA: 0x0039FDB4 File Offset: 0x0039DFB4
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

		// Token: 0x06018E71 RID: 102001 RVA: 0x0039FDBD File Offset: 0x0039DFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillResponse);
		}

		// Token: 0x06018E72 RID: 102002 RVA: 0x0039FDCB File Offset: 0x0039DFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E73 RID: 102003 RVA: 0x0039FDFC File Offset: 0x0039DFFC
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

		// Token: 0x06018E74 RID: 102004 RVA: 0x0039FE41 File Offset: 0x0039E041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E75 RID: 102005 RVA: 0x0039FE4E File Offset: 0x0039E04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E76 RID: 102006 RVA: 0x0039FE57 File Offset: 0x0039E057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E77 RID: 102007 RVA: 0x0039FE8C File Offset: 0x0039E08C
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

		// Token: 0x06018E78 RID: 102008 RVA: 0x0039FECA File Offset: 0x0039E0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillResponse other)
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

		// Token: 0x06018E79 RID: 102009 RVA: 0x0039FEFB File Offset: 0x0039E0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E7A RID: 102010 RVA: 0x0039FF04 File Offset: 0x0039E104
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092E3 RID: 37603
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092E4 RID: 37604
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040092E5 RID: 37605
		private ErrorCode errorCode_;
	}
}
