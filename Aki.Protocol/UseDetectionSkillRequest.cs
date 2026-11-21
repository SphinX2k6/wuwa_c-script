using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001526 RID: 5414
	[NetMessage(EMessageId.UseDetectionSkillRequest)]
	public sealed class UseDetectionSkillRequest : IMessage<UseDetectionSkillRequest>, IMessage, IEquatable<UseDetectionSkillRequest>, IDeepCloneable<UseDetectionSkillRequest>, IBufferMessage
	{
		// Token: 0x0601CAE0 RID: 117472 RVA: 0x00427D7B File Offset: 0x00425F7B
		[NullableContext(1)]
		public static UseDetectionSkillRequest Create()
		{
			return new UseDetectionSkillRequest();
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x0601CAE1 RID: 117473 RVA: 0x00427D82 File Offset: 0x00425F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x0601CAE2 RID: 117474 RVA: 0x00427D85 File Offset: 0x00425F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseDetectionSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601CAE3 RID: 117475 RVA: 0x00427D8C File Offset: 0x00425F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest()
		{
		}

		// Token: 0x0601CAE4 RID: 117476 RVA: 0x00427D94 File Offset: 0x00425F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest(UseDetectionSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.confirmUseDetectionSkill_ = other.confirmUseDetectionSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAE5 RID: 117477 RVA: 0x00427E08 File Offset: 0x00426008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest Clone()
		{
			return new UseDetectionSkillRequest(this);
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x0601CAE6 RID: 117478 RVA: 0x00427E10 File Offset: 0x00426010
		// (set) Token: 0x0601CAE7 RID: 117479 RVA: 0x00427E18 File Offset: 0x00426018
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

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x0601CAE8 RID: 117480 RVA: 0x00427E21 File Offset: 0x00426021
		// (set) Token: 0x0601CAE9 RID: 117481 RVA: 0x00427E29 File Offset: 0x00426029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x0601CAEA RID: 117482 RVA: 0x00427E32 File Offset: 0x00426032
		// (set) Token: 0x0601CAEB RID: 117483 RVA: 0x00427E3A File Offset: 0x0042603A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x0601CAEC RID: 117484 RVA: 0x00427E43 File Offset: 0x00426043
		// (set) Token: 0x0601CAED RID: 117485 RVA: 0x00427E4B File Offset: 0x0042604B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ConfirmUseDetectionSkill
		{
			get
			{
				return this.confirmUseDetectionSkill_;
			}
			set
			{
				this.confirmUseDetectionSkill_ = value;
			}
		}

		// Token: 0x0601CAEE RID: 117486 RVA: 0x00427E54 File Offset: 0x00426054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseDetectionSkillRequest);
		}

		// Token: 0x0601CAEF RID: 117487 RVA: 0x00427E64 File Offset: 0x00426064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseDetectionSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.ConfirmUseDetectionSkill == other.ConfirmUseDetectionSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAF0 RID: 117488 RVA: 0x00427ED8 File Offset: 0x004260D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.ConfirmUseDetectionSkill)
			{
				num ^= this.ConfirmUseDetectionSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAF1 RID: 117489 RVA: 0x00427F5C File Offset: 0x0042615C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAF2 RID: 117490 RVA: 0x00427F69 File Offset: 0x00426169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAF3 RID: 117491 RVA: 0x00427F74 File Offset: 0x00426174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Rot);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Pos);
			}
			if (this.ConfirmUseDetectionSkill)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ConfirmUseDetectionSkill);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CAF4 RID: 117492 RVA: 0x00428008 File Offset: 0x00426208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.ConfirmUseDetectionSkill)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x00428084 File Offset: 0x00426284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseDetectionSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.ConfirmUseDetectionSkill)
			{
				this.ConfirmUseDetectionSkill = other.ConfirmUseDetectionSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x0042812C File Offset: 0x0042632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAF7 RID: 117495 RVA: 0x00428138 File Offset: 0x00426338
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
				if (num <= 50U)
				{
					if (num == 18U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 50U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ConfirmUseDetectionSkill = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A52F RID: 42287
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A530 RID: 42288
		public const int SkillIdFieldNumber = 13;

		// Token: 0x0400A531 RID: 42289
		private int skillId_;

		// Token: 0x0400A532 RID: 42290
		public const int PosFieldNumber = 6;

		// Token: 0x0400A533 RID: 42291
		private Vector pos_;

		// Token: 0x0400A534 RID: 42292
		public const int RotFieldNumber = 2;

		// Token: 0x0400A535 RID: 42293
		private Rotator rot_;

		// Token: 0x0400A536 RID: 42294
		public const int ConfirmUseDetectionSkillFieldNumber = 8;

		// Token: 0x0400A537 RID: 42295
		private bool confirmUseDetectionSkill_;
	}
}
