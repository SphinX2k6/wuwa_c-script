using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF0 RID: 3824
	[NetMessage(EMessageId.RemoveInstanceTimerResponse)]
	public sealed class RemoveInstanceTimerResponse : IMessage<RemoveInstanceTimerResponse>, IMessage, IEquatable<RemoveInstanceTimerResponse>, IDeepCloneable<RemoveInstanceTimerResponse>, IBufferMessage
	{
		// Token: 0x0601483D RID: 84029 RVA: 0x002FB865 File Offset: 0x002F9A65
		[NullableContext(1)]
		public static RemoveInstanceTimerResponse Create()
		{
			return new RemoveInstanceTimerResponse();
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0601483E RID: 84030 RVA: 0x002FB86C File Offset: 0x002F9A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0601483F RID: 84031 RVA: 0x002FB86F File Offset: 0x002F9A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveInstanceTimerResponse.Descriptor;
			}
		}

		// Token: 0x06014840 RID: 84032 RVA: 0x002FB876 File Offset: 0x002F9A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse()
		{
		}

		// Token: 0x06014841 RID: 84033 RVA: 0x002FB87E File Offset: 0x002F9A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse(RemoveInstanceTimerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.timerId_ = other.timerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014842 RID: 84034 RVA: 0x002FB8AF File Offset: 0x002F9AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveInstanceTimerResponse Clone()
		{
			return new RemoveInstanceTimerResponse(this);
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x06014843 RID: 84035 RVA: 0x002FB8B7 File Offset: 0x002F9AB7
		// (set) Token: 0x06014844 RID: 84036 RVA: 0x002FB8BF File Offset: 0x002F9ABF
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

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x06014845 RID: 84037 RVA: 0x002FB8C8 File Offset: 0x002F9AC8
		// (set) Token: 0x06014846 RID: 84038 RVA: 0x002FB8D0 File Offset: 0x002F9AD0
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

		// Token: 0x06014847 RID: 84039 RVA: 0x002FB8D9 File Offset: 0x002F9AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveInstanceTimerResponse);
		}

		// Token: 0x06014848 RID: 84040 RVA: 0x002FB8E7 File Offset: 0x002F9AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveInstanceTimerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TimerId == other.TimerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014849 RID: 84041 RVA: 0x002FB928 File Offset: 0x002F9B28
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

		// Token: 0x0601484A RID: 84042 RVA: 0x002FB986 File Offset: 0x002F9B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601484B RID: 84043 RVA: 0x002FB993 File Offset: 0x002F9B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601484C RID: 84044 RVA: 0x002FB99C File Offset: 0x002F9B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TimerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TimerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601484D RID: 84045 RVA: 0x002FB9F8 File Offset: 0x002F9BF8
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

		// Token: 0x0601484E RID: 84046 RVA: 0x002FBA50 File Offset: 0x002F9C50
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

		// Token: 0x0601484F RID: 84047 RVA: 0x002FBAA0 File Offset: 0x002F9CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014850 RID: 84048 RVA: 0x002FBAAC File Offset: 0x002F9CAC
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
						this.TimerId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CC8 RID: 31944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC9 RID: 31945
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007CCA RID: 31946
		private ErrorCode errorCode_;

		// Token: 0x04007CCB RID: 31947
		public const int TimerIdFieldNumber = 12;

		// Token: 0x04007CCC RID: 31948
		private int timerId_;
	}
}
