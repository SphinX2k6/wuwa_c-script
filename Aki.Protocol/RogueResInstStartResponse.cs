using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE1 RID: 4065
	[NetMessage(EMessageId.RogueResInstStartResponse)]
	public sealed class RogueResInstStartResponse : IMessage<RogueResInstStartResponse>, IMessage, IEquatable<RogueResInstStartResponse>, IDeepCloneable<RogueResInstStartResponse>, IBufferMessage
	{
		// Token: 0x06015C2D RID: 89133 RVA: 0x00329EDD File Offset: 0x003280DD
		[NullableContext(1)]
		public static RogueResInstStartResponse Create()
		{
			return new RogueResInstStartResponse();
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06015C2E RID: 89134 RVA: 0x00329EE4 File Offset: 0x003280E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x06015C2F RID: 89135 RVA: 0x00329EE7 File Offset: 0x003280E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstStartResponse.Descriptor;
			}
		}

		// Token: 0x06015C30 RID: 89136 RVA: 0x00329EEE File Offset: 0x003280EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse()
		{
		}

		// Token: 0x06015C31 RID: 89137 RVA: 0x00329EF6 File Offset: 0x003280F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse(RogueResInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C32 RID: 89138 RVA: 0x00329F1B File Offset: 0x0032811B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse Clone()
		{
			return new RogueResInstStartResponse(this);
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x06015C33 RID: 89139 RVA: 0x00329F23 File Offset: 0x00328123
		// (set) Token: 0x06015C34 RID: 89140 RVA: 0x00329F2B File Offset: 0x0032812B
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

		// Token: 0x06015C35 RID: 89141 RVA: 0x00329F34 File Offset: 0x00328134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstStartResponse);
		}

		// Token: 0x06015C36 RID: 89142 RVA: 0x00329F42 File Offset: 0x00328142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C37 RID: 89143 RVA: 0x00329F70 File Offset: 0x00328170
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

		// Token: 0x06015C38 RID: 89144 RVA: 0x00329FB5 File Offset: 0x003281B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C39 RID: 89145 RVA: 0x00329FC2 File Offset: 0x003281C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C3A RID: 89146 RVA: 0x00329FCB File Offset: 0x003281CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C3B RID: 89147 RVA: 0x0032A000 File Offset: 0x00328200
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

		// Token: 0x06015C3C RID: 89148 RVA: 0x0032A03E File Offset: 0x0032823E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstStartResponse other)
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

		// Token: 0x06015C3D RID: 89149 RVA: 0x0032A06F File Offset: 0x0032826F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C3E RID: 89150 RVA: 0x0032A078 File Offset: 0x00328278
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400831C RID: 33564
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400831D RID: 33565
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400831E RID: 33566
		private ErrorCode errorCode_;
	}
}
