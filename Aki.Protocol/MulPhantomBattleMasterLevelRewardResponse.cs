using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE5 RID: 2789
	[NetMessage(EMessageId.MulPhantomBattleMasterLevelRewardResponse)]
	public sealed class MulPhantomBattleMasterLevelRewardResponse : IMessage<MulPhantomBattleMasterLevelRewardResponse>, IMessage, IEquatable<MulPhantomBattleMasterLevelRewardResponse>, IDeepCloneable<MulPhantomBattleMasterLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F291 RID: 62097 RVA: 0x002368FC File Offset: 0x00234AFC
		[NullableContext(1)]
		public static MulPhantomBattleMasterLevelRewardResponse Create()
		{
			return new MulPhantomBattleMasterLevelRewardResponse();
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600F292 RID: 62098 RVA: 0x00236903 File Offset: 0x00234B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600F293 RID: 62099 RVA: 0x00236906 File Offset: 0x00234B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulPhantomBattleMasterLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F294 RID: 62100 RVA: 0x0023690D File Offset: 0x00234B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse()
		{
		}

		// Token: 0x0600F295 RID: 62101 RVA: 0x00236920 File Offset: 0x00234B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse(MulPhantomBattleMasterLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F296 RID: 62102 RVA: 0x00236956 File Offset: 0x00234B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulPhantomBattleMasterLevelRewardResponse Clone()
		{
			return new MulPhantomBattleMasterLevelRewardResponse(this);
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600F297 RID: 62103 RVA: 0x0023695E File Offset: 0x00234B5E
		// (set) Token: 0x0600F298 RID: 62104 RVA: 0x00236966 File Offset: 0x00234B66
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

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600F299 RID: 62105 RVA: 0x0023696F File Offset: 0x00234B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
		}

		// Token: 0x0600F29A RID: 62106 RVA: 0x00236977 File Offset: 0x00234B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulPhantomBattleMasterLevelRewardResponse);
		}

		// Token: 0x0600F29B RID: 62107 RVA: 0x00236988 File Offset: 0x00234B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulPhantomBattleMasterLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleMasterLevelId_.Equals(other.phantomBattleMasterLevelId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F29C RID: 62108 RVA: 0x002369D8 File Offset: 0x00234BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleMasterLevelId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F29D RID: 62109 RVA: 0x00236A2B File Offset: 0x00234C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F29E RID: 62110 RVA: 0x00236A38 File Offset: 0x00234C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F29F RID: 62111 RVA: 0x00236A44 File Offset: 0x00234C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleMasterLevelId_.WriteTo(ref output, MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2A0 RID: 62112 RVA: 0x00236A94 File Offset: 0x00234C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleMasterLevelId_.CalculateSize(MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2A1 RID: 62113 RVA: 0x00236AE8 File Offset: 0x00234CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulPhantomBattleMasterLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleMasterLevelId_.Add(other.phantomBattleMasterLevelId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2A2 RID: 62114 RVA: 0x00236B35 File Offset: 0x00234D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2A3 RID: 62115 RVA: 0x00236B40 File Offset: 0x00234D40
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
				if (num != 8U && num != 10U)
				{
					if (num != 24U)
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
					this.phantomBattleMasterLevelId_.AddEntriesFrom(ref input, MulPhantomBattleMasterLevelRewardResponse._repeated_phantomBattleMasterLevelId_codec);
				}
			}
		}

		// Token: 0x040061D6 RID: 25046
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061D7 RID: 25047
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040061D8 RID: 25048
		private ErrorCode errorCode_;

		// Token: 0x040061D9 RID: 25049
		public const int PhantomBattleMasterLevelIdFieldNumber = 1;

		// Token: 0x040061DA RID: 25050
		private static readonly FieldCodec<int> _repeated_phantomBattleMasterLevelId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040061DB RID: 25051
		private readonly RepeatedField<int> phantomBattleMasterLevelId_ = new RepeatedField<int>();
	}
}
