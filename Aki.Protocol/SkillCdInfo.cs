using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001273 RID: 4723
	public sealed class SkillCdInfo : IMessage<SkillCdInfo>, IMessage, IEquatable<SkillCdInfo>, IDeepCloneable<SkillCdInfo>, IBufferMessage
	{
		// Token: 0x0601936D RID: 103277 RVA: 0x003AD72E File Offset: 0x003AB92E
		[NullableContext(1)]
		public static SkillCdInfo Create()
		{
			return new SkillCdInfo();
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x0601936E RID: 103278 RVA: 0x003AD735 File Offset: 0x003AB935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillCdInfo> Parser
		{
			get
			{
				return SkillCdInfo._parser;
			}
		}

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x0601936F RID: 103279 RVA: 0x003AD73C File Offset: 0x003AB93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x06019370 RID: 103280 RVA: 0x003AD73F File Offset: 0x003AB93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillCdInfo.Descriptor;
			}
		}

		// Token: 0x06019371 RID: 103281 RVA: 0x003AD746 File Offset: 0x003AB946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo()
		{
		}

		// Token: 0x06019372 RID: 103282 RVA: 0x003AD759 File Offset: 0x003AB959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo(SkillCdInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.cdEndTimeList_ = other.cdEndTimeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019373 RID: 103283 RVA: 0x003AD78F File Offset: 0x003AB98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo Clone()
		{
			return new SkillCdInfo(this);
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x06019374 RID: 103284 RVA: 0x003AD797 File Offset: 0x003AB997
		// (set) Token: 0x06019375 RID: 103285 RVA: 0x003AD79F File Offset: 0x003AB99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x06019376 RID: 103286 RVA: 0x003AD7A8 File Offset: 0x003AB9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> CdEndTimeList
		{
			get
			{
				return this.cdEndTimeList_;
			}
		}

		// Token: 0x06019377 RID: 103287 RVA: 0x003AD7B0 File Offset: 0x003AB9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillCdInfo);
		}

		// Token: 0x06019378 RID: 103288 RVA: 0x003AD7C0 File Offset: 0x003AB9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillCdInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.cdEndTimeList_.Equals(other.cdEndTimeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019379 RID: 103289 RVA: 0x003AD810 File Offset: 0x003ABA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.cdEndTimeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601937A RID: 103290 RVA: 0x003AD85D File Offset: 0x003ABA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601937B RID: 103291 RVA: 0x003AD86A File Offset: 0x003ABA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601937C RID: 103292 RVA: 0x003AD874 File Offset: 0x003ABA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			this.cdEndTimeList_.WriteTo(ref output, SkillCdInfo._repeated_cdEndTimeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601937D RID: 103293 RVA: 0x003AD8C4 File Offset: 0x003ABAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			num += this.cdEndTimeList_.CalculateSize(SkillCdInfo._repeated_cdEndTimeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601937E RID: 103294 RVA: 0x003AD918 File Offset: 0x003ABB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillCdInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this.cdEndTimeList_.Add(other.cdEndTimeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601937F RID: 103295 RVA: 0x003AD965 File Offset: 0x003ABB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019380 RID: 103296 RVA: 0x003AD970 File Offset: 0x003ABB70
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cdEndTimeList_.AddEntriesFrom(ref input, SkillCdInfo._repeated_cdEndTimeList_codec);
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400953E RID: 38206
		private static readonly MessageParser<SkillCdInfo> _parser = new MessageParser<SkillCdInfo>(() => new SkillCdInfo());

		// Token: 0x0400953F RID: 38207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009540 RID: 38208
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04009541 RID: 38209
		private long skillId_;

		// Token: 0x04009542 RID: 38210
		public const int CdEndTimeListFieldNumber = 2;

		// Token: 0x04009543 RID: 38211
		private static readonly FieldCodec<long> _repeated_cdEndTimeList_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04009544 RID: 38212
		private readonly RepeatedField<long> cdEndTimeList_ = new RepeatedField<long>();
	}
}
