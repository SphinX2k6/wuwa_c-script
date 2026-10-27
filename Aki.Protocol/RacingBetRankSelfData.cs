using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E48 RID: 3656
	public sealed class RacingBetRankSelfData : IMessage<RacingBetRankSelfData>, IMessage, IEquatable<RacingBetRankSelfData>, IDeepCloneable<RacingBetRankSelfData>, IBufferMessage
	{
		// Token: 0x06013A11 RID: 80401 RVA: 0x002DA6CE File Offset: 0x002D88CE
		[NullableContext(1)]
		public static RacingBetRankSelfData Create()
		{
			return new RacingBetRankSelfData();
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x06013A12 RID: 80402 RVA: 0x002DA6D5 File Offset: 0x002D88D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x06013A13 RID: 80403 RVA: 0x002DA6D8 File Offset: 0x002D88D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetRankSelfData.Descriptor;
			}
		}

		// Token: 0x06013A14 RID: 80404 RVA: 0x002DA6DF File Offset: 0x002D88DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData()
		{
		}

		// Token: 0x06013A15 RID: 80405 RVA: 0x002DA6F4 File Offset: 0x002D88F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData(RacingBetRankSelfData other) : this()
		{
			this.headIcon_ = other.headIcon_;
			this.name_ = other.name_;
			this.cash_ = other.cash_;
			this.hitNum_ = other.hitNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A16 RID: 80406 RVA: 0x002DA748 File Offset: 0x002D8948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData Clone()
		{
			return new RacingBetRankSelfData(this);
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x06013A17 RID: 80407 RVA: 0x002DA750 File Offset: 0x002D8950
		// (set) Token: 0x06013A18 RID: 80408 RVA: 0x002DA758 File Offset: 0x002D8958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadIcon
		{
			get
			{
				return this.headIcon_;
			}
			set
			{
				this.headIcon_ = value;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x06013A19 RID: 80409 RVA: 0x002DA761 File Offset: 0x002D8961
		// (set) Token: 0x06013A1A RID: 80410 RVA: 0x002DA769 File Offset: 0x002D8969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x06013A1B RID: 80411 RVA: 0x002DA77C File Offset: 0x002D897C
		// (set) Token: 0x06013A1C RID: 80412 RVA: 0x002DA784 File Offset: 0x002D8984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cash
		{
			get
			{
				return this.cash_;
			}
			set
			{
				this.cash_ = value;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x06013A1D RID: 80413 RVA: 0x002DA78D File Offset: 0x002D898D
		// (set) Token: 0x06013A1E RID: 80414 RVA: 0x002DA795 File Offset: 0x002D8995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HitNum
		{
			get
			{
				return this.hitNum_;
			}
			set
			{
				this.hitNum_ = value;
			}
		}

		// Token: 0x06013A1F RID: 80415 RVA: 0x002DA79E File Offset: 0x002D899E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetRankSelfData);
		}

		// Token: 0x06013A20 RID: 80416 RVA: 0x002DA7AC File Offset: 0x002D89AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetRankSelfData other)
		{
			return other != null && (other == this || (this.HeadIcon == other.HeadIcon && !(this.Name != other.Name) && this.Cash == other.Cash && this.HitNum == other.HitNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A21 RID: 80417 RVA: 0x002DA81C File Offset: 0x002D8A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadIcon != 0)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Cash != 0)
			{
				num ^= this.Cash.GetHashCode();
			}
			if (this.HitNum != 0)
			{
				num ^= this.HitNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A22 RID: 80418 RVA: 0x002DA8A8 File Offset: 0x002D8AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A23 RID: 80419 RVA: 0x002DA8B5 File Offset: 0x002D8AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A24 RID: 80420 RVA: 0x002DA8C0 File Offset: 0x002D8AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadIcon != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HeadIcon);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Cash != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Cash);
			}
			if (this.HitNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HitNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A25 RID: 80421 RVA: 0x002DA958 File Offset: 0x002D8B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadIcon != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadIcon);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Cash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cash);
			}
			if (this.HitNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HitNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A26 RID: 80422 RVA: 0x002DA9E4 File Offset: 0x002D8BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetRankSelfData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadIcon != 0)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Cash != 0)
			{
				this.Cash = other.Cash;
			}
			if (other.HitNum != 0)
			{
				this.HitNum = other.HitNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A27 RID: 80423 RVA: 0x002DAA61 File Offset: 0x002D8C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A28 RID: 80424 RVA: 0x002DAA6C File Offset: 0x002D8C6C
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.HeadIcon = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Cash = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.HitNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007822 RID: 30754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007823 RID: 30755
		public const int HeadIconFieldNumber = 1;

		// Token: 0x04007824 RID: 30756
		private int headIcon_;

		// Token: 0x04007825 RID: 30757
		public const int NameFieldNumber = 2;

		// Token: 0x04007826 RID: 30758
		private string name_ = "";

		// Token: 0x04007827 RID: 30759
		public const int CashFieldNumber = 3;

		// Token: 0x04007828 RID: 30760
		private int cash_;

		// Token: 0x04007829 RID: 30761
		public const int HitNumFieldNumber = 4;

		// Token: 0x0400782A RID: 30762
		private int hitNum_;
	}
}
