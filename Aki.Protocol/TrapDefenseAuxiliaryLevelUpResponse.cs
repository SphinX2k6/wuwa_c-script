using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147A RID: 5242
	[NetMessage(EMessageId.TrapDefenseAuxiliaryLevelUpResponse)]
	public sealed class TrapDefenseAuxiliaryLevelUpResponse : IMessage<TrapDefenseAuxiliaryLevelUpResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryLevelUpResponse>, IDeepCloneable<TrapDefenseAuxiliaryLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601BD72 RID: 114034 RVA: 0x0040BD49 File Offset: 0x00409F49
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryLevelUpResponse Create()
		{
			return new TrapDefenseAuxiliaryLevelUpResponse();
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x0601BD73 RID: 114035 RVA: 0x0040BD50 File Offset: 0x00409F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x0601BD74 RID: 114036 RVA: 0x0040BD53 File Offset: 0x00409F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601BD75 RID: 114037 RVA: 0x0040BD5A File Offset: 0x00409F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse()
		{
		}

		// Token: 0x0601BD76 RID: 114038 RVA: 0x0040BD62 File Offset: 0x00409F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse(TrapDefenseAuxiliaryLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD77 RID: 114039 RVA: 0x0040BD87 File Offset: 0x00409F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse Clone()
		{
			return new TrapDefenseAuxiliaryLevelUpResponse(this);
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x0601BD78 RID: 114040 RVA: 0x0040BD8F File Offset: 0x00409F8F
		// (set) Token: 0x0601BD79 RID: 114041 RVA: 0x0040BD97 File Offset: 0x00409F97
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

		// Token: 0x0601BD7A RID: 114042 RVA: 0x0040BDA0 File Offset: 0x00409FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryLevelUpResponse);
		}

		// Token: 0x0601BD7B RID: 114043 RVA: 0x0040BDAE File Offset: 0x00409FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x0040BDDC File Offset: 0x00409FDC
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

		// Token: 0x0601BD7D RID: 114045 RVA: 0x0040BE21 File Offset: 0x0040A021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD7E RID: 114046 RVA: 0x0040BE2E File Offset: 0x0040A02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD7F RID: 114047 RVA: 0x0040BE37 File Offset: 0x0040A037
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

		// Token: 0x0601BD80 RID: 114048 RVA: 0x0040BE68 File Offset: 0x0040A068
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

		// Token: 0x0601BD81 RID: 114049 RVA: 0x0040BEA6 File Offset: 0x0040A0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryLevelUpResponse other)
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

		// Token: 0x0601BD82 RID: 114050 RVA: 0x0040BED7 File Offset: 0x0040A0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD83 RID: 114051 RVA: 0x0040BEE0 File Offset: 0x0040A0E0
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

		// Token: 0x0400A196 RID: 41366
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A197 RID: 41367
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A198 RID: 41368
		private ErrorCode errorCode_;
	}
}
