using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001086 RID: 4230
	public sealed class RolePassiveSkillInfo : IMessage<RolePassiveSkillInfo>, IMessage, IEquatable<RolePassiveSkillInfo>, IDeepCloneable<RolePassiveSkillInfo>, IBufferMessage
	{
		// Token: 0x060169FF RID: 92671 RVA: 0x0034A958 File Offset: 0x00348B58
		[NullableContext(1)]
		public static RolePassiveSkillInfo Create()
		{
			return new RolePassiveSkillInfo();
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x06016A00 RID: 92672 RVA: 0x0034A95F File Offset: 0x00348B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePassiveSkillInfo> Parser
		{
			get
			{
				return RolePassiveSkillInfo._parser;
			}
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x06016A01 RID: 92673 RVA: 0x0034A966 File Offset: 0x00348B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x06016A02 RID: 92674 RVA: 0x0034A969 File Offset: 0x00348B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePassiveSkillInfo.Descriptor;
			}
		}

		// Token: 0x06016A03 RID: 92675 RVA: 0x0034A970 File Offset: 0x00348B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo()
		{
		}

		// Token: 0x06016A04 RID: 92676 RVA: 0x0034A983 File Offset: 0x00348B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo(RolePassiveSkillInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.passiveSkillInfoList_ = other.passiveSkillInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A05 RID: 92677 RVA: 0x0034A9B9 File Offset: 0x00348BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo Clone()
		{
			return new RolePassiveSkillInfo(this);
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x06016A06 RID: 92678 RVA: 0x0034A9C1 File Offset: 0x00348BC1
		// (set) Token: 0x06016A07 RID: 92679 RVA: 0x0034A9C9 File Offset: 0x00348BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x06016A08 RID: 92680 RVA: 0x0034A9D2 File Offset: 0x00348BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillInfo> PassiveSkillInfoList
		{
			get
			{
				return this.passiveSkillInfoList_;
			}
		}

		// Token: 0x06016A09 RID: 92681 RVA: 0x0034A9DA File Offset: 0x00348BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePassiveSkillInfo);
		}

		// Token: 0x06016A0A RID: 92682 RVA: 0x0034A9E8 File Offset: 0x00348BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePassiveSkillInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.passiveSkillInfoList_.Equals(other.passiveSkillInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A0B RID: 92683 RVA: 0x0034AA38 File Offset: 0x00348C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.passiveSkillInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A0C RID: 92684 RVA: 0x0034AA85 File Offset: 0x00348C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A0D RID: 92685 RVA: 0x0034AA92 File Offset: 0x00348C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A0E RID: 92686 RVA: 0x0034AA9C File Offset: 0x00348C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.passiveSkillInfoList_.WriteTo(ref output, RolePassiveSkillInfo._repeated_passiveSkillInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A0F RID: 92687 RVA: 0x0034AAEC File Offset: 0x00348CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.passiveSkillInfoList_.CalculateSize(RolePassiveSkillInfo._repeated_passiveSkillInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A10 RID: 92688 RVA: 0x0034AB40 File Offset: 0x00348D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePassiveSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.passiveSkillInfoList_.Add(other.passiveSkillInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A11 RID: 92689 RVA: 0x0034AB8D File Offset: 0x00348D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A12 RID: 92690 RVA: 0x0034AB98 File Offset: 0x00348D98
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.passiveSkillInfoList_.AddEntriesFrom(ref input, RolePassiveSkillInfo._repeated_passiveSkillInfoList_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087AD RID: 34733
		private static readonly MessageParser<RolePassiveSkillInfo> _parser = new MessageParser<RolePassiveSkillInfo>(() => new RolePassiveSkillInfo());

		// Token: 0x040087AE RID: 34734
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087AF RID: 34735
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087B0 RID: 34736
		private int roleId_;

		// Token: 0x040087B1 RID: 34737
		public const int PassiveSkillInfoListFieldNumber = 2;

		// Token: 0x040087B2 RID: 34738
		private static readonly FieldCodec<PassiveSkillInfo> _repeated_passiveSkillInfoList_codec = FieldCodec.ForMessage<PassiveSkillInfo>(18U, PassiveSkillInfo.Parser);

		// Token: 0x040087B3 RID: 34739
		private readonly RepeatedField<PassiveSkillInfo> passiveSkillInfoList_ = new RepeatedField<PassiveSkillInfo>();
	}
}
