using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123B RID: 4667
	public sealed class SkillInfoPb : IMessage<SkillInfoPb>, IMessage, IEquatable<SkillInfoPb>, IDeepCloneable<SkillInfoPb>, IBufferMessage
	{
		// Token: 0x06018DF4 RID: 101876 RVA: 0x0039E90E File Offset: 0x0039CB0E
		[NullableContext(1)]
		public static SkillInfoPb Create()
		{
			return new SkillInfoPb();
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x06018DF5 RID: 101877 RVA: 0x0039E915 File Offset: 0x0039CB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x06018DF6 RID: 101878 RVA: 0x0039E918 File Offset: 0x0039CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillInfoPb.Descriptor;
			}
		}

		// Token: 0x06018DF7 RID: 101879 RVA: 0x0039E91F File Offset: 0x0039CB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb()
		{
		}

		// Token: 0x06018DF8 RID: 101880 RVA: 0x0039E93D File Offset: 0x0039CB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb(SkillInfoPb other) : this()
		{
			this.skillCdInfoList_ = other.skillCdInfoList_.Clone();
			this.skillCdGroupInfoList_ = other.skillCdGroupInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DF9 RID: 101881 RVA: 0x0039E978 File Offset: 0x0039CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb Clone()
		{
			return new SkillInfoPb(this);
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x06018DFA RID: 101882 RVA: 0x0039E980 File Offset: 0x0039CB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillCdInfo> SkillCdInfoList
		{
			get
			{
				return this.skillCdInfoList_;
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x06018DFB RID: 101883 RVA: 0x0039E988 File Offset: 0x0039CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillCdGroupInfo> SkillCdGroupInfoList
		{
			get
			{
				return this.skillCdGroupInfoList_;
			}
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x0039E990 File Offset: 0x0039CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillInfoPb);
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x0039E9A0 File Offset: 0x0039CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillInfoPb other)
		{
			return other != null && (other == this || (this.skillCdInfoList_.Equals(other.skillCdInfoList_) && this.skillCdGroupInfoList_.Equals(other.skillCdGroupInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DFE RID: 101886 RVA: 0x0039E9F4 File Offset: 0x0039CBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillCdInfoList_.GetHashCode();
			num ^= this.skillCdGroupInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DFF RID: 101887 RVA: 0x0039EA36 File Offset: 0x0039CC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E00 RID: 101888 RVA: 0x0039EA43 File Offset: 0x0039CC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E01 RID: 101889 RVA: 0x0039EA4C File Offset: 0x0039CC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillCdInfoList_.WriteTo(ref output, SkillInfoPb._repeated_skillCdInfoList_codec);
			this.skillCdGroupInfoList_.WriteTo(ref output, SkillInfoPb._repeated_skillCdGroupInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E02 RID: 101890 RVA: 0x0039EA84 File Offset: 0x0039CC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillCdInfoList_.CalculateSize(SkillInfoPb._repeated_skillCdInfoList_codec);
			num += this.skillCdGroupInfoList_.CalculateSize(SkillInfoPb._repeated_skillCdGroupInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E03 RID: 101891 RVA: 0x0039EAD0 File Offset: 0x0039CCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.skillCdInfoList_.Add(other.skillCdInfoList_);
			this.skillCdGroupInfoList_.Add(other.skillCdGroupInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E04 RID: 101892 RVA: 0x0039EB0F File Offset: 0x0039CD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E05 RID: 101893 RVA: 0x0039EB18 File Offset: 0x0039CD18
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skillCdGroupInfoList_.AddEntriesFrom(ref input, SkillInfoPb._repeated_skillCdGroupInfoList_codec);
					}
				}
				else
				{
					this.skillCdInfoList_.AddEntriesFrom(ref input, SkillInfoPb._repeated_skillCdInfoList_codec);
				}
			}
		}

		// Token: 0x040092B6 RID: 37558
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092B7 RID: 37559
		public const int SkillCdInfoListFieldNumber = 1;

		// Token: 0x040092B8 RID: 37560
		private static readonly FieldCodec<SkillCdInfo> _repeated_skillCdInfoList_codec = FieldCodec.ForMessage<SkillCdInfo>(10U, SkillCdInfo.Parser);

		// Token: 0x040092B9 RID: 37561
		private readonly RepeatedField<SkillCdInfo> skillCdInfoList_ = new RepeatedField<SkillCdInfo>();

		// Token: 0x040092BA RID: 37562
		public const int SkillCdGroupInfoListFieldNumber = 2;

		// Token: 0x040092BB RID: 37563
		private static readonly FieldCodec<SkillCdGroupInfo> _repeated_skillCdGroupInfoList_codec = FieldCodec.ForMessage<SkillCdGroupInfo>(18U, SkillCdGroupInfo.Parser);

		// Token: 0x040092BC RID: 37564
		private readonly RepeatedField<SkillCdGroupInfo> skillCdGroupInfoList_ = new RepeatedField<SkillCdGroupInfo>();
	}
}
