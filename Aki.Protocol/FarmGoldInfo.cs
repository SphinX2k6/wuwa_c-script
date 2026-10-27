using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051D RID: 1309
	public sealed class FarmGoldInfo : IMessage<FarmGoldInfo>, IMessage, IEquatable<FarmGoldInfo>, IDeepCloneable<FarmGoldInfo>, IBufferMessage
	{
		// Token: 0x06007AED RID: 31469 RVA: 0x0012A510 File Offset: 0x00128710
		[NullableContext(1)]
		public static FarmGoldInfo Create()
		{
			return new FarmGoldInfo();
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x0012A517 File Offset: 0x00128717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x0012A51A File Offset: 0x0012871A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldInfo.Descriptor;
			}
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x0012A521 File Offset: 0x00128721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo()
		{
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x0012A53F File Offset: 0x0012873F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo(FarmGoldInfo other) : this()
		{
			this.pointsRewardGet_ = other.pointsRewardGet_.Clone();
			this.levelPlayTasks_ = other.levelPlayTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x0012A57A File Offset: 0x0012877A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo Clone()
		{
			return new FarmGoldInfo(this);
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x0012A582 File Offset: 0x00128782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PointsRewardGet
		{
			get
			{
				return this.pointsRewardGet_;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x0012A58A File Offset: 0x0012878A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FarmGoldLevelPlayInfo> LevelPlayTasks
		{
			get
			{
				return this.levelPlayTasks_;
			}
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x0012A592 File Offset: 0x00128792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldInfo);
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x0012A5A0 File Offset: 0x001287A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldInfo other)
		{
			return other != null && (other == this || (this.pointsRewardGet_.Equals(other.pointsRewardGet_) && this.levelPlayTasks_.Equals(other.levelPlayTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x0012A5F4 File Offset: 0x001287F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pointsRewardGet_.GetHashCode();
			num ^= this.levelPlayTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x0012A636 File Offset: 0x00128836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x0012A643 File Offset: 0x00128843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x0012A64C File Offset: 0x0012884C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pointsRewardGet_.WriteTo(ref output, FarmGoldInfo._repeated_pointsRewardGet_codec);
			this.levelPlayTasks_.WriteTo(ref output, FarmGoldInfo._repeated_levelPlayTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x0012A684 File Offset: 0x00128884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pointsRewardGet_.CalculateSize(FarmGoldInfo._repeated_pointsRewardGet_codec);
			num += this.levelPlayTasks_.CalculateSize(FarmGoldInfo._repeated_levelPlayTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x0012A6D0 File Offset: 0x001288D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.pointsRewardGet_.Add(other.pointsRewardGet_);
			this.levelPlayTasks_.Add(other.levelPlayTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x0012A70F File Offset: 0x0012890F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x0012A718 File Offset: 0x00128918
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
				if (num != 8U && num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.levelPlayTasks_.AddEntriesFrom(ref input, FarmGoldInfo._repeated_levelPlayTasks_codec);
					}
				}
				else
				{
					this.pointsRewardGet_.AddEntriesFrom(ref input, FarmGoldInfo._repeated_pointsRewardGet_codec);
				}
			}
		}

		// Token: 0x04003F06 RID: 16134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F07 RID: 16135
		public const int PointsRewardGetFieldNumber = 1;

		// Token: 0x04003F08 RID: 16136
		private static readonly FieldCodec<int> _repeated_pointsRewardGet_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003F09 RID: 16137
		private readonly RepeatedField<int> pointsRewardGet_ = new RepeatedField<int>();

		// Token: 0x04003F0A RID: 16138
		public const int LevelPlayTasksFieldNumber = 2;

		// Token: 0x04003F0B RID: 16139
		private static readonly FieldCodec<FarmGoldLevelPlayInfo> _repeated_levelPlayTasks_codec = FieldCodec.ForMessage<FarmGoldLevelPlayInfo>(18U, FarmGoldLevelPlayInfo.Parser);

		// Token: 0x04003F0C RID: 16140
		private readonly RepeatedField<FarmGoldLevelPlayInfo> levelPlayTasks_ = new RepeatedField<FarmGoldLevelPlayInfo>();
	}
}
