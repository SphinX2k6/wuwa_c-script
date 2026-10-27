using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD7 RID: 2775
	[NetMessage(EMessageId.MulCalabashLevelRewardResponse)]
	public sealed class MulCalabashLevelRewardResponse : IMessage<MulCalabashLevelRewardResponse>, IMessage, IEquatable<MulCalabashLevelRewardResponse>, IDeepCloneable<MulCalabashLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F185 RID: 61829 RVA: 0x00234809 File Offset: 0x00232A09
		[NullableContext(1)]
		public static MulCalabashLevelRewardResponse Create()
		{
			return new MulCalabashLevelRewardResponse();
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600F186 RID: 61830 RVA: 0x00234810 File Offset: 0x00232A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600F187 RID: 61831 RVA: 0x00234813 File Offset: 0x00232A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCalabashLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F188 RID: 61832 RVA: 0x0023481A File Offset: 0x00232A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse()
		{
		}

		// Token: 0x0600F189 RID: 61833 RVA: 0x0023482D File Offset: 0x00232A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse(MulCalabashLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F18A RID: 61834 RVA: 0x00234863 File Offset: 0x00232A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardResponse Clone()
		{
			return new MulCalabashLevelRewardResponse(this);
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600F18B RID: 61835 RVA: 0x0023486B File Offset: 0x00232A6B
		// (set) Token: 0x0600F18C RID: 61836 RVA: 0x00234873 File Offset: 0x00232A73
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

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600F18D RID: 61837 RVA: 0x0023487C File Offset: 0x00232A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F18E RID: 61838 RVA: 0x00234884 File Offset: 0x00232A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCalabashLevelRewardResponse);
		}

		// Token: 0x0600F18F RID: 61839 RVA: 0x00234894 File Offset: 0x00232A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCalabashLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x002348E4 File Offset: 0x00232AE4
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

		// Token: 0x0600F191 RID: 61841 RVA: 0x00234937 File Offset: 0x00232B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F192 RID: 61842 RVA: 0x00234944 File Offset: 0x00232B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F193 RID: 61843 RVA: 0x00234950 File Offset: 0x00232B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.level_.WriteTo(ref output, MulCalabashLevelRewardResponse._repeated_level_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F194 RID: 61844 RVA: 0x002349A0 File Offset: 0x00232BA0
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

		// Token: 0x0600F195 RID: 61845 RVA: 0x002349F4 File Offset: 0x00232BF4
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

		// Token: 0x0600F196 RID: 61846 RVA: 0x00234A41 File Offset: 0x00232C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F197 RID: 61847 RVA: 0x00234A4C File Offset: 0x00232C4C
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
				if (num != 48U && num != 50U)
				{
					if (num != 80U)
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
					this.level_.AddEntriesFrom(ref input, MulCalabashLevelRewardResponse._repeated_level_codec);
				}
			}
		}

		// Token: 0x0400618F RID: 24975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006190 RID: 24976
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006191 RID: 24977
		private ErrorCode errorCode_;

		// Token: 0x04006192 RID: 24978
		public const int LevelFieldNumber = 6;

		// Token: 0x04006193 RID: 24979
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006194 RID: 24980
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
