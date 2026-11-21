using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000314 RID: 788
	[NetMessage(EMessageId.CountryExploreScoreInfoRequest)]
	public sealed class CountryExploreScoreInfoRequest : IMessage<CountryExploreScoreInfoRequest>, IMessage, IEquatable<CountryExploreScoreInfoRequest>, IDeepCloneable<CountryExploreScoreInfoRequest>, IBufferMessage
	{
		// Token: 0x06004F86 RID: 20358 RVA: 0x000C12CB File Offset: 0x000BF4CB
		[NullableContext(1)]
		public static CountryExploreScoreInfoRequest Create()
		{
			return new CountryExploreScoreInfoRequest();
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x000C12D2 File Offset: 0x000BF4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x000C12D5 File Offset: 0x000BF4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreScoreInfoRequest.Descriptor;
			}
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x000C12DC File Offset: 0x000BF4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest()
		{
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x000C12E4 File Offset: 0x000BF4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest(CountryExploreScoreInfoRequest other) : this()
		{
			this.countryId_ = other.countryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x000C1309 File Offset: 0x000BF509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreScoreInfoRequest Clone()
		{
			return new CountryExploreScoreInfoRequest(this);
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x000C1311 File Offset: 0x000BF511
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x000C1319 File Offset: 0x000BF519
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

		// Token: 0x06004F8E RID: 20366 RVA: 0x000C1322 File Offset: 0x000BF522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreScoreInfoRequest);
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x000C1330 File Offset: 0x000BF530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreScoreInfoRequest other)
		{
			return other != null && (other == this || (this.CountryId == other.CountryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x000C1360 File Offset: 0x000BF560
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

		// Token: 0x06004F91 RID: 20369 RVA: 0x000C139F File Offset: 0x000BF59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x000C13AC File Offset: 0x000BF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x000C13B5 File Offset: 0x000BF5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountryId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CountryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x000C13E8 File Offset: 0x000BF5E8
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

		// Token: 0x06004F95 RID: 20373 RVA: 0x000C1426 File Offset: 0x000BF626
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

		// Token: 0x06004F96 RID: 20374 RVA: 0x000C1457 File Offset: 0x000BF657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x000C1460 File Offset: 0x000BF660
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CountryId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003240 RID: 12864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003241 RID: 12865
		public const int CountryIdFieldNumber = 7;

		// Token: 0x04003242 RID: 12866
		private int countryId_;
	}
}
