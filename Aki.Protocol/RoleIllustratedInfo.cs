using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001075 RID: 4213
	public sealed class RoleIllustratedInfo : IMessage<RoleIllustratedInfo>, IMessage, IEquatable<RoleIllustratedInfo>, IDeepCloneable<RoleIllustratedInfo>, IBufferMessage
	{
		// Token: 0x06016883 RID: 92291 RVA: 0x00346C23 File Offset: 0x00344E23
		[NullableContext(1)]
		public static RoleIllustratedInfo Create()
		{
			return new RoleIllustratedInfo();
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x06016884 RID: 92292 RVA: 0x00346C2A File Offset: 0x00344E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleIllustratedInfo> Parser
		{
			get
			{
				return RoleIllustratedInfo._parser;
			}
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x06016885 RID: 92293 RVA: 0x00346C31 File Offset: 0x00344E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x06016886 RID: 92294 RVA: 0x00346C34 File Offset: 0x00344E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x06016887 RID: 92295 RVA: 0x00346C3B File Offset: 0x00344E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo()
		{
		}

		// Token: 0x06016888 RID: 92296 RVA: 0x00346C43 File Offset: 0x00344E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo(RoleIllustratedInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016889 RID: 92297 RVA: 0x00346C74 File Offset: 0x00344E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfo Clone()
		{
			return new RoleIllustratedInfo(this);
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x0601688A RID: 92298 RVA: 0x00346C7C File Offset: 0x00344E7C
		// (set) Token: 0x0601688B RID: 92299 RVA: 0x00346C84 File Offset: 0x00344E84
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

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x0601688C RID: 92300 RVA: 0x00346C8D File Offset: 0x00344E8D
		// (set) Token: 0x0601688D RID: 92301 RVA: 0x00346C95 File Offset: 0x00344E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x0601688E RID: 92302 RVA: 0x00346C9E File Offset: 0x00344E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfo);
		}

		// Token: 0x0601688F RID: 92303 RVA: 0x00346CAC File Offset: 0x00344EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016890 RID: 92304 RVA: 0x00346CEC File Offset: 0x00344EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016891 RID: 92305 RVA: 0x00346D44 File Offset: 0x00344F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016892 RID: 92306 RVA: 0x00346D51 File Offset: 0x00344F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016893 RID: 92307 RVA: 0x00346D5C File Offset: 0x00344F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016894 RID: 92308 RVA: 0x00346DB4 File Offset: 0x00344FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016895 RID: 92309 RVA: 0x00346E0C File Offset: 0x0034500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016896 RID: 92310 RVA: 0x00346E5C File Offset: 0x0034505C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016897 RID: 92311 RVA: 0x00346E68 File Offset: 0x00345068
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008713 RID: 34579
		private static readonly MessageParser<RoleIllustratedInfo> _parser = new MessageParser<RoleIllustratedInfo>(() => new RoleIllustratedInfo());

		// Token: 0x04008714 RID: 34580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008715 RID: 34581
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008716 RID: 34582
		private int roleId_;

		// Token: 0x04008717 RID: 34583
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04008718 RID: 34584
		private long unlockTime_;
	}
}
