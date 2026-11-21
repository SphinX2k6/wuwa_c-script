using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113F RID: 4415
	public sealed class RoverRogueHistoryInsInfo : IMessage<RoverRogueHistoryInsInfo>, IMessage, IEquatable<RoverRogueHistoryInsInfo>, IDeepCloneable<RoverRogueHistoryInsInfo>, IBufferMessage
	{
		// Token: 0x06017950 RID: 96592 RVA: 0x0036E335 File Offset: 0x0036C535
		[NullableContext(1)]
		public static RoverRogueHistoryInsInfo Create()
		{
			return new RoverRogueHistoryInsInfo();
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06017951 RID: 96593 RVA: 0x0036E33C File Offset: 0x0036C53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06017952 RID: 96594 RVA: 0x0036E33F File Offset: 0x0036C53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueHistoryInsInfo.Descriptor;
			}
		}

		// Token: 0x06017953 RID: 96595 RVA: 0x0036E346 File Offset: 0x0036C546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo()
		{
		}

		// Token: 0x06017954 RID: 96596 RVA: 0x0036E350 File Offset: 0x0036C550
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

		// Token: 0x06017955 RID: 96597 RVA: 0x0036E3A4 File Offset: 0x0036C5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueHistoryInsInfo Clone()
		{
			return new RoverRogueHistoryInsInfo(this);
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06017956 RID: 96598 RVA: 0x0036E3AC File Offset: 0x0036C5AC
		// (set) Token: 0x06017957 RID: 96599 RVA: 0x0036E3B4 File Offset: 0x0036C5B4
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

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x06017958 RID: 96600 RVA: 0x0036E3BD File Offset: 0x0036C5BD
		// (set) Token: 0x06017959 RID: 96601 RVA: 0x0036E3C5 File Offset: 0x0036C5C5
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

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x0601795A RID: 96602 RVA: 0x0036E3CE File Offset: 0x0036C5CE
		// (set) Token: 0x0601795B RID: 96603 RVA: 0x0036E3D6 File Offset: 0x0036C5D6
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

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x0601795C RID: 96604 RVA: 0x0036E3DF File Offset: 0x0036C5DF
		// (set) Token: 0x0601795D RID: 96605 RVA: 0x0036E3E7 File Offset: 0x0036C5E7
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

		// Token: 0x0601795E RID: 96606 RVA: 0x0036E3F0 File Offset: 0x0036C5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueHistoryInsInfo);
		}

		// Token: 0x0601795F RID: 96607 RVA: 0x0036E400 File Offset: 0x0036C600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueHistoryInsInfo other)
		{
			return other != null && (other == this || (this.CurInsId == other.CurInsId && this.CurLayer == other.CurLayer && this.TotalLayer == other.TotalLayer && this.LootId == other.LootId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017960 RID: 96608 RVA: 0x0036E46C File Offset: 0x0036C66C
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

		// Token: 0x06017961 RID: 96609 RVA: 0x0036E4F6 File Offset: 0x0036C6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017962 RID: 96610 RVA: 0x0036E503 File Offset: 0x0036C703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017963 RID: 96611 RVA: 0x0036E50C File Offset: 0x0036C70C
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

		// Token: 0x06017964 RID: 96612 RVA: 0x0036E59C File Offset: 0x0036C79C
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

		// Token: 0x06017965 RID: 96613 RVA: 0x0036E624 File Offset: 0x0036C824
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

		// Token: 0x06017966 RID: 96614 RVA: 0x0036E69C File Offset: 0x0036C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017967 RID: 96615 RVA: 0x0036E6A8 File Offset: 0x0036C8A8
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

		// Token: 0x04008CAF RID: 36015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CB0 RID: 36016
		public const int CurInsIdFieldNumber = 1;

		// Token: 0x04008CB1 RID: 36017
		private int curInsId_;

		// Token: 0x04008CB2 RID: 36018
		public const int CurLayerFieldNumber = 2;

		// Token: 0x04008CB3 RID: 36019
		private int curLayer_;

		// Token: 0x04008CB4 RID: 36020
		public const int TotalLayerFieldNumber = 3;

		// Token: 0x04008CB5 RID: 36021
		private int totalLayer_;

		// Token: 0x04008CB6 RID: 36022
		public const int LootIdFieldNumber = 4;

		// Token: 0x04008CB7 RID: 36023
		private int lootId_;
	}
}
