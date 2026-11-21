using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000316 RID: 790
	public sealed class CowLevel : IMessage<CowLevel>, IMessage, IEquatable<CowLevel>, IDeepCloneable<CowLevel>, IBufferMessage
	{
		// Token: 0x06004FAC RID: 20396 RVA: 0x000C1750 File Offset: 0x000BF950
		[NullableContext(1)]
		public static CowLevel Create()
		{
			return new CowLevel();
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x000C1757 File Offset: 0x000BF957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x000C175A File Offset: 0x000BF95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CowLevel.Descriptor;
			}
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x000C1761 File Offset: 0x000BF961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel()
		{
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x000C1769 File Offset: 0x000BF969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel(CowLevel other) : this()
		{
			this.levelScore_ = other.levelScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x000C178E File Offset: 0x000BF98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CowLevel Clone()
		{
			return new CowLevel(this);
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x000C1796 File Offset: 0x000BF996
		// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x000C179E File Offset: 0x000BF99E
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

		// Token: 0x06004FB4 RID: 20404 RVA: 0x000C17A7 File Offset: 0x000BF9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CowLevel);
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x000C17B5 File Offset: 0x000BF9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CowLevel other)
		{
			return other != null && (other == this || (this.LevelScore == other.LevelScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x000C17E4 File Offset: 0x000BF9E4
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

		// Token: 0x06004FB7 RID: 20407 RVA: 0x000C1823 File Offset: 0x000BFA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x000C1830 File Offset: 0x000BFA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x000C1839 File Offset: 0x000BFA39
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

		// Token: 0x06004FBA RID: 20410 RVA: 0x000C186C File Offset: 0x000BFA6C
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

		// Token: 0x06004FBB RID: 20411 RVA: 0x000C18AA File Offset: 0x000BFAAA
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

		// Token: 0x06004FBC RID: 20412 RVA: 0x000C18DB File Offset: 0x000BFADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x000C18E4 File Offset: 0x000BFAE4
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

		// Token: 0x04003249 RID: 12873
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400324A RID: 12874
		public const int LevelScoreFieldNumber = 1;

		// Token: 0x0400324B RID: 12875
		private int levelScore_;
	}
}
