using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD2 RID: 2770
	[NetMessage(EMessageId.MulMapTravelTaskRewardResponse)]
	public sealed class MulMapTravelTaskRewardResponse : IMessage<MulMapTravelTaskRewardResponse>, IMessage, IEquatable<MulMapTravelTaskRewardResponse>, IDeepCloneable<MulMapTravelTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F14F RID: 61775 RVA: 0x00234195 File Offset: 0x00232395
		[NullableContext(1)]
		public static MulMapTravelTaskRewardResponse Create()
		{
			return new MulMapTravelTaskRewardResponse();
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600F150 RID: 61776 RVA: 0x0023419C File Offset: 0x0023239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600F151 RID: 61777 RVA: 0x0023419F File Offset: 0x0023239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F152 RID: 61778 RVA: 0x002341A6 File Offset: 0x002323A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse()
		{
		}

		// Token: 0x0600F153 RID: 61779 RVA: 0x002341B9 File Offset: 0x002323B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse(MulMapTravelTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x002341EF File Offset: 0x002323EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse Clone()
		{
			return new MulMapTravelTaskRewardResponse(this);
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600F155 RID: 61781 RVA: 0x002341F7 File Offset: 0x002323F7
		// (set) Token: 0x0600F156 RID: 61782 RVA: 0x002341FF File Offset: 0x002323FF
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

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600F157 RID: 61783 RVA: 0x00234208 File Offset: 0x00232408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x00234210 File Offset: 0x00232410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelTaskRewardResponse);
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x00234220 File Offset: 0x00232420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x00234270 File Offset: 0x00232470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F15B RID: 61787 RVA: 0x002342C3 File Offset: 0x002324C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F15C RID: 61788 RVA: 0x002342D0 File Offset: 0x002324D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F15D RID: 61789 RVA: 0x002342DC File Offset: 0x002324DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, MulMapTravelTaskRewardResponse._repeated_taskId_codec);
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

		// Token: 0x0600F15E RID: 61790 RVA: 0x0023432C File Offset: 0x0023252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskId_.CalculateSize(MulMapTravelTaskRewardResponse._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F15F RID: 61791 RVA: 0x00234380 File Offset: 0x00232580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulMapTravelTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F160 RID: 61792 RVA: 0x002343CD File Offset: 0x002325CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x002343D8 File Offset: 0x002325D8
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
				if (num != 32U && num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, MulMapTravelTaskRewardResponse._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040061D3 RID: 25043
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061D4 RID: 25044
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040061D5 RID: 25045
		private ErrorCode errorCode_;

		// Token: 0x040061D6 RID: 25046
		public const int TaskIdFieldNumber = 4;

		// Token: 0x040061D7 RID: 25047
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040061D8 RID: 25048
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
