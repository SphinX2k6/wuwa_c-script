using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB1 RID: 3505
	[NetMessage(EMessageId.PlayerXboxSessionNotify)]
	public sealed class PlayerXboxSessionNotify : IMessage<PlayerXboxSessionNotify>, IMessage, IEquatable<PlayerXboxSessionNotify>, IDeepCloneable<PlayerXboxSessionNotify>, IBufferMessage
	{
		// Token: 0x06012E6B RID: 77419 RVA: 0x002C217F File Offset: 0x002C037F
		[NullableContext(1)]
		public static PlayerXboxSessionNotify Create()
		{
			return new PlayerXboxSessionNotify();
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x06012E6C RID: 77420 RVA: 0x002C2186 File Offset: 0x002C0386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06012E6D RID: 77421 RVA: 0x002C2189 File Offset: 0x002C0389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxSessionNotify.Descriptor;
			}
		}

		// Token: 0x06012E6E RID: 77422 RVA: 0x002C2190 File Offset: 0x002C0390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify()
		{
		}

		// Token: 0x06012E6F RID: 77423 RVA: 0x002C21A3 File Offset: 0x002C03A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify(PlayerXboxSessionNotify other) : this()
		{
			this.xboxSessionId_ = other.xboxSessionId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E70 RID: 77424 RVA: 0x002C21D4 File Offset: 0x002C03D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxSessionNotify Clone()
		{
			return new PlayerXboxSessionNotify(this);
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06012E71 RID: 77425 RVA: 0x002C21DC File Offset: 0x002C03DC
		// (set) Token: 0x06012E72 RID: 77426 RVA: 0x002C21E4 File Offset: 0x002C03E4
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

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06012E73 RID: 77427 RVA: 0x002C21F7 File Offset: 0x002C03F7
		// (set) Token: 0x06012E74 RID: 77428 RVA: 0x002C21FF File Offset: 0x002C03FF
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

		// Token: 0x06012E75 RID: 77429 RVA: 0x002C2208 File Offset: 0x002C0408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxSessionNotify);
		}

		// Token: 0x06012E76 RID: 77430 RVA: 0x002C2218 File Offset: 0x002C0418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxSessionNotify other)
		{
			return other != null && (other == this || (!(this.XboxSessionId != other.XboxSessionId) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E77 RID: 77431 RVA: 0x002C2268 File Offset: 0x002C0468
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

		// Token: 0x06012E78 RID: 77432 RVA: 0x002C22C2 File Offset: 0x002C04C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E79 RID: 77433 RVA: 0x002C22CF File Offset: 0x002C04CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E7A RID: 77434 RVA: 0x002C22D8 File Offset: 0x002C04D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.XboxSessionId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.XboxSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E7B RID: 77435 RVA: 0x002C2338 File Offset: 0x002C0538
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

		// Token: 0x06012E7C RID: 77436 RVA: 0x002C2394 File Offset: 0x002C0594
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

		// Token: 0x06012E7D RID: 77437 RVA: 0x002C23E9 File Offset: 0x002C05E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E7E RID: 77438 RVA: 0x002C23F4 File Offset: 0x002C05F4
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.XboxSessionId = input.ReadString();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007552 RID: 30034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007553 RID: 30035
		public const int XboxSessionIdFieldNumber = 10;

		// Token: 0x04007554 RID: 30036
		private string xboxSessionId_ = "";

		// Token: 0x04007555 RID: 30037
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007556 RID: 30038
		private int playerId_;
	}
}
