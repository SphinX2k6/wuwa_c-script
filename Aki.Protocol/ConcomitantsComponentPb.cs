using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CD RID: 717
	public sealed class ConcomitantsComponentPb : IMessage<ConcomitantsComponentPb>, IMessage, IEquatable<ConcomitantsComponentPb>, IDeepCloneable<ConcomitantsComponentPb>, IBufferMessage
	{
		// Token: 0x060049C9 RID: 18889 RVA: 0x000B4B6C File Offset: 0x000B2D6C
		[NullableContext(1)]
		public static ConcomitantsComponentPb Create()
		{
			return new ConcomitantsComponentPb();
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060049CA RID: 18890 RVA: 0x000B4B73 File Offset: 0x000B2D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x000B4B76 File Offset: 0x000B2D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConcomitantsComponentPb.Descriptor;
			}
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x000B4B7D File Offset: 0x000B2D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb()
		{
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x000B4B9C File Offset: 0x000B2D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb(ConcomitantsComponentPb other) : this()
		{
			this.visionEntityIds_ = other.visionEntityIds_.Clone();
			this.customEntityIds_ = other.customEntityIds_.Clone();
			this.phantomRoleEid_ = other.phantomRoleEid_;
			this.weakVisionEid_ = other.weakVisionEid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x000B4BFA File Offset: 0x000B2DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb Clone()
		{
			return new ConcomitantsComponentPb(this);
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x000B4C02 File Offset: 0x000B2E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> VisionEntityIds
		{
			get
			{
				return this.visionEntityIds_;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x000B4C0A File Offset: 0x000B2E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> CustomEntityIds
		{
			get
			{
				return this.customEntityIds_;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x000B4C12 File Offset: 0x000B2E12
		// (set) Token: 0x060049D2 RID: 18898 RVA: 0x000B4C1A File Offset: 0x000B2E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PhantomRoleEid
		{
			get
			{
				return this.phantomRoleEid_;
			}
			set
			{
				this.phantomRoleEid_ = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x000B4C23 File Offset: 0x000B2E23
		// (set) Token: 0x060049D4 RID: 18900 RVA: 0x000B4C2B File Offset: 0x000B2E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long WeakVisionEid
		{
			get
			{
				return this.weakVisionEid_;
			}
			set
			{
				this.weakVisionEid_ = value;
			}
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x000B4C34 File Offset: 0x000B2E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConcomitantsComponentPb);
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x000B4C44 File Offset: 0x000B2E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConcomitantsComponentPb other)
		{
			return other != null && (other == this || (this.visionEntityIds_.Equals(other.visionEntityIds_) && this.customEntityIds_.Equals(other.customEntityIds_) && this.PhantomRoleEid == other.PhantomRoleEid && this.WeakVisionEid == other.WeakVisionEid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x000B4CB8 File Offset: 0x000B2EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.visionEntityIds_.GetHashCode();
			num ^= this.customEntityIds_.GetHashCode();
			if (this.PhantomRoleEid != 0L)
			{
				num ^= this.PhantomRoleEid.GetHashCode();
			}
			if (this.WeakVisionEid != 0L)
			{
				num ^= this.WeakVisionEid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x000B4D2C File Offset: 0x000B2F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x000B4D39 File Offset: 0x000B2F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x000B4D44 File Offset: 0x000B2F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.visionEntityIds_.WriteTo(ref output, ConcomitantsComponentPb._repeated_visionEntityIds_codec);
			this.customEntityIds_.WriteTo(ref output, ConcomitantsComponentPb._repeated_customEntityIds_codec);
			if (this.PhantomRoleEid != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PhantomRoleEid);
			}
			if (this.WeakVisionEid != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.WeakVisionEid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x000B4DC0 File Offset: 0x000B2FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.visionEntityIds_.CalculateSize(ConcomitantsComponentPb._repeated_visionEntityIds_codec);
			num += this.customEntityIds_.CalculateSize(ConcomitantsComponentPb._repeated_customEntityIds_codec);
			if (this.PhantomRoleEid != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PhantomRoleEid);
			}
			if (this.WeakVisionEid != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.WeakVisionEid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x000B4E3C File Offset: 0x000B303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConcomitantsComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.visionEntityIds_.Add(other.visionEntityIds_);
			this.customEntityIds_.Add(other.customEntityIds_);
			if (other.PhantomRoleEid != 0L)
			{
				this.PhantomRoleEid = other.PhantomRoleEid;
			}
			if (other.WeakVisionEid != 0L)
			{
				this.WeakVisionEid = other.WeakVisionEid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x000B4EAE File Offset: 0x000B30AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x000B4EB8 File Offset: 0x000B30B8
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
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.visionEntityIds_.AddEntriesFrom(ref input, ConcomitantsComponentPb._repeated_visionEntityIds_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_54;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_54;
					}
					if (num == 24U)
					{
						this.PhantomRoleEid = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.WeakVisionEid = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_54:
				this.customEntityIds_.AddEntriesFrom(ref input, ConcomitantsComponentPb._repeated_customEntityIds_codec);
			}
		}

		// Token: 0x04003095 RID: 12437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003096 RID: 12438
		public const int VisionEntityIdsFieldNumber = 1;

		// Token: 0x04003097 RID: 12439
		private static readonly FieldCodec<long> _repeated_visionEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04003098 RID: 12440
		private readonly RepeatedField<long> visionEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003099 RID: 12441
		public const int CustomEntityIdsFieldNumber = 2;

		// Token: 0x0400309A RID: 12442
		private static readonly FieldCodec<long> _repeated_customEntityIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x0400309B RID: 12443
		private readonly RepeatedField<long> customEntityIds_ = new RepeatedField<long>();

		// Token: 0x0400309C RID: 12444
		public const int PhantomRoleEidFieldNumber = 3;

		// Token: 0x0400309D RID: 12445
		private long phantomRoleEid_;

		// Token: 0x0400309E RID: 12446
		public const int WeakVisionEidFieldNumber = 4;

		// Token: 0x0400309F RID: 12447
		private long weakVisionEid_;
	}
}
