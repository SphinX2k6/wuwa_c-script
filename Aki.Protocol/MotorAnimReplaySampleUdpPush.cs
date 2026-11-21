using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0E RID: 2574
	[NetMessage(EMessageId.MotorAnimReplaySampleUdpPush)]
	public sealed class MotorAnimReplaySampleUdpPush : IMessage<MotorAnimReplaySampleUdpPush>, IMessage, IEquatable<MotorAnimReplaySampleUdpPush>, IDeepCloneable<MotorAnimReplaySampleUdpPush>, IBufferMessage
	{
		// Token: 0x0600E17F RID: 57727 RVA: 0x00210E19 File Offset: 0x0020F019
		[NullableContext(1)]
		public static MotorAnimReplaySampleUdpPush Create()
		{
			return new MotorAnimReplaySampleUdpPush();
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600E180 RID: 57728 RVA: 0x00210E20 File Offset: 0x0020F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600E181 RID: 57729 RVA: 0x00210E23 File Offset: 0x0020F023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimReplaySampleUdpPush.Descriptor;
			}
		}

		// Token: 0x0600E182 RID: 57730 RVA: 0x00210E2A File Offset: 0x0020F02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush()
		{
		}

		// Token: 0x0600E183 RID: 57731 RVA: 0x00210E3D File Offset: 0x0020F03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush(MotorAnimReplaySampleUdpPush other) : this()
		{
			this.motorAnimEntities_ = other.motorAnimEntities_.Clone();
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E184 RID: 57732 RVA: 0x00210E73 File Offset: 0x0020F073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpPush Clone()
		{
			return new MotorAnimReplaySampleUdpPush(this);
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00210E7B File Offset: 0x0020F07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimEntity> MotorAnimEntities
		{
			get
			{
				return this.motorAnimEntities_;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600E186 RID: 57734 RVA: 0x00210E83 File Offset: 0x0020F083
		// (set) Token: 0x0600E187 RID: 57735 RVA: 0x00210E8B File Offset: 0x0020F08B
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

		// Token: 0x0600E188 RID: 57736 RVA: 0x00210E94 File Offset: 0x0020F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimReplaySampleUdpPush);
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x00210EA4 File Offset: 0x0020F0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimReplaySampleUdpPush other)
		{
			return other != null && (other == this || (this.motorAnimEntities_.Equals(other.motorAnimEntities_) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E18A RID: 57738 RVA: 0x00210EF4 File Offset: 0x0020F0F4
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

		// Token: 0x0600E18B RID: 57739 RVA: 0x00210F41 File Offset: 0x0020F141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x00210F4E File Offset: 0x0020F14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x00210F58 File Offset: 0x0020F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SceneOwnerId);
			}
			this.motorAnimEntities_.WriteTo(ref output, MotorAnimReplaySampleUdpPush._repeated_motorAnimEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E18E RID: 57742 RVA: 0x00210FA8 File Offset: 0x0020F1A8
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

		// Token: 0x0600E18F RID: 57743 RVA: 0x00210FFC File Offset: 0x0020F1FC
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

		// Token: 0x0600E190 RID: 57744 RVA: 0x00211049 File Offset: 0x0020F249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x00211054 File Offset: 0x0020F254
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
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motorAnimEntities_.AddEntriesFrom(ref input, MotorAnimReplaySampleUdpPush._repeated_motorAnimEntities_codec);
					}
				}
				else
				{
					this.SceneOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D0F RID: 23823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D10 RID: 23824
		public const int MotorAnimEntitiesFieldNumber = 13;

		// Token: 0x04005D11 RID: 23825
		private static readonly FieldCodec<MotorAnimEntity> _repeated_motorAnimEntities_codec = FieldCodec.ForMessage<MotorAnimEntity>(106U, MotorAnimEntity.Parser);

		// Token: 0x04005D12 RID: 23826
		private readonly RepeatedField<MotorAnimEntity> motorAnimEntities_ = new RepeatedField<MotorAnimEntity>();

		// Token: 0x04005D13 RID: 23827
		public const int SceneOwnerIdFieldNumber = 11;

		// Token: 0x04005D14 RID: 23828
		private int sceneOwnerId_;
	}
}
