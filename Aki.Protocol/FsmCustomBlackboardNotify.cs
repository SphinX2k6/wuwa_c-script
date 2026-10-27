using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066B RID: 1643
	[NetMessage(EMessageId.FsmCustomBlackboardNotify)]
	public sealed class FsmCustomBlackboardNotify : IMessage<FsmCustomBlackboardNotify>, IMessage, IEquatable<FsmCustomBlackboardNotify>, IDeepCloneable<FsmCustomBlackboardNotify>, IBufferMessage
	{
		// Token: 0x060096B7 RID: 38583 RVA: 0x0016B851 File Offset: 0x00169A51
		[NullableContext(1)]
		public static FsmCustomBlackboardNotify Create()
		{
			return new FsmCustomBlackboardNotify();
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0016B858 File Offset: 0x00169A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x060096B9 RID: 38585 RVA: 0x0016B85B File Offset: 0x00169A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmCustomBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x0016B862 File Offset: 0x00169A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify()
		{
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x0016B86A File Offset: 0x00169A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify(FsmCustomBlackboardNotify other) : this()
		{
			this.fsmCustomBlackboardDatas_ = ((other.fsmCustomBlackboardDatas_ != null) ? other.fsmCustomBlackboardDatas_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x0016B89F File Offset: 0x00169A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardNotify Clone()
		{
			return new FsmCustomBlackboardNotify(this);
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x060096BD RID: 38589 RVA: 0x0016B8A7 File Offset: 0x00169AA7
		// (set) Token: 0x060096BE RID: 38590 RVA: 0x0016B8AF File Offset: 0x00169AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmCustomBlackboardDatas FsmCustomBlackboardDatas
		{
			get
			{
				return this.fsmCustomBlackboardDatas_;
			}
			set
			{
				this.fsmCustomBlackboardDatas_ = value;
			}
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x0016B8B8 File Offset: 0x00169AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmCustomBlackboardNotify);
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x0016B8C6 File Offset: 0x00169AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmCustomBlackboardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FsmCustomBlackboardDatas, other.FsmCustomBlackboardDatas) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x0016B8FC File Offset: 0x00169AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num ^= this.FsmCustomBlackboardDatas.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x0016B938 File Offset: 0x00169B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x0016B945 File Offset: 0x00169B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x0016B94E File Offset: 0x00169B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x0016B980 File Offset: 0x00169B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fsmCustomBlackboardDatas_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FsmCustomBlackboardDatas);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x0016B9C0 File Offset: 0x00169BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmCustomBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fsmCustomBlackboardDatas_ != null)
			{
				if (this.fsmCustomBlackboardDatas_ == null)
				{
					this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
				}
				this.FsmCustomBlackboardDatas.MergeFrom(other.FsmCustomBlackboardDatas);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0016BA14 File Offset: 0x00169C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x0016BA20 File Offset: 0x00169C20
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fsmCustomBlackboardDatas_ == null)
					{
						this.FsmCustomBlackboardDatas = new FsmCustomBlackboardDatas();
					}
					input.ReadMessage(this.FsmCustomBlackboardDatas);
				}
			}
		}

		// Token: 0x040047C6 RID: 18374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C7 RID: 18375
		public const int FsmCustomBlackboardDatasFieldNumber = 9;

		// Token: 0x040047C8 RID: 18376
		private FsmCustomBlackboardDatas fsmCustomBlackboardDatas_;
	}
}
