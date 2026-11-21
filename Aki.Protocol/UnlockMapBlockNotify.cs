using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FF RID: 5375
	[NetMessage(EMessageId.UnlockMapBlockNotify)]
	public sealed class UnlockMapBlockNotify : IMessage<UnlockMapBlockNotify>, IMessage, IEquatable<UnlockMapBlockNotify>, IDeepCloneable<UnlockMapBlockNotify>, IBufferMessage
	{
		// Token: 0x0601C7DA RID: 116698 RVA: 0x00421919 File Offset: 0x0041FB19
		[NullableContext(1)]
		public static UnlockMapBlockNotify Create()
		{
			return new UnlockMapBlockNotify();
		}

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x0601C7DB RID: 116699 RVA: 0x00421920 File Offset: 0x0041FB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x0601C7DC RID: 116700 RVA: 0x00421923 File Offset: 0x0041FB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMapBlockNotify.Descriptor;
			}
		}

		// Token: 0x0601C7DD RID: 116701 RVA: 0x0042192A File Offset: 0x0041FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify()
		{
		}

		// Token: 0x0601C7DE RID: 116702 RVA: 0x0042193D File Offset: 0x0041FB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify(UnlockMapBlockNotify other) : this()
		{
			this.unlockBlockId_ = other.unlockBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7DF RID: 116703 RVA: 0x00421967 File Offset: 0x0041FB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMapBlockNotify Clone()
		{
			return new UnlockMapBlockNotify(this);
		}

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x0601C7E0 RID: 116704 RVA: 0x0042196F File Offset: 0x0041FB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlockId
		{
			get
			{
				return this.unlockBlockId_;
			}
		}

		// Token: 0x0601C7E1 RID: 116705 RVA: 0x00421977 File Offset: 0x0041FB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMapBlockNotify);
		}

		// Token: 0x0601C7E2 RID: 116706 RVA: 0x00421985 File Offset: 0x0041FB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMapBlockNotify other)
		{
			return other != null && (other == this || (this.unlockBlockId_.Equals(other.unlockBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7E3 RID: 116707 RVA: 0x004219B8 File Offset: 0x0041FBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7E4 RID: 116708 RVA: 0x004219EC File Offset: 0x0041FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7E5 RID: 116709 RVA: 0x004219F9 File Offset: 0x0041FBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7E6 RID: 116710 RVA: 0x00421A02 File Offset: 0x0041FC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBlockId_.WriteTo(ref output, UnlockMapBlockNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7E7 RID: 116711 RVA: 0x00421A2C File Offset: 0x0041FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBlockId_.CalculateSize(UnlockMapBlockNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7E8 RID: 116712 RVA: 0x00421A65 File Offset: 0x0041FC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockMapBlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBlockId_.Add(other.unlockBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7E9 RID: 116713 RVA: 0x00421A93 File Offset: 0x0041FC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7EA RID: 116714 RVA: 0x00421A9C File Offset: 0x0041FC9C
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBlockId_.AddEntriesFrom(ref input, UnlockMapBlockNotify._repeated_unlockBlockId_codec);
				}
			}
		}

		// Token: 0x0400A460 RID: 42080
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A461 RID: 42081
		public const int UnlockBlockIdFieldNumber = 3;

		// Token: 0x0400A462 RID: 42082
		private static readonly FieldCodec<int> _repeated_unlockBlockId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A463 RID: 42083
		private readonly RepeatedField<int> unlockBlockId_ = new RepeatedField<int>();
	}
}
