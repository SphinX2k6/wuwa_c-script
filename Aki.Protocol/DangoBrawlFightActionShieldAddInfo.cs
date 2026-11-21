using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035C RID: 860
	public sealed class DangoBrawlFightActionShieldAddInfo : IMessage<DangoBrawlFightActionShieldAddInfo>, IMessage, IEquatable<DangoBrawlFightActionShieldAddInfo>, IDeepCloneable<DangoBrawlFightActionShieldAddInfo>, IBufferMessage
	{
		// Token: 0x06005616 RID: 22038 RVA: 0x000D27D3 File Offset: 0x000D09D3
		[NullableContext(1)]
		public static DangoBrawlFightActionShieldAddInfo Create()
		{
			return new DangoBrawlFightActionShieldAddInfo();
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x000D27DA File Offset: 0x000D09DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x000D27DD File Offset: 0x000D09DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionShieldAddInfo.Descriptor;
			}
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x000D27E4 File Offset: 0x000D09E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo()
		{
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x000D27EC File Offset: 0x000D09EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo(DangoBrawlFightActionShieldAddInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.shieldValue_ = other.shieldValue_;
			this.itemUId_ = other.itemUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x000D2829 File Offset: 0x000D0A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionShieldAddInfo Clone()
		{
			return new DangoBrawlFightActionShieldAddInfo(this);
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x000D2831 File Offset: 0x000D0A31
		// (set) Token: 0x0600561D RID: 22045 RVA: 0x000D2839 File Offset: 0x000D0A39
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x0600561E RID: 22046 RVA: 0x000D2842 File Offset: 0x000D0A42
		// (set) Token: 0x0600561F RID: 22047 RVA: 0x000D284A File Offset: 0x000D0A4A
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

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06005620 RID: 22048 RVA: 0x000D2853 File Offset: 0x000D0A53
		// (set) Token: 0x06005621 RID: 22049 RVA: 0x000D285B File Offset: 0x000D0A5B
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

		// Token: 0x06005622 RID: 22050 RVA: 0x000D2864 File Offset: 0x000D0A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionShieldAddInfo);
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x000D2874 File Offset: 0x000D0A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionShieldAddInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.ShieldValue == other.ShieldValue && this.ItemUId == other.ItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x000D28D0 File Offset: 0x000D0AD0
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

		// Token: 0x06005625 RID: 22053 RVA: 0x000D2941 File Offset: 0x000D0B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x000D294E File Offset: 0x000D0B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x000D2958 File Offset: 0x000D0B58
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

		// Token: 0x06005628 RID: 22056 RVA: 0x000D29CC File Offset: 0x000D0BCC
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

		// Token: 0x06005629 RID: 22057 RVA: 0x000D2A3C File Offset: 0x000D0C3C
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

		// Token: 0x0600562A RID: 22058 RVA: 0x000D2AA0 File Offset: 0x000D0CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x000D2AAC File Offset: 0x000D0CAC
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

		// Token: 0x040034A8 RID: 13480
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034A9 RID: 13481
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040034AA RID: 13482
		private int targetFighterUId_;

		// Token: 0x040034AB RID: 13483
		public const int ShieldValueFieldNumber = 2;

		// Token: 0x040034AC RID: 13484
		private int shieldValue_;

		// Token: 0x040034AD RID: 13485
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x040034AE RID: 13486
		private int itemUId_;
	}
}
