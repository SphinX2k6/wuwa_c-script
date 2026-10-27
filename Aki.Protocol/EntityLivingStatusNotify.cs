using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A0 RID: 1184
	[NetMessage(EMessageId.EntityLivingStatusNotify)]
	public sealed class EntityLivingStatusNotify : IMessage<EntityLivingStatusNotify>, IMessage, IEquatable<EntityLivingStatusNotify>, IDeepCloneable<EntityLivingStatusNotify>, IBufferMessage
	{
		// Token: 0x060070FA RID: 28922 RVA: 0x001152F7 File Offset: 0x001134F7
		[NullableContext(1)]
		public static EntityLivingStatusNotify Create()
		{
			return new EntityLivingStatusNotify();
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x060070FB RID: 28923 RVA: 0x001152FE File Offset: 0x001134FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x00115301 File Offset: 0x00113501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLivingStatusNotify.Descriptor;
			}
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00115308 File Offset: 0x00113508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify()
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x0011531C File Offset: 0x0011351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify(EntityLivingStatusNotify other) : this()
		{
			this.id_ = other.id_;
			this.livingStatus_ = other.livingStatus_;
			this.dropVisionItem_ = other.dropVisionItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00115369 File Offset: 0x00113569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLivingStatusNotify Clone()
		{
			return new EntityLivingStatusNotify(this);
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x00115371 File Offset: 0x00113571
		// (set) Token: 0x06007101 RID: 28929 RVA: 0x00115379 File Offset: 0x00113579
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

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06007102 RID: 28930 RVA: 0x00115382 File Offset: 0x00113582
		// (set) Token: 0x06007103 RID: 28931 RVA: 0x0011538A File Offset: 0x0011358A
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

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06007104 RID: 28932 RVA: 0x00115393 File Offset: 0x00113593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropVisionItemResult> DropVisionItem
		{
			get
			{
				return this.dropVisionItem_;
			}
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x0011539B File Offset: 0x0011359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLivingStatusNotify);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x001153AC File Offset: 0x001135AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLivingStatusNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LivingStatus == other.LivingStatus && this.dropVisionItem_.Equals(other.dropVisionItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x0011540C File Offset: 0x0011360C
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

		// Token: 0x06007108 RID: 28936 RVA: 0x00115478 File Offset: 0x00113678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x00115485 File Offset: 0x00113685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x00115490 File Offset: 0x00113690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropVisionItem_.WriteTo(ref output, EntityLivingStatusNotify._repeated_dropVisionItem_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.LivingStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x001154FC File Offset: 0x001136FC
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

		// Token: 0x0600710C RID: 28940 RVA: 0x00115568 File Offset: 0x00113768
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

		// Token: 0x0600710D RID: 28941 RVA: 0x001155C9 File Offset: 0x001137C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x001155D4 File Offset: 0x001137D4
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
				if (num != 34U)
				{
					if (num != 48U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.dropVisionItem_.AddEntriesFrom(ref input, EntityLivingStatusNotify._repeated_dropVisionItem_codec);
				}
			}
		}

		// Token: 0x04003C5F RID: 15455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C60 RID: 15456
		public const int IdFieldNumber = 6;

		// Token: 0x04003C61 RID: 15457
		private long id_;

		// Token: 0x04003C62 RID: 15458
		public const int LivingStatusFieldNumber = 15;

		// Token: 0x04003C63 RID: 15459
		private LivingStatus livingStatus_;

		// Token: 0x04003C64 RID: 15460
		public const int DropVisionItemFieldNumber = 4;

		// Token: 0x04003C65 RID: 15461
		private static readonly FieldCodec<DropVisionItemResult> _repeated_dropVisionItem_codec = FieldCodec.ForMessage<DropVisionItemResult>(34U, DropVisionItemResult.Parser);

		// Token: 0x04003C66 RID: 15462
		private readonly RepeatedField<DropVisionItemResult> dropVisionItem_ = new RepeatedField<DropVisionItemResult>();
	}
}
