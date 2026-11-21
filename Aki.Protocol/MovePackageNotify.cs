using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA9 RID: 2729
	[NetMessage(EMessageId.MovePackageNotify)]
	public sealed class MovePackageNotify : IMessage<MovePackageNotify>, IMessage, IEquatable<MovePackageNotify>, IDeepCloneable<MovePackageNotify>, IBufferMessage
	{
		// Token: 0x0600EDDA RID: 60890 RVA: 0x0022BE2D File Offset: 0x0022A02D
		[NullableContext(1)]
		public static MovePackageNotify Create()
		{
			return new MovePackageNotify();
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600EDDB RID: 60891 RVA: 0x0022BE34 File Offset: 0x0022A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x0022BE37 File Offset: 0x0022A037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePackageNotify.Descriptor;
			}
		}

		// Token: 0x0600EDDD RID: 60893 RVA: 0x0022BE3E File Offset: 0x0022A03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify()
		{
		}

		// Token: 0x0600EDDE RID: 60894 RVA: 0x0022BE51 File Offset: 0x0022A051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify(MovePackageNotify other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDDF RID: 60895 RVA: 0x0022BE7B File Offset: 0x0022A07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackageNotify Clone()
		{
			return new MovePackageNotify(this);
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x0022BE83 File Offset: 0x0022A083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x0600EDE1 RID: 60897 RVA: 0x0022BE8B File Offset: 0x0022A08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePackageNotify);
		}

		// Token: 0x0600EDE2 RID: 60898 RVA: 0x0022BE99 File Offset: 0x0022A099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePackageNotify other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDE3 RID: 60899 RVA: 0x0022BECC File Offset: 0x0022A0CC
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

		// Token: 0x0600EDE4 RID: 60900 RVA: 0x0022BF00 File Offset: 0x0022A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDE5 RID: 60901 RVA: 0x0022BF0D File Offset: 0x0022A10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDE6 RID: 60902 RVA: 0x0022BF16 File Offset: 0x0022A116
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

		// Token: 0x0600EDE7 RID: 60903 RVA: 0x0022BF40 File Offset: 0x0022A140
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

		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0022BF79 File Offset: 0x0022A179
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

		// Token: 0x0600EDE9 RID: 60905 RVA: 0x0022BFA7 File Offset: 0x0022A1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDEA RID: 60906 RVA: 0x0022BFB0 File Offset: 0x0022A1B0
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.movingEntities_.AddEntriesFrom(ref input, MovePackageNotify._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x040060A9 RID: 24745
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060AA RID: 24746
		public const int MovingEntitiesFieldNumber = 12;

		// Token: 0x040060AB RID: 24747
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(98U, MovingEntityData.Parser);

		// Token: 0x040060AC RID: 24748
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();
	}
}
