using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EF RID: 5359
	[NetMessage(EMessageId.UDPMovePackagePush)]
	public sealed class UDPMovePackagePush : IMessage<UDPMovePackagePush>, IMessage, IEquatable<UDPMovePackagePush>, IDeepCloneable<UDPMovePackagePush>, IBufferMessage
	{
		// Token: 0x0601C69E RID: 116382 RVA: 0x0041F1E5 File Offset: 0x0041D3E5
		[NullableContext(1)]
		public static UDPMovePackagePush Create()
		{
			return new UDPMovePackagePush();
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x0601C69F RID: 116383 RVA: 0x0041F1EC File Offset: 0x0041D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x0601C6A0 RID: 116384 RVA: 0x0041F1EF File Offset: 0x0041D3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UDPMovePackagePush.Descriptor;
			}
		}

		// Token: 0x0601C6A1 RID: 116385 RVA: 0x0041F1F6 File Offset: 0x0041D3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush()
		{
		}

		// Token: 0x0601C6A2 RID: 116386 RVA: 0x0041F209 File Offset: 0x0041D409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush(UDPMovePackagePush other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6A3 RID: 116387 RVA: 0x0041F23F File Offset: 0x0041D43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackagePush Clone()
		{
			return new UDPMovePackagePush(this);
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x0601C6A4 RID: 116388 RVA: 0x0041F247 File Offset: 0x0041D447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x0601C6A5 RID: 116389 RVA: 0x0041F24F File Offset: 0x0041D44F
		// (set) Token: 0x0601C6A6 RID: 116390 RVA: 0x0041F257 File Offset: 0x0041D457
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

		// Token: 0x0601C6A7 RID: 116391 RVA: 0x0041F260 File Offset: 0x0041D460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UDPMovePackagePush);
		}

		// Token: 0x0601C6A8 RID: 116392 RVA: 0x0041F270 File Offset: 0x0041D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UDPMovePackagePush other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6A9 RID: 116393 RVA: 0x0041F2C0 File Offset: 0x0041D4C0
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

		// Token: 0x0601C6AA RID: 116394 RVA: 0x0041F30D File Offset: 0x0041D50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6AB RID: 116395 RVA: 0x0041F31A File Offset: 0x0041D51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6AC RID: 116396 RVA: 0x0041F324 File Offset: 0x0041D524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SceneOwnerId);
			}
			this.movingEntities_.WriteTo(ref output, UDPMovePackagePush._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6AD RID: 116397 RVA: 0x0041F374 File Offset: 0x0041D574
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

		// Token: 0x0601C6AE RID: 116398 RVA: 0x0041F3C8 File Offset: 0x0041D5C8
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

		// Token: 0x0601C6AF RID: 116399 RVA: 0x0041F415 File Offset: 0x0041D615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6B0 RID: 116400 RVA: 0x0041F420 File Offset: 0x0041D620
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
				if (num != 48U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.movingEntities_.AddEntriesFrom(ref input, UDPMovePackagePush._repeated_movingEntities_codec);
					}
				}
				else
				{
					this.SceneOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A412 RID: 42002
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A413 RID: 42003
		public const int MovingEntitiesFieldNumber = 15;

		// Token: 0x0400A414 RID: 42004
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(122U, MovingEntityData.Parser);

		// Token: 0x0400A415 RID: 42005
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();

		// Token: 0x0400A416 RID: 42006
		public const int SceneOwnerIdFieldNumber = 6;

		// Token: 0x0400A417 RID: 42007
		private int sceneOwnerId_;
	}
}
