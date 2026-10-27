using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C1 RID: 4545
	public sealed class SelectViewOp : IMessage<SelectViewOp>, IMessage, IEquatable<SelectViewOp>, IDeepCloneable<SelectViewOp>, IBufferMessage
	{
		// Token: 0x06018406 RID: 99334 RVA: 0x00387CC2 File Offset: 0x00385EC2
		[NullableContext(1)]
		public static SelectViewOp Create()
		{
			return new SelectViewOp();
		}

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x06018407 RID: 99335 RVA: 0x00387CC9 File Offset: 0x00385EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051B5 RID: 20917
		// (get) Token: 0x06018408 RID: 99336 RVA: 0x00387CCC File Offset: 0x00385ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectViewOp.Descriptor;
			}
		}

		// Token: 0x06018409 RID: 99337 RVA: 0x00387CD3 File Offset: 0x00385ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp()
		{
		}

		// Token: 0x0601840A RID: 99338 RVA: 0x00387CDB File Offset: 0x00385EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp(SelectViewOp other) : this()
		{
			this.rogueResOption_ = ((other.rogueResOption_ != null) ? other.rogueResOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601840B RID: 99339 RVA: 0x00387D10 File Offset: 0x00385F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp Clone()
		{
			return new SelectViewOp(this);
		}

		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x0601840C RID: 99340 RVA: 0x00387D18 File Offset: 0x00385F18
		// (set) Token: 0x0601840D RID: 99341 RVA: 0x00387D20 File Offset: 0x00385F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOption RogueResOption
		{
			get
			{
				return this.rogueResOption_;
			}
			set
			{
				this.rogueResOption_ = value;
			}
		}

		// Token: 0x0601840E RID: 99342 RVA: 0x00387D29 File Offset: 0x00385F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectViewOp);
		}

		// Token: 0x0601840F RID: 99343 RVA: 0x00387D37 File Offset: 0x00385F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectViewOp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResOption, other.RogueResOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018410 RID: 99344 RVA: 0x00387D6C File Offset: 0x00385F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResOption_ != null)
			{
				num ^= this.RogueResOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018411 RID: 99345 RVA: 0x00387DA8 File Offset: 0x00385FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018412 RID: 99346 RVA: 0x00387DB5 File Offset: 0x00385FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018413 RID: 99347 RVA: 0x00387DBE File Offset: 0x00385FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018414 RID: 99348 RVA: 0x00387DF0 File Offset: 0x00385FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018415 RID: 99349 RVA: 0x00387E30 File Offset: 0x00386030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectViewOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResOption_ != null)
			{
				if (this.rogueResOption_ == null)
				{
					this.RogueResOption = new RogueResOption();
				}
				this.RogueResOption.MergeFrom(other.RogueResOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018416 RID: 99350 RVA: 0x00387E84 File Offset: 0x00386084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018417 RID: 99351 RVA: 0x00387E90 File Offset: 0x00386090
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueResOption_ == null)
					{
						this.RogueResOption = new RogueResOption();
					}
					input.ReadMessage(this.RogueResOption);
				}
			}
		}

		// Token: 0x04008FC7 RID: 36807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FC8 RID: 36808
		public const int RogueResOptionFieldNumber = 1;

		// Token: 0x04008FC9 RID: 36809
		private RogueResOption rogueResOption_;
	}
}
