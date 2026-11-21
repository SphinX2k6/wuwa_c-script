using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE7 RID: 4071
	[NetMessage(EMessageId.RogueResMoveRequest)]
	public sealed class RogueResMoveRequest : IMessage<RogueResMoveRequest>, IMessage, IEquatable<RogueResMoveRequest>, IDeepCloneable<RogueResMoveRequest>, IBufferMessage
	{
		// Token: 0x06015CA3 RID: 89251 RVA: 0x0032ADA0 File Offset: 0x00328FA0
		[NullableContext(1)]
		public static RogueResMoveRequest Create()
		{
			return new RogueResMoveRequest();
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x06015CA4 RID: 89252 RVA: 0x0032ADA7 File Offset: 0x00328FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06015CA5 RID: 89253 RVA: 0x0032ADAA File Offset: 0x00328FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoveRequest.Descriptor;
			}
		}

		// Token: 0x06015CA6 RID: 89254 RVA: 0x0032ADB1 File Offset: 0x00328FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest()
		{
		}

		// Token: 0x06015CA7 RID: 89255 RVA: 0x0032ADB9 File Offset: 0x00328FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest(RogueResMoveRequest other) : this()
		{
			this.moveOp_ = ((other.moveOp_ != null) ? other.moveOp_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CA8 RID: 89256 RVA: 0x0032ADEE File Offset: 0x00328FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest Clone()
		{
			return new RogueResMoveRequest(this);
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06015CA9 RID: 89257 RVA: 0x0032ADF6 File Offset: 0x00328FF6
		// (set) Token: 0x06015CAA RID: 89258 RVA: 0x0032ADFE File Offset: 0x00328FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp MoveOp
		{
			get
			{
				return this.moveOp_;
			}
			set
			{
				this.moveOp_ = value;
			}
		}

		// Token: 0x06015CAB RID: 89259 RVA: 0x0032AE07 File Offset: 0x00329007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoveRequest);
		}

		// Token: 0x06015CAC RID: 89260 RVA: 0x0032AE15 File Offset: 0x00329015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoveRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MoveOp, other.MoveOp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CAD RID: 89261 RVA: 0x0032AE48 File Offset: 0x00329048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.moveOp_ != null)
			{
				num ^= this.MoveOp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CAE RID: 89262 RVA: 0x0032AE84 File Offset: 0x00329084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CAF RID: 89263 RVA: 0x0032AE91 File Offset: 0x00329091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CB0 RID: 89264 RVA: 0x0032AE9A File Offset: 0x0032909A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.moveOp_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MoveOp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CB1 RID: 89265 RVA: 0x0032AECC File Offset: 0x003290CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.moveOp_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveOp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CB2 RID: 89266 RVA: 0x0032AF0C File Offset: 0x0032910C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.moveOp_ != null)
			{
				if (this.moveOp_ == null)
				{
					this.MoveOp = new MoveOp();
				}
				this.MoveOp.MergeFrom(other.MoveOp);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CB3 RID: 89267 RVA: 0x0032AF60 File Offset: 0x00329160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CB4 RID: 89268 RVA: 0x0032AF6C File Offset: 0x0032916C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.moveOp_ == null)
					{
						this.MoveOp = new MoveOp();
					}
					input.ReadMessage(this.MoveOp);
				}
			}
		}

		// Token: 0x04008338 RID: 33592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008339 RID: 33593
		public const int MoveOpFieldNumber = 2;

		// Token: 0x0400833A RID: 33594
		private MoveOp moveOp_;
	}
}
