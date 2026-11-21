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
		// Token: 0x060013C1 RID: 5057 RVA: 0x00035762 File Offset: 0x00033962
		[NullableContext(1)]
		public static AbyssRewardRequest Create()
		{
			return new AbyssRewardRequest();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00035769 File Offset: 0x00033969
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
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0003576C File Offset: 0x0003396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardRequest.Descriptor;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00035773 File Offset: 0x00033973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest()
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00035786 File Offset: 0x00033986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest(AbyssRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x000357BC File Offset: 0x000339BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardRequest Clone()
		{
			return new AbyssRewardRequest(this);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000357C4 File Offset: 0x000339C4
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x000357CC File Offset: 0x000339CC
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
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000357D5 File Offset: 0x000339D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000357DD File Offset: 0x000339DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardRequest);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000357EC File Offset: 0x000339EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0003583C File Offset: 0x00033A3C
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

		// Token: 0x060013CD RID: 5069 RVA: 0x00035889 File Offset: 0x00033A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00035896 File Offset: 0x00033A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000358A0 File Offset: 0x00033AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			this.ids_.WriteTo(ref output, AbyssRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000358F0 File Offset: 0x00033AF0
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

		// Token: 0x060013D1 RID: 5073 RVA: 0x00035944 File Offset: 0x00033B44
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

		// Token: 0x060013D2 RID: 5074 RVA: 0x00035991 File Offset: 0x00033B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0003599C File Offset: 0x00033B9C
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
				if (num != 112U)
				{
					if (num != 120U && num != 122U)
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

		// Token: 0x04002074 RID: 8308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002075 RID: 8309
		public const int IdFieldNumber = 14;

		// Token: 0x04002076 RID: 8310
		private int id_;

		// Token: 0x04002077 RID: 8311
		public const int IdsFieldNumber = 15;

		// Token: 0x04002078 RID: 8312
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04002079 RID: 8313
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
