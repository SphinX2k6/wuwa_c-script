using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000766 RID: 1894
	[NetMessage(EMessageId.HonamiStoryInstLeaveRequest)]
	public sealed class HonamiStoryInstLeaveRequest : IMessage<HonamiStoryInstLeaveRequest>, IMessage, IEquatable<HonamiStoryInstLeaveRequest>, IDeepCloneable<HonamiStoryInstLeaveRequest>, IBufferMessage
	{
		// Token: 0x0600ABA4 RID: 43940 RVA: 0x0019D3B1 File Offset: 0x0019B5B1
		[NullableContext(1)]
		public static HonamiStoryInstLeaveRequest Create()
		{
			return new HonamiStoryInstLeaveRequest();
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x0600ABA5 RID: 43941 RVA: 0x0019D3B8 File Offset: 0x0019B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x0019D3BB File Offset: 0x0019B5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstLeaveRequest.Descriptor;
			}
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x0019D3C2 File Offset: 0x0019B5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest()
		{
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x0019D3CA File Offset: 0x0019B5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest(HonamiStoryInstLeaveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x0019D3E3 File Offset: 0x0019B5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest Clone()
		{
			return new HonamiStoryInstLeaveRequest(this);
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x0019D3EB File Offset: 0x0019B5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstLeaveRequest);
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x0019D3F9 File Offset: 0x0019B5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstLeaveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x0019D418 File Offset: 0x0019B618
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

		// Token: 0x0600ABAD RID: 43949 RVA: 0x0019D43E File Offset: 0x0019B63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x0019D44B File Offset: 0x0019B64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x0019D454 File Offset: 0x0019B654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x0019D46C File Offset: 0x0019B66C
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

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x0019D492 File Offset: 0x0019B692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstLeaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0019D4AF File Offset: 0x0019B6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x0019D4B8 File Offset: 0x0019B6B8
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

		// Token: 0x04004E44 RID: 20036
		private UnknownFieldSet _unknownFields;
	}
}
