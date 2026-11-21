using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000638 RID: 1592
	[NetMessage(EMessageId.FriendApplyDeletedNotify)]
	public sealed class FriendApplyDeletedNotify : IMessage<FriendApplyDeletedNotify>, IMessage, IEquatable<FriendApplyDeletedNotify>, IDeepCloneable<FriendApplyDeletedNotify>, IBufferMessage
	{
		// Token: 0x060092F6 RID: 37622 RVA: 0x00163D43 File Offset: 0x00161F43
		[NullableContext(1)]
		public static FriendApplyDeletedNotify Create()
		{
			return new FriendApplyDeletedNotify();
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x00163D4A File Offset: 0x00161F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00163D4D File Offset: 0x00161F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyDeletedNotify.Descriptor;
			}
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x00163D54 File Offset: 0x00161F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify()
		{
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x00163D5C File Offset: 0x00161F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify(FriendApplyDeletedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x00163D81 File Offset: 0x00161F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify Clone()
		{
			return new FriendApplyDeletedNotify(this);
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00163D89 File Offset: 0x00161F89
		// (set) Token: 0x060092FD RID: 37629 RVA: 0x00163D91 File Offset: 0x00161F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x00163D9A File Offset: 0x00161F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyDeletedNotify);
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x00163DA8 File Offset: 0x00161FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyDeletedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x00163DD8 File Offset: 0x00161FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x00163E17 File Offset: 0x00162017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x00163E24 File Offset: 0x00162024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00163E2D File Offset: 0x0016202D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x00163E60 File Offset: 0x00162060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x00163E9E File Offset: 0x0016209E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyDeletedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x00163ECF File Offset: 0x001620CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x00163ED8 File Offset: 0x001620D8
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004718 RID: 18200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004719 RID: 18201
		public const int IdFieldNumber = 12;

		// Token: 0x0400471A RID: 18202
		private int id_;
	}
}
