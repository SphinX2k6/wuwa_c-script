using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB2 RID: 2738
	[NetMessage(EMessageId.MoveSceneItemResetPositionRequest)]
	public sealed class MoveSceneItemResetPositionRequest : IMessage<MoveSceneItemResetPositionRequest>, IMessage, IEquatable<MoveSceneItemResetPositionRequest>, IDeepCloneable<MoveSceneItemResetPositionRequest>, IBufferMessage
	{
		// Token: 0x0600EEB9 RID: 61113 RVA: 0x0022E6AF File Offset: 0x0022C8AF
		[NullableContext(1)]
		public static MoveSceneItemResetPositionRequest Create()
		{
			return new MoveSceneItemResetPositionRequest();
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600EEBA RID: 61114 RVA: 0x0022E6B6 File Offset: 0x0022C8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600EEBB RID: 61115 RVA: 0x0022E6B9 File Offset: 0x0022C8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemResetPositionRequest.Descriptor;
			}
		}

		// Token: 0x0600EEBC RID: 61116 RVA: 0x0022E6C0 File Offset: 0x0022C8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest()
		{
		}

		// Token: 0x0600EEBD RID: 61117 RVA: 0x0022E6C8 File Offset: 0x0022C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest(MoveSceneItemResetPositionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.resetEntityId_ = other.resetEntityId_;
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEBE RID: 61118 RVA: 0x0022E705 File Offset: 0x0022C905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest Clone()
		{
			return new MoveSceneItemResetPositionRequest(this);
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600EEBF RID: 61119 RVA: 0x0022E70D File Offset: 0x0022C90D
		// (set) Token: 0x0600EEC0 RID: 61120 RVA: 0x0022E715 File Offset: 0x0022C915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600EEC1 RID: 61121 RVA: 0x0022E71E File Offset: 0x0022C91E
		// (set) Token: 0x0600EEC2 RID: 61122 RVA: 0x0022E726 File Offset: 0x0022C926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResetEntityId
		{
			get
			{
				return this.resetEntityId_;
			}
			set
			{
				this.resetEntityId_ = value;
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x0022E72F File Offset: 0x0022C92F
		// (set) Token: 0x0600EEC4 RID: 61124 RVA: 0x0022E737 File Offset: 0x0022C937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneOwnerId
		{
			get
			{
				return this.sceneOwnerId_;
			}
			set
			{
				this.sceneOwnerId_ = value;
			}
		}

		// Token: 0x0600EEC5 RID: 61125 RVA: 0x0022E740 File Offset: 0x0022C940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemResetPositionRequest);
		}

		// Token: 0x0600EEC6 RID: 61126 RVA: 0x0022E750 File Offset: 0x0022C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemResetPositionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ResetEntityId == other.ResetEntityId && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEC7 RID: 61127 RVA: 0x0022E7AC File Offset: 0x0022C9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ResetEntityId != 0L)
			{
				num ^= this.ResetEntityId.GetHashCode();
			}
			if (this.SceneOwnerId != 0)
			{
				num ^= this.SceneOwnerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EEC8 RID: 61128 RVA: 0x0022E81D File Offset: 0x0022CA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEC9 RID: 61129 RVA: 0x0022E82A File Offset: 0x0022CA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EECA RID: 61130 RVA: 0x0022E834 File Offset: 0x0022CA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ResetEntityId);
			}
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EECB RID: 61131 RVA: 0x0022E8A8 File Offset: 0x0022CAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ResetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResetEntityId);
			}
			if (this.SceneOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EECC RID: 61132 RVA: 0x0022E918 File Offset: 0x0022CB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSceneItemResetPositionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ResetEntityId != 0L)
			{
				this.ResetEntityId = other.ResetEntityId;
			}
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EECD RID: 61133 RVA: 0x0022E97C File Offset: 0x0022CB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EECE RID: 61134 RVA: 0x0022E988 File Offset: 0x0022CB88
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.SceneOwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.ResetEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006103 RID: 24835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006104 RID: 24836
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04006105 RID: 24837
		private long entityId_;

		// Token: 0x04006106 RID: 24838
		public const int ResetEntityIdFieldNumber = 1;

		// Token: 0x04006107 RID: 24839
		private long resetEntityId_;

		// Token: 0x04006108 RID: 24840
		public const int SceneOwnerIdFieldNumber = 3;

		// Token: 0x04006109 RID: 24841
		private int sceneOwnerId_;
	}
}
