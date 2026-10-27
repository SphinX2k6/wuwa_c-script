using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A4 RID: 1956
	[NetMessage(EMessageId.HonamiStorySetFormationNotify)]
	public sealed class HonamiStorySetFormationNotify : IMessage<HonamiStorySetFormationNotify>, IMessage, IEquatable<HonamiStorySetFormationNotify>, IDeepCloneable<HonamiStorySetFormationNotify>, IBufferMessage
	{
		// Token: 0x0600B04F RID: 45135 RVA: 0x001A6E91 File Offset: 0x001A5091
		[NullableContext(1)]
		public static HonamiStorySetFormationNotify Create()
		{
			return new HonamiStorySetFormationNotify();
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600B050 RID: 45136 RVA: 0x001A6E98 File Offset: 0x001A5098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x001A6E9B File Offset: 0x001A509B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySetFormationNotify.Descriptor;
			}
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x001A6EA2 File Offset: 0x001A50A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify()
		{
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x001A6EB8 File Offset: 0x001A50B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify(HonamiStorySetFormationNotify other) : this()
		{
			this.equipRack_ = ((other.equipRack_ != null) ? other.equipRack_.Clone() : null);
			this.honamiStoryRackInfos_ = other.honamiStoryRackInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x001A6F09 File Offset: 0x001A5109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySetFormationNotify Clone()
		{
			return new HonamiStorySetFormationNotify(this);
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x001A6F11 File Offset: 0x001A5111
		// (set) Token: 0x0600B056 RID: 45142 RVA: 0x001A6F19 File Offset: 0x001A5119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfo EquipRack
		{
			get
			{
				return this.equipRack_;
			}
			set
			{
				this.equipRack_ = value;
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600B057 RID: 45143 RVA: 0x001A6F22 File Offset: 0x001A5122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryRackInfo> HonamiStoryRackInfos
		{
			get
			{
				return this.honamiStoryRackInfos_;
			}
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x001A6F2A File Offset: 0x001A512A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySetFormationNotify);
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x001A6F38 File Offset: 0x001A5138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySetFormationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.EquipRack, other.EquipRack) && this.honamiStoryRackInfos_.Equals(other.honamiStoryRackInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x001A6F8C File Offset: 0x001A518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.equipRack_ != null)
			{
				num ^= this.EquipRack.GetHashCode();
			}
			num ^= this.honamiStoryRackInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x001A6FD6 File Offset: 0x001A51D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x001A6FE3 File Offset: 0x001A51E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x001A6FEC File Offset: 0x001A51EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.equipRack_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.EquipRack);
			}
			this.honamiStoryRackInfos_.WriteTo(ref output, HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x001A703C File Offset: 0x001A523C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.equipRack_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EquipRack);
			}
			num += this.honamiStoryRackInfos_.CalculateSize(HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x001A7090 File Offset: 0x001A5290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySetFormationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.equipRack_ != null)
			{
				if (this.equipRack_ == null)
				{
					this.EquipRack = new HonamiStoryBagInfo();
				}
				this.EquipRack.MergeFrom(other.EquipRack);
			}
			this.honamiStoryRackInfos_.Add(other.honamiStoryRackInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x001A70F5 File Offset: 0x001A52F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x001A7100 File Offset: 0x001A5300
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
				if (num != 34U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryRackInfos_.AddEntriesFrom(ref input, HonamiStorySetFormationNotify._repeated_honamiStoryRackInfos_codec);
					}
				}
				else
				{
					if (this.equipRack_ == null)
					{
						this.EquipRack = new HonamiStoryBagInfo();
					}
					input.ReadMessage(this.EquipRack);
				}
			}
		}

		// Token: 0x04004F39 RID: 20281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F3A RID: 20282
		public const int EquipRackFieldNumber = 4;

		// Token: 0x04004F3B RID: 20283
		private HonamiStoryBagInfo equipRack_;

		// Token: 0x04004F3C RID: 20284
		public const int HonamiStoryRackInfosFieldNumber = 12;

		// Token: 0x04004F3D RID: 20285
		private static readonly FieldCodec<HonamiStoryRackInfo> _repeated_honamiStoryRackInfos_codec = FieldCodec.ForMessage<HonamiStoryRackInfo>(98U, HonamiStoryRackInfo.Parser);

		// Token: 0x04004F3E RID: 20286
		private readonly RepeatedField<HonamiStoryRackInfo> honamiStoryRackInfos_ = new RepeatedField<HonamiStoryRackInfo>();
	}
}
