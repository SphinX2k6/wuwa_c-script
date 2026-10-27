using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABA RID: 2746
	[NetMessage(EMessageId.MovePackageNotify)]
	public sealed class MovePackageNotify : IMessage<MovePackageNotify>, IMessage, IEquatable<MovePackageNotify>, IDeepCloneable<MovePackageNotify>, IBufferMessage
	{
		// Token: 0x0600EEF4 RID: 61172 RVA: 0x0022E02D File Offset: 0x0022C22D
		[NullableContext(1)]
		public static MovePackageNotify Create()
		{
			return new MovePackageNotify();
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600EEF5 RID: 61173 RVA: 0x0022E034 File Offset: 0x0022C234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600EEF6 RID: 61174 RVA: 0x0022E037 File Offset: 0x0022C237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePackageNotify.Descriptor;
			}
		}

		// Token: 0x0600EEF7 RID: 61175 RVA: 0x0022E03E File Offset: 0x0022C23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify()
		{
		}

		// Token: 0x0600EEF8 RID: 61176 RVA: 0x0022E051 File Offset: 0x0022C251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify(MovePackageNotify other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEF9 RID: 61177 RVA: 0x0022E07B File Offset: 0x0022C27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify Clone()
		{
			return new MovePackageNotify(this);
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600EEFA RID: 61178 RVA: 0x0022E083 File Offset: 0x0022C283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x0600EEFB RID: 61179 RVA: 0x0022E08B File Offset: 0x0022C28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePackageNotify);
		}

		// Token: 0x0600EEFC RID: 61180 RVA: 0x0022E099 File Offset: 0x0022C299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePackageNotify other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEFD RID: 61181 RVA: 0x0022E0CC File Offset: 0x0022C2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.movingEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EEFE RID: 61182 RVA: 0x0022E100 File Offset: 0x0022C300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEFF RID: 61183 RVA: 0x0022E10D File Offset: 0x0022C30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF00 RID: 61184 RVA: 0x0022E116 File Offset: 0x0022C316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.movingEntities_.WriteTo(ref output, MovePackageNotify._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF01 RID: 61185 RVA: 0x0022E140 File Offset: 0x0022C340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.movingEntities_.CalculateSize(MovePackageNotify._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EF02 RID: 61186 RVA: 0x0022E179 File Offset: 0x0022C379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovePackageNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.movingEntities_.Add(other.movingEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x0022E1A7 File Offset: 0x0022C3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF04 RID: 61188 RVA: 0x0022E1B0 File Offset: 0x0022C3B0
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.movingEntities_.AddEntriesFrom(ref input, MovePackageNotify._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x040060A0 RID: 24736
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060A1 RID: 24737
		public const int MovingEntitiesFieldNumber = 14;

		// Token: 0x040060A2 RID: 24738
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(114U, MovingEntityData.Parser);

		// Token: 0x040060A3 RID: 24739
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();
	}
}
