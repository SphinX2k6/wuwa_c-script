using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001056 RID: 4182
	public sealed class RoleBondInfo : IMessage<RoleBondInfo>, IMessage, IEquatable<RoleBondInfo>, IDeepCloneable<RoleBondInfo>, IBufferMessage
	{
		// Token: 0x06016580 RID: 91520 RVA: 0x0033F1CE File Offset: 0x0033D3CE
		[NullableContext(1)]
		public static RoleBondInfo Create()
		{
			return new RoleBondInfo();
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x06016581 RID: 91521 RVA: 0x0033F1D5 File Offset: 0x0033D3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleBondInfo> Parser
		{
			get
			{
				return RoleBondInfo._parser;
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x06016582 RID: 91522 RVA: 0x0033F1DC File Offset: 0x0033D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x06016583 RID: 91523 RVA: 0x0033F1DF File Offset: 0x0033D3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBondInfo.Descriptor;
			}
		}

		// Token: 0x06016584 RID: 91524 RVA: 0x0033F1E6 File Offset: 0x0033D3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo()
		{
		}

		// Token: 0x06016585 RID: 91525 RVA: 0x0033F1F0 File Offset: 0x0033D3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo(RoleBondInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.level_ = other.level_;
			this.targetStar_ = other.targetStar_;
			this.curStar_ = other.curStar_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016586 RID: 91526 RVA: 0x0033F244 File Offset: 0x0033D444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfo Clone()
		{
			return new RoleBondInfo(this);
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x06016587 RID: 91527 RVA: 0x0033F24C File Offset: 0x0033D44C
		// (set) Token: 0x06016588 RID: 91528 RVA: 0x0033F254 File Offset: 0x0033D454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x06016589 RID: 91529 RVA: 0x0033F25D File Offset: 0x0033D45D
		// (set) Token: 0x0601658A RID: 91530 RVA: 0x0033F265 File Offset: 0x0033D465
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

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x0601658B RID: 91531 RVA: 0x0033F26E File Offset: 0x0033D46E
		// (set) Token: 0x0601658C RID: 91532 RVA: 0x0033F276 File Offset: 0x0033D476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetStar
		{
			get
			{
				return this.targetStar_;
			}
			set
			{
				this.targetStar_ = value;
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x0601658D RID: 91533 RVA: 0x0033F27F File Offset: 0x0033D47F
		// (set) Token: 0x0601658E RID: 91534 RVA: 0x0033F287 File Offset: 0x0033D487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStar
		{
			get
			{
				return this.curStar_;
			}
			set
			{
				this.curStar_ = value;
			}
		}

		// Token: 0x0601658F RID: 91535 RVA: 0x0033F290 File Offset: 0x0033D490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBondInfo);
		}

		// Token: 0x06016590 RID: 91536 RVA: 0x0033F2A0 File Offset: 0x0033D4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBondInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.Level == other.Level && this.TargetStar == other.TargetStar && this.CurStar == other.CurStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016591 RID: 91537 RVA: 0x0033F30C File Offset: 0x0033D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.TargetStar != 0)
			{
				num ^= this.TargetStar.GetHashCode();
			}
			if (this.CurStar != 0)
			{
				num ^= this.CurStar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016592 RID: 91538 RVA: 0x0033F396 File Offset: 0x0033D596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016593 RID: 91539 RVA: 0x0033F3A3 File Offset: 0x0033D5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016594 RID: 91540 RVA: 0x0033F3AC File Offset: 0x0033D5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.TargetStar != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetStar);
			}
			if (this.CurStar != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurStar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016595 RID: 91541 RVA: 0x0033F43C File Offset: 0x0033D63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.TargetStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetStar);
			}
			if (this.CurStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016596 RID: 91542 RVA: 0x0033F4C4 File Offset: 0x0033D6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBondInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.TargetStar != 0)
			{
				this.TargetStar = other.TargetStar;
			}
			if (other.CurStar != 0)
			{
				this.CurStar = other.CurStar;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016597 RID: 91543 RVA: 0x0033F53C File Offset: 0x0033D73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016598 RID: 91544 RVA: 0x0033F548 File Offset: 0x0033D748
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
						this.ConfigId = input.ReadInt32();
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
						this.TargetStar = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurStar = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085A0 RID: 34208
		private static readonly MessageParser<RoleBondInfo> _parser = new MessageParser<RoleBondInfo>(() => new RoleBondInfo());

		// Token: 0x040085A1 RID: 34209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085A2 RID: 34210
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040085A3 RID: 34211
		private int configId_;

		// Token: 0x040085A4 RID: 34212
		public const int LevelFieldNumber = 2;

		// Token: 0x040085A5 RID: 34213
		private int level_;

		// Token: 0x040085A6 RID: 34214
		public const int TargetStarFieldNumber = 3;

		// Token: 0x040085A7 RID: 34215
		private int targetStar_;

		// Token: 0x040085A8 RID: 34216
		public const int CurStarFieldNumber = 4;

		// Token: 0x040085A9 RID: 34217
		private int curStar_;
	}
}
