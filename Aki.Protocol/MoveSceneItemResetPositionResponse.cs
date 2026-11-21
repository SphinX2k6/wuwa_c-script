using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB3 RID: 2739
	[NetMessage(EMessageId.MoveSceneItemResetPositionResponse)]
	public sealed class MoveSceneItemResetPositionResponse : IMessage<MoveSceneItemResetPositionResponse>, IMessage, IEquatable<MoveSceneItemResetPositionResponse>, IDeepCloneable<MoveSceneItemResetPositionResponse>, IBufferMessage
	{
		// Token: 0x0600EECF RID: 61135 RVA: 0x0022E9F2 File Offset: 0x0022CBF2
		[NullableContext(1)]
		public static MoveSceneItemResetPositionResponse Create()
		{
			return new MoveSceneItemResetPositionResponse();
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600EED0 RID: 61136 RVA: 0x0022E9F9 File Offset: 0x0022CBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x0022E9FC File Offset: 0x0022CBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemResetPositionResponse.Descriptor;
			}
		}

		// Token: 0x0600EED2 RID: 61138 RVA: 0x0022EA03 File Offset: 0x0022CC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse()
		{
		}

		// Token: 0x0600EED3 RID: 61139 RVA: 0x0022EA0B File Offset: 0x0022CC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse(MoveSceneItemResetPositionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EED4 RID: 61140 RVA: 0x0022EA30 File Offset: 0x0022CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionResponse Clone()
		{
			return new MoveSceneItemResetPositionResponse(this);
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600EED5 RID: 61141 RVA: 0x0022EA38 File Offset: 0x0022CC38
		// (set) Token: 0x0600EED6 RID: 61142 RVA: 0x0022EA40 File Offset: 0x0022CC40
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

		// Token: 0x0600EED7 RID: 61143 RVA: 0x0022EA49 File Offset: 0x0022CC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemResetPositionResponse);
		}

		// Token: 0x0600EED8 RID: 61144 RVA: 0x0022EA57 File Offset: 0x0022CC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemResetPositionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EED9 RID: 61145 RVA: 0x0022EA88 File Offset: 0x0022CC88
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

		// Token: 0x0600EEDA RID: 61146 RVA: 0x0022EACD File Offset: 0x0022CCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEDB RID: 61147 RVA: 0x0022EADA File Offset: 0x0022CCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EEDC RID: 61148 RVA: 0x0022EAE3 File Offset: 0x0022CCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600EEDD RID: 61149 RVA: 0x0022EB18 File Offset: 0x0022CD18
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

		// Token: 0x0600EEDE RID: 61150 RVA: 0x0022EB56 File Offset: 0x0022CD56
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

		// Token: 0x0600EEDF RID: 61151 RVA: 0x0022EB87 File Offset: 0x0022CD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEE0 RID: 61152 RVA: 0x0022EB90 File Offset: 0x0022CD90
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400610A RID: 24842
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400610B RID: 24843
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400610C RID: 24844
		private ErrorCode errorCode_;
	}
}
