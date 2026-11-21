using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B24 RID: 2852
	[NetMessage(EMessageId.NewTowerLastCycleInfoRequest)]
	public sealed class NewTowerLastCycleInfoRequest : IMessage<NewTowerLastCycleInfoRequest>, IMessage, IEquatable<NewTowerLastCycleInfoRequest>, IDeepCloneable<NewTowerLastCycleInfoRequest>, IBufferMessage
	{
		// Token: 0x0600F7EB RID: 63467 RVA: 0x002430C1 File Offset: 0x002412C1
		[NullableContext(1)]
		public static NewTowerLastCycleInfoRequest Create()
		{
			return new NewTowerLastCycleInfoRequest();
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600F7EC RID: 63468 RVA: 0x002430C8 File Offset: 0x002412C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600F7ED RID: 63469 RVA: 0x002430CB File Offset: 0x002412CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLastCycleInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600F7EE RID: 63470 RVA: 0x002430D2 File Offset: 0x002412D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest()
		{
		}

		// Token: 0x0600F7EF RID: 63471 RVA: 0x002430DA File Offset: 0x002412DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest(NewTowerLastCycleInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x002430F3 File Offset: 0x002412F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoRequest Clone()
		{
			return new NewTowerLastCycleInfoRequest(this);
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x002430FB File Offset: 0x002412FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLastCycleInfoRequest);
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x00243109 File Offset: 0x00241309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLastCycleInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F7F3 RID: 63475 RVA: 0x00243128 File Offset: 0x00241328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F7F4 RID: 63476 RVA: 0x0024314E File Offset: 0x0024134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7F5 RID: 63477 RVA: 0x0024315B File Offset: 0x0024135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7F6 RID: 63478 RVA: 0x00243164 File Offset: 0x00241364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7F7 RID: 63479 RVA: 0x0024317C File Offset: 0x0024137C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F7F8 RID: 63480 RVA: 0x002431A2 File Offset: 0x002413A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLastCycleInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F7F9 RID: 63481 RVA: 0x002431BF File Offset: 0x002413BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7FA RID: 63482 RVA: 0x002431C8 File Offset: 0x002413C8
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040063DF RID: 25567
		private UnknownFieldSet _unknownFields;
	}
}
