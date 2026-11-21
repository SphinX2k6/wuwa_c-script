using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA0 RID: 3744
	[NetMessage(EMessageId.RecallItemUseRequest)]
	public sealed class RecallItemUseRequest : IMessage<RecallItemUseRequest>, IMessage, IEquatable<RecallItemUseRequest>, IDeepCloneable<RecallItemUseRequest>, IBufferMessage
	{
		// Token: 0x060141F2 RID: 82418 RVA: 0x002EE2F9 File Offset: 0x002EC4F9
		[NullableContext(1)]
		public static RecallItemUseRequest Create()
		{
			return new RecallItemUseRequest();
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x060141F3 RID: 82419 RVA: 0x002EE300 File Offset: 0x002EC500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x060141F4 RID: 82420 RVA: 0x002EE303 File Offset: 0x002EC503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemUseRequest.Descriptor;
			}
		}

		// Token: 0x060141F5 RID: 82421 RVA: 0x002EE30A File Offset: 0x002EC50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest()
		{
		}

		// Token: 0x060141F6 RID: 82422 RVA: 0x002EE312 File Offset: 0x002EC512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest(RecallItemUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141F7 RID: 82423 RVA: 0x002EE343 File Offset: 0x002EC543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest Clone()
		{
			return new RecallItemUseRequest(this);
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x060141F8 RID: 82424 RVA: 0x002EE34B File Offset: 0x002EC54B
		// (set) Token: 0x060141F9 RID: 82425 RVA: 0x002EE353 File Offset: 0x002EC553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x060141FA RID: 82426 RVA: 0x002EE35C File Offset: 0x002EC55C
		// (set) Token: 0x060141FB RID: 82427 RVA: 0x002EE364 File Offset: 0x002EC564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060141FC RID: 82428 RVA: 0x002EE36D File Offset: 0x002EC56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemUseRequest);
		}

		// Token: 0x060141FD RID: 82429 RVA: 0x002EE37B File Offset: 0x002EC57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141FE RID: 82430 RVA: 0x002EE3BC File Offset: 0x002EC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060141FF RID: 82431 RVA: 0x002EE414 File Offset: 0x002EC614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014200 RID: 82432 RVA: 0x002EE421 File Offset: 0x002EC621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014201 RID: 82433 RVA: 0x002EE42C File Offset: 0x002EC62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014202 RID: 82434 RVA: 0x002EE488 File Offset: 0x002EC688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014203 RID: 82435 RVA: 0x002EE4E0 File Offset: 0x002EC6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemUseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014204 RID: 82436 RVA: 0x002EE530 File Offset: 0x002EC730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014205 RID: 82437 RVA: 0x002EE53C File Offset: 0x002EC73C
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B0C RID: 31500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B0D RID: 31501
		public const int CountFieldNumber = 15;

		// Token: 0x04007B0E RID: 31502
		private int count_;

		// Token: 0x04007B0F RID: 31503
		public const int ItemIdFieldNumber = 9;

		// Token: 0x04007B10 RID: 31504
		private int itemId_;
	}
}
