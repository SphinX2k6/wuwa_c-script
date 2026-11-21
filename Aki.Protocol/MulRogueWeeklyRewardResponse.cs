using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD8 RID: 2776
	[NetMessage(EMessageId.MulRogueWeeklyRewardResponse)]
	public sealed class MulRogueWeeklyRewardResponse : IMessage<MulRogueWeeklyRewardResponse>, IMessage, IEquatable<MulRogueWeeklyRewardResponse>, IDeepCloneable<MulRogueWeeklyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F1C7 RID: 61895 RVA: 0x002351AC File Offset: 0x002333AC
		[NullableContext(1)]
		public static MulRogueWeeklyRewardResponse Create()
		{
			return new MulRogueWeeklyRewardResponse();
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x002351B3 File Offset: 0x002333B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600F1C9 RID: 61897 RVA: 0x002351B6 File Offset: 0x002333B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRogueWeeklyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F1CA RID: 61898 RVA: 0x002351BD File Offset: 0x002333BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse()
		{
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x002351D0 File Offset: 0x002333D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse(MulRogueWeeklyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.configId_ = other.configId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x00235206 File Offset: 0x00233406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardResponse Clone()
		{
			return new MulRogueWeeklyRewardResponse(this);
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600F1CD RID: 61901 RVA: 0x0023520E File Offset: 0x0023340E
		// (set) Token: 0x0600F1CE RID: 61902 RVA: 0x00235216 File Offset: 0x00233416
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

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600F1CF RID: 61903 RVA: 0x0023521F File Offset: 0x0023341F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigId
		{
			get
			{
				return this.configId_;
			}
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x00235227 File Offset: 0x00233427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRogueWeeklyRewardResponse);
		}

		// Token: 0x0600F1D1 RID: 61905 RVA: 0x00235238 File Offset: 0x00233438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRogueWeeklyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.configId_.Equals(other.configId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1D2 RID: 61906 RVA: 0x00235288 File Offset: 0x00233488
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

		// Token: 0x0600F1D3 RID: 61907 RVA: 0x002352DB File Offset: 0x002334DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1D4 RID: 61908 RVA: 0x002352E8 File Offset: 0x002334E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1D5 RID: 61909 RVA: 0x002352F4 File Offset: 0x002334F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configId_.WriteTo(ref output, MulRogueWeeklyRewardResponse._repeated_configId_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00235344 File Offset: 0x00233544
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

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x00235398 File Offset: 0x00233598
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

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x002353E5 File Offset: 0x002335E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x002353F0 File Offset: 0x002335F0
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
				if (num != 112U && num != 114U)
				{
					if (num != 120U)
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
					this.configId_.AddEntriesFrom(ref input, MulRogueWeeklyRewardResponse._repeated_configId_codec);
				}
			}
		}

		// Token: 0x040061F7 RID: 25079
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061F8 RID: 25080
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040061F9 RID: 25081
		private ErrorCode errorCode_;

		// Token: 0x040061FA RID: 25082
		public const int ConfigIdFieldNumber = 14;

		// Token: 0x040061FB RID: 25083
		private static readonly FieldCodec<int> _repeated_configId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040061FC RID: 25084
		private readonly RepeatedField<int> configId_ = new RepeatedField<int>();
	}
}
