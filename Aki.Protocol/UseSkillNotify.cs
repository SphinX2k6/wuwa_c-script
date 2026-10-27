using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B9 RID: 5305
	[NetMessage(EMessageId.UseSkillNotify)]
	public sealed class UseSkillNotify : IMessage<UseSkillNotify>, IMessage, IEquatable<UseSkillNotify>, IDeepCloneable<UseSkillNotify>, IBufferMessage
	{
		// Token: 0x0601C0E3 RID: 114915 RVA: 0x0040E3C9 File Offset: 0x0040C5C9
		[NullableContext(1)]
		public static UseSkillNotify Create()
		{
			return new UseSkillNotify();
		}

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x0601C0E4 RID: 114916 RVA: 0x0040E3D0 File Offset: 0x0040C5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x0601C0E5 RID: 114917 RVA: 0x0040E3D3 File Offset: 0x0040C5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillNotify.Descriptor;
			}
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x0040E3DA File Offset: 0x0040C5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify()
		{
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x0040E3E4 File Offset: 0x0040C5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify(UseSkillNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x0040E44C File Offset: 0x0040C64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillNotify Clone()
		{
			return new UseSkillNotify(this);
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x0601C0E9 RID: 114921 RVA: 0x0040E454 File Offset: 0x0040C654
		// (set) Token: 0x0601C0EA RID: 114922 RVA: 0x0040E45C File Offset: 0x0040C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x0601C0EB RID: 114923 RVA: 0x0040E465 File Offset: 0x0040C665
		// (set) Token: 0x0601C0EC RID: 114924 RVA: 0x0040E46D File Offset: 0x0040C66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x0601C0ED RID: 114925 RVA: 0x0040E476 File Offset: 0x0040C676
		// (set) Token: 0x0601C0EE RID: 114926 RVA: 0x0040E47E File Offset: 0x0040C67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x0601C0EF RID: 114927 RVA: 0x0040E487 File Offset: 0x0040C687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillNotify);
		}

		// Token: 0x0601C0F0 RID: 114928 RVA: 0x0040E498 File Offset: 0x0040C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0F1 RID: 114929 RVA: 0x0040E4FC File Offset: 0x0040C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0F2 RID: 114930 RVA: 0x0040E567 File Offset: 0x0040C767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0F3 RID: 114931 RVA: 0x0040E574 File Offset: 0x0040C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0F4 RID: 114932 RVA: 0x0040E580 File Offset: 0x0040C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0F5 RID: 114933 RVA: 0x0040E5F8 File Offset: 0x0040C7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0F6 RID: 114934 RVA: 0x0040E668 File Offset: 0x0040C868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0F7 RID: 114935 RVA: 0x0040E6FC File Offset: 0x0040C8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0F8 RID: 114936 RVA: 0x0040E708 File Offset: 0x0040C908
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
				if (num != 34U)
				{
					if (num != 74U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillSingleId = input.ReadInt32();
						}
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					if (this.useSkillInfo_ == null)
					{
						this.UseSkillInfo = new UseSkillInformation();
					}
					input.ReadMessage(this.UseSkillInfo);
				}
			}
		}

		// Token: 0x0400A11F RID: 41247
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A120 RID: 41248
		public const int CombatCommonFieldNumber = 9;

		// Token: 0x0400A121 RID: 41249
		private CombatCommon combatCommon_;

		// Token: 0x0400A122 RID: 41250
		public const int UseSkillInfoFieldNumber = 4;

		// Token: 0x0400A123 RID: 41251
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400A124 RID: 41252
		public const int SkillSingleIdFieldNumber = 13;

		// Token: 0x0400A125 RID: 41253
		private int skillSingleId_;
	}
}
