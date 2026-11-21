using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155A RID: 5466
	public sealed class VisionSkillInformation : IMessage<VisionSkillInformation>, IMessage, IEquatable<VisionSkillInformation>, IDeepCloneable<VisionSkillInformation>, IBufferMessage
	{
		// Token: 0x0601CF38 RID: 118584 RVA: 0x00431D43 File Offset: 0x0042FF43
		[NullableContext(1)]
		public static VisionSkillInformation Create()
		{
			return new VisionSkillInformation();
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x0601CF39 RID: 118585 RVA: 0x00431D4A File Offset: 0x0042FF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VisionSkillInformation> Parser
		{
			get
			{
				return VisionSkillInformation._parser;
			}
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x0601CF3A RID: 118586 RVA: 0x00431D51 File Offset: 0x0042FF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x0601CF3B RID: 118587 RVA: 0x00431D54 File Offset: 0x0042FF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillInformation.Descriptor;
			}
		}

		// Token: 0x0601CF3C RID: 118588 RVA: 0x00431D5B File Offset: 0x0042FF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation()
		{
		}

		// Token: 0x0601CF3D RID: 118589 RVA: 0x00431D64 File Offset: 0x0042FF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation(VisionSkillInformation other) : this()
		{
			this.skillId_ = other.skillId_;
			this.level_ = other.level_;
			this.quality_ = other.quality_;
			this.visionEntityId_ = other.visionEntityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF3E RID: 118590 RVA: 0x00431DC4 File Offset: 0x0042FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation Clone()
		{
			return new VisionSkillInformation(this);
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x0601CF3F RID: 118591 RVA: 0x00431DCC File Offset: 0x0042FFCC
		// (set) Token: 0x0601CF40 RID: 118592 RVA: 0x00431DD4 File Offset: 0x0042FFD4
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

		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x0601CF41 RID: 118593 RVA: 0x00431DDD File Offset: 0x0042FFDD
		// (set) Token: 0x0601CF42 RID: 118594 RVA: 0x00431DE5 File Offset: 0x0042FFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x0601CF43 RID: 118595 RVA: 0x00431DEE File Offset: 0x0042FFEE
		// (set) Token: 0x0601CF44 RID: 118596 RVA: 0x00431DF6 File Offset: 0x0042FFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quality
		{
			get
			{
				return this.quality_;
			}
			set
			{
				this.quality_ = value;
			}
		}

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x0601CF45 RID: 118597 RVA: 0x00431DFF File Offset: 0x0042FFFF
		// (set) Token: 0x0601CF46 RID: 118598 RVA: 0x00431E07 File Offset: 0x00430007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VisionEntityId
		{
			get
			{
				return this.visionEntityId_;
			}
			set
			{
				this.visionEntityId_ = value;
			}
		}

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x0601CF47 RID: 118599 RVA: 0x00431E10 File Offset: 0x00430010
		// (set) Token: 0x0601CF48 RID: 118600 RVA: 0x00431E18 File Offset: 0x00430018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601CF49 RID: 118601 RVA: 0x00431E21 File Offset: 0x00430021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillInformation);
		}

		// Token: 0x0601CF4A RID: 118602 RVA: 0x00431E30 File Offset: 0x00430030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillInformation other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Level == other.Level && this.Quality == other.Quality && this.VisionEntityId == other.VisionEntityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF4B RID: 118603 RVA: 0x00431EAC File Offset: 0x004300AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			if (this.VisionEntityId != 0L)
			{
				num ^= this.VisionEntityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF4C RID: 118604 RVA: 0x00431F4F File Offset: 0x0043014F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF4D RID: 118605 RVA: 0x00431F5C File Offset: 0x0043015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF4E RID: 118606 RVA: 0x00431F68 File Offset: 0x00430168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Quality);
			}
			if (this.VisionEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.VisionEntityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF4F RID: 118607 RVA: 0x00432014 File Offset: 0x00430214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Quality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			if (this.VisionEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VisionEntityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF50 RID: 118608 RVA: 0x004320B4 File Offset: 0x004302B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionSkillInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			if (other.VisionEntityId != 0L)
			{
				this.VisionEntityId = other.VisionEntityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF51 RID: 118609 RVA: 0x00432140 File Offset: 0x00430340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF52 RID: 118610 RVA: 0x0043214C File Offset: 0x0043034C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.VisionEntityId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A66E RID: 42606
		private static readonly MessageParser<VisionSkillInformation> _parser = new MessageParser<VisionSkillInformation>(() => new VisionSkillInformation());

		// Token: 0x0400A66F RID: 42607
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A670 RID: 42608
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400A671 RID: 42609
		private int skillId_;

		// Token: 0x0400A672 RID: 42610
		public const int LevelFieldNumber = 2;

		// Token: 0x0400A673 RID: 42611
		private int level_;

		// Token: 0x0400A674 RID: 42612
		public const int QualityFieldNumber = 3;

		// Token: 0x0400A675 RID: 42613
		private int quality_;

		// Token: 0x0400A676 RID: 42614
		public const int VisionEntityIdFieldNumber = 4;

		// Token: 0x0400A677 RID: 42615
		private long visionEntityId_;

		// Token: 0x0400A678 RID: 42616
		public const int IndexFieldNumber = 5;

		// Token: 0x0400A679 RID: 42617
		private int index_;
	}
}
