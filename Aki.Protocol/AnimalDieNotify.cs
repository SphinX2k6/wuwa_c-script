using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E4 RID: 228
	[NetMessage(EMessageId.AnimalDieNotify)]
	public sealed class AnimalDieNotify : IMessage<AnimalDieNotify>, IMessage, IEquatable<AnimalDieNotify>, IDeepCloneable<AnimalDieNotify>, IBufferMessage
	{
		// Token: 0x060021BF RID: 8639 RVA: 0x0005A5EC File Offset: 0x000587EC
		[NullableContext(1)]
		public static AnimalDieNotify Create()
		{
			return new AnimalDieNotify();
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x0005A5F3 File Offset: 0x000587F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0005A5F6 File Offset: 0x000587F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieNotify.Descriptor;
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0005A5FD File Offset: 0x000587FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify()
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0005A605 File Offset: 0x00058805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify(AnimalDieNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0005A636 File Offset: 0x00058836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieNotify Clone()
		{
			return new AnimalDieNotify(this);
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x0005A63E File Offset: 0x0005883E
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0005A646 File Offset: 0x00058846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0005A64F File Offset: 0x0005884F
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x0005A657 File Offset: 0x00058857
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

		// Token: 0x060021C9 RID: 8649 RVA: 0x0005A660 File Offset: 0x00058860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieNotify);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0005A66E File Offset: 0x0005886E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0005A6AC File Offset: 0x000588AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x060021CC RID: 8652 RVA: 0x0005A704 File Offset: 0x00058904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0005A711 File Offset: 0x00058911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0005A71C File Offset: 0x0005891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0005A778 File Offset: 0x00058978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x060021D0 RID: 8656 RVA: 0x0005A7D0 File Offset: 0x000589D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0005A820 File Offset: 0x00058A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0005A82C File Offset: 0x00058A2C
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
				if (num != 40U)
				{
					if (num != 72U)
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040024A0 RID: 9376
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024A1 RID: 9377
		public const int EntityIdFieldNumber = 5;

		// Token: 0x040024A2 RID: 9378
		private long entityId_;

		// Token: 0x040024A3 RID: 9379
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x040024A4 RID: 9380
		private int playerId_;
	}
}
