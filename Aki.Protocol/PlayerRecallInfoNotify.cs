using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA6 RID: 3494
	[NetMessage(EMessageId.PlayerRecallInfoNotify)]
	public sealed class PlayerRecallInfoNotify : IMessage<PlayerRecallInfoNotify>, IMessage, IEquatable<PlayerRecallInfoNotify>, IDeepCloneable<PlayerRecallInfoNotify>, IBufferMessage
	{
		// Token: 0x06012D32 RID: 77106 RVA: 0x002BEC85 File Offset: 0x002BCE85
		[NullableContext(1)]
		public static PlayerRecallInfoNotify Create()
		{
			return new PlayerRecallInfoNotify();
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x06012D33 RID: 77107 RVA: 0x002BEC8C File Offset: 0x002BCE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x06012D34 RID: 77108 RVA: 0x002BEC8F File Offset: 0x002BCE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRecallInfoNotify.Descriptor;
			}
		}

		// Token: 0x06012D35 RID: 77109 RVA: 0x002BEC96 File Offset: 0x002BCE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify()
		{
		}

		// Token: 0x06012D36 RID: 77110 RVA: 0x002BEC9E File Offset: 0x002BCE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify(PlayerRecallInfoNotify other) : this()
		{
			this.curRecallId_ = other.curRecallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D37 RID: 77111 RVA: 0x002BECC3 File Offset: 0x002BCEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify Clone()
		{
			return new PlayerRecallInfoNotify(this);
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x06012D38 RID: 77112 RVA: 0x002BECCB File Offset: 0x002BCECB
		// (set) Token: 0x06012D39 RID: 77113 RVA: 0x002BECD3 File Offset: 0x002BCED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRecallId
		{
			get
			{
				return this.curRecallId_;
			}
			set
			{
				this.curRecallId_ = value;
			}
		}

		// Token: 0x06012D3A RID: 77114 RVA: 0x002BECDC File Offset: 0x002BCEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRecallInfoNotify);
		}

		// Token: 0x06012D3B RID: 77115 RVA: 0x002BECEA File Offset: 0x002BCEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRecallInfoNotify other)
		{
			return other != null && (other == this || (this.CurRecallId == other.CurRecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D3C RID: 77116 RVA: 0x002BED18 File Offset: 0x002BCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRecallId != 0)
			{
				num ^= this.CurRecallId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D3D RID: 77117 RVA: 0x002BED57 File Offset: 0x002BCF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D3E RID: 77118 RVA: 0x002BED64 File Offset: 0x002BCF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D3F RID: 77119 RVA: 0x002BED6D File Offset: 0x002BCF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRecallId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurRecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D40 RID: 77120 RVA: 0x002BEDA0 File Offset: 0x002BCFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRecallId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D41 RID: 77121 RVA: 0x002BEDDE File Offset: 0x002BCFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRecallInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRecallId != 0)
			{
				this.CurRecallId = other.CurRecallId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D42 RID: 77122 RVA: 0x002BEE0F File Offset: 0x002BD00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x002BEE18 File Offset: 0x002BD018
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurRecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007483 RID: 29827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007484 RID: 29828
		public const int CurRecallIdFieldNumber = 7;

		// Token: 0x04007485 RID: 29829
		private int curRecallId_;
	}
}
