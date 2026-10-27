using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030D RID: 781
	[NetMessage(EMessageId.CountryExploreScoreInfoRequest)]
	public sealed class CountryExploreScoreInfoRequest : IMessage<CountryExploreScoreInfoRequest>, IMessage, IEquatable<CountryExploreScoreInfoRequest>, IDeepCloneable<CountryExploreScoreInfoRequest>, IBufferMessage
	{
		// Token: 0x06004EAD RID: 20141 RVA: 0x000BEEDF File Offset: 0x000BD0DF
		[NullableContext(1)]
		public static CountryExploreScoreInfoRequest Create()
		{
			return new CountryExploreScoreInfoRequest();
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x000BEEE6 File Offset: 0x000BD0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x000BEEE9 File Offset: 0x000BD0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreScoreInfoRequest.Descriptor;
			}
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x000BEEF0 File Offset: 0x000BD0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest()
		{
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x000BEEF8 File Offset: 0x000BD0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest(CountryExploreScoreInfoRequest other) : this()
		{
			this.countryId_ = other.countryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x000BEF1D File Offset: 0x000BD11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest Clone()
		{
			return new CountryExploreScoreInfoRequest(this);
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x000BEF25 File Offset: 0x000BD125
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x000BEF2D File Offset: 0x000BD12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountryId
		{
			get
			{
				return this.countryId_;
			}
			set
			{
				this.countryId_ = value;
			}
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x000BEF36 File Offset: 0x000BD136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreScoreInfoRequest);
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x000BEF44 File Offset: 0x000BD144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreScoreInfoRequest other)
		{
			return other != null && (other == this || (this.CountryId == other.CountryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x000BEF74 File Offset: 0x000BD174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CountryId != 0)
			{
				num ^= this.CountryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x000BEFB3 File Offset: 0x000BD1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x000BEFC0 File Offset: 0x000BD1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x000BEFC9 File Offset: 0x000BD1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountryId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CountryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x000BEFFC File Offset: 0x000BD1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CountryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x000BF03A File Offset: 0x000BD23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CountryExploreScoreInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CountryId != 0)
			{
				this.CountryId = other.CountryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x000BF06B File Offset: 0x000BD26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x000BF074 File Offset: 0x000BD274
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CountryId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040031A9 RID: 12713
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031AA RID: 12714
		public const int CountryIdFieldNumber = 1;

		// Token: 0x040031AB RID: 12715
		private int countryId_;
	}
}
