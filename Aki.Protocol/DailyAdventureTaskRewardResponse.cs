using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000321 RID: 801
	[NetMessage(EMessageId.DailyAdventureTaskRewardResponse)]
	public sealed class DailyAdventureTaskRewardResponse : IMessage<DailyAdventureTaskRewardResponse>, IMessage, IEquatable<DailyAdventureTaskRewardResponse>, IDeepCloneable<DailyAdventureTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005098 RID: 20632 RVA: 0x000C4681 File Offset: 0x000C2881
		[NullableContext(1)]
		public static DailyAdventureTaskRewardResponse Create()
		{
			return new DailyAdventureTaskRewardResponse();
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x000C4688 File Offset: 0x000C2888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x000C468B File Offset: 0x000C288B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x000C4692 File Offset: 0x000C2892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse()
		{
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x000C469A File Offset: 0x000C289A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse(DailyAdventureTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x000C46BF File Offset: 0x000C28BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse Clone()
		{
			return new DailyAdventureTaskRewardResponse(this);
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x000C46C7 File Offset: 0x000C28C7
		// (set) Token: 0x0600509F RID: 20639 RVA: 0x000C46CF File Offset: 0x000C28CF
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

		// Token: 0x060050A0 RID: 20640 RVA: 0x000C46D8 File Offset: 0x000C28D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskRewardResponse);
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x000C46E6 File Offset: 0x000C28E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x000C4714 File Offset: 0x000C2914
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

		// Token: 0x060050A3 RID: 20643 RVA: 0x000C4759 File Offset: 0x000C2959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x000C4766 File Offset: 0x000C2966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x000C476F File Offset: 0x000C296F
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

		// Token: 0x060050A6 RID: 20646 RVA: 0x000C47A4 File Offset: 0x000C29A4
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

		// Token: 0x060050A7 RID: 20647 RVA: 0x000C47E2 File Offset: 0x000C29E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureTaskRewardResponse other)
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

		// Token: 0x060050A8 RID: 20648 RVA: 0x000C4813 File Offset: 0x000C2A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x000C481C File Offset: 0x000C2A1C
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

		// Token: 0x0400326E RID: 12910
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400326F RID: 12911
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04003270 RID: 12912
		private ErrorCode errorCode_;
	}
}
