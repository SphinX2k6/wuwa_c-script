using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026A RID: 618
	[NetMessage(EMessageId.ChangeSummonEntityStateResponse)]
	public sealed class ChangeSummonEntityStateResponse : IMessage<ChangeSummonEntityStateResponse>, IMessage, IEquatable<ChangeSummonEntityStateResponse>, IDeepCloneable<ChangeSummonEntityStateResponse>, IBufferMessage
	{
		// Token: 0x0600416C RID: 16748 RVA: 0x000A0C6C File Offset: 0x0009EE6C
		[NullableContext(1)]
		public static ChangeSummonEntityStateResponse Create()
		{
			return new ChangeSummonEntityStateResponse();
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x000A0C73 File Offset: 0x0009EE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x000A0C76 File Offset: 0x0009EE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSummonEntityStateResponse.Descriptor;
			}
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x000A0C7D File Offset: 0x0009EE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse()
		{
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x000A0C85 File Offset: 0x0009EE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse(ChangeSummonEntityStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x000A0CAA File Offset: 0x0009EEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse Clone()
		{
			return new ChangeSummonEntityStateResponse(this);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x000A0CB2 File Offset: 0x0009EEB2
		// (set) Token: 0x06004173 RID: 16755 RVA: 0x000A0CBA File Offset: 0x0009EEBA
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

		// Token: 0x06004174 RID: 16756 RVA: 0x000A0CC3 File Offset: 0x0009EEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSummonEntityStateResponse);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000A0CD1 File Offset: 0x0009EED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSummonEntityStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x000A0D00 File Offset: 0x0009EF00
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

		// Token: 0x06004177 RID: 16759 RVA: 0x000A0D45 File Offset: 0x0009EF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x000A0D52 File Offset: 0x0009EF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000A0D5B File Offset: 0x0009EF5B
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

		// Token: 0x0600417A RID: 16762 RVA: 0x000A0D8C File Offset: 0x0009EF8C
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

		// Token: 0x0600417B RID: 16763 RVA: 0x000A0DCA File Offset: 0x0009EFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSummonEntityStateResponse other)
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

		// Token: 0x0600417C RID: 16764 RVA: 0x000A0DFB File Offset: 0x0009EFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x000A0E04 File Offset: 0x0009F004
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

		// Token: 0x04002DFE RID: 11774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFF RID: 11775
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002E00 RID: 11776
		private ErrorCode errorCode_;
	}
}
