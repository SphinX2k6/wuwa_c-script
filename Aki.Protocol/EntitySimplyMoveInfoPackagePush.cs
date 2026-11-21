using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AA RID: 1194
	[NetMessage(EMessageId.EntitySimplyMoveInfoPackagePush)]
	public sealed class EntitySimplyMoveInfoPackagePush : IMessage<EntitySimplyMoveInfoPackagePush>, IMessage, IEquatable<EntitySimplyMoveInfoPackagePush>, IDeepCloneable<EntitySimplyMoveInfoPackagePush>, IBufferMessage
	{
		// Token: 0x06007230 RID: 29232 RVA: 0x001189D7 File Offset: 0x00116BD7
		[NullableContext(1)]
		public static EntitySimplyMoveInfoPackagePush Create()
		{
			return new EntitySimplyMoveInfoPackagePush();
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x001189DE File Offset: 0x00116BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06007232 RID: 29234 RVA: 0x001189E1 File Offset: 0x00116BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySimplyMoveInfoPackagePush.Descriptor;
			}
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x001189E8 File Offset: 0x00116BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush()
		{
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x001189FB File Offset: 0x00116BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush(EntitySimplyMoveInfoPackagePush other) : this()
		{
			this.moveInfos_ = other.moveInfos_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x00118A31 File Offset: 0x00116C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfoPackagePush Clone()
		{
			return new EntitySimplyMoveInfoPackagePush(this);
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x00118A39 File Offset: 0x00116C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntitySimplyMoveInfo> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00118A41 File Offset: 0x00116C41
		// (set) Token: 0x06007238 RID: 29240 RVA: 0x00118A49 File Offset: 0x00116C49
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

		// Token: 0x06007239 RID: 29241 RVA: 0x00118A52 File Offset: 0x00116C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySimplyMoveInfoPackagePush);
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00118A60 File Offset: 0x00116C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySimplyMoveInfoPackagePush other)
		{
			return other != null && (other == this || (this.moveInfos_.Equals(other.moveInfos_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00118AB0 File Offset: 0x00116CB0
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

		// Token: 0x0600723C RID: 29244 RVA: 0x00118AFD File Offset: 0x00116CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00118B0A File Offset: 0x00116D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00118B14 File Offset: 0x00116D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SceneOwnerId);
			}
			this.moveInfos_.WriteTo(ref output, EntitySimplyMoveInfoPackagePush._repeated_moveInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00118B64 File Offset: 0x00116D64
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

		// Token: 0x06007240 RID: 29248 RVA: 0x00118BB8 File Offset: 0x00116DB8
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

		// Token: 0x06007241 RID: 29249 RVA: 0x00118C05 File Offset: 0x00116E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00118C10 File Offset: 0x00116E10
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
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.moveInfos_.AddEntriesFrom(ref input, EntitySimplyMoveInfoPackagePush._repeated_moveInfos_codec);
					}
				}
				else
				{
					this.SceneOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D25 RID: 15653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D26 RID: 15654
		public const int MoveInfosFieldNumber = 15;

		// Token: 0x04003D27 RID: 15655
		private static readonly FieldCodec<EntitySimplyMoveInfo> _repeated_moveInfos_codec = FieldCodec.ForMessage<EntitySimplyMoveInfo>(122U, EntitySimplyMoveInfo.Parser);

		// Token: 0x04003D28 RID: 15656
		private readonly RepeatedField<EntitySimplyMoveInfo> moveInfos_ = new RepeatedField<EntitySimplyMoveInfo>();

		// Token: 0x04003D29 RID: 15657
		public const int SceneOwnerIdFieldNumber = 8;

		// Token: 0x04003D2A RID: 15658
		private int sceneOwnerId_;
	}
}
