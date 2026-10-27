using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A37 RID: 2615
	[NetMessage(EMessageId.MotorFightAddCollectionNotify)]
	public sealed class MotorFightAddCollectionNotify : IMessage<MotorFightAddCollectionNotify>, IMessage, IEquatable<MotorFightAddCollectionNotify>, IDeepCloneable<MotorFightAddCollectionNotify>, IBufferMessage
	{
		// Token: 0x0600E45D RID: 58461 RVA: 0x002166B1 File Offset: 0x002148B1
		[NullableContext(1)]
		public static MotorFightAddCollectionNotify Create()
		{
			return new MotorFightAddCollectionNotify();
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600E45E RID: 58462 RVA: 0x002166B8 File Offset: 0x002148B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600E45F RID: 58463 RVA: 0x002166BB File Offset: 0x002148BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddCollectionNotify.Descriptor;
			}
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x002166C2 File Offset: 0x002148C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify()
		{
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x002166D5 File Offset: 0x002148D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify(MotorFightAddCollectionNotify other) : this()
		{
			this.collections_ = other.collections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x002166FF File Offset: 0x002148FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddCollectionNotify Clone()
		{
			return new MotorFightAddCollectionNotify(this);
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600E463 RID: 58467 RVA: 0x00216707 File Offset: 0x00214907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundCollectionPb> Collections
		{
			get
			{
				return this.collections_;
			}
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x0021670F File Offset: 0x0021490F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddCollectionNotify);
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x0021671D File Offset: 0x0021491D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddCollectionNotify other)
		{
			return other != null && (other == this || (this.collections_.Equals(other.collections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x00216750 File Offset: 0x00214950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x00216784 File Offset: 0x00214984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x00216791 File Offset: 0x00214991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x0021679A File Offset: 0x0021499A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collections_.WriteTo(ref output, MotorFightAddCollectionNotify._repeated_collections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x002167C4 File Offset: 0x002149C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collections_.CalculateSize(MotorFightAddCollectionNotify._repeated_collections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x002167FD File Offset: 0x002149FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightAddCollectionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.collections_.Add(other.collections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x0021682B File Offset: 0x00214A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x00216834 File Offset: 0x00214A34
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.collections_.AddEntriesFrom(ref input, MotorFightAddCollectionNotify._repeated_collections_codec);
				}
			}
		}

		// Token: 0x04005D74 RID: 23924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D75 RID: 23925
		public const int CollectionsFieldNumber = 3;

		// Token: 0x04005D76 RID: 23926
		private static readonly FieldCodec<MotorFightRoundCollectionPb> _repeated_collections_codec = FieldCodec.ForMessage<MotorFightRoundCollectionPb>(26U, MotorFightRoundCollectionPb.Parser);

		// Token: 0x04005D77 RID: 23927
		private readonly RepeatedField<MotorFightRoundCollectionPb> collections_ = new RepeatedField<MotorFightRoundCollectionPb>();
	}
}
