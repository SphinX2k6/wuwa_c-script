using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E5 RID: 229
	[NetMessage(EMessageId.AnimalDieRequest)]
	public sealed class AnimalDieRequest : IMessage<AnimalDieRequest>, IMessage, IEquatable<AnimalDieRequest>, IDeepCloneable<AnimalDieRequest>, IBufferMessage
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x0005A884 File Offset: 0x00058A84
		[NullableContext(1)]
		public static AnimalDieRequest Create()
		{
			return new AnimalDieRequest();
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0005A88B File Offset: 0x00058A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0005A88E File Offset: 0x00058A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieRequest.Descriptor;
			}
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0005A895 File Offset: 0x00058A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest()
		{
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest(AnimalDieRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0005A8EC File Offset: 0x00058AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest Clone()
		{
			return new AnimalDieRequest(this);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0005A8F4 File Offset: 0x00058AF4
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x0005A8FC File Offset: 0x00058AFC
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x0005A905 File Offset: 0x00058B05
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0005A90D File Offset: 0x00058B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0005A916 File Offset: 0x00058B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieRequest);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0005A924 File Offset: 0x00058B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0005A974 File Offset: 0x00058B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0005A9C9 File Offset: 0x00058BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0005A9D6 File Offset: 0x00058BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0005A9E0 File Offset: 0x00058BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Pos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0005AA3C File Offset: 0x00058C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0005AA94 File Offset: 0x00058C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0005AAFC File Offset: 0x00058CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0005AB08 File Offset: 0x00058D08
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
				if (num != 98U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x040024A5 RID: 9381
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024A6 RID: 9382
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040024A7 RID: 9383
		private long entityId_;

		// Token: 0x040024A8 RID: 9384
		public const int PosFieldNumber = 12;

		// Token: 0x040024A9 RID: 9385
		private Vector pos_;
	}
}
