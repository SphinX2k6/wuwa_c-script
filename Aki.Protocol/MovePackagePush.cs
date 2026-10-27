using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABB RID: 2747
	[NetMessage(EMessageId.MovePackagePush)]
	public sealed class MovePackagePush : IMessage<MovePackagePush>, IMessage, IEquatable<MovePackagePush>, IDeepCloneable<MovePackagePush>, IBufferMessage
	{
		// Token: 0x0600EF06 RID: 61190 RVA: 0x0022E20D File Offset: 0x0022C40D
		[NullableContext(1)]
		public static MovePackagePush Create()
		{
			return new MovePackagePush();
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600EF07 RID: 61191 RVA: 0x0022E214 File Offset: 0x0022C414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600EF08 RID: 61192 RVA: 0x0022E217 File Offset: 0x0022C417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePackagePush.Descriptor;
			}
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x0022E21E File Offset: 0x0022C41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush()
		{
		}

		// Token: 0x0600EF0A RID: 61194 RVA: 0x0022E231 File Offset: 0x0022C431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush(MovePackagePush other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF0B RID: 61195 RVA: 0x0022E267 File Offset: 0x0022C467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush Clone()
		{
			return new MovePackagePush(this);
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600EF0C RID: 61196 RVA: 0x0022E26F File Offset: 0x0022C46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600EF0D RID: 61197 RVA: 0x0022E277 File Offset: 0x0022C477
		// (set) Token: 0x0600EF0E RID: 61198 RVA: 0x0022E27F File Offset: 0x0022C47F
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

		// Token: 0x0600EF0F RID: 61199 RVA: 0x0022E288 File Offset: 0x0022C488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePackagePush);
		}

		// Token: 0x0600EF10 RID: 61200 RVA: 0x0022E298 File Offset: 0x0022C498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePackagePush other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF11 RID: 61201 RVA: 0x0022E2E8 File Offset: 0x0022C4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.movingEntities_.GetHashCode();
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

		// Token: 0x0600EF12 RID: 61202 RVA: 0x0022E335 File Offset: 0x0022C535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF13 RID: 61203 RVA: 0x0022E342 File Offset: 0x0022C542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF14 RID: 61204 RVA: 0x0022E34C File Offset: 0x0022C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SceneOwnerId);
			}
			this.movingEntities_.WriteTo(ref output, MovePackagePush._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF15 RID: 61205 RVA: 0x0022E39C File Offset: 0x0022C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.movingEntities_.CalculateSize(MovePackagePush._repeated_movingEntities_codec);
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

		// Token: 0x0600EF16 RID: 61206 RVA: 0x0022E3F0 File Offset: 0x0022C5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovePackagePush other)
		{
			if (other == null)
			{
				return;
			}
			this.movingEntities_.Add(other.movingEntities_);
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x0022E43D File Offset: 0x0022C63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x0022E448 File Offset: 0x0022C648
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
				if (num != 32U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.movingEntities_.AddEntriesFrom(ref input, MovePackagePush._repeated_movingEntities_codec);
					}
				}
				else
				{
					this.SceneOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040060A4 RID: 24740
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060A5 RID: 24741
		public const int MovingEntitiesFieldNumber = 12;

		// Token: 0x040060A6 RID: 24742
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(98U, MovingEntityData.Parser);

		// Token: 0x040060A7 RID: 24743
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();

		// Token: 0x040060A8 RID: 24744
		public const int SceneOwnerIdFieldNumber = 4;

		// Token: 0x040060A9 RID: 24745
		private int sceneOwnerId_;
	}
}
