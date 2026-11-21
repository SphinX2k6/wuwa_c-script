using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AD RID: 4525
	[NetMessage(EMessageId.SceneItemSetPosSenderNotify)]
	public sealed class SceneItemSetPosSenderNotify : IMessage<SceneItemSetPosSenderNotify>, IMessage, IEquatable<SceneItemSetPosSenderNotify>, IDeepCloneable<SceneItemSetPosSenderNotify>, IBufferMessage
	{
		// Token: 0x060182A6 RID: 98982 RVA: 0x00384C18 File Offset: 0x00382E18
		[NullableContext(1)]
		public static SceneItemSetPosSenderNotify Create()
		{
			return new SceneItemSetPosSenderNotify();
		}

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x060182A7 RID: 98983 RVA: 0x00384C1F File Offset: 0x00382E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x060182A8 RID: 98984 RVA: 0x00384C22 File Offset: 0x00382E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderNotify.Descriptor;
			}
		}

		// Token: 0x060182A9 RID: 98985 RVA: 0x00384C29 File Offset: 0x00382E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify()
		{
		}

		// Token: 0x060182AA RID: 98986 RVA: 0x00384C31 File Offset: 0x00382E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify(SceneItemSetPosSenderNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.posSender_ = other.posSender_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182AB RID: 98987 RVA: 0x00384C62 File Offset: 0x00382E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify Clone()
		{
			return new SceneItemSetPosSenderNotify(this);
		}

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x060182AC RID: 98988 RVA: 0x00384C6A File Offset: 0x00382E6A
		// (set) Token: 0x060182AD RID: 98989 RVA: 0x00384C72 File Offset: 0x00382E72
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

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x060182AE RID: 98990 RVA: 0x00384C7B File Offset: 0x00382E7B
		// (set) Token: 0x060182AF RID: 98991 RVA: 0x00384C83 File Offset: 0x00382E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosSender
		{
			get
			{
				return this.posSender_;
			}
			set
			{
				this.posSender_ = value;
			}
		}

		// Token: 0x060182B0 RID: 98992 RVA: 0x00384C8C File Offset: 0x00382E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderNotify);
		}

		// Token: 0x060182B1 RID: 98993 RVA: 0x00384C9A File Offset: 0x00382E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PosSender == other.PosSender && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182B2 RID: 98994 RVA: 0x00384CD8 File Offset: 0x00382ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PosSender != 0)
			{
				num ^= this.PosSender.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060182B3 RID: 98995 RVA: 0x00384D30 File Offset: 0x00382F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182B4 RID: 98996 RVA: 0x00384D3D File Offset: 0x00382F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182B5 RID: 98997 RVA: 0x00384D48 File Offset: 0x00382F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.PosSender != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PosSender);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182B6 RID: 98998 RVA: 0x00384DA4 File Offset: 0x00382FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PosSender != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosSender);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060182B7 RID: 98999 RVA: 0x00384DFC File Offset: 0x00382FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PosSender != 0)
			{
				this.PosSender = other.PosSender;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060182B8 RID: 99000 RVA: 0x00384E4C File Offset: 0x0038304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182B9 RID: 99001 RVA: 0x00384E58 File Offset: 0x00383058
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PosSender = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008FCD RID: 36813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FCE RID: 36814
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04008FCF RID: 36815
		private long entityId_;

		// Token: 0x04008FD0 RID: 36816
		public const int PosSenderFieldNumber = 14;

		// Token: 0x04008FD1 RID: 36817
		private int posSender_;
	}
}
