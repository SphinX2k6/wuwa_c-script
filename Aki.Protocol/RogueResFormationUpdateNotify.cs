using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCC RID: 4044
	[NetMessage(EMessageId.RogueResFormationUpdateNotify)]
	public sealed class RogueResFormationUpdateNotify : IMessage<RogueResFormationUpdateNotify>, IMessage, IEquatable<RogueResFormationUpdateNotify>, IDeepCloneable<RogueResFormationUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015A44 RID: 88644 RVA: 0x00324A31 File Offset: 0x00322C31
		[NullableContext(1)]
		public static RogueResFormationUpdateNotify Create()
		{
			return new RogueResFormationUpdateNotify();
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x06015A45 RID: 88645 RVA: 0x00324A38 File Offset: 0x00322C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x06015A46 RID: 88646 RVA: 0x00324A3B File Offset: 0x00322C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFormationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015A47 RID: 88647 RVA: 0x00324A42 File Offset: 0x00322C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify()
		{
		}

		// Token: 0x06015A48 RID: 88648 RVA: 0x00324A55 File Offset: 0x00322C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify(RogueResFormationUpdateNotify other) : this()
		{
			this.rogueResFormations_ = other.rogueResFormations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A49 RID: 88649 RVA: 0x00324A7F File Offset: 0x00322C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify Clone()
		{
			return new RogueResFormationUpdateNotify(this);
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x06015A4A RID: 88650 RVA: 0x00324A87 File Offset: 0x00322C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResFormation> RogueResFormations
		{
			get
			{
				return this.rogueResFormations_;
			}
		}

		// Token: 0x06015A4B RID: 88651 RVA: 0x00324A8F File Offset: 0x00322C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFormationUpdateNotify);
		}

		// Token: 0x06015A4C RID: 88652 RVA: 0x00324A9D File Offset: 0x00322C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFormationUpdateNotify other)
		{
			return other != null && (other == this || (this.rogueResFormations_.Equals(other.rogueResFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A4D RID: 88653 RVA: 0x00324AD0 File Offset: 0x00322CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueResFormations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A4E RID: 88654 RVA: 0x00324B04 File Offset: 0x00322D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A4F RID: 88655 RVA: 0x00324B11 File Offset: 0x00322D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A50 RID: 88656 RVA: 0x00324B1A File Offset: 0x00322D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResFormations_.WriteTo(ref output, RogueResFormationUpdateNotify._repeated_rogueResFormations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A51 RID: 88657 RVA: 0x00324B44 File Offset: 0x00322D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResFormations_.CalculateSize(RogueResFormationUpdateNotify._repeated_rogueResFormations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A52 RID: 88658 RVA: 0x00324B7D File Offset: 0x00322D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResFormationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResFormations_.Add(other.rogueResFormations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A53 RID: 88659 RVA: 0x00324BAB File Offset: 0x00322DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A54 RID: 88660 RVA: 0x00324BB4 File Offset: 0x00322DB4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResFormations_.AddEntriesFrom(ref input, RogueResFormationUpdateNotify._repeated_rogueResFormations_codec);
				}
			}
		}

		// Token: 0x04008260 RID: 33376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008261 RID: 33377
		public const int RogueResFormationsFieldNumber = 9;

		// Token: 0x04008262 RID: 33378
		private static readonly FieldCodec<RogueResFormation> _repeated_rogueResFormations_codec = FieldCodec.ForMessage<RogueResFormation>(74U, RogueResFormation.Parser);

		// Token: 0x04008263 RID: 33379
		private readonly RepeatedField<RogueResFormation> rogueResFormations_ = new RepeatedField<RogueResFormation>();
	}
}
