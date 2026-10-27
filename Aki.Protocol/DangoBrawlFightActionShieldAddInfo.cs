using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000354 RID: 852
	public sealed class DangoBrawlFightActionShieldAddInfo : IMessage<DangoBrawlFightActionShieldAddInfo>, IMessage, IEquatable<DangoBrawlFightActionShieldAddInfo>, IDeepCloneable<DangoBrawlFightActionShieldAddInfo>, IBufferMessage
	{
		// Token: 0x06005529 RID: 21801 RVA: 0x000D0147 File Offset: 0x000CE347
		[NullableContext(1)]
		public static DangoBrawlFightActionShieldAddInfo Create()
		{
			return new DangoBrawlFightActionShieldAddInfo();
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x000D014E File Offset: 0x000CE34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x000D0151 File Offset: 0x000CE351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionShieldAddInfo.Descriptor;
			}
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x000D0158 File Offset: 0x000CE358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo()
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x000D0160 File Offset: 0x000CE360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo(DangoBrawlFightActionShieldAddInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.shieldValue_ = other.shieldValue_;
			this.itemUId_ = other.itemUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x000D019D File Offset: 0x000CE39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo Clone()
		{
			return new DangoBrawlFightActionShieldAddInfo(this);
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x000D01A5 File Offset: 0x000CE3A5
		// (set) Token: 0x06005530 RID: 21808 RVA: 0x000D01AD File Offset: 0x000CE3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x000D01B6 File Offset: 0x000CE3B6
		// (set) Token: 0x06005532 RID: 21810 RVA: 0x000D01BE File Offset: 0x000CE3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldValue
		{
			get
			{
				return this.shieldValue_;
			}
			set
			{
				this.shieldValue_ = value;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x000D01C7 File Offset: 0x000CE3C7
		// (set) Token: 0x06005534 RID: 21812 RVA: 0x000D01CF File Offset: 0x000CE3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x000D01D8 File Offset: 0x000CE3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionShieldAddInfo);
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x000D01E8 File Offset: 0x000CE3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionShieldAddInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.ShieldValue == other.ShieldValue && this.ItemUId == other.ItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x000D0244 File Offset: 0x000CE444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.ShieldValue != 0)
			{
				num ^= this.ShieldValue.GetHashCode();
			}
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x000D02B5 File Offset: 0x000CE4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x000D02C2 File Offset: 0x000CE4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x000D02CC File Offset: 0x000CE4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.ShieldValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ShieldValue);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x000D0340 File Offset: 0x000CE540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.ShieldValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldValue);
			}
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x000D03B0 File Offset: 0x000CE5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionShieldAddInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.ShieldValue != 0)
			{
				this.ShieldValue = other.ShieldValue;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x000D0414 File Offset: 0x000CE614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x000D0420 File Offset: 0x000CE620
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
							this.ItemUId = input.ReadInt32();
						}
					}
					else
					{
						this.ShieldValue = input.ReadInt32();
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400340C RID: 13324
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400340D RID: 13325
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x0400340E RID: 13326
		private int targetFighterUId_;

		// Token: 0x0400340F RID: 13327
		public const int ShieldValueFieldNumber = 2;

		// Token: 0x04003410 RID: 13328
		private int shieldValue_;

		// Token: 0x04003411 RID: 13329
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x04003412 RID: 13330
		private int itemUId_;
	}
}
