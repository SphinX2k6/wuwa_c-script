using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103A RID: 4154
	[NetMessage(EMessageId.RogueWeeklyStartResponse)]
	public sealed class RogueWeeklyStartResponse : IMessage<RogueWeeklyStartResponse>, IMessage, IEquatable<RogueWeeklyStartResponse>, IDeepCloneable<RogueWeeklyStartResponse>, IBufferMessage
	{
		// Token: 0x06016397 RID: 91031 RVA: 0x0033B14F File Offset: 0x0033934F
		[NullableContext(1)]
		public static RogueWeeklyStartResponse Create()
		{
			return new RogueWeeklyStartResponse();
		}

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x06016398 RID: 91032 RVA: 0x0033B156 File Offset: 0x00339356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x06016399 RID: 91033 RVA: 0x0033B159 File Offset: 0x00339359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyStartResponse.Descriptor;
			}
		}

		// Token: 0x0601639A RID: 91034 RVA: 0x0033B160 File Offset: 0x00339360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse()
		{
		}

		// Token: 0x0601639B RID: 91035 RVA: 0x0033B168 File Offset: 0x00339368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse(RogueWeeklyStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601639C RID: 91036 RVA: 0x0033B18D File Offset: 0x0033938D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyStartResponse Clone()
		{
			return new RogueWeeklyStartResponse(this);
		}

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x0601639D RID: 91037 RVA: 0x0033B195 File Offset: 0x00339395
		// (set) Token: 0x0601639E RID: 91038 RVA: 0x0033B19D File Offset: 0x0033939D
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

		// Token: 0x0601639F RID: 91039 RVA: 0x0033B1A6 File Offset: 0x003393A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyStartResponse);
		}

		// Token: 0x060163A0 RID: 91040 RVA: 0x0033B1B4 File Offset: 0x003393B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163A1 RID: 91041 RVA: 0x0033B1E4 File Offset: 0x003393E4
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

		// Token: 0x060163A2 RID: 91042 RVA: 0x0033B229 File Offset: 0x00339429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163A3 RID: 91043 RVA: 0x0033B236 File Offset: 0x00339436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163A4 RID: 91044 RVA: 0x0033B23F File Offset: 0x0033943F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x060163A5 RID: 91045 RVA: 0x0033B274 File Offset: 0x00339474
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

		// Token: 0x060163A6 RID: 91046 RVA: 0x0033B2B2 File Offset: 0x003394B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyStartResponse other)
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

		// Token: 0x060163A7 RID: 91047 RVA: 0x0033B2E3 File Offset: 0x003394E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x0033B2EC File Offset: 0x003394EC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008567 RID: 34151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008568 RID: 34152
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008569 RID: 34153
		private ErrorCode errorCode_;
	}
}
