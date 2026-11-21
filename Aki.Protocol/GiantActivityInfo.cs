using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C1 RID: 1729
	public sealed class GiantActivityInfo : IMessage<GiantActivityInfo>, IMessage, IEquatable<GiantActivityInfo>, IDeepCloneable<GiantActivityInfo>, IBufferMessage
	{
		// Token: 0x06009E66 RID: 40550 RVA: 0x001804C1 File Offset: 0x0017E6C1
		[NullableContext(1)]
		public static GiantActivityInfo Create()
		{
			return new GiantActivityInfo();
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06009E67 RID: 40551 RVA: 0x001804C8 File Offset: 0x0017E6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06009E68 RID: 40552 RVA: 0x001804CB File Offset: 0x0017E6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantActivityInfo.Descriptor;
			}
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x001804D2 File Offset: 0x0017E6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo()
		{
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x001804F0 File Offset: 0x0017E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo(GiantActivityInfo other) : this()
		{
			this.totalStableValue_ = other.totalStableValue_;
			this.gotRewardIds_ = other.gotRewardIds_.Clone();
			this.activeIds_ = other.activeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x00180542 File Offset: 0x0017E742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo Clone()
		{
			return new GiantActivityInfo(this);
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06009E6C RID: 40556 RVA: 0x0018054A File Offset: 0x0017E74A
		// (set) Token: 0x06009E6D RID: 40557 RVA: 0x00180552 File Offset: 0x0017E752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalStableValue
		{
			get
			{
				return this.totalStableValue_;
			}
			set
			{
				this.totalStableValue_ = value;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06009E6E RID: 40558 RVA: 0x0018055B File Offset: 0x0017E75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GotRewardIds
		{
			get
			{
				return this.gotRewardIds_;
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x00180563 File Offset: 0x0017E763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveIds
		{
			get
			{
				return this.activeIds_;
			}
		}

		// Token: 0x06009E70 RID: 40560 RVA: 0x0018056B File Offset: 0x0017E76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantActivityInfo);
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x0018057C File Offset: 0x0017E77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantActivityInfo other)
		{
			return other != null && (other == this || (this.TotalStableValue == other.TotalStableValue && this.gotRewardIds_.Equals(other.gotRewardIds_) && this.activeIds_.Equals(other.activeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x001805E0 File Offset: 0x0017E7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalStableValue != 0)
			{
				num ^= this.TotalStableValue.GetHashCode();
			}
			num ^= this.gotRewardIds_.GetHashCode();
			num ^= this.activeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x0018063B File Offset: 0x0017E83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x00180648 File Offset: 0x0017E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x00180654 File Offset: 0x0017E854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalStableValue != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TotalStableValue);
			}
			this.gotRewardIds_.WriteTo(ref output, GiantActivityInfo._repeated_gotRewardIds_codec);
			this.activeIds_.WriteTo(ref output, GiantActivityInfo._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x001806B4 File Offset: 0x0017E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalStableValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalStableValue);
			}
			num += this.gotRewardIds_.CalculateSize(GiantActivityInfo._repeated_gotRewardIds_codec);
			num += this.activeIds_.CalculateSize(GiantActivityInfo._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x00180718 File Offset: 0x0017E918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalStableValue != 0)
			{
				this.TotalStableValue = other.TotalStableValue;
			}
			this.gotRewardIds_.Add(other.gotRewardIds_);
			this.activeIds_.Add(other.activeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00180776 File Offset: 0x0017E976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x00180780 File Offset: 0x0017E980
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
						this.TotalStableValue = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.activeIds_.AddEntriesFrom(ref input, GiantActivityInfo._repeated_activeIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.gotRewardIds_.AddEntriesFrom(ref input, GiantActivityInfo._repeated_gotRewardIds_codec);
			}
		}

		// Token: 0x04004A72 RID: 19058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A73 RID: 19059
		public const int TotalStableValueFieldNumber = 1;

		// Token: 0x04004A74 RID: 19060
		private int totalStableValue_;

		// Token: 0x04004A75 RID: 19061
		public const int GotRewardIdsFieldNumber = 2;

		// Token: 0x04004A76 RID: 19062
		private static readonly FieldCodec<int> _repeated_gotRewardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004A77 RID: 19063
		private readonly RepeatedField<int> gotRewardIds_ = new RepeatedField<int>();

		// Token: 0x04004A78 RID: 19064
		public const int ActiveIdsFieldNumber = 3;

		// Token: 0x04004A79 RID: 19065
		private static readonly FieldCodec<int> _repeated_activeIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004A7A RID: 19066
		private readonly RepeatedField<int> activeIds_ = new RepeatedField<int>();
	}
}
