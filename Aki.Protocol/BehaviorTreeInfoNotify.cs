using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019B RID: 411
	[NetMessage(EMessageId.BehaviorTreeInfoNotify)]
	public sealed class BehaviorTreeInfoNotify : IMessage<BehaviorTreeInfoNotify>, IMessage, IEquatable<BehaviorTreeInfoNotify>, IDeepCloneable<BehaviorTreeInfoNotify>, IBufferMessage
	{
		// Token: 0x060030DC RID: 12508 RVA: 0x0007CDD5 File Offset: 0x0007AFD5
		[NullableContext(1)]
		public static BehaviorTreeInfoNotify Create()
		{
			return new BehaviorTreeInfoNotify();
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x0007CDDF File Offset: 0x0007AFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeInfoNotify.Descriptor;
			}
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0007CDE6 File Offset: 0x0007AFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify()
		{
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0007CDF9 File Offset: 0x0007AFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify(BehaviorTreeInfoNotify other) : this()
		{
			this.treeInfos_ = other.treeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0007CE23 File Offset: 0x0007B023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeInfoNotify Clone()
		{
			return new BehaviorTreeInfoNotify(this);
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x0007CE2B File Offset: 0x0007B02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreeInfo> TreeInfos
		{
			get
			{
				return this.treeInfos_;
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0007CE33 File Offset: 0x0007B033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeInfoNotify);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0007CE41 File Offset: 0x0007B041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeInfoNotify other)
		{
			return other != null && (other == this || (this.treeInfos_.Equals(other.treeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0007CE74 File Offset: 0x0007B074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.treeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0007CEA8 File Offset: 0x0007B0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0007CEB5 File Offset: 0x0007B0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0007CEBE File Offset: 0x0007B0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.treeInfos_.WriteTo(ref output, BehaviorTreeInfoNotify._repeated_treeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0007CEE8 File Offset: 0x0007B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.treeInfos_.CalculateSize(BehaviorTreeInfoNotify._repeated_treeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0007CF21 File Offset: 0x0007B121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BehaviorTreeInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.treeInfos_.Add(other.treeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x0007CF4F File Offset: 0x0007B14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0007CF58 File Offset: 0x0007B158
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.treeInfos_.AddEntriesFrom(ref input, BehaviorTreeInfoNotify._repeated_treeInfos_codec);
				}
			}
		}

		// Token: 0x04002967 RID: 10599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002968 RID: 10600
		public const int TreeInfosFieldNumber = 5;

		// Token: 0x04002969 RID: 10601
		private static readonly FieldCodec<TreeInfo> _repeated_treeInfos_codec = FieldCodec.ForMessage<TreeInfo>(42U, TreeInfo.Parser);

		// Token: 0x0400296A RID: 10602
		private readonly RepeatedField<TreeInfo> treeInfos_ = new RepeatedField<TreeInfo>();
	}
}
