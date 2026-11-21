using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C7 RID: 1735
	public sealed class GiantItemAccessPb : IMessage<GiantItemAccessPb>, IMessage, IEquatable<GiantItemAccessPb>, IDeepCloneable<GiantItemAccessPb>, IBufferMessage
	{
		// Token: 0x06009EE5 RID: 40677 RVA: 0x001816F9 File Offset: 0x0017F8F9
		[NullableContext(1)]
		public static GiantItemAccessPb Create()
		{
			return new GiantItemAccessPb();
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x00181700 File Offset: 0x0017F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantItemAccessPb> Parser
		{
			get
			{
				return GiantItemAccessPb._parser;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x00181707 File Offset: 0x0017F907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06009EE8 RID: 40680 RVA: 0x0018170A File Offset: 0x0017F90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessPb.Descriptor;
			}
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x00181711 File Offset: 0x0017F911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb()
		{
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x00181724 File Offset: 0x0017F924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb(GiantItemAccessPb other) : this()
		{
			this.accessId_ = other.accessId_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this.accessStatus_ = other.accessStatus_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x0018177D File Offset: 0x0017F97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb Clone()
		{
			return new GiantItemAccessPb(this);
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x00181785 File Offset: 0x0017F985
		// (set) Token: 0x06009EED RID: 40685 RVA: 0x0018178D File Offset: 0x0017F98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccessId
		{
			get
			{
				return this.accessId_;
			}
			set
			{
				this.accessId_ = value;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x00181796 File Offset: 0x0017F996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06009EEF RID: 40687 RVA: 0x0018179E File Offset: 0x0017F99E
		// (set) Token: 0x06009EF0 RID: 40688 RVA: 0x001817A6 File Offset: 0x0017F9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessStatus AccessStatus
		{
			get
			{
				return this.accessStatus_;
			}
			set
			{
				this.accessStatus_ = value;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x001817AF File Offset: 0x0017F9AF
		// (set) Token: 0x06009EF2 RID: 40690 RVA: 0x001817B7 File Offset: 0x0017F9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x001817C0 File Offset: 0x0017F9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessPb);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x001817D0 File Offset: 0x0017F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessPb other)
		{
			return other != null && (other == this || (this.AccessId == other.AccessId && this.ItemInfos.Equals(other.ItemInfos) && this.AccessStatus == other.AccessStatus && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x00181840 File Offset: 0x0017FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AccessId != 0)
			{
				num ^= this.AccessId.GetHashCode();
			}
			num ^= this.ItemInfos.GetHashCode();
			if (this.AccessStatus != GiantItemAccessStatus.AccessLock)
			{
				num ^= this.AccessStatus.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x001818C5 File Offset: 0x0017FAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x001818D2 File Offset: 0x0017FAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x001818DC File Offset: 0x0017FADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AccessId);
			}
			this.itemInfos_.WriteTo(ref output, GiantItemAccessPb._map_itemInfos_codec);
			if (this.AccessStatus != GiantItemAccessStatus.AccessLock)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.AccessStatus);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x00181964 File Offset: 0x0017FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AccessId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccessId);
			}
			num += this.itemInfos_.CalculateSize(GiantItemAccessPb._map_itemInfos_codec);
			if (this.AccessStatus != GiantItemAccessStatus.AccessLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AccessStatus);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x001819DC File Offset: 0x0017FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantItemAccessPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AccessId != 0)
			{
				this.AccessId = other.AccessId;
			}
			this.itemInfos_.MergeFrom(other.itemInfos_);
			if (other.AccessStatus != GiantItemAccessStatus.AccessLock)
			{
				this.AccessStatus = other.AccessStatus;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x00181A51 File Offset: 0x0017FC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x00181A5C File Offset: 0x0017FC5C
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.AccessId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, GiantItemAccessPb._map_itemInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.AccessStatus = (GiantItemAccessStatus)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A9B RID: 19099
		private static readonly MessageParser<GiantItemAccessPb> _parser = new MessageParser<GiantItemAccessPb>(() => new GiantItemAccessPb());

		// Token: 0x04004A9C RID: 19100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A9D RID: 19101
		public const int AccessIdFieldNumber = 1;

		// Token: 0x04004A9E RID: 19102
		private int accessId_;

		// Token: 0x04004A9F RID: 19103
		public const int ItemInfosFieldNumber = 2;

		// Token: 0x04004AA0 RID: 19104
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04004AA1 RID: 19105
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();

		// Token: 0x04004AA2 RID: 19106
		public const int AccessStatusFieldNumber = 3;

		// Token: 0x04004AA3 RID: 19107
		private GiantItemAccessStatus accessStatus_;

		// Token: 0x04004AA4 RID: 19108
		public const int IsFinishFieldNumber = 4;

		// Token: 0x04004AA5 RID: 19109
		private bool isFinish_;
	}
}
