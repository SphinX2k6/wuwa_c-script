using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072D RID: 1837
	[NetMessage(EMessageId.HarvestActivityLevelDiffResponse)]
	public sealed class HarvestActivityLevelDiffResponse : IMessage<HarvestActivityLevelDiffResponse>, IMessage, IEquatable<HarvestActivityLevelDiffResponse>, IDeepCloneable<HarvestActivityLevelDiffResponse>, IBufferMessage
	{
		// Token: 0x0600A6EE RID: 42734 RVA: 0x00192413 File Offset: 0x00190613
		[NullableContext(1)]
		public static HarvestActivityLevelDiffResponse Create()
		{
			return new HarvestActivityLevelDiffResponse();
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x0019241A File Offset: 0x0019061A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x0600A6F0 RID: 42736 RVA: 0x0019241D File Offset: 0x0019061D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelDiffResponse.Descriptor;
			}
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x00192424 File Offset: 0x00190624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse()
		{
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x0019242C File Offset: 0x0019062C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse(HarvestActivityLevelDiffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x00192451 File Offset: 0x00190651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse Clone()
		{
			return new HarvestActivityLevelDiffResponse(this);
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x00192459 File Offset: 0x00190659
		// (set) Token: 0x0600A6F5 RID: 42741 RVA: 0x00192461 File Offset: 0x00190661
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

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x0019246A File Offset: 0x0019066A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelDiffResponse);
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x00192478 File Offset: 0x00190678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelDiffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x001924A8 File Offset: 0x001906A8
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

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x001924ED File Offset: 0x001906ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x001924FA File Offset: 0x001906FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x00192503 File Offset: 0x00190703
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

		// Token: 0x0600A6FC RID: 42748 RVA: 0x00192538 File Offset: 0x00190738
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

		// Token: 0x0600A6FD RID: 42749 RVA: 0x00192576 File Offset: 0x00190776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelDiffResponse other)
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

		// Token: 0x0600A6FE RID: 42750 RVA: 0x001925A7 File Offset: 0x001907A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x001925B0 File Offset: 0x001907B0
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

		// Token: 0x04004CC4 RID: 19652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CC5 RID: 19653
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004CC6 RID: 19654
		private ErrorCode errorCode_;
	}
}
