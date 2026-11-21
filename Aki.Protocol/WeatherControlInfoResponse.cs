using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001573 RID: 5491
	[NetMessage(EMessageId.WeatherControlInfoResponse)]
	public sealed class WeatherControlInfoResponse : IMessage<WeatherControlInfoResponse>, IMessage, IEquatable<WeatherControlInfoResponse>, IDeepCloneable<WeatherControlInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D137 RID: 119095 RVA: 0x0043603A File Offset: 0x0043423A
		[NullableContext(1)]
		public static WeatherControlInfoResponse Create()
		{
			return new WeatherControlInfoResponse();
		}

		// Token: 0x17006260 RID: 25184
		// (get) Token: 0x0601D138 RID: 119096 RVA: 0x00436041 File Offset: 0x00434241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006261 RID: 25185
		// (get) Token: 0x0601D139 RID: 119097 RVA: 0x00436044 File Offset: 0x00434244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D13A RID: 119098 RVA: 0x0043604B File Offset: 0x0043424B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse()
		{
		}

		// Token: 0x0601D13B RID: 119099 RVA: 0x00436060 File Offset: 0x00434260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse(WeatherControlInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unlockedSwitchIds_ = other.unlockedSwitchIds_.Clone();
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D13C RID: 119100 RVA: 0x004360AD File Offset: 0x004342AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse Clone()
		{
			return new WeatherControlInfoResponse(this);
		}

		// Token: 0x17006262 RID: 25186
		// (get) Token: 0x0601D13D RID: 119101 RVA: 0x004360B5 File Offset: 0x004342B5
		// (set) Token: 0x0601D13E RID: 119102 RVA: 0x004360BD File Offset: 0x004342BD
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

		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x0601D13F RID: 119103 RVA: 0x004360C6 File Offset: 0x004342C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedSwitchIds
		{
			get
			{
				return this.unlockedSwitchIds_;
			}
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x0601D140 RID: 119104 RVA: 0x004360CE File Offset: 0x004342CE
		// (set) Token: 0x0601D141 RID: 119105 RVA: 0x004360D6 File Offset: 0x004342D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601D142 RID: 119106 RVA: 0x004360DF File Offset: 0x004342DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlInfoResponse);
		}

		// Token: 0x0601D143 RID: 119107 RVA: 0x004360F0 File Offset: 0x004342F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.unlockedSwitchIds_.Equals(other.unlockedSwitchIds_) && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D144 RID: 119108 RVA: 0x00436150 File Offset: 0x00434350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.unlockedSwitchIds_.GetHashCode();
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D145 RID: 119109 RVA: 0x004361BC File Offset: 0x004343BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D146 RID: 119110 RVA: 0x004361C9 File Offset: 0x004343C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x004361D4 File Offset: 0x004343D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedSwitchIds_.WriteTo(ref output, WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this.IncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.IncId);
			}
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

		// Token: 0x0601D148 RID: 119112 RVA: 0x00436240 File Offset: 0x00434440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.unlockedSwitchIds_.CalculateSize(WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x004362AC File Offset: 0x004344AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.unlockedSwitchIds_.Add(other.unlockedSwitchIds_);
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x0043630D File Offset: 0x0043450D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D14B RID: 119115 RVA: 0x00436318 File Offset: 0x00434518
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
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.unlockedSwitchIds_.AddEntriesFrom(ref input, WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.IncId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A6FE RID: 42750
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6FF RID: 42751
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400A700 RID: 42752
		private ErrorCode errorCode_;

		// Token: 0x0400A701 RID: 42753
		public const int UnlockedSwitchIdsFieldNumber = 5;

		// Token: 0x0400A702 RID: 42754
		private static readonly FieldCodec<int> _repeated_unlockedSwitchIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A703 RID: 42755
		private readonly RepeatedField<int> unlockedSwitchIds_ = new RepeatedField<int>();

		// Token: 0x0400A704 RID: 42756
		public const int IncIdFieldNumber = 10;

		// Token: 0x0400A705 RID: 42757
		private long incId_;
	}
}
