using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A00 RID: 2560
	[NetMessage(EMessageId.MoonPhaseRandomResponse)]
	public sealed class MoonPhaseRandomResponse : IMessage<MoonPhaseRandomResponse>, IMessage, IEquatable<MoonPhaseRandomResponse>, IDeepCloneable<MoonPhaseRandomResponse>, IBufferMessage
	{
		// Token: 0x0600E054 RID: 57428 RVA: 0x0020E31A File Offset: 0x0020C51A
		[NullableContext(1)]
		public static MoonPhaseRandomResponse Create()
		{
			return new MoonPhaseRandomResponse();
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600E055 RID: 57429 RVA: 0x0020E321 File Offset: 0x0020C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0600E056 RID: 57430 RVA: 0x0020E324 File Offset: 0x0020C524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRandomResponse.Descriptor;
			}
		}

		// Token: 0x0600E057 RID: 57431 RVA: 0x0020E32B File Offset: 0x0020C52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse()
		{
		}

		// Token: 0x0600E058 RID: 57432 RVA: 0x0020E334 File Offset: 0x0020C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse(MoonPhaseRandomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x0020E380 File Offset: 0x0020C580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRandomResponse Clone()
		{
			return new MoonPhaseRandomResponse(this);
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600E05A RID: 57434 RVA: 0x0020E388 File Offset: 0x0020C588
		// (set) Token: 0x0600E05B RID: 57435 RVA: 0x0020E390 File Offset: 0x0020C590
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

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x0020E399 File Offset: 0x0020C599
		// (set) Token: 0x0600E05D RID: 57437 RVA: 0x0020E3A1 File Offset: 0x0020C5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600E05E RID: 57438 RVA: 0x0020E3AA File Offset: 0x0020C5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRandomResponse);
		}

		// Token: 0x0600E05F RID: 57439 RVA: 0x0020E3B8 File Offset: 0x0020C5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRandomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x0020E408 File Offset: 0x0020C608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E061 RID: 57441 RVA: 0x0020E463 File Offset: 0x0020C663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E062 RID: 57442 RVA: 0x0020E470 File Offset: 0x0020C670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E063 RID: 57443 RVA: 0x0020E47C File Offset: 0x0020C67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Result);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E064 RID: 57444 RVA: 0x0020E4D8 File Offset: 0x0020C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x0020E530 File Offset: 0x0020C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRandomResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MoonPhaseSelect();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x0020E598 File Offset: 0x0020C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x0020E5A4 File Offset: 0x0020C7A4
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
				if (num != 66U)
				{
					if (num != 112U)
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
					if (this.result_ == null)
					{
						this.Result = new MoonPhaseSelect();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04005CB1 RID: 23729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CB2 RID: 23730
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005CB3 RID: 23731
		private ErrorCode errorCode_;

		// Token: 0x04005CB4 RID: 23732
		public const int ResultFieldNumber = 8;

		// Token: 0x04005CB5 RID: 23733
		private MoonPhaseSelect result_;
	}
}
