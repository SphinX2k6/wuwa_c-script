using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000473 RID: 1139
	[NetMessage(EMessageId.EntityBlackboardRequest)]
	public sealed class EntityBlackboardRequest : IMessage<EntityBlackboardRequest>, IMessage, IEquatable<EntityBlackboardRequest>, IDeepCloneable<EntityBlackboardRequest>, IBufferMessage
	{
		// Token: 0x06006C98 RID: 27800 RVA: 0x00106328 File Offset: 0x00104528
		[NullableContext(1)]
		public static EntityBlackboardRequest Create()
		{
			return new EntityBlackboardRequest();
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x0010632F File Offset: 0x0010452F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06006C9A RID: 27802 RVA: 0x00106332 File Offset: 0x00104532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00106339 File Offset: 0x00104539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest()
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x0010634C File Offset: 0x0010454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest(EntityBlackboardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00106382 File Offset: 0x00104582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest Clone()
		{
			return new EntityBlackboardRequest(this);
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06006C9E RID: 27806 RVA: 0x0010638A File Offset: 0x0010458A
		// (set) Token: 0x06006C9F RID: 27807 RVA: 0x00106392 File Offset: 0x00104592
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

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06006CA0 RID: 27808 RVA: 0x0010639B File Offset: 0x0010459B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x001063A3 File Offset: 0x001045A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardRequest);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x001063B4 File Offset: 0x001045B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00106404 File Offset: 0x00104604
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

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00106451 File Offset: 0x00104651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x0010645E File Offset: 0x0010465E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x00106468 File Offset: 0x00104668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			this.params_.WriteTo(ref output, EntityBlackboardRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x001064B8 File Offset: 0x001046B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.params_.CalculateSize(EntityBlackboardRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x0010650C File Offset: 0x0010470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBlackboardRequest other)
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

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00106559 File Offset: 0x00104759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00106564 File Offset: 0x00104764
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
				if (num != 24U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.params_.AddEntriesFrom(ref input, EntityBlackboardRequest._repeated_params_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003AFE RID: 15102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AFF RID: 15103
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003B00 RID: 15104
		private long entityId_;

		// Token: 0x04003B01 RID: 15105
		public const int ParamsFieldNumber = 9;

		// Token: 0x04003B02 RID: 15106
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(74U, BlackboardParam.Parser);

		// Token: 0x04003B03 RID: 15107
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
