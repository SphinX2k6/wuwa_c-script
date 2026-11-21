using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000201 RID: 513
	[NetMessage(EMessageId.BuffEffectExecuteRequest)]
	public sealed class BuffEffectExecuteRequest : IMessage<BuffEffectExecuteRequest>, IMessage, IEquatable<BuffEffectExecuteRequest>, IDeepCloneable<BuffEffectExecuteRequest>, IBufferMessage
	{
		// Token: 0x0600390D RID: 14605 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
		[NullableContext(1)]
		public static BuffEffectExecuteRequest Create()
		{
			return new BuffEffectExecuteRequest();
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x0008EBAF File Offset: 0x0008CDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0008EBB2 File Offset: 0x0008CDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecuteRequest.Descriptor;
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0008EBB9 File Offset: 0x0008CDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest()
		{
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0008EBC4 File Offset: 0x0008CDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest(BuffEffectExecuteRequest other) : this()
		{
			this.index_ = other.index_;
			this.context_ = ((other.context_ != null) ? other.context_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x0008EC10 File Offset: 0x0008CE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteRequest Clone()
		{
			return new BuffEffectExecuteRequest(this);
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x0008EC18 File Offset: 0x0008CE18
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0008EC20 File Offset: 0x0008CE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0008EC29 File Offset: 0x0008CE29
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x0008EC31 File Offset: 0x0008CE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext Context
		{
			get
			{
				return this.context_;
			}
			set
			{
				this.context_ = value;
			}
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0008EC3A File Offset: 0x0008CE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecuteRequest);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0008EC48 File Offset: 0x0008CE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecuteRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.Context, other.Context) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0008EC98 File Offset: 0x0008CE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.context_ != null)
			{
				num ^= this.Context.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0008ECED File Offset: 0x0008CEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0008ECFA File Offset: 0x0008CEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x0008ED04 File Offset: 0x0008CF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.context_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Context);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0008ED60 File Offset: 0x0008CF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.context_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Context);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0008EDB8 File Offset: 0x0008CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecuteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.context_ != null)
			{
				if (this.context_ == null)
				{
					this.Context = new FightBuffEffectContext();
				}
				this.Context.MergeFrom(other.Context);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x0008EE20 File Offset: 0x0008D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0008EE2C File Offset: 0x0008D02C
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
				if (num != 58U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.context_ == null)
					{
						this.Context = new FightBuffEffectContext();
					}
					input.ReadMessage(this.Context);
				}
			}
		}

		// Token: 0x04002BB7 RID: 11191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB8 RID: 11192
		public const int IndexFieldNumber = 14;

		// Token: 0x04002BB9 RID: 11193
		private int index_;

		// Token: 0x04002BBA RID: 11194
		public const int ContextFieldNumber = 7;

		// Token: 0x04002BBB RID: 11195
		private FightBuffEffectContext context_;
	}
}
