using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C3 RID: 2499
	[NetMessage(EMessageId.MingSuHandRewardRequest)]
	public sealed class MingSuHandRewardRequest : IMessage<MingSuHandRewardRequest>, IMessage, IEquatable<MingSuHandRewardRequest>, IDeepCloneable<MingSuHandRewardRequest>, IBufferMessage
	{
		// Token: 0x0600DB89 RID: 56201 RVA: 0x002041FC File Offset: 0x002023FC
		[NullableContext(1)]
		public static MingSuHandRewardRequest Create()
		{
			return new MingSuHandRewardRequest();
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x00204203 File Offset: 0x00202403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0600DB8B RID: 56203 RVA: 0x00204206 File Offset: 0x00202406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuHandRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x0020420D File Offset: 0x0020240D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest()
		{
		}

		// Token: 0x0600DB8D RID: 56205 RVA: 0x00204215 File Offset: 0x00202415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest(MingSuHandRewardRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB8E RID: 56206 RVA: 0x00204246 File Offset: 0x00202446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardRequest Clone()
		{
			return new MingSuHandRewardRequest(this);
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600DB8F RID: 56207 RVA: 0x0020424E File Offset: 0x0020244E
		// (set) Token: 0x0600DB90 RID: 56208 RVA: 0x00204256 File Offset: 0x00202456
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

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600DB91 RID: 56209 RVA: 0x0020425F File Offset: 0x0020245F
		// (set) Token: 0x0600DB92 RID: 56210 RVA: 0x00204267 File Offset: 0x00202467
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

		// Token: 0x0600DB93 RID: 56211 RVA: 0x00204270 File Offset: 0x00202470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuHandRewardRequest);
		}

		// Token: 0x0600DB94 RID: 56212 RVA: 0x0020427E File Offset: 0x0020247E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuHandRewardRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB95 RID: 56213 RVA: 0x002042BC File Offset: 0x002024BC
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

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00204314 File Offset: 0x00202514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00204321 File Offset: 0x00202521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB98 RID: 56216 RVA: 0x0020432C File Offset: 0x0020252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(16);
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

		// Token: 0x0600DB99 RID: 56217 RVA: 0x00204388 File Offset: 0x00202588
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

		// Token: 0x0600DB9A RID: 56218 RVA: 0x002043E0 File Offset: 0x002025E0
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

		// Token: 0x0600DB9B RID: 56219 RVA: 0x00204430 File Offset: 0x00202630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB9C RID: 56220 RVA: 0x0020443C File Offset: 0x0020263C
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

		// Token: 0x04005B69 RID: 23401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B6A RID: 23402
		public const int DragonPoolIdFieldNumber = 2;

		// Token: 0x04005B6B RID: 23403
		private int dragonPoolId_;

		// Token: 0x04005B6C RID: 23404
		public const int InteractEntityIdFieldNumber = 12;

		// Token: 0x04005B6D RID: 23405
		private long interactEntityId_;
	}
}
