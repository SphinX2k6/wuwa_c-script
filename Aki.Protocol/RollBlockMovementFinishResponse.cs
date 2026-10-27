using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E1 RID: 4321
	[NetMessage(EMessageId.RollBlockMovementFinishResponse)]
	public sealed class RollBlockMovementFinishResponse : IMessage<RollBlockMovementFinishResponse>, IMessage, IEquatable<RollBlockMovementFinishResponse>, IDeepCloneable<RollBlockMovementFinishResponse>, IBufferMessage
	{
		// Token: 0x060170CF RID: 94415 RVA: 0x003587C3 File Offset: 0x003569C3
		[NullableContext(1)]
		public static RollBlockMovementFinishResponse Create()
		{
			return new RollBlockMovementFinishResponse();
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x060170D0 RID: 94416 RVA: 0x003587CA File Offset: 0x003569CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x060170D1 RID: 94417 RVA: 0x003587CD File Offset: 0x003569CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockMovementFinishResponse.Descriptor;
			}
		}

		// Token: 0x060170D2 RID: 94418 RVA: 0x003587D4 File Offset: 0x003569D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse()
		{
		}

		// Token: 0x060170D3 RID: 94419 RVA: 0x003587DC File Offset: 0x003569DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse(RollBlockMovementFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170D4 RID: 94420 RVA: 0x00358801 File Offset: 0x00356A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse Clone()
		{
			return new RollBlockMovementFinishResponse(this);
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x060170D5 RID: 94421 RVA: 0x00358809 File Offset: 0x00356A09
		// (set) Token: 0x060170D6 RID: 94422 RVA: 0x00358811 File Offset: 0x00356A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060170D7 RID: 94423 RVA: 0x0035881A File Offset: 0x00356A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockMovementFinishResponse);
		}

		// Token: 0x060170D8 RID: 94424 RVA: 0x00358828 File Offset: 0x00356A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockMovementFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170D9 RID: 94425 RVA: 0x00358858 File Offset: 0x00356A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170DA RID: 94426 RVA: 0x0035889D File Offset: 0x00356A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170DB RID: 94427 RVA: 0x003588AA File Offset: 0x00356AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x003588B3 File Offset: 0x00356AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170DD RID: 94429 RVA: 0x003588E8 File Offset: 0x00356AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170DE RID: 94430 RVA: 0x00358926 File Offset: 0x00356B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockMovementFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170DF RID: 94431 RVA: 0x00358957 File Offset: 0x00356B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170E0 RID: 94432 RVA: 0x00358960 File Offset: 0x00356B60
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008931 RID: 35121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008932 RID: 35122
		public const int CodeFieldNumber = 7;

		// Token: 0x04008933 RID: 35123
		private ErrorCode code_;
	}
}
