using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B49 RID: 2889
	[NetMessage(EMessageId.NewTowerSeasonRewardRequest)]
	public sealed class NewTowerSeasonRewardRequest : IMessage<NewTowerSeasonRewardRequest>, IMessage, IEquatable<NewTowerSeasonRewardRequest>, IDeepCloneable<NewTowerSeasonRewardRequest>, IBufferMessage
	{
		// Token: 0x0600FA9D RID: 64157 RVA: 0x002489DD File Offset: 0x00246BDD
		[NullableContext(1)]
		public static NewTowerSeasonRewardRequest Create()
		{
			return new NewTowerSeasonRewardRequest();
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600FA9E RID: 64158 RVA: 0x002489E4 File Offset: 0x00246BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600FA9F RID: 64159 RVA: 0x002489E7 File Offset: 0x00246BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600FAA0 RID: 64160 RVA: 0x002489EE File Offset: 0x00246BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest()
		{
		}

		// Token: 0x0600FAA1 RID: 64161 RVA: 0x00248A01 File Offset: 0x00246C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest(NewTowerSeasonRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAA2 RID: 64162 RVA: 0x00248A2B File Offset: 0x00246C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardRequest Clone()
		{
			return new NewTowerSeasonRewardRequest(this);
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600FAA3 RID: 64163 RVA: 0x00248A33 File Offset: 0x00246C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600FAA4 RID: 64164 RVA: 0x00248A3B File Offset: 0x00246C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonRewardRequest);
		}

		// Token: 0x0600FAA5 RID: 64165 RVA: 0x00248A49 File Offset: 0x00246C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAA6 RID: 64166 RVA: 0x00248A7C File Offset: 0x00246C7C
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

		// Token: 0x0600FAA7 RID: 64167 RVA: 0x00248AB0 File Offset: 0x00246CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAA8 RID: 64168 RVA: 0x00248ABD File Offset: 0x00246CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAA9 RID: 64169 RVA: 0x00248AC6 File Offset: 0x00246CC6
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

		// Token: 0x0600FAAA RID: 64170 RVA: 0x00248AF0 File Offset: 0x00246CF0
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

		// Token: 0x0600FAAB RID: 64171 RVA: 0x00248B29 File Offset: 0x00246D29
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

		// Token: 0x0600FAAC RID: 64172 RVA: 0x00248B57 File Offset: 0x00246D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAAD RID: 64173 RVA: 0x00248B60 File Offset: 0x00246D60
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerSeasonRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x0400644F RID: 25679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006450 RID: 25680
		public const int IndexsFieldNumber = 10;

		// Token: 0x04006451 RID: 25681
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04006452 RID: 25682
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
