using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCA RID: 3530
	[NetMessage(EMessageId.PortalReplaceNotify)]
	public sealed class PortalReplaceNotify : IMessage<PortalReplaceNotify>, IMessage, IEquatable<PortalReplaceNotify>, IDeepCloneable<PortalReplaceNotify>, IBufferMessage
	{
		// Token: 0x06013015 RID: 77845 RVA: 0x002C5315 File Offset: 0x002C3515
		[NullableContext(1)]
		public static PortalReplaceNotify Create()
		{
			return new PortalReplaceNotify();
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x06013016 RID: 77846 RVA: 0x002C531C File Offset: 0x002C351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x06013017 RID: 77847 RVA: 0x002C531F File Offset: 0x002C351F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PortalReplaceNotify.Descriptor;
			}
		}

		// Token: 0x06013018 RID: 77848 RVA: 0x002C5326 File Offset: 0x002C3526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify()
		{
		}

		// Token: 0x06013019 RID: 77849 RVA: 0x002C532E File Offset: 0x002C352E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify(PortalReplaceNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newCreatorId_ = other.newCreatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601301A RID: 77850 RVA: 0x002C535F File Offset: 0x002C355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PortalReplaceNotify Clone()
		{
			return new PortalReplaceNotify(this);
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x0601301B RID: 77851 RVA: 0x002C5367 File Offset: 0x002C3567
		// (set) Token: 0x0601301C RID: 77852 RVA: 0x002C536F File Offset: 0x002C356F
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

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0601301D RID: 77853 RVA: 0x002C5378 File Offset: 0x002C3578
		// (set) Token: 0x0601301E RID: 77854 RVA: 0x002C5380 File Offset: 0x002C3580
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

		// Token: 0x0601301F RID: 77855 RVA: 0x002C5389 File Offset: 0x002C3589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PortalReplaceNotify);
		}

		// Token: 0x06013020 RID: 77856 RVA: 0x002C5397 File Offset: 0x002C3597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PortalReplaceNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NewCreatorId == other.NewCreatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013021 RID: 77857 RVA: 0x002C53D8 File Offset: 0x002C35D8
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

		// Token: 0x06013022 RID: 77858 RVA: 0x002C5430 File Offset: 0x002C3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013023 RID: 77859 RVA: 0x002C543D File Offset: 0x002C363D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013024 RID: 77860 RVA: 0x002C5448 File Offset: 0x002C3648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewCreatorId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.NewCreatorId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013025 RID: 77861 RVA: 0x002C54A4 File Offset: 0x002C36A4
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

		// Token: 0x06013026 RID: 77862 RVA: 0x002C54FC File Offset: 0x002C36FC
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

		// Token: 0x06013027 RID: 77863 RVA: 0x002C554C File Offset: 0x002C374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013028 RID: 77864 RVA: 0x002C5558 File Offset: 0x002C3758
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
					if (num != 112U)
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

		// Token: 0x04007562 RID: 30050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007563 RID: 30051
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04007564 RID: 30052
		private long entityId_;

		// Token: 0x04007565 RID: 30053
		public const int NewCreatorIdFieldNumber = 8;

		// Token: 0x04007566 RID: 30054
		private long newCreatorId_;
	}
}
