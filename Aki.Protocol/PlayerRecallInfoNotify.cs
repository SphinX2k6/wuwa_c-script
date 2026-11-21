using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D96 RID: 3478
	[NetMessage(EMessageId.PlayerRecallInfoNotify)]
	public sealed class PlayerRecallInfoNotify : IMessage<PlayerRecallInfoNotify>, IMessage, IEquatable<PlayerRecallInfoNotify>, IDeepCloneable<PlayerRecallInfoNotify>, IBufferMessage
	{
		// Token: 0x06012C36 RID: 76854 RVA: 0x002BD061 File Offset: 0x002BB261
		[NullableContext(1)]
		public static PlayerRecallInfoNotify Create()
		{
			return new PlayerRecallInfoNotify();
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x06012C37 RID: 76855 RVA: 0x002BD068 File Offset: 0x002BB268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x06012C38 RID: 76856 RVA: 0x002BD06B File Offset: 0x002BB26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRecallInfoNotify.Descriptor;
			}
		}

		// Token: 0x06012C39 RID: 76857 RVA: 0x002BD072 File Offset: 0x002BB272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify()
		{
		}

		// Token: 0x06012C3A RID: 76858 RVA: 0x002BD07A File Offset: 0x002BB27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify(PlayerRecallInfoNotify other) : this()
		{
			this.curRecallId_ = other.curRecallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C3B RID: 76859 RVA: 0x002BD09F File Offset: 0x002BB29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRecallInfoNotify Clone()
		{
			return new PlayerRecallInfoNotify(this);
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x06012C3C RID: 76860 RVA: 0x002BD0A7 File Offset: 0x002BB2A7
		// (set) Token: 0x06012C3D RID: 76861 RVA: 0x002BD0AF File Offset: 0x002BB2AF
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

		// Token: 0x06012C3E RID: 76862 RVA: 0x002BD0B8 File Offset: 0x002BB2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRecallInfoNotify);
		}

		// Token: 0x06012C3F RID: 76863 RVA: 0x002BD0C6 File Offset: 0x002BB2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRecallInfoNotify other)
		{
			return other != null && (other == this || (this.CurRecallId == other.CurRecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C40 RID: 76864 RVA: 0x002BD0F4 File Offset: 0x002BB2F4
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

		// Token: 0x06012C41 RID: 76865 RVA: 0x002BD133 File Offset: 0x002BB333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C42 RID: 76866 RVA: 0x002BD140 File Offset: 0x002BB340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C43 RID: 76867 RVA: 0x002BD149 File Offset: 0x002BB349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRecallId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurRecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C44 RID: 76868 RVA: 0x002BD17C File Offset: 0x002BB37C
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

		// Token: 0x06012C45 RID: 76869 RVA: 0x002BD1BA File Offset: 0x002BB3BA
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

		// Token: 0x06012C46 RID: 76870 RVA: 0x002BD1EB File Offset: 0x002BB3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C47 RID: 76871 RVA: 0x002BD1F4 File Offset: 0x002BB3F4
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
					this.CurRecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400749B RID: 29851
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400749C RID: 29852
		public const int CurRecallIdFieldNumber = 6;

		// Token: 0x0400749D RID: 29853
		private int curRecallId_;
	}
}
