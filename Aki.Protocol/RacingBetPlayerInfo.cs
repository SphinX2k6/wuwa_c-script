using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E36 RID: 3638
	public sealed class RacingBetPlayerInfo : IMessage<RacingBetPlayerInfo>, IMessage, IEquatable<RacingBetPlayerInfo>, IDeepCloneable<RacingBetPlayerInfo>, IBufferMessage
	{
		// Token: 0x060138F4 RID: 80116 RVA: 0x002D85E6 File Offset: 0x002D67E6
		[NullableContext(1)]
		public static RacingBetPlayerInfo Create()
		{
			return new RacingBetPlayerInfo();
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x060138F5 RID: 80117 RVA: 0x002D85ED File Offset: 0x002D67ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x060138F6 RID: 80118 RVA: 0x002D85F0 File Offset: 0x002D67F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetPlayerInfo.Descriptor;
			}
		}

		// Token: 0x060138F7 RID: 80119 RVA: 0x002D85F7 File Offset: 0x002D67F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo()
		{
		}

		// Token: 0x060138F8 RID: 80120 RVA: 0x002D860C File Offset: 0x002D680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo(RacingBetPlayerInfo other) : this()
		{
			this.curCash_ = other.curCash_;
			this.totalCash_ = other.totalCash_;
			this.gearInfo_ = other.gearInfo_.Clone();
			this.hitNum_ = other.hitNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138F9 RID: 80121 RVA: 0x002D8665 File Offset: 0x002D6865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo Clone()
		{
			return new RacingBetPlayerInfo(this);
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x060138FA RID: 80122 RVA: 0x002D866D File Offset: 0x002D686D
		// (set) Token: 0x060138FB RID: 80123 RVA: 0x002D8675 File Offset: 0x002D6875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCash
		{
			get
			{
				return this.curCash_;
			}
			set
			{
				this.curCash_ = value;
			}
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x060138FC RID: 80124 RVA: 0x002D867E File Offset: 0x002D687E
		// (set) Token: 0x060138FD RID: 80125 RVA: 0x002D8686 File Offset: 0x002D6886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCash
		{
			get
			{
				return this.totalCash_;
			}
			set
			{
				this.totalCash_ = value;
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x060138FE RID: 80126 RVA: 0x002D868F File Offset: 0x002D688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGearInfo> GearInfo
		{
			get
			{
				return this.gearInfo_;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x060138FF RID: 80127 RVA: 0x002D8697 File Offset: 0x002D6897
		// (set) Token: 0x06013900 RID: 80128 RVA: 0x002D869F File Offset: 0x002D689F
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

		// Token: 0x06013901 RID: 80129 RVA: 0x002D86A8 File Offset: 0x002D68A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetPlayerInfo);
		}

		// Token: 0x06013902 RID: 80130 RVA: 0x002D86B8 File Offset: 0x002D68B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetPlayerInfo other)
		{
			return other != null && (other == this || (this.CurCash == other.CurCash && this.TotalCash == other.TotalCash && this.gearInfo_.Equals(other.gearInfo_) && this.HitNum == other.HitNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013903 RID: 80131 RVA: 0x002D8728 File Offset: 0x002D6928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurCash != 0)
			{
				num ^= this.CurCash.GetHashCode();
			}
			if (this.TotalCash != 0)
			{
				num ^= this.TotalCash.GetHashCode();
			}
			num ^= this.gearInfo_.GetHashCode();
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

		// Token: 0x06013904 RID: 80132 RVA: 0x002D87A7 File Offset: 0x002D69A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013905 RID: 80133 RVA: 0x002D87B4 File Offset: 0x002D69B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013906 RID: 80134 RVA: 0x002D87C0 File Offset: 0x002D69C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCash != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurCash);
			}
			if (this.TotalCash != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCash);
			}
			this.gearInfo_.WriteTo(ref output, RacingBetPlayerInfo._repeated_gearInfo_codec);
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

		// Token: 0x06013907 RID: 80135 RVA: 0x002D8848 File Offset: 0x002D6A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurCash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCash);
			}
			if (this.TotalCash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCash);
			}
			num += this.gearInfo_.CalculateSize(RacingBetPlayerInfo._repeated_gearInfo_codec);
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

		// Token: 0x06013908 RID: 80136 RVA: 0x002D88CC File Offset: 0x002D6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurCash != 0)
			{
				this.CurCash = other.CurCash;
			}
			if (other.TotalCash != 0)
			{
				this.TotalCash = other.TotalCash;
			}
			this.gearInfo_.Add(other.gearInfo_);
			if (other.HitNum != 0)
			{
				this.HitNum = other.HitNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013909 RID: 80137 RVA: 0x002D8941 File Offset: 0x002D6B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601390A RID: 80138 RVA: 0x002D894C File Offset: 0x002D6B4C
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
						this.CurCash = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCash = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.gearInfo_.AddEntriesFrom(ref input, RacingBetPlayerInfo._repeated_gearInfo_codec);
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

		// Token: 0x04007832 RID: 30770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007833 RID: 30771
		public const int CurCashFieldNumber = 1;

		// Token: 0x04007834 RID: 30772
		private int curCash_;

		// Token: 0x04007835 RID: 30773
		public const int TotalCashFieldNumber = 2;

		// Token: 0x04007836 RID: 30774
		private int totalCash_;

		// Token: 0x04007837 RID: 30775
		public const int GearInfoFieldNumber = 3;

		// Token: 0x04007838 RID: 30776
		private static readonly FieldCodec<RacingBetsGearInfo> _repeated_gearInfo_codec = FieldCodec.ForMessage<RacingBetsGearInfo>(26U, RacingBetsGearInfo.Parser);

		// Token: 0x04007839 RID: 30777
		private readonly RepeatedField<RacingBetsGearInfo> gearInfo_ = new RepeatedField<RacingBetsGearInfo>();

		// Token: 0x0400783A RID: 30778
		public const int HitNumFieldNumber = 4;

		// Token: 0x0400783B RID: 30779
		private int hitNum_;
	}
}
