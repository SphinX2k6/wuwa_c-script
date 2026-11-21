using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC6 RID: 2758
	[NetMessage(EMessageId.MulCalabashLevelRewardResponse)]
	public sealed class MulCalabashLevelRewardResponse : IMessage<MulCalabashLevelRewardResponse>, IMessage, IEquatable<MulCalabashLevelRewardResponse>, IDeepCloneable<MulCalabashLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F06B RID: 61547 RVA: 0x002325FD File Offset: 0x002307FD
		[NullableContext(1)]
		public static MulCalabashLevelRewardResponse Create()
		{
			return new MulCalabashLevelRewardResponse();
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x00232604 File Offset: 0x00230804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600F06D RID: 61549 RVA: 0x00232607 File Offset: 0x00230807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCalabashLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F06E RID: 61550 RVA: 0x0023260E File Offset: 0x0023080E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse()
		{
		}

		// Token: 0x0600F06F RID: 61551 RVA: 0x00232621 File Offset: 0x00230821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse(MulCalabashLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F070 RID: 61552 RVA: 0x00232657 File Offset: 0x00230857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse Clone()
		{
			return new MulCalabashLevelRewardResponse(this);
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600F071 RID: 61553 RVA: 0x0023265F File Offset: 0x0023085F
		// (set) Token: 0x0600F072 RID: 61554 RVA: 0x00232667 File Offset: 0x00230867
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

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600F073 RID: 61555 RVA: 0x00232670 File Offset: 0x00230870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F074 RID: 61556 RVA: 0x00232678 File Offset: 0x00230878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCalabashLevelRewardResponse);
		}

		// Token: 0x0600F075 RID: 61557 RVA: 0x00232688 File Offset: 0x00230888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCalabashLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F076 RID: 61558 RVA: 0x002326D8 File Offset: 0x002308D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.level_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F077 RID: 61559 RVA: 0x0023272B File Offset: 0x0023092B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F078 RID: 61560 RVA: 0x00232738 File Offset: 0x00230938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F079 RID: 61561 RVA: 0x00232744 File Offset: 0x00230944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.level_.WriteTo(ref output, MulCalabashLevelRewardResponse._repeated_level_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F07A RID: 61562 RVA: 0x00232794 File Offset: 0x00230994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.level_.CalculateSize(MulCalabashLevelRewardResponse._repeated_level_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F07B RID: 61563 RVA: 0x002327E8 File Offset: 0x002309E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCalabashLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.level_.Add(other.level_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F07C RID: 61564 RVA: 0x00232835 File Offset: 0x00230A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F07D RID: 61565 RVA: 0x00232840 File Offset: 0x00230A40
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
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.level_.AddEntriesFrom(ref input, MulCalabashLevelRewardResponse._repeated_level_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006198 RID: 24984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006199 RID: 24985
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400619A RID: 24986
		private ErrorCode errorCode_;

		// Token: 0x0400619B RID: 24987
		public const int LevelFieldNumber = 12;

		// Token: 0x0400619C RID: 24988
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400619D RID: 24989
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
