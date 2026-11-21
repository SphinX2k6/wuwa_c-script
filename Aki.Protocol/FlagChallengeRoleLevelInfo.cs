using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000587 RID: 1415
	public sealed class FlagChallengeRoleLevelInfo : IMessage<FlagChallengeRoleLevelInfo>, IMessage, IEquatable<FlagChallengeRoleLevelInfo>, IDeepCloneable<FlagChallengeRoleLevelInfo>, IBufferMessage
	{
		// Token: 0x06008383 RID: 33667 RVA: 0x0013CF99 File Offset: 0x0013B199
		[NullableContext(1)]
		public static FlagChallengeRoleLevelInfo Create()
		{
			return new FlagChallengeRoleLevelInfo();
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x0013CFA0 File Offset: 0x0013B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06008385 RID: 33669 RVA: 0x0013CFA3 File Offset: 0x0013B1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRoleLevelInfo.Descriptor;
			}
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x0013CFAA File Offset: 0x0013B1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo()
		{
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x0013CFB2 File Offset: 0x0013B1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo(FlagChallengeRoleLevelInfo other) : this()
		{
			this.perLevel_ = other.perLevel_;
			this.perExp_ = other.perExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0013CFE3 File Offset: 0x0013B1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo Clone()
		{
			return new FlagChallengeRoleLevelInfo(this);
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x0013CFEB File Offset: 0x0013B1EB
		// (set) Token: 0x0600838A RID: 33674 RVA: 0x0013CFF3 File Offset: 0x0013B1F3
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

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600838B RID: 33675 RVA: 0x0013CFFC File Offset: 0x0013B1FC
		// (set) Token: 0x0600838C RID: 33676 RVA: 0x0013D004 File Offset: 0x0013B204
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

		// Token: 0x0600838D RID: 33677 RVA: 0x0013D00D File Offset: 0x0013B20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRoleLevelInfo);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0013D01B File Offset: 0x0013B21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRoleLevelInfo other)
		{
			return other != null && (other == this || (this.PerLevel == other.PerLevel && this.PerExp == other.PerExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0013D05C File Offset: 0x0013B25C
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

		// Token: 0x06008390 RID: 33680 RVA: 0x0013D0B4 File Offset: 0x0013B2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0013D0C1 File Offset: 0x0013B2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0013D0CC File Offset: 0x0013B2CC
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

		// Token: 0x06008393 RID: 33683 RVA: 0x0013D124 File Offset: 0x0013B324
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

		// Token: 0x06008394 RID: 33684 RVA: 0x0013D17C File Offset: 0x0013B37C
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

		// Token: 0x06008395 RID: 33685 RVA: 0x0013D1CC File Offset: 0x0013B3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0013D1D8 File Offset: 0x0013B3D8
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

		// Token: 0x040041D1 RID: 16849
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D2 RID: 16850
		public const int PerLevelFieldNumber = 1;

		// Token: 0x040041D3 RID: 16851
		private int perLevel_;

		// Token: 0x040041D4 RID: 16852
		public const int PerExpFieldNumber = 2;

		// Token: 0x040041D5 RID: 16853
		private int perExp_;
	}
}
