using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F4 RID: 2292
	public sealed class LevelGridPbData : IMessage<LevelGridPbData>, IMessage, IEquatable<LevelGridPbData>, IDeepCloneable<LevelGridPbData>, IBufferMessage
	{
		// Token: 0x0600CA96 RID: 51862 RVA: 0x001DE59D File Offset: 0x001DC79D
		[NullableContext(1)]
		public static LevelGridPbData Create()
		{
			return new LevelGridPbData();
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x001DE5A4 File Offset: 0x001DC7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600CA98 RID: 51864 RVA: 0x001DE5A7 File Offset: 0x001DC7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelGridPbData.Descriptor;
			}
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x001DE5AE File Offset: 0x001DC7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData()
		{
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x001DE5B8 File Offset: 0x001DC7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData(LevelGridPbData other) : this()
		{
			this.gridPlacementPbInfo_ = ((other.gridPlacementPbInfo_ != null) ? other.gridPlacementPbInfo_.Clone() : null);
			LevelGridPbData.DataOneofCase dataCase = other.DataCase;
			if (dataCase != LevelGridPbData.DataOneofCase.EntityGridPbData)
			{
				if (dataCase == LevelGridPbData.DataOneofCase.PollutedGridPbData)
				{
					this.PollutedGridPbData = other.PollutedGridPbData.Clone();
				}
			}
			else
			{
				this.EntityGridPbData = other.EntityGridPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x001DE62D File Offset: 0x001DC82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData Clone()
		{
			return new LevelGridPbData(this);
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x001DE635 File Offset: 0x001DC835
		// (set) Token: 0x0600CA9D RID: 51869 RVA: 0x001DE63D File Offset: 0x001DC83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo GridPlacementPbInfo
		{
			get
			{
				return this.gridPlacementPbInfo_;
			}
			set
			{
				this.gridPlacementPbInfo_ = value;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x001DE646 File Offset: 0x001DC846
		// (set) Token: 0x0600CA9F RID: 51871 RVA: 0x001DE65E File Offset: 0x001DC85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData EntityGridPbData
		{
			get
			{
				if (this.dataCase_ != LevelGridPbData.DataOneofCase.EntityGridPbData)
				{
					return null;
				}
				return (EntityGridPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? LevelGridPbData.DataOneofCase.None : LevelGridPbData.DataOneofCase.EntityGridPbData);
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600CAA0 RID: 51872 RVA: 0x001DE674 File Offset: 0x001DC874
		// (set) Token: 0x0600CAA1 RID: 51873 RVA: 0x001DE68C File Offset: 0x001DC88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData PollutedGridPbData
		{
			get
			{
				if (this.dataCase_ != LevelGridPbData.DataOneofCase.PollutedGridPbData)
				{
					return null;
				}
				return (PollutedGridPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? LevelGridPbData.DataOneofCase.None : LevelGridPbData.DataOneofCase.PollutedGridPbData);
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600CAA2 RID: 51874 RVA: 0x001DE6A2 File Offset: 0x001DC8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x001DE6AA File Offset: 0x001DC8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = LevelGridPbData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x001DE6BA File Offset: 0x001DC8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelGridPbData);
		}

		// Token: 0x0600CAA5 RID: 51877 RVA: 0x001DE6C8 File Offset: 0x001DC8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelGridPbData other)
		{
			return other != null && (other == this || (object.Equals(this.GridPlacementPbInfo, other.GridPlacementPbInfo) && object.Equals(this.EntityGridPbData, other.EntityGridPbData) && object.Equals(this.PollutedGridPbData, other.PollutedGridPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x001DE740 File Offset: 0x001DC940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gridPlacementPbInfo_ != null)
			{
				num ^= this.GridPlacementPbInfo.GetHashCode();
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.EntityGridPbData)
			{
				num ^= this.EntityGridPbData.GetHashCode();
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.PollutedGridPbData)
			{
				num ^= this.PollutedGridPbData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x001DE7B3 File Offset: 0x001DC9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAA8 RID: 51880 RVA: 0x001DE7C0 File Offset: 0x001DC9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x001DE7CC File Offset: 0x001DC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GridPlacementPbInfo);
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.EntityGridPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityGridPbData);
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.PollutedGridPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PollutedGridPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x001DE844 File Offset: 0x001DCA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gridPlacementPbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridPlacementPbInfo);
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.EntityGridPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityGridPbData);
			}
			if (this.dataCase_ == LevelGridPbData.DataOneofCase.PollutedGridPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PollutedGridPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x001DE8B4 File Offset: 0x001DCAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelGridPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gridPlacementPbInfo_ != null)
			{
				if (this.gridPlacementPbInfo_ == null)
				{
					this.GridPlacementPbInfo = new GridPlacementPbInfo();
				}
				this.GridPlacementPbInfo.MergeFrom(other.GridPlacementPbInfo);
			}
			LevelGridPbData.DataOneofCase dataCase = other.DataCase;
			if (dataCase != LevelGridPbData.DataOneofCase.EntityGridPbData)
			{
				if (dataCase == LevelGridPbData.DataOneofCase.PollutedGridPbData)
				{
					if (this.PollutedGridPbData == null)
					{
						this.PollutedGridPbData = new PollutedGridPbData();
					}
					this.PollutedGridPbData.MergeFrom(other.PollutedGridPbData);
				}
			}
			else
			{
				if (this.EntityGridPbData == null)
				{
					this.EntityGridPbData = new EntityGridPbData();
				}
				this.EntityGridPbData.MergeFrom(other.EntityGridPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x001DE963 File Offset: 0x001DCB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x001DE96C File Offset: 0x001DCB6C
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							PollutedGridPbData pollutedGridPbData = new PollutedGridPbData();
							if (this.dataCase_ == LevelGridPbData.DataOneofCase.PollutedGridPbData)
							{
								pollutedGridPbData.MergeFrom(this.PollutedGridPbData);
							}
							input.ReadMessage(pollutedGridPbData);
							this.PollutedGridPbData = pollutedGridPbData;
						}
					}
					else
					{
						EntityGridPbData entityGridPbData = new EntityGridPbData();
						if (this.dataCase_ == LevelGridPbData.DataOneofCase.EntityGridPbData)
						{
							entityGridPbData.MergeFrom(this.EntityGridPbData);
						}
						input.ReadMessage(entityGridPbData);
						this.EntityGridPbData = entityGridPbData;
					}
				}
				else
				{
					if (this.gridPlacementPbInfo_ == null)
					{
						this.GridPlacementPbInfo = new GridPlacementPbInfo();
					}
					input.ReadMessage(this.GridPlacementPbInfo);
				}
			}
		}

		// Token: 0x04005630 RID: 22064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005631 RID: 22065
		public const int GridPlacementPbInfoFieldNumber = 1;

		// Token: 0x04005632 RID: 22066
		private GridPlacementPbInfo gridPlacementPbInfo_;

		// Token: 0x04005633 RID: 22067
		public const int EntityGridPbDataFieldNumber = 2;

		// Token: 0x04005634 RID: 22068
		public const int PollutedGridPbDataFieldNumber = 3;

		// Token: 0x04005635 RID: 22069
		private object data_;

		// Token: 0x04005636 RID: 22070
		private LevelGridPbData.DataOneofCase dataCase_;

		// Token: 0x02001817 RID: 6167
		public enum DataOneofCase
		{
			// Token: 0x0400C7D5 RID: 51157
			None,
			// Token: 0x0400C7D6 RID: 51158
			EntityGridPbData = 2,
			// Token: 0x0400C7D7 RID: 51159
			PollutedGridPbData
		}
	}
}
