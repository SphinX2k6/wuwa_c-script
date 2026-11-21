using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E29 RID: 3625
	[NetMessage(EMessageId.QuickHackSkillResponse)]
	public sealed class QuickHackSkillResponse : IMessage<QuickHackSkillResponse>, IMessage, IEquatable<QuickHackSkillResponse>, IDeepCloneable<QuickHackSkillResponse>, IBufferMessage
	{
		// Token: 0x060137CC RID: 79820 RVA: 0x002D563C File Offset: 0x002D383C
		[NullableContext(1)]
		public static QuickHackSkillResponse Create()
		{
			return new QuickHackSkillResponse();
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x060137CD RID: 79821 RVA: 0x002D5643 File Offset: 0x002D3843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x060137CE RID: 79822 RVA: 0x002D5646 File Offset: 0x002D3846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackSkillResponse.Descriptor;
			}
		}

		// Token: 0x060137CF RID: 79823 RVA: 0x002D564D File Offset: 0x002D384D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse()
		{
		}

		// Token: 0x060137D0 RID: 79824 RVA: 0x002D5655 File Offset: 0x002D3855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse(QuickHackSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137D1 RID: 79825 RVA: 0x002D567A File Offset: 0x002D387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackSkillResponse Clone()
		{
			return new QuickHackSkillResponse(this);
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x060137D2 RID: 79826 RVA: 0x002D5682 File Offset: 0x002D3882
		// (set) Token: 0x060137D3 RID: 79827 RVA: 0x002D568A File Offset: 0x002D388A
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

		// Token: 0x060137D4 RID: 79828 RVA: 0x002D5693 File Offset: 0x002D3893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackSkillResponse);
		}

		// Token: 0x060137D5 RID: 79829 RVA: 0x002D56A1 File Offset: 0x002D38A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137D6 RID: 79830 RVA: 0x002D56D0 File Offset: 0x002D38D0
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

		// Token: 0x060137D7 RID: 79831 RVA: 0x002D5715 File Offset: 0x002D3915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137D8 RID: 79832 RVA: 0x002D5722 File Offset: 0x002D3922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137D9 RID: 79833 RVA: 0x002D572B File Offset: 0x002D392B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137DA RID: 79834 RVA: 0x002D5760 File Offset: 0x002D3960
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

		// Token: 0x060137DB RID: 79835 RVA: 0x002D579E File Offset: 0x002D399E
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

		// Token: 0x060137DC RID: 79836 RVA: 0x002D57CF File Offset: 0x002D39CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137DD RID: 79837 RVA: 0x002D57D8 File Offset: 0x002D39D8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040077C4 RID: 30660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077C5 RID: 30661
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040077C6 RID: 30662
		private ErrorCode errorCode_;
	}
}
