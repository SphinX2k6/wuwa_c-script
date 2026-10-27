using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E4 RID: 228
	[NetMessage(EMessageId.AnimalDieNotify)]
	public sealed class AnimalDieNotify : IMessage<AnimalDieNotify>, IMessage, IEquatable<AnimalDieNotify>, IDeepCloneable<AnimalDieNotify>, IBufferMessage
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x00059B1D File Offset: 0x00057D1D
		[NullableContext(1)]
		public static AnimalDieNotify Create()
		{
			return new AnimalDieNotify();
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00059B24 File Offset: 0x00057D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00059B27 File Offset: 0x00057D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieNotify.Descriptor;
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00059B2E File Offset: 0x00057D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify()
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00059B36 File Offset: 0x00057D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify(AnimalDieNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00059B67 File Offset: 0x00057D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify Clone()
		{
			return new AnimalDieNotify(this);
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00059B6F File Offset: 0x00057D6F
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00059B77 File Offset: 0x00057D77
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x00059B80 File Offset: 0x00057D80
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00059B88 File Offset: 0x00057D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00059B91 File Offset: 0x00057D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieNotify);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00059B9F File Offset: 0x00057D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00059BE0 File Offset: 0x00057DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00059C38 File Offset: 0x00057E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00059C45 File Offset: 0x00057E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00059C50 File Offset: 0x00057E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00059CAC File Offset: 0x00057EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00059D04 File Offset: 0x00057F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00059D54 File Offset: 0x00057F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00059D60 File Offset: 0x00057F60
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002441 RID: 9281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002442 RID: 9282
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04002443 RID: 9283
		private long entityId_;

		// Token: 0x04002444 RID: 9284
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04002445 RID: 9285
		private int playerId_;
	}
}
