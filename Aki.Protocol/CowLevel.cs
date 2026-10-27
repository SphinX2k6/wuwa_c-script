using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030F RID: 783
	public sealed class CowLevel : IMessage<CowLevel>, IMessage, IEquatable<CowLevel>, IDeepCloneable<CowLevel>, IBufferMessage
	{
		// Token: 0x06004ED3 RID: 20179 RVA: 0x000BF364 File Offset: 0x000BD564
		[NullableContext(1)]
		public static CowLevel Create()
		{
			return new CowLevel();
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x000BF36B File Offset: 0x000BD56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x000BF36E File Offset: 0x000BD56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CowLevel.Descriptor;
			}
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x000BF375 File Offset: 0x000BD575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel()
		{
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x000BF37D File Offset: 0x000BD57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel(CowLevel other) : this()
		{
			this.levelScore_ = other.levelScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x000BF3A2 File Offset: 0x000BD5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel Clone()
		{
			return new CowLevel(this);
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x000BF3AA File Offset: 0x000BD5AA
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x000BF3B2 File Offset: 0x000BD5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelScore
		{
			get
			{
				return this.levelScore_;
			}
			set
			{
				this.levelScore_ = value;
			}
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x000BF3BB File Offset: 0x000BD5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CowLevel);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x000BF3C9 File Offset: 0x000BD5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CowLevel other)
		{
			return other != null && (other == this || (this.LevelScore == other.LevelScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x000BF3F8 File Offset: 0x000BD5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelScore != 0)
			{
				num ^= this.LevelScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x000BF437 File Offset: 0x000BD637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x000BF444 File Offset: 0x000BD644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x000BF44D File Offset: 0x000BD64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x000BF480 File Offset: 0x000BD680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x000BF4BE File Offset: 0x000BD6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CowLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelScore != 0)
			{
				this.LevelScore = other.LevelScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x000BF4EF File Offset: 0x000BD6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x000BF4F8 File Offset: 0x000BD6F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x040031B2 RID: 12722
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031B3 RID: 12723
		public const int LevelScoreFieldNumber = 1;

		// Token: 0x040031B4 RID: 12724
		private int levelScore_;
	}
}
