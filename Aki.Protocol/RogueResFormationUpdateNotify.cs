using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDC RID: 4060
	[NetMessage(EMessageId.RogueResFormationUpdateNotify)]
	public sealed class RogueResFormationUpdateNotify : IMessage<RogueResFormationUpdateNotify>, IMessage, IEquatable<RogueResFormationUpdateNotify>, IDeepCloneable<RogueResFormationUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015B29 RID: 88873 RVA: 0x003260E5 File Offset: 0x003242E5
		[NullableContext(1)]
		public static RogueResFormationUpdateNotify Create()
		{
			return new RogueResFormationUpdateNotify();
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x06015B2A RID: 88874 RVA: 0x003260EC File Offset: 0x003242EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x06015B2B RID: 88875 RVA: 0x003260EF File Offset: 0x003242EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFormationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015B2C RID: 88876 RVA: 0x003260F6 File Offset: 0x003242F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify()
		{
		}

		// Token: 0x06015B2D RID: 88877 RVA: 0x00326109 File Offset: 0x00324309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify(RogueResFormationUpdateNotify other) : this()
		{
			this.rogueResFormations_ = other.rogueResFormations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B2E RID: 88878 RVA: 0x00326133 File Offset: 0x00324333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormationUpdateNotify Clone()
		{
			return new RogueResFormationUpdateNotify(this);
		}

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x06015B2F RID: 88879 RVA: 0x0032613B File Offset: 0x0032433B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResFormation> RogueResFormations
		{
			get
			{
				return this.rogueResFormations_;
			}
		}

		// Token: 0x06015B30 RID: 88880 RVA: 0x00326143 File Offset: 0x00324343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFormationUpdateNotify);
		}

		// Token: 0x06015B31 RID: 88881 RVA: 0x00326151 File Offset: 0x00324351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFormationUpdateNotify other)
		{
			return other != null && (other == this || (this.rogueResFormations_.Equals(other.rogueResFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B32 RID: 88882 RVA: 0x00326184 File Offset: 0x00324384
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

		// Token: 0x06015B33 RID: 88883 RVA: 0x003261B8 File Offset: 0x003243B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B34 RID: 88884 RVA: 0x003261C5 File Offset: 0x003243C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B35 RID: 88885 RVA: 0x003261CE File Offset: 0x003243CE
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

		// Token: 0x06015B36 RID: 88886 RVA: 0x003261F8 File Offset: 0x003243F8
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

		// Token: 0x06015B37 RID: 88887 RVA: 0x00326231 File Offset: 0x00324431
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

		// Token: 0x06015B38 RID: 88888 RVA: 0x0032625F File Offset: 0x0032445F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B39 RID: 88889 RVA: 0x00326268 File Offset: 0x00324468
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResFormations_.AddEntriesFrom(ref input, RogueResFormationUpdateNotify._repeated_rogueResFormations_codec);
				}
			}
		}

		// Token: 0x04008236 RID: 33334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008237 RID: 33335
		public const int RogueResFormationsFieldNumber = 4;

		// Token: 0x04008238 RID: 33336
		private static readonly FieldCodec<RogueResFormation> _repeated_rogueResFormations_codec = FieldCodec.ForMessage<RogueResFormation>(34U, RogueResFormation.Parser);

		// Token: 0x04008239 RID: 33337
		private readonly RepeatedField<RogueResFormation> rogueResFormations_ = new RepeatedField<RogueResFormation>();
	}
}
