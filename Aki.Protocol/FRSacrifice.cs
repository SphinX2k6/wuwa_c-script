using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000648 RID: 1608
	public sealed class FRSacrifice : IMessage<FRSacrifice>, IMessage, IEquatable<FRSacrifice>, IDeepCloneable<FRSacrifice>, IBufferMessage
	{
		// Token: 0x06009426 RID: 37926 RVA: 0x0016630F File Offset: 0x0016450F
		[NullableContext(1)]
		public static FRSacrifice Create()
		{
			return new FRSacrifice();
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06009427 RID: 37927 RVA: 0x00166316 File Offset: 0x00164516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06009428 RID: 37928 RVA: 0x00166319 File Offset: 0x00164519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRSacrifice.Descriptor;
			}
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x00166320 File Offset: 0x00164520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice()
		{
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x00166333 File Offset: 0x00164533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice(FRSacrifice other) : this()
		{
			this.actionList_ = other.actionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x0016635D File Offset: 0x0016455D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSacrifice Clone()
		{
			return new FRSacrifice(this);
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x00166365 File Offset: 0x00164565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> ActionList
		{
			get
			{
				return this.actionList_;
			}
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x0016636D File Offset: 0x0016456D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRSacrifice);
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x0016637B File Offset: 0x0016457B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRSacrifice other)
		{
			return other != null && (other == this || (this.actionList_.Equals(other.actionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x001663B0 File Offset: 0x001645B0
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

		// Token: 0x06009430 RID: 37936 RVA: 0x001663E4 File Offset: 0x001645E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x001663F1 File Offset: 0x001645F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x001663FA File Offset: 0x001645FA
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

		// Token: 0x06009433 RID: 37939 RVA: 0x00166424 File Offset: 0x00164624
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

		// Token: 0x06009434 RID: 37940 RVA: 0x0016645D File Offset: 0x0016465D
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

		// Token: 0x06009435 RID: 37941 RVA: 0x0016648B File Offset: 0x0016468B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00166494 File Offset: 0x00164694
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

		// Token: 0x04004760 RID: 18272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004761 RID: 18273
		public const int ActionListFieldNumber = 1;

		// Token: 0x04004762 RID: 18274
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_actionList_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(10U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x04004763 RID: 18275
		private readonly RepeatedField<FloroRanchUnitActionMsg> actionList_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
