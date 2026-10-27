using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000196 RID: 406
	[NetMessage(EMessageId.BehaviorTreeDeleteNotify)]
	public sealed class BehaviorTreeDeleteNotify : IMessage<BehaviorTreeDeleteNotify>, IMessage, IEquatable<BehaviorTreeDeleteNotify>, IDeepCloneable<BehaviorTreeDeleteNotify>, IBufferMessage
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x0007B488 File Offset: 0x00079688
		[NullableContext(1)]
		public static BehaviorTreeDeleteNotify Create()
		{
			return new BehaviorTreeDeleteNotify();
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x0007B48F File Offset: 0x0007968F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x0007B492 File Offset: 0x00079692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeDeleteNotify.Descriptor;
			}
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0007B499 File Offset: 0x00079699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify()
		{
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0007B4AC File Offset: 0x000796AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify(BehaviorTreeDeleteNotify other) : this()
		{
			this.treeIncIds_ = other.treeIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0007B4D6 File Offset: 0x000796D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeDeleteNotify Clone()
		{
			return new BehaviorTreeDeleteNotify(this);
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x0007B4DE File Offset: 0x000796DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> TreeIncIds
		{
			get
			{
				return this.treeIncIds_;
			}
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0007B4E6 File Offset: 0x000796E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeDeleteNotify);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0007B4F4 File Offset: 0x000796F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeDeleteNotify other)
		{
			return other != null && (other == this || (this.treeIncIds_.Equals(other.treeIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0007B528 File Offset: 0x00079728
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

		// Token: 0x06003047 RID: 12359 RVA: 0x0007B55C File Offset: 0x0007975C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0007B569 File Offset: 0x00079769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0007B572 File Offset: 0x00079772
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

		// Token: 0x0600304A RID: 12362 RVA: 0x0007B59C File Offset: 0x0007979C
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

		// Token: 0x0600304B RID: 12363 RVA: 0x0007B5D5 File Offset: 0x000797D5
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

		// Token: 0x0600304C RID: 12364 RVA: 0x0007B603 File Offset: 0x00079803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0007B60C File Offset: 0x0007980C
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.treeIncIds_.AddEntriesFrom(ref input, BehaviorTreeDeleteNotify._repeated_treeIncIds_codec);
				}
			}
		}

		// Token: 0x040028E8 RID: 10472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E9 RID: 10473
		public const int TreeIncIdsFieldNumber = 7;

		// Token: 0x040028EA RID: 10474
		private static readonly FieldCodec<long> _repeated_treeIncIds_codec = FieldCodec.ForInt64(58U);

		// Token: 0x040028EB RID: 10475
		private readonly RepeatedField<long> treeIncIds_ = new RepeatedField<long>();
	}
}
