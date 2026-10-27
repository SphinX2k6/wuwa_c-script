using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001197 RID: 4503
	[NetMessage(EMessageId.ScheduleNpcUpdatePosResponse)]
	public sealed class ScheduleNpcUpdatePosResponse : IMessage<ScheduleNpcUpdatePosResponse>, IMessage, IEquatable<ScheduleNpcUpdatePosResponse>, IDeepCloneable<ScheduleNpcUpdatePosResponse>, IBufferMessage
	{
		// Token: 0x06017FF9 RID: 98297 RVA: 0x0037C394 File Offset: 0x0037A594
		[NullableContext(1)]
		public static ScheduleNpcUpdatePosResponse Create()
		{
			return new ScheduleNpcUpdatePosResponse();
		}

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x06017FFA RID: 98298 RVA: 0x0037C39B File Offset: 0x0037A59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x06017FFB RID: 98299 RVA: 0x0037C39E File Offset: 0x0037A59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleNpcUpdatePosResponse.Descriptor;
			}
		}

		// Token: 0x06017FFC RID: 98300 RVA: 0x0037C3A5 File Offset: 0x0037A5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse()
		{
		}

		// Token: 0x06017FFD RID: 98301 RVA: 0x0037C3AD File Offset: 0x0037A5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse(ScheduleNpcUpdatePosResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FFE RID: 98302 RVA: 0x0037C3D2 File Offset: 0x0037A5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosResponse Clone()
		{
			return new ScheduleNpcUpdatePosResponse(this);
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x06017FFF RID: 98303 RVA: 0x0037C3DA File Offset: 0x0037A5DA
		// (set) Token: 0x06018000 RID: 98304 RVA: 0x0037C3E2 File Offset: 0x0037A5E2
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

		// Token: 0x06018001 RID: 98305 RVA: 0x0037C3EB File Offset: 0x0037A5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleNpcUpdatePosResponse);
		}

		// Token: 0x06018002 RID: 98306 RVA: 0x0037C3F9 File Offset: 0x0037A5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleNpcUpdatePosResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018003 RID: 98307 RVA: 0x0037C428 File Offset: 0x0037A628
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

		// Token: 0x06018004 RID: 98308 RVA: 0x0037C46D File Offset: 0x0037A66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018005 RID: 98309 RVA: 0x0037C47A File Offset: 0x0037A67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018006 RID: 98310 RVA: 0x0037C483 File Offset: 0x0037A683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018007 RID: 98311 RVA: 0x0037C4B8 File Offset: 0x0037A6B8
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

		// Token: 0x06018008 RID: 98312 RVA: 0x0037C4F6 File Offset: 0x0037A6F6
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

		// Token: 0x06018009 RID: 98313 RVA: 0x0037C527 File Offset: 0x0037A727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601800A RID: 98314 RVA: 0x0037C530 File Offset: 0x0037A730
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E23 RID: 36387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E24 RID: 36388
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04008E25 RID: 36389
		private ErrorCode errCode_;
	}
}
