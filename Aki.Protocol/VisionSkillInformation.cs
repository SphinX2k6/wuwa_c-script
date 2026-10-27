using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E4 RID: 5348
	public sealed class VisionSkillInformation : IMessage<VisionSkillInformation>, IMessage, IEquatable<VisionSkillInformation>, IDeepCloneable<VisionSkillInformation>, IBufferMessage
	{
		// Token: 0x0601C471 RID: 115825 RVA: 0x00416287 File Offset: 0x00414487
		[NullableContext(1)]
		public static VisionSkillInformation Create()
		{
			return new VisionSkillInformation();
		}

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x0601C472 RID: 115826 RVA: 0x0041628E File Offset: 0x0041448E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VisionSkillInformation> Parser
		{
			get
			{
				return VisionSkillInformation._parser;
			}
		}

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x0601C473 RID: 115827 RVA: 0x00416295 File Offset: 0x00414495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x0601C474 RID: 115828 RVA: 0x00416298 File Offset: 0x00414498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionSkillInformation.Descriptor;
			}
		}

		// Token: 0x0601C475 RID: 115829 RVA: 0x0041629F File Offset: 0x0041449F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation()
		{
		}

		// Token: 0x0601C476 RID: 115830 RVA: 0x004162A8 File Offset: 0x004144A8
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

		// Token: 0x0601C477 RID: 115831 RVA: 0x00416308 File Offset: 0x00414508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillInformation Clone()
		{
			return new VisionSkillInformation(this);
		}

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x0601C478 RID: 115832 RVA: 0x00416310 File Offset: 0x00414510
		// (set) Token: 0x0601C479 RID: 115833 RVA: 0x00416318 File Offset: 0x00414518
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

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x0601C47A RID: 115834 RVA: 0x00416321 File Offset: 0x00414521
		// (set) Token: 0x0601C47B RID: 115835 RVA: 0x00416329 File Offset: 0x00414529
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

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x0601C47C RID: 115836 RVA: 0x00416332 File Offset: 0x00414532
		// (set) Token: 0x0601C47D RID: 115837 RVA: 0x0041633A File Offset: 0x0041453A
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

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x0601C47E RID: 115838 RVA: 0x00416343 File Offset: 0x00414543
		// (set) Token: 0x0601C47F RID: 115839 RVA: 0x0041634B File Offset: 0x0041454B
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

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x0601C480 RID: 115840 RVA: 0x00416354 File Offset: 0x00414554
		// (set) Token: 0x0601C481 RID: 115841 RVA: 0x0041635C File Offset: 0x0041455C
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

		// Token: 0x0601C482 RID: 115842 RVA: 0x00416365 File Offset: 0x00414565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionSkillInformation);
		}

		// Token: 0x0601C483 RID: 115843 RVA: 0x00416374 File Offset: 0x00414574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionSkillInformation other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Level == other.Level && this.Quality == other.Quality && this.VisionEntityId == other.VisionEntityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C484 RID: 115844 RVA: 0x004163F0 File Offset: 0x004145F0
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

		// Token: 0x0601C485 RID: 115845 RVA: 0x00416493 File Offset: 0x00414693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C486 RID: 115846 RVA: 0x004164A0 File Offset: 0x004146A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x004164AC File Offset: 0x004146AC
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

		// Token: 0x0601C488 RID: 115848 RVA: 0x00416558 File Offset: 0x00414758
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

		// Token: 0x0601C489 RID: 115849 RVA: 0x004165F8 File Offset: 0x004147F8
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

		// Token: 0x0601C48A RID: 115850 RVA: 0x00416684 File Offset: 0x00414884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C48B RID: 115851 RVA: 0x00416690 File Offset: 0x00414890
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

		// Token: 0x0400A215 RID: 41493
		private static readonly MessageParser<VisionSkillInformation> _parser = new MessageParser<VisionSkillInformation>(() => new VisionSkillInformation());

		// Token: 0x0400A216 RID: 41494
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A217 RID: 41495
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400A218 RID: 41496
		private int skillId_;

		// Token: 0x0400A219 RID: 41497
		public const int LevelFieldNumber = 2;

		// Token: 0x0400A21A RID: 41498
		private int level_;

		// Token: 0x0400A21B RID: 41499
		public const int QualityFieldNumber = 3;

		// Token: 0x0400A21C RID: 41500
		private int quality_;

		// Token: 0x0400A21D RID: 41501
		public const int VisionEntityIdFieldNumber = 4;

		// Token: 0x0400A21E RID: 41502
		private long visionEntityId_;

		// Token: 0x0400A21F RID: 41503
		public const int IndexFieldNumber = 5;

		// Token: 0x0400A220 RID: 41504
		private int index_;
	}
}
