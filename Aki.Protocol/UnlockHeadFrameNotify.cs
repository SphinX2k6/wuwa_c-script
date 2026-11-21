using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F9 RID: 5369
	[NetMessage(EMessageId.UnlockHeadFrameNotify)]
	public sealed class UnlockHeadFrameNotify : IMessage<UnlockHeadFrameNotify>, IMessage, IEquatable<UnlockHeadFrameNotify>, IDeepCloneable<UnlockHeadFrameNotify>, IBufferMessage
	{
		// Token: 0x0601C763 RID: 116579 RVA: 0x00420AE0 File Offset: 0x0041ECE0
		[NullableContext(1)]
		public static UnlockHeadFrameNotify Create()
		{
			return new UnlockHeadFrameNotify();
		}

		// Token: 0x17006050 RID: 24656
		// (get) Token: 0x0601C764 RID: 116580 RVA: 0x00420AE7 File Offset: 0x0041ECE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006051 RID: 24657
		// (get) Token: 0x0601C765 RID: 116581 RVA: 0x00420AEA File Offset: 0x0041ECEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockHeadFrameNotify.Descriptor;
			}
		}

		// Token: 0x0601C766 RID: 116582 RVA: 0x00420AF1 File Offset: 0x0041ECF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify()
		{
		}

		// Token: 0x0601C767 RID: 116583 RVA: 0x00420AF9 File Offset: 0x0041ECF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify(UnlockHeadFrameNotify other) : this()
		{
			this.headFrameId_ = other.headFrameId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C768 RID: 116584 RVA: 0x00420B1E File Offset: 0x0041ED1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify Clone()
		{
			return new UnlockHeadFrameNotify(this);
		}

		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x0601C769 RID: 116585 RVA: 0x00420B26 File Offset: 0x0041ED26
		// (set) Token: 0x0601C76A RID: 116586 RVA: 0x00420B2E File Offset: 0x0041ED2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadFrameId
		{
			get
			{
				return this.headFrameId_;
			}
			set
			{
				this.headFrameId_ = value;
			}
		}

		// Token: 0x0601C76B RID: 116587 RVA: 0x00420B37 File Offset: 0x0041ED37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockHeadFrameNotify);
		}

		// Token: 0x0601C76C RID: 116588 RVA: 0x00420B45 File Offset: 0x0041ED45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockHeadFrameNotify other)
		{
			return other != null && (other == this || (this.HeadFrameId == other.HeadFrameId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C76D RID: 116589 RVA: 0x00420B74 File Offset: 0x0041ED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadFrameId != 0)
			{
				num ^= this.HeadFrameId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C76E RID: 116590 RVA: 0x00420BB3 File Offset: 0x0041EDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C76F RID: 116591 RVA: 0x00420BC0 File Offset: 0x0041EDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C770 RID: 116592 RVA: 0x00420BC9 File Offset: 0x0041EDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadFrameId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HeadFrameId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C771 RID: 116593 RVA: 0x00420BFC File Offset: 0x0041EDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadFrameId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadFrameId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C772 RID: 116594 RVA: 0x00420C3A File Offset: 0x0041EE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockHeadFrameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadFrameId != 0)
			{
				this.HeadFrameId = other.HeadFrameId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C773 RID: 116595 RVA: 0x00420C6B File Offset: 0x0041EE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C774 RID: 116596 RVA: 0x00420C74 File Offset: 0x0041EE74
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
					this.HeadFrameId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A443 RID: 42051
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A444 RID: 42052
		public const int HeadFrameIdFieldNumber = 3;

		// Token: 0x0400A445 RID: 42053
		private int headFrameId_;
	}
}
