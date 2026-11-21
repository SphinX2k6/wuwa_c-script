using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E3 RID: 2275
	public sealed class LevelGridPbData : IMessage<LevelGridPbData>, IMessage, IEquatable<LevelGridPbData>, IDeepCloneable<LevelGridPbData>, IBufferMessage
	{
		// Token: 0x0600C97A RID: 51578 RVA: 0x001DC2C1 File Offset: 0x001DA4C1
		[NullableContext(1)]
		public static LevelGridPbData Create()
		{
			return new LevelGridPbData();
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600C97B RID: 51579 RVA: 0x001DC2C8 File Offset: 0x001DA4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600C97C RID: 51580 RVA: 0x001DC2CB File Offset: 0x001DA4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelGridPbData.Descriptor;
			}
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x001DC2D2 File Offset: 0x001DA4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData()
		{
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x001DC2DC File Offset: 0x001DA4DC
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

		// Token: 0x0600C97F RID: 51583 RVA: 0x001DC351 File Offset: 0x001DA551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData Clone()
		{
			return new LevelGridPbData(this);
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600C980 RID: 51584 RVA: 0x001DC359 File Offset: 0x001DA559
		// (set) Token: 0x0600C981 RID: 51585 RVA: 0x001DC361 File Offset: 0x001DA561
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

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600C982 RID: 51586 RVA: 0x001DC36A File Offset: 0x001DA56A
		// (set) Token: 0x0600C983 RID: 51587 RVA: 0x001DC382 File Offset: 0x001DA582
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

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600C984 RID: 51588 RVA: 0x001DC398 File Offset: 0x001DA598
		// (set) Token: 0x0600C985 RID: 51589 RVA: 0x001DC3B0 File Offset: 0x001DA5B0
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

		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600C986 RID: 51590 RVA: 0x001DC3C6 File Offset: 0x001DA5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600C987 RID: 51591 RVA: 0x001DC3CE File Offset: 0x001DA5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = LevelGridPbData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x001DC3DE File Offset: 0x001DA5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelGridPbData);
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x001DC3EC File Offset: 0x001DA5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelGridPbData other)
		{
			return other != null && (other == this || (object.Equals(this.GridPlacementPbInfo, other.GridPlacementPbInfo) && object.Equals(this.EntityGridPbData, other.EntityGridPbData) && object.Equals(this.PollutedGridPbData, other.PollutedGridPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C98A RID: 51594 RVA: 0x001DC464 File Offset: 0x001DA664
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

		// Token: 0x0600C98B RID: 51595 RVA: 0x001DC4D7 File Offset: 0x001DA6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x001DC4E4 File Offset: 0x001DA6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x001DC4F0 File Offset: 0x001DA6F0
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

		// Token: 0x0600C98E RID: 51598 RVA: 0x001DC568 File Offset: 0x001DA768
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

		// Token: 0x0600C98F RID: 51599 RVA: 0x001DC5D8 File Offset: 0x001DA7D8
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

		// Token: 0x0600C990 RID: 51600 RVA: 0x001DC687 File Offset: 0x001DA887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C991 RID: 51601 RVA: 0x001DC690 File Offset: 0x001DA890
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

		// Token: 0x04005637 RID: 22071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005638 RID: 22072
		public const int GridPlacementPbInfoFieldNumber = 1;

		// Token: 0x04005639 RID: 22073
		private GridPlacementPbInfo gridPlacementPbInfo_;

		// Token: 0x0400563A RID: 22074
		public const int EntityGridPbDataFieldNumber = 2;

		// Token: 0x0400563B RID: 22075
		public const int PollutedGridPbDataFieldNumber = 3;

		// Token: 0x0400563C RID: 22076
		private object data_;

		// Token: 0x0400563D RID: 22077
		private LevelGridPbData.DataOneofCase dataCase_;

		// Token: 0x0200188F RID: 6287
		public enum DataOneofCase
		{
			// Token: 0x0400CD00 RID: 52480
			None,
			// Token: 0x0400CD01 RID: 52481
			EntityGridPbData = 2,
			// Token: 0x0400CD02 RID: 52482
			PollutedGridPbData
		}
	}
}
