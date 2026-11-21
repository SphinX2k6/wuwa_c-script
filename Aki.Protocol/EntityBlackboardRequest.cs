using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045C RID: 1116
	[NetMessage(EMessageId.EntityBlackboardRequest)]
	public sealed class EntityBlackboardRequest : IMessage<EntityBlackboardRequest>, IMessage, IEquatable<EntityBlackboardRequest>, IDeepCloneable<EntityBlackboardRequest>, IBufferMessage
	{
		// Token: 0x06006B0A RID: 27402 RVA: 0x001032B4 File Offset: 0x001014B4
		[NullableContext(1)]
		public static EntityBlackboardRequest Create()
		{
			return new EntityBlackboardRequest();
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x001032BB File Offset: 0x001014BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x001032BE File Offset: 0x001014BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x001032C5 File Offset: 0x001014C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest()
		{
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x001032D8 File Offset: 0x001014D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest(EntityBlackboardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x0010330E File Offset: 0x0010150E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardRequest Clone()
		{
			return new EntityBlackboardRequest(this);
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06006B10 RID: 27408 RVA: 0x00103316 File Offset: 0x00101516
		// (set) Token: 0x06006B11 RID: 27409 RVA: 0x0010331E File Offset: 0x0010151E
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06006B12 RID: 27410 RVA: 0x00103327 File Offset: 0x00101527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x0010332F File Offset: 0x0010152F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardRequest);
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x00103340 File Offset: 0x00101540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x00103390 File Offset: 0x00101590
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

		// Token: 0x06006B16 RID: 27414 RVA: 0x001033DD File Offset: 0x001015DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x001033EA File Offset: 0x001015EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x001033F4 File Offset: 0x001015F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, EntityBlackboardRequest._repeated_params_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00103444 File Offset: 0x00101644
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

		// Token: 0x06006B1A RID: 27418 RVA: 0x00103498 File Offset: 0x00101698
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

		// Token: 0x06006B1B RID: 27419 RVA: 0x001034E5 File Offset: 0x001016E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x001034F0 File Offset: 0x001016F0
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
				if (num != 74U)
				{
					if (num != 104U)
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
					this.params_.AddEntriesFrom(ref input, EntityBlackboardRequest._repeated_params_codec);
				}
			}
		}

		// Token: 0x04003AEC RID: 15084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AED RID: 15085
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003AEE RID: 15086
		private long entityId_;

		// Token: 0x04003AEF RID: 15087
		public const int ParamsFieldNumber = 9;

		// Token: 0x04003AF0 RID: 15088
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(74U, BlackboardParam.Parser);

		// Token: 0x04003AF1 RID: 15089
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
