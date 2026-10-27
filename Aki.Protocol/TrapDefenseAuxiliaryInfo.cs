using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001405 RID: 5125
	public sealed class TrapDefenseAuxiliaryInfo : IMessage<TrapDefenseAuxiliaryInfo>, IMessage, IEquatable<TrapDefenseAuxiliaryInfo>, IDeepCloneable<TrapDefenseAuxiliaryInfo>, IBufferMessage
	{
		// Token: 0x0601B2BB RID: 111291 RVA: 0x003F047D File Offset: 0x003EE67D
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryInfo Create()
		{
			return new TrapDefenseAuxiliaryInfo();
		}

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x0601B2BC RID: 111292 RVA: 0x003F0484 File Offset: 0x003EE684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseAuxiliaryInfo> Parser
		{
			get
			{
				return TrapDefenseAuxiliaryInfo._parser;
			}
		}

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x0601B2BD RID: 111293 RVA: 0x003F048B File Offset: 0x003EE68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x0601B2BE RID: 111294 RVA: 0x003F048E File Offset: 0x003EE68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryInfo.Descriptor;
			}
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x003F0495 File Offset: 0x003EE695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo()
		{
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x003F04A0 File Offset: 0x003EE6A0
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

		// Token: 0x0601B2C1 RID: 111297 RVA: 0x003F04F4 File Offset: 0x003EE6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo Clone()
		{
			return new TrapDefenseAuxiliaryInfo(this);
		}

		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x0601B2C2 RID: 111298 RVA: 0x003F04FC File Offset: 0x003EE6FC
		// (set) Token: 0x0601B2C3 RID: 111299 RVA: 0x003F0504 File Offset: 0x003EE704
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

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x0601B2C4 RID: 111300 RVA: 0x003F050D File Offset: 0x003EE70D
		// (set) Token: 0x0601B2C5 RID: 111301 RVA: 0x003F0515 File Offset: 0x003EE715
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

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x0601B2C6 RID: 111302 RVA: 0x003F051E File Offset: 0x003EE71E
		// (set) Token: 0x0601B2C7 RID: 111303 RVA: 0x003F0526 File Offset: 0x003EE726
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

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x0601B2C8 RID: 111304 RVA: 0x003F052F File Offset: 0x003EE72F
		// (set) Token: 0x0601B2C9 RID: 111305 RVA: 0x003F0537 File Offset: 0x003EE737
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

		// Token: 0x0601B2CA RID: 111306 RVA: 0x003F0540 File Offset: 0x003EE740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryInfo);
		}

		// Token: 0x0601B2CB RID: 111307 RVA: 0x003F0550 File Offset: 0x003EE750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Branch == other.Branch && this.CurMaxLevel == other.CurMaxLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2CC RID: 111308 RVA: 0x003F05BC File Offset: 0x003EE7BC
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

		// Token: 0x0601B2CD RID: 111309 RVA: 0x003F0646 File Offset: 0x003EE846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2CE RID: 111310 RVA: 0x003F0653 File Offset: 0x003EE853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2CF RID: 111311 RVA: 0x003F065C File Offset: 0x003EE85C
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

		// Token: 0x0601B2D0 RID: 111312 RVA: 0x003F06EC File Offset: 0x003EE8EC
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

		// Token: 0x0601B2D1 RID: 111313 RVA: 0x003F0774 File Offset: 0x003EE974
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

		// Token: 0x0601B2D2 RID: 111314 RVA: 0x003F07EC File Offset: 0x003EE9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2D3 RID: 111315 RVA: 0x003F07F8 File Offset: 0x003EE9F8
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

		// Token: 0x04009D42 RID: 40258
		private static readonly MessageParser<TrapDefenseAuxiliaryInfo> _parser = new MessageParser<TrapDefenseAuxiliaryInfo>(() => new TrapDefenseAuxiliaryInfo());

		// Token: 0x04009D43 RID: 40259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D44 RID: 40260
		public const int IdFieldNumber = 1;

		// Token: 0x04009D45 RID: 40261
		private int id_;

		// Token: 0x04009D46 RID: 40262
		public const int LevelFieldNumber = 2;

		// Token: 0x04009D47 RID: 40263
		private int level_;

		// Token: 0x04009D48 RID: 40264
		public const int BranchFieldNumber = 3;

		// Token: 0x04009D49 RID: 40265
		private int branch_;

		// Token: 0x04009D4A RID: 40266
		public const int CurMaxLevelFieldNumber = 4;

		// Token: 0x04009D4B RID: 40267
		private int curMaxLevel_;
	}
}
