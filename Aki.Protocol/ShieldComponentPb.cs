using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001225 RID: 4645
	public sealed class ShieldComponentPb : IMessage<ShieldComponentPb>, IMessage, IEquatable<ShieldComponentPb>, IDeepCloneable<ShieldComponentPb>, IBufferMessage
	{
		// Token: 0x06018CE0 RID: 101600 RVA: 0x0039D823 File Offset: 0x0039BA23
		[NullableContext(1)]
		public static ShieldComponentPb Create()
		{
			return new ShieldComponentPb();
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x06018CE1 RID: 101601 RVA: 0x0039D82A File Offset: 0x0039BA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x06018CE2 RID: 101602 RVA: 0x0039D82D File Offset: 0x0039BA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldComponentPb.Descriptor;
			}
		}

		// Token: 0x06018CE3 RID: 101603 RVA: 0x0039D834 File Offset: 0x0039BA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb()
		{
		}

		// Token: 0x06018CE4 RID: 101604 RVA: 0x0039D847 File Offset: 0x0039BA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb(ShieldComponentPb other) : this()
		{
			this.shieldInfoPbList_ = other.shieldInfoPbList_.Clone();
			this.shieldValueTotal_ = other.shieldValueTotal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CE5 RID: 101605 RVA: 0x0039D87D File Offset: 0x0039BA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb Clone()
		{
			return new ShieldComponentPb(this);
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x06018CE6 RID: 101606 RVA: 0x0039D885 File Offset: 0x0039BA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShieldInfoPb> ShieldInfoPbList
		{
			get
			{
				return this.shieldInfoPbList_;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x06018CE7 RID: 101607 RVA: 0x0039D88D File Offset: 0x0039BA8D
		// (set) Token: 0x06018CE8 RID: 101608 RVA: 0x0039D895 File Offset: 0x0039BA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldValueTotal
		{
			get
			{
				return this.shieldValueTotal_;
			}
			set
			{
				this.shieldValueTotal_ = value;
			}
		}

		// Token: 0x06018CE9 RID: 101609 RVA: 0x0039D89E File Offset: 0x0039BA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldComponentPb);
		}

		// Token: 0x06018CEA RID: 101610 RVA: 0x0039D8AC File Offset: 0x0039BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldComponentPb other)
		{
			return other != null && (other == this || (this.shieldInfoPbList_.Equals(other.shieldInfoPbList_) && this.ShieldValueTotal == other.ShieldValueTotal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CEB RID: 101611 RVA: 0x0039D8FC File Offset: 0x0039BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shieldInfoPbList_.GetHashCode();
			if (this.ShieldValueTotal != 0)
			{
				num ^= this.ShieldValueTotal.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CEC RID: 101612 RVA: 0x0039D949 File Offset: 0x0039BB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CED RID: 101613 RVA: 0x0039D956 File Offset: 0x0039BB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CEE RID: 101614 RVA: 0x0039D960 File Offset: 0x0039BB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shieldInfoPbList_.WriteTo(ref output, ShieldComponentPb._repeated_shieldInfoPbList_codec);
			if (this.ShieldValueTotal != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ShieldValueTotal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CEF RID: 101615 RVA: 0x0039D9B0 File Offset: 0x0039BBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shieldInfoPbList_.CalculateSize(ShieldComponentPb._repeated_shieldInfoPbList_codec);
			if (this.ShieldValueTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldValueTotal);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CF0 RID: 101616 RVA: 0x0039DA04 File Offset: 0x0039BC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.shieldInfoPbList_.Add(other.shieldInfoPbList_);
			if (other.ShieldValueTotal != 0)
			{
				this.ShieldValueTotal = other.ShieldValueTotal;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CF1 RID: 101617 RVA: 0x0039DA51 File Offset: 0x0039BC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CF2 RID: 101618 RVA: 0x0039DA5C File Offset: 0x0039BC5C
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShieldValueTotal = input.ReadInt32();
					}
				}
				else
				{
					this.shieldInfoPbList_.AddEntriesFrom(ref input, ShieldComponentPb._repeated_shieldInfoPbList_codec);
				}
			}
		}

		// Token: 0x0400932A RID: 37674
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400932B RID: 37675
		public const int ShieldInfoPbListFieldNumber = 1;

		// Token: 0x0400932C RID: 37676
		private static readonly FieldCodec<ShieldInfoPb> _repeated_shieldInfoPbList_codec = FieldCodec.ForMessage<ShieldInfoPb>(10U, ShieldInfoPb.Parser);

		// Token: 0x0400932D RID: 37677
		private readonly RepeatedField<ShieldInfoPb> shieldInfoPbList_ = new RepeatedField<ShieldInfoPb>();

		// Token: 0x0400932E RID: 37678
		public const int ShieldValueTotalFieldNumber = 2;

		// Token: 0x0400932F RID: 37679
		private int shieldValueTotal_;
	}
}
