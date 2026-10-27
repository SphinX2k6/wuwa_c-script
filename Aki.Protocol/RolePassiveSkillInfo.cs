using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001096 RID: 4246
	public sealed class RolePassiveSkillInfo : IMessage<RolePassiveSkillInfo>, IMessage, IEquatable<RolePassiveSkillInfo>, IDeepCloneable<RolePassiveSkillInfo>, IBufferMessage
	{
		// Token: 0x06016AE4 RID: 92900 RVA: 0x0034C034 File Offset: 0x0034A234
		[NullableContext(1)]
		public static RolePassiveSkillInfo Create()
		{
			return new RolePassiveSkillInfo();
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06016AE5 RID: 92901 RVA: 0x0034C03B File Offset: 0x0034A23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePassiveSkillInfo> Parser
		{
			get
			{
				return RolePassiveSkillInfo._parser;
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06016AE6 RID: 92902 RVA: 0x0034C042 File Offset: 0x0034A242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06016AE7 RID: 92903 RVA: 0x0034C045 File Offset: 0x0034A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePassiveSkillInfo.Descriptor;
			}
		}

		// Token: 0x06016AE8 RID: 92904 RVA: 0x0034C04C File Offset: 0x0034A24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo()
		{
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x0034C05F File Offset: 0x0034A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo(RolePassiveSkillInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.passiveSkillInfoList_ = other.passiveSkillInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AEA RID: 92906 RVA: 0x0034C095 File Offset: 0x0034A295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePassiveSkillInfo Clone()
		{
			return new RolePassiveSkillInfo(this);
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x06016AEB RID: 92907 RVA: 0x0034C09D File Offset: 0x0034A29D
		// (set) Token: 0x06016AEC RID: 92908 RVA: 0x0034C0A5 File Offset: 0x0034A2A5
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

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x06016AED RID: 92909 RVA: 0x0034C0AE File Offset: 0x0034A2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillInfo> PassiveSkillInfoList
		{
			get
			{
				return this.passiveSkillInfoList_;
			}
		}

		// Token: 0x06016AEE RID: 92910 RVA: 0x0034C0B6 File Offset: 0x0034A2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePassiveSkillInfo);
		}

		// Token: 0x06016AEF RID: 92911 RVA: 0x0034C0C4 File Offset: 0x0034A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePassiveSkillInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.passiveSkillInfoList_.Equals(other.passiveSkillInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AF0 RID: 92912 RVA: 0x0034C114 File Offset: 0x0034A314
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

		// Token: 0x06016AF1 RID: 92913 RVA: 0x0034C161 File Offset: 0x0034A361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AF2 RID: 92914 RVA: 0x0034C16E File Offset: 0x0034A36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AF3 RID: 92915 RVA: 0x0034C178 File Offset: 0x0034A378
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

		// Token: 0x06016AF4 RID: 92916 RVA: 0x0034C1C8 File Offset: 0x0034A3C8
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

		// Token: 0x06016AF5 RID: 92917 RVA: 0x0034C21C File Offset: 0x0034A41C
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

		// Token: 0x06016AF6 RID: 92918 RVA: 0x0034C269 File Offset: 0x0034A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AF7 RID: 92919 RVA: 0x0034C274 File Offset: 0x0034A474
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

		// Token: 0x04008783 RID: 34691
		private static readonly MessageParser<RolePassiveSkillInfo> _parser = new MessageParser<RolePassiveSkillInfo>(() => new RolePassiveSkillInfo());

		// Token: 0x04008784 RID: 34692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008785 RID: 34693
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008786 RID: 34694
		private int roleId_;

		// Token: 0x04008787 RID: 34695
		public const int PassiveSkillInfoListFieldNumber = 2;

		// Token: 0x04008788 RID: 34696
		private static readonly FieldCodec<PassiveSkillInfo> _repeated_passiveSkillInfoList_codec = FieldCodec.ForMessage<PassiveSkillInfo>(18U, PassiveSkillInfo.Parser);

		// Token: 0x04008789 RID: 34697
		private readonly RepeatedField<PassiveSkillInfo> passiveSkillInfoList_ = new RepeatedField<PassiveSkillInfo>();
	}
}
