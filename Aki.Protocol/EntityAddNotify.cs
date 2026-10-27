using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000467 RID: 1127
	[NetMessage(EMessageId.EntityAddNotify)]
	public sealed class EntityAddNotify : IMessage<EntityAddNotify>, IMessage, IEquatable<EntityAddNotify>, IDeepCloneable<EntityAddNotify>, IBufferMessage
	{
		// Token: 0x06006B8E RID: 27534 RVA: 0x001038B9 File Offset: 0x00101AB9
		[NullableContext(1)]
		public static EntityAddNotify Create()
		{
			return new EntityAddNotify();
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06006B8F RID: 27535 RVA: 0x001038C0 File Offset: 0x00101AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06006B90 RID: 27536 RVA: 0x001038C3 File Offset: 0x00101AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddNotify.Descriptor;
			}
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x001038CA File Offset: 0x00101ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify()
		{
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x001038DD File Offset: 0x00101ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify(EntityAddNotify other) : this()
		{
			this.entityPbs_ = other.entityPbs_.Clone();
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00103913 File Offset: 0x00101B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify Clone()
		{
			return new EntityAddNotify(this);
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x0010391B File Offset: 0x00101B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> EntityPbs
		{
			get
			{
				return this.entityPbs_;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x00103923 File Offset: 0x00101B23
		// (set) Token: 0x06006B96 RID: 27542 RVA: 0x0010392B File Offset: 0x00101B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00103934 File Offset: 0x00101B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddNotify);
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00103944 File Offset: 0x00101B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddNotify other)
		{
			return other != null && (other == this || (this.entityPbs_.Equals(other.entityPbs_) && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00103994 File Offset: 0x00101B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityPbs_.GetHashCode();
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x001039E1 File Offset: 0x00101BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x001039EE File Offset: 0x00101BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x001039F8 File Offset: 0x00101BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAdd)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsAdd);
			}
			this.entityPbs_.WriteTo(ref output, EntityAddNotify._repeated_entityPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00103A48 File Offset: 0x00101C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityPbs_.CalculateSize(EntityAddNotify._repeated_entityPbs_codec);
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00103A90 File Offset: 0x00101C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityPbs_.Add(other.entityPbs_);
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00103ADD File Offset: 0x00101CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x00103AE8 File Offset: 0x00101CE8
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
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityPbs_.AddEntriesFrom(ref input, EntityAddNotify._repeated_entityPbs_codec);
					}
				}
				else
				{
					this.IsAdd = input.ReadBool();
				}
			}
		}

		// Token: 0x04003AA2 RID: 15010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AA3 RID: 15011
		public const int EntityPbsFieldNumber = 6;

		// Token: 0x04003AA4 RID: 15012
		private static readonly FieldCodec<EntityPb> _repeated_entityPbs_codec = FieldCodec.ForMessage<EntityPb>(50U, EntityPb.Parser);

		// Token: 0x04003AA5 RID: 15013
		private readonly RepeatedField<EntityPb> entityPbs_ = new RepeatedField<EntityPb>();

		// Token: 0x04003AA6 RID: 15014
		public const int IsAddFieldNumber = 1;

		// Token: 0x04003AA7 RID: 15015
		private bool isAdd_;
	}
}
