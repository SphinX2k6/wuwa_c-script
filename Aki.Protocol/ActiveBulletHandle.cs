using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007E RID: 126
	public sealed class ActiveBulletHandle : IMessage<ActiveBulletHandle>, IMessage, IEquatable<ActiveBulletHandle>, IDeepCloneable<ActiveBulletHandle>, IBufferMessage
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00040465 File Offset: 0x0003E665
		[NullableContext(1)]
		public static ActiveBulletHandle Create()
		{
			return new ActiveBulletHandle();
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0004046C File Offset: 0x0003E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0004046F File Offset: 0x0003E66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveBulletHandle.Descriptor;
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00040476 File Offset: 0x0003E676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle()
		{
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0004047E File Offset: 0x0003E67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle(ActiveBulletHandle other) : this()
		{
			this.playerId_ = other.playerId_;
			this.handleId_ = other.handleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000404AF File Offset: 0x0003E6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle Clone()
		{
			return new ActiveBulletHandle(this);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x000404B7 File Offset: 0x0003E6B7
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x000404BF File Offset: 0x0003E6BF
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x000404C8 File Offset: 0x0003E6C8
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x000404D0 File Offset: 0x0003E6D0
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

		// Token: 0x0600189D RID: 6301 RVA: 0x000404D9 File Offset: 0x0003E6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveBulletHandle);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000404E7 File Offset: 0x0003E6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveBulletHandle other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.HandleId == other.HandleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00040528 File Offset: 0x0003E728
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

		// Token: 0x060018A0 RID: 6304 RVA: 0x00040580 File Offset: 0x0003E780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0004058D File Offset: 0x0003E78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00040598 File Offset: 0x0003E798
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

		// Token: 0x060018A3 RID: 6307 RVA: 0x000405F0 File Offset: 0x0003E7F0
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

		// Token: 0x060018A4 RID: 6308 RVA: 0x00040648 File Offset: 0x0003E848
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

		// Token: 0x060018A5 RID: 6309 RVA: 0x00040698 File Offset: 0x0003E898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000406A4 File Offset: 0x0003E8A4
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

		// Token: 0x04002187 RID: 8583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002188 RID: 8584
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002189 RID: 8585
		private int playerId_;

		// Token: 0x0400218A RID: 8586
		public const int HandleIdFieldNumber = 2;

		// Token: 0x0400218B RID: 8587
		private int handleId_;
	}
}
