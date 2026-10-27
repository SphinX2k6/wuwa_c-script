using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC1 RID: 3521
	[NetMessage(EMessageId.PlayerXboxSessionNotify)]
	public sealed class PlayerXboxSessionNotify : IMessage<PlayerXboxSessionNotify>, IMessage, IEquatable<PlayerXboxSessionNotify>, IDeepCloneable<PlayerXboxSessionNotify>, IBufferMessage
	{
		// Token: 0x06012F67 RID: 77671 RVA: 0x002C3DA3 File Offset: 0x002C1FA3
		[NullableContext(1)]
		public static PlayerXboxSessionNotify Create()
		{
			return new PlayerXboxSessionNotify();
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x06012F68 RID: 77672 RVA: 0x002C3DAA File Offset: 0x002C1FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x06012F69 RID: 77673 RVA: 0x002C3DAD File Offset: 0x002C1FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxSessionNotify.Descriptor;
			}
		}

		// Token: 0x06012F6A RID: 77674 RVA: 0x002C3DB4 File Offset: 0x002C1FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify()
		{
		}

		// Token: 0x06012F6B RID: 77675 RVA: 0x002C3DC7 File Offset: 0x002C1FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify(PlayerXboxSessionNotify other) : this()
		{
			this.xboxSessionId_ = other.xboxSessionId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F6C RID: 77676 RVA: 0x002C3DF8 File Offset: 0x002C1FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify Clone()
		{
			return new PlayerXboxSessionNotify(this);
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x06012F6D RID: 77677 RVA: 0x002C3E00 File Offset: 0x002C2000
		// (set) Token: 0x06012F6E RID: 77678 RVA: 0x002C3E08 File Offset: 0x002C2008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxSessionId
		{
			get
			{
				return this.xboxSessionId_;
			}
			set
			{
				this.xboxSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x06012F6F RID: 77679 RVA: 0x002C3E1B File Offset: 0x002C201B
		// (set) Token: 0x06012F70 RID: 77680 RVA: 0x002C3E23 File Offset: 0x002C2023
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

		// Token: 0x06012F71 RID: 77681 RVA: 0x002C3E2C File Offset: 0x002C202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxSessionNotify);
		}

		// Token: 0x06012F72 RID: 77682 RVA: 0x002C3E3C File Offset: 0x002C203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxSessionNotify other)
		{
			return other != null && (other == this || (!(this.XboxSessionId != other.XboxSessionId) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F73 RID: 77683 RVA: 0x002C3E8C File Offset: 0x002C208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.XboxSessionId.Length != 0)
			{
				num ^= this.XboxSessionId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F74 RID: 77684 RVA: 0x002C3EE6 File Offset: 0x002C20E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F75 RID: 77685 RVA: 0x002C3EF3 File Offset: 0x002C20F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F76 RID: 77686 RVA: 0x002C3EFC File Offset: 0x002C20FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxSessionId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.XboxSessionId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F77 RID: 77687 RVA: 0x002C3F5C File Offset: 0x002C215C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.XboxSessionId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxSessionId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F78 RID: 77688 RVA: 0x002C3FB8 File Offset: 0x002C21B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxSessionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.XboxSessionId.Length != 0)
			{
				this.XboxSessionId = other.XboxSessionId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F79 RID: 77689 RVA: 0x002C400D File Offset: 0x002C220D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F7A RID: 77690 RVA: 0x002C4018 File Offset: 0x002C2218
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.XboxSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x0400753A RID: 30010
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400753B RID: 30011
		public const int XboxSessionIdFieldNumber = 4;

		// Token: 0x0400753C RID: 30012
		private string xboxSessionId_ = "";

		// Token: 0x0400753D RID: 30013
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x0400753E RID: 30014
		private int playerId_;
	}
}
