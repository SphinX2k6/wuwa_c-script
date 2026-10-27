using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E2 RID: 226
	[NetMessage(EMessageId.AnimalDestroyRequest)]
	public sealed class AnimalDestroyRequest : IMessage<AnimalDestroyRequest>, IMessage, IEquatable<AnimalDestroyRequest>, IDeepCloneable<AnimalDestroyRequest>, IBufferMessage
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00059763 File Offset: 0x00057963
		[NullableContext(1)]
		public static AnimalDestroyRequest Create()
		{
			return new AnimalDestroyRequest();
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0005976A File Offset: 0x0005796A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0005976D File Offset: 0x0005796D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDestroyRequest.Descriptor;
			}
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00059774 File Offset: 0x00057974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest()
		{
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0005977C File Offset: 0x0005797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest(AnimalDestroyRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x000597A1 File Offset: 0x000579A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest Clone()
		{
			return new AnimalDestroyRequest(this);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000597A9 File Offset: 0x000579A9
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x000597B1 File Offset: 0x000579B1
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

		// Token: 0x0600216C RID: 8556 RVA: 0x000597BA File Offset: 0x000579BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDestroyRequest);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000597C8 File Offset: 0x000579C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDestroyRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000597F8 File Offset: 0x000579F8
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

		// Token: 0x0600216F RID: 8559 RVA: 0x00059837 File Offset: 0x00057A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00059844 File Offset: 0x00057A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0005984D File Offset: 0x00057A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00059880 File Offset: 0x00057A80
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

		// Token: 0x06002173 RID: 8563 RVA: 0x000598BE File Offset: 0x00057ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDestroyRequest other)
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

		// Token: 0x06002174 RID: 8564 RVA: 0x000598EF File Offset: 0x00057AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000598F8 File Offset: 0x00057AF8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400243B RID: 9275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400243C RID: 9276
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400243D RID: 9277
		private long entityId_;
	}
}
