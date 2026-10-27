using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074B RID: 1867
	public sealed class HarvestLevelReward : IMessage<HarvestLevelReward>, IMessage, IEquatable<HarvestLevelReward>, IDeepCloneable<HarvestLevelReward>, IBufferMessage
	{
		// Token: 0x0600A906 RID: 43270 RVA: 0x0019668A File Offset: 0x0019488A
		[NullableContext(1)]
		public static HarvestLevelReward Create()
		{
			return new HarvestLevelReward();
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600A907 RID: 43271 RVA: 0x00196691 File Offset: 0x00194891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HarvestLevelReward> Parser
		{
			get
			{
				return HarvestLevelReward._parser;
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x00196698 File Offset: 0x00194898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600A909 RID: 43273 RVA: 0x0019669B File Offset: 0x0019489B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestLevelReward.Descriptor;
			}
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x001966A2 File Offset: 0x001948A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestLevelReward()
		{
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x001966AC File Offset: 0x001948AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestLevelReward(HarvestLevelReward other) : this()
		{
			this.id_ = other.id_;
			this.startTime_ = other.startTime_;
			this.isOpen_ = other.isOpen_;
			this.point_ = other.point_;
			this.diff_ = other.diff_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x00196718 File Offset: 0x00194918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestLevelReward Clone()
		{
			return new HarvestLevelReward(this);
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600A90D RID: 43277 RVA: 0x00196720 File Offset: 0x00194920
		// (set) Token: 0x0600A90E RID: 43278 RVA: 0x00196728 File Offset: 0x00194928
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

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x00196731 File Offset: 0x00194931
		// (set) Token: 0x0600A910 RID: 43280 RVA: 0x00196739 File Offset: 0x00194939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x00196742 File Offset: 0x00194942
		// (set) Token: 0x0600A912 RID: 43282 RVA: 0x0019674A File Offset: 0x0019494A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x00196753 File Offset: 0x00194953
		// (set) Token: 0x0600A914 RID: 43284 RVA: 0x0019675B File Offset: 0x0019495B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600A915 RID: 43285 RVA: 0x00196764 File Offset: 0x00194964
		// (set) Token: 0x0600A916 RID: 43286 RVA: 0x0019676C File Offset: 0x0019496C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Diff
		{
			get
			{
				return this.diff_;
			}
			set
			{
				this.diff_ = value;
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600A917 RID: 43287 RVA: 0x00196775 File Offset: 0x00194975
		// (set) Token: 0x0600A918 RID: 43288 RVA: 0x0019677D File Offset: 0x0019497D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x00196786 File Offset: 0x00194986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestLevelReward);
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x00196794 File Offset: 0x00194994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestLevelReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Point == other.Point && this.Diff == other.Diff && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x00196820 File Offset: 0x00194A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StartTime != 0)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.Diff != 0)
			{
				num ^= this.Diff.GetHashCode();
			}
			if (this.State != SignState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x001968E2 File Offset: 0x00194AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x001968EF File Offset: 0x00194AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x001968F8 File Offset: 0x00194AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.StartTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartTime);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOpen);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Point);
			}
			if (this.Diff != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Diff);
			}
			if (this.State != SignState.Lock)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x001969C0 File Offset: 0x00194BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.StartTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartTime);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.Diff != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Diff);
			}
			if (this.State != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x00196A6C File Offset: 0x00194C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestLevelReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.StartTime != 0)
			{
				this.StartTime = other.StartTime;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.Diff != 0)
			{
				this.Diff = other.Diff;
			}
			if (other.State != SignState.Lock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x00196B0C File Offset: 0x00194D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x00196B18 File Offset: 0x00194D18
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartTime = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsOpen = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Diff = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.State = (SignState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CFB RID: 19707
		private static readonly MessageParser<HarvestLevelReward> _parser = new MessageParser<HarvestLevelReward>(() => new HarvestLevelReward());

		// Token: 0x04004CFC RID: 19708
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CFD RID: 19709
		public const int IdFieldNumber = 1;

		// Token: 0x04004CFE RID: 19710
		private int id_;

		// Token: 0x04004CFF RID: 19711
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04004D00 RID: 19712
		private int startTime_;

		// Token: 0x04004D01 RID: 19713
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04004D02 RID: 19714
		private bool isOpen_;

		// Token: 0x04004D03 RID: 19715
		public const int PointFieldNumber = 4;

		// Token: 0x04004D04 RID: 19716
		private int point_;

		// Token: 0x04004D05 RID: 19717
		public const int DiffFieldNumber = 5;

		// Token: 0x04004D06 RID: 19718
		private int diff_;

		// Token: 0x04004D07 RID: 19719
		public const int StateFieldNumber = 6;

		// Token: 0x04004D08 RID: 19720
		private SignState state_;
	}
}
