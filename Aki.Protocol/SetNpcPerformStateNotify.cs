using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001213 RID: 4627
	[NetMessage(EMessageId.SetNpcPerformStateNotify)]
	public sealed class SetNpcPerformStateNotify : IMessage<SetNpcPerformStateNotify>, IMessage, IEquatable<SetNpcPerformStateNotify>, IDeepCloneable<SetNpcPerformStateNotify>, IBufferMessage
	{
		// Token: 0x06018B69 RID: 101225 RVA: 0x0039A441 File Offset: 0x00398641
		[NullableContext(1)]
		public static SetNpcPerformStateNotify Create()
		{
			return new SetNpcPerformStateNotify();
		}

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x06018B6A RID: 101226 RVA: 0x0039A448 File Offset: 0x00398648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x06018B6B RID: 101227 RVA: 0x0039A44B File Offset: 0x0039864B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetNpcPerformStateNotify.Descriptor;
			}
		}

		// Token: 0x06018B6C RID: 101228 RVA: 0x0039A452 File Offset: 0x00398652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify()
		{
		}

		// Token: 0x06018B6D RID: 101229 RVA: 0x0039A470 File Offset: 0x00398670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify(SetNpcPerformStateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.type_ = other.type_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B6E RID: 101230 RVA: 0x0039A4AD File Offset: 0x003986AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify Clone()
		{
			return new SetNpcPerformStateNotify(this);
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x06018B6F RID: 101231 RVA: 0x0039A4B5 File Offset: 0x003986B5
		// (set) Token: 0x06018B70 RID: 101232 RVA: 0x0039A4BD File Offset: 0x003986BD
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

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x06018B71 RID: 101233 RVA: 0x0039A4C6 File Offset: 0x003986C6
		// (set) Token: 0x06018B72 RID: 101234 RVA: 0x0039A4CE File Offset: 0x003986CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x06018B73 RID: 101235 RVA: 0x0039A4E1 File Offset: 0x003986E1
		// (set) Token: 0x06018B74 RID: 101236 RVA: 0x0039A4E9 File Offset: 0x003986E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x0039A4FC File Offset: 0x003986FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetNpcPerformStateNotify);
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x0039A50C File Offset: 0x0039870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetNpcPerformStateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.Type != other.Type) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B77 RID: 101239 RVA: 0x0039A570 File Offset: 0x00398770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Type.Length != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B78 RID: 101240 RVA: 0x0039A5E5 File Offset: 0x003987E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B79 RID: 101241 RVA: 0x0039A5F2 File Offset: 0x003987F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B7A RID: 101242 RVA: 0x0039A5FC File Offset: 0x003987FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.State);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B7B RID: 101243 RVA: 0x0039A67C File Offset: 0x0039887C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Type.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B7C RID: 101244 RVA: 0x0039A6F4 File Offset: 0x003988F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetNpcPerformStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Type.Length != 0)
			{
				this.Type = other.Type;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B7D RID: 101245 RVA: 0x0039A762 File Offset: 0x00398962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B7E RID: 101246 RVA: 0x0039A76C File Offset: 0x0039896C
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
				if (num != 74U)
				{
					if (num != 80U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = input.ReadString();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.State = input.ReadString();
				}
			}
		}

		// Token: 0x040092B4 RID: 37556
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092B5 RID: 37557
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040092B6 RID: 37558
		private long entityId_;

		// Token: 0x040092B7 RID: 37559
		public const int TypeFieldNumber = 13;

		// Token: 0x040092B8 RID: 37560
		private string type_ = "";

		// Token: 0x040092B9 RID: 37561
		public const int StateFieldNumber = 9;

		// Token: 0x040092BA RID: 37562
		private string state_ = "";
	}
}
