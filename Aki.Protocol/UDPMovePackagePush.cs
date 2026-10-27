using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147C RID: 5244
	[NetMessage(EMessageId.UDPMovePackagePush)]
	public sealed class UDPMovePackagePush : IMessage<UDPMovePackagePush>, IMessage, IEquatable<UDPMovePackagePush>, IDeepCloneable<UDPMovePackagePush>, IBufferMessage
	{
		// Token: 0x0601BC13 RID: 113683 RVA: 0x00403F21 File Offset: 0x00402121
		[NullableContext(1)]
		public static UDPMovePackagePush Create()
		{
			return new UDPMovePackagePush();
		}

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x0601BC14 RID: 113684 RVA: 0x00403F28 File Offset: 0x00402128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0601BC15 RID: 113685 RVA: 0x00403F2B File Offset: 0x0040212B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UDPMovePackagePush.Descriptor;
			}
		}

		// Token: 0x0601BC16 RID: 113686 RVA: 0x00403F32 File Offset: 0x00402132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush()
		{
		}

		// Token: 0x0601BC17 RID: 113687 RVA: 0x00403F45 File Offset: 0x00402145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush(UDPMovePackagePush other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC18 RID: 113688 RVA: 0x00403F7B File Offset: 0x0040217B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush Clone()
		{
			return new UDPMovePackagePush(this);
		}

		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x0601BC19 RID: 113689 RVA: 0x00403F83 File Offset: 0x00402183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x0601BC1A RID: 113690 RVA: 0x00403F8B File Offset: 0x0040218B
		// (set) Token: 0x0601BC1B RID: 113691 RVA: 0x00403F93 File Offset: 0x00402193
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

		// Token: 0x0601BC1C RID: 113692 RVA: 0x00403F9C File Offset: 0x0040219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UDPMovePackagePush);
		}

		// Token: 0x0601BC1D RID: 113693 RVA: 0x00403FAC File Offset: 0x004021AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UDPMovePackagePush other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC1E RID: 113694 RVA: 0x00403FFC File Offset: 0x004021FC
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

		// Token: 0x0601BC1F RID: 113695 RVA: 0x00404049 File Offset: 0x00402249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC20 RID: 113696 RVA: 0x00404056 File Offset: 0x00402256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC21 RID: 113697 RVA: 0x00404060 File Offset: 0x00402260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.movingEntities_.WriteTo(ref output, UDPMovePackagePush._repeated_movingEntities_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC22 RID: 113698 RVA: 0x004040B0 File Offset: 0x004022B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.movingEntities_.CalculateSize(UDPMovePackagePush._repeated_movingEntities_codec);
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

		// Token: 0x0601BC23 RID: 113699 RVA: 0x00404104 File Offset: 0x00402304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UDPMovePackagePush other)
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

		// Token: 0x0601BC24 RID: 113700 RVA: 0x00404151 File Offset: 0x00402351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC25 RID: 113701 RVA: 0x0040415C File Offset: 0x0040235C
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
					if (num != 16U)
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
					this.movingEntities_.AddEntriesFrom(ref input, UDPMovePackagePush._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x04009FCB RID: 40907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FCC RID: 40908
		public const int MovingEntitiesFieldNumber = 1;

		// Token: 0x04009FCD RID: 40909
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(10U, MovingEntityData.Parser);

		// Token: 0x04009FCE RID: 40910
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();

		// Token: 0x04009FCF RID: 40911
		public const int SceneOwnerIdFieldNumber = 2;

		// Token: 0x04009FD0 RID: 40912
		private int sceneOwnerId_;
	}
}
