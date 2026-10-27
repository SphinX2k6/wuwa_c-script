using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE5 RID: 4069
	[NetMessage(EMessageId.RogueResGridDataUpdateNotify)]
	public sealed class RogueResGridDataUpdateNotify : IMessage<RogueResGridDataUpdateNotify>, IMessage, IEquatable<RogueResGridDataUpdateNotify>, IDeepCloneable<RogueResGridDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015C03 RID: 89091 RVA: 0x0032897D File Offset: 0x00326B7D
		[NullableContext(1)]
		public static RogueResGridDataUpdateNotify Create()
		{
			return new RogueResGridDataUpdateNotify();
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06015C04 RID: 89092 RVA: 0x00328984 File Offset: 0x00326B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06015C05 RID: 89093 RVA: 0x00328987 File Offset: 0x00326B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015C06 RID: 89094 RVA: 0x0032898E File Offset: 0x00326B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify()
		{
		}

		// Token: 0x06015C07 RID: 89095 RVA: 0x003289A4 File Offset: 0x00326BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify(RogueResGridDataUpdateNotify other) : this()
		{
			this.rogueResGridDataDict_ = other.rogueResGridDataDict_.Clone();
			this.reason_ = other.reason_;
			RogueResGridDataUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex)
			{
				if (dataCase == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
				{
					this.LightBlockByLocation = other.LightBlockByLocation.Clone();
				}
			}
			else
			{
				this.PlayerIndex = other.PlayerIndex;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C08 RID: 89096 RVA: 0x00328A16 File Offset: 0x00326C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify Clone()
		{
			return new RogueResGridDataUpdateNotify(this);
		}

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06015C09 RID: 89097 RVA: 0x00328A1E File Offset: 0x00326C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResGridData> RogueResGridDataDict
		{
			get
			{
				return this.rogueResGridDataDict_;
			}
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06015C0A RID: 89098 RVA: 0x00328A26 File Offset: 0x00326C26
		// (set) Token: 0x06015C0B RID: 89099 RVA: 0x00328A2E File Offset: 0x00326C2E
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

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06015C0C RID: 89100 RVA: 0x00328A37 File Offset: 0x00326C37
		// (set) Token: 0x06015C0D RID: 89101 RVA: 0x00328A4E File Offset: 0x00326C4E
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

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06015C0E RID: 89102 RVA: 0x00328A63 File Offset: 0x00326C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPlayerIndex
		{
			get
			{
				return this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex;
			}
		}

		// Token: 0x06015C0F RID: 89103 RVA: 0x00328A6E File Offset: 0x00326C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPlayerIndex()
		{
			if (this.HasPlayerIndex)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06015C10 RID: 89104 RVA: 0x00328A7E File Offset: 0x00326C7E
		// (set) Token: 0x06015C11 RID: 89105 RVA: 0x00328A97 File Offset: 0x00326C97
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

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06015C12 RID: 89106 RVA: 0x00328AAE File Offset: 0x00326CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridDataUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015C13 RID: 89107 RVA: 0x00328AB6 File Offset: 0x00326CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResGridDataUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015C14 RID: 89108 RVA: 0x00328AC6 File Offset: 0x00326CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridDataUpdateNotify);
		}

		// Token: 0x06015C15 RID: 89109 RVA: 0x00328AD4 File Offset: 0x00326CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridDataUpdateNotify other)
		{
			return other != null && (other == this || (this.RogueResGridDataDict.Equals(other.RogueResGridDataDict) && this.Reason == other.Reason && this.PlayerIndex == other.PlayerIndex && object.Equals(this.LightBlockByLocation, other.LightBlockByLocation) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C16 RID: 89110 RVA: 0x00328B58 File Offset: 0x00326D58
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

		// Token: 0x06015C17 RID: 89111 RVA: 0x00328BE5 File Offset: 0x00326DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C18 RID: 89112 RVA: 0x00328BF2 File Offset: 0x00326DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C19 RID: 89113 RVA: 0x00328BFC File Offset: 0x00326DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != GridDataUpdateReason.GridUpdate)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			this.rogueResGridDataDict_.WriteTo(ref output, RogueResGridDataUpdateNotify._map_rogueResGridDataDict_codec);
			if (this.HasPlayerIndex)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerIndex);
			}
			if (this.dataCase_ == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.LightBlockByLocation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C1A RID: 89114 RVA: 0x00328C84 File Offset: 0x00326E84
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

		// Token: 0x06015C1B RID: 89115 RVA: 0x00328D08 File Offset: 0x00326F08
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
			if (dataCase != RogueResGridDataUpdateNotify.DataOneofCase.PlayerIndex)
			{
				if (dataCase == RogueResGridDataUpdateNotify.DataOneofCase.LightBlockByLocation)
				{
					if (this.LightBlockByLocation == null)
					{
						this.LightBlockByLocation = new LightBlockByLocationParam();
					}
					this.LightBlockByLocation.MergeFrom(other.LightBlockByLocation);
				}
			}
			else
			{
				this.PlayerIndex = other.PlayerIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C1C RID: 89116 RVA: 0x00328D99 File Offset: 0x00326F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C1D RID: 89117 RVA: 0x00328DA4 File Offset: 0x00326FA4
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.Reason = (GridDataUpdateReason)input.ReadEnum();
						continue;
					}
					if (num == 34U)
					{
						this.rogueResGridDataDict_.AddEntriesFrom(ref input, RogueResGridDataUpdateNotify._map_rogueResGridDataDict_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.PlayerIndex = input.ReadInt32();
						continue;
					}
					if (num == 74U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400828F RID: 33423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008290 RID: 33424
		public const int RogueResGridDataDictFieldNumber = 4;

		// Token: 0x04008291 RID: 33425
		private static readonly MapField<int, RogueResGridData>.Codec _map_rogueResGridDataDict_codec = new MapField<int, RogueResGridData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResGridData>(18U, RogueResGridData.Parser), 34U);

		// Token: 0x04008292 RID: 33426
		private readonly MapField<int, RogueResGridData> rogueResGridDataDict_ = new MapField<int, RogueResGridData>();

		// Token: 0x04008293 RID: 33427
		public const int ReasonFieldNumber = 1;

		// Token: 0x04008294 RID: 33428
		private GridDataUpdateReason reason_;

		// Token: 0x04008295 RID: 33429
		public const int PlayerIndexFieldNumber = 7;

		// Token: 0x04008296 RID: 33430
		public const int LightBlockByLocationFieldNumber = 9;

		// Token: 0x04008297 RID: 33431
		private object data_;

		// Token: 0x04008298 RID: 33432
		private RogueResGridDataUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001938 RID: 6456
		public enum DataOneofCase
		{
			// Token: 0x0400C98A RID: 51594
			None,
			// Token: 0x0400C98B RID: 51595
			PlayerIndex = 7,
			// Token: 0x0400C98C RID: 51596
			LightBlockByLocation = 9
		}
	}
}
