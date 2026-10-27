using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000910 RID: 2320
	[NetMessage(EMessageId.LevelPlaySwitchSportModeResponse)]
	public sealed class LevelPlaySwitchSportModeResponse : IMessage<LevelPlaySwitchSportModeResponse>, IMessage, IEquatable<LevelPlaySwitchSportModeResponse>, IDeepCloneable<LevelPlaySwitchSportModeResponse>, IBufferMessage
	{
		// Token: 0x0600CCD0 RID: 52432 RVA: 0x001E3053 File Offset: 0x001E1253
		[NullableContext(1)]
		public static LevelPlaySwitchSportModeResponse Create()
		{
			return new LevelPlaySwitchSportModeResponse();
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x001E305A File Offset: 0x001E125A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x001E305D File Offset: 0x001E125D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlaySwitchSportModeResponse.Descriptor;
			}
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x001E3064 File Offset: 0x001E1264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse()
		{
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x001E306C File Offset: 0x001E126C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse(LevelPlaySwitchSportModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x001E3091 File Offset: 0x001E1291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeResponse Clone()
		{
			return new LevelPlaySwitchSportModeResponse(this);
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x001E3099 File Offset: 0x001E1299
		// (set) Token: 0x0600CCD7 RID: 52439 RVA: 0x001E30A1 File Offset: 0x001E12A1
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

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x001E30AA File Offset: 0x001E12AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlaySwitchSportModeResponse);
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x001E30B8 File Offset: 0x001E12B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlaySwitchSportModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x001E30E8 File Offset: 0x001E12E8
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

		// Token: 0x0600CCDB RID: 52443 RVA: 0x001E312D File Offset: 0x001E132D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x001E313A File Offset: 0x001E133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x001E3143 File Offset: 0x001E1343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600CCDE RID: 52446 RVA: 0x001E3178 File Offset: 0x001E1378
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

		// Token: 0x0600CCDF RID: 52447 RVA: 0x001E31B6 File Offset: 0x001E13B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlaySwitchSportModeResponse other)
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

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x001E31E7 File Offset: 0x001E13E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x001E31F0 File Offset: 0x001E13F0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056CB RID: 22219
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056CC RID: 22220
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040056CD RID: 22221
		private ErrorCode errorCode_;
	}
}
