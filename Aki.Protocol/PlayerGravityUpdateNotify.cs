using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D91 RID: 3473
	[NetMessage(EMessageId.PlayerGravityUpdateNotify)]
	public sealed class PlayerGravityUpdateNotify : IMessage<PlayerGravityUpdateNotify>, IMessage, IEquatable<PlayerGravityUpdateNotify>, IDeepCloneable<PlayerGravityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012BA4 RID: 76708 RVA: 0x002BBC6D File Offset: 0x002B9E6D
		[NullableContext(1)]
		public static PlayerGravityUpdateNotify Create()
		{
			return new PlayerGravityUpdateNotify();
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x06012BA5 RID: 76709 RVA: 0x002BBC74 File Offset: 0x002B9E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x06012BA6 RID: 76710 RVA: 0x002BBC77 File Offset: 0x002B9E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGravityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012BA7 RID: 76711 RVA: 0x002BBC7E File Offset: 0x002B9E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify()
		{
		}

		// Token: 0x06012BA8 RID: 76712 RVA: 0x002BBC88 File Offset: 0x002B9E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify(PlayerGravityUpdateNotify other) : this()
		{
			this.preGravityDirection_ = ((other.preGravityDirection_ != null) ? other.preGravityDirection_.Clone() : null);
			this.curGravityDirection_ = ((other.curGravityDirection_ != null) ? other.curGravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x002BBCE4 File Offset: 0x002B9EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGravityUpdateNotify Clone()
		{
			return new PlayerGravityUpdateNotify(this);
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x06012BAA RID: 76714 RVA: 0x002BBCEC File Offset: 0x002B9EEC
		// (set) Token: 0x06012BAB RID: 76715 RVA: 0x002BBCF4 File Offset: 0x002B9EF4
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

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x06012BAC RID: 76716 RVA: 0x002BBCFD File Offset: 0x002B9EFD
		// (set) Token: 0x06012BAD RID: 76717 RVA: 0x002BBD05 File Offset: 0x002B9F05
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

		// Token: 0x06012BAE RID: 76718 RVA: 0x002BBD0E File Offset: 0x002B9F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGravityUpdateNotify);
		}

		// Token: 0x06012BAF RID: 76719 RVA: 0x002BBD1C File Offset: 0x002B9F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGravityUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PreGravityDirection, other.PreGravityDirection) && object.Equals(this.CurGravityDirection, other.CurGravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BB0 RID: 76720 RVA: 0x002BBD70 File Offset: 0x002B9F70
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

		// Token: 0x06012BB1 RID: 76721 RVA: 0x002BBDC2 File Offset: 0x002B9FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BB2 RID: 76722 RVA: 0x002BBDCF File Offset: 0x002B9FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BB3 RID: 76723 RVA: 0x002BBDD8 File Offset: 0x002B9FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curGravityDirection_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CurGravityDirection);
			}
			if (this.preGravityDirection_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PreGravityDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BB4 RID: 76724 RVA: 0x002BBE34 File Offset: 0x002BA034
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

		// Token: 0x06012BB5 RID: 76725 RVA: 0x002BBE8C File Offset: 0x002BA08C
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

		// Token: 0x06012BB6 RID: 76726 RVA: 0x002BBF0C File Offset: 0x002BA10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BB7 RID: 76727 RVA: 0x002BBF18 File Offset: 0x002BA118
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
				if (num != 66U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					if (this.curGravityDirection_ == null)
					{
						this.CurGravityDirection = new Vector();
					}
					input.ReadMessage(this.CurGravityDirection);
				}
			}
		}

		// Token: 0x0400742C RID: 29740
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400742D RID: 29741
		public const int PreGravityDirectionFieldNumber = 9;

		// Token: 0x0400742E RID: 29742
		private Vector preGravityDirection_;

		// Token: 0x0400742F RID: 29743
		public const int CurGravityDirectionFieldNumber = 8;

		// Token: 0x04007430 RID: 29744
		private Vector curGravityDirection_;
	}
}
