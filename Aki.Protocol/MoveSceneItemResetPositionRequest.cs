using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC3 RID: 2755
	[NetMessage(EMessageId.MoveSceneItemResetPositionRequest)]
	public sealed class MoveSceneItemResetPositionRequest : IMessage<MoveSceneItemResetPositionRequest>, IMessage, IEquatable<MoveSceneItemResetPositionRequest>, IDeepCloneable<MoveSceneItemResetPositionRequest>, IBufferMessage
	{
		// Token: 0x0600EFD3 RID: 61395 RVA: 0x002308B3 File Offset: 0x0022EAB3
		[NullableContext(1)]
		public static MoveSceneItemResetPositionRequest Create()
		{
			return new MoveSceneItemResetPositionRequest();
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600EFD4 RID: 61396 RVA: 0x002308BA File Offset: 0x0022EABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600EFD5 RID: 61397 RVA: 0x002308BD File Offset: 0x0022EABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSceneItemResetPositionRequest.Descriptor;
			}
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x002308C4 File Offset: 0x0022EAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest()
		{
		}

		// Token: 0x0600EFD7 RID: 61399 RVA: 0x002308CC File Offset: 0x0022EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest(MoveSceneItemResetPositionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.resetEntityId_ = other.resetEntityId_;
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EFD8 RID: 61400 RVA: 0x00230909 File Offset: 0x0022EB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSceneItemResetPositionRequest Clone()
		{
			return new MoveSceneItemResetPositionRequest(this);
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600EFD9 RID: 61401 RVA: 0x00230911 File Offset: 0x0022EB11
		// (set) Token: 0x0600EFDA RID: 61402 RVA: 0x00230919 File Offset: 0x0022EB19
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

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600EFDB RID: 61403 RVA: 0x00230922 File Offset: 0x0022EB22
		// (set) Token: 0x0600EFDC RID: 61404 RVA: 0x0023092A File Offset: 0x0022EB2A
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

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600EFDD RID: 61405 RVA: 0x00230933 File Offset: 0x0022EB33
		// (set) Token: 0x0600EFDE RID: 61406 RVA: 0x0023093B File Offset: 0x0022EB3B
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

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00230944 File Offset: 0x0022EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSceneItemResetPositionRequest);
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x00230954 File Offset: 0x0022EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSceneItemResetPositionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ResetEntityId == other.ResetEntityId && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFE1 RID: 61409 RVA: 0x002309B0 File Offset: 0x0022EBB0
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

		// Token: 0x0600EFE2 RID: 61410 RVA: 0x00230A21 File Offset: 0x0022EC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFE3 RID: 61411 RVA: 0x00230A2E File Offset: 0x0022EC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFE4 RID: 61412 RVA: 0x00230A38 File Offset: 0x0022EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.ResetEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ResetEntityId);
			}
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFE5 RID: 61413 RVA: 0x00230AB0 File Offset: 0x0022ECB0
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

		// Token: 0x0600EFE6 RID: 61414 RVA: 0x00230B20 File Offset: 0x0022ED20
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

		// Token: 0x0600EFE7 RID: 61415 RVA: 0x00230B84 File Offset: 0x0022ED84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFE8 RID: 61416 RVA: 0x00230B90 File Offset: 0x0022ED90
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
				if (num != 16U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040060FA RID: 24826
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060FB RID: 24827
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040060FC RID: 24828
		private long entityId_;

		// Token: 0x040060FD RID: 24829
		public const int ResetEntityIdFieldNumber = 11;

		// Token: 0x040060FE RID: 24830
		private long resetEntityId_;

		// Token: 0x040060FF RID: 24831
		public const int SceneOwnerIdFieldNumber = 15;

		// Token: 0x04006100 RID: 24832
		private int sceneOwnerId_;
	}
}
