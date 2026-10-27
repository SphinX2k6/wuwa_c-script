using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000040 RID: 64
	[NetMessage(EMessageId.AbyssRewardRequest)]
	public sealed class AbyssRewardRequest : IMessage<AbyssRewardRequest>, IMessage, IEquatable<AbyssRewardRequest>, IDeepCloneable<AbyssRewardRequest>, IBufferMessage
	{
		// Token: 0x06001396 RID: 5014 RVA: 0x000351AE File Offset: 0x000333AE
		[NullableContext(1)]
		public static AbyssRewardRequest Create()
		{
			return new AbyssRewardRequest();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x000351B5 File Offset: 0x000333B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000351B8 File Offset: 0x000333B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardRequest.Descriptor;
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000351BF File Offset: 0x000333BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest()
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000351D2 File Offset: 0x000333D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest(AbyssRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00035208 File Offset: 0x00033408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest Clone()
		{
			return new AbyssRewardRequest(this);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00035210 File Offset: 0x00033410
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00035218 File Offset: 0x00033418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00035221 File Offset: 0x00033421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00035229 File Offset: 0x00033429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardRequest);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00035238 File Offset: 0x00033438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00035288 File Offset: 0x00033488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000352D5 File Offset: 0x000334D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x000352E2 File Offset: 0x000334E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000352EC File Offset: 0x000334EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.ids_.WriteTo(ref output, AbyssRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0003533C File Offset: 0x0003353C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.ids_.CalculateSize(AbyssRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00035390 File Offset: 0x00033590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000353DD File Offset: 0x000335DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x000353E8 File Offset: 0x000335E8
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
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, AbyssRewardRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400201E RID: 8222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400201F RID: 8223
		public const int IdFieldNumber = 1;

		// Token: 0x04002020 RID: 8224
		private int id_;

		// Token: 0x04002021 RID: 8225
		public const int IdsFieldNumber = 13;

		// Token: 0x04002022 RID: 8226
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04002023 RID: 8227
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
