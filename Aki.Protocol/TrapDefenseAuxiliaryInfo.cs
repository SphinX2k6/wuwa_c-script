using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001478 RID: 5240
	public sealed class TrapDefenseAuxiliaryInfo : IMessage<TrapDefenseAuxiliaryInfo>, IMessage, IEquatable<TrapDefenseAuxiliaryInfo>, IDeepCloneable<TrapDefenseAuxiliaryInfo>, IBufferMessage
	{
		// Token: 0x0601BD46 RID: 113990 RVA: 0x0040B755 File Offset: 0x00409955
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryInfo Create()
		{
			return new TrapDefenseAuxiliaryInfo();
		}

		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x0601BD47 RID: 113991 RVA: 0x0040B75C File Offset: 0x0040995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseAuxiliaryInfo> Parser
		{
			get
			{
				return TrapDefenseAuxiliaryInfo._parser;
			}
		}

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x0601BD48 RID: 113992 RVA: 0x0040B763 File Offset: 0x00409963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x0601BD49 RID: 113993 RVA: 0x0040B766 File Offset: 0x00409966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryInfo.Descriptor;
			}
		}

		// Token: 0x0601BD4A RID: 113994 RVA: 0x0040B76D File Offset: 0x0040996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo()
		{
		}

		// Token: 0x0601BD4B RID: 113995 RVA: 0x0040B778 File Offset: 0x00409978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo(TrapDefenseAuxiliaryInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.branch_ = other.branch_;
			this.curMaxLevel_ = other.curMaxLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD4C RID: 113996 RVA: 0x0040B7CC File Offset: 0x004099CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo Clone()
		{
			return new TrapDefenseAuxiliaryInfo(this);
		}

		// Token: 0x17005E3F RID: 24127
		// (get) Token: 0x0601BD4D RID: 113997 RVA: 0x0040B7D4 File Offset: 0x004099D4
		// (set) Token: 0x0601BD4E RID: 113998 RVA: 0x0040B7DC File Offset: 0x004099DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005E40 RID: 24128
		// (get) Token: 0x0601BD4F RID: 113999 RVA: 0x0040B7E5 File Offset: 0x004099E5
		// (set) Token: 0x0601BD50 RID: 114000 RVA: 0x0040B7ED File Offset: 0x004099ED
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

		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x0601BD51 RID: 114001 RVA: 0x0040B7F6 File Offset: 0x004099F6
		// (set) Token: 0x0601BD52 RID: 114002 RVA: 0x0040B7FE File Offset: 0x004099FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Branch
		{
			get
			{
				return this.branch_;
			}
			set
			{
				this.branch_ = value;
			}
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x0601BD53 RID: 114003 RVA: 0x0040B807 File Offset: 0x00409A07
		// (set) Token: 0x0601BD54 RID: 114004 RVA: 0x0040B80F File Offset: 0x00409A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurMaxLevel
		{
			get
			{
				return this.curMaxLevel_;
			}
			set
			{
				this.curMaxLevel_ = value;
			}
		}

		// Token: 0x0601BD55 RID: 114005 RVA: 0x0040B818 File Offset: 0x00409A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryInfo);
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x0040B828 File Offset: 0x00409A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Branch == other.Branch && this.CurMaxLevel == other.CurMaxLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD57 RID: 114007 RVA: 0x0040B894 File Offset: 0x00409A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Branch != 0)
			{
				num ^= this.Branch.GetHashCode();
			}
			if (this.CurMaxLevel != 0)
			{
				num ^= this.CurMaxLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD58 RID: 114008 RVA: 0x0040B91E File Offset: 0x00409B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD59 RID: 114009 RVA: 0x0040B92B File Offset: 0x00409B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD5A RID: 114010 RVA: 0x0040B934 File Offset: 0x00409B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Branch);
			}
			if (this.CurMaxLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurMaxLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD5B RID: 114011 RVA: 0x0040B9C4 File Offset: 0x00409BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Branch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Branch);
			}
			if (this.CurMaxLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurMaxLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD5C RID: 114012 RVA: 0x0040BA4C File Offset: 0x00409C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Branch != 0)
			{
				this.Branch = other.Branch;
			}
			if (other.CurMaxLevel != 0)
			{
				this.CurMaxLevel = other.CurMaxLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD5D RID: 114013 RVA: 0x0040BAC4 File Offset: 0x00409CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD5E RID: 114014 RVA: 0x0040BAD0 File Offset: 0x00409CD0
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
						this.Id = input.ReadInt32();
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
						this.Branch = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurMaxLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A189 RID: 41353
		private static readonly MessageParser<TrapDefenseAuxiliaryInfo> _parser = new MessageParser<TrapDefenseAuxiliaryInfo>(() => new TrapDefenseAuxiliaryInfo());

		// Token: 0x0400A18A RID: 41354
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A18B RID: 41355
		public const int IdFieldNumber = 1;

		// Token: 0x0400A18C RID: 41356
		private int id_;

		// Token: 0x0400A18D RID: 41357
		public const int LevelFieldNumber = 2;

		// Token: 0x0400A18E RID: 41358
		private int level_;

		// Token: 0x0400A18F RID: 41359
		public const int BranchFieldNumber = 3;

		// Token: 0x0400A190 RID: 41360
		private int branch_;

		// Token: 0x0400A191 RID: 41361
		public const int CurMaxLevelFieldNumber = 4;

		// Token: 0x0400A192 RID: 41362
		private int curMaxLevel_;
	}
}
