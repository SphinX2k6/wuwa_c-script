using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001029 RID: 4137
	public sealed class RogueViewUnit : IMessage<RogueViewUnit>, IMessage, IEquatable<RogueViewUnit>, IDeepCloneable<RogueViewUnit>, IBufferMessage
	{
		// Token: 0x060161C3 RID: 90563 RVA: 0x003365E9 File Offset: 0x003347E9
		[NullableContext(1)]
		public static RogueViewUnit Create()
		{
			return new RogueViewUnit();
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x060161C4 RID: 90564 RVA: 0x003365F0 File Offset: 0x003347F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueViewUnit> Parser
		{
			get
			{
				return RogueViewUnit._parser;
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x060161C5 RID: 90565 RVA: 0x003365F7 File Offset: 0x003347F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x060161C6 RID: 90566 RVA: 0x003365FA File Offset: 0x003347FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewUnit.Descriptor;
			}
		}

		// Token: 0x060161C7 RID: 90567 RVA: 0x00336601 File Offset: 0x00334801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit()
		{
		}

		// Token: 0x060161C8 RID: 90568 RVA: 0x0033660C File Offset: 0x0033480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit(RogueViewUnit other) : this()
		{
			RogueViewUnit.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				if (dataCase == RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					this.ItemObtainNotify = other.ItemObtainNotify.Clone();
				}
			}
			else
			{
				this.RoguelikeEventGainNotify = other.RoguelikeEventGainNotify.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161C9 RID: 90569 RVA: 0x00336665 File Offset: 0x00334865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit Clone()
		{
			return new RogueViewUnit(this);
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x060161CA RID: 90570 RVA: 0x0033666D File Offset: 0x0033486D
		// (set) Token: 0x060161CB RID: 90571 RVA: 0x00336685 File Offset: 0x00334885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify RoguelikeEventGainNotify
		{
			get
			{
				if (this.dataCase_ != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
				{
					return null;
				}
				return (RoguelikeEventGainNotify)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueViewUnit.DataOneofCase.None : RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify);
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x060161CC RID: 90572 RVA: 0x0033669B File Offset: 0x0033489B
		// (set) Token: 0x060161CD RID: 90573 RVA: 0x003366B3 File Offset: 0x003348B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify ItemObtainNotify
		{
			get
			{
				if (this.dataCase_ != RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					return null;
				}
				return (ItemObtainNotify)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueViewUnit.DataOneofCase.None : RogueViewUnit.DataOneofCase.ItemObtainNotify);
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x060161CE RID: 90574 RVA: 0x003366C9 File Offset: 0x003348C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060161CF RID: 90575 RVA: 0x003366D1 File Offset: 0x003348D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueViewUnit.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060161D0 RID: 90576 RVA: 0x003366E1 File Offset: 0x003348E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewUnit);
		}

		// Token: 0x060161D1 RID: 90577 RVA: 0x003366F0 File Offset: 0x003348F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewUnit other)
		{
			return other != null && (other == this || (object.Equals(this.RoguelikeEventGainNotify, other.RoguelikeEventGainNotify) && object.Equals(this.ItemObtainNotify, other.ItemObtainNotify) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161D2 RID: 90578 RVA: 0x00336754 File Offset: 0x00334954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				num ^= this.RoguelikeEventGainNotify.GetHashCode();
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				num ^= this.ItemObtainNotify.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060161D3 RID: 90579 RVA: 0x003367B1 File Offset: 0x003349B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161D4 RID: 90580 RVA: 0x003367BE File Offset: 0x003349BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161D5 RID: 90581 RVA: 0x003367C8 File Offset: 0x003349C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoguelikeEventGainNotify);
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ItemObtainNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161D6 RID: 90582 RVA: 0x00336824 File Offset: 0x00334A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeEventGainNotify);
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemObtainNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161D7 RID: 90583 RVA: 0x0033687C File Offset: 0x00334A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueViewUnit other)
		{
			if (other == null)
			{
				return;
			}
			RogueViewUnit.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				if (dataCase == RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					if (this.ItemObtainNotify == null)
					{
						this.ItemObtainNotify = new ItemObtainNotify();
					}
					this.ItemObtainNotify.MergeFrom(other.ItemObtainNotify);
				}
			}
			else
			{
				if (this.RoguelikeEventGainNotify == null)
				{
					this.RoguelikeEventGainNotify = new RoguelikeEventGainNotify();
				}
				this.RoguelikeEventGainNotify.MergeFrom(other.RoguelikeEventGainNotify);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161D8 RID: 90584 RVA: 0x003368FF File Offset: 0x00334AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161D9 RID: 90585 RVA: 0x00336908 File Offset: 0x00334B08
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ItemObtainNotify itemObtainNotify = new ItemObtainNotify();
						if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
						{
							itemObtainNotify.MergeFrom(this.ItemObtainNotify);
						}
						input.ReadMessage(itemObtainNotify);
						this.ItemObtainNotify = itemObtainNotify;
					}
				}
				else
				{
					RoguelikeEventGainNotify roguelikeEventGainNotify = new RoguelikeEventGainNotify();
					if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
					{
						roguelikeEventGainNotify.MergeFrom(this.RoguelikeEventGainNotify);
					}
					input.ReadMessage(roguelikeEventGainNotify);
					this.RoguelikeEventGainNotify = roguelikeEventGainNotify;
				}
			}
		}

		// Token: 0x0400846D RID: 33901
		private static readonly MessageParser<RogueViewUnit> _parser = new MessageParser<RogueViewUnit>(() => new RogueViewUnit());

		// Token: 0x0400846E RID: 33902
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400846F RID: 33903
		public const int RoguelikeEventGainNotifyFieldNumber = 1;

		// Token: 0x04008470 RID: 33904
		public const int ItemObtainNotifyFieldNumber = 2;

		// Token: 0x04008471 RID: 33905
		private object data_;

		// Token: 0x04008472 RID: 33906
		private RogueViewUnit.DataOneofCase dataCase_;

		// Token: 0x02001943 RID: 6467
		public enum DataOneofCase
		{
			// Token: 0x0400C9A3 RID: 51619
			None,
			// Token: 0x0400C9A4 RID: 51620
			RoguelikeEventGainNotify,
			// Token: 0x0400C9A5 RID: 51621
			ItemObtainNotify
		}
	}
}
