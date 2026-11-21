using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FB RID: 2555
	[NetMessage(EMessageId.MonthCardRequest)]
	public sealed class MonthCardRequest : IMessage<MonthCardRequest>, IMessage, IEquatable<MonthCardRequest>, IDeepCloneable<MonthCardRequest>, IBufferMessage
	{
		// Token: 0x0600DFEC RID: 57324 RVA: 0x0020D4DA File Offset: 0x0020B6DA
		[NullableContext(1)]
		public static MonthCardRequest Create()
		{
			return new MonthCardRequest();
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600DFED RID: 57325 RVA: 0x0020D4E1 File Offset: 0x0020B6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600DFEE RID: 57326 RVA: 0x0020D4E4 File Offset: 0x0020B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardRequest.Descriptor;
			}
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x0020D4EB File Offset: 0x0020B6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest()
		{
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x0020D4F3 File Offset: 0x0020B6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest(MonthCardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x0020D50C File Offset: 0x0020B70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest Clone()
		{
			return new MonthCardRequest(this);
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x0020D514 File Offset: 0x0020B714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardRequest);
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x0020D522 File Offset: 0x0020B722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x0020D540 File Offset: 0x0020B740
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

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0020D566 File Offset: 0x0020B766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x0020D573 File Offset: 0x0020B773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x0020D57C File Offset: 0x0020B77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x0020D594 File Offset: 0x0020B794
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

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x0020D5BA File Offset: 0x0020B7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFFA RID: 57338 RVA: 0x0020D5D7 File Offset: 0x0020B7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x0020D5E0 File Offset: 0x0020B7E0
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

		// Token: 0x04005C93 RID: 23699
		private UnknownFieldSet _unknownFields;
	}
}
