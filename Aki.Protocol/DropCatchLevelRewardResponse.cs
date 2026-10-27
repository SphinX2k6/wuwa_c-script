using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040D RID: 1037
	[NetMessage(EMessageId.DropCatchLevelRewardResponse)]
	public sealed class DropCatchLevelRewardResponse : IMessage<DropCatchLevelRewardResponse>, IMessage, IEquatable<DropCatchLevelRewardResponse>, IDeepCloneable<DropCatchLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x060063F0 RID: 25584 RVA: 0x000F0340 File Offset: 0x000EE540
		[NullableContext(1)]
		public static DropCatchLevelRewardResponse Create()
		{
			return new DropCatchLevelRewardResponse();
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060063F1 RID: 25585 RVA: 0x000F0347 File Offset: 0x000EE547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x000F034A File Offset: 0x000EE54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x000F0351 File Offset: 0x000EE551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse()
		{
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x000F0359 File Offset: 0x000EE559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse(DropCatchLevelRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x000F037E File Offset: 0x000EE57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse Clone()
		{
			return new DropCatchLevelRewardResponse(this);
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x000F0386 File Offset: 0x000EE586
		// (set) Token: 0x060063F7 RID: 25591 RVA: 0x000F038E File Offset: 0x000EE58E
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

		// Token: 0x060063F8 RID: 25592 RVA: 0x000F0397 File Offset: 0x000EE597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardResponse);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x000F03A5 File Offset: 0x000EE5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x000F03D4 File Offset: 0x000EE5D4
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

		// Token: 0x060063FB RID: 25595 RVA: 0x000F0419 File Offset: 0x000EE619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x000F0426 File Offset: 0x000EE626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x000F042F File Offset: 0x000EE62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x000F0464 File Offset: 0x000EE664
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

		// Token: 0x060063FF RID: 25599 RVA: 0x000F04A2 File Offset: 0x000EE6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardResponse other)
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

		// Token: 0x06006400 RID: 25600 RVA: 0x000F04D3 File Offset: 0x000EE6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x000F04DC File Offset: 0x000EE6DC
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003847 RID: 14407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003848 RID: 14408
		public const int ErrorFieldNumber = 5;

		// Token: 0x04003849 RID: 14409
		private ErrorCode error_;
	}
}
