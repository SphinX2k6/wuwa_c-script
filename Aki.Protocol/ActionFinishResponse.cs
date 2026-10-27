using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006C RID: 108
	[NetMessage(EMessageId.ActionFinishResponse)]
	public sealed class ActionFinishResponse : IMessage<ActionFinishResponse>, IMessage, IEquatable<ActionFinishResponse>, IDeepCloneable<ActionFinishResponse>, IBufferMessage
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x0003C485 File Offset: 0x0003A685
		[NullableContext(1)]
		public static ActionFinishResponse Create()
		{
			return new ActionFinishResponse();
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0003C48C File Offset: 0x0003A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0003C48F File Offset: 0x0003A68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishResponse.Descriptor;
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0003C496 File Offset: 0x0003A696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse()
		{
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0003C49E File Offset: 0x0003A69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse(ActionFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0003C4C3 File Offset: 0x0003A6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse Clone()
		{
			return new ActionFinishResponse(this);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0003C4CB File Offset: 0x0003A6CB
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0003C4D3 File Offset: 0x0003A6D3
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

		// Token: 0x0600170E RID: 5902 RVA: 0x0003C4DC File Offset: 0x0003A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishResponse);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0003C4EA File Offset: 0x0003A6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0003C518 File Offset: 0x0003A718
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

		// Token: 0x06001711 RID: 5905 RVA: 0x0003C55D File Offset: 0x0003A75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0003C56A File Offset: 0x0003A76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0003C573 File Offset: 0x0003A773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0003C5A8 File Offset: 0x0003A7A8
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

		// Token: 0x06001715 RID: 5909 RVA: 0x0003C5E6 File Offset: 0x0003A7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishResponse other)
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

		// Token: 0x06001716 RID: 5910 RVA: 0x0003C617 File Offset: 0x0003A817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0003C620 File Offset: 0x0003A820
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400210D RID: 8461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400210E RID: 8462
		public const int CodeFieldNumber = 8;

		// Token: 0x0400210F RID: 8463
		private ErrorCode code_;
	}
}
