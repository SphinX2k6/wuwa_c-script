using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C98 RID: 3224
	public sealed class PhantomBattleRoleInfo : IMessage<PhantomBattleRoleInfo>, IMessage, IEquatable<PhantomBattleRoleInfo>, IDeepCloneable<PhantomBattleRoleInfo>, IBufferMessage
	{
		// Token: 0x060117E9 RID: 71657 RVA: 0x002909EE File Offset: 0x0028EBEE
		[NullableContext(1)]
		public static PhantomBattleRoleInfo Create()
		{
			return new PhantomBattleRoleInfo();
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x060117EA RID: 71658 RVA: 0x002909F5 File Offset: 0x0028EBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleRoleInfo> Parser
		{
			get
			{
				return PhantomBattleRoleInfo._parser;
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x060117EB RID: 71659 RVA: 0x002909FC File Offset: 0x0028EBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x060117EC RID: 71660 RVA: 0x002909FF File Offset: 0x0028EBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleInfo.Descriptor;
			}
		}

		// Token: 0x060117ED RID: 71661 RVA: 0x00290A06 File Offset: 0x0028EC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo()
		{
		}

		// Token: 0x060117EE RID: 71662 RVA: 0x00290A0E File Offset: 0x0028EC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo(PhantomBattleRoleInfo other) : this()
		{
			this.phantomBattleRoleId_ = other.phantomBattleRoleId_;
			this.isUnlock_ = other.isUnlock_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117EF RID: 71663 RVA: 0x00290A4B File Offset: 0x0028EC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo Clone()
		{
			return new PhantomBattleRoleInfo(this);
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x060117F0 RID: 71664 RVA: 0x00290A53 File Offset: 0x0028EC53
		// (set) Token: 0x060117F1 RID: 71665 RVA: 0x00290A5B File Offset: 0x0028EC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleRoleId
		{
			get
			{
				return this.phantomBattleRoleId_;
			}
			set
			{
				this.phantomBattleRoleId_ = value;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x060117F2 RID: 71666 RVA: 0x00290A64 File Offset: 0x0028EC64
		// (set) Token: 0x060117F3 RID: 71667 RVA: 0x00290A6C File Offset: 0x0028EC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x060117F4 RID: 71668 RVA: 0x00290A75 File Offset: 0x0028EC75
		// (set) Token: 0x060117F5 RID: 71669 RVA: 0x00290A7D File Offset: 0x0028EC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRewarded
		{
			get
			{
				return this.isRewarded_;
			}
			set
			{
				this.isRewarded_ = value;
			}
		}

		// Token: 0x060117F6 RID: 71670 RVA: 0x00290A86 File Offset: 0x0028EC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleInfo);
		}

		// Token: 0x060117F7 RID: 71671 RVA: 0x00290A94 File Offset: 0x0028EC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleRoleId == other.PhantomBattleRoleId && this.IsUnlock == other.IsUnlock && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117F8 RID: 71672 RVA: 0x00290AF0 File Offset: 0x0028ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleRoleId != 0)
			{
				num ^= this.PhantomBattleRoleId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsRewarded)
			{
				num ^= this.IsRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060117F9 RID: 71673 RVA: 0x00290B61 File Offset: 0x0028ED61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117FA RID: 71674 RVA: 0x00290B6E File Offset: 0x0028ED6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117FB RID: 71675 RVA: 0x00290B78 File Offset: 0x0028ED78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleRoleId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117FC RID: 71676 RVA: 0x00290BEC File Offset: 0x0028EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleRoleId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsRewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060117FD RID: 71677 RVA: 0x00290C44 File Offset: 0x0028EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleRoleId != 0)
			{
				this.PhantomBattleRoleId = other.PhantomBattleRoleId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsRewarded)
			{
				this.IsRewarded = other.IsRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117FE RID: 71678 RVA: 0x00290CA8 File Offset: 0x0028EEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117FF RID: 71679 RVA: 0x00290CB4 File Offset: 0x0028EEB4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRewarded = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.PhantomBattleRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006EC2 RID: 28354
		private static readonly MessageParser<PhantomBattleRoleInfo> _parser = new MessageParser<PhantomBattleRoleInfo>(() => new PhantomBattleRoleInfo());

		// Token: 0x04006EC3 RID: 28355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EC4 RID: 28356
		public const int PhantomBattleRoleIdFieldNumber = 1;

		// Token: 0x04006EC5 RID: 28357
		private int phantomBattleRoleId_;

		// Token: 0x04006EC6 RID: 28358
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006EC7 RID: 28359
		private bool isUnlock_;

		// Token: 0x04006EC8 RID: 28360
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006EC9 RID: 28361
		private bool isRewarded_;
	}
}
