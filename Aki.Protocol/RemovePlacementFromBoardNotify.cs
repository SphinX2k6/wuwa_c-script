using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF3 RID: 3827
	[NetMessage(EMessageId.RemovePlacementFromBoardNotify)]
	public sealed class RemovePlacementFromBoardNotify : IMessage<RemovePlacementFromBoardNotify>, IMessage, IEquatable<RemovePlacementFromBoardNotify>, IDeepCloneable<RemovePlacementFromBoardNotify>, IBufferMessage
	{
		// Token: 0x06014875 RID: 84085 RVA: 0x002FBEC0 File Offset: 0x002FA0C0
		[NullableContext(1)]
		public static RemovePlacementFromBoardNotify Create()
		{
			return new RemovePlacementFromBoardNotify();
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x06014876 RID: 84086 RVA: 0x002FBEC7 File Offset: 0x002FA0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x06014877 RID: 84087 RVA: 0x002FBECA File Offset: 0x002FA0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePlacementFromBoardNotify.Descriptor;
			}
		}

		// Token: 0x06014878 RID: 84088 RVA: 0x002FBED1 File Offset: 0x002FA0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify()
		{
		}

		// Token: 0x06014879 RID: 84089 RVA: 0x002FBEDC File Offset: 0x002FA0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify(RemovePlacementFromBoardNotify other) : this()
		{
			this.boardEntityConfigId_ = other.boardEntityConfigId_;
			this.gridInfo_ = ((other.gridInfo_ != null) ? other.gridInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601487A RID: 84090 RVA: 0x002FBF28 File Offset: 0x002FA128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify Clone()
		{
			return new RemovePlacementFromBoardNotify(this);
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x0601487B RID: 84091 RVA: 0x002FBF30 File Offset: 0x002FA130
		// (set) Token: 0x0601487C RID: 84092 RVA: 0x002FBF38 File Offset: 0x002FA138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardEntityConfigId
		{
			get
			{
				return this.boardEntityConfigId_;
			}
			set
			{
				this.boardEntityConfigId_ = value;
			}
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x0601487D RID: 84093 RVA: 0x002FBF41 File Offset: 0x002FA141
		// (set) Token: 0x0601487E RID: 84094 RVA: 0x002FBF49 File Offset: 0x002FA149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo GridInfo
		{
			get
			{
				return this.gridInfo_;
			}
			set
			{
				this.gridInfo_ = value;
			}
		}

		// Token: 0x0601487F RID: 84095 RVA: 0x002FBF52 File Offset: 0x002FA152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePlacementFromBoardNotify);
		}

		// Token: 0x06014880 RID: 84096 RVA: 0x002FBF60 File Offset: 0x002FA160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemovePlacementFromBoardNotify other)
		{
			return other != null && (other == this || (this.BoardEntityConfigId == other.BoardEntityConfigId && object.Equals(this.GridInfo, other.GridInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014881 RID: 84097 RVA: 0x002FBFB0 File Offset: 0x002FA1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardEntityConfigId != 0)
			{
				num ^= this.BoardEntityConfigId.GetHashCode();
			}
			if (this.gridInfo_ != null)
			{
				num ^= this.GridInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014882 RID: 84098 RVA: 0x002FC005 File Offset: 0x002FA205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014883 RID: 84099 RVA: 0x002FC012 File Offset: 0x002FA212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014884 RID: 84100 RVA: 0x002FC01C File Offset: 0x002FA21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GridInfo);
			}
			if (this.BoardEntityConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014885 RID: 84101 RVA: 0x002FC078 File Offset: 0x002FA278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardEntityConfigId);
			}
			if (this.gridInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014886 RID: 84102 RVA: 0x002FC0D0 File Offset: 0x002FA2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemovePlacementFromBoardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardEntityConfigId != 0)
			{
				this.BoardEntityConfigId = other.BoardEntityConfigId;
			}
			if (other.gridInfo_ != null)
			{
				if (this.gridInfo_ == null)
				{
					this.GridInfo = new OccupiedBoardGridInfo();
				}
				this.GridInfo.MergeFrom(other.GridInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014887 RID: 84103 RVA: 0x002FC138 File Offset: 0x002FA338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014888 RID: 84104 RVA: 0x002FC144 File Offset: 0x002FA344
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoardEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.gridInfo_ == null)
					{
						this.GridInfo = new OccupiedBoardGridInfo();
					}
					input.ReadMessage(this.GridInfo);
				}
			}
		}

		// Token: 0x04007CD5 RID: 31957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CD6 RID: 31958
		public const int BoardEntityConfigIdFieldNumber = 9;

		// Token: 0x04007CD7 RID: 31959
		private int boardEntityConfigId_;

		// Token: 0x04007CD8 RID: 31960
		public const int GridInfoFieldNumber = 1;

		// Token: 0x04007CD9 RID: 31961
		private OccupiedBoardGridInfo gridInfo_;
	}
}
