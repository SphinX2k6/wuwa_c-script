using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B87 RID: 2951
	[NetMessage(EMessageId.OnlineMotorActivityLevelResponse)]
	public sealed class OnlineMotorActivityLevelResponse : IMessage<OnlineMotorActivityLevelResponse>, IMessage, IEquatable<OnlineMotorActivityLevelResponse>, IDeepCloneable<OnlineMotorActivityLevelResponse>, IBufferMessage
	{
		// Token: 0x06010065 RID: 65637 RVA: 0x00257538 File Offset: 0x00255738
		[NullableContext(1)]
		public static OnlineMotorActivityLevelResponse Create()
		{
			return new OnlineMotorActivityLevelResponse();
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x06010066 RID: 65638 RVA: 0x0025753F File Offset: 0x0025573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x06010067 RID: 65639 RVA: 0x00257542 File Offset: 0x00255742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityLevelResponse.Descriptor;
			}
		}

		// Token: 0x06010068 RID: 65640 RVA: 0x00257549 File Offset: 0x00255749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse()
		{
		}

		// Token: 0x06010069 RID: 65641 RVA: 0x00257551 File Offset: 0x00255751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse(OnlineMotorActivityLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601006A RID: 65642 RVA: 0x00257576 File Offset: 0x00255776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityLevelResponse Clone()
		{
			return new OnlineMotorActivityLevelResponse(this);
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0601006B RID: 65643 RVA: 0x0025757E File Offset: 0x0025577E
		// (set) Token: 0x0601006C RID: 65644 RVA: 0x00257586 File Offset: 0x00255786
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

		// Token: 0x0601006D RID: 65645 RVA: 0x0025758F File Offset: 0x0025578F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityLevelResponse);
		}

		// Token: 0x0601006E RID: 65646 RVA: 0x0025759D File Offset: 0x0025579D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601006F RID: 65647 RVA: 0x002575CC File Offset: 0x002557CC
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

		// Token: 0x06010070 RID: 65648 RVA: 0x00257611 File Offset: 0x00255811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010071 RID: 65649 RVA: 0x0025761E File Offset: 0x0025581E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010072 RID: 65650 RVA: 0x00257627 File Offset: 0x00255827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06010073 RID: 65651 RVA: 0x0025765C File Offset: 0x0025585C
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

		// Token: 0x06010074 RID: 65652 RVA: 0x0025769A File Offset: 0x0025589A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorActivityLevelResponse other)
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

		// Token: 0x06010075 RID: 65653 RVA: 0x002576CB File Offset: 0x002558CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010076 RID: 65654 RVA: 0x002576D4 File Offset: 0x002558D4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040066A5 RID: 26277
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066A6 RID: 26278
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040066A7 RID: 26279
		private ErrorCode errorCode_;
	}
}
