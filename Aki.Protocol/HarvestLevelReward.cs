using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000737 RID: 1847
	public sealed class HarvestLevelReward : IMessage<HarvestLevelReward>, IMessage, IEquatable<HarvestLevelReward>, IDeepCloneable<HarvestLevelReward>, IBufferMessage
	{
		// Token: 0x0600A7B0 RID: 42928 RVA: 0x00193C5E File Offset: 0x00191E5E
		[NullableContext(1)]
		public static HarvestLevelReward Create()
		{
			return new HarvestLevelReward();
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x00193C65 File Offset: 0x00191E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HarvestLevelReward> Parser
		{
			get
			{
				return HarvestLevelReward._parser;
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x0600A7B2 RID: 42930 RVA: 0x00193C6C File Offset: 0x00191E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x00193C6F File Offset: 0x00191E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestLevelReward.Descriptor;
			}
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x00193C76 File Offset: 0x00191E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestLevelReward()
		{
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x00193C80 File Offset: 0x00191E80
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

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x00193CEC File Offset: 0x00191EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestLevelReward Clone()
		{
			return new HarvestLevelReward(this);
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x0600A7B7 RID: 42935 RVA: 0x00193CF4 File Offset: 0x00191EF4
		// (set) Token: 0x0600A7B8 RID: 42936 RVA: 0x00193CFC File Offset: 0x00191EFC
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

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x0600A7B9 RID: 42937 RVA: 0x00193D05 File Offset: 0x00191F05
		// (set) Token: 0x0600A7BA RID: 42938 RVA: 0x00193D0D File Offset: 0x00191F0D
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

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x00193D16 File Offset: 0x00191F16
		// (set) Token: 0x0600A7BC RID: 42940 RVA: 0x00193D1E File Offset: 0x00191F1E
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

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x00193D27 File Offset: 0x00191F27
		// (set) Token: 0x0600A7BE RID: 42942 RVA: 0x00193D2F File Offset: 0x00191F2F
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

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x00193D38 File Offset: 0x00191F38
		// (set) Token: 0x0600A7C0 RID: 42944 RVA: 0x00193D40 File Offset: 0x00191F40
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

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x0600A7C1 RID: 42945 RVA: 0x00193D49 File Offset: 0x00191F49
		// (set) Token: 0x0600A7C2 RID: 42946 RVA: 0x00193D51 File Offset: 0x00191F51
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

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x00193D5A File Offset: 0x00191F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestLevelReward);
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x00193D68 File Offset: 0x00191F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestLevelReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Point == other.Point && this.Diff == other.Diff && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x00193DF4 File Offset: 0x00191FF4
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

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x00193EB6 File Offset: 0x001920B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x00193EC3 File Offset: 0x001920C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x00193ECC File Offset: 0x001920CC
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

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x00193F94 File Offset: 0x00192194
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

		// Token: 0x0600A7CA RID: 42954 RVA: 0x00194040 File Offset: 0x00192240
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

		// Token: 0x0600A7CB RID: 42955 RVA: 0x001940E0 File Offset: 0x001922E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x001940EC File Offset: 0x001922EC
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

		// Token: 0x04004CF4 RID: 19700
		private static readonly MessageParser<HarvestLevelReward> _parser = new MessageParser<HarvestLevelReward>(() => new HarvestLevelReward());

		// Token: 0x04004CF5 RID: 19701
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CF6 RID: 19702
		public const int IdFieldNumber = 1;

		// Token: 0x04004CF7 RID: 19703
		private int id_;

		// Token: 0x04004CF8 RID: 19704
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04004CF9 RID: 19705
		private int startTime_;

		// Token: 0x04004CFA RID: 19706
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04004CFB RID: 19707
		private bool isOpen_;

		// Token: 0x04004CFC RID: 19708
		public const int PointFieldNumber = 4;

		// Token: 0x04004CFD RID: 19709
		private int point_;

		// Token: 0x04004CFE RID: 19710
		public const int DiffFieldNumber = 5;

		// Token: 0x04004CFF RID: 19711
		private int diff_;

		// Token: 0x04004D00 RID: 19712
		public const int StateFieldNumber = 6;

		// Token: 0x04004D01 RID: 19713
		private SignState state_;
	}
}
