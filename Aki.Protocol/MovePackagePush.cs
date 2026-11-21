using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAA RID: 2730
	[NetMessage(EMessageId.MovePackagePush)]
	public sealed class MovePackagePush : IMessage<MovePackagePush>, IMessage, IEquatable<MovePackagePush>, IDeepCloneable<MovePackagePush>, IBufferMessage
	{
		// Token: 0x0600EDEC RID: 60908 RVA: 0x0022C00D File Offset: 0x0022A20D
		[NullableContext(1)]
		public static MovePackagePush Create()
		{
			return new MovePackagePush();
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600EDED RID: 60909 RVA: 0x0022C014 File Offset: 0x0022A214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x0022C017 File Offset: 0x0022A217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovePackagePush.Descriptor;
			}
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x0022C01E File Offset: 0x0022A21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush()
		{
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x0022C031 File Offset: 0x0022A231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush(MovePackagePush other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDF1 RID: 60913 RVA: 0x0022C067 File Offset: 0x0022A267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovePackagePush Clone()
		{
			return new MovePackagePush(this);
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x0022C06F File Offset: 0x0022A26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600EDF3 RID: 60915 RVA: 0x0022C077 File Offset: 0x0022A277
		// (set) Token: 0x0600EDF4 RID: 60916 RVA: 0x0022C07F File Offset: 0x0022A27F
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

		// Token: 0x0600EDF5 RID: 60917 RVA: 0x0022C088 File Offset: 0x0022A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovePackagePush);
		}

		// Token: 0x0600EDF6 RID: 60918 RVA: 0x0022C098 File Offset: 0x0022A298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovePackagePush other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDF7 RID: 60919 RVA: 0x0022C0E8 File Offset: 0x0022A2E8
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

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x0022C135 File Offset: 0x0022A335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x0022C142 File Offset: 0x0022A342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDFA RID: 60922 RVA: 0x0022C14C File Offset: 0x0022A34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.movingEntities_.WriteTo(ref output, MovePackagePush._repeated_movingEntities_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDFB RID: 60923 RVA: 0x0022C19C File Offset: 0x0022A39C
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

		// Token: 0x0600EDFC RID: 60924 RVA: 0x0022C1F0 File Offset: 0x0022A3F0
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

		// Token: 0x0600EDFD RID: 60925 RVA: 0x0022C23D File Offset: 0x0022A43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDFE RID: 60926 RVA: 0x0022C248 File Offset: 0x0022A448
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
				if (num != 42U)
				{
					if (num != 104U)
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
					this.movingEntities_.AddEntriesFrom(ref input, MovePackagePush._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x040060AD RID: 24749
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060AE RID: 24750
		public const int MovingEntitiesFieldNumber = 5;

		// Token: 0x040060AF RID: 24751
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(42U, MovingEntityData.Parser);

		// Token: 0x040060B0 RID: 24752
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();

		// Token: 0x040060B1 RID: 24753
		public const int SceneOwnerIdFieldNumber = 13;

		// Token: 0x040060B2 RID: 24754
		private int sceneOwnerId_;
	}
}
