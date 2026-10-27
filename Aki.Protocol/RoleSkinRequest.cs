using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BD RID: 4285
	[NetMessage(EMessageId.RoleSkinRequest)]
	public sealed class RoleSkinRequest : IMessage<RoleSkinRequest>, IMessage, IEquatable<RoleSkinRequest>, IDeepCloneable<RoleSkinRequest>, IBufferMessage
	{
		// Token: 0x06016DFB RID: 93691 RVA: 0x003528EF File Offset: 0x00350AEF
		[NullableContext(1)]
		public static RoleSkinRequest Create()
		{
			return new RoleSkinRequest();
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x06016DFC RID: 93692 RVA: 0x003528F6 File Offset: 0x00350AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x06016DFD RID: 93693 RVA: 0x003528F9 File Offset: 0x00350AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinRequest.Descriptor;
			}
		}

		// Token: 0x06016DFE RID: 93694 RVA: 0x00352900 File Offset: 0x00350B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest()
		{
		}

		// Token: 0x06016DFF RID: 93695 RVA: 0x00352908 File Offset: 0x00350B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest(RoleSkinRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E00 RID: 93696 RVA: 0x00352921 File Offset: 0x00350B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest Clone()
		{
			return new RoleSkinRequest(this);
		}

		// Token: 0x06016E01 RID: 93697 RVA: 0x00352929 File Offset: 0x00350B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinRequest);
		}

		// Token: 0x06016E02 RID: 93698 RVA: 0x00352937 File Offset: 0x00350B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016E03 RID: 93699 RVA: 0x00352958 File Offset: 0x00350B58
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

		// Token: 0x06016E04 RID: 93700 RVA: 0x0035297E File Offset: 0x00350B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E05 RID: 93701 RVA: 0x0035298B File Offset: 0x00350B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E06 RID: 93702 RVA: 0x00352994 File Offset: 0x00350B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E07 RID: 93703 RVA: 0x003529AC File Offset: 0x00350BAC
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

		// Token: 0x06016E08 RID: 93704 RVA: 0x003529D2 File Offset: 0x00350BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x003529EF File Offset: 0x00350BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x003529F8 File Offset: 0x00350BF8
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

		// Token: 0x0400886C RID: 34924
		private UnknownFieldSet _unknownFields;
	}
}
