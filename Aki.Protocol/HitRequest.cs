using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000741 RID: 1857
	[NetMessage(EMessageId.HitRequest)]
	public sealed class HitRequest : IMessage<HitRequest>, IMessage, IEquatable<HitRequest>, IDeepCloneable<HitRequest>, IBufferMessage
	{
		// Token: 0x0600A8A0 RID: 43168 RVA: 0x001964BE File Offset: 0x001946BE
		[NullableContext(1)]
		public static HitRequest Create()
		{
			return new HitRequest();
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x001964C5 File Offset: 0x001946C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600A8A2 RID: 43170 RVA: 0x001964C8 File Offset: 0x001946C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitRequest.Descriptor;
			}
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x001964CF File Offset: 0x001946CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest()
		{
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x001964D8 File Offset: 0x001946D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest(HitRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this.skillMessageId_ = other.skillMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x00196540 File Offset: 0x00194740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest Clone()
		{
			return new HitRequest(this);
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x00196548 File Offset: 0x00194748
		// (set) Token: 0x0600A8A7 RID: 43175 RVA: 0x00196550 File Offset: 0x00194750
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

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x00196559 File Offset: 0x00194759
		// (set) Token: 0x0600A8A9 RID: 43177 RVA: 0x00196561 File Offset: 0x00194761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation HitInfo
		{
			get
			{
				return this.hitInfo_;
			}
			set
			{
				this.hitInfo_ = value;
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x0019656A File Offset: 0x0019476A
		// (set) Token: 0x0600A8AB RID: 43179 RVA: 0x00196572 File Offset: 0x00194772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillMessageId
		{
			get
			{
				return this.skillMessageId_;
			}
			set
			{
				this.skillMessageId_ = value;
			}
		}

		// Token: 0x0600A8AC RID: 43180 RVA: 0x0019657B File Offset: 0x0019477B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitRequest);
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x0019658C File Offset: 0x0019478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.HitInfo, other.HitInfo) && this.SkillMessageId == other.SkillMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x001965F0 File Offset: 0x001947F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.hitInfo_ != null)
			{
				num ^= this.HitInfo.GetHashCode();
			}
			if (this.SkillMessageId != 0L)
			{
				num ^= this.SkillMessageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x0019665B File Offset: 0x0019485B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x00196668 File Offset: 0x00194868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x00196674 File Offset: 0x00194874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HitInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillMessageId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SkillMessageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x001966EC File Offset: 0x001948EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.hitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitInfo);
			}
			if (this.SkillMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillMessageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x0019675C File Offset: 0x0019495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitRequest other)
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
			if (other.hitInfo_ != null)
			{
				if (this.hitInfo_ == null)
				{
					this.HitInfo = new HitInformation();
				}
				this.HitInfo.MergeFrom(other.HitInfo);
			}
			if (other.SkillMessageId != 0L)
			{
				this.SkillMessageId = other.SkillMessageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x001967F0 File Offset: 0x001949F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x001967FC File Offset: 0x001949FC
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
				if (num != 58U)
				{
					if (num != 66U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillMessageId = input.ReadInt64();
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
					if (this.hitInfo_ == null)
					{
						this.HitInfo = new HitInformation();
					}
					input.ReadMessage(this.HitInfo);
				}
			}
		}

		// Token: 0x04004D4C RID: 19788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D4D RID: 19789
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x04004D4E RID: 19790
		private CombatCommon combatCommon_;

		// Token: 0x04004D4F RID: 19791
		public const int HitInfoFieldNumber = 7;

		// Token: 0x04004D50 RID: 19792
		private HitInformation hitInfo_;

		// Token: 0x04004D51 RID: 19793
		public const int SkillMessageIdFieldNumber = 12;

		// Token: 0x04004D52 RID: 19794
		private long skillMessageId_;
	}
}
