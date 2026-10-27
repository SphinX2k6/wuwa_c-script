using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EA RID: 4586
	public sealed class ShieldComponentPb : IMessage<ShieldComponentPb>, IMessage, IEquatable<ShieldComponentPb>, IDeepCloneable<ShieldComponentPb>, IBufferMessage
	{
		// Token: 0x0601871C RID: 100124 RVA: 0x0038DCBC File Offset: 0x0038BEBC
		[NullableContext(1)]
		public static ShieldComponentPb Create()
		{
			return new ShieldComponentPb();
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x0601871D RID: 100125 RVA: 0x0038DCC3 File Offset: 0x0038BEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x0601871E RID: 100126 RVA: 0x0038DCC6 File Offset: 0x0038BEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldComponentPb.Descriptor;
			}
		}

		// Token: 0x0601871F RID: 100127 RVA: 0x0038DCCD File Offset: 0x0038BECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb()
		{
		}

		// Token: 0x06018720 RID: 100128 RVA: 0x0038DCE0 File Offset: 0x0038BEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb(ShieldComponentPb other) : this()
		{
			this.shieldInfoPbList_ = other.shieldInfoPbList_.Clone();
			this.shieldValueTotal_ = other.shieldValueTotal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018721 RID: 100129 RVA: 0x0038DD16 File Offset: 0x0038BF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb Clone()
		{
			return new ShieldComponentPb(this);
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x06018722 RID: 100130 RVA: 0x0038DD1E File Offset: 0x0038BF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShieldInfoPb> ShieldInfoPbList
		{
			get
			{
				return this.shieldInfoPbList_;
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x06018723 RID: 100131 RVA: 0x0038DD26 File Offset: 0x0038BF26
		// (set) Token: 0x06018724 RID: 100132 RVA: 0x0038DD2E File Offset: 0x0038BF2E
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

		// Token: 0x06018725 RID: 100133 RVA: 0x0038DD37 File Offset: 0x0038BF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldComponentPb);
		}

		// Token: 0x06018726 RID: 100134 RVA: 0x0038DD48 File Offset: 0x0038BF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldComponentPb other)
		{
			return other != null && (other == this || (this.shieldInfoPbList_.Equals(other.shieldInfoPbList_) && this.ShieldValueTotal == other.ShieldValueTotal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018727 RID: 100135 RVA: 0x0038DD98 File Offset: 0x0038BF98
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

		// Token: 0x06018728 RID: 100136 RVA: 0x0038DDE5 File Offset: 0x0038BFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018729 RID: 100137 RVA: 0x0038DDF2 File Offset: 0x0038BFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601872A RID: 100138 RVA: 0x0038DDFC File Offset: 0x0038BFFC
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

		// Token: 0x0601872B RID: 100139 RVA: 0x0038DE4C File Offset: 0x0038C04C
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

		// Token: 0x0601872C RID: 100140 RVA: 0x0038DEA0 File Offset: 0x0038C0A0
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

		// Token: 0x0601872D RID: 100141 RVA: 0x0038DEED File Offset: 0x0038C0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601872E RID: 100142 RVA: 0x0038DEF8 File Offset: 0x0038C0F8
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

		// Token: 0x04009080 RID: 36992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009081 RID: 36993
		public const int ShieldInfoPbListFieldNumber = 1;

		// Token: 0x04009082 RID: 36994
		private static readonly FieldCodec<ShieldInfoPb> _repeated_shieldInfoPbList_codec = FieldCodec.ForMessage<ShieldInfoPb>(10U, ShieldInfoPb.Parser);

		// Token: 0x04009083 RID: 36995
		private readonly RepeatedField<ShieldInfoPb> shieldInfoPbList_ = new RepeatedField<ShieldInfoPb>();

		// Token: 0x04009084 RID: 36996
		public const int ShieldValueTotalFieldNumber = 2;

		// Token: 0x04009085 RID: 36997
		private int shieldValueTotal_;
	}
}
