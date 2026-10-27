using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC4 RID: 2756
	[NetMessage(EMessageId.MoveSceneItemResetPositionResponse)]
	public sealed class MoveSceneItemResetPositionResponse : IMessage<MoveSceneItemResetPositionResponse>, IMessage, IEquatable<MoveSceneItemResetPositionResponse>, IDeepCloneable<MoveSceneItemResetPositionResponse>, IBufferMessage
	{
		// Token: 0x0600EFE9 RID: 61417 RVA: 0x00230BFB File Offset: 0x0022EDFB
		[NullableContext(1)]
		public static MoveSceneItemResetPositionResponse Create()
		{
			return new MoveSceneItemResetPositionResponse();
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600EFEA RID: 61418 RVA: 0x00230C02 File Offset: 0x0022EE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600EFEB RID: 61419 RVA: 0x00230C05 File Offset: 0x0022EE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemResetPositionResponse.Descriptor;
			}
		}

		// Token: 0x0600EFEC RID: 61420 RVA: 0x00230C0C File Offset: 0x0022EE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse()
		{
		}

		// Token: 0x0600EFED RID: 61421 RVA: 0x00230C14 File Offset: 0x0022EE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse(MoveSceneItemResetPositionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFEE RID: 61422 RVA: 0x00230C39 File Offset: 0x0022EE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse Clone()
		{
			return new MoveSceneItemResetPositionResponse(this);
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600EFEF RID: 61423 RVA: 0x00230C41 File Offset: 0x0022EE41
		// (set) Token: 0x0600EFF0 RID: 61424 RVA: 0x00230C49 File Offset: 0x0022EE49
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

		// Token: 0x0600EFF1 RID: 61425 RVA: 0x00230C52 File Offset: 0x0022EE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemResetPositionResponse);
		}

		// Token: 0x0600EFF2 RID: 61426 RVA: 0x00230C60 File Offset: 0x0022EE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemResetPositionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFF3 RID: 61427 RVA: 0x00230C90 File Offset: 0x0022EE90
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

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x00230CD5 File Offset: 0x0022EED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFF5 RID: 61429 RVA: 0x00230CE2 File Offset: 0x0022EEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFF6 RID: 61430 RVA: 0x00230CEB File Offset: 0x0022EEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFF7 RID: 61431 RVA: 0x00230D20 File Offset: 0x0022EF20
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

		// Token: 0x0600EFF8 RID: 61432 RVA: 0x00230D5E File Offset: 0x0022EF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSceneItemResetPositionResponse other)
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

		// Token: 0x0600EFF9 RID: 61433 RVA: 0x00230D8F File Offset: 0x0022EF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFFA RID: 61434 RVA: 0x00230D98 File Offset: 0x0022EF98
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006101 RID: 24833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006102 RID: 24834
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006103 RID: 24835
		private ErrorCode errorCode_;
	}
}
