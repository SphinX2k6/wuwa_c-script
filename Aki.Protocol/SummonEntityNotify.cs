using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AE RID: 4782
	[NetMessage(EMessageId.SummonEntityNotify)]
	public sealed class SummonEntityNotify : IMessage<SummonEntityNotify>, IMessage, IEquatable<SummonEntityNotify>, IDeepCloneable<SummonEntityNotify>, IBufferMessage
	{
		// Token: 0x0601972A RID: 104234 RVA: 0x003B2CCD File Offset: 0x003B0ECD
		[NullableContext(1)]
		public static SummonEntityNotify Create()
		{
			return new SummonEntityNotify();
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x0601972B RID: 104235 RVA: 0x003B2CD4 File Offset: 0x003B0ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x0601972C RID: 104236 RVA: 0x003B2CD7 File Offset: 0x003B0ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonEntityNotify.Descriptor;
			}
		}

		// Token: 0x0601972D RID: 104237 RVA: 0x003B2CDE File Offset: 0x003B0EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify()
		{
		}

		// Token: 0x0601972E RID: 104238 RVA: 0x003B2CF1 File Offset: 0x003B0EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify(SummonEntityNotify other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonIds_ = other.summonIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601972F RID: 104239 RVA: 0x003B2D27 File Offset: 0x003B0F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonEntityNotify Clone()
		{
			return new SummonEntityNotify(this);
		}

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x06019730 RID: 104240 RVA: 0x003B2D2F File Offset: 0x003B0F2F
		// (set) Token: 0x06019731 RID: 104241 RVA: 0x003B2D37 File Offset: 0x003B0F37
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

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x06019732 RID: 104242 RVA: 0x003B2D40 File Offset: 0x003B0F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SummonIds
		{
			get
			{
				return this.summonIds_;
			}
		}

		// Token: 0x06019733 RID: 104243 RVA: 0x003B2D48 File Offset: 0x003B0F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonEntityNotify);
		}

		// Token: 0x06019734 RID: 104244 RVA: 0x003B2D58 File Offset: 0x003B0F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonEntityNotify other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.summonIds_.Equals(other.summonIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019735 RID: 104245 RVA: 0x003B2DA8 File Offset: 0x003B0FA8
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

		// Token: 0x06019736 RID: 104246 RVA: 0x003B2DF5 File Offset: 0x003B0FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019737 RID: 104247 RVA: 0x003B2E02 File Offset: 0x003B1002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019738 RID: 104248 RVA: 0x003B2E0C File Offset: 0x003B100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.summonIds_.WriteTo(ref output, SummonEntityNotify._repeated_summonIds_codec);
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.SummonerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019739 RID: 104249 RVA: 0x003B2E5C File Offset: 0x003B105C
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

		// Token: 0x0601973A RID: 104250 RVA: 0x003B2EB0 File Offset: 0x003B10B0
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

		// Token: 0x0601973B RID: 104251 RVA: 0x003B2EFD File Offset: 0x003B10FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601973C RID: 104252 RVA: 0x003B2F08 File Offset: 0x003B1108
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
				if (num != 64U && num != 66U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SummonerId = input.ReadInt64();
					}
				}
				else
				{
					this.summonIds_.AddEntriesFrom(ref input, SummonEntityNotify._repeated_summonIds_codec);
				}
			}
		}

		// Token: 0x0400955B RID: 38235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400955C RID: 38236
		public const int SummonerIdFieldNumber = 13;

		// Token: 0x0400955D RID: 38237
		private long summonerId_;

		// Token: 0x0400955E RID: 38238
		public const int SummonIdsFieldNumber = 8;

		// Token: 0x0400955F RID: 38239
		private static readonly FieldCodec<long> _repeated_summonIds_codec = FieldCodec.ForInt64(66U);

		// Token: 0x04009560 RID: 38240
		private readonly RepeatedField<long> summonIds_ = new RepeatedField<long>();
	}
}
