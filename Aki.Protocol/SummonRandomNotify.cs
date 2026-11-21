using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131F RID: 4895
	[NetMessage(EMessageId.SummonRandomNotify)]
	public sealed class SummonRandomNotify : IMessage<SummonRandomNotify>, IMessage, IEquatable<SummonRandomNotify>, IDeepCloneable<SummonRandomNotify>, IBufferMessage
	{
		// Token: 0x0601A18A RID: 106890 RVA: 0x003CD9F6 File Offset: 0x003CBBF6
		[NullableContext(1)]
		public static SummonRandomNotify Create()
		{
			return new SummonRandomNotify();
		}

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x0601A18B RID: 106891 RVA: 0x003CD9FD File Offset: 0x003CBBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x0601A18C RID: 106892 RVA: 0x003CDA00 File Offset: 0x003CBC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomNotify.Descriptor;
			}
		}

		// Token: 0x0601A18D RID: 106893 RVA: 0x003CDA07 File Offset: 0x003CBC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify()
		{
		}

		// Token: 0x0601A18E RID: 106894 RVA: 0x003CDA1A File Offset: 0x003CBC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify(SummonRandomNotify other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonIds_ = other.summonIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A18F RID: 106895 RVA: 0x003CDA50 File Offset: 0x003CBC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomNotify Clone()
		{
			return new SummonRandomNotify(this);
		}

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x0601A190 RID: 106896 RVA: 0x003CDA58 File Offset: 0x003CBC58
		// (set) Token: 0x0601A191 RID: 106897 RVA: 0x003CDA60 File Offset: 0x003CBC60
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

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x0601A192 RID: 106898 RVA: 0x003CDA69 File Offset: 0x003CBC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SummonIds
		{
			get
			{
				return this.summonIds_;
			}
		}

		// Token: 0x0601A193 RID: 106899 RVA: 0x003CDA71 File Offset: 0x003CBC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomNotify);
		}

		// Token: 0x0601A194 RID: 106900 RVA: 0x003CDA80 File Offset: 0x003CBC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomNotify other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.summonIds_.Equals(other.summonIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A195 RID: 106901 RVA: 0x003CDAD0 File Offset: 0x003CBCD0
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

		// Token: 0x0601A196 RID: 106902 RVA: 0x003CDB1D File Offset: 0x003CBD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A197 RID: 106903 RVA: 0x003CDB2A File Offset: 0x003CBD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A198 RID: 106904 RVA: 0x003CDB34 File Offset: 0x003CBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SummonerId);
			}
			this.summonIds_.WriteTo(ref output, SummonRandomNotify._repeated_summonIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A199 RID: 106905 RVA: 0x003CDB84 File Offset: 0x003CBD84
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

		// Token: 0x0601A19A RID: 106906 RVA: 0x003CDBD8 File Offset: 0x003CBDD8
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

		// Token: 0x0601A19B RID: 106907 RVA: 0x003CDC25 File Offset: 0x003CBE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A19C RID: 106908 RVA: 0x003CDC30 File Offset: 0x003CBE30
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
				if (num != 72U)
				{
					if (num != 80U && num != 82U)
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

		// Token: 0x04009992 RID: 39314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009993 RID: 39315
		public const int SummonerIdFieldNumber = 9;

		// Token: 0x04009994 RID: 39316
		private long summonerId_;

		// Token: 0x04009995 RID: 39317
		public const int SummonIdsFieldNumber = 10;

		// Token: 0x04009996 RID: 39318
		private static readonly FieldCodec<long> _repeated_summonIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04009997 RID: 39319
		private readonly RepeatedField<long> summonIds_ = new RepeatedField<long>();
	}
}
