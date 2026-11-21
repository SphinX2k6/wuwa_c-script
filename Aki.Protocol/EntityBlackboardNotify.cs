using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045B RID: 1115
	[NetMessage(EMessageId.EntityBlackboardNotify)]
	public sealed class EntityBlackboardNotify : IMessage<EntityBlackboardNotify>, IMessage, IEquatable<EntityBlackboardNotify>, IDeepCloneable<EntityBlackboardNotify>, IBufferMessage
	{
		// Token: 0x06006AF6 RID: 27382 RVA: 0x0010300B File Offset: 0x0010120B
		[NullableContext(1)]
		public static EntityBlackboardNotify Create()
		{
			return new EntityBlackboardNotify();
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x00103012 File Offset: 0x00101212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x00103015 File Offset: 0x00101215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x0010301C File Offset: 0x0010121C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify()
		{
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x0010302F File Offset: 0x0010122F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify(EntityBlackboardNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00103065 File Offset: 0x00101265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardNotify Clone()
		{
			return new EntityBlackboardNotify(this);
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06006AFC RID: 27388 RVA: 0x0010306D File Offset: 0x0010126D
		// (set) Token: 0x06006AFD RID: 27389 RVA: 0x00103075 File Offset: 0x00101275
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

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06006AFE RID: 27390 RVA: 0x0010307E File Offset: 0x0010127E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00103086 File Offset: 0x00101286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardNotify);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00103094 File Offset: 0x00101294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x001030E4 File Offset: 0x001012E4
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

		// Token: 0x06006B02 RID: 27394 RVA: 0x00103131 File Offset: 0x00101331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x0010313E File Offset: 0x0010133E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00103148 File Offset: 0x00101348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, EntityBlackboardNotify._repeated_params_codec);
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

		// Token: 0x06006B05 RID: 27397 RVA: 0x00103198 File Offset: 0x00101398
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

		// Token: 0x06006B06 RID: 27398 RVA: 0x001031EC File Offset: 0x001013EC
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

		// Token: 0x06006B07 RID: 27399 RVA: 0x00103239 File Offset: 0x00101439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00103244 File Offset: 0x00101444
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
					this.params_.AddEntriesFrom(ref input, EntityBlackboardNotify._repeated_params_codec);
				}
			}
		}

		// Token: 0x04003AE6 RID: 15078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AE7 RID: 15079
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003AE8 RID: 15080
		private long entityId_;

		// Token: 0x04003AE9 RID: 15081
		public const int ParamsFieldNumber = 3;

		// Token: 0x04003AEA RID: 15082
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(26U, BlackboardParam.Parser);

		// Token: 0x04003AEB RID: 15083
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
