using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000472 RID: 1138
	[NetMessage(EMessageId.EntityBlackboardNotify)]
	public sealed class EntityBlackboardNotify : IMessage<EntityBlackboardNotify>, IMessage, IEquatable<EntityBlackboardNotify>, IDeepCloneable<EntityBlackboardNotify>, IBufferMessage
	{
		// Token: 0x06006C84 RID: 27780 RVA: 0x0010607F File Offset: 0x0010427F
		[NullableContext(1)]
		public static EntityBlackboardNotify Create()
		{
			return new EntityBlackboardNotify();
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06006C85 RID: 27781 RVA: 0x00106086 File Offset: 0x00104286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x00106089 File Offset: 0x00104289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x00106090 File Offset: 0x00104290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify()
		{
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x001060A3 File Offset: 0x001042A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify(EntityBlackboardNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x001060D9 File Offset: 0x001042D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify Clone()
		{
			return new EntityBlackboardNotify(this);
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001060E1 File Offset: 0x001042E1
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x001060E9 File Offset: 0x001042E9
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x001060F2 File Offset: 0x001042F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x001060FA File Offset: 0x001042FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardNotify);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00106108 File Offset: 0x00104308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00106158 File Offset: 0x00104358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.params_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x001061A5 File Offset: 0x001043A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x001061B2 File Offset: 0x001043B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x001061BC File Offset: 0x001043BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, EntityBlackboardNotify._repeated_params_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x0010620C File Offset: 0x0010440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.params_.CalculateSize(EntityBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00106260 File Offset: 0x00104460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x001062AD File Offset: 0x001044AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x001062B8 File Offset: 0x001044B8
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
				if (num != 26U)
				{
					if (num != 64U)
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
					this.params_.AddEntriesFrom(ref input, EntityBlackboardNotify._repeated_params_codec);
				}
			}
		}

		// Token: 0x04003AF8 RID: 15096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF9 RID: 15097
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04003AFA RID: 15098
		private long entityId_;

		// Token: 0x04003AFB RID: 15099
		public const int ParamsFieldNumber = 3;

		// Token: 0x04003AFC RID: 15100
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(26U, BlackboardParam.Parser);

		// Token: 0x04003AFD RID: 15101
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
