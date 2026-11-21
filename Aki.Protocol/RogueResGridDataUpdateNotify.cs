using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD5 RID: 4053
	[NetMessage(EMessageId.RogueResGridDataUpdateNotify)]
	public sealed class RogueResGridDataUpdateNotify : IMessage<RogueResGridDataUpdateNotify>, IMessage, IEquatable<RogueResGridDataUpdateNotify>, IDeepCloneable<RogueResGridDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015B1E RID: 88862 RVA: 0x003272C9 File Offset: 0x003254C9
		[NullableContext(1)]
		public static RogueResGridDataUpdateNotify Create()
		{
			return new RogueResGridDataUpdateNotify();
		}

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06015B1F RID: 88863 RVA: 0x003272D0 File Offset: 0x003254D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06015B20 RID: 88864 RVA: 0x003272D3 File Offset: 0x003254D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015B21 RID: 88865 RVA: 0x003272DA File Offset: 0x003254DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify()
		{
		}

		// Token: 0x06015B22 RID: 88866 RVA: 0x003272F0 File Offset: 0x003254F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify(RogueResGridDataUpdateNotify other) : this()
		{
			this.rogueResGridDataDict_ = other.rogueResGridDataDict_.Clone();
			this.reason_ = other.reason_;
			RogueResGridDataUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				if (dataCase == RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex)
				{
					this.PlayerIndex = other.PlayerIndex;
				}
			}
			else
			{
				this.LightBlockByLocation = other.LightBlockByLocation.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B23 RID: 88867 RVA: 0x00327360 File Offset: 0x00325560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify Clone()
		{
			return new RogueResGridDataUpdateNotify(this);
		}

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06015B24 RID: 88868 RVA: 0x00327368 File Offset: 0x00325568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResGridData> RogueResGridDataDict
		{
			get
			{
				return this.rogueResGridDataDict_;
			}
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06015B25 RID: 88869 RVA: 0x00327370 File Offset: 0x00325570
		// (set) Token: 0x06015B26 RID: 88870 RVA: 0x00327378 File Offset: 0x00325578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridDataUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06015B27 RID: 88871 RVA: 0x00327381 File Offset: 0x00325581
		// (set) Token: 0x06015B28 RID: 88872 RVA: 0x00327398 File Offset: 0x00325598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerIndex
		{
			get
			{
				if (!this.HasPlayerIndex)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex;
			}
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06015B29 RID: 88873 RVA: 0x003273AE File Offset: 0x003255AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPlayerIndex
		{
			get
			{
				return this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex;
			}
		}

		// Token: 0x06015B2A RID: 88874 RVA: 0x003273BA File Offset: 0x003255BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPlayerIndex()
		{
			if (this.HasPlayerIndex)
			{
				this.ClearData();
			}
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06015B2B RID: 88875 RVA: 0x003273CA File Offset: 0x003255CA
		// (set) Token: 0x06015B2C RID: 88876 RVA: 0x003273E2 File Offset: 0x003255E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam LightBlockByLocation
		{
			get
			{
				if (this.dataCase_ != RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
				{
					return null;
				}
				return (LightBlockByLocationParam)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGridDataUpdateNotify.DataOneofCase.None : RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation);
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06015B2D RID: 88877 RVA: 0x003273F8 File Offset: 0x003255F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015B2E RID: 88878 RVA: 0x00327400 File Offset: 0x00325600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResGridDataUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015B2F RID: 88879 RVA: 0x00327410 File Offset: 0x00325610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridDataUpdateNotify);
		}

		// Token: 0x06015B30 RID: 88880 RVA: 0x00327420 File Offset: 0x00325620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridDataUpdateNotify other)
		{
			return other != null && (other == this || (this.RogueResGridDataDict.Equals(other.RogueResGridDataDict) && this.Reason == other.Reason && this.PlayerIndex == other.PlayerIndex && object.Equals(this.LightBlockByLocation, other.LightBlockByLocation) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B31 RID: 88881 RVA: 0x003274A4 File Offset: 0x003256A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RogueResGridDataDict.GetHashCode();
			if (this.Reason != GridDataUpdateReason.GridUpdate)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.HasPlayerIndex)
			{
				num ^= this.PlayerIndex.GetHashCode();
			}
			if (this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				num ^= this.LightBlockByLocation.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B32 RID: 88882 RVA: 0x00327530 File Offset: 0x00325730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B33 RID: 88883 RVA: 0x0032753D File Offset: 0x0032573D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B34 RID: 88884 RVA: 0x00327548 File Offset: 0x00325748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResGridDataDict_.WriteTo(ref output, RogueResGridDataUpdateNotify._map_rogueResGridDataDict_codec);
			if (this.Reason != GridDataUpdateReason.GridUpdate)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reason);
			}
			if (this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LightBlockByLocation);
			}
			if (this.HasPlayerIndex)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B35 RID: 88885 RVA: 0x003275D0 File Offset: 0x003257D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResGridDataDict_.CalculateSize(RogueResGridDataUpdateNotify._map_rogueResGridDataDict_codec);
			if (this.Reason != GridDataUpdateReason.GridUpdate)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.HasPlayerIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerIndex);
			}
			if (this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LightBlockByLocation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B36 RID: 88886 RVA: 0x00327654 File Offset: 0x00325854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGridDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResGridDataDict_.MergeFrom(other.rogueResGridDataDict_);
			if (other.Reason != GridDataUpdateReason.GridUpdate)
			{
				this.Reason = other.Reason;
			}
			RogueResGridDataUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				if (dataCase == RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex)
				{
					this.PlayerIndex = other.PlayerIndex;
				}
			}
			else
			{
				if (this.LightBlockByLocation == null)
				{
					this.LightBlockByLocation = new LightBlockByLocationParam();
				}
				this.LightBlockByLocation.MergeFrom(other.LightBlockByLocation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B37 RID: 88887 RVA: 0x003276E3 File Offset: 0x003258E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B38 RID: 88888 RVA: 0x003276EC File Offset: 0x003258EC
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.rogueResGridDataDict_.AddEntriesFrom(ref input, RogueResGridDataUpdateNotify._map_rogueResGridDataDict_codec);
						continue;
					}
					if (num == 24U)
					{
						this.Reason = (GridDataUpdateReason)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						LightBlockByLocationParam lightBlockByLocationParam = new LightBlockByLocationParam();
						if (this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
						{
							lightBlockByLocationParam.MergeFrom(this.LightBlockByLocation);
						}
						input.ReadMessage(lightBlockByLocationParam);
						this.LightBlockByLocation = lightBlockByLocationParam;
						continue;
					}
					if (num == 88U)
					{
						this.PlayerIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040082B9 RID: 33465
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082BA RID: 33466
		public const int RogueResGridDataDictFieldNumber = 1;

		// Token: 0x040082BB RID: 33467
		private static readonly MapField<int, RogueResGridData>.Codec _map_rogueResGridDataDict_codec = new MapField<int, RogueResGridData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResGridData>(18U, RogueResGridData.Parser), 10U);

		// Token: 0x040082BC RID: 33468
		private readonly MapField<int, RogueResGridData> rogueResGridDataDict_ = new MapField<int, RogueResGridData>();

		// Token: 0x040082BD RID: 33469
		public const int ReasonFieldNumber = 3;

		// Token: 0x040082BE RID: 33470
		private GridDataUpdateReason reason_;

		// Token: 0x040082BF RID: 33471
		public const int PlayerIndexFieldNumber = 11;

		// Token: 0x040082C0 RID: 33472
		public const int LightBlockByLocationFieldNumber = 5;

		// Token: 0x040082C1 RID: 33473
		private object data_;

		// Token: 0x040082C2 RID: 33474
		private RogueResGridDataUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020019B0 RID: 6576
		public enum DataOneofCase
		{
			// Token: 0x0400CEB5 RID: 52917
			None,
			// Token: 0x0400CEB6 RID: 52918
			PlayerIndex = 11,
			// Token: 0x0400CEB7 RID: 52919
			LightBlockByLocation = 5
		}
	}
}
