using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F4 RID: 1268
	[NetMessage(EMessageId.ExploreActivityTaskRewardResponse)]
	public sealed class ExploreActivityTaskRewardResponse : IMessage<ExploreActivityTaskRewardResponse>, IMessage, IEquatable<ExploreActivityTaskRewardResponse>, IDeepCloneable<ExploreActivityTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060077CA RID: 30666 RVA: 0x0012410D File Offset: 0x0012230D
		[NullableContext(1)]
		public static ExploreActivityTaskRewardResponse Create()
		{
			return new ExploreActivityTaskRewardResponse();
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x00124114 File Offset: 0x00122314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060077CC RID: 30668 RVA: 0x00124117 File Offset: 0x00122317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0012411E File Offset: 0x0012231E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse()
		{
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00124126 File Offset: 0x00122326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse(ExploreActivityTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0012414B File Offset: 0x0012234B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse Clone()
		{
			return new ExploreActivityTaskRewardResponse(this);
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x00124153 File Offset: 0x00122353
		// (set) Token: 0x060077D1 RID: 30673 RVA: 0x0012415B File Offset: 0x0012235B
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

		// Token: 0x060077D2 RID: 30674 RVA: 0x00124164 File Offset: 0x00122364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskRewardResponse);
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x00124172 File Offset: 0x00122372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x001241A0 File Offset: 0x001223A0
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

		// Token: 0x060077D5 RID: 30677 RVA: 0x001241E5 File Offset: 0x001223E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x001241F2 File Offset: 0x001223F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x001241FB File Offset: 0x001223FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00124230 File Offset: 0x00122430
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

		// Token: 0x060077D9 RID: 30681 RVA: 0x0012426E File Offset: 0x0012246E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreActivityTaskRewardResponse other)
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

		// Token: 0x060077DA RID: 30682 RVA: 0x0012429F File Offset: 0x0012249F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x001242A8 File Offset: 0x001224A8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E42 RID: 15938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E43 RID: 15939
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04003E44 RID: 15940
		private ErrorCode errorCode_;
	}
}
