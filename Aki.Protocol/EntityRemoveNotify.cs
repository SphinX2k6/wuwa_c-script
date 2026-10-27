using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BB RID: 1211
	[NetMessage(EMessageId.EntityRemoveNotify)]
	public sealed class EntityRemoveNotify : IMessage<EntityRemoveNotify>, IMessage, IEquatable<EntityRemoveNotify>, IDeepCloneable<EntityRemoveNotify>, IBufferMessage
	{
		// Token: 0x06007346 RID: 29510 RVA: 0x0011AA37 File Offset: 0x00118C37
		[NullableContext(1)]
		public static EntityRemoveNotify Create()
		{
			return new EntityRemoveNotify();
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06007347 RID: 29511 RVA: 0x0011AA3E File Offset: 0x00118C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x0011AA41 File Offset: 0x00118C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x0011AA48 File Offset: 0x00118C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify()
		{
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x0011AA5B File Offset: 0x00118C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify(EntityRemoveNotify other) : this()
		{
			this.removeInfos_ = other.removeInfos_.Clone();
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x0011AA91 File Offset: 0x00118C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify Clone()
		{
			return new EntityRemoveNotify(this);
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x0011AA99 File Offset: 0x00118C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityRemoveInfo> RemoveInfos
		{
			get
			{
				return this.removeInfos_;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x0011AAA1 File Offset: 0x00118CA1
		// (set) Token: 0x0600734E RID: 29518 RVA: 0x0011AAA9 File Offset: 0x00118CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemove
		{
			get
			{
				return this.isRemove_;
			}
			set
			{
				this.isRemove_ = value;
			}
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x0011AAB2 File Offset: 0x00118CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveNotify);
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x0011AAC0 File Offset: 0x00118CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveNotify other)
		{
			return other != null && (other == this || (this.removeInfos_.Equals(other.removeInfos_) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x0011AB10 File Offset: 0x00118D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.removeInfos_.GetHashCode();
			if (this.IsRemove)
			{
				num ^= this.IsRemove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x0011AB5D File Offset: 0x00118D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x0011AB6A File Offset: 0x00118D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x0011AB74 File Offset: 0x00118D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsRemove)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsRemove);
			}
			this.removeInfos_.WriteTo(ref output, EntityRemoveNotify._repeated_removeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x0011ABC4 File Offset: 0x00118DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.removeInfos_.CalculateSize(EntityRemoveNotify._repeated_removeInfos_codec);
			if (this.IsRemove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0011AC0C File Offset: 0x00118E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.removeInfos_.Add(other.removeInfos_);
			if (other.IsRemove)
			{
				this.IsRemove = other.IsRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x0011AC59 File Offset: 0x00118E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0011AC64 File Offset: 0x00118E64
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
				if (num != 32U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.removeInfos_.AddEntriesFrom(ref input, EntityRemoveNotify._repeated_removeInfos_codec);
					}
				}
				else
				{
					this.IsRemove = input.ReadBool();
				}
			}
		}

		// Token: 0x04003D19 RID: 15641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D1A RID: 15642
		public const int RemoveInfosFieldNumber = 5;

		// Token: 0x04003D1B RID: 15643
		private static readonly FieldCodec<EntityRemoveInfo> _repeated_removeInfos_codec = FieldCodec.ForMessage<EntityRemoveInfo>(42U, EntityRemoveInfo.Parser);

		// Token: 0x04003D1C RID: 15644
		private readonly RepeatedField<EntityRemoveInfo> removeInfos_ = new RepeatedField<EntityRemoveInfo>();

		// Token: 0x04003D1D RID: 15645
		public const int IsRemoveFieldNumber = 4;

		// Token: 0x04003D1E RID: 15646
		private bool isRemove_;
	}
}
