using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F03 RID: 3843
	[NetMessage(EMessageId.RemovePlacementFromBoardNotify)]
	public sealed class RemovePlacementFromBoardNotify : IMessage<RemovePlacementFromBoardNotify>, IMessage, IEquatable<RemovePlacementFromBoardNotify>, IDeepCloneable<RemovePlacementFromBoardNotify>, IBufferMessage
	{
		// Token: 0x0601495A RID: 84314 RVA: 0x002FD57C File Offset: 0x002FB77C
		[NullableContext(1)]
		public static RemovePlacementFromBoardNotify Create()
		{
			return new RemovePlacementFromBoardNotify();
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x0601495B RID: 84315 RVA: 0x002FD583 File Offset: 0x002FB783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x0601495C RID: 84316 RVA: 0x002FD586 File Offset: 0x002FB786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePlacementFromBoardNotify.Descriptor;
			}
		}

		// Token: 0x0601495D RID: 84317 RVA: 0x002FD58D File Offset: 0x002FB78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify()
		{
		}

		// Token: 0x0601495E RID: 84318 RVA: 0x002FD598 File Offset: 0x002FB798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify(RemovePlacementFromBoardNotify other) : this()
		{
			this.boardEntityConfigId_ = other.boardEntityConfigId_;
			this.gridInfo_ = ((other.gridInfo_ != null) ? other.gridInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601495F RID: 84319 RVA: 0x002FD5E4 File Offset: 0x002FB7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePlacementFromBoardNotify Clone()
		{
			return new RemovePlacementFromBoardNotify(this);
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x06014960 RID: 84320 RVA: 0x002FD5EC File Offset: 0x002FB7EC
		// (set) Token: 0x06014961 RID: 84321 RVA: 0x002FD5F4 File Offset: 0x002FB7F4
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

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x06014962 RID: 84322 RVA: 0x002FD5FD File Offset: 0x002FB7FD
		// (set) Token: 0x06014963 RID: 84323 RVA: 0x002FD605 File Offset: 0x002FB805
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

		// Token: 0x06014964 RID: 84324 RVA: 0x002FD60E File Offset: 0x002FB80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePlacementFromBoardNotify);
		}

		// Token: 0x06014965 RID: 84325 RVA: 0x002FD61C File Offset: 0x002FB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemovePlacementFromBoardNotify other)
		{
			return other != null && (other == this || (this.BoardEntityConfigId == other.BoardEntityConfigId && object.Equals(this.GridInfo, other.GridInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014966 RID: 84326 RVA: 0x002FD66C File Offset: 0x002FB86C
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

		// Token: 0x06014967 RID: 84327 RVA: 0x002FD6C1 File Offset: 0x002FB8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014968 RID: 84328 RVA: 0x002FD6CE File Offset: 0x002FB8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014969 RID: 84329 RVA: 0x002FD6D8 File Offset: 0x002FB8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gridInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GridInfo);
			}
			if (this.BoardEntityConfigId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601496A RID: 84330 RVA: 0x002FD734 File Offset: 0x002FB934
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

		// Token: 0x0601496B RID: 84331 RVA: 0x002FD78C File Offset: 0x002FB98C
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

		// Token: 0x0601496C RID: 84332 RVA: 0x002FD7F4 File Offset: 0x002FB9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601496D RID: 84333 RVA: 0x002FD800 File Offset: 0x002FBA00
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
					if (num != 112U)
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

		// Token: 0x04007CAB RID: 31915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CAC RID: 31916
		public const int BoardEntityConfigIdFieldNumber = 14;

		// Token: 0x04007CAD RID: 31917
		private int boardEntityConfigId_;

		// Token: 0x04007CAE RID: 31918
		public const int GridInfoFieldNumber = 4;

		// Token: 0x04007CAF RID: 31919
		private OccupiedBoardGridInfo gridInfo_;
	}
}
