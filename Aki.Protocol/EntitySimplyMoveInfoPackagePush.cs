using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C1 RID: 1217
	[NetMessage(EMessageId.EntitySimplyMoveInfoPackagePush)]
	public sealed class EntitySimplyMoveInfoPackagePush : IMessage<EntitySimplyMoveInfoPackagePush>, IMessage, IEquatable<EntitySimplyMoveInfoPackagePush>, IDeepCloneable<EntitySimplyMoveInfoPackagePush>, IBufferMessage
	{
		// Token: 0x060073C0 RID: 29632 RVA: 0x0011BAEF File Offset: 0x00119CEF
		[NullableContext(1)]
		public static EntitySimplyMoveInfoPackagePush Create()
		{
			return new EntitySimplyMoveInfoPackagePush();
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x0011BAF6 File Offset: 0x00119CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060073C2 RID: 29634 RVA: 0x0011BAF9 File Offset: 0x00119CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySimplyMoveInfoPackagePush.Descriptor;
			}
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x0011BB00 File Offset: 0x00119D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush()
		{
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x0011BB13 File Offset: 0x00119D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush(EntitySimplyMoveInfoPackagePush other) : this()
		{
			this.moveInfos_ = other.moveInfos_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x0011BB49 File Offset: 0x00119D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush Clone()
		{
			return new EntitySimplyMoveInfoPackagePush(this);
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060073C6 RID: 29638 RVA: 0x0011BB51 File Offset: 0x00119D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntitySimplyMoveInfo> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060073C7 RID: 29639 RVA: 0x0011BB59 File Offset: 0x00119D59
		// (set) Token: 0x060073C8 RID: 29640 RVA: 0x0011BB61 File Offset: 0x00119D61
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

		// Token: 0x060073C9 RID: 29641 RVA: 0x0011BB6A File Offset: 0x00119D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySimplyMoveInfoPackagePush);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x0011BB78 File Offset: 0x00119D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySimplyMoveInfoPackagePush other)
		{
			return other != null && (other == this || (this.moveInfos_.Equals(other.moveInfos_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x0011BBC8 File Offset: 0x00119DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.moveInfos_.GetHashCode();
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

		// Token: 0x060073CC RID: 29644 RVA: 0x0011BC15 File Offset: 0x00119E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x0011BC22 File Offset: 0x00119E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x0011BC2C File Offset: 0x00119E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moveInfos_.WriteTo(ref output, EntitySimplyMoveInfoPackagePush._repeated_moveInfos_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x0011BC7C File Offset: 0x00119E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.moveInfos_.CalculateSize(EntitySimplyMoveInfoPackagePush._repeated_moveInfos_codec);
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

		// Token: 0x060073D0 RID: 29648 RVA: 0x0011BCD0 File Offset: 0x00119ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySimplyMoveInfoPackagePush other)
		{
			if (other == null)
			{
				return;
			}
			this.moveInfos_.Add(other.moveInfos_);
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x0011BD1D File Offset: 0x00119F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x0011BD28 File Offset: 0x00119F28
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
				if (num != 18U)
				{
					if (num != 96U)
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
					this.moveInfos_.AddEntriesFrom(ref input, EntitySimplyMoveInfoPackagePush._repeated_moveInfos_codec);
				}
			}
		}

		// Token: 0x04003D39 RID: 15673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D3A RID: 15674
		public const int MoveInfosFieldNumber = 2;

		// Token: 0x04003D3B RID: 15675
		private static readonly FieldCodec<EntitySimplyMoveInfo> _repeated_moveInfos_codec = FieldCodec.ForMessage<EntitySimplyMoveInfo>(18U, EntitySimplyMoveInfo.Parser);

		// Token: 0x04003D3C RID: 15676
		private readonly RepeatedField<EntitySimplyMoveInfo> moveInfos_ = new RepeatedField<EntitySimplyMoveInfo>();

		// Token: 0x04003D3D RID: 15677
		public const int SceneOwnerIdFieldNumber = 12;

		// Token: 0x04003D3E RID: 15678
		private int sceneOwnerId_;
	}
}
