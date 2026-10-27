using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000562 RID: 1378
	public sealed class FishingIllustratedRewardInfo : IMessage<FishingIllustratedRewardInfo>, IMessage, IEquatable<FishingIllustratedRewardInfo>, IDeepCloneable<FishingIllustratedRewardInfo>, IBufferMessage
	{
		// Token: 0x06008074 RID: 32884 RVA: 0x00136487 File Offset: 0x00134687
		[NullableContext(1)]
		public static FishingIllustratedRewardInfo Create()
		{
			return new FishingIllustratedRewardInfo();
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x0013648E File Offset: 0x0013468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingIllustratedRewardInfo> Parser
		{
			get
			{
				return FishingIllustratedRewardInfo._parser;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x00136495 File Offset: 0x00134695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06008077 RID: 32887 RVA: 0x00136498 File Offset: 0x00134698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardInfo.Descriptor;
			}
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x0013649F File Offset: 0x0013469F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo()
		{
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x001364A8 File Offset: 0x001346A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo(FishingIllustratedRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x00136508 File Offset: 0x00134708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo Clone()
		{
			return new FishingIllustratedRewardInfo(this);
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00136510 File Offset: 0x00134710
		// (set) Token: 0x0600807C RID: 32892 RVA: 0x00136518 File Offset: 0x00134718
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

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x00136521 File Offset: 0x00134721
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x00136529 File Offset: 0x00134729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x00136532 File Offset: 0x00134732
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x0013653A File Offset: 0x0013473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x00136543 File Offset: 0x00134743
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x0013654B File Offset: 0x0013474B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x00136554 File Offset: 0x00134754
		// (set) Token: 0x06008084 RID: 32900 RVA: 0x0013655C File Offset: 0x0013475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTaken
		{
			get
			{
				return this.isTaken_;
			}
			set
			{
				this.isTaken_ = value;
			}
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x00136565 File Offset: 0x00134765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardInfo);
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00136574 File Offset: 0x00134774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x001365F0 File Offset: 0x001347F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.IsTaken)
			{
				num ^= this.IsTaken.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x00136693 File Offset: 0x00134893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x001366A0 File Offset: 0x001348A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x001366AC File Offset: 0x001348AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinished);
			}
			if (this.IsTaken)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTaken);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00136758 File Offset: 0x00134958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.IsTaken)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x001367E0 File Offset: 0x001349E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.IsTaken)
			{
				this.IsTaken = other.IsTaken;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x0013686C File Offset: 0x00134A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x00136878 File Offset: 0x00134A78
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
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsTaken = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040040A6 RID: 16550
		private static readonly MessageParser<FishingIllustratedRewardInfo> _parser = new MessageParser<FishingIllustratedRewardInfo>(() => new FishingIllustratedRewardInfo());

		// Token: 0x040040A7 RID: 16551
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040A8 RID: 16552
		public const int IdFieldNumber = 1;

		// Token: 0x040040A9 RID: 16553
		private int id_;

		// Token: 0x040040AA RID: 16554
		public const int CurrentFieldNumber = 2;

		// Token: 0x040040AB RID: 16555
		private int current_;

		// Token: 0x040040AC RID: 16556
		public const int TargetFieldNumber = 3;

		// Token: 0x040040AD RID: 16557
		private int target_;

		// Token: 0x040040AE RID: 16558
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040040AF RID: 16559
		private bool isFinished_;

		// Token: 0x040040B0 RID: 16560
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040040B1 RID: 16561
		private bool isTaken_;
	}
}
