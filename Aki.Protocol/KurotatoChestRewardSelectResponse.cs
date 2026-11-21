using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000879 RID: 2169
	[NetMessage(EMessageId.KurotatoChestRewardSelectResponse)]
	public sealed class KurotatoChestRewardSelectResponse : IMessage<KurotatoChestRewardSelectResponse>, IMessage, IEquatable<KurotatoChestRewardSelectResponse>, IDeepCloneable<KurotatoChestRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C169 RID: 49513 RVA: 0x001CBDC5 File Offset: 0x001C9FC5
		[NullableContext(1)]
		public static KurotatoChestRewardSelectResponse Create()
		{
			return new KurotatoChestRewardSelectResponse();
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x001CBDCC File Offset: 0x001C9FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600C16B RID: 49515 RVA: 0x001CBDCF File Offset: 0x001C9FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C16C RID: 49516 RVA: 0x001CBDD6 File Offset: 0x001C9FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse()
		{
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x001CBDDE File Offset: 0x001C9FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse(KurotatoChestRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x001CBE03 File Offset: 0x001CA003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardSelectResponse Clone()
		{
			return new KurotatoChestRewardSelectResponse(this);
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600C16F RID: 49519 RVA: 0x001CBE0B File Offset: 0x001CA00B
		// (set) Token: 0x0600C170 RID: 49520 RVA: 0x001CBE13 File Offset: 0x001CA013
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

		// Token: 0x0600C171 RID: 49521 RVA: 0x001CBE1C File Offset: 0x001CA01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardSelectResponse);
		}

		// Token: 0x0600C172 RID: 49522 RVA: 0x001CBE2A File Offset: 0x001CA02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C173 RID: 49523 RVA: 0x001CBE58 File Offset: 0x001CA058
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

		// Token: 0x0600C174 RID: 49524 RVA: 0x001CBE9D File Offset: 0x001CA09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C175 RID: 49525 RVA: 0x001CBEAA File Offset: 0x001CA0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C176 RID: 49526 RVA: 0x001CBEB3 File Offset: 0x001CA0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x001CBEE8 File Offset: 0x001CA0E8
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

		// Token: 0x0600C178 RID: 49528 RVA: 0x001CBF26 File Offset: 0x001CA126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoChestRewardSelectResponse other)
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

		// Token: 0x0600C179 RID: 49529 RVA: 0x001CBF57 File Offset: 0x001CA157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C17A RID: 49530 RVA: 0x001CBF60 File Offset: 0x001CA160
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400544A RID: 21578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400544B RID: 21579
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400544C RID: 21580
		private ErrorCode errorCode_;
	}
}
