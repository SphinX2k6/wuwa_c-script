using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F7 RID: 1271
	[NetMessage(EMessageId.ExploreLevelNotify)]
	public sealed class ExploreLevelNotify : IMessage<ExploreLevelNotify>, IMessage, IEquatable<ExploreLevelNotify>, IDeepCloneable<ExploreLevelNotify>, IBufferMessage
	{
		// Token: 0x06007804 RID: 30724 RVA: 0x0012483C File Offset: 0x00122A3C
		[NullableContext(1)]
		public static ExploreLevelNotify Create()
		{
			return new ExploreLevelNotify();
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x00124843 File Offset: 0x00122A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x00124846 File Offset: 0x00122A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreLevelNotify.Descriptor;
			}
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0012484D File Offset: 0x00122A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify()
		{
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00124860 File Offset: 0x00122A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify(ExploreLevelNotify other) : this()
		{
			this.countryExploreLevel_ = other.countryExploreLevel_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x0012488A File Offset: 0x00122A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreLevelNotify Clone()
		{
			return new ExploreLevelNotify(this);
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x00124892 File Offset: 0x00122A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CountryExploreLevel> CountryExploreLevel
		{
			get
			{
				return this.countryExploreLevel_;
			}
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x0012489A File Offset: 0x00122A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreLevelNotify);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x001248A8 File Offset: 0x00122AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreLevelNotify other)
		{
			return other != null && (other == this || (this.countryExploreLevel_.Equals(other.countryExploreLevel_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x001248DC File Offset: 0x00122ADC
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

		// Token: 0x0600780E RID: 30734 RVA: 0x00124910 File Offset: 0x00122B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x0012491D File Offset: 0x00122B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00124926 File Offset: 0x00122B26
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

		// Token: 0x06007811 RID: 30737 RVA: 0x00124950 File Offset: 0x00122B50
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

		// Token: 0x06007812 RID: 30738 RVA: 0x00124989 File Offset: 0x00122B89
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

		// Token: 0x06007813 RID: 30739 RVA: 0x001249B7 File Offset: 0x00122BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x001249C0 File Offset: 0x00122BC0
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
					this.countryExploreLevel_.AddEntriesFrom(ref input, ExploreLevelNotify._repeated_countryExploreLevel_codec);
				}
			}
		}

		// Token: 0x04003E50 RID: 15952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E51 RID: 15953
		public const int CountryExploreLevelFieldNumber = 12;

		// Token: 0x04003E52 RID: 15954
		private static readonly FieldCodec<CountryExploreLevel> _repeated_countryExploreLevel_codec = FieldCodec.ForMessage<CountryExploreLevel>(98U, Aki.Protocol.CountryExploreLevel.Parser);

		// Token: 0x04003E53 RID: 15955
		private readonly RepeatedField<CountryExploreLevel> countryExploreLevel_ = new RepeatedField<CountryExploreLevel>();
	}
}
