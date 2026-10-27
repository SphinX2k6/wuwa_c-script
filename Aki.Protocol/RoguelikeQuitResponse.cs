using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAA RID: 4010
	[NetMessage(EMessageId.RoguelikeQuitResponse)]
	public sealed class RoguelikeQuitResponse : IMessage<RoguelikeQuitResponse>, IMessage, IEquatable<RoguelikeQuitResponse>, IDeepCloneable<RoguelikeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601570F RID: 87823 RVA: 0x0031C9FA File Offset: 0x0031ABFA
		[NullableContext(1)]
		public static RoguelikeQuitResponse Create()
		{
			return new RoguelikeQuitResponse();
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x06015710 RID: 87824 RVA: 0x0031CA01 File Offset: 0x0031AC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x06015711 RID: 87825 RVA: 0x0031CA04 File Offset: 0x0031AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeQuitResponse.Descriptor;
			}
		}

		// Token: 0x06015712 RID: 87826 RVA: 0x0031CA0B File Offset: 0x0031AC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse()
		{
		}

		// Token: 0x06015713 RID: 87827 RVA: 0x0031CA13 File Offset: 0x0031AC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse(RoguelikeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015714 RID: 87828 RVA: 0x0031CA38 File Offset: 0x0031AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse Clone()
		{
			return new RoguelikeQuitResponse(this);
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x06015715 RID: 87829 RVA: 0x0031CA40 File Offset: 0x0031AC40
		// (set) Token: 0x06015716 RID: 87830 RVA: 0x0031CA48 File Offset: 0x0031AC48
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

		// Token: 0x06015717 RID: 87831 RVA: 0x0031CA51 File Offset: 0x0031AC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeQuitResponse);
		}

		// Token: 0x06015718 RID: 87832 RVA: 0x0031CA5F File Offset: 0x0031AC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015719 RID: 87833 RVA: 0x0031CA90 File Offset: 0x0031AC90
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

		// Token: 0x0601571A RID: 87834 RVA: 0x0031CAD5 File Offset: 0x0031ACD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601571B RID: 87835 RVA: 0x0031CAE2 File Offset: 0x0031ACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601571C RID: 87836 RVA: 0x0031CAEB File Offset: 0x0031ACEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601571D RID: 87837 RVA: 0x0031CB20 File Offset: 0x0031AD20
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

		// Token: 0x0601571E RID: 87838 RVA: 0x0031CB5E File Offset: 0x0031AD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeQuitResponse other)
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

		// Token: 0x0601571F RID: 87839 RVA: 0x0031CB8F File Offset: 0x0031AD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015720 RID: 87840 RVA: 0x0031CB98 File Offset: 0x0031AD98
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040080EF RID: 33007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080F0 RID: 33008
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040080F1 RID: 33009
		private ErrorCode errorCode_;
	}
}
