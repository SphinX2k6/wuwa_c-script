using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7C RID: 3708
	[NetMessage(EMessageId.RacingBetsTaskRewardResponse)]
	public sealed class RacingBetsTaskRewardResponse : IMessage<RacingBetsTaskRewardResponse>, IMessage, IEquatable<RacingBetsTaskRewardResponse>, IDeepCloneable<RacingBetsTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06013EA1 RID: 81569 RVA: 0x002E63F1 File Offset: 0x002E45F1
		[NullableContext(1)]
		public static RacingBetsTaskRewardResponse Create()
		{
			return new RacingBetsTaskRewardResponse();
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x06013EA2 RID: 81570 RVA: 0x002E63F8 File Offset: 0x002E45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x06013EA3 RID: 81571 RVA: 0x002E63FB File Offset: 0x002E45FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06013EA4 RID: 81572 RVA: 0x002E6402 File Offset: 0x002E4602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse()
		{
		}

		// Token: 0x06013EA5 RID: 81573 RVA: 0x002E640A File Offset: 0x002E460A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse(RacingBetsTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EA6 RID: 81574 RVA: 0x002E642F File Offset: 0x002E462F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskRewardResponse Clone()
		{
			return new RacingBetsTaskRewardResponse(this);
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x06013EA7 RID: 81575 RVA: 0x002E6437 File Offset: 0x002E4637
		// (set) Token: 0x06013EA8 RID: 81576 RVA: 0x002E643F File Offset: 0x002E463F
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

		// Token: 0x06013EA9 RID: 81577 RVA: 0x002E6448 File Offset: 0x002E4648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskRewardResponse);
		}

		// Token: 0x06013EAA RID: 81578 RVA: 0x002E6456 File Offset: 0x002E4656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EAB RID: 81579 RVA: 0x002E6484 File Offset: 0x002E4684
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

		// Token: 0x06013EAC RID: 81580 RVA: 0x002E64C9 File Offset: 0x002E46C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EAD RID: 81581 RVA: 0x002E64D6 File Offset: 0x002E46D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EAE RID: 81582 RVA: 0x002E64DF File Offset: 0x002E46DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EAF RID: 81583 RVA: 0x002E6514 File Offset: 0x002E4714
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

		// Token: 0x06013EB0 RID: 81584 RVA: 0x002E6552 File Offset: 0x002E4752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskRewardResponse other)
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

		// Token: 0x06013EB1 RID: 81585 RVA: 0x002E6583 File Offset: 0x002E4783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EB2 RID: 81586 RVA: 0x002E658C File Offset: 0x002E478C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040079B3 RID: 31155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079B4 RID: 31156
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040079B5 RID: 31157
		private ErrorCode errorCode_;
	}
}
