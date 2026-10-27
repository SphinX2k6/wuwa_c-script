using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B7 RID: 1463
	public sealed class FloroRanchPlayBuff : IMessage<FloroRanchPlayBuff>, IMessage, IEquatable<FloroRanchPlayBuff>, IDeepCloneable<FloroRanchPlayBuff>, IBufferMessage
	{
		// Token: 0x0600871D RID: 34589 RVA: 0x00144A09 File Offset: 0x00142C09
		[NullableContext(1)]
		public static FloroRanchPlayBuff Create()
		{
			return new FloroRanchPlayBuff();
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600871E RID: 34590 RVA: 0x00144A10 File Offset: 0x00142C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayBuff> Parser
		{
			get
			{
				return FloroRanchPlayBuff._parser;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600871F RID: 34591 RVA: 0x00144A17 File Offset: 0x00142C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06008720 RID: 34592 RVA: 0x00144A1A File Offset: 0x00142C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayBuff.Descriptor;
			}
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x00144A21 File Offset: 0x00142C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff()
		{
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00144A2C File Offset: 0x00142C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff(FloroRanchPlayBuff other) : this()
		{
			this.playIncId_ = other.playIncId_;
			this.id_ = other.id_;
			this.point_ = other.point_;
			this.day_ = other.day_;
			this.plies_ = other.plies_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00144A8C File Offset: 0x00142C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayBuff Clone()
		{
			return new FloroRanchPlayBuff(this);
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06008724 RID: 34596 RVA: 0x00144A94 File Offset: 0x00142C94
		// (set) Token: 0x06008725 RID: 34597 RVA: 0x00144A9C File Offset: 0x00142C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayIncId
		{
			get
			{
				return this.playIncId_;
			}
			set
			{
				this.playIncId_ = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06008726 RID: 34598 RVA: 0x00144AA5 File Offset: 0x00142CA5
		// (set) Token: 0x06008727 RID: 34599 RVA: 0x00144AAD File Offset: 0x00142CAD
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

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06008728 RID: 34600 RVA: 0x00144AB6 File Offset: 0x00142CB6
		// (set) Token: 0x06008729 RID: 34601 RVA: 0x00144ABE File Offset: 0x00142CBE
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

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x00144AC7 File Offset: 0x00142CC7
		// (set) Token: 0x0600872B RID: 34603 RVA: 0x00144ACF File Offset: 0x00142CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Day
		{
			get
			{
				return this.day_;
			}
			set
			{
				this.day_ = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x0600872C RID: 34604 RVA: 0x00144AD8 File Offset: 0x00142CD8
		// (set) Token: 0x0600872D RID: 34605 RVA: 0x00144AE0 File Offset: 0x00142CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Plies
		{
			get
			{
				return this.plies_;
			}
			set
			{
				this.plies_ = value;
			}
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00144AE9 File Offset: 0x00142CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayBuff);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x00144AF8 File Offset: 0x00142CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayBuff other)
		{
			return other != null && (other == this || (this.PlayIncId == other.PlayIncId && this.Id == other.Id && this.Point == other.Point && this.Day == other.Day && this.Plies == other.Plies && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x00144B74 File Offset: 0x00142D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayIncId != 0)
			{
				num ^= this.PlayIncId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this.Plies != 0)
			{
				num ^= this.Plies.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x00144C17 File Offset: 0x00142E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00144C24 File Offset: 0x00142E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00144C30 File Offset: 0x00142E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayIncId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Point);
			}
			if (this.Day != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Day);
			}
			if (this.Plies != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Plies);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00144CDC File Offset: 0x00142EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayIncId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this.Plies != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Plies);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00144D7C File Offset: 0x00142F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayIncId != 0)
			{
				this.PlayIncId = other.PlayIncId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			if (other.Plies != 0)
			{
				this.Plies = other.Plies;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00144E08 File Offset: 0x00143008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x00144E14 File Offset: 0x00143014
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
						this.PlayIncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Day = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Plies = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004284 RID: 17028
		private static readonly MessageParser<FloroRanchPlayBuff> _parser = new MessageParser<FloroRanchPlayBuff>(() => new FloroRanchPlayBuff());

		// Token: 0x04004285 RID: 17029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004286 RID: 17030
		public const int PlayIncIdFieldNumber = 1;

		// Token: 0x04004287 RID: 17031
		private int playIncId_;

		// Token: 0x04004288 RID: 17032
		public const int IdFieldNumber = 2;

		// Token: 0x04004289 RID: 17033
		private int id_;

		// Token: 0x0400428A RID: 17034
		public const int PointFieldNumber = 3;

		// Token: 0x0400428B RID: 17035
		private int point_;

		// Token: 0x0400428C RID: 17036
		public const int DayFieldNumber = 4;

		// Token: 0x0400428D RID: 17037
		private int day_;

		// Token: 0x0400428E RID: 17038
		public const int PliesFieldNumber = 5;

		// Token: 0x0400428F RID: 17039
		private int plies_;
	}
}
