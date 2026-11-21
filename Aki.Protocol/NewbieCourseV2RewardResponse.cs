using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFD RID: 2813
	[NetMessage(EMessageId.NewbieCourseV2RewardResponse)]
	public sealed class NewbieCourseV2RewardResponse : IMessage<NewbieCourseV2RewardResponse>, IMessage, IEquatable<NewbieCourseV2RewardResponse>, IDeepCloneable<NewbieCourseV2RewardResponse>, IBufferMessage
	{
		// Token: 0x0600F4BA RID: 62650 RVA: 0x0023BA2F File Offset: 0x00239C2F
		[NullableContext(1)]
		public static NewbieCourseV2RewardResponse Create()
		{
			return new NewbieCourseV2RewardResponse();
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600F4BB RID: 62651 RVA: 0x0023BA36 File Offset: 0x00239C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600F4BC RID: 62652 RVA: 0x0023BA39 File Offset: 0x00239C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0023BA40 File Offset: 0x00239C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse()
		{
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0023BA48 File Offset: 0x00239C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse(NewbieCourseV2RewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x0023BA6D File Offset: 0x00239C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardResponse Clone()
		{
			return new NewbieCourseV2RewardResponse(this);
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600F4C0 RID: 62656 RVA: 0x0023BA75 File Offset: 0x00239C75
		// (set) Token: 0x0600F4C1 RID: 62657 RVA: 0x0023BA7D File Offset: 0x00239C7D
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

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x0023BA86 File Offset: 0x00239C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardResponse);
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x0023BA94 File Offset: 0x00239C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x0023BAC4 File Offset: 0x00239CC4
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

		// Token: 0x0600F4C5 RID: 62661 RVA: 0x0023BB09 File Offset: 0x00239D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x0023BB16 File Offset: 0x00239D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4C7 RID: 62663 RVA: 0x0023BB1F File Offset: 0x00239D1F
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

		// Token: 0x0600F4C8 RID: 62664 RVA: 0x0023BB54 File Offset: 0x00239D54
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

		// Token: 0x0600F4C9 RID: 62665 RVA: 0x0023BB92 File Offset: 0x00239D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2RewardResponse other)
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

		// Token: 0x0600F4CA RID: 62666 RVA: 0x0023BBC3 File Offset: 0x00239DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0023BBCC File Offset: 0x00239DCC
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

		// Token: 0x040062D5 RID: 25301
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D6 RID: 25302
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040062D7 RID: 25303
		private ErrorCode errorCode_;
	}
}
