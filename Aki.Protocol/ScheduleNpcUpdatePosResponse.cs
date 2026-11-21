using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D1 RID: 4561
	[NetMessage(EMessageId.ScheduleNpcUpdatePosResponse)]
	public sealed class ScheduleNpcUpdatePosResponse : IMessage<ScheduleNpcUpdatePosResponse>, IMessage, IEquatable<ScheduleNpcUpdatePosResponse>, IDeepCloneable<ScheduleNpcUpdatePosResponse>, IBufferMessage
	{
		// Token: 0x0601859A RID: 99738 RVA: 0x0038B6D4 File Offset: 0x003898D4
		[NullableContext(1)]
		public static ScheduleNpcUpdatePosResponse Create()
		{
			return new ScheduleNpcUpdatePosResponse();
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x0601859B RID: 99739 RVA: 0x0038B6DB File Offset: 0x003898DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x0601859C RID: 99740 RVA: 0x0038B6DE File Offset: 0x003898DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleNpcUpdatePosResponse.Descriptor;
			}
		}

		// Token: 0x0601859D RID: 99741 RVA: 0x0038B6E5 File Offset: 0x003898E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse()
		{
		}

		// Token: 0x0601859E RID: 99742 RVA: 0x0038B6ED File Offset: 0x003898ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse(ScheduleNpcUpdatePosResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601859F RID: 99743 RVA: 0x0038B712 File Offset: 0x00389912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse Clone()
		{
			return new ScheduleNpcUpdatePosResponse(this);
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x060185A0 RID: 99744 RVA: 0x0038B71A File Offset: 0x0038991A
		// (set) Token: 0x060185A1 RID: 99745 RVA: 0x0038B722 File Offset: 0x00389922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060185A2 RID: 99746 RVA: 0x0038B72B File Offset: 0x0038992B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleNpcUpdatePosResponse);
		}

		// Token: 0x060185A3 RID: 99747 RVA: 0x0038B739 File Offset: 0x00389939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleNpcUpdatePosResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185A4 RID: 99748 RVA: 0x0038B768 File Offset: 0x00389968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185A5 RID: 99749 RVA: 0x0038B7AD File Offset: 0x003899AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185A6 RID: 99750 RVA: 0x0038B7BA File Offset: 0x003899BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185A7 RID: 99751 RVA: 0x0038B7C3 File Offset: 0x003899C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185A8 RID: 99752 RVA: 0x0038B7F8 File Offset: 0x003899F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x0038B836 File Offset: 0x00389A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleNpcUpdatePosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185AA RID: 99754 RVA: 0x0038B867 File Offset: 0x00389A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185AB RID: 99755 RVA: 0x0038B870 File Offset: 0x00389A70
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040090B6 RID: 37046
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090B7 RID: 37047
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x040090B8 RID: 37048
		private ErrorCode errCode_;
	}
}
