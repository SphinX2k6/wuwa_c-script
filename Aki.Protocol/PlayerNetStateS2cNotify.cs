using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9F RID: 3487
	[NetMessage(EMessageId.PlayerNetStateS2cNotify)]
	public sealed class PlayerNetStateS2cNotify : IMessage<PlayerNetStateS2cNotify>, IMessage, IEquatable<PlayerNetStateS2cNotify>, IDeepCloneable<PlayerNetStateS2cNotify>, IBufferMessage
	{
		// Token: 0x06012CB2 RID: 76978 RVA: 0x002BDDF5 File Offset: 0x002BBFF5
		[NullableContext(1)]
		public static PlayerNetStateS2cNotify Create()
		{
			return new PlayerNetStateS2cNotify();
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x06012CB3 RID: 76979 RVA: 0x002BDDFC File Offset: 0x002BBFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x06012CB4 RID: 76980 RVA: 0x002BDDFF File Offset: 0x002BBFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateS2cNotify.Descriptor;
			}
		}

		// Token: 0x06012CB5 RID: 76981 RVA: 0x002BDE06 File Offset: 0x002BC006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify()
		{
		}

		// Token: 0x06012CB6 RID: 76982 RVA: 0x002BDE0E File Offset: 0x002BC00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify(PlayerNetStateS2cNotify other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CB7 RID: 76983 RVA: 0x002BDE33 File Offset: 0x002BC033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify Clone()
		{
			return new PlayerNetStateS2cNotify(this);
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x06012CB8 RID: 76984 RVA: 0x002BDE3B File Offset: 0x002BC03B
		// (set) Token: 0x06012CB9 RID: 76985 RVA: 0x002BDE43 File Offset: 0x002BC043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x06012CBA RID: 76986 RVA: 0x002BDE4C File Offset: 0x002BC04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateS2cNotify);
		}

		// Token: 0x06012CBB RID: 76987 RVA: 0x002BDE5A File Offset: 0x002BC05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateS2cNotify other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x002BDE88 File Offset: 0x002BC088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0L)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CBD RID: 76989 RVA: 0x002BDEC7 File Offset: 0x002BC0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CBE RID: 76990 RVA: 0x002BDED4 File Offset: 0x002BC0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CBF RID: 76991 RVA: 0x002BDEDD File Offset: 0x002BC0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CC0 RID: 76992 RVA: 0x002BDF10 File Offset: 0x002BC110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CC1 RID: 76993 RVA: 0x002BDF4E File Offset: 0x002BC14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStateS2cNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0L)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CC2 RID: 76994 RVA: 0x002BDF7F File Offset: 0x002BC17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CC3 RID: 76995 RVA: 0x002BDF88 File Offset: 0x002BC188
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400746B RID: 29803
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400746C RID: 29804
		public const int UidFieldNumber = 6;

		// Token: 0x0400746D RID: 29805
		private long uid_;
	}
}
