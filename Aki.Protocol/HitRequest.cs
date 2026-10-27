using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000755 RID: 1877
	[NetMessage(EMessageId.HitRequest)]
	public sealed class HitRequest : IMessage<HitRequest>, IMessage, IEquatable<HitRequest>, IDeepCloneable<HitRequest>, IBufferMessage
	{
		// Token: 0x0600A9F6 RID: 43510 RVA: 0x00198EE6 File Offset: 0x001970E6
		[NullableContext(1)]
		public static HitRequest Create()
		{
			return new HitRequest();
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x00198EED File Offset: 0x001970ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x00198EF0 File Offset: 0x001970F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitRequest.Descriptor;
			}
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x00198EF7 File Offset: 0x001970F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest()
		{
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x00198F00 File Offset: 0x00197100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest(HitRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this.skillMessageId_ = other.skillMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x00198F68 File Offset: 0x00197168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitRequest Clone()
		{
			return new HitRequest(this);
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600A9FC RID: 43516 RVA: 0x00198F70 File Offset: 0x00197170
		// (set) Token: 0x0600A9FD RID: 43517 RVA: 0x00198F78 File Offset: 0x00197178
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

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x00198F81 File Offset: 0x00197181
		// (set) Token: 0x0600A9FF RID: 43519 RVA: 0x00198F89 File Offset: 0x00197189
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

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x00198F92 File Offset: 0x00197192
		// (set) Token: 0x0600AA01 RID: 43521 RVA: 0x00198F9A File Offset: 0x0019719A
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

		// Token: 0x0600AA02 RID: 43522 RVA: 0x00198FA3 File Offset: 0x001971A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitRequest);
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x00198FB4 File Offset: 0x001971B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.HitInfo, other.HitInfo) && this.SkillMessageId == other.SkillMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x00199018 File Offset: 0x00197218
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

		// Token: 0x0600AA05 RID: 43525 RVA: 0x00199083 File Offset: 0x00197283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x00199090 File Offset: 0x00197290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x0019909C File Offset: 0x0019729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.HitInfo);
			}
			if (this.SkillMessageId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.SkillMessageId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x00199114 File Offset: 0x00197314
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

		// Token: 0x0600AA09 RID: 43529 RVA: 0x00199184 File Offset: 0x00197384
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

		// Token: 0x0600AA0A RID: 43530 RVA: 0x00199218 File Offset: 0x00197418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x00199224 File Offset: 0x00197424
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
					if (num != 40U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
						this.SkillMessageId = input.ReadInt64();
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

		// Token: 0x04004D53 RID: 19795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D54 RID: 19796
		public const int CombatCommonFieldNumber = 12;

		// Token: 0x04004D55 RID: 19797
		private CombatCommon combatCommon_;

		// Token: 0x04004D56 RID: 19798
		public const int HitInfoFieldNumber = 4;

		// Token: 0x04004D57 RID: 19799
		private HitInformation hitInfo_;

		// Token: 0x04004D58 RID: 19800
		public const int SkillMessageIdFieldNumber = 5;

		// Token: 0x04004D59 RID: 19801
		private long skillMessageId_;
	}
}
