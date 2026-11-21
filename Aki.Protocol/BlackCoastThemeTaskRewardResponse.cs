using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AE RID: 430
	[NetMessage(EMessageId.BlackCoastThemeTaskRewardResponse)]
	public sealed class BlackCoastThemeTaskRewardResponse : IMessage<BlackCoastThemeTaskRewardResponse>, IMessage, IEquatable<BlackCoastThemeTaskRewardResponse>, IDeepCloneable<BlackCoastThemeTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600326E RID: 12910 RVA: 0x00080635 File Offset: 0x0007E835
		[NullableContext(1)]
		public static BlackCoastThemeTaskRewardResponse Create()
		{
			return new BlackCoastThemeTaskRewardResponse();
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x0008063C File Offset: 0x0007E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x0008063F File Offset: 0x0007E83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x00080646 File Offset: 0x0007E846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse()
		{
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x0008064E File Offset: 0x0007E84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse(BlackCoastThemeTaskRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00080673 File Offset: 0x0007E873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse Clone()
		{
			return new BlackCoastThemeTaskRewardResponse(this);
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x0008067B File Offset: 0x0007E87B
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x00080683 File Offset: 0x0007E883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x0008068C File Offset: 0x0007E88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeTaskRewardResponse);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0008069A File Offset: 0x0007E89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeTaskRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000806C8 File Offset: 0x0007E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0008070D File Offset: 0x0007E90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0008071A File Offset: 0x0007E91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00080723 File Offset: 0x0007E923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00080758 File Offset: 0x0007E958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00080796 File Offset: 0x0007E996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000807C7 File Offset: 0x0007E9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000807D0 File Offset: 0x0007E9D0
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040029CD RID: 10701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029CE RID: 10702
		public const int ErrorFieldNumber = 4;

		// Token: 0x040029CF RID: 10703
		private ErrorCode error_;
	}
}
