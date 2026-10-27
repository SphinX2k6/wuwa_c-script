using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F00 RID: 3840
	[NetMessage(EMessageId.RemoveInstanceTimerResponse)]
	public sealed class RemoveInstanceTimerResponse : IMessage<RemoveInstanceTimerResponse>, IMessage, IEquatable<RemoveInstanceTimerResponse>, IDeepCloneable<RemoveInstanceTimerResponse>, IBufferMessage
	{
		// Token: 0x06014922 RID: 84258 RVA: 0x002FCF21 File Offset: 0x002FB121
		[NullableContext(1)]
		public static RemoveInstanceTimerResponse Create()
		{
			return new RemoveInstanceTimerResponse();
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x06014923 RID: 84259 RVA: 0x002FCF28 File Offset: 0x002FB128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x06014924 RID: 84260 RVA: 0x002FCF2B File Offset: 0x002FB12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerResponse.Descriptor;
			}
		}

		// Token: 0x06014925 RID: 84261 RVA: 0x002FCF32 File Offset: 0x002FB132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse()
		{
		}

		// Token: 0x06014926 RID: 84262 RVA: 0x002FCF3A File Offset: 0x002FB13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse(RemoveInstanceTimerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014927 RID: 84263 RVA: 0x002FCF6B File Offset: 0x002FB16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse Clone()
		{
			return new RemoveInstanceTimerResponse(this);
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x06014928 RID: 84264 RVA: 0x002FCF73 File Offset: 0x002FB173
		// (set) Token: 0x06014929 RID: 84265 RVA: 0x002FCF7B File Offset: 0x002FB17B
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

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x0601492A RID: 84266 RVA: 0x002FCF84 File Offset: 0x002FB184
		// (set) Token: 0x0601492B RID: 84267 RVA: 0x002FCF8C File Offset: 0x002FB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimerId
		{
			get
			{
				return this.timerId_;
			}
			set
			{
				this.timerId_ = value;
			}
		}

		// Token: 0x0601492C RID: 84268 RVA: 0x002FCF95 File Offset: 0x002FB195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerResponse);
		}

		// Token: 0x0601492D RID: 84269 RVA: 0x002FCFA3 File Offset: 0x002FB1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601492E RID: 84270 RVA: 0x002FCFE4 File Offset: 0x002FB1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TimerId != 0)
			{
				num ^= this.TimerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601492F RID: 84271 RVA: 0x002FD042 File Offset: 0x002FB242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014930 RID: 84272 RVA: 0x002FD04F File Offset: 0x002FB24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014931 RID: 84273 RVA: 0x002FD058 File Offset: 0x002FB258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TimerId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014932 RID: 84274 RVA: 0x002FD0B4 File Offset: 0x002FB2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TimerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014933 RID: 84275 RVA: 0x002FD10C File Offset: 0x002FB30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveInstanceTimerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TimerId != 0)
			{
				this.TimerId = other.TimerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014934 RID: 84276 RVA: 0x002FD15C File Offset: 0x002FB35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014935 RID: 84277 RVA: 0x002FD168 File Offset: 0x002FB368
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
					if (num != 96U)
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
					this.TimerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C9E RID: 31902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C9F RID: 31903
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007CA0 RID: 31904
		private ErrorCode errorCode_;

		// Token: 0x04007CA1 RID: 31905
		public const int TimerIdFieldNumber = 3;

		// Token: 0x04007CA2 RID: 31906
		private int timerId_;
	}
}
