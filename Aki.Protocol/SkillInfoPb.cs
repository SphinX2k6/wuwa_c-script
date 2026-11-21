using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001278 RID: 4728
	public sealed class SkillInfoPb : IMessage<SkillInfoPb>, IMessage, IEquatable<SkillInfoPb>, IDeepCloneable<SkillInfoPb>, IBufferMessage
	{
		// Token: 0x060193DE RID: 103390 RVA: 0x003AE86E File Offset: 0x003ACA6E
		[NullableContext(1)]
		public static SkillInfoPb Create()
		{
			return new SkillInfoPb();
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x060193DF RID: 103391 RVA: 0x003AE875 File Offset: 0x003ACA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x060193E0 RID: 103392 RVA: 0x003AE878 File Offset: 0x003ACA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillInfoPb.Descriptor;
			}
		}

		// Token: 0x060193E1 RID: 103393 RVA: 0x003AE87F File Offset: 0x003ACA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb()
		{
		}

		// Token: 0x060193E2 RID: 103394 RVA: 0x003AE89D File Offset: 0x003ACA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb(SkillInfoPb other) : this()
		{
			this.skillCdInfoList_ = other.skillCdInfoList_.Clone();
			this.skillCdGroupInfoList_ = other.skillCdGroupInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193E3 RID: 103395 RVA: 0x003AE8D8 File Offset: 0x003ACAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb Clone()
		{
			return new SkillInfoPb(this);
		}

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x060193E4 RID: 103396 RVA: 0x003AE8E0 File Offset: 0x003ACAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillCdInfo> SkillCdInfoList
		{
			get
			{
				return this.skillCdInfoList_;
			}
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x060193E5 RID: 103397 RVA: 0x003AE8E8 File Offset: 0x003ACAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillCdGroupInfo> SkillCdGroupInfoList
		{
			get
			{
				return this.skillCdGroupInfoList_;
			}
		}

		// Token: 0x060193E6 RID: 103398 RVA: 0x003AE8F0 File Offset: 0x003ACAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillInfoPb);
		}

		// Token: 0x060193E7 RID: 103399 RVA: 0x003AE900 File Offset: 0x003ACB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillInfoPb other)
		{
			return other != null && (other == this || (this.skillCdInfoList_.Equals(other.skillCdInfoList_) && this.skillCdGroupInfoList_.Equals(other.skillCdGroupInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x003AE954 File Offset: 0x003ACB54
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

		// Token: 0x060193E9 RID: 103401 RVA: 0x003AE996 File Offset: 0x003ACB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193EA RID: 103402 RVA: 0x003AE9A3 File Offset: 0x003ACBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193EB RID: 103403 RVA: 0x003AE9AC File Offset: 0x003ACBAC
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

		// Token: 0x060193EC RID: 103404 RVA: 0x003AE9E4 File Offset: 0x003ACBE4
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

		// Token: 0x060193ED RID: 103405 RVA: 0x003AEA30 File Offset: 0x003ACC30
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

		// Token: 0x060193EE RID: 103406 RVA: 0x003AEA6F File Offset: 0x003ACC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193EF RID: 103407 RVA: 0x003AEA78 File Offset: 0x003ACC78
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

		// Token: 0x04009568 RID: 38248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009569 RID: 38249
		public const int SkillCdInfoListFieldNumber = 1;

		// Token: 0x0400956A RID: 38250
		private static readonly FieldCodec<SkillCdInfo> _repeated_skillCdInfoList_codec = FieldCodec.ForMessage<SkillCdInfo>(10U, SkillCdInfo.Parser);

		// Token: 0x0400956B RID: 38251
		private readonly RepeatedField<SkillCdInfo> skillCdInfoList_ = new RepeatedField<SkillCdInfo>();

		// Token: 0x0400956C RID: 38252
		public const int SkillCdGroupInfoListFieldNumber = 2;

		// Token: 0x0400956D RID: 38253
		private static readonly FieldCodec<SkillCdGroupInfo> _repeated_skillCdGroupInfoList_codec = FieldCodec.ForMessage<SkillCdGroupInfo>(18U, SkillCdGroupInfo.Parser);

		// Token: 0x0400956E RID: 38254
		private readonly RepeatedField<SkillCdGroupInfo> skillCdGroupInfoList_ = new RepeatedField<SkillCdGroupInfo>();
	}
}
