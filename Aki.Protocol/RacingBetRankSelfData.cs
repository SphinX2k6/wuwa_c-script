using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E38 RID: 3640
	public sealed class RacingBetRankSelfData : IMessage<RacingBetRankSelfData>, IMessage, IEquatable<RacingBetRankSelfData>, IDeepCloneable<RacingBetRankSelfData>, IBufferMessage
	{
		// Token: 0x0601392C RID: 80172 RVA: 0x002D9012 File Offset: 0x002D7212
		[NullableContext(1)]
		public static RacingBetRankSelfData Create()
		{
			return new RacingBetRankSelfData();
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0601392D RID: 80173 RVA: 0x002D9019 File Offset: 0x002D7219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0601392E RID: 80174 RVA: 0x002D901C File Offset: 0x002D721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetRankSelfData.Descriptor;
			}
		}

		// Token: 0x0601392F RID: 80175 RVA: 0x002D9023 File Offset: 0x002D7223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData()
		{
		}

		// Token: 0x06013930 RID: 80176 RVA: 0x002D9038 File Offset: 0x002D7238
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

		// Token: 0x06013931 RID: 80177 RVA: 0x002D908C File Offset: 0x002D728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData Clone()
		{
			return new RacingBetRankSelfData(this);
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x06013932 RID: 80178 RVA: 0x002D9094 File Offset: 0x002D7294
		// (set) Token: 0x06013933 RID: 80179 RVA: 0x002D909C File Offset: 0x002D729C
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

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x06013934 RID: 80180 RVA: 0x002D90A5 File Offset: 0x002D72A5
		// (set) Token: 0x06013935 RID: 80181 RVA: 0x002D90AD File Offset: 0x002D72AD
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

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x06013936 RID: 80182 RVA: 0x002D90C0 File Offset: 0x002D72C0
		// (set) Token: 0x06013937 RID: 80183 RVA: 0x002D90C8 File Offset: 0x002D72C8
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

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x06013938 RID: 80184 RVA: 0x002D90D1 File Offset: 0x002D72D1
		// (set) Token: 0x06013939 RID: 80185 RVA: 0x002D90D9 File Offset: 0x002D72D9
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

		// Token: 0x0601393A RID: 80186 RVA: 0x002D90E2 File Offset: 0x002D72E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetRankSelfData);
		}

		// Token: 0x0601393B RID: 80187 RVA: 0x002D90F0 File Offset: 0x002D72F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetRankSelfData other)
		{
			return other != null && (other == this || (this.HeadIcon == other.HeadIcon && !(this.Name != other.Name) && this.Cash == other.Cash && this.HitNum == other.HitNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601393C RID: 80188 RVA: 0x002D9160 File Offset: 0x002D7360
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

		// Token: 0x0601393D RID: 80189 RVA: 0x002D91EC File Offset: 0x002D73EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601393E RID: 80190 RVA: 0x002D91F9 File Offset: 0x002D73F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601393F RID: 80191 RVA: 0x002D9204 File Offset: 0x002D7404
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

		// Token: 0x06013940 RID: 80192 RVA: 0x002D929C File Offset: 0x002D749C
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

		// Token: 0x06013941 RID: 80193 RVA: 0x002D9328 File Offset: 0x002D7528
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

		// Token: 0x06013942 RID: 80194 RVA: 0x002D93A5 File Offset: 0x002D75A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013943 RID: 80195 RVA: 0x002D93B0 File Offset: 0x002D75B0
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

		// Token: 0x0400784C RID: 30796
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400784D RID: 30797
		public const int HeadIconFieldNumber = 1;

		// Token: 0x0400784E RID: 30798
		private int headIcon_;

		// Token: 0x0400784F RID: 30799
		public const int NameFieldNumber = 2;

		// Token: 0x04007850 RID: 30800
		private string name_ = "";

		// Token: 0x04007851 RID: 30801
		public const int CashFieldNumber = 3;

		// Token: 0x04007852 RID: 30802
		private int cash_;

		// Token: 0x04007853 RID: 30803
		public const int HitNumFieldNumber = 4;

		// Token: 0x04007854 RID: 30804
		private int hitNum_;
	}
}
