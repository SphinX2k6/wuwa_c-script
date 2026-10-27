using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001105 RID: 4357
	public sealed class RoverRogueHistoryInsInfo : IMessage<RoverRogueHistoryInsInfo>, IMessage, IEquatable<RoverRogueHistoryInsInfo>, IDeepCloneable<RoverRogueHistoryInsInfo>, IBufferMessage
	{
		// Token: 0x060173AF RID: 95151 RVA: 0x0035EFE5 File Offset: 0x0035D1E5
		[NullableContext(1)]
		public static RoverRogueHistoryInsInfo Create()
		{
			return new RoverRogueHistoryInsInfo();
		}

		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x060173B0 RID: 95152 RVA: 0x0035EFEC File Offset: 0x0035D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x060173B1 RID: 95153 RVA: 0x0035EFEF File Offset: 0x0035D1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueHistoryInsInfo.Descriptor;
			}
		}

		// Token: 0x060173B2 RID: 95154 RVA: 0x0035EFF6 File Offset: 0x0035D1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo()
		{
		}

		// Token: 0x060173B3 RID: 95155 RVA: 0x0035F000 File Offset: 0x0035D200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo(RoverRogueHistoryInsInfo other) : this()
		{
			this.curInsId_ = other.curInsId_;
			this.curLayer_ = other.curLayer_;
			this.totalLayer_ = other.totalLayer_;
			this.lootId_ = other.lootId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173B4 RID: 95156 RVA: 0x0035F054 File Offset: 0x0035D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo Clone()
		{
			return new RoverRogueHistoryInsInfo(this);
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x060173B5 RID: 95157 RVA: 0x0035F05C File Offset: 0x0035D25C
		// (set) Token: 0x060173B6 RID: 95158 RVA: 0x0035F064 File Offset: 0x0035D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurInsId
		{
			get
			{
				return this.curInsId_;
			}
			set
			{
				this.curInsId_ = value;
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x060173B7 RID: 95159 RVA: 0x0035F06D File Offset: 0x0035D26D
		// (set) Token: 0x060173B8 RID: 95160 RVA: 0x0035F075 File Offset: 0x0035D275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x060173B9 RID: 95161 RVA: 0x0035F07E File Offset: 0x0035D27E
		// (set) Token: 0x060173BA RID: 95162 RVA: 0x0035F086 File Offset: 0x0035D286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalLayer
		{
			get
			{
				return this.totalLayer_;
			}
			set
			{
				this.totalLayer_ = value;
			}
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x060173BB RID: 95163 RVA: 0x0035F08F File Offset: 0x0035D28F
		// (set) Token: 0x060173BC RID: 95164 RVA: 0x0035F097 File Offset: 0x0035D297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootId
		{
			get
			{
				return this.lootId_;
			}
			set
			{
				this.lootId_ = value;
			}
		}

		// Token: 0x060173BD RID: 95165 RVA: 0x0035F0A0 File Offset: 0x0035D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueHistoryInsInfo);
		}

		// Token: 0x060173BE RID: 95166 RVA: 0x0035F0B0 File Offset: 0x0035D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueHistoryInsInfo other)
		{
			return other != null && (other == this || (this.CurInsId == other.CurInsId && this.CurLayer == other.CurLayer && this.TotalLayer == other.TotalLayer && this.LootId == other.LootId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173BF RID: 95167 RVA: 0x0035F11C File Offset: 0x0035D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurInsId != 0)
			{
				num ^= this.CurInsId.GetHashCode();
			}
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.TotalLayer != 0)
			{
				num ^= this.TotalLayer.GetHashCode();
			}
			if (this.LootId != 0)
			{
				num ^= this.LootId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173C0 RID: 95168 RVA: 0x0035F1A6 File Offset: 0x0035D3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173C1 RID: 95169 RVA: 0x0035F1B3 File Offset: 0x0035D3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173C2 RID: 95170 RVA: 0x0035F1BC File Offset: 0x0035D3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurInsId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurLayer);
			}
			if (this.TotalLayer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalLayer);
			}
			if (this.LootId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LootId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x0035F24C File Offset: 0x0035D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurInsId);
			}
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.TotalLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalLayer);
			}
			if (this.LootId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x0035F2D4 File Offset: 0x0035D4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueHistoryInsInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurInsId != 0)
			{
				this.CurInsId = other.CurInsId;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.TotalLayer != 0)
			{
				this.TotalLayer = other.TotalLayer;
			}
			if (other.LootId != 0)
			{
				this.LootId = other.LootId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x0035F34C File Offset: 0x0035D54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173C6 RID: 95174 RVA: 0x0035F358 File Offset: 0x0035D558
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
						this.CurInsId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TotalLayer = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LootId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A1C RID: 35356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A1D RID: 35357
		public const int CurInsIdFieldNumber = 1;

		// Token: 0x04008A1E RID: 35358
		private int curInsId_;

		// Token: 0x04008A1F RID: 35359
		public const int CurLayerFieldNumber = 2;

		// Token: 0x04008A20 RID: 35360
		private int curLayer_;

		// Token: 0x04008A21 RID: 35361
		public const int TotalLayerFieldNumber = 3;

		// Token: 0x04008A22 RID: 35362
		private int totalLayer_;

		// Token: 0x04008A23 RID: 35363
		public const int LootIdFieldNumber = 4;

		// Token: 0x04008A24 RID: 35364
		private int lootId_;
	}
}
