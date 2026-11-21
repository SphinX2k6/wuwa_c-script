using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001556 RID: 5462
	[NetMessage(EMessageId.VisionExploreSkillSetResponse)]
	public sealed class VisionExploreSkillSetResponse : IMessage<VisionExploreSkillSetResponse>, IMessage, IEquatable<VisionExploreSkillSetResponse>, IDeepCloneable<VisionExploreSkillSetResponse>, IBufferMessage
	{
		// Token: 0x0601CEE6 RID: 118502 RVA: 0x0043112F File Offset: 0x0042F32F
		[NullableContext(1)]
		public static VisionExploreSkillSetResponse Create()
		{
			return new VisionExploreSkillSetResponse();
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x0601CEE7 RID: 118503 RVA: 0x00431136 File Offset: 0x0042F336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x0601CEE8 RID: 118504 RVA: 0x00431139 File Offset: 0x0042F339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillSetResponse.Descriptor;
			}
		}

		// Token: 0x0601CEE9 RID: 118505 RVA: 0x00431140 File Offset: 0x0042F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse()
		{
		}

		// Token: 0x0601CEEA RID: 118506 RVA: 0x00431148 File Offset: 0x0042F348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse(VisionExploreSkillSetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEEB RID: 118507 RVA: 0x00431179 File Offset: 0x0042F379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse Clone()
		{
			return new VisionExploreSkillSetResponse(this);
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x0601CEEC RID: 118508 RVA: 0x00431181 File Offset: 0x0042F381
		// (set) Token: 0x0601CEED RID: 118509 RVA: 0x00431189 File Offset: 0x0042F389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x0601CEEE RID: 118510 RVA: 0x00431192 File Offset: 0x0042F392
		// (set) Token: 0x0601CEEF RID: 118511 RVA: 0x0043119A File Offset: 0x0042F39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x0601CEF0 RID: 118512 RVA: 0x004311A3 File Offset: 0x0042F3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillSetResponse);
		}

		// Token: 0x0601CEF1 RID: 118513 RVA: 0x004311B1 File Offset: 0x0042F3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillSetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEF2 RID: 118514 RVA: 0x004311F0 File Offset: 0x0042F3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEF3 RID: 118515 RVA: 0x0043124E File Offset: 0x0042F44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEF4 RID: 118516 RVA: 0x0043125B File Offset: 0x0042F45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEF5 RID: 118517 RVA: 0x00431264 File Offset: 0x0042F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEF6 RID: 118518 RVA: 0x004312C0 File Offset: 0x0042F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CEF7 RID: 118519 RVA: 0x00431318 File Offset: 0x0042F518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionExploreSkillSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CEF8 RID: 118520 RVA: 0x00431368 File Offset: 0x0042F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEF9 RID: 118521 RVA: 0x00431374 File Offset: 0x0042F574
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A656 RID: 42582
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A657 RID: 42583
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x0400A658 RID: 42584
		private ErrorCode errCode_;

		// Token: 0x0400A659 RID: 42585
		public const int SkillIdFieldNumber = 7;

		// Token: 0x0400A65A RID: 42586
		private int skillId_;
	}
}
