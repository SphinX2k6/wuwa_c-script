using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EF RID: 1007
	public sealed class DollGrabMachineComponentPb : IMessage<DollGrabMachineComponentPb>, IMessage, IEquatable<DollGrabMachineComponentPb>, IDeepCloneable<DollGrabMachineComponentPb>, IBufferMessage
	{
		// Token: 0x06006199 RID: 24985 RVA: 0x000EB683 File Offset: 0x000E9883
		[NullableContext(1)]
		public static DollGrabMachineComponentPb Create()
		{
			return new DollGrabMachineComponentPb();
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x000EB68A File Offset: 0x000E988A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600619B RID: 24987 RVA: 0x000EB68D File Offset: 0x000E988D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabMachineComponentPb.Descriptor;
			}
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x000EB694 File Offset: 0x000E9894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb()
		{
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x000EB6A8 File Offset: 0x000E98A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb(DollGrabMachineComponentPb other) : this()
		{
			this.canCapturedItems_ = other.canCapturedItems_.Clone();
			this.highScore_ = other.highScore_;
			this.accumulatedScore_ = other.accumulatedScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x000EB6F5 File Offset: 0x000E98F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb Clone()
		{
			return new DollGrabMachineComponentPb(this);
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600619F RID: 24991 RVA: 0x000EB6FD File Offset: 0x000E98FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanCapturedItems
		{
			get
			{
				return this.canCapturedItems_;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x000EB705 File Offset: 0x000E9905
		// (set) Token: 0x060061A1 RID: 24993 RVA: 0x000EB70D File Offset: 0x000E990D
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

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060061A2 RID: 24994 RVA: 0x000EB716 File Offset: 0x000E9916
		// (set) Token: 0x060061A3 RID: 24995 RVA: 0x000EB71E File Offset: 0x000E991E
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

		// Token: 0x060061A4 RID: 24996 RVA: 0x000EB727 File Offset: 0x000E9927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabMachineComponentPb);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x000EB738 File Offset: 0x000E9938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabMachineComponentPb other)
		{
			return other != null && (other == this || (this.canCapturedItems_.Equals(other.canCapturedItems_) && this.HighScore == other.HighScore && this.AccumulatedScore == other.AccumulatedScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x000EB798 File Offset: 0x000E9998
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

		// Token: 0x060061A7 RID: 24999 RVA: 0x000EB7FE File Offset: 0x000E99FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x000EB80B File Offset: 0x000E9A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x000EB814 File Offset: 0x000E9A14
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

		// Token: 0x060061AA RID: 25002 RVA: 0x000EB880 File Offset: 0x000E9A80
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

		// Token: 0x060061AB RID: 25003 RVA: 0x000EB8EC File Offset: 0x000E9AEC
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

		// Token: 0x060061AC RID: 25004 RVA: 0x000EB94D File Offset: 0x000E9B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x000EB958 File Offset: 0x000E9B58
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

		// Token: 0x040037A6 RID: 14246
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A7 RID: 14247
		public const int CanCapturedItemsFieldNumber = 1;

		// Token: 0x040037A8 RID: 14248
		private static readonly FieldCodec<int> _repeated_canCapturedItems_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040037A9 RID: 14249
		private readonly RepeatedField<int> canCapturedItems_ = new RepeatedField<int>();

		// Token: 0x040037AA RID: 14250
		public const int HighScoreFieldNumber = 2;

		// Token: 0x040037AB RID: 14251
		private int highScore_;

		// Token: 0x040037AC RID: 14252
		public const int AccumulatedScoreFieldNumber = 3;

		// Token: 0x040037AD RID: 14253
		private int accumulatedScore_;
	}
}
