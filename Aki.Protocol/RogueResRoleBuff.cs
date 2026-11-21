using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF3 RID: 4083
	public sealed class RogueResRoleBuff : IMessage<RogueResRoleBuff>, IMessage, IEquatable<RogueResRoleBuff>, IDeepCloneable<RogueResRoleBuff>, IBufferMessage
	{
		// Token: 0x06015DC6 RID: 89542 RVA: 0x0032E201 File Offset: 0x0032C401
		[NullableContext(1)]
		public static RogueResRoleBuff Create()
		{
			return new RogueResRoleBuff();
		}

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x06015DC7 RID: 89543 RVA: 0x0032E208 File Offset: 0x0032C408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x06015DC8 RID: 89544 RVA: 0x0032E20B File Offset: 0x0032C40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoleBuff.Descriptor;
			}
		}

		// Token: 0x06015DC9 RID: 89545 RVA: 0x0032E212 File Offset: 0x0032C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff()
		{
		}

		// Token: 0x06015DCA RID: 89546 RVA: 0x0032E21A File Offset: 0x0032C41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff(RogueResRoleBuff other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DCB RID: 89547 RVA: 0x0032E24B File Offset: 0x0032C44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff Clone()
		{
			return new RogueResRoleBuff(this);
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x06015DCC RID: 89548 RVA: 0x0032E253 File Offset: 0x0032C453
		// (set) Token: 0x06015DCD RID: 89549 RVA: 0x0032E25B File Offset: 0x0032C45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x06015DCE RID: 89550 RVA: 0x0032E264 File Offset: 0x0032C464
		// (set) Token: 0x06015DCF RID: 89551 RVA: 0x0032E26C File Offset: 0x0032C46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06015DD0 RID: 89552 RVA: 0x0032E275 File Offset: 0x0032C475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoleBuff);
		}

		// Token: 0x06015DD1 RID: 89553 RVA: 0x0032E283 File Offset: 0x0032C483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoleBuff other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DD2 RID: 89554 RVA: 0x0032E2C4 File Offset: 0x0032C4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015DD3 RID: 89555 RVA: 0x0032E31C File Offset: 0x0032C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DD4 RID: 89556 RVA: 0x0032E329 File Offset: 0x0032C529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DD5 RID: 89557 RVA: 0x0032E334 File Offset: 0x0032C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DD6 RID: 89558 RVA: 0x0032E38C File Offset: 0x0032C58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015DD7 RID: 89559 RVA: 0x0032E3D8 File Offset: 0x0032C5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResRoleBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015DD8 RID: 89560 RVA: 0x0032E428 File Offset: 0x0032C628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DD9 RID: 89561 RVA: 0x0032E434 File Offset: 0x0032C634
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083A7 RID: 33703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083A8 RID: 33704
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040083A9 RID: 33705
		private int configId_;

		// Token: 0x040083AA RID: 33706
		public const int IsNewFieldNumber = 2;

		// Token: 0x040083AB RID: 33707
		private bool isNew_;
	}
}
