using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0A RID: 2826
	[NetMessage(EMessageId.NewBieCourseRewardResponse)]
	public sealed class NewBieCourseRewardResponse : IMessage<NewBieCourseRewardResponse>, IMessage, IEquatable<NewBieCourseRewardResponse>, IDeepCloneable<NewBieCourseRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F586 RID: 62854 RVA: 0x0023D25D File Offset: 0x0023B45D
		[NullableContext(1)]
		public static NewBieCourseRewardResponse Create()
		{
			return new NewBieCourseRewardResponse();
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600F587 RID: 62855 RVA: 0x0023D264 File Offset: 0x0023B464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600F588 RID: 62856 RVA: 0x0023D267 File Offset: 0x0023B467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F589 RID: 62857 RVA: 0x0023D26E File Offset: 0x0023B46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse()
		{
		}

		// Token: 0x0600F58A RID: 62858 RVA: 0x0023D276 File Offset: 0x0023B476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse(NewBieCourseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F58B RID: 62859 RVA: 0x0023D29B File Offset: 0x0023B49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardResponse Clone()
		{
			return new NewBieCourseRewardResponse(this);
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600F58C RID: 62860 RVA: 0x0023D2A3 File Offset: 0x0023B4A3
		// (set) Token: 0x0600F58D RID: 62861 RVA: 0x0023D2AB File Offset: 0x0023B4AB
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

		// Token: 0x0600F58E RID: 62862 RVA: 0x0023D2B4 File Offset: 0x0023B4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardResponse);
		}

		// Token: 0x0600F58F RID: 62863 RVA: 0x0023D2C2 File Offset: 0x0023B4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F590 RID: 62864 RVA: 0x0023D2F0 File Offset: 0x0023B4F0
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

		// Token: 0x0600F591 RID: 62865 RVA: 0x0023D335 File Offset: 0x0023B535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F592 RID: 62866 RVA: 0x0023D342 File Offset: 0x0023B542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F593 RID: 62867 RVA: 0x0023D34B File Offset: 0x0023B54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F594 RID: 62868 RVA: 0x0023D380 File Offset: 0x0023B580
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

		// Token: 0x0600F595 RID: 62869 RVA: 0x0023D3BE File Offset: 0x0023B5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardResponse other)
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

		// Token: 0x0600F596 RID: 62870 RVA: 0x0023D3EF File Offset: 0x0023B5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F597 RID: 62871 RVA: 0x0023D3F8 File Offset: 0x0023B5F8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062B7 RID: 25271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062B8 RID: 25272
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040062B9 RID: 25273
		private ErrorCode errorCode_;
	}
}
