using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B38 RID: 2872
	[NetMessage(EMessageId.NewTowerSeasonRewardRequest)]
	public sealed class NewTowerSeasonRewardRequest : IMessage<NewTowerSeasonRewardRequest>, IMessage, IEquatable<NewTowerSeasonRewardRequest>, IDeepCloneable<NewTowerSeasonRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F983 RID: 63875 RVA: 0x002467C5 File Offset: 0x002449C5
		[NullableContext(1)]
		public static NewTowerSeasonRewardRequest Create()
		{
			return new NewTowerSeasonRewardRequest();
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600F984 RID: 63876 RVA: 0x002467CC File Offset: 0x002449CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600F985 RID: 63877 RVA: 0x002467CF File Offset: 0x002449CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F986 RID: 63878 RVA: 0x002467D6 File Offset: 0x002449D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest()
		{
		}

		// Token: 0x0600F987 RID: 63879 RVA: 0x002467E9 File Offset: 0x002449E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest(NewTowerSeasonRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F988 RID: 63880 RVA: 0x00246813 File Offset: 0x00244A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest Clone()
		{
			return new NewTowerSeasonRewardRequest(this);
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600F989 RID: 63881 RVA: 0x0024681B File Offset: 0x00244A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600F98A RID: 63882 RVA: 0x00246823 File Offset: 0x00244A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonRewardRequest);
		}

		// Token: 0x0600F98B RID: 63883 RVA: 0x00246831 File Offset: 0x00244A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F98C RID: 63884 RVA: 0x00246864 File Offset: 0x00244A64
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

		// Token: 0x0600F98D RID: 63885 RVA: 0x00246898 File Offset: 0x00244A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F98E RID: 63886 RVA: 0x002468A5 File Offset: 0x00244AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F98F RID: 63887 RVA: 0x002468AE File Offset: 0x00244AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.indexs_.WriteTo(ref output, NewTowerSeasonRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F990 RID: 63888 RVA: 0x002468D8 File Offset: 0x00244AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.indexs_.CalculateSize(NewTowerSeasonRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F991 RID: 63889 RVA: 0x00246911 File Offset: 0x00244B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.indexs_.Add(other.indexs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F992 RID: 63890 RVA: 0x0024693F File Offset: 0x00244B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F993 RID: 63891 RVA: 0x00246948 File Offset: 0x00244B48
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerSeasonRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x04006458 RID: 25688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006459 RID: 25689
		public const int IndexsFieldNumber = 1;

		// Token: 0x0400645A RID: 25690
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400645B RID: 25691
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
