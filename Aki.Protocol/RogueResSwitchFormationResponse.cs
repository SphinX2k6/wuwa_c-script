using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF9 RID: 4089
	[NetMessage(EMessageId.RogueResSwitchFormationResponse)]
	public sealed class RogueResSwitchFormationResponse : IMessage<RogueResSwitchFormationResponse>, IMessage, IEquatable<RogueResSwitchFormationResponse>, IDeepCloneable<RogueResSwitchFormationResponse>, IBufferMessage
	{
		// Token: 0x06015E5E RID: 89694 RVA: 0x0032FE05 File Offset: 0x0032E005
		[NullableContext(1)]
		public static RogueResSwitchFormationResponse Create()
		{
			return new RogueResSwitchFormationResponse();
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x06015E5F RID: 89695 RVA: 0x0032FE0C File Offset: 0x0032E00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x06015E60 RID: 89696 RVA: 0x0032FE0F File Offset: 0x0032E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSwitchFormationResponse.Descriptor;
			}
		}

		// Token: 0x06015E61 RID: 89697 RVA: 0x0032FE16 File Offset: 0x0032E016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse()
		{
		}

		// Token: 0x06015E62 RID: 89698 RVA: 0x0032FE1E File Offset: 0x0032E01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse(RogueResSwitchFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E63 RID: 89699 RVA: 0x0032FE43 File Offset: 0x0032E043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationResponse Clone()
		{
			return new RogueResSwitchFormationResponse(this);
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x06015E64 RID: 89700 RVA: 0x0032FE4B File Offset: 0x0032E04B
		// (set) Token: 0x06015E65 RID: 89701 RVA: 0x0032FE53 File Offset: 0x0032E053
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

		// Token: 0x06015E66 RID: 89702 RVA: 0x0032FE5C File Offset: 0x0032E05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSwitchFormationResponse);
		}

		// Token: 0x06015E67 RID: 89703 RVA: 0x0032FE6A File Offset: 0x0032E06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSwitchFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E68 RID: 89704 RVA: 0x0032FE98 File Offset: 0x0032E098
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

		// Token: 0x06015E69 RID: 89705 RVA: 0x0032FEDD File Offset: 0x0032E0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E6A RID: 89706 RVA: 0x0032FEEA File Offset: 0x0032E0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E6B RID: 89707 RVA: 0x0032FEF3 File Offset: 0x0032E0F3
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

		// Token: 0x06015E6C RID: 89708 RVA: 0x0032FF28 File Offset: 0x0032E128
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

		// Token: 0x06015E6D RID: 89709 RVA: 0x0032FF66 File Offset: 0x0032E166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSwitchFormationResponse other)
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

		// Token: 0x06015E6E RID: 89710 RVA: 0x0032FF97 File Offset: 0x0032E197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E6F RID: 89711 RVA: 0x0032FFA0 File Offset: 0x0032E1A0
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

		// Token: 0x040083F2 RID: 33778
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083F3 RID: 33779
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040083F4 RID: 33780
		private ErrorCode errorCode_;
	}
}
