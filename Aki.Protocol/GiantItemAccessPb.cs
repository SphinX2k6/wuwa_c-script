using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DB RID: 1755
	public sealed class GiantItemAccessPb : IMessage<GiantItemAccessPb>, IMessage, IEquatable<GiantItemAccessPb>, IDeepCloneable<GiantItemAccessPb>, IBufferMessage
	{
		// Token: 0x0600A03B RID: 41019 RVA: 0x0018412D File Offset: 0x0018232D
		[NullableContext(1)]
		public static GiantItemAccessPb Create()
		{
			return new GiantItemAccessPb();
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x0600A03C RID: 41020 RVA: 0x00184134 File Offset: 0x00182334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantItemAccessPb> Parser
		{
			get
			{
				return GiantItemAccessPb._parser;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600A03D RID: 41021 RVA: 0x0018413B File Offset: 0x0018233B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x0018413E File Offset: 0x0018233E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessPb.Descriptor;
			}
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x00184145 File Offset: 0x00182345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb()
		{
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x00184158 File Offset: 0x00182358
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

		// Token: 0x0600A041 RID: 41025 RVA: 0x001841B1 File Offset: 0x001823B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb Clone()
		{
			return new GiantItemAccessPb(this);
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x001841B9 File Offset: 0x001823B9
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x001841C1 File Offset: 0x001823C1
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

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x001841CA File Offset: 0x001823CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600A045 RID: 41029 RVA: 0x001841D2 File Offset: 0x001823D2
		// (set) Token: 0x0600A046 RID: 41030 RVA: 0x001841DA File Offset: 0x001823DA
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

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600A047 RID: 41031 RVA: 0x001841E3 File Offset: 0x001823E3
		// (set) Token: 0x0600A048 RID: 41032 RVA: 0x001841EB File Offset: 0x001823EB
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

		// Token: 0x0600A049 RID: 41033 RVA: 0x001841F4 File Offset: 0x001823F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessPb);
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x00184204 File Offset: 0x00182404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessPb other)
		{
			return other != null && (other == this || (this.AccessId == other.AccessId && this.ItemInfos.Equals(other.ItemInfos) && this.AccessStatus == other.AccessStatus && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x00184274 File Offset: 0x00182474
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

		// Token: 0x0600A04C RID: 41036 RVA: 0x001842F9 File Offset: 0x001824F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x00184306 File Offset: 0x00182506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x00184310 File Offset: 0x00182510
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

		// Token: 0x0600A04F RID: 41039 RVA: 0x00184398 File Offset: 0x00182598
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

		// Token: 0x0600A050 RID: 41040 RVA: 0x00184410 File Offset: 0x00182610
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

		// Token: 0x0600A051 RID: 41041 RVA: 0x00184485 File Offset: 0x00182685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x00184490 File Offset: 0x00182690
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

		// Token: 0x04004AA2 RID: 19106
		private static readonly MessageParser<GiantItemAccessPb> _parser = new MessageParser<GiantItemAccessPb>(() => new GiantItemAccessPb());

		// Token: 0x04004AA3 RID: 19107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA4 RID: 19108
		public const int AccessIdFieldNumber = 1;

		// Token: 0x04004AA5 RID: 19109
		private int accessId_;

		// Token: 0x04004AA6 RID: 19110
		public const int ItemInfosFieldNumber = 2;

		// Token: 0x04004AA7 RID: 19111
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04004AA8 RID: 19112
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();

		// Token: 0x04004AA9 RID: 19113
		public const int AccessStatusFieldNumber = 3;

		// Token: 0x04004AAA RID: 19114
		private GiantItemAccessStatus accessStatus_;

		// Token: 0x04004AAB RID: 19115
		public const int IsFinishFieldNumber = 4;

		// Token: 0x04004AAC RID: 19116
		private bool isFinish_;
	}
}
