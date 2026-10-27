using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE3 RID: 2787
	[NetMessage(EMessageId.MulMapTravelTaskRewardResponse)]
	public sealed class MulMapTravelTaskRewardResponse : IMessage<MulMapTravelTaskRewardResponse>, IMessage, IEquatable<MulMapTravelTaskRewardResponse>, IDeepCloneable<MulMapTravelTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F269 RID: 62057 RVA: 0x002363A1 File Offset: 0x002345A1
		[NullableContext(1)]
		public static MulMapTravelTaskRewardResponse Create()
		{
			return new MulMapTravelTaskRewardResponse();
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600F26A RID: 62058 RVA: 0x002363A8 File Offset: 0x002345A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600F26B RID: 62059 RVA: 0x002363AB File Offset: 0x002345AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x002363B2 File Offset: 0x002345B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse()
		{
		}

		// Token: 0x0600F26D RID: 62061 RVA: 0x002363C5 File Offset: 0x002345C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse(MulMapTravelTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F26E RID: 62062 RVA: 0x002363FB File Offset: 0x002345FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardResponse Clone()
		{
			return new MulMapTravelTaskRewardResponse(this);
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600F26F RID: 62063 RVA: 0x00236403 File Offset: 0x00234603
		// (set) Token: 0x0600F270 RID: 62064 RVA: 0x0023640B File Offset: 0x0023460B
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

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600F271 RID: 62065 RVA: 0x00236414 File Offset: 0x00234614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600F272 RID: 62066 RVA: 0x0023641C File Offset: 0x0023461C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelTaskRewardResponse);
		}

		// Token: 0x0600F273 RID: 62067 RVA: 0x0023642C File Offset: 0x0023462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F274 RID: 62068 RVA: 0x0023647C File Offset: 0x0023467C
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

		// Token: 0x0600F275 RID: 62069 RVA: 0x002364CF File Offset: 0x002346CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x002364DC File Offset: 0x002346DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F277 RID: 62071 RVA: 0x002364E8 File Offset: 0x002346E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskId_.WriteTo(ref output, MulMapTravelTaskRewardResponse._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F278 RID: 62072 RVA: 0x00236538 File Offset: 0x00234738
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

		// Token: 0x0600F279 RID: 62073 RVA: 0x0023658C File Offset: 0x0023478C
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

		// Token: 0x0600F27A RID: 62074 RVA: 0x002365D9 File Offset: 0x002347D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x002365E4 File Offset: 0x002347E4
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
				if (num != 8U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskId_.AddEntriesFrom(ref input, MulMapTravelTaskRewardResponse._repeated_taskId_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061CA RID: 25034
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061CB RID: 25035
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040061CC RID: 25036
		private ErrorCode errorCode_;

		// Token: 0x040061CD RID: 25037
		public const int TaskIdFieldNumber = 12;

		// Token: 0x040061CE RID: 25038
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040061CF RID: 25039
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
