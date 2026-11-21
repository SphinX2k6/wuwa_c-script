using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D81 RID: 3457
	[NetMessage(EMessageId.PlayerGravityUpdateNotify)]
	public sealed class PlayerGravityUpdateNotify : IMessage<PlayerGravityUpdateNotify>, IMessage, IEquatable<PlayerGravityUpdateNotify>, IDeepCloneable<PlayerGravityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012AA8 RID: 76456 RVA: 0x002BA049 File Offset: 0x002B8249
		[NullableContext(1)]
		public static PlayerGravityUpdateNotify Create()
		{
			return new PlayerGravityUpdateNotify();
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x06012AA9 RID: 76457 RVA: 0x002BA050 File Offset: 0x002B8250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x06012AAA RID: 76458 RVA: 0x002BA053 File Offset: 0x002B8253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGravityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012AAB RID: 76459 RVA: 0x002BA05A File Offset: 0x002B825A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify()
		{
		}

		// Token: 0x06012AAC RID: 76460 RVA: 0x002BA064 File Offset: 0x002B8264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify(PlayerGravityUpdateNotify other) : this()
		{
			this.preGravityDirection_ = ((other.preGravityDirection_ != null) ? other.preGravityDirection_.Clone() : null);
			this.curGravityDirection_ = ((other.curGravityDirection_ != null) ? other.curGravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AAD RID: 76461 RVA: 0x002BA0C0 File Offset: 0x002B82C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify Clone()
		{
			return new PlayerGravityUpdateNotify(this);
		}

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x06012AAE RID: 76462 RVA: 0x002BA0C8 File Offset: 0x002B82C8
		// (set) Token: 0x06012AAF RID: 76463 RVA: 0x002BA0D0 File Offset: 0x002B82D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PreGravityDirection
		{
			get
			{
				return this.preGravityDirection_;
			}
			set
			{
				this.preGravityDirection_ = value;
			}
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x06012AB0 RID: 76464 RVA: 0x002BA0D9 File Offset: 0x002B82D9
		// (set) Token: 0x06012AB1 RID: 76465 RVA: 0x002BA0E1 File Offset: 0x002B82E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector CurGravityDirection
		{
			get
			{
				return this.curGravityDirection_;
			}
			set
			{
				this.curGravityDirection_ = value;
			}
		}

		// Token: 0x06012AB2 RID: 76466 RVA: 0x002BA0EA File Offset: 0x002B82EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGravityUpdateNotify);
		}

		// Token: 0x06012AB3 RID: 76467 RVA: 0x002BA0F8 File Offset: 0x002B82F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGravityUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PreGravityDirection, other.PreGravityDirection) && object.Equals(this.CurGravityDirection, other.CurGravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AB4 RID: 76468 RVA: 0x002BA14C File Offset: 0x002B834C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.preGravityDirection_ != null)
			{
				num ^= this.PreGravityDirection.GetHashCode();
			}
			if (this.curGravityDirection_ != null)
			{
				num ^= this.CurGravityDirection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012AB5 RID: 76469 RVA: 0x002BA19E File Offset: 0x002B839E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AB6 RID: 76470 RVA: 0x002BA1AB File Offset: 0x002B83AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AB7 RID: 76471 RVA: 0x002BA1B4 File Offset: 0x002B83B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preGravityDirection_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PreGravityDirection);
			}
			if (this.curGravityDirection_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CurGravityDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012AB8 RID: 76472 RVA: 0x002BA210 File Offset: 0x002B8410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.preGravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreGravityDirection);
			}
			if (this.curGravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurGravityDirection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012AB9 RID: 76473 RVA: 0x002BA268 File Offset: 0x002B8468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGravityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.preGravityDirection_ != null)
			{
				if (this.preGravityDirection_ == null)
				{
					this.PreGravityDirection = new Vector();
				}
				this.PreGravityDirection.MergeFrom(other.PreGravityDirection);
			}
			if (other.curGravityDirection_ != null)
			{
				if (this.curGravityDirection_ == null)
				{
					this.CurGravityDirection = new Vector();
				}
				this.CurGravityDirection.MergeFrom(other.CurGravityDirection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012ABA RID: 76474 RVA: 0x002BA2E8 File Offset: 0x002B84E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x002BA2F4 File Offset: 0x002B84F4
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
				if (num != 114U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.curGravityDirection_ == null)
						{
							this.CurGravityDirection = new Vector();
						}
						input.ReadMessage(this.CurGravityDirection);
					}
				}
				else
				{
					if (this.preGravityDirection_ == null)
					{
						this.PreGravityDirection = new Vector();
					}
					input.ReadMessage(this.PreGravityDirection);
				}
			}
		}

		// Token: 0x04007444 RID: 29764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007445 RID: 29765
		public const int PreGravityDirectionFieldNumber = 14;

		// Token: 0x04007446 RID: 29766
		private Vector preGravityDirection_;

		// Token: 0x04007447 RID: 29767
		public const int CurGravityDirectionFieldNumber = 15;

		// Token: 0x04007448 RID: 29768
		private Vector curGravityDirection_;
	}
}
