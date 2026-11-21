using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007F RID: 127
	public sealed class ActiveBulletHandle : IMessage<ActiveBulletHandle>, IMessage, IEquatable<ActiveBulletHandle>, IDeepCloneable<ActiveBulletHandle>, IBufferMessage
	{
		// Token: 0x060018D6 RID: 6358 RVA: 0x00040E15 File Offset: 0x0003F015
		[NullableContext(1)]
		public static ActiveBulletHandle Create()
		{
			return new ActiveBulletHandle();
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00040E1C File Offset: 0x0003F01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00040E1F File Offset: 0x0003F01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveBulletHandle.Descriptor;
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00040E26 File Offset: 0x0003F026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle()
		{
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00040E2E File Offset: 0x0003F02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle(ActiveBulletHandle other) : this()
		{
			this.playerId_ = other.playerId_;
			this.handleId_ = other.handleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00040E5F File Offset: 0x0003F05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle Clone()
		{
			return new ActiveBulletHandle(this);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00040E67 File Offset: 0x0003F067
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00040E6F File Offset: 0x0003F06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00040E78 File Offset: 0x0003F078
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x00040E80 File Offset: 0x0003F080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00040E89 File Offset: 0x0003F089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveBulletHandle);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00040E97 File Offset: 0x0003F097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveBulletHandle other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.HandleId == other.HandleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00040F30 File Offset: 0x0003F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00040F3D File Offset: 0x0003F13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00040F48 File Offset: 0x0003F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00040FF8 File Offset: 0x0003F1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActiveBulletHandle other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00041048 File Offset: 0x0003F248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00041054 File Offset: 0x0003F254
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HandleId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040021E6 RID: 8678
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021E7 RID: 8679
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040021E8 RID: 8680
		private int playerId_;

		// Token: 0x040021E9 RID: 8681
		public const int HandleIdFieldNumber = 2;

		// Token: 0x040021EA RID: 8682
		private int handleId_;
	}
}
