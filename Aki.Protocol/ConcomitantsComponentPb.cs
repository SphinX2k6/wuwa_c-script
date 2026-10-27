using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C6 RID: 710
	public sealed class ConcomitantsComponentPb : IMessage<ConcomitantsComponentPb>, IMessage, IEquatable<ConcomitantsComponentPb>, IDeepCloneable<ConcomitantsComponentPb>, IBufferMessage
	{
		// Token: 0x060048F0 RID: 18672 RVA: 0x000B2784 File Offset: 0x000B0984
		[NullableContext(1)]
		public static ConcomitantsComponentPb Create()
		{
			return new ConcomitantsComponentPb();
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x000B278B File Offset: 0x000B098B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x000B278E File Offset: 0x000B098E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConcomitantsComponentPb.Descriptor;
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x000B2795 File Offset: 0x000B0995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb()
		{
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x000B27B4 File Offset: 0x000B09B4
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

		// Token: 0x060048F5 RID: 18677 RVA: 0x000B2812 File Offset: 0x000B0A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb Clone()
		{
			return new ConcomitantsComponentPb(this);
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x000B281A File Offset: 0x000B0A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> VisionEntityIds
		{
			get
			{
				return this.visionEntityIds_;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x000B2822 File Offset: 0x000B0A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> CustomEntityIds
		{
			get
			{
				return this.customEntityIds_;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x000B282A File Offset: 0x000B0A2A
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x000B2832 File Offset: 0x000B0A32
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x000B283B File Offset: 0x000B0A3B
		// (set) Token: 0x060048FB RID: 18683 RVA: 0x000B2843 File Offset: 0x000B0A43
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

		// Token: 0x060048FC RID: 18684 RVA: 0x000B284C File Offset: 0x000B0A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConcomitantsComponentPb);
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x000B285C File Offset: 0x000B0A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConcomitantsComponentPb other)
		{
			return other != null && (other == this || (this.visionEntityIds_.Equals(other.visionEntityIds_) && this.customEntityIds_.Equals(other.customEntityIds_) && this.PhantomRoleEid == other.PhantomRoleEid && this.WeakVisionEid == other.WeakVisionEid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x000B28D0 File Offset: 0x000B0AD0
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

		// Token: 0x060048FF RID: 18687 RVA: 0x000B2944 File Offset: 0x000B0B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x000B2951 File Offset: 0x000B0B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x000B295C File Offset: 0x000B0B5C
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

		// Token: 0x06004902 RID: 18690 RVA: 0x000B29D8 File Offset: 0x000B0BD8
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

		// Token: 0x06004903 RID: 18691 RVA: 0x000B2A54 File Offset: 0x000B0C54
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

		// Token: 0x06004904 RID: 18692 RVA: 0x000B2AC6 File Offset: 0x000B0CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x000B2AD0 File Offset: 0x000B0CD0
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

		// Token: 0x04002FFE RID: 12286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FFF RID: 12287
		public const int VisionEntityIdsFieldNumber = 1;

		// Token: 0x04003000 RID: 12288
		private static readonly FieldCodec<long> _repeated_visionEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04003001 RID: 12289
		private readonly RepeatedField<long> visionEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003002 RID: 12290
		public const int CustomEntityIdsFieldNumber = 2;

		// Token: 0x04003003 RID: 12291
		private static readonly FieldCodec<long> _repeated_customEntityIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04003004 RID: 12292
		private readonly RepeatedField<long> customEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003005 RID: 12293
		public const int PhantomRoleEidFieldNumber = 3;

		// Token: 0x04003006 RID: 12294
		private long phantomRoleEid_;

		// Token: 0x04003007 RID: 12295
		public const int WeakVisionEidFieldNumber = 4;

		// Token: 0x04003008 RID: 12296
		private long weakVisionEid_;
	}
}
