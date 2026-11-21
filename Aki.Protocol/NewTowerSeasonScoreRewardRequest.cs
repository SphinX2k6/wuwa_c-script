using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3A RID: 2874
	[NetMessage(EMessageId.NewTowerSeasonScoreRewardRequest)]
	public sealed class NewTowerSeasonScoreRewardRequest : IMessage<NewTowerSeasonScoreRewardRequest>, IMessage, IEquatable<NewTowerSeasonScoreRewardRequest>, IDeepCloneable<NewTowerSeasonScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F9A7 RID: 63911 RVA: 0x00246B85 File Offset: 0x00244D85
		[NullableContext(1)]
		public static NewTowerSeasonScoreRewardRequest Create()
		{
			return new NewTowerSeasonScoreRewardRequest();
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600F9A8 RID: 63912 RVA: 0x00246B8C File Offset: 0x00244D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600F9A9 RID: 63913 RVA: 0x00246B8F File Offset: 0x00244D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F9AA RID: 63914 RVA: 0x00246B96 File Offset: 0x00244D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest()
		{
		}

		// Token: 0x0600F9AB RID: 63915 RVA: 0x00246BA9 File Offset: 0x00244DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest(NewTowerSeasonScoreRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9AC RID: 63916 RVA: 0x00246BD3 File Offset: 0x00244DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonScoreRewardRequest Clone()
		{
			return new NewTowerSeasonScoreRewardRequest(this);
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600F9AD RID: 63917 RVA: 0x00246BDB File Offset: 0x00244DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600F9AE RID: 63918 RVA: 0x00246BE3 File Offset: 0x00244DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonScoreRewardRequest);
		}

		// Token: 0x0600F9AF RID: 63919 RVA: 0x00246BF1 File Offset: 0x00244DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonScoreRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9B0 RID: 63920 RVA: 0x00246C24 File Offset: 0x00244E24
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

		// Token: 0x0600F9B1 RID: 63921 RVA: 0x00246C58 File Offset: 0x00244E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9B2 RID: 63922 RVA: 0x00246C65 File Offset: 0x00244E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9B3 RID: 63923 RVA: 0x00246C6E File Offset: 0x00244E6E
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

		// Token: 0x0600F9B4 RID: 63924 RVA: 0x00246C98 File Offset: 0x00244E98
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

		// Token: 0x0600F9B5 RID: 63925 RVA: 0x00246CD1 File Offset: 0x00244ED1
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

		// Token: 0x0600F9B6 RID: 63926 RVA: 0x00246CFF File Offset: 0x00244EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9B7 RID: 63927 RVA: 0x00246D08 File Offset: 0x00244F08
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerSeasonScoreRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x0400645F RID: 25695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006460 RID: 25696
		public const int IndexsFieldNumber = 6;

		// Token: 0x04006461 RID: 25697
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006462 RID: 25698
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
