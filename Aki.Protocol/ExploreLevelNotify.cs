using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E1 RID: 1249
	[NetMessage(EMessageId.ExploreLevelNotify)]
	public sealed class ExploreLevelNotify : IMessage<ExploreLevelNotify>, IMessage, IEquatable<ExploreLevelNotify>, IDeepCloneable<ExploreLevelNotify>, IBufferMessage
	{
		// Token: 0x06007688 RID: 30344 RVA: 0x001219A8 File Offset: 0x0011FBA8
		[NullableContext(1)]
		public static ExploreLevelNotify Create()
		{
			return new ExploreLevelNotify();
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x001219AF File Offset: 0x0011FBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x001219B2 File Offset: 0x0011FBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x001219B9 File Offset: 0x0011FBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify()
		{
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x001219CC File Offset: 0x0011FBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify(ExploreLevelNotify other) : this()
		{
			this.countryExploreLevel_ = other.countryExploreLevel_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x001219F6 File Offset: 0x0011FBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify Clone()
		{
			return new ExploreLevelNotify(this);
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x001219FE File Offset: 0x0011FBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CountryExploreLevel> CountryExploreLevel
		{
			get
			{
				return this.countryExploreLevel_;
			}
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00121A06 File Offset: 0x0011FC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreLevelNotify);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00121A14 File Offset: 0x0011FC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreLevelNotify other)
		{
			return other != null && (other == this || (this.countryExploreLevel_.Equals(other.countryExploreLevel_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00121A48 File Offset: 0x0011FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.countryExploreLevel_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00121A7C File Offset: 0x0011FC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00121A89 File Offset: 0x0011FC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00121A92 File Offset: 0x0011FC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.countryExploreLevel_.WriteTo(ref output, ExploreLevelNotify._repeated_countryExploreLevel_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00121ABC File Offset: 0x0011FCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.countryExploreLevel_.CalculateSize(ExploreLevelNotify._repeated_countryExploreLevel_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00121AF5 File Offset: 0x0011FCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.countryExploreLevel_.Add(other.countryExploreLevel_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00121B23 File Offset: 0x0011FD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00121B2C File Offset: 0x0011FD2C
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.countryExploreLevel_.AddEntriesFrom(ref input, ExploreLevelNotify._repeated_countryExploreLevel_codec);
				}
			}
		}

		// Token: 0x04003E41 RID: 15937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E42 RID: 15938
		public const int CountryExploreLevelFieldNumber = 5;

		// Token: 0x04003E43 RID: 15939
		private static readonly FieldCodec<CountryExploreLevel> _repeated_countryExploreLevel_codec = FieldCodec.ForMessage<CountryExploreLevel>(42U, Aki.Protocol.CountryExploreLevel.Parser);

		// Token: 0x04003E44 RID: 15940
		private readonly RepeatedField<CountryExploreLevel> countryExploreLevel_ = new RepeatedField<CountryExploreLevel>();
	}
}
