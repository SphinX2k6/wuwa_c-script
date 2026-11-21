using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2F RID: 2863
	[NetMessage(EMessageId.NewTowerRecommendRequest)]
	public sealed class NewTowerRecommendRequest : IMessage<NewTowerRecommendRequest>, IMessage, IEquatable<NewTowerRecommendRequest>, IDeepCloneable<NewTowerRecommendRequest>, IBufferMessage
	{
		// Token: 0x0600F8C9 RID: 63689 RVA: 0x00244D0C File Offset: 0x00242F0C
		[NullableContext(1)]
		public static NewTowerRecommendRequest Create()
		{
			return new NewTowerRecommendRequest();
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x00244D13 File Offset: 0x00242F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600F8CB RID: 63691 RVA: 0x00244D16 File Offset: 0x00242F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x00244D1D File Offset: 0x00242F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest()
		{
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00244D25 File Offset: 0x00242F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest(NewTowerRecommendRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00244D3E File Offset: 0x00242F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendRequest Clone()
		{
			return new NewTowerRecommendRequest(this);
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00244D46 File Offset: 0x00242F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendRequest);
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00244D54 File Offset: 0x00242F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00244D74 File Offset: 0x00242F74
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

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00244D9A File Offset: 0x00242F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x00244DA7 File Offset: 0x00242FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x00244DB0 File Offset: 0x00242FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x00244DC8 File Offset: 0x00242FC8
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

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00244DEE File Offset: 0x00242FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00244E0B File Offset: 0x0024300B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00244E14 File Offset: 0x00243014
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

		// Token: 0x0400641B RID: 25627
		private UnknownFieldSet _unknownFields;
	}
}
