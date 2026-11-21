using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EA RID: 2538
	[NetMessage(EMessageId.MonsterDrownPush)]
	public sealed class MonsterDrownPush : IMessage<MonsterDrownPush>, IMessage, IEquatable<MonsterDrownPush>, IDeepCloneable<MonsterDrownPush>, IBufferMessage
	{
		// Token: 0x0600DE96 RID: 56982 RVA: 0x0020A889 File Offset: 0x00208A89
		[NullableContext(1)]
		public static MonsterDrownPush Create()
		{
			return new MonsterDrownPush();
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x0020A890 File Offset: 0x00208A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600DE98 RID: 56984 RVA: 0x0020A893 File Offset: 0x00208A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownPush.Descriptor;
			}
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x0020A89A File Offset: 0x00208A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush()
		{
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x0020A8A2 File Offset: 0x00208AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush(MonsterDrownPush other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x0020A8D7 File Offset: 0x00208AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush Clone()
		{
			return new MonsterDrownPush(this);
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600DE9C RID: 56988 RVA: 0x0020A8DF File Offset: 0x00208ADF
		// (set) Token: 0x0600DE9D RID: 56989 RVA: 0x0020A8E7 File Offset: 0x00208AE7
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

		// Token: 0x0600DE9E RID: 56990 RVA: 0x0020A8F0 File Offset: 0x00208AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownPush);
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x0020A8FE File Offset: 0x00208AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownPush other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x0020A934 File Offset: 0x00208B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0020A970 File Offset: 0x00208B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEA2 RID: 56994 RVA: 0x0020A97D File Offset: 0x00208B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x0020A986 File Offset: 0x00208B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x0020A9B8 File Offset: 0x00208BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x0020A9F8 File Offset: 0x00208BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDrownPush other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x0020AA4C File Offset: 0x00208C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0020AA58 File Offset: 0x00208C58
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04005C3C RID: 23612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C3D RID: 23613
		public const int PosFieldNumber = 6;

		// Token: 0x04005C3E RID: 23614
		private Vector pos_;
	}
}
