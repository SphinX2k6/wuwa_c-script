using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D4 RID: 2516
	[NetMessage(EMessageId.MingSuHandRewardRequest)]
	public sealed class MingSuHandRewardRequest : IMessage<MingSuHandRewardRequest>, IMessage, IEquatable<MingSuHandRewardRequest>, IDeepCloneable<MingSuHandRewardRequest>, IBufferMessage
	{
		// Token: 0x0600DCA3 RID: 56483 RVA: 0x002063EC File Offset: 0x002045EC
		[NullableContext(1)]
		public static MingSuHandRewardRequest Create()
		{
			return new MingSuHandRewardRequest();
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x002063F3 File Offset: 0x002045F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600DCA5 RID: 56485 RVA: 0x002063F6 File Offset: 0x002045F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuHandRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x002063FD File Offset: 0x002045FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest()
		{
		}

		// Token: 0x0600DCA7 RID: 56487 RVA: 0x00206405 File Offset: 0x00204605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest(MingSuHandRewardRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCA8 RID: 56488 RVA: 0x00206436 File Offset: 0x00204636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest Clone()
		{
			return new MingSuHandRewardRequest(this);
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0600DCA9 RID: 56489 RVA: 0x0020643E File Offset: 0x0020463E
		// (set) Token: 0x0600DCAA RID: 56490 RVA: 0x00206446 File Offset: 0x00204646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0600DCAB RID: 56491 RVA: 0x0020644F File Offset: 0x0020464F
		// (set) Token: 0x0600DCAC RID: 56492 RVA: 0x00206457 File Offset: 0x00204657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x0600DCAD RID: 56493 RVA: 0x00206460 File Offset: 0x00204660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuHandRewardRequest);
		}

		// Token: 0x0600DCAE RID: 56494 RVA: 0x0020646E File Offset: 0x0020466E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuHandRewardRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCAF RID: 56495 RVA: 0x002064AC File Offset: 0x002046AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x00206504 File Offset: 0x00204704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCB1 RID: 56497 RVA: 0x00206511 File Offset: 0x00204711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCB2 RID: 56498 RVA: 0x0020651C File Offset: 0x0020471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x00206578 File Offset: 0x00204778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x002065D0 File Offset: 0x002047D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MingSuHandRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCB5 RID: 56501 RVA: 0x00206620 File Offset: 0x00204820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCB6 RID: 56502 RVA: 0x0020662C File Offset: 0x0020482C
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
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B60 RID: 23392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B61 RID: 23393
		public const int DragonPoolIdFieldNumber = 7;

		// Token: 0x04005B62 RID: 23394
		private int dragonPoolId_;

		// Token: 0x04005B63 RID: 23395
		public const int InteractEntityIdFieldNumber = 12;

		// Token: 0x04005B64 RID: 23396
		private long interactEntityId_;
	}
}
