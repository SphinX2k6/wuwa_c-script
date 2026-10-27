using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0C RID: 3852
	[NetMessage(EMessageId.RemoveSysBuffNotify)]
	public sealed class RemoveSysBuffNotify : IMessage<RemoveSysBuffNotify>, IMessage, IEquatable<RemoveSysBuffNotify>, IDeepCloneable<RemoveSysBuffNotify>, IBufferMessage
	{
		// Token: 0x06014A0C RID: 84492 RVA: 0x002FEC9D File Offset: 0x002FCE9D
		[NullableContext(1)]
		public static RemoveSysBuffNotify Create()
		{
			return new RemoveSysBuffNotify();
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x06014A0D RID: 84493 RVA: 0x002FECA4 File Offset: 0x002FCEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x06014A0E RID: 84494 RVA: 0x002FECA7 File Offset: 0x002FCEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x06014A0F RID: 84495 RVA: 0x002FECAE File Offset: 0x002FCEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify()
		{
		}

		// Token: 0x06014A10 RID: 84496 RVA: 0x002FECC1 File Offset: 0x002FCEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify(RemoveSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x002FECF7 File Offset: 0x002FCEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify Clone()
		{
			return new RemoveSysBuffNotify(this);
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x06014A12 RID: 84498 RVA: 0x002FECFF File Offset: 0x002FCEFF
		// (set) Token: 0x06014A13 RID: 84499 RVA: 0x002FED07 File Offset: 0x002FCF07
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

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x06014A14 RID: 84500 RVA: 0x002FED10 File Offset: 0x002FCF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06014A15 RID: 84501 RVA: 0x002FED18 File Offset: 0x002FCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSysBuffNotify);
		}

		// Token: 0x06014A16 RID: 84502 RVA: 0x002FED28 File Offset: 0x002FCF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A17 RID: 84503 RVA: 0x002FED78 File Offset: 0x002FCF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A18 RID: 84504 RVA: 0x002FEDC5 File Offset: 0x002FCFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A19 RID: 84505 RVA: 0x002FEDD2 File Offset: 0x002FCFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A1A RID: 84506 RVA: 0x002FEDDC File Offset: 0x002FCFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.ids_.WriteTo(ref output, RemoveSysBuffNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A1B RID: 84507 RVA: 0x002FEE2C File Offset: 0x002FD02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.ids_.CalculateSize(RemoveSysBuffNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A1C RID: 84508 RVA: 0x002FEE80 File Offset: 0x002FD080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSysBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A1D RID: 84509 RVA: 0x002FEECD File Offset: 0x002FD0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A1E RID: 84510 RVA: 0x002FEED8 File Offset: 0x002FD0D8
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
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, RemoveSysBuffNotify._repeated_ids_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007CD7 RID: 31959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CD8 RID: 31960
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04007CD9 RID: 31961
		private long entityId_;

		// Token: 0x04007CDA RID: 31962
		public const int IdsFieldNumber = 4;

		// Token: 0x04007CDB RID: 31963
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007CDC RID: 31964
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
