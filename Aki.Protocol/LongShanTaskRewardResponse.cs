using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000947 RID: 2375
	[NetMessage(EMessageId.LongShanTaskRewardResponse)]
	public sealed class LongShanTaskRewardResponse : IMessage<LongShanTaskRewardResponse>, IMessage, IEquatable<LongShanTaskRewardResponse>, IDeepCloneable<LongShanTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D1BD RID: 53693 RVA: 0x001EF23D File Offset: 0x001ED43D
		[NullableContext(1)]
		public static LongShanTaskRewardResponse Create()
		{
			return new LongShanTaskRewardResponse();
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600D1BE RID: 53694 RVA: 0x001EF244 File Offset: 0x001ED444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x001EF247 File Offset: 0x001ED447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D1C0 RID: 53696 RVA: 0x001EF24E File Offset: 0x001ED44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse()
		{
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x001EF256 File Offset: 0x001ED456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse(LongShanTaskRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x001EF27B File Offset: 0x001ED47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse Clone()
		{
			return new LongShanTaskRewardResponse(this);
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600D1C3 RID: 53699 RVA: 0x001EF283 File Offset: 0x001ED483
		// (set) Token: 0x0600D1C4 RID: 53700 RVA: 0x001EF28B File Offset: 0x001ED48B
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

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x001EF294 File Offset: 0x001ED494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskRewardResponse);
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x001EF2A2 File Offset: 0x001ED4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x001EF2D0 File Offset: 0x001ED4D0
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

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x001EF315 File Offset: 0x001ED515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x001EF322 File Offset: 0x001ED522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x001EF32B File Offset: 0x001ED52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1CB RID: 53707 RVA: 0x001EF360 File Offset: 0x001ED560
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

		// Token: 0x0600D1CC RID: 53708 RVA: 0x001EF39E File Offset: 0x001ED59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanTaskRewardResponse other)
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

		// Token: 0x0600D1CD RID: 53709 RVA: 0x001EF3CF File Offset: 0x001ED5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1CE RID: 53710 RVA: 0x001EF3D8 File Offset: 0x001ED5D8
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058BC RID: 22716
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058BD RID: 22717
		public const int ErrorFieldNumber = 15;

		// Token: 0x040058BE RID: 22718
		private ErrorCode error_;
	}
}
