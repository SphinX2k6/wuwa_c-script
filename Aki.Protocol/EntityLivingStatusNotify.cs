using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000489 RID: 1161
	[NetMessage(EMessageId.EntityLivingStatusNotify)]
	public sealed class EntityLivingStatusNotify : IMessage<EntityLivingStatusNotify>, IMessage, IEquatable<EntityLivingStatusNotify>, IDeepCloneable<EntityLivingStatusNotify>, IBufferMessage
	{
		// Token: 0x06006F6C RID: 28524 RVA: 0x0011227F File Offset: 0x0011047F
		[NullableContext(1)]
		public static EntityLivingStatusNotify Create()
		{
			return new EntityLivingStatusNotify();
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x00112286 File Offset: 0x00110486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06006F6E RID: 28526 RVA: 0x00112289 File Offset: 0x00110489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLivingStatusNotify.Descriptor;
			}
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00112290 File Offset: 0x00110490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify()
		{
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x001122A4 File Offset: 0x001104A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify(EntityLivingStatusNotify other) : this()
		{
			this.id_ = other.id_;
			this.livingStatus_ = other.livingStatus_;
			this.dropVisionItem_ = other.dropVisionItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x001122F1 File Offset: 0x001104F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify Clone()
		{
			return new EntityLivingStatusNotify(this);
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x001122F9 File Offset: 0x001104F9
		// (set) Token: 0x06006F73 RID: 28531 RVA: 0x00112301 File Offset: 0x00110501
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06006F74 RID: 28532 RVA: 0x0011230A File Offset: 0x0011050A
		// (set) Token: 0x06006F75 RID: 28533 RVA: 0x00112312 File Offset: 0x00110512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingStatus LivingStatus
		{
			get
			{
				return this.livingStatus_;
			}
			set
			{
				this.livingStatus_ = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x0011231B File Offset: 0x0011051B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropVisionItemResult> DropVisionItem
		{
			get
			{
				return this.dropVisionItem_;
			}
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00112323 File Offset: 0x00110523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLivingStatusNotify);
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00112334 File Offset: 0x00110534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLivingStatusNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LivingStatus == other.LivingStatus && this.dropVisionItem_.Equals(other.dropVisionItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x00112394 File Offset: 0x00110594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			num ^= this.dropVisionItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x00112400 File Offset: 0x00110600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x0011240D File Offset: 0x0011060D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x00112418 File Offset: 0x00110618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.LivingStatus);
			}
			this.dropVisionItem_.WriteTo(ref output, EntityLivingStatusNotify._repeated_dropVisionItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x00112484 File Offset: 0x00110684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			num += this.dropVisionItem_.CalculateSize(EntityLivingStatusNotify._repeated_dropVisionItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x001124F0 File Offset: 0x001106F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityLivingStatusNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			this.dropVisionItem_.Add(other.dropVisionItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00112551 File Offset: 0x00110751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x0011255C File Offset: 0x0011075C
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.dropVisionItem_.AddEntriesFrom(ref input, EntityLivingStatusNotify._repeated_dropVisionItem_codec);
						}
					}
					else
					{
						this.LivingStatus = (LivingStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C4D RID: 15437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C4E RID: 15438
		public const int IdFieldNumber = 6;

		// Token: 0x04003C4F RID: 15439
		private long id_;

		// Token: 0x04003C50 RID: 15440
		public const int LivingStatusFieldNumber = 7;

		// Token: 0x04003C51 RID: 15441
		private LivingStatus livingStatus_;

		// Token: 0x04003C52 RID: 15442
		public const int DropVisionItemFieldNumber = 9;

		// Token: 0x04003C53 RID: 15443
		private static readonly FieldCodec<DropVisionItemResult> _repeated_dropVisionItem_codec = FieldCodec.ForMessage<DropVisionItemResult>(74U, DropVisionItemResult.Parser);

		// Token: 0x04003C54 RID: 15444
		private readonly RepeatedField<DropVisionItemResult> dropVisionItem_ = new RepeatedField<DropVisionItemResult>();
	}
}
