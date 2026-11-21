using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D8 RID: 984
	public sealed class DollGrabMachineComponentPb : IMessage<DollGrabMachineComponentPb>, IMessage, IEquatable<DollGrabMachineComponentPb>, IDeepCloneable<DollGrabMachineComponentPb>, IBufferMessage
	{
		// Token: 0x06006009 RID: 24585 RVA: 0x000E8503 File Offset: 0x000E6703
		[NullableContext(1)]
		public static DollGrabMachineComponentPb Create()
		{
			return new DollGrabMachineComponentPb();
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x000E850A File Offset: 0x000E670A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600600B RID: 24587 RVA: 0x000E850D File Offset: 0x000E670D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabMachineComponentPb.Descriptor;
			}
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x000E8514 File Offset: 0x000E6714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb()
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x000E8528 File Offset: 0x000E6728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb(DollGrabMachineComponentPb other) : this()
		{
			this.canCapturedItems_ = other.canCapturedItems_.Clone();
			this.highScore_ = other.highScore_;
			this.accumulatedScore_ = other.accumulatedScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x000E8575 File Offset: 0x000E6775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb Clone()
		{
			return new DollGrabMachineComponentPb(this);
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600600F RID: 24591 RVA: 0x000E857D File Offset: 0x000E677D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanCapturedItems
		{
			get
			{
				return this.canCapturedItems_;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x000E8585 File Offset: 0x000E6785
		// (set) Token: 0x06006011 RID: 24593 RVA: 0x000E858D File Offset: 0x000E678D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighScore
		{
			get
			{
				return this.highScore_;
			}
			set
			{
				this.highScore_ = value;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x000E8596 File Offset: 0x000E6796
		// (set) Token: 0x06006013 RID: 24595 RVA: 0x000E859E File Offset: 0x000E679E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccumulatedScore
		{
			get
			{
				return this.accumulatedScore_;
			}
			set
			{
				this.accumulatedScore_ = value;
			}
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x000E85A7 File Offset: 0x000E67A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabMachineComponentPb);
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x000E85B8 File Offset: 0x000E67B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabMachineComponentPb other)
		{
			return other != null && (other == this || (this.canCapturedItems_.Equals(other.canCapturedItems_) && this.HighScore == other.HighScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x000E8618 File Offset: 0x000E6818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.canCapturedItems_.GetHashCode();
			if (this.HighScore != 0)
			{
				num ^= this.HighScore.GetHashCode();
			}
			if (this.AccumulatedScore != 0)
			{
				num ^= this.AccumulatedScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x000E867E File Offset: 0x000E687E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x000E868B File Offset: 0x000E688B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x000E8694 File Offset: 0x000E6894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.canCapturedItems_.WriteTo(ref output, DollGrabMachineComponentPb._repeated_canCapturedItems_codec);
			if (this.HighScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HighScore);
			}
			if (this.AccumulatedScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x000E8700 File Offset: 0x000E6900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.canCapturedItems_.CalculateSize(DollGrabMachineComponentPb._repeated_canCapturedItems_codec);
			if (this.HighScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighScore);
			}
			if (this.AccumulatedScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccumulatedScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x000E876C File Offset: 0x000E696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabMachineComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.canCapturedItems_.Add(other.canCapturedItems_);
			if (other.HighScore != 0)
			{
				this.HighScore = other.HighScore;
			}
			if (other.AccumulatedScore != 0)
			{
				this.AccumulatedScore = other.AccumulatedScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x000E87CD File Offset: 0x000E69CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x000E87D8 File Offset: 0x000E69D8
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.canCapturedItems_.AddEntriesFrom(ref input, DollGrabMachineComponentPb._repeated_canCapturedItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.AccumulatedScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003793 RID: 14227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003794 RID: 14228
		public const int CanCapturedItemsFieldNumber = 1;

		// Token: 0x04003795 RID: 14229
		private static readonly FieldCodec<int> _repeated_canCapturedItems_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003796 RID: 14230
		private readonly RepeatedField<int> canCapturedItems_ = new RepeatedField<int>();

		// Token: 0x04003797 RID: 14231
		public const int HighScoreFieldNumber = 2;

		// Token: 0x04003798 RID: 14232
		private int highScore_;

		// Token: 0x04003799 RID: 14233
		public const int AccumulatedScoreFieldNumber = 3;

		// Token: 0x0400379A RID: 14234
		private int accumulatedScore_;
	}
}
