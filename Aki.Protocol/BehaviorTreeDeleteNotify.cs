using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019A RID: 410
	[NetMessage(EMessageId.BehaviorTreeDeleteNotify)]
	public sealed class BehaviorTreeDeleteNotify : IMessage<BehaviorTreeDeleteNotify>, IMessage, IEquatable<BehaviorTreeDeleteNotify>, IDeepCloneable<BehaviorTreeDeleteNotify>, IBufferMessage
	{
		// Token: 0x060030CA RID: 12490 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		[NullableContext(1)]
		public static BehaviorTreeDeleteNotify Create()
		{
			return new BehaviorTreeDeleteNotify();
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x0007CBFB File Offset: 0x0007ADFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x0007CBFE File Offset: 0x0007ADFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeDeleteNotify.Descriptor;
			}
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0007CC05 File Offset: 0x0007AE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify()
		{
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0007CC18 File Offset: 0x0007AE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify(BehaviorTreeDeleteNotify other) : this()
		{
			this.treeIncIds_ = other.treeIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0007CC42 File Offset: 0x0007AE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify Clone()
		{
			return new BehaviorTreeDeleteNotify(this);
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x0007CC4A File Offset: 0x0007AE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> TreeIncIds
		{
			get
			{
				return this.treeIncIds_;
			}
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0007CC52 File Offset: 0x0007AE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeDeleteNotify);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0007CC60 File Offset: 0x0007AE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeDeleteNotify other)
		{
			return other != null && (other == this || (this.treeIncIds_.Equals(other.treeIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0007CC94 File Offset: 0x0007AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.treeIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0007CCC8 File Offset: 0x0007AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0007CCD5 File Offset: 0x0007AED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0007CCDE File Offset: 0x0007AEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.treeIncIds_.WriteTo(ref output, BehaviorTreeDeleteNotify._repeated_treeIncIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0007CD08 File Offset: 0x0007AF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.treeIncIds_.CalculateSize(BehaviorTreeDeleteNotify._repeated_treeIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0007CD41 File Offset: 0x0007AF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BehaviorTreeDeleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.treeIncIds_.Add(other.treeIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0007CD6F File Offset: 0x0007AF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0007CD78 File Offset: 0x0007AF78
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.treeIncIds_.AddEntriesFrom(ref input, BehaviorTreeDeleteNotify._repeated_treeIncIds_codec);
				}
			}
		}

		// Token: 0x04002963 RID: 10595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002964 RID: 10596
		public const int TreeIncIdsFieldNumber = 8;

		// Token: 0x04002965 RID: 10597
		private static readonly FieldCodec<long> _repeated_treeIncIds_codec = FieldCodec.ForInt64(66U);

		// Token: 0x04002966 RID: 10598
		private readonly RepeatedField<long> treeIncIds_ = new RepeatedField<long>();
	}
}
