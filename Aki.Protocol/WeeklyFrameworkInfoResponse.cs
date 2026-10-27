using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150C RID: 5388
	[NetMessage(EMessageId.WeeklyFrameworkInfoResponse)]
	public sealed class WeeklyFrameworkInfoResponse : IMessage<WeeklyFrameworkInfoResponse>, IMessage, IEquatable<WeeklyFrameworkInfoResponse>, IDeepCloneable<WeeklyFrameworkInfoResponse>, IBufferMessage
	{
		// Token: 0x0601C7A3 RID: 116643 RVA: 0x0041CEF6 File Offset: 0x0041B0F6
		[NullableContext(1)]
		public static WeeklyFrameworkInfoResponse Create()
		{
			return new WeeklyFrameworkInfoResponse();
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x0601C7A4 RID: 116644 RVA: 0x0041CEFD File Offset: 0x0041B0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x0601C7A5 RID: 116645 RVA: 0x0041CF00 File Offset: 0x0041B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601C7A6 RID: 116646 RVA: 0x0041CF07 File Offset: 0x0041B107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse()
		{
		}

		// Token: 0x0601C7A7 RID: 116647 RVA: 0x0041CF10 File Offset: 0x0041B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse(WeeklyFrameworkInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.frameworkInfo_ = ((other.frameworkInfo_ != null) ? other.frameworkInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7A8 RID: 116648 RVA: 0x0041CF5C File Offset: 0x0041B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoResponse Clone()
		{
			return new WeeklyFrameworkInfoResponse(this);
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x0601C7A9 RID: 116649 RVA: 0x0041CF64 File Offset: 0x0041B164
		// (set) Token: 0x0601C7AA RID: 116650 RVA: 0x0041CF6C File Offset: 0x0041B16C
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

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x0601C7AB RID: 116651 RVA: 0x0041CF75 File Offset: 0x0041B175
		// (set) Token: 0x0601C7AC RID: 116652 RVA: 0x0041CF7D File Offset: 0x0041B17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo FrameworkInfo
		{
			get
			{
				return this.frameworkInfo_;
			}
			set
			{
				this.frameworkInfo_ = value;
			}
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x0041CF86 File Offset: 0x0041B186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoResponse);
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x0041CF94 File Offset: 0x0041B194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FrameworkInfo, other.FrameworkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x0041CFE4 File Offset: 0x0041B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.frameworkInfo_ != null)
			{
				num ^= this.FrameworkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7B0 RID: 116656 RVA: 0x0041D03F File Offset: 0x0041B23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7B1 RID: 116657 RVA: 0x0041D04C File Offset: 0x0041B24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7B2 RID: 116658 RVA: 0x0041D058 File Offset: 0x0041B258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.frameworkInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7B3 RID: 116659 RVA: 0x0041D0B4 File Offset: 0x0041B2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.frameworkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7B4 RID: 116660 RVA: 0x0041D10C File Offset: 0x0041B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.frameworkInfo_ != null)
			{
				if (this.frameworkInfo_ == null)
				{
					this.FrameworkInfo = new WeeklyFrameworkInfo();
				}
				this.FrameworkInfo.MergeFrom(other.FrameworkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7B5 RID: 116661 RVA: 0x0041D174 File Offset: 0x0041B374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7B6 RID: 116662 RVA: 0x0041D180 File Offset: 0x0041B380
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
				if (num != 24U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.frameworkInfo_ == null)
						{
							this.FrameworkInfo = new WeeklyFrameworkInfo();
						}
						input.ReadMessage(this.FrameworkInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A300 RID: 41728
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A301 RID: 41729
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A302 RID: 41730
		private ErrorCode errorCode_;

		// Token: 0x0400A303 RID: 41731
		public const int FrameworkInfoFieldNumber = 5;

		// Token: 0x0400A304 RID: 41732
		private WeeklyFrameworkInfo frameworkInfo_;
	}
}
