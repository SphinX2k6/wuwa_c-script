using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B0 RID: 4784
	[NetMessage(EMessageId.SummonRandomNotify)]
	public sealed class SummonRandomNotify : IMessage<SummonRandomNotify>, IMessage, IEquatable<SummonRandomNotify>, IDeepCloneable<SummonRandomNotify>, IBufferMessage
	{
		// Token: 0x06019754 RID: 104276 RVA: 0x003B32BA File Offset: 0x003B14BA
		[NullableContext(1)]
		public static SummonRandomNotify Create()
		{
			return new SummonRandomNotify();
		}

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x06019755 RID: 104277 RVA: 0x003B32C1 File Offset: 0x003B14C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x06019756 RID: 104278 RVA: 0x003B32C4 File Offset: 0x003B14C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomNotify.Descriptor;
			}
		}

		// Token: 0x06019757 RID: 104279 RVA: 0x003B32CB File Offset: 0x003B14CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify()
		{
		}

		// Token: 0x06019758 RID: 104280 RVA: 0x003B32DE File Offset: 0x003B14DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify(SummonRandomNotify other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonIds_ = other.summonIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019759 RID: 104281 RVA: 0x003B3314 File Offset: 0x003B1514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify Clone()
		{
			return new SummonRandomNotify(this);
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x0601975A RID: 104282 RVA: 0x003B331C File Offset: 0x003B151C
		// (set) Token: 0x0601975B RID: 104283 RVA: 0x003B3324 File Offset: 0x003B1524
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

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x0601975C RID: 104284 RVA: 0x003B332D File Offset: 0x003B152D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SummonIds
		{
			get
			{
				return this.summonIds_;
			}
		}

		// Token: 0x0601975D RID: 104285 RVA: 0x003B3335 File Offset: 0x003B1535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomNotify);
		}

		// Token: 0x0601975E RID: 104286 RVA: 0x003B3344 File Offset: 0x003B1544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomNotify other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.summonIds_.Equals(other.summonIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601975F RID: 104287 RVA: 0x003B3394 File Offset: 0x003B1594
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

		// Token: 0x06019760 RID: 104288 RVA: 0x003B33E1 File Offset: 0x003B15E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019761 RID: 104289 RVA: 0x003B33EE File Offset: 0x003B15EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019762 RID: 104290 RVA: 0x003B33F8 File Offset: 0x003B15F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SummonerId);
			}
			this.summonIds_.WriteTo(ref output, SummonRandomNotify._repeated_summonIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019763 RID: 104291 RVA: 0x003B3448 File Offset: 0x003B1648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			num += this.summonIds_.CalculateSize(SummonRandomNotify._repeated_summonIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019764 RID: 104292 RVA: 0x003B349C File Offset: 0x003B169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRandomNotify other)
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

		// Token: 0x06019765 RID: 104293 RVA: 0x003B34E9 File Offset: 0x003B16E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019766 RID: 104294 RVA: 0x003B34F4 File Offset: 0x003B16F4
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
				if (num != 32U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.summonIds_.AddEntriesFrom(ref input, SummonRandomNotify._repeated_summonIds_codec);
					}
				}
				else
				{
					this.SummonerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009568 RID: 38248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009569 RID: 38249
		public const int SummonerIdFieldNumber = 4;

		// Token: 0x0400956A RID: 38250
		private long summonerId_;

		// Token: 0x0400956B RID: 38251
		public const int SummonIdsFieldNumber = 14;

		// Token: 0x0400956C RID: 38252
		private static readonly FieldCodec<long> _repeated_summonIds_codec = FieldCodec.ForInt64(114U);

		// Token: 0x0400956D RID: 38253
		private readonly RepeatedField<long> summonIds_ = new RepeatedField<long>();
	}
}
