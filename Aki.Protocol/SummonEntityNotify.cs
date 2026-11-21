using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131D RID: 4893
	[NetMessage(EMessageId.SummonEntityNotify)]
	public sealed class SummonEntityNotify : IMessage<SummonEntityNotify>, IMessage, IEquatable<SummonEntityNotify>, IDeepCloneable<SummonEntityNotify>, IBufferMessage
	{
		// Token: 0x0601A160 RID: 106848 RVA: 0x003CD409 File Offset: 0x003CB609
		[NullableContext(1)]
		public static SummonEntityNotify Create()
		{
			return new SummonEntityNotify();
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x0601A161 RID: 106849 RVA: 0x003CD410 File Offset: 0x003CB610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x0601A162 RID: 106850 RVA: 0x003CD413 File Offset: 0x003CB613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonEntityNotify.Descriptor;
			}
		}

		// Token: 0x0601A163 RID: 106851 RVA: 0x003CD41A File Offset: 0x003CB61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify()
		{
		}

		// Token: 0x0601A164 RID: 106852 RVA: 0x003CD42D File Offset: 0x003CB62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify(SummonEntityNotify other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonIds_ = other.summonIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A165 RID: 106853 RVA: 0x003CD463 File Offset: 0x003CB663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify Clone()
		{
			return new SummonEntityNotify(this);
		}

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x0601A166 RID: 106854 RVA: 0x003CD46B File Offset: 0x003CB66B
		// (set) Token: 0x0601A167 RID: 106855 RVA: 0x003CD473 File Offset: 0x003CB673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x0601A168 RID: 106856 RVA: 0x003CD47C File Offset: 0x003CB67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SummonIds
		{
			get
			{
				return this.summonIds_;
			}
		}

		// Token: 0x0601A169 RID: 106857 RVA: 0x003CD484 File Offset: 0x003CB684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonEntityNotify);
		}

		// Token: 0x0601A16A RID: 106858 RVA: 0x003CD494 File Offset: 0x003CB694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonEntityNotify other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.summonIds_.Equals(other.summonIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A16B RID: 106859 RVA: 0x003CD4E4 File Offset: 0x003CB6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
			}
			num ^= this.summonIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A16C RID: 106860 RVA: 0x003CD531 File Offset: 0x003CB731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A16D RID: 106861 RVA: 0x003CD53E File Offset: 0x003CB73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A16E RID: 106862 RVA: 0x003CD548 File Offset: 0x003CB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SummonerId);
			}
			this.summonIds_.WriteTo(ref output, SummonEntityNotify._repeated_summonIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A16F RID: 106863 RVA: 0x003CD598 File Offset: 0x003CB798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			num += this.summonIds_.CalculateSize(SummonEntityNotify._repeated_summonIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A170 RID: 106864 RVA: 0x003CD5EC File Offset: 0x003CB7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			this.summonIds_.Add(other.summonIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A171 RID: 106865 RVA: 0x003CD639 File Offset: 0x003CB839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A172 RID: 106866 RVA: 0x003CD644 File Offset: 0x003CB844
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
				if (num != 24U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.summonIds_.AddEntriesFrom(ref input, SummonEntityNotify._repeated_summonIds_codec);
					}
				}
				else
				{
					this.SummonerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009985 RID: 39301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009986 RID: 39302
		public const int SummonerIdFieldNumber = 3;

		// Token: 0x04009987 RID: 39303
		private long summonerId_;

		// Token: 0x04009988 RID: 39304
		public const int SummonIdsFieldNumber = 14;

		// Token: 0x04009989 RID: 39305
		private static readonly FieldCodec<long> _repeated_summonIds_codec = FieldCodec.ForInt64(114U);

		// Token: 0x0400998A RID: 39306
		private readonly RepeatedField<long> summonIds_ = new RepeatedField<long>();
	}
}
