using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A5 RID: 1189
	[NetMessage(EMessageId.EntityOnLandedNotify)]
	public sealed class EntityOnLandedNotify : IMessage<EntityOnLandedNotify>, IMessage, IEquatable<EntityOnLandedNotify>, IDeepCloneable<EntityOnLandedNotify>, IBufferMessage
	{
		// Token: 0x06007169 RID: 29033 RVA: 0x0011647D File Offset: 0x0011467D
		[NullableContext(1)]
		public static EntityOnLandedNotify Create()
		{
			return new EntityOnLandedNotify();
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x00116484 File Offset: 0x00114684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x00116487 File Offset: 0x00114687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedNotify.Descriptor;
			}
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x0011648E File Offset: 0x0011468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify()
		{
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x00116496 File Offset: 0x00114696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify(EntityOnLandedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x001164BB File Offset: 0x001146BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify Clone()
		{
			return new EntityOnLandedNotify(this);
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x001164C3 File Offset: 0x001146C3
		// (set) Token: 0x06007170 RID: 29040 RVA: 0x001164CB File Offset: 0x001146CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x06007171 RID: 29041 RVA: 0x001164D4 File Offset: 0x001146D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedNotify);
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x001164E2 File Offset: 0x001146E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x00116510 File Offset: 0x00114710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x0011654F File Offset: 0x0011474F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x0011655C File Offset: 0x0011475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x00116565 File Offset: 0x00114765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x00116598 File Offset: 0x00114798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x001165D6 File Offset: 0x001147D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityOnLandedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00116607 File Offset: 0x00114807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x00116610 File Offset: 0x00114810
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C85 RID: 15493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C86 RID: 15494
		public const int IdFieldNumber = 10;

		// Token: 0x04003C87 RID: 15495
		private long id_;
	}
}
