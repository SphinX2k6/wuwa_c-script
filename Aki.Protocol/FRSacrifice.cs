using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065C RID: 1628
	public sealed class FRSacrifice : IMessage<FRSacrifice>, IMessage, IEquatable<FRSacrifice>, IDeepCloneable<FRSacrifice>, IBufferMessage
	{
		// Token: 0x0600957C RID: 38268 RVA: 0x00168D3B File Offset: 0x00166F3B
		[NullableContext(1)]
		public static FRSacrifice Create()
		{
			return new FRSacrifice();
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x00168D42 File Offset: 0x00166F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x00168D45 File Offset: 0x00166F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRSacrifice.Descriptor;
			}
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x00168D4C File Offset: 0x00166F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice()
		{
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x00168D5F File Offset: 0x00166F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice(FRSacrifice other) : this()
		{
			this.actionList_ = other.actionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x00168D89 File Offset: 0x00166F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice Clone()
		{
			return new FRSacrifice(this);
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009582 RID: 38274 RVA: 0x00168D91 File Offset: 0x00166F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> ActionList
		{
			get
			{
				return this.actionList_;
			}
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x00168D99 File Offset: 0x00166F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRSacrifice);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x00168DA7 File Offset: 0x00166FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRSacrifice other)
		{
			return other != null && (other == this || (this.actionList_.Equals(other.actionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x00168DDC File Offset: 0x00166FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.actionList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00168E10 File Offset: 0x00167010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00168E1D File Offset: 0x0016701D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00168E26 File Offset: 0x00167026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.actionList_.WriteTo(ref output, FRSacrifice._repeated_actionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00168E50 File Offset: 0x00167050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actionList_.CalculateSize(FRSacrifice._repeated_actionList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00168E89 File Offset: 0x00167089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRSacrifice other)
		{
			if (other == null)
			{
				return;
			}
			this.actionList_.Add(other.actionList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x00168EB7 File Offset: 0x001670B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00168EC0 File Offset: 0x001670C0
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
					this.actionList_.AddEntriesFrom(ref input, FRSacrifice._repeated_actionList_codec);
				}
			}
		}

		// Token: 0x04004767 RID: 18279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004768 RID: 18280
		public const int ActionListFieldNumber = 1;

		// Token: 0x04004769 RID: 18281
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_actionList_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(10U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x0400476A RID: 18282
		private readonly RepeatedField<FloroRanchUnitActionMsg> actionList_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
