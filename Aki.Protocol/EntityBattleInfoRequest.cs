using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000455 RID: 1109
	[NetMessage(EMessageId.EntityBattleInfoRequest)]
	public sealed class EntityBattleInfoRequest : IMessage<EntityBattleInfoRequest>, IMessage, IEquatable<EntityBattleInfoRequest>, IDeepCloneable<EntityBattleInfoRequest>, IBufferMessage
	{
		// Token: 0x06006A6E RID: 27246 RVA: 0x001018E3 File Offset: 0x000FFAE3
		[NullableContext(1)]
		public static EntityBattleInfoRequest Create()
		{
			return new EntityBattleInfoRequest();
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x001018EA File Offset: 0x000FFAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06006A70 RID: 27248 RVA: 0x001018ED File Offset: 0x000FFAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleInfoRequest.Descriptor;
			}
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x001018F4 File Offset: 0x000FFAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest()
		{
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x001018FC File Offset: 0x000FFAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest(EntityBattleInfoRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00101921 File Offset: 0x000FFB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest Clone()
		{
			return new EntityBattleInfoRequest(this);
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06006A74 RID: 27252 RVA: 0x00101929 File Offset: 0x000FFB29
		// (set) Token: 0x06006A75 RID: 27253 RVA: 0x00101931 File Offset: 0x000FFB31
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

		// Token: 0x06006A76 RID: 27254 RVA: 0x0010193A File Offset: 0x000FFB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleInfoRequest);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00101948 File Offset: 0x000FFB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleInfoRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00101978 File Offset: 0x000FFB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x001019B7 File Offset: 0x000FFBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x001019C4 File Offset: 0x000FFBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x001019CD File Offset: 0x000FFBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00101A00 File Offset: 0x000FFC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x00101A3E File Offset: 0x000FFC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBattleInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00101A6F File Offset: 0x000FFC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x00101A78 File Offset: 0x000FFC78
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003AB0 RID: 15024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB1 RID: 15025
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003AB2 RID: 15026
		private long entityId_;
	}
}
