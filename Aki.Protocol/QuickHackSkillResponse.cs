using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E39 RID: 3641
	[NetMessage(EMessageId.QuickHackSkillResponse)]
	public sealed class QuickHackSkillResponse : IMessage<QuickHackSkillResponse>, IMessage, IEquatable<QuickHackSkillResponse>, IDeepCloneable<QuickHackSkillResponse>, IBufferMessage
	{
		// Token: 0x060138B1 RID: 80049 RVA: 0x002D6CFC File Offset: 0x002D4EFC
		[NullableContext(1)]
		public static QuickHackSkillResponse Create()
		{
			return new QuickHackSkillResponse();
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x060138B2 RID: 80050 RVA: 0x002D6D03 File Offset: 0x002D4F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x060138B3 RID: 80051 RVA: 0x002D6D06 File Offset: 0x002D4F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackSkillResponse.Descriptor;
			}
		}

		// Token: 0x060138B4 RID: 80052 RVA: 0x002D6D0D File Offset: 0x002D4F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse()
		{
		}

		// Token: 0x060138B5 RID: 80053 RVA: 0x002D6D15 File Offset: 0x002D4F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse(QuickHackSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138B6 RID: 80054 RVA: 0x002D6D3A File Offset: 0x002D4F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse Clone()
		{
			return new QuickHackSkillResponse(this);
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x060138B7 RID: 80055 RVA: 0x002D6D42 File Offset: 0x002D4F42
		// (set) Token: 0x060138B8 RID: 80056 RVA: 0x002D6D4A File Offset: 0x002D4F4A
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

		// Token: 0x060138B9 RID: 80057 RVA: 0x002D6D53 File Offset: 0x002D4F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackSkillResponse);
		}

		// Token: 0x060138BA RID: 80058 RVA: 0x002D6D61 File Offset: 0x002D4F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138BB RID: 80059 RVA: 0x002D6D90 File Offset: 0x002D4F90
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

		// Token: 0x060138BC RID: 80060 RVA: 0x002D6DD5 File Offset: 0x002D4FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138BD RID: 80061 RVA: 0x002D6DE2 File Offset: 0x002D4FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138BE RID: 80062 RVA: 0x002D6DEB File Offset: 0x002D4FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138BF RID: 80063 RVA: 0x002D6E20 File Offset: 0x002D5020
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

		// Token: 0x060138C0 RID: 80064 RVA: 0x002D6E5E File Offset: 0x002D505E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuickHackSkillResponse other)
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

		// Token: 0x060138C1 RID: 80065 RVA: 0x002D6E8F File Offset: 0x002D508F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138C2 RID: 80066 RVA: 0x002D6E98 File Offset: 0x002D5098
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400779A RID: 30618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400779B RID: 30619
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400779C RID: 30620
		private ErrorCode errorCode_;
	}
}
