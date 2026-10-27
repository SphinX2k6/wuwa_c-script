using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A6 RID: 1190
	[NetMessage(EMessageId.EntityOnLandedRequest)]
	public sealed class EntityOnLandedRequest : IMessage<EntityOnLandedRequest>, IMessage, IEquatable<EntityOnLandedRequest>, IDeepCloneable<EntityOnLandedRequest>, IBufferMessage
	{
		// Token: 0x0600717B RID: 29051 RVA: 0x00116655 File Offset: 0x00114855
		[NullableContext(1)]
		public static EntityOnLandedRequest Create()
		{
			return new EntityOnLandedRequest();
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x0011665C File Offset: 0x0011485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x0011665F File Offset: 0x0011485F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedRequest.Descriptor;
			}
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x00116666 File Offset: 0x00114866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest()
		{
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x0011666E File Offset: 0x0011486E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest(EntityOnLandedRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00116693 File Offset: 0x00114893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest Clone()
		{
			return new EntityOnLandedRequest(this);
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x0011669B File Offset: 0x0011489B
		// (set) Token: 0x06007182 RID: 29058 RVA: 0x001166A3 File Offset: 0x001148A3
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

		// Token: 0x06007183 RID: 29059 RVA: 0x001166AC File Offset: 0x001148AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedRequest);
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x001166BA File Offset: 0x001148BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x001166E8 File Offset: 0x001148E8
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

		// Token: 0x06007186 RID: 29062 RVA: 0x00116727 File Offset: 0x00114927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00116734 File Offset: 0x00114934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x0011673D File Offset: 0x0011493D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00116770 File Offset: 0x00114970
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

		// Token: 0x0600718A RID: 29066 RVA: 0x001167AE File Offset: 0x001149AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityOnLandedRequest other)
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

		// Token: 0x0600718B RID: 29067 RVA: 0x001167DF File Offset: 0x001149DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x001167E8 File Offset: 0x001149E8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C88 RID: 15496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C89 RID: 15497
		public const int IdFieldNumber = 5;

		// Token: 0x04003C8A RID: 15498
		private long id_;
	}
}
