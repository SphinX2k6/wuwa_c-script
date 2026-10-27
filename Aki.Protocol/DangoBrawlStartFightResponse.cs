using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037B RID: 891
	[NetMessage(EMessageId.DangoBrawlStartFightResponse)]
	public sealed class DangoBrawlStartFightResponse : IMessage<DangoBrawlStartFightResponse>, IMessage, IEquatable<DangoBrawlStartFightResponse>, IDeepCloneable<DangoBrawlStartFightResponse>, IBufferMessage
	{
		// Token: 0x06005862 RID: 22626 RVA: 0x000D780E File Offset: 0x000D5A0E
		[NullableContext(1)]
		public static DangoBrawlStartFightResponse Create()
		{
			return new DangoBrawlStartFightResponse();
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x000D7815 File Offset: 0x000D5A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06005864 RID: 22628 RVA: 0x000D7818 File Offset: 0x000D5A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightResponse.Descriptor;
			}
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x000D781F File Offset: 0x000D5A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse()
		{
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x000D7827 File Offset: 0x000D5A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse(DangoBrawlStartFightResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x000D784C File Offset: 0x000D5A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse Clone()
		{
			return new DangoBrawlStartFightResponse(this);
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x000D7854 File Offset: 0x000D5A54
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x000D785C File Offset: 0x000D5A5C
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

		// Token: 0x0600586A RID: 22634 RVA: 0x000D7865 File Offset: 0x000D5A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightResponse);
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x000D7873 File Offset: 0x000D5A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x000D78A4 File Offset: 0x000D5AA4
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

		// Token: 0x0600586D RID: 22637 RVA: 0x000D78E9 File Offset: 0x000D5AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x000D78F6 File Offset: 0x000D5AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x000D78FF File Offset: 0x000D5AFF
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

		// Token: 0x06005870 RID: 22640 RVA: 0x000D7934 File Offset: 0x000D5B34
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

		// Token: 0x06005871 RID: 22641 RVA: 0x000D7972 File Offset: 0x000D5B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightResponse other)
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

		// Token: 0x06005872 RID: 22642 RVA: 0x000D79A3 File Offset: 0x000D5BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x000D79AC File Offset: 0x000D5BAC
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

		// Token: 0x0400350F RID: 13583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003510 RID: 13584
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04003511 RID: 13585
		private ErrorCode errorCode_;
	}
}
