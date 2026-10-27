using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059C RID: 1436
	public sealed class FlagChallengeRoleLevelInfo : IMessage<FlagChallengeRoleLevelInfo>, IMessage, IEquatable<FlagChallengeRoleLevelInfo>, IDeepCloneable<FlagChallengeRoleLevelInfo>, IBufferMessage
	{
		// Token: 0x060084EB RID: 34027 RVA: 0x0013FBA1 File Offset: 0x0013DDA1
		[NullableContext(1)]
		public static FlagChallengeRoleLevelInfo Create()
		{
			return new FlagChallengeRoleLevelInfo();
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x060084EC RID: 34028 RVA: 0x0013FBA8 File Offset: 0x0013DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060084ED RID: 34029 RVA: 0x0013FBAB File Offset: 0x0013DDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRoleLevelInfo.Descriptor;
			}
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x0013FBB2 File Offset: 0x0013DDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo()
		{
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x0013FBBA File Offset: 0x0013DDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo(FlagChallengeRoleLevelInfo other) : this()
		{
			this.perLevel_ = other.perLevel_;
			this.perExp_ = other.perExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x0013FBEB File Offset: 0x0013DDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo Clone()
		{
			return new FlagChallengeRoleLevelInfo(this);
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x0013FBF3 File Offset: 0x0013DDF3
		// (set) Token: 0x060084F2 RID: 34034 RVA: 0x0013FBFB File Offset: 0x0013DDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PerLevel
		{
			get
			{
				return this.perLevel_;
			}
			set
			{
				this.perLevel_ = value;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x0013FC04 File Offset: 0x0013DE04
		// (set) Token: 0x060084F4 RID: 34036 RVA: 0x0013FC0C File Offset: 0x0013DE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PerExp
		{
			get
			{
				return this.perExp_;
			}
			set
			{
				this.perExp_ = value;
			}
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x0013FC15 File Offset: 0x0013DE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRoleLevelInfo);
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x0013FC23 File Offset: 0x0013DE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRoleLevelInfo other)
		{
			return other != null && (other == this || (this.PerLevel == other.PerLevel && this.PerExp == other.PerExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x0013FC64 File Offset: 0x0013DE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PerLevel != 0)
			{
				num ^= this.PerLevel.GetHashCode();
			}
			if (this.PerExp != 0)
			{
				num ^= this.PerExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x0013FCBC File Offset: 0x0013DEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x0013FCC9 File Offset: 0x0013DEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x0013FCD4 File Offset: 0x0013DED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PerLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PerLevel);
			}
			if (this.PerExp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PerExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x0013FD2C File Offset: 0x0013DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PerLevel);
			}
			if (this.PerExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PerExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x0013FD84 File Offset: 0x0013DF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeRoleLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PerLevel != 0)
			{
				this.PerLevel = other.PerLevel;
			}
			if (other.PerExp != 0)
			{
				this.PerExp = other.PerExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x0013FDD4 File Offset: 0x0013DFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x0013FDE0 File Offset: 0x0013DFE0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PerExp = input.ReadInt32();
					}
				}
				else
				{
					this.PerLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041DB RID: 16859
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041DC RID: 16860
		public const int PerLevelFieldNumber = 1;

		// Token: 0x040041DD RID: 16861
		private int perLevel_;

		// Token: 0x040041DE RID: 16862
		public const int PerExpFieldNumber = 2;

		// Token: 0x040041DF RID: 16863
		private int perExp_;
	}
}
