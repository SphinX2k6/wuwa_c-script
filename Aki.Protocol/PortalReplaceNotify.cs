using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB9 RID: 3513
	[NetMessage(EMessageId.PortalReplaceNotify)]
	public sealed class PortalReplaceNotify : IMessage<PortalReplaceNotify>, IMessage, IEquatable<PortalReplaceNotify>, IDeepCloneable<PortalReplaceNotify>, IBufferMessage
	{
		// Token: 0x06012F05 RID: 77573 RVA: 0x002C3465 File Offset: 0x002C1665
		[NullableContext(1)]
		public static PortalReplaceNotify Create()
		{
			return new PortalReplaceNotify();
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06012F06 RID: 77574 RVA: 0x002C346C File Offset: 0x002C166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x06012F07 RID: 77575 RVA: 0x002C346F File Offset: 0x002C166F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PortalReplaceNotify.Descriptor;
			}
		}

		// Token: 0x06012F08 RID: 77576 RVA: 0x002C3476 File Offset: 0x002C1676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify()
		{
		}

		// Token: 0x06012F09 RID: 77577 RVA: 0x002C347E File Offset: 0x002C167E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify(PortalReplaceNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newCreatorId_ = other.newCreatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F0A RID: 77578 RVA: 0x002C34AF File Offset: 0x002C16AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify Clone()
		{
			return new PortalReplaceNotify(this);
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x06012F0B RID: 77579 RVA: 0x002C34B7 File Offset: 0x002C16B7
		// (set) Token: 0x06012F0C RID: 77580 RVA: 0x002C34BF File Offset: 0x002C16BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x06012F0D RID: 77581 RVA: 0x002C34C8 File Offset: 0x002C16C8
		// (set) Token: 0x06012F0E RID: 77582 RVA: 0x002C34D0 File Offset: 0x002C16D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NewCreatorId
		{
			get
			{
				return this.newCreatorId_;
			}
			set
			{
				this.newCreatorId_ = value;
			}
		}

		// Token: 0x06012F0F RID: 77583 RVA: 0x002C34D9 File Offset: 0x002C16D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PortalReplaceNotify);
		}

		// Token: 0x06012F10 RID: 77584 RVA: 0x002C34E7 File Offset: 0x002C16E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PortalReplaceNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NewCreatorId == other.NewCreatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F11 RID: 77585 RVA: 0x002C3528 File Offset: 0x002C1728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NewCreatorId != 0L)
			{
				num ^= this.NewCreatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F12 RID: 77586 RVA: 0x002C3580 File Offset: 0x002C1780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F13 RID: 77587 RVA: 0x002C358D File Offset: 0x002C178D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F14 RID: 77588 RVA: 0x002C3598 File Offset: 0x002C1798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewCreatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.NewCreatorId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F15 RID: 77589 RVA: 0x002C35F4 File Offset: 0x002C17F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.NewCreatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NewCreatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F16 RID: 77590 RVA: 0x002C364C File Offset: 0x002C184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PortalReplaceNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NewCreatorId != 0L)
			{
				this.NewCreatorId = other.NewCreatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F17 RID: 77591 RVA: 0x002C369C File Offset: 0x002C189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F18 RID: 77592 RVA: 0x002C36A8 File Offset: 0x002C18A8
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.NewCreatorId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007575 RID: 30069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007576 RID: 30070
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04007577 RID: 30071
		private long entityId_;

		// Token: 0x04007578 RID: 30072
		public const int NewCreatorIdFieldNumber = 10;

		// Token: 0x04007579 RID: 30073
		private long newCreatorId_;
	}
}
