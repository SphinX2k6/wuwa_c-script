using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE9 RID: 2793
	[NetMessage(EMessageId.MulRogueWeeklyRewardResponse)]
	public sealed class MulRogueWeeklyRewardResponse : IMessage<MulRogueWeeklyRewardResponse>, IMessage, IEquatable<MulRogueWeeklyRewardResponse>, IDeepCloneable<MulRogueWeeklyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F2E1 RID: 62177 RVA: 0x002373B4 File Offset: 0x002355B4
		[NullableContext(1)]
		public static MulRogueWeeklyRewardResponse Create()
		{
			return new MulRogueWeeklyRewardResponse();
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600F2E2 RID: 62178 RVA: 0x002373BB File Offset: 0x002355BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600F2E3 RID: 62179 RVA: 0x002373BE File Offset: 0x002355BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRogueWeeklyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x002373C5 File Offset: 0x002355C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse()
		{
		}

		// Token: 0x0600F2E5 RID: 62181 RVA: 0x002373D8 File Offset: 0x002355D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse(MulRogueWeeklyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.configId_ = other.configId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2E6 RID: 62182 RVA: 0x0023740E File Offset: 0x0023560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse Clone()
		{
			return new MulRogueWeeklyRewardResponse(this);
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600F2E7 RID: 62183 RVA: 0x00237416 File Offset: 0x00235616
		// (set) Token: 0x0600F2E8 RID: 62184 RVA: 0x0023741E File Offset: 0x0023561E
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

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600F2E9 RID: 62185 RVA: 0x00237427 File Offset: 0x00235627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigId
		{
			get
			{
				return this.configId_;
			}
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x0023742F File Offset: 0x0023562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRogueWeeklyRewardResponse);
		}

		// Token: 0x0600F2EB RID: 62187 RVA: 0x00237440 File Offset: 0x00235640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRogueWeeklyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.configId_.Equals(other.configId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2EC RID: 62188 RVA: 0x00237490 File Offset: 0x00235690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.configId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F2ED RID: 62189 RVA: 0x002374E3 File Offset: 0x002356E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2EE RID: 62190 RVA: 0x002374F0 File Offset: 0x002356F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2EF RID: 62191 RVA: 0x002374FC File Offset: 0x002356FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.configId_.WriteTo(ref output, MulRogueWeeklyRewardResponse._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2F0 RID: 62192 RVA: 0x0023754C File Offset: 0x0023574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.configId_.CalculateSize(MulRogueWeeklyRewardResponse._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x002375A0 File Offset: 0x002357A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRogueWeeklyRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.configId_.Add(other.configId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2F2 RID: 62194 RVA: 0x002375ED File Offset: 0x002357ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2F3 RID: 62195 RVA: 0x002375F8 File Offset: 0x002357F8
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
				if (num != 72U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.configId_.AddEntriesFrom(ref input, MulRogueWeeklyRewardResponse._repeated_configId_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061EE RID: 25070
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061EF RID: 25071
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040061F0 RID: 25072
		private ErrorCode errorCode_;

		// Token: 0x040061F1 RID: 25073
		public const int ConfigIdFieldNumber = 13;

		// Token: 0x040061F2 RID: 25074
		private static readonly FieldCodec<int> _repeated_configId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040061F3 RID: 25075
		private readonly RepeatedField<int> configId_ = new RepeatedField<int>();
	}
}
