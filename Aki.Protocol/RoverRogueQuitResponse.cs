using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001150 RID: 4432
	[NetMessage(EMessageId.RoverRogueQuitResponse)]
	public sealed class RoverRogueQuitResponse : IMessage<RoverRogueQuitResponse>, IMessage, IEquatable<RoverRogueQuitResponse>, IDeepCloneable<RoverRogueQuitResponse>, IBufferMessage
	{
		// Token: 0x06017ADF RID: 96991 RVA: 0x00372379 File Offset: 0x00370579
		[NullableContext(1)]
		public static RoverRogueQuitResponse Create()
		{
			return new RoverRogueQuitResponse();
		}

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x06017AE0 RID: 96992 RVA: 0x00372380 File Offset: 0x00370580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x06017AE1 RID: 96993 RVA: 0x00372383 File Offset: 0x00370583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueQuitResponse.Descriptor;
			}
		}

		// Token: 0x06017AE2 RID: 96994 RVA: 0x0037238A File Offset: 0x0037058A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse()
		{
		}

		// Token: 0x06017AE3 RID: 96995 RVA: 0x00372392 File Offset: 0x00370592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse(RoverRogueQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AE4 RID: 96996 RVA: 0x003723B7 File Offset: 0x003705B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitResponse Clone()
		{
			return new RoverRogueQuitResponse(this);
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x06017AE5 RID: 96997 RVA: 0x003723BF File Offset: 0x003705BF
		// (set) Token: 0x06017AE6 RID: 96998 RVA: 0x003723C7 File Offset: 0x003705C7
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

		// Token: 0x06017AE7 RID: 96999 RVA: 0x003723D0 File Offset: 0x003705D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueQuitResponse);
		}

		// Token: 0x06017AE8 RID: 97000 RVA: 0x003723DE File Offset: 0x003705DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AE9 RID: 97001 RVA: 0x0037240C File Offset: 0x0037060C
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

		// Token: 0x06017AEA RID: 97002 RVA: 0x00372451 File Offset: 0x00370651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AEB RID: 97003 RVA: 0x0037245E File Offset: 0x0037065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AEC RID: 97004 RVA: 0x00372467 File Offset: 0x00370667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06017AED RID: 97005 RVA: 0x0037249C File Offset: 0x0037069C
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

		// Token: 0x06017AEE RID: 97006 RVA: 0x003724DA File Offset: 0x003706DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueQuitResponse other)
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

		// Token: 0x06017AEF RID: 97007 RVA: 0x0037250B File Offset: 0x0037070B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017AF0 RID: 97008 RVA: 0x00372514 File Offset: 0x00370714
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D4A RID: 36170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D4B RID: 36171
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04008D4C RID: 36172
		private ErrorCode errorCode_;
	}
}
