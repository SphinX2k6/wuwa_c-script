using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4B RID: 2891
	[NetMessage(EMessageId.NewTowerSeasonScoreRewardRequest)]
	public sealed class NewTowerSeasonScoreRewardRequest : IMessage<NewTowerSeasonScoreRewardRequest>, IMessage, IEquatable<NewTowerSeasonScoreRewardRequest>, IDeepCloneable<NewTowerSeasonScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600FAC1 RID: 64193 RVA: 0x00248D9D File Offset: 0x00246F9D
		[NullableContext(1)]
		public static NewTowerSeasonScoreRewardRequest Create()
		{
			return new NewTowerSeasonScoreRewardRequest();
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600FAC2 RID: 64194 RVA: 0x00248DA4 File Offset: 0x00246FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600FAC3 RID: 64195 RVA: 0x00248DA7 File Offset: 0x00246FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600FAC4 RID: 64196 RVA: 0x00248DAE File Offset: 0x00246FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest()
		{
		}

		// Token: 0x0600FAC5 RID: 64197 RVA: 0x00248DC1 File Offset: 0x00246FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest(NewTowerSeasonScoreRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAC6 RID: 64198 RVA: 0x00248DEB File Offset: 0x00246FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest Clone()
		{
			return new NewTowerSeasonScoreRewardRequest(this);
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600FAC7 RID: 64199 RVA: 0x00248DF3 File Offset: 0x00246FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600FAC8 RID: 64200 RVA: 0x00248DFB File Offset: 0x00246FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonScoreRewardRequest);
		}

		// Token: 0x0600FAC9 RID: 64201 RVA: 0x00248E09 File Offset: 0x00247009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonScoreRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FACA RID: 64202 RVA: 0x00248E3C File Offset: 0x0024703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.indexs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FACB RID: 64203 RVA: 0x00248E70 File Offset: 0x00247070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FACC RID: 64204 RVA: 0x00248E7D File Offset: 0x0024707D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FACD RID: 64205 RVA: 0x00248E86 File Offset: 0x00247086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.indexs_.WriteTo(ref output, NewTowerSeasonScoreRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FACE RID: 64206 RVA: 0x00248EB0 File Offset: 0x002470B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.indexs_.CalculateSize(NewTowerSeasonScoreRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FACF RID: 64207 RVA: 0x00248EE9 File Offset: 0x002470E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.indexs_.Add(other.indexs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FAD0 RID: 64208 RVA: 0x00248F17 File Offset: 0x00247117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAD1 RID: 64209 RVA: 0x00248F20 File Offset: 0x00247120
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerSeasonScoreRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x04006456 RID: 25686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006457 RID: 25687
		public const int IndexsFieldNumber = 2;

		// Token: 0x04006458 RID: 25688
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006459 RID: 25689
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
