using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F0 RID: 240
	[NetMessage(EMessageId.AnimationStateChangedResponse)]
	public sealed class AnimationStateChangedResponse : IMessage<AnimationStateChangedResponse>, IMessage, IEquatable<AnimationStateChangedResponse>, IDeepCloneable<AnimationStateChangedResponse>, IBufferMessage
	{
		// Token: 0x060022B8 RID: 8888 RVA: 0x0005C9FD File Offset: 0x0005ABFD
		[NullableContext(1)]
		public static AnimationStateChangedResponse Create()
		{
			return new AnimationStateChangedResponse();
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0005CA04 File Offset: 0x0005AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0005CA07 File Offset: 0x0005AC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedResponse.Descriptor;
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0005CA0E File Offset: 0x0005AC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse()
		{
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0005CA16 File Offset: 0x0005AC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse(AnimationStateChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0005CA3B File Offset: 0x0005AC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedResponse Clone()
		{
			return new AnimationStateChangedResponse(this);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x0005CA43 File Offset: 0x0005AC43
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x0005CA4B File Offset: 0x0005AC4B
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

		// Token: 0x060022C0 RID: 8896 RVA: 0x0005CA54 File Offset: 0x0005AC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedResponse);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0005CA62 File Offset: 0x0005AC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0005CA90 File Offset: 0x0005AC90
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

		// Token: 0x060022C3 RID: 8899 RVA: 0x0005CAD5 File Offset: 0x0005ACD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0005CAE2 File Offset: 0x0005ACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0005CAEB File Offset: 0x0005ACEB
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

		// Token: 0x060022C6 RID: 8902 RVA: 0x0005CB20 File Offset: 0x0005AD20
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

		// Token: 0x060022C7 RID: 8903 RVA: 0x0005CB5E File Offset: 0x0005AD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateChangedResponse other)
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

		// Token: 0x060022C8 RID: 8904 RVA: 0x0005CB8F File Offset: 0x0005AD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0005CB98 File Offset: 0x0005AD98
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

		// Token: 0x040024EE RID: 9454
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024EF RID: 9455
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040024F0 RID: 9456
		private ErrorCode errorCode_;
	}
}
