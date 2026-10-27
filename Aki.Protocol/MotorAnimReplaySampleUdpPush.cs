using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1F RID: 2591
	[NetMessage(EMessageId.MotorAnimReplaySampleUdpPush)]
	public sealed class MotorAnimReplaySampleUdpPush : IMessage<MotorAnimReplaySampleUdpPush>, IMessage, IEquatable<MotorAnimReplaySampleUdpPush>, IDeepCloneable<MotorAnimReplaySampleUdpPush>, IBufferMessage
	{
		// Token: 0x0600E299 RID: 58009 RVA: 0x0021300D File Offset: 0x0021120D
		[NullableContext(1)]
		public static MotorAnimReplaySampleUdpPush Create()
		{
			return new MotorAnimReplaySampleUdpPush();
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00213014 File Offset: 0x00211214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600E29B RID: 58011 RVA: 0x00213017 File Offset: 0x00211217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimReplaySampleUdpPush.Descriptor;
			}
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x0021301E File Offset: 0x0021121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush()
		{
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x00213031 File Offset: 0x00211231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush(MotorAnimReplaySampleUdpPush other) : this()
		{
			this.motorAnimEntities_ = other.motorAnimEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x00213067 File Offset: 0x00211267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush Clone()
		{
			return new MotorAnimReplaySampleUdpPush(this);
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600E29F RID: 58015 RVA: 0x0021306F File Offset: 0x0021126F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimEntity> MotorAnimEntities
		{
			get
			{
				return this.motorAnimEntities_;
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600E2A0 RID: 58016 RVA: 0x00213077 File Offset: 0x00211277
		// (set) Token: 0x0600E2A1 RID: 58017 RVA: 0x0021307F File Offset: 0x0021127F
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

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x00213088 File Offset: 0x00211288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimReplaySampleUdpPush);
		}

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x00213098 File Offset: 0x00211298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimReplaySampleUdpPush other)
		{
			return other != null && (other == this || (this.motorAnimEntities_.Equals(other.motorAnimEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x002130E8 File Offset: 0x002112E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorAnimEntities_.GetHashCode();
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

		// Token: 0x0600E2A5 RID: 58021 RVA: 0x00213135 File Offset: 0x00211335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2A6 RID: 58022 RVA: 0x00213142 File Offset: 0x00211342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2A7 RID: 58023 RVA: 0x0021314C File Offset: 0x0021134C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorAnimEntities_.WriteTo(ref output, MotorAnimReplaySampleUdpPush._repeated_motorAnimEntities_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2A8 RID: 58024 RVA: 0x0021319C File Offset: 0x0021139C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorAnimEntities_.CalculateSize(MotorAnimReplaySampleUdpPush._repeated_motorAnimEntities_codec);
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

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x002131F0 File Offset: 0x002113F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimReplaySampleUdpPush other)
		{
			if (other == null)
			{
				return;
			}
			this.motorAnimEntities_.Add(other.motorAnimEntities_);
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x0021323D File Offset: 0x0021143D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00213248 File Offset: 0x00211448
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
					if (num != 56U)
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
					this.motorAnimEntities_.AddEntriesFrom(ref input, MotorAnimReplaySampleUdpPush._repeated_motorAnimEntities_codec);
				}
			}
		}

		// Token: 0x04005D06 RID: 23814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D07 RID: 23815
		public const int MotorAnimEntitiesFieldNumber = 4;

		// Token: 0x04005D08 RID: 23816
		private static readonly FieldCodec<MotorAnimEntity> _repeated_motorAnimEntities_codec = FieldCodec.ForMessage<MotorAnimEntity>(34U, MotorAnimEntity.Parser);

		// Token: 0x04005D09 RID: 23817
		private readonly RepeatedField<MotorAnimEntity> motorAnimEntities_ = new RepeatedField<MotorAnimEntity>();

		// Token: 0x04005D0A RID: 23818
		public const int SceneOwnerIdFieldNumber = 7;

		// Token: 0x04005D0B RID: 23819
		private int sceneOwnerId_;
	}
}
